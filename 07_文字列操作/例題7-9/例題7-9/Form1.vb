Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = TextBox2.Text
        Dim str3 As String = TextBox3.Text
        Label5.Text = str1.Replace(str2, str3)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
