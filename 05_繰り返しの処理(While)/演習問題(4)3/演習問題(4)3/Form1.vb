Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, sum, i As Integer
        a = TextBox1.Text
        b = 1
        i = 1
        sum = 1

        Do While a >= i
            sum = sum * b
            i = i + 1
            b = b + 1
        Loop
        TextBox2.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
