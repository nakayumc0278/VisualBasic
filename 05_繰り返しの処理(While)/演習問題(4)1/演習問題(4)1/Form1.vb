Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, i, k, g, sum As Integer
        k = 0
        g = 0
        sum = 0
        a = Val(TextBox1.Text)
        For i = 1 To a Step 2
            k += i
        Next i
        For i = 2 To a Step 2
            g += i
        Next i
        For i = 1 To a
            sum += i
        Next i
        TextBox2.Text = g
        TextBox3.Text = k
        TextBox4.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
