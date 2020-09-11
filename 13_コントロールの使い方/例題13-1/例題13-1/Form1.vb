Public Class Form1
    <System.Runtime.InteropServices.DllImport("winmm.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As System.Text.StringBuilder, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer

    End Function
    <System.Runtime.InteropServices.DllImport("winmm.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function mciGetErrorString(ByVal dwError As Integer, ByVal lpBuffer As String, ByVal lpBufLength As Integer) As Integer

    End Function

    Public Const SrcCopy As Integer = &HCC0020
    Public Const SrcAnd As Integer = &H8800C6
    Public Const SrcPaint As Integer = &HEE0086

    Public Const SND_SYNC As Short = &H0S
    Public Const SND_ASYNC As Short = &H1S
    Public Const SND_NODEFAULT As Short = &H2S
    Public Const SND_MEMORY As Short = &H4S
    Public Const SND_LOOP As Short = &H8S
    Public Const SND_NOSTOP As Short = &H10S

    Public Declare Function ShowCursor Lib "user32" (ByVal bShow As Integer) As Integer

    Public Const API_TRUE As Integer = 1
    'Public Const API_FALSE As Integer = 0

    Private aliasName As String = "MediaFile"

    Private Const FILE_NAME1 As String = "..\..\Resources\Chime.wav"
    Private Const FILE_NAME2 As String = "..\..\Resources\Space.wav"
    Private Const FILE_NAME3 As String = "..\..\Resources\Smooth.mp3"
    Dim cmd2 As String

    Private Sub 終了_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 終了.Click
        mciSendString("close MIDI", Nothing, 0, 0)
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BGM1.Visible = True
        BGM1_STOP.Visible = False
        BGM2.Visible = True
        BGM2_STOP.Visible = False

        cmd2 = "open """ + FILE_NAME3 + """ alias " + aliasName
        If mciSendString(cmd2, Nothing, 0, 0) <> 0 Then
            Return
        End If
        mciSendString(cmd2, Nothing, 0, 0)
        cmd2 = "play " + aliasName + " repeat"
        mciSendString(cmd2, Nothing, 0, 0)
    End Sub

    <Flags()>
    Public Enum PlaySoundFlags
        SND_SYNC = &H0
        SND_ASYNC = &H1
        SND_NODEFAULT = &H2
        SND_MEMORY = &H4
        SND_LOOP = &H8
        SND_NOSTOP = &H10
        SND_NOWAIT = &H2000
        SND_ALIAS = &H10000
        SND_ALIAS_ID = &H110000
        SND_FILENAME = &H20000
        SND_RESOURCE = &H40004
        SND_PURGE = &H40
        SND_APPLIATION = &H80
    End Enum

    <System.Runtime.InteropServices.DllImport("winmm.dll", CharSet:=System.Runtime.InteropServices.CharSet.Auto)>
    Private Shared Function PlaySound(ByVal pszSound As String, ByVal hmod As IntPtr, ByVal fdwSound As PlaySoundFlags) As Boolean

    End Function

    Private Sub BGM1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BGM1.Click
        Dim cmd As String
        cmd = "" + FILE_NAME1 + ""

        'PlaySound(cmd, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_ASYNC)
        PlaySound(cmd, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_ASYNC Or PlaySoundFlags.SND_LOOP)
        'PlaySound(cmd, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_SYNC)
        BGM1.Visible = False
        BGM1_STOP.Visible = True
    End Sub

    Private Sub BGM1_STOP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BGM1_STOP.Click
        PlaySound(Nothing, IntPtr.Zero, PlaySoundFlags.SND_PURGE)
        BGM1_STOP.Visible = False
        BGM1.Visible = True
    End Sub

    Private Sub BGM2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BGM2.Click
        Dim cmd3 As String
        cmd3 = "" + FILE_NAME2 + ""

        'PlaySound(cmd3, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_ASYNC)
        PlaySound(cmd3, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_ASYNC Or PlaySoundFlags.SND_LOOP)
        'PlaySound(cmd3, IntPtr.Zero, PlaySoundFlags.SND_FILENAME Or PlaySoundFlags.SND_SYNC)
        BGM2_STOP.Visible = True
        BGM2.Visible = False
    End Sub
    Private Sub BGM2_STOP_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BGM2_STOP.Click
        PlaySound(Nothing, IntPtr.Zero, PlaySoundFlags.SND_PURGE)
        BGM2_STOP.Visible = False
        BGM2.Visible = True
    End Sub
End Class
