Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, sum, n As Double
        b = 1
        sum = 1
        n = TextBox1.Text
        For a = 1 To (n - 1)
            b = a + b
            sum += b
            Label3.Text = Str(sum)
            Label5.Text = Str(a + 1)
            Label7.Text = Str(b)
        Next
    End Sub
End Class
