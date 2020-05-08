# N.A.D. Visual Parameter Adaption
VPA uses a visual overview and interface along with the automatic file loading functionality carried over from [N.A.D Automatic File Loading](https://github.com/StijndeK/N.A.D.AutomaticSoundloader)
, to look into upgrading the process of prototyping nonlinear systems and improving (interdisciplinary) communication. Because audio is a nonvisual medium and therefore always is experienced linearely, it can prove difficult to fully understand nonlinear audio systems design.

## NADT
Procedural Audio System (working title) is the third experiment in a range of experiments meant to adress obstructions in the process of designing and prototyping nonlinear audiosystems. [Click here](http://sdkoning.com/PF/N.A.D.T..html) for more information on the project.

#### Other N.A.D. tools & experiments
- [N.A.D Automatic File Loading in Python](https://github.com/StijndeK/N.A.D.AutomaticSoundloader)
- [N.A.D Procedural Audio System](https://github.com/StijndeK/N.A.D.ProceduralAudioSystem)

## Example current version
![HighresScreenshot00046 copy](https://user-images.githubusercontent.com/31696336/81261235-fff5f200-903b-11ea-8ebb-8e6addefe3ef.png)

- [This video](https://streamable.com/y6rm5e) shows the latest version of the project used to test audio systems for project Rookery. A walking simulator type game currently under development.

### Older versions
- [EXP3 video](https://streamable.com/434ev)
- [EXP4 video](https://streamable.com/wqf3h)
- [EXP5 video](https://streamable.com/uvkjxm)
- [EXP6 video](https://streamable.com/y6rm5e)

## Dataflow
The program has 4 main components. The `Fileloader` loads the audiofiles and parses the information obtained from the filenames. The `Spawner` allows the user to spawn `Layers` containing horizontal loops with variations, that can be dragged into the `Sequencer`. The `Sequencer` checks if certain parameters are checked to see if and what sound needs to be played. The `Controler` eventually calls the audio.
<img width="1261" alt="VASD_EXP6_Dataflow" src="https://user-images.githubusercontent.com/31696336/79068833-1f625f00-7cca-11ea-98f7-a95e34ac824b.png">

Because of the need for a visual interfase and the application of N.A.D. on games, VPA is build in Unity using the FMOD Core API. This allows for quick prototyping.


## Current status & improvements
As an investigation into using a visual approach to upgrade the process of designing nonlinear audio for games and communicating about them, VPA has achieved its goal. However, the project only scratches the surface of nonlinear gameaudio possibilities and its current version conditions the user quite heavily into using certain techniques. Moreover, the current system could be more easily adaptable, mainly due to the Unity based 'objectcomponents approach'. This is also the reason [the next experiment](https://github.com/StijndeK/N.A.D.ProceduralAudioSystem) completely steps away from this approach.

Features to be added in the future include:
- Probability
- Sound to sound communication
- Dynamic layer lengths
- Other transition techniques
- Oneshot sounds 
- Layer containers
- DSP
- volume and panning
- mixing
- changing files from the program itself
- game context
- implementation in games (remove the extra step caused by middleware)

