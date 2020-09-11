Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, c, d, i As Integer
        Dim b As Double
        a = TextBox1.Text
        b = TextBox2.Text
        b *= 0.01
        i = 0
        Do
            i += 1
            c = a * (1 + i * b)
            d = a * (1 + b) ^ i
        Loop While c * 2 >= d
        TextBox3.Text = i
        TextBox4.Text = c
        TextBox5.Text = d
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
