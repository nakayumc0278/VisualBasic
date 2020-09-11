Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, v0 As Integer
        Dim t, g, y As Double
        i = 0
        TextBox1.Text = ""
        v0 = TextBox2.Text
        Do While i >= 0 And i <= 60
            t = i * 0.1
            y = t * v0 - 9.8 * t ^ 2 / 2
            TextBox1.Text &= y & ControlChars.CrLf

            i = i + 2
        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
