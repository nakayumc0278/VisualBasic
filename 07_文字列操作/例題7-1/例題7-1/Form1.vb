Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String = TextBox1.Text
        Dim b As String = TextBox2.Text
        Dim c As String
        c = a & b
        Label3.Text = c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
