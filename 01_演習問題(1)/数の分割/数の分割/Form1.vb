Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim kazu As Integer
        Label3.Text = Val(TextBox1.Text) \ 1000
        Label5.Text = Val(TextBox1.Text) Mod 1000
    End Sub
End Class
