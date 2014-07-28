How to build the DVD/CD drive control software
==============================================

**1.** Open the Visual Studio project file located here: watson\code\drives_code\ECD.vbproj

**2.** Go to "Solution Explorer" and open "Module1.vb".

**For each drive:**

**3.** *(Skip to step 7 if your drive is spring-loaded and can only eject, not go back in. Many laptop/portable drives are like this, so make sure you check.)* In Sub Main(), you might see code like this. Replace all the stars ("L"'s in the default code) with your first drive letter.

```VB.net
Sub Main()
    mciSendString("open *: type cdaudio alias drive*", rt, 127, 0)
    mciSendString("set drive* door closed", rt, 127, 0)
    mciSendString("close drive*", rt, 127, 0)
End Sub
```

**4.** Open your first drive.

**5.** Click the green button near the top that looks like a "play" button and is next to text that says "Start". Your drive should close.

**6.** Reopen Solution Explorer and right-click on the top icon. (It should say "ECD" in bold letters.) Near the bottom of the context menu, there should be an option that says "Open Folder in File Explorer". Click on it and click on the "bin" folder and then either "Debug" or "Release", depending on which one was selected in Visual Studio. (I believe it defaults to Debug.) Here's a picture of the option:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/drives/context-menu.png "The correct button is circled.")

**7..** Rename your compiled app from "ECD" to "ECD\*", with \* being the number (not the letter of your drive, e.g. "ECD1.exe" and "ECD2.exe". Keep this window open.

**8.** Reopen Sub Main and change the second mciSendString from

```VB.net
    mciSendString("set drive* door closed", rt, 127, 0)
```
to
```VB.net
    mciSendString("set drive* door open", rt, 127, 0)
```
with \* still as your drive letter.

**4.** Make sure your first drive is closed.

**5.** Click the green button near the top that looks like a "play" button and is next to text that says "Start". Your drive should open.

**7..** Rename your (re)compiled app from "ECD" to "CCD\*", with \* being the number (not the letter of your drive, e.g. "CCD1.exe" and "CCD2.exe".

**After you've done all drives:**

**8.** Take all of the binaries you've built (except for ECD.exe) and copy them into your clone of the Github repo, under "watson/server-files". Overwrite any existing files, as those were my sample builds of ECD.exe.

Only my second drive had open/close functionality, while my first one did not, so in the phone app, you'll need to add a button for closing the first drive programmatically.
