Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d As Single
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)
        d = Val(TextBox4.Text)
        TextBox5.Text = ""
        TextBox5.Text = "x" & vbTab & "y" & vbTab & "z" & vbTab & "s" & vbCrLf & vbCrLf
        keisan(a, b, c)
        keisan(b, c, d)
        keisan(a, c, d)
        keisan(a, b, d)
    End Sub

    Private Sub keisan(ByVal x As Single, ByVal y As Single, ByVal z As Single)
        Dim p, s As Single
        If z < x + y And z > Math.Abs(x - y) Then
            p = (x + y + z) / 2
            s = Math.Sqrt(p * (p - x) * (p - y) * (p - z))
        Else
            s = 0
        End If
        TextBox5.Text &= x & vbTab & y & vbTab & z & vbTab & Format(s, "##0.0") & vbCrLf
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
