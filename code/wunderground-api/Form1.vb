Public Class Form1

    Public derp As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer8.Start()
        If TextBox1.Text = "" Then
            MessageBox.Show("Please enter your first name!")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("Please enter your last name!")
            Exit Sub
        End If
        If ComboBox1.SelectedItem = Nothing Then
            MessageBox.Show("Please select a country!")
            Exit Sub
        End If
        Me.Hide()
        For Each cont As Control In Me.Controls
            If cont.Name.Contains("Form") = True Then Continue For
            cont.Hide()
        Next
        Me.Text = "Generating key"
        Dim rand As New Random()
        derp = ""
        For length As Integer = 0 To 5
            derp = derp + Hex(Math.Round(rand.NextDouble * 255).ToString).ToString.ToLower
        Next
        WebControl1.Show()
        WebControl1.Source = New Uri("http://www.wunderground.com/weather/api/d/login.html")
        Panel1.Show()
        Me.Show()
    End Sub

    Private Sub Awesomium_Windows_Forms_WebControl_DocumentReady(sender As Object, e As Awesomium.Core.UrlEventArgs) Handles WebControl1.DocumentReady
        If e.Url.ToString.StartsWith("http://www.wunderground.com/weather/api/d/login.html?validation=1&email=") = True Then
            ProgLabel.Text = "Validating account"
            ProgressBar1.Value = 2
            WebControl1.Source = New Uri("http://mailinator.com/inbox.jsp?to=" + derp)
        ElseIf e.Url = New Uri("http://www.wunderground.com/weather/api/d/login.html") Then
            Timer1.Start()
        ElseIf e.Url.ToString.StartsWith("http://mailinator.com/inbox.jsp?to=") = True Then
            Timer2.Start()
        ElseIf e.Url.ToString.StartsWith("http://mailinator.com/rendermail.jsp") Then
            WebControl1.ExecuteJavascript("window.location = document.getElementsByTagName('a')[0].href")
        ElseIf e.Url.ToString.StartsWith("http://www.wunderground.com/weather/api/d/login.html?validation=") Then
            Timer4.Start()
        ElseIf e.Url = New Uri("http://www.wunderground.com/weather/api/") Then
            WebControl1.Source = New Uri("http://www.wunderground.com/weather/api/d/pricing.html")
        ElseIf e.Url = New Uri("http://www.wunderground.com/weather/api/d/pricing.html") Then
            Timer5.Start()
        ElseIf e.Url = New Uri("http://www.wunderground.com/weather/api/d/questionnaire.html") Then
            Timer7.Start()
        ElseIf e.Url.ToString.Contains("wunderground.recurly.com/subscribe//") Then
            ProgLabel.Text = "Parsing key"
            ProgressBar1.Value = 6
            Dim key As String = e.Url.ToString
            key = key.Substring(key.IndexOf("subscribe//") + 11)
            key = key.Remove(key.IndexOf("/?email="))
            ProgLabel.Text = "Done"
            ProgressBar1.Value = 7
            My.Computer.Clipboard.SetText(key)
            MessageBox.Show("Your API key is " + Chr(34) + key + Chr(34) + ". It has been copied to your clipboard.")
            Me.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        ProgLabel.Text = "Creating account"
        ProgressBar1.Value = 1
        FillForm()
        Timer1.Stop()
    End Sub

    Sub FillForm()
        WebControl1.ExecuteJavascript("document.getElementById('create-email').value = '" + derp + "@mailinator.com'")
        WebControl1.ExecuteJavascript("document.getElementById('create-pass').value = 'wunderground-bot'")
        WebControl1.ExecuteJavascript("document.getElementById('create-pass2').value = 'wunderground-bot'")
        WebControl1.ExecuteJavascript("document.getElementsByClassName('create')[3].value = '" + derp + "'")
        WebControl1.ExecuteJavascript("document.getElementById('agree-to-terms').checked = true")
        WebControl1.ExecuteJavascript("document.getElementById('enroll').submit();")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        WebControl1.ExecuteJavascript("document.getElementsByTagName('a')[6].onclick();")
        Timer2.Stop()
        Timer3.Start()
        'Dim emailcode As String =
        '.Substring(WebControl1.HTML.IndexOf("showmail('") + 10)
        'emailcode = emailcode.Remove(emailcode.IndexOf("')"))
        'MessageBox.Show(emailcode)
        'WebControl1.ExecuteJavascript("showmail('" + emailcode + "')")
        'Timer2.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        WebControl1.ExecuteJavascript("window.location = document.getElementsByTagName('iframe')[0].src")
        Timer3.Stop()
        Timer2.Stop()
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        Timer4.Stop()
        ProgLabel.Text = "Signing into account"
        ProgressBar1.Value = 3
        WebControl1.ExecuteJavascript("document.getElementById('login-email').value = '" + derp + "@mailinator.com'")
        WebControl1.ExecuteJavascript("document.getElementById('login-pass').value = 'wunderground-bot'")
        WebControl1.ExecuteJavascript("document.getElementById('login').submit();")
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        Timer6.Start()
        Timer5.Stop()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        ProgLabel.Text = "Completing account"
        ProgressBar1.Value = 4
        WebControl1.ExecuteJavascript("document.getElementsByName('api_package')[5].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('api_history')[2].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('api_usage')[0].checked = true")
        WebControl1.ExecuteJavascript("document.getElementById('planConfig_r').submit();")
        Timer6.Stop()
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        If WebControl1.IsLoading = True Then Exit Sub
        WebControl1.ExecuteJavascript("document.getElementById('contact_name').value = '" + TextBox1.Text + " " + TextBox2.Text + "'")
        WebControl1.ExecuteJavascript("document.getElementsByName('contact_email')[0].value = '" + derp + "@mailinator.com'")
        WebControl1.ExecuteJavascript("document.getElementsByName('project_name')[0].value = 'Watson'")
        WebControl1.ExecuteJavascript("document.getElementsByName('website')[0].value = 'http://hackaday.io/project/2142'")
        WebControl1.ExecuteJavascript("document.getElementsByName('where')[3].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('commercial')[1].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('chip')[1].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('selectedCountry')[0].value = '" + ComboBox1.SelectedItem + "'")
        WebControl1.ExecuteJavascript("document.getElementById('field').value = 'This account was automatically registered for a new user of the Watson home automation suite.'")
        WebControl1.ExecuteJavascript("document.getElementsByName('branding')[0].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByName('agree')[0].checked = true")
        WebControl1.ExecuteJavascript("document.getElementsByTagName('form')[1].submit();")
        ProgLabel.Text = "Obtaining key"
        ProgressBar1.Value = 5
        Timer7.Stop()
    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        MessageBox.Show("The app has timed out. Please relaunch this app to continue.")
        Me.Close()
    End Sub
End Class
