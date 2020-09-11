Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, i As Double
        a = 1
        i = 1
        c = 1
        Do
            a = i * a
            c = 1 / a + c
            b = 1 / a
            i += 1
        Loop While b >= 0.000000000000001
        TextBox1.Text = c
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
