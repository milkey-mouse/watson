How to modify the remote to be computer-controllable
====================================================

*Obviously, before doing this tutorial, please plug the output of the relay into a surge strip with a test device (lamp, etc.) that you know will work when plugged in, and plug the input into the wall.*

**1.** Take the remote from the wall relay, test it, then put it on a table:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_1.png "Remote facing forwards")

**2.** Flip it over:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_back.png "Remote facing backwards")

**3.** Unscrew (and keep) this screw:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_back_screw.png "Remote's screw")

**4.** Pry off the front of the case:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/case_pry.jpg "Prying the case off")

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_open.png "Remote facing backwards")

**5.** Pry out the battery (and keep it, of course):

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/battery_pry.png "Prying out the battery")

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_nobattery.jpg "Battery out of the remote")

**6.** Carefully pry out the circuit board:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_tape_front.jpg "Remote facing backwards")

**7.** (I don't have a picture of this, since I disassembled mine to do this tutorial, and I had already soldered these) Since you want to be able to reassemble the remote if need be, you need a non-permanent solution for securing the wires onto the buttons. I simply made two largish solder blobs in the circled locations of this picture:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_solderguide.png "Circled locations are to be soldered")

(Picture is after the soldering had taken place)

**8.** Take your wire with alligator clips, cut it in half, and strip each of the wire ends so that each one has one side that is an alligator clip and one side that is just wire (sorry no picture).

**9.** Wrap a piece of tape around the bottom of the circuit board, stopping before you get to the buttons on the other side:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_tape_back.jpg "Remote, with tape, facing backwards")

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_tape_front.jpg "Remote, with tape, facing forwards")

**10.** Clip the alligator clip end of each wire to the blobs (preferably with the cover on the clip to avoid shorts):

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_clips.jpg "Remote's clips")

**11.** Tape over the clips you just attached:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_clips_taped.jpg "Remote's clips, taped down")

**12.** Re-insert the battery:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/remote_open_single.png "Open controller with battery reinserted")

**13.** Test the remote again (you may need to hold the circuit board into place).

**14.** Try pressing the "off" button, then touching the two protruding wires together. The surge strip should turn on. Otherwise, check your connections.

**15.** Wrap tape around EVERYTHING! (except the wires, battery compartment, and buttons on the front)

**16.** Get four male-female wires (twice what is in the picture, since I had already done two and forgotten to take a picture):

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/wires.jpg "Two of the four required wires")

**17.** Cut off the male ends:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/wires_cut.jpg "Circled areas are to be cut off")

**18.** Strip the ends of the four wires.

**19.** Take two of them and connect the two wires to the two on the alligator clips, then wrap tape around each one (like in the picture below):

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/wires_spliced.jpg "Connected wires")

**20.** Play with whatever Dream Cheeky foam-dart-launching product you bought for a few minutes before taking it apart (you won't be able to put it back together, but you don't need to take out the motors. Raspberry Pi missile launcher, anyone?)

**20.** Take apart the missile launcher, cut the wires to the motors as close as you can, and remove the circuit board (you may have to either cut through the plastic or cut and reassemble the USB cord afterwards).

**21.** Find the yellow and red wires (they should be connected) and strip them:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/wires_yellowred.jpg "The yellow and red wires")

**22.** Connect the other two jumper wires:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/wires_spliced.jpg "Connected wires")

**23.** Here is a diagram of the relay and what goes where:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/relay_diagram.png "Relay diagram")

Green means wires from the missile launcher circuit board and red means wires to the remote. 

**24.** Bend down the pins like in this picture: 

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/relay_bending.jpg "Relay diagram")

**25.** Attach the wires from the missile launcher to the relay and hold them down with your finger like this:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/relay_green_insertion.jpg "Relay with 2 connections")

**26.** Tape over those two connections, making sure thay cannot slide in any further:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/surge-strip/relay_green_complete.jpg "Relay with 2 connections completed")

**27.** Do the same thing, but with the wires leading up to the remote and the red connections. Be sure to secure those too, even if they aren't bent down! (I ended up bending them both outwards and taping over them.)

**28.** Plug the missile launcher into the computer, turn off the socket from the remote itself, and run this program: "watson/server-files/Turn Socket On.exe". It should turn the socket back on, with your test device. If it doesn't work, listen for the small "click" sound made by the relay. If you can hear it, the problem is with the remote's connections. Otherwise, make *sure* it's not there (it's really quiet) and start looking for problems in the missile launcher portion, or in the connection to the relay.

**29.** Test it one more time, just to make sure.

Congratulations! You have completed another of the tutorials on Watson's peripherals.