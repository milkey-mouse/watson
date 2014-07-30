How to build the servo/computer interface
=========================================

**1.** Get out your servo, the audio cable, and one of your USB cables. Strip it like last time. Here's the picture again for reference:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/blinds/wires.png "USB cable wire diagram")

**2.** Wrap a wire around each of the 3 metal rings at the end of the cable, solder the connections you just made into place (be careful not to short any connections, of course), and label the wires based on which section they are soldered onto according to this diagram:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/lamp/audio-pinout.png "Audio cable end diagram")

**3.** Attach the wires marked "ground" and "speaker" to the end of the cable on your speaker as shown in this next diagram:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/lamp/speaker-pinout.png "Speaker cable end diagram")

(Or, if you just have a bare speaker with no cable and two wires, hook those up normally.)

**4.** Take the stranded wires from the USB cable and attach a solid-core wire to each, with both ends stripped. Of course, wrap some tape around each of these connections to prevent shorts.

**5.** Plug these wires into the servo, following the diagram below:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/lamp/servo-pinout.png "Servo cable pinout diagram")

**6.** Insulate each wire from each other by wrapping some more tape around the connections and then finally wrapping tape around the point where all three of the wires meet the servo cable's end connector.

**7.** Get your dimmer and use LOTS of tape to secure the servo to the side of it like in the picture below. Then, use whatever you have on hand (for me, an empty Chapstick container and hlf of a broken chopstick, a la Macgyver) to make a "finger" that sweeps over the dimmer control slider to turn the lights on.

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/lamp/servo-setup.jpg "Servo cable pinout diagram")

**8.** Test it! Plug in the other end of the original audio jack and then set your computer's volume to 100. Then, open [this sound file](https://github.com/milkey-mouse/watson/raw/master/server-files/Turn%20Light%20On.wav) and your servo should move. Try playing some music (remember to lower the volume first). It should come out of your speaker! (If it only comes out the left side of a stereo speaker, you need to short the bridge between the left and right channels. To do this, make sure some solder gets past the black line- from the tip, and into the middle.)

If it works, congratulations! Remember that you need to keep the volume high for normal operation. Next I would recommend using TurnLightOn.exe in the server-files folder instead of the raw audio clip. All of the code is already compiled for you, no changes necessary, but if you want to look at the (two lines of) code in the .exe then look in the code folder for lamp_code. The only real big reason for making the .exe for this is that the program that receives requests can only launch .exe's, and in a certain folder. Otherwise it just fetches the document for you.