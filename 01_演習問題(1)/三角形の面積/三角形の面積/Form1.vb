Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, p As Integer
        Dim s As Single

        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        p = (a + b + c) / 2.0
        s = Math.Sqrt(p * (p - a) * (p - b) * (p - c))

        Label6.Text = Format(s, "#.#")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
