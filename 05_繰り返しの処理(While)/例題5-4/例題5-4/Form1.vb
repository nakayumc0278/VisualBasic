Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim srtAnser As String
        Do
            srtAnser = InputBox("OKと入力すれば、処理が終了します。", "入力")
        Loop While srtAnser <> "OK" And srtAnser <> "ok" And srtAnser <> "ＯＫ"
        End
    End Sub
End Class
