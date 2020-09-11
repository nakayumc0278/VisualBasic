Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, sum, n, x As Double
        b = 1
        sum = 1
        n = TextBox1.Text
        x = TextBox2.Text

        For a = 1 To (n - 1)
            b += a
            sum += b
            If b >= x Then
                Label3.Text = Str(a)
                Label5.Text = Str(b - a)
                Label7.Text = Str(sum - b)
                Exit For
            End If
        Next
    End Sub
End Class
