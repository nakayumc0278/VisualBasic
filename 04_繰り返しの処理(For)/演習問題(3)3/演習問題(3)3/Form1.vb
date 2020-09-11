Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, sum As Integer
        sum = 1
        For i = 1 To 7
            sum = 1
            For j = 1 To i
                sum = sum * j
            Next
            TextBox1.Text &= Format(sum, "###,###") & ControlChars.CrLf
        Next


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
