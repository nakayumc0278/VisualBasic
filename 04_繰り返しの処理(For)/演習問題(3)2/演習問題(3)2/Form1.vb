Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, sum As Integer
        For i = 3 To 17 Step 2
            sum += i
            Label1.Text = sum
        Next
    End Sub
End Class
