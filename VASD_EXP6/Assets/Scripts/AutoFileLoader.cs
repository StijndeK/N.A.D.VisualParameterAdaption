using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class AutoFileLoader : MonoBehaviour
{
    public List<string> fileNames;
    public static List<List<List<string>>> entries = new List<List<List<string>>>(); // TODO: dataset instead of 3d list

    public InputField inputFieldBPM;
    public InputField inputFieldBeats;

    public static int layerAmount;

    public static string textForOutput;

    public InputField folderLocationInput;
    public Button loadButton;
    public static string folderLocation = "../BounceLocation/";

    private void Start()
    {
        loadButton.onClick.AddListener(LoadButtonPressed);
    }

    void LoadButtonPressed()
    {
        folderLocation = folderLocationInput.text;
        print("new path set to: " + folderLocation);
    }

    public void ReadFiles()
    {
        DirectoryInfo dir = new DirectoryInfo("../BounceLocation");
        FileInfo[] info = dir.GetFiles("*.wav*");

        // get and initialise all sounds
        int oldValue = 0;
        foreach (FileInfo f in info)
        {
            fileNames.Add(f.Name);
            AudioPlayer.InitSound(f.Name);
            print(f.Name);

            // set layeramount by checking for highest layer
            if (int.Parse(f.Name[0].ToString()) > oldValue)
            {
                layerAmount = int.Parse(f.Name[0].ToString());
            }
        }

        // initialise lists for every layer
        for (int i = 0; i < layerAmount; i++)
        {
            entries.Add(new List<List<string>>());
            SoundSystem.transitionValues.Add(0);
            SoundSystem.layerActiveChecks.Add(0);
        }

        // parse list with layers and possible transitions
        textForOutput = textForOutput + "loaded files: ";
        for (int i = 0; i < fileNames.Count; i++)
        {
            textForOutput = textForOutput + "\n" + fileNames[i];

            // get transition possibilities for loop from filename
            string possibleTransitions = "";
            string tempName = fileNames[i].Remove(fileNames[i].Length - 4, 4);
            while (true)
            {
                int number;
                bool result = int.TryParse(tempName[tempName.Length - 1].ToString(), out number);
                if (result)
                {
                    possibleTransitions += number.ToString();
                    tempName = tempName.Remove(tempName.Length - 1, 1);
                }
                else
                {
                    break;
                }
            }

            entries[int.Parse(fileNames[i][0].ToString()) - 1].Add(new List<string> { fileNames[i], possibleTransitions });
        }
    }

    public float CalculateTime()
    {
        float beatsPerMinute = float.Parse(inputFieldBPM.text);
        float beatAmount = float.Parse(inputFieldBeats.text);

        return (60 / beatsPerMinute) * beatAmount;
    }
}