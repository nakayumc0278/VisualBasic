Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        proc1("プロシージャ呼び出し")
    End Sub

    Private Sub proc1(ByVal strmsg As String)
        MessageBox.Show(strmsg, "値渡し")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strMsg As String
        proc2(strMsg)
        MessageBox.Show(strMsg, "参照渡し")
    End Sub
    Private Sub proc2(ByRef strmsg As String)
        strmsg = "プロシージャ設定"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
