# Wake Up Speaker

## Background

I recently bought a new sound system for my PC. The Logitech Z533.  
I'm actually very happy with the system, but it has one major drawback. It switches off after a certain amount of time without sound and goes into standby mode. Known as auto off or standby problem.
This is very annoying because the device has to be switched off and on again manually.  
My web research first brought up a [hardware hack](https://www.reddit.com/r/LogitechG/comments/1b5crbi/logitech_z533_auto_offstandbypower_save_disable/). But I didn't want to screw and solder on a new product.  
This article led me to a [software solution](https://veg.by/en/projects/soundkeeper/). Unfortunately, this did not work with my speaker with analog input.  
There are modes that play inaudible sounds, but I don't like that.  

In the end, [this description](https://spabbit.net/archives/972) gave me the idea. You have to increase the volume for a short time until the loudspeaker wakes up. The problem with this is that the required level must be so high that your ears hurt after waking up, the neighbors complain and the cat flees.

## Solution

My solution is a very small program that raises the volume for a short time and then lowers it again to the original value. The loudspeaker reacts to the wake-up with a delay. This is exactly what is utilized. The program reduces the volume before the loudspeaker starts to sound again.  

The program is a console application and must be started with exactly two parameters:

```
WakeUpSpeaker.exe volume=xx duration=yy
```

- xx: Volume in the range 0-100
- yy: Duration in milliseconds

Typical example:

```
WakeUpSpeaker.exe volume=80 duration=2000
```

This sets the volume to 80% for 2 seconds. The volume is then reset to the original value.

Play with the values until you are satisfied with the result.  

The solution will not only work with the Logitech Z533, but with any speaker that has a similar power save mode.

## Download and Installation

There is no installer. Everything is in the single exe file.  
Put it in a directory of your choice. Ideally one that is in the PATH environment variable.  
Download of the binary: [WakeUpSpeaker.exe](https://www.biondi.ch/downloads/WakeUpSpeaker/WakeUpSpeaker.exe)


## Warning

Do not use the program when the sound plays. The effect would be very unpleasant.

