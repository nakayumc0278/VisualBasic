Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(5) As Integer
        For i = 0 To 5
            data(i) = (i + 1) ^ 2
        Next
        Label1.Text = ""
        For I = 0 To 5
            Label1.Text &= data(I) & ControlChars.CrLf
        Next
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
