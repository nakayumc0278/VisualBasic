Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SplitArray(), temp As String
        SplitArray = Split(TextBox1.Text, " ")

        For Each temp In SplitArray
            Label1.Text &= temp & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
