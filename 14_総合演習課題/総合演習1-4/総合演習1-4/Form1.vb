Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, sum, n, x As Double
        Dim a0, b0, sum0, sumall, x0 As Double

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

        b0 = 1
        sum0 = 1
        n = TextBox1.Text
        x0 = TextBox3.Text
        For a0 = 1 To (n - 1)
            b0 += a0
            sum0 += b0
            If b0 >= x0 Then
                Label16.Text = Str(a0 + 1)
                Label13.Text = Str(b0)
                Label14.Text = Str(sum0)
                Exit For
            End If
        Next
        sumall = ((sum - b) - sum0) + b0
        Label15.Text = Str(sumall)
    End Sub
End Class
