Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, r, ans As Single
        a = Val(TextBox1.Text)
        c = Val(TextBox2.Text)
        b = Val(TextBox3.Text)

        ans = (a * c * Math.Sin(b * Math.PI / 180)) / 2
        Label4.Text = ans
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
