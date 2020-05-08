using System.Collections.Generic;
using FMOD;

public static class AudioPlayer
{
    static FMOD.System corSystem;
    public static ChannelGroup channelgroup;
    public static List<SoundHolder> sounds = new List<SoundHolder>();

    public static void Start()
    {
        corSystem = FMODUnity.RuntimeManager.CoreSystem;
        corSystem.getVersion(out _);
        corSystem.createChannelGroup("master", out channelgroup);
    }

    public static void PlayTrack(string filename)
    {

        var sound = sounds.Find(x => x.soundName == filename);
        corSystem.playSound(sound.sound, channelgroup, false, out Channel channel);

        UnityEngine.MonoBehaviour.print("playing: " + filename);
        SoundSystem.textForOutput = "playing: " + filename + "\n" + SoundSystem.textForOutput;
    }

    public static void InitSound(string fileName)
    {
        corSystem.createSound(AutoFileLoader.folderLocation + fileName, MODE.DEFAULT, out Sound tempSound);
        sounds.Add(new SoundHolder(tempSound, fileName));
    }
}

public class SoundHolder
{
    public Sound sound;
    public string soundName;

    public SoundHolder(Sound sound, string soundName)
    {
        this.sound = sound;
        this.soundName = soundName;
    }
}