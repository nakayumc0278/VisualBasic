Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, x1, x2 As Double
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        d = b ^ 2 - 4 * a * c
        If d < 0 Then
            Label8.Text = "虚根です"
        Else
            x1 = (-1 * b + Math.Sqrt(d)) / (2 * a)
            x2 = (-1 * b - Math.Sqrt(d)) / (2 * a)

            Label6.Text = Format(x1, "0.###")
            Label7.Text = Format(x2, "0.###")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class
