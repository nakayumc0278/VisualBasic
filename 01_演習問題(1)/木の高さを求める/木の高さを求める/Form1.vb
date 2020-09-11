Public Class Form1
    Dim tan As Single
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tan = Val(TextBox1.Text) * Math.Tan(TextBox2.Text * Math.PI / 180) + 1.5
        Label7.Text = Format(tan, "####.#")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
