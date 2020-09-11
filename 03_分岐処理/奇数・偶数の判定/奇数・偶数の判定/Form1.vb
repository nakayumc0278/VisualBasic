Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, amari As Integer
        a = Val(TextBox1.Text)
        amari = a Mod 2
        If amari = 0 Then
            Label3.Text = "偶数"
        Else
            Label3.Text = "奇数"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
