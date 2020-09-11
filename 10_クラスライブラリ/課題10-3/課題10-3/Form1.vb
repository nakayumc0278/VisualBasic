Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, t3 As String
        Dim d1, d2 As Integer
        d1 = TextBox4.Text
        d2 = TextBox5.Text
        t1 = TextBox1.Text
        t2 = TextBox2.Text
        t3 = TextBox3.Text

        Label8.Text = String.Concat(t1, t2)
        Label9.Text = Label8.Text.Length
        Label10.Text = Label8.Text.Remove(d1 - 1, d2)
        Label11.Text = Label8.Text.Replace(TextBox2.Text, TextBox3.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
