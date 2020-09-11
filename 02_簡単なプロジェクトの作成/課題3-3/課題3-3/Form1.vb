Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label11.Text = Val(TextBox5.Text) * Val(TextBox9.Text)
        Label12.Text = Val(TextBox6.Text) * Val(TextBox10.Text)
        Label13.Text = Val(TextBox7.Text) * Val(TextBox11.Text)
        Label14.Text = Val(TextBox8.Text) * Val(TextBox12.Text)
        Label16.Text = Val(Label11.Text) + Val(Label12.Text) + Val(Label13.Text) + Val(Label14.Text)
        Label15.Text = Val(Label16.Text) \ 4
    End Sub
End Class
