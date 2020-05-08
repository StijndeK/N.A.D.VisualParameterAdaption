using System.Collections.Generic;
using UnityEngine;
using FMOD;
using UnityEngine.UI;

public class SoundSystem : MonoBehaviour
{
    public static GameObject FileLoaderObject;

    public static List<int> transitionValues = new List<int>();

    private bool playing;
    private bool stopping;

    private float bpm;

    private bool startPlaying;
    private float loopTime;

    public Button playButton;
    bool firstPress = true;
    public Button pauseButton;
    public Slider volumeSlider; // TODO: exponential curve with db values

    private int boxText;

    public static string textForOutput;

    public static List<int> layerActiveChecks = new List<int>();

    void Start()
    {
        AudioPlayer.Start();

        // read and parse audio files
        FileLoaderObject = GameObject.FindGameObjectWithTag("fileloader");
        FileLoaderObject.GetComponent<AutoFileLoader>().ReadFiles();      

        // UI listeners
        playButton.onClick.AddListener(PlayButtonPressed);
        pauseButton.onClick.AddListener(PauseButtonPressed);
        volumeSlider.onValueChanged.AddListener(SliderMoved);

        // spawn boxes
        GameObject.FindGameObjectWithTag("spawncomponent").GetComponent<SpawnerSystem>().SpawnBoxes();
    }

    void Update()
    {
        if (startPlaying == true)
            GameLoop();
    }

    private void SliderMoved(float value)
    {
        AudioPlayer.channelgroup.setVolume(value);
    }

    public void PlayButtonPressed()
    {
        if (firstPress)         // start game on first
        {
            bpm = FileLoaderObject.GetComponent<AutoFileLoader>().CalculateTime();
            startPlaying = true;
            firstPress = false;
        }
        else
        {
            stopping = !stopping;
        }
        print("play");
        textForOutput = "play" + "\n" + textForOutput;
    }

    private void PauseButtonPressed()
    {
        print("pause (on next horizontal cycle)");
        textForOutput = "pause (on next horizontal cycle)" + textForOutput + "\n";
        stopping = !stopping;
    }

    public int SetBoxText()
    {
        boxText++;
        return boxText;
    }

    private void GameLoop()
    {
        // TODO: implement clock to send ticks

        // play tracks
        if (playing == false && stopping == false)
        {
            loopTime = Time.time + bpm;
            for (int layer = 0; layer < AutoFileLoader.layerAmount; layer++)
            {
                if (layerActiveChecks[layer] == 1)
                {
                    string currentTransitionOptions = AutoFileLoader.entries[layer][transitionValues[layer]][1];
                    int randomValue = Random.Range(1, (currentTransitionOptions.Length + 1));

                    // select transition option by applying the random value to the string with options
                    transitionValues[layer] = int.Parse(currentTransitionOptions[currentTransitionOptions.Length - randomValue].ToString()) - 1;

                    // play track if parameters (X & Y) are checked
                    if (SequencerSystem.CheckIfLayerShouldPlay(layer) == true)
                    {
                        AudioPlayer.PlayTrack(AutoFileLoader.entries[layer][transitionValues[layer]][0]);
                    }
                }
            }
            playing = true;
        }

        playing &= Time.time < loopTime;
    }
}