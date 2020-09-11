Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b As Single
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        Label3.Text = Format(y(a) - y(b), "##0.####0")
    End Sub
    Private Function y(ByRef x As Single)
        y = x ^ 2 - 4 * x + 4
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
