Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim a, root As Double
        a = Val(TextBox1.Text)
        If a < 0 Then
            a = Math.Abs(a)
        End If
        root = Math.Sqrt(a)
        Label3.Text = root
    End Sub

End Class
