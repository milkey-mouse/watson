How to build the software for the surge strip
=============================================

**1.** Download USBDeview [here](http://www.nirsoft.net/utils/usb_devices_view.html). *Be sure to pick the 32-bit version for a 32-bit PC and the 64-bit version for a 64-bit PC!*

**2.** Plug in your missile launcher now.

**3.** Start the app. Set it to sort by "Connected", with "Yes" being first.

**4.** Find a device with "Dream Cheeky" in its name that is plugged in, like this:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/surge-strip/usb-1.png "The correct device is circled.")

**5.** Look at its Vendor and Product IDs, like in the picture below:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/surge-strip/usb-2.png "The correct device is circled.")

Take each one and input them into [this website](http://www.binaryhexconverter.com/hex-to-decimal-converter). *(Don't follow the picture exactly, this was just an example and the numbers that are circled are not correct!)*

**6.** If the (decimal) Vendor ID is 2689, then you're probably on the right track! (If you haven't come up with that number, go and look in USBDeview again for something that does.)

**7.** Record both values and save them for later in Notepad (or anything else, for that matter). Go ahead and close out of USBDeview and the hexadecimal converter site.

**8.** Open the Visual Studio project file located here: watson\code\socket-code\Turn Socket On.vbproj

**9.** Go to "Solution Explorer" and right-click on "Form1.vb". Select "View Code", as shown in the picture below:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/surge-strip/context-menu-3.png "The correct device is circled.")

**10.** For the second line of the file, you'll probably see code that looks like this:

```VB.net
Public ml As New Indy.Rocket.Core.Rocket(2689, 1793)
```

Change "1793" to the Product ID (not the Vendor ID).

**11.** Turn off your surge strip (with the remote, not the switch on it).

**11.** Click the green button near the top that looks like a "play" button and is next to text that says "Start". Your surge strip should start up.

**12.** Reopen Solution Explorer and right-click on the top icon. (It should say "Turn Socket On" in bold letters.) Near the bottom of the context menu, there should be an option that says "Open Folder in File Explorer". Click on it and click on the "bin" folder and then either "Debug" or "Release", depending on which one was selected in Visual Studio. (I believe it defaults to Debug.) Here's a picture of the option:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/drives/context-menu.png "The correct button is circled.")

**13.** Take "Turn Socket On.exe", "RocketLauncher.dll", and "UsbLibrary.dll" and comy them to watson\server-files. If you need to overwrite any existing files, that's fine.

**14.** Save the file that you made in Notepad (or whatever you used) as it will be needed in another tutorial.