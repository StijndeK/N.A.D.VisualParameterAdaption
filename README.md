# N.A.D. Visual Parameter Adaption
VPA is a tool designed to improve the process of testing and prototyping nonlinear audio for games through the use of fast sound implementation functionality and a visual representation based interface. The time it takes to implement audio into nonlinear audio systems before being able to test it, obstructs the workflow. This obstructs the ability to experiment and try different things. Using a visual aproach, VPA allows for quick prototyping and improves interdisciplinary communication. Because audio is a nonvisual medium and is always experienced linearely, it can be hard to fully understand nonlinear audio system designs. Files are loaded automatically from a specific folder with certain parameters based on their names, using a functionality caried over from [N.A.D Automatic File Loading in Python](https://github.com/StijndeK/N.A.D.AutomaticSoundloader).

## N.A.D.
VPA is the second experiment for my thesis on: Tools for Designing Nonlinear Audio for Games. As a game audio designer I am hindered during my creative process, due to the discrepancy between the nonlinearity of my work and the linear character of standard audio production software. Standard linear audio production tools offer little to none nonlinear sequencing, transitioning, parameter adaption and probability functionalities. Furthermore, linear sequencers are not optimised to provide a visual representation of nonlinear systems. Existing standard middleware solutions focus less on tackling the obstructions in the design stage of a project. These issues cause testing and prototyping to take unnecessary amounts of time and obscures communication with collaborators. This obstructs the workflow and discourages innovation. 

#### Other N.A.D. tools & experiments
- [N.A.D Automatic File Loading in Python](https://github.com/StijndeK/N.A.D.AutomaticSoundloader)
- [N.A.D Procedural Audio System](https://github.com/StijndeK/N.A.D.ProceduralAudioSystem)

## Unity and C#
Because of the need for a visual interfase and the application of N.A.D. on games, VPA is build in Unity using the [FMOD Core API](https://fmod.com/resources/documentation-api?version=2.0&page=core-guide.html), which allows for quick prototyping with certain game-specific functionalities easily available.

## Example current version
- [This video](https://streamable.com/y6rm5e) shows the latest version of the project used to test audio systems for project Rookery. A walking simulator type game currently under development.
![HighresScreenshot00046 copy](https://user-images.githubusercontent.com/31696336/81261235-fff5f200-903b-11ea-8ebb-8e6addefe3ef.png)

### Older versions
- [EXP3 video](https://streamable.com/434ev)
- [EXP4 video](https://streamable.com/wqf3h)
- [EXP5 video](https://streamable.com/uvkjxm)
- [EXP6 video](https://streamable.com/y6rm5e)

## Dataflow
The program has 4 main components. The fileloader loads the audiofiles and parses the information obtained from the filenames in lists. The spawner allows the user to spawn `Layers` containing horizontal loops with variations. The sequencer checks if certain parameters are checked to see if and what sound needs to be played. The controler eventually calls the audio.
<img width="1261" alt="VASD_EXP6_Dataflow" src="https://user-images.githubusercontent.com/31696336/79068833-1f625f00-7cca-11ea-98f7-a95e34ac824b.png">

## Current status & improvements
As an investigation into using a visual approach to upgrade the process of the designing of and communicating about nonlinear audio for games, VPA has reached it goal. However, the project only scratches the surface of available nonlinear gameaudio techiniques and its current version conditions the user quite heavily. Features to be added in the future include:
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

