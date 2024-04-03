For my final project, I would like to expand on a proof of concept I developed in my free time over the course of a week and a half during the summer. It is a VR interactive music experience inspired by the audience conducting Jacob Collier does at his live shows. Right now it’s called Choir Conductor VR. I don’t love the name, but I’ve yet to come up with anything better. Here’s the proof of concept:
https://www.youtube.com/watch?v=tdkDUZUYtH0

The premise is simple. Each ‘sectional’ can be told to sing one note higher or lower in a scale. They can be turned on and off and there can be as few or as many sectionals as I want. I did this using 3 (really 2) simple scripts that I entirely used ChatGPT to write. This was before I had taken “Introduction to Programming”, so there’s a lot that I’ll be able to do now that I couldn’t figure out before! The first is a simple activity toggler used by the green and red’ buttons’ and the other two increase/decrease the note value by one and ensure that it wraps back around. These are on all the grey buttons. I provided all 3 scripts as well as a screenshot of my FMOD session along with the upload of this assignment so you can see them if you want.

Another cool thing worth mentioning is that I’m going to get to meet Jacob after his show here in Boston on the 24th. I know he already saw my YouTube video of the tech demo (because he commented!) so it would be cool to get to show him a more realized version in person!

Some of the things I expect to accomplish in a good outcome are implementing a system that displays the current chord up in the air as well as note names underneath each sectional. Also I want to replace the choir samples with samples from Jacob Colliers new “Audience Choir” plugin that he released about a month ago. It’ll be cool to use samples from the actual audience choirs I’m simulating instead of the stock logic choir im using at present. I think I can also add the option to increase/decrease the number of sectionals to your can break the audience into more parts until you have a bunch of unique parts all around you. Also I want to try adding ray-casting instead of trigger-boxes. Having a proper ui is something I wanted at the time but didn’t know how to do so it’ll be nice to actually make that happen. More visual flair I want to add is color changing of the choir depending on pitch. I might also make them move a bit.

A better outcome will include adding support for multiple keys, and possibly controller haptics (vibration feedback when you interact). I hope to also find/make a better asset for the audience instead of stairs with capsules on them (made in tinkercad lol). I also want a way to cut off the entire choir at once. Im not sure of the best way to do this interface-wise, but I know how to do it technically in Wwise/FMOD. Additionally I want to make the hands articulate. I almost had this done in the proof of concept but it was causing some graphical bugs where the hands would duplicate so I scrapped it.

A best outcome will allow control over vowels and/or dynamics. To do this I will probably make it so that when you move your hands while holding the triggers, you control dynamics instead of pitch and perhaps rotating your hands/wrists changes vowel. I might also add gesture support instead of/in addition to ray-casting (tracks velocity and direction of controllers). Another thing Id like to add is automatic height calibration based on headset position (and if that doesn’t work, then wingspan)

Some research imma need to do:
Before, I partitioned my hard drive to be able to run windows thru bootcamp. I did this because thats the only way you can test in unity in vr. I later learned however that you can use virtual vr controllers on Mac to test without having to build each time so I might look into that. Additionally I’ll have to try to remember how I got the VR rig working and make sure I can still make that work

I also want to look into using Wwise instead of FMOD. The reason I want to switch to Wwise is because the FMOD system has a good bit of latency between triggering a note change and hearing the note change. Wwise might let me switch notes faster. I’ll see what I can do in Wwise but this would require a lot of backtracking — so much so that I’d probably just start over with a new project file altogether. If it’s faster though I’m doing it. Even if I have to learn the new API.