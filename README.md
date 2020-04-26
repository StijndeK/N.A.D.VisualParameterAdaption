# N.A.D. Visual Parameter Adaption
VPA is a tool designed to improve the process of testing and prototyping nonlinear audio for games with quick sound implementing functionality and a visual representation based interface. The time it takes to implement audio into nonlinear audio systems before being able to test it obstructs the workflow, which reduces the ability to experiment and try different things. Using a visual aproach, VPA allows for quick prototyping and improves interdisciplinary communication. Because audio is a nonvisual medium and is always experienced linearely, it can be hard to fully understand nonlinear audio system designs. Files are loaded automatically from a specific folder with certain parameters based on their names, using a functionality caried over from [N.A.D Automatic File Loading in Python](https://github.com/StijndeK/N.A.D.AutomaticSoundloader).

## Application to games
Experiments are applied to game projects that are currently being developed:
- [EXP3 video](https://streamable.com/434ev)
- [EXP4 video](https://streamable.com/wqf3h)
- [EXP5 video](https://streamable.com/uvkjxm)
- [EXP6 video](https://streamable.com/y6rm5e)

## N.A.D.
VPA is the second experiment for my thesis about: Tools for Designing Nonlinear Audio for Games. As a game audio designer I am hindered during my creative process, due to the discrepancy between the nonlinearity of my work and the linear character of standard audio production software. Standard linear audio production tools offer little to none nonlinear sequencing, transitioning, parameter adaption and probability functionalities. Furthermore, linear sequencers are not optimised to provide a visual representation of nonlinear systems. Existing standard middleware solutions focus less on tackling the obstructions in the design stage of a project. These issues cause testing and prototyping to take unnecessary amounts of time and obscures communication with collaborators. This obstructs the workflow and discourages innovation. 

#### Other N.A.D. tools & experiments
- [N.A.D Automatic File Loading in Python](https://github.com/StijndeK/N.A.D.AutomaticSoundloader)
- [N.A.D Procedural Audio System](https://github.com/StijndeK/N.A.D.ProceduralAudioSystem)

## Unity and C#
Because of the need for a visual interfase and the application of N.A.D. on games, VPA is build in Unity using the [FMOD Core API](https://fmod.com/resources/documentation-api?version=2.0&page=core-guide.html), which allows for quick prototyping with certain game-specific functionalities easily available.

## Example current version
- [EXP6 (latest version) video](https://streamable.com/uvkjxm)
<img width="1306" alt="VASD_EXP6" src="https://user-images.githubusercontent.com/31696336/79067862-d3f88280-7cc2-11ea-83de-1272f8238e1e.png">

## Dataflow
<img width="1261" alt="VASD_EXP6_Dataflow" src="https://user-images.githubusercontent.com/31696336/79068833-1f625f00-7cca-11ea-98f7-a95e34ac824b.png">

## Current status
As an investigation into using a visual approach to upgrade the process of designing nonlinear audio for games and communicating about them, VPA has reached it goal.

## Improvements
The project only scratches the surface of nonlinear gameaudio possibilities and its current version conditions the user quite heavily. Features to be added in the future include:
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
- easy implementation in games

