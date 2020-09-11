Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(9, 9) As Integer
        Dim i, j As Integer
        For i = 1 To 9
            For j = 1 To 9
                data(i, j) = i * j
            Next
        Next
        For i = 1 To 9
            For j = 1 To 9
                Label1.Text &= Str(data(i, j)) & ControlChars.Tab
            Next
            Label1.Text &= ControlChars.CrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
