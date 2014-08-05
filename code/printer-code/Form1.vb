Imports Newtonsoft.Json
Public Class Form1

    Public stringToPrint As String = ""
    Public points As String = ""
    Public dateToPrint As String = Date.Today.ToLongDateString()
    Public feelsLike As Single = Nothing
    Public pollen As Single = 0
    Public pollenString As String = ""
    Public weatherString As String = ""
    Public tempString As String = ""
    Public ml As New Indy.Rocket.Core.Rocket(2689, 1793)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.DocumentName = "Watson Day At A Glance"
        PrintDocument1.PrinterSettings.PrinterName = "HP Photosmart C7200 series"
        Try
            Try
                stringToPrint = WhatsForLunch.WhatsForLunch()
            Catch
            End Try
            Try
                Dim weather_json As WeatherInfo = Newtonsoft.Json.JsonConvert.DeserializeObject(Of WeatherInfo)(New System.Net.WebClient().DownloadString("http://api.wunderground.com/api/ccacf53a6ad1f168/conditions/q/WA/Redmond.json"))
                weatherString = weather_json.current_observation.weather
                tempString = weather_json.current_observation.feelslike_f.ToString + "°F"
            Catch
            End Try
            Awesomium.Core.WebCore.Initialize(New Awesomium.Core.WebConfig)
            Dim ac As Awesomium.Core.WebView = Awesomium.Core.WebCore.CreateWebView(0, 0)
            Dim wc As New System.Net.WebClient
            ac.LoadHTML(wc.DownloadString("http://www.wunderground.com/DisplayPollen.asp?Zipcode=98052"))
            Do
                Try
                    Awesomium.Core.WebCore.Update()
                Catch
                End Try
            Loop Until ac.IsDocumentReady = True
            pollen = Convert.ToSingle(ac.ExecuteJavascriptWithResult("document.getElementsByClassName('levels')[0].children[1].innerText").ToString())
            points = System.IO.File.ReadAllText("H:\bingPoints.txt").ToString()
        Catch
        End Try
        pollenString = "Pollen: " + pollen.ToString + " out of 12"
        stringToPrint = stringToPrint.Replace("NO SCHOOL", "No School")
        ml.Connect()
        ml.MoveRight(Indy.Rocket.Core.Rocket.Speed.Normal)
        Timer1.Start()
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(My.Resources.watson, New Point(0, e.PageBounds.Height - My.Resources.watson.Height - 50))
        e.Graphics.DrawString(dateToPrint, New Font("HelveticaNeue-Medium", 40), Brushes.SlateGray, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(dateToPrint, New Font("HelveticaNeue-Medium", 40)).Width / 2), 0))
        e.Graphics.DrawString(stringToPrint, New Font("HelveticaNeue-UltraLight", 20), Brushes.DimGray, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(stringToPrint, New Font("HelveticaNeue-UltraLight", 20)).Width / 2), e.PageBounds.Height / 2 - (e.Graphics.MeasureString(stringToPrint, New Font("HelveticaNeue-UltraLight", 20)).Height / 2) - 20))
        e.Graphics.DrawString(points, New Font("HelveticaNeue-UltraLight", 20), Brushes.Black, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(points, New Font("HelveticaNeue-UltraLight", 20)).Width / 2) + 20, e.PageBounds.Height / 2 + (e.Graphics.MeasureString(points, New Font("HelveticaNeue-UltraLight", 20)).Height) + 10))
        e.Graphics.DrawImage(My.Resources.rewards_medallion, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(points, New Font("HelveticaNeue-UltraLight", 20)).Width / 2) - 10, e.PageBounds.Height / 2 + (e.Graphics.MeasureString(points, New Font("HelveticaNeue-UltraLight", 20)).Height) + 10))
        e.Graphics.DrawString(pollenString, New Font("HelveticaNeue-UltraLight", 20), Brushes.Black, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(pollenString, New Font("HelveticaNeue-UltraLight", 20)).Width / 2), e.PageBounds.Height / 2 + (e.Graphics.MeasureString(pollenString, New Font("HelveticaNeue-UltraLight", 20)).Height) + 40))
        e.Graphics.DrawString(weatherString, New Font("HelveticaNeue-UltraLight", 20), Brushes.Black, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(weatherString, New Font("HelveticaNeue-UltraLight", 20)).Width / 2), e.PageBounds.Height / 2 + (e.Graphics.MeasureString(weatherString, New Font("HelveticaNeue-UltraLight", 20)).Height) + 70))
        e.Graphics.DrawString(tempString, New Font("HelveticaNeue-UltraLight", 20), Brushes.Black, New Point(e.PageBounds.Width / 2 - (e.Graphics.MeasureString(tempString, New Font("HelveticaNeue-UltraLight", 20)).Width / 2), e.PageBounds.Height / 2 + (e.Graphics.MeasureString(tempString, New Font("HelveticaNeue-UltraLight", 20)).Height) + 100))
    End Sub

    Private Sub PrintDocument1_EndPrint(sender As Object, e As Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        Process.GetCurrentProcess.Kill()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        ml.MoveDown()
        ml.Move(Indy.Rocket.Core.Rocket.HorizDir.None, Indy.Rocket.Core.Rocket.VertDir.None)
        ml.StopAll()
        Process.Start("G:\WatsonServer_files\BlindsUp_automated.exe")
        My.Computer.Audio.Play("G:\Watson\Turn Light On.wav", AudioPlayMode.WaitToComplete)
        PrintDocument1.Print()
    End Sub
End Class

Public Class WeatherInfo
    Public Property current_observation As CurrentObservation
End Class

Public Class CurrentObservation
    Public Property feelslike_f As Decimal = 0
    Public Property weather As String = ""
    Public Property icon As String = ""
End Class
