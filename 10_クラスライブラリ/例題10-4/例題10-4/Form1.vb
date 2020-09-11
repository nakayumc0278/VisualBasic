Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label14.Text = TextBox1.Text.IndexOf("Basic")
        Label16.Text = TextBox1.Text.Insert(12, ".NET")
        Label18.Text = TextBox1.Text.Remove(0, 7)
        Label20.Text = TextBox1.Text.Replace("Basic", "C")
        Label22.Text = TextBox1.Text.Substring(7, 5)
        Label24.Text = TextBox1.Text.ToUpper()
        Label15.Text = TextBox1.Text.ToLower()
        Label17.Text = TextBox1.Text.Chars(7)
        Label19.Text = TextBox1.Text.Length
        Label21.Text = TextBox1.Text.LastIndexOf("Basic")
        Label23.Text = String.Concat(TextBox1.Text, TextBox2.Text)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
