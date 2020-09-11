Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim shosu1, shosu2 As Single
        shosu1 = Val(TextBox1.Text)
        Label3.Text = shosu1 * 2 * Math.PI
        shosu1 = Val(Label3.Text)
        Label3.Text = Format(shosu1, "####.##0")

        shosu2 = Val(TextBox1.Text)
        Label5.Text = shosu2 * shosu2 * Math.PI
        shosu2 = Val(Label5.Text)
        Label5.Text = Format(shosu2, "####.##0")
    End Sub
End Class
