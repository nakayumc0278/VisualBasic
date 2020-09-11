Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim beer, whisky As Integer
        beer = Val(TextBox1.Text) * 350 * 0.055
        whisky = Val(TextBox2.Text) * 0.43
        Label6.Text = beer + whisky
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
