How to set up the RC car's controller with the MaKey MaKey
==========================================================

**1.** *(Skip to step 2 if you're not using a MaKey MaKey.)* Follow [this guide on how to set up Arduino on a MaKey MaKey](https://learn.sparkfun.com/tutorials/makey-makey-advanced-guide/installing-the-arduino-addon), but if you're on WIndows 8 you may need to follow [this](http://dhakshinamoorthy.wordpress.com/2012/05/14/installing-an-unsigned-driver-in-windows-8-x64/) first.

**2.** Install (if not already installed) the Arduino editor. Then, open it up and select the correct COM port and board type.

**3.** Open up this file from the repo: watson/code/makey-makey/firmware/firmware.ino

**4.** Upload to your Arduino.

**5.** Unplug the Arduino and get out your project box. (Other 'duinos besides the MaKey MaKey might not fit along with the controller.)

**6.** Take out the batteries and unscrew the plastic shell off of your RC car. Take the circuit board out, being careful not to damage it or its connection to the battery compartment for the controller.

**7.** Remove the two joysticks, and any pieces that were attached, like plastic sliders with metal contacts on them. The screws to do so are normally on the back.

**8.** Use a paper towel to wipe off the grease on the vertical contacts of the PCB, which are the 3 largish copper-colored pads aligned vertically. (We're not going to do anything with the steering, but feel free to use it along with modified code as a guide for making a fully-functional computer-controlled RC car!)

**9.** Solder wires to each of the vertical pads you just cleaned off.

**10.** Connect the middle wire to two more wires, attaching one end to each 5V relay (on the switch part, not the power part).

**11.** Connect the wire from the top contact to one relay (relay A) and the wire from the bottom contact to another relay (relay B).

**12.** Connect one pin on each relay to ground on the Arduino.

**13.** Connect the last pin on relay A to pin 16 on the Arduino and connect the last pin on relay B to pin 15.

**14.** Make sure your controller has batteries, chack all of the connections, and then plug the Arduino back in. Make sure the correct firmware is running, then open the Serial Monitor with Ctrl+Shift+M. Send "U" to the Arduino to make the blinds go up, and send "D" to the Arduino to make the blinds go down. Doing one of these should work, but it may open and close too far.

**15.** To remedy the problem of the blinds opening/closing too much, try tweaking the values in the Arduino firmware for the delay() function until your blinds open and close with an amount that is to your liking.

Lastly, if you happen to have an Arduino and controller that fits (like the MaKey MaKey) then just cram it all into a box, make a hole for the USB port, screw on the top, plug in the USB cable, plug the other end into your computer, and turn it on again!

If, for some reason, any of this doesn't work, try checking the connections with three wires and the ones to the relays. Those came out a lot for me.

Here's a picture of my setup. Sorry about the blur.

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/makey-makey/completed-transmitter.jpg "My wheel-to-rod setup")
