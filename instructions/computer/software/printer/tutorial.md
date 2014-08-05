How to configure the printer
============================

**1.** Plug in/install your printer on your PC.

**2.** Record the *exact* name of the printer located in Control Panel\Devices and Printers.

**3.** Open the Visual Studio project file located here: watson\code\printer_code\TastyPrint.vbproj

**4.** Go to "Solution Explorer" and right-click on "Form1.vb". Select "View Code", as shown in the picture below:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/surge-strip/context-menu-3.png "The correct device is circled.")

**5.** Open up the text files you made earlier for the surge strip and the weather API.

**6.** Change the code in the line that looks like this:

```VB.net
Public ml As New Indy.Rocket.Core.Rocket(2689, 1793)
```

to this:

```VB.net
Public ml As New Indy.Rocket.Core.Rocket(yourVendorId, yourProductId)
```

with yourVendorId and yourProductId actually being your IDs from the text file.

**7.** Change the code in the line that looks like this:

```VB.net
Dim weather_json As WeatherInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WeatherInfo)(New System.Net.WebClient().DownloadString("http://api.wunderground.com/api/ccacf53a6ad1f168/conditions/q/WA/Redmond.json"))
```

to this:

```VB.net
Dim weather_json As WeatherInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WeatherInfo)(New System.Net.WebClient().DownloadString("http://api.wunderground.com/api/yourAPIKey/conditions/q/yourStateAbbreviation/yourCity.json"))
```

with yourAPIKey being the key you generated, yourStateAbbreviation as the two-letter abbreviation for a state (AZ, WA, etc.), and yourCity being the city you live in.

**8.** Change the code in the line that looks like this:

```VB.net
ac.LoadHTML(wc.DownloadString("http://www.wunderground.com/DisplayPollen.asp?Zipcode=98052"))
```

to this:

```VB.net
ac.LoadHTML(wc.DownloadString("http://www.wunderground.com/DisplayPollen.asp?Zipcode=yourZipCode"))
```

with yourZipCode being your area's zip code.

**9.** Change the code in the line that looks like this:

```VB.net
points = System.IO.File.ReadAllText("H:\bingPoints.txt").ToString()
```

to point towards wherever you put your Bing Rewards monitoring software (Watson Bing Helper) instead of H:/. (Keep the "bingPoints.txt" there, though.)

**10.** Replace all instances of:

```VB.net
"G:\WatsonServer_files\some-random-thing.exe"
```

to point towards wherever you have the "server-files" folder from the repo.

**11.** Change the code in the line that looks like this:

```VB.net
points = System.IO.File.ReadAllText("H:\bingPoints.txt").ToString()
```

to point towards wherever you put your Bing Rewards monitoring software (Watson Bing Helper) instead of H:\. (Keep the "bingPoints.txt" there, though.)

**12.** Change the code in the line that looks like this:

```VB.net
My.Computer.Audio.Play("G:\Watson\Turn Light On.wav", AudioPlayMode.WaitToComplete)
```

to this:

```VB.net
My.Computer.Audio.Play("pathToFile\Turn Light On.wav", AudioPlayMode.WaitToComplete)
```

with pathToFile as the path to the Turn Light On sound file that you can download [here](https://github.com/milkey-mouse/watson/raw/master/server-files/Turn%20Light%20On.wav).

**13.** Change the code in the line that looks like this:

```VB.net
PrintDocument1.PrinterSettings.PrinterName = "HP Photosmart C7200 series"
```

to this:

```VB.net
PrintDocument1.PrinterSettings.PrinterName = "yourPrinterName"
```

with yourPrinterName being the exact name of the printer on your computer that you connected earlier.

**14.** Click the green button near the top that looks like a "play" button and is next to text that says "Start". It may take a minute or two, but your blinds should open, your surge strip should turn on, your lamp should turn on, and your printer should print out a document looking something like this:

![alt text](https://github.com/milkey-mouse/watson/raw/master/instructions/computer/software/printer/docscan.jpg "A sample printout.")


