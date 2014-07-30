Imports System.IO

Public Class Form1
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            Dim attribute As String = Me.WebBrowser1.Document.GetElementById("id_rc").GetAttribute("innerText")
            If File.Exists("bingPoints.txt") Then
                File.Delete("bingPoints.txt")
            End If
            File.WriteAllText("bingPoints.txt", attribute)
            Me.Close()
        Catch
            Me.Close()
        End Try
    End Sub

    Private Sub WebBrowser1_Navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles WebBrowser1.Navigating
        If e.Url.ToString().Contains("msn.com") Then
            Me.WebBrowser1.Url = New Uri("http://login.live.com/login.srf")
        End If
    End Sub
End Class
