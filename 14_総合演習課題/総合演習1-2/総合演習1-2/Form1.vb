Public Class Form1
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, sum, n As Double
        Dim a0, b0, sum0, sumall, n0 As Double

        b = 1
        sum = 1

        n = TextBox1.Text
        For a = 1 To (n - 1)
            b += a
            sum += b
            Label3.Text = Str(sum)
            Label5.Text = Str(a + 1)
            Label7.Text = Str(b)
        Next

        b0 = 1
        sum0 = 1
        n0 = (TextBox2.Text)
        For a0 = 1 To (n0 - 1)
            b0 += a0
            sum0 += b0
            Label16.Text = Str(sum0)
            Label13.Text = Str(a0 + 1)
            Label14.Text = Str(b0)
        Next
        sumall = sum - (sum0 - b0)
        Label15.Text = Str(sumall)
    End Sub
End Class
