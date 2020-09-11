Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim data(9, 9) As Integer
        Dim d(9, 9) As Integer
        Dim i, j, a As Integer
        a = Val(TextBox1.Text)
        Label1.Text = ""
        For i = 1 To 9
            For j = 1 To 9
                If a = i * j Then
                    Label1.Text &= Str(i) & ControlChars.Tab
                    Label1.Text &= (" *") & ControlChars.Tab
                    Label1.Text &= Str(j) & ControlChars.CrLf
                End If
            Next
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
