How to build the Bing Rewards checker software
==============================================

*If you haven't registered for Bing Rewards yet, do me a favor and use [this link](http://www.bing.com/explore/rewards?PUBL=REFERAFRIEND&CREA=RAW&rrid=_d7889aa0-c3b7-37a3-5c45-3241d2ec1433). It'll earn me some points and I think you get some free as well! If you prefer to do it without the referral link, go ahead, but you need to click on one of those (if you haven't already registered for Bing Rewards) in order to use this code. Even if you don't use Bing at all, you should still sign up, since there are a few apps that do stuff like search for you or search Bing (offscreen, just so you get the credits) whenever you Google something.*

**1.** Open the Visual Studio project file located here: watson\code\rewards_code\Watson Bing Helper.vbproj

**2.** Go to "Solution Explorer" and right-click on "Form1.vb". Click on "View Code", as shown in the picture below:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/rewards/context-menu-2.png "The correct button is circled.")

**3.** In WebBrowser1_DocumentCompleted(), you might see code like this. Replace "username" with your Microsoft account's username/email (leaving the quotes) and do the same with "password" for your Microsoft account password.

```VB.net
Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        Try
            If Me.WebBrowser1.Url.ToString().Contains("http://login.live.com/login.srf") Then
                Me.WebBrowser1.Document.GetElementById("i0116").SetAttribute("value", "username")
                Me.WebBrowser1.Document.GetElementById("i0118").SetAttribute("value", "password")
                Me.WebBrowser1.Document.GetElementById("idChkBx_PWD_KMSI0Pwd").InvokeMember("click")
                Me.WebBrowser1.Document.GetElementById("idSIButton9").InvokeMember("click")
            End If
            If Me.WebBrowser1.Url.ToString().Contains("http://www.bing.com/rewards/dashboard") Then
                Me.Timer1.Start()
            End If
            If Me.WebBrowser1.Url.ToString().Contains("https://account.live.com/summarypage.aspx") Then
                Me.WebBrowser1.Url = New Uri("http://www.bing.com/rewards/dashboard")
            End If
        Catch ex As Exception
            If Not ex.Message = "Object reference not set to an instance of an object." Then Me.Close()
        End Try
    End Sub
```

**4.** Click the green button near the top that looks like a "play" button and is next to text that says "Start". Wait until the program closes itself again.

**5.** Reopen Solution Explorer and right-click on the top icon. (It should say "ECD" in bold letters.) Near the bottom of the context menu, there should be an option that says "Open Folder in File Explorer". Click on it and click on the "bin" folder and then either "Debug" or "Release", depending on which one was selected in Visual Studio. (I believe it defaults to Debug.) Here's a picture of the option:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/drives/context-menu.png "The correct button is circled.")

**7.** Check to see if there is a file called bingPoints.txt. If there isn't, try going to the other build folder (e.g. try "Release" for "Debug", try "Debug" for "Release"). If neither of the folders have a file called "bingPoints.txt", then there is something wrong that you have to troubleshoot.

**8.** Go back into the folder where you found bingPoints.txt. Copy the .exe into watson/server-files.

If it's working, congratulations! This is part of the software that makes the daily printouts in the morning.