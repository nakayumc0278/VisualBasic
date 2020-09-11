Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = TextBox1.Text
        time(a)
    End Sub

    Private Sub time(ByVal t As Integer)
        Select Case t
            Case 5, 6, 7, 8, 9, 10
                TextBox2.Text = ("おはようごさいます")
            Case 11, 12, 13, 14, 15, 16, 17
                TextBox2.Text = ("こんにちは")
            Case 18, 19, 20, 21, 22, 0, 1, 2, 3, 4
                TextBox2.Text = ("こんばんは")
            Case Else
                TextBox2.Text = ("")
                MessageBox.Show("エラーです", "エラー")
        End Select
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
