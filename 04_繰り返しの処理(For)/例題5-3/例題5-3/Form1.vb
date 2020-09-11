Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k As Integer
        TextBox1.Text = ""
        For i = 1 To 9
            For j = 1 To 9
                k = i * j
                TextBox1.Text &= Str(k) & ControlChars.Tab
            Next
            TextBox1.Text &= ControlChars.CrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
