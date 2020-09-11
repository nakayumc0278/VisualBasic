Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Integer
        n = TextBox1.Text

        Label2.Text = y(n)
    End Sub
    Private Function y(ByVal g As Integer) As Integer
        Dim i As Integer
        Dim mul As Long = 1
        For i = 1 To g
            mul *= i
        Next
        y = mul
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
