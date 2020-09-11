Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        For i = 1 To 4
            TextBox1.Text &= (TextBox2.Text) & ControlChars.CrLf
        Next
    End Sub
End Class
