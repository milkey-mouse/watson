Public Class Form1
    Public ml As New Indy.Rocket.Core.Rocket(2689, 1793)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ml.Connect()
        ml.MoveRight(Indy.Rocket.Core.Rocket.Speed.Normal)
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        ml.MoveDown()
        ml.Move(Indy.Rocket.Core.Rocket.HorizDir.None, Indy.Rocket.Core.Rocket.VertDir.None)
        ml.StopAll()
        Me.Close()
    End Sub
End Class
