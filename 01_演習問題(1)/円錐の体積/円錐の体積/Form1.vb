Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        a = 1 / 3 * Math.PI * Val(TextBox1.Text) ^ 2 * Val(TextBox2.Text)
        Label4.Text = Format(a, "####.###")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
