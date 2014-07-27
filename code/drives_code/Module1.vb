Imports System.Runtime.InteropServices
Imports System.Text

Module Module1

    <DllImport("winmm.dll")> _
    Public Function mciSendString(lpstrCommand As String, lpstrReturnString As StringBuilder, uReturnLength As UInt32, hwndCallback As IntPtr) As UInt32
    End Function

    Public rt As StringBuilder

    Sub Main()
        mciSendString("open L: type cdaudio alias driveL", rt, 127, 0)
        mciSendString("set driveL door closed", rt, 127, 0)
        mciSendString("close driveL", rt, 127, 0)
    End Sub

End Module
