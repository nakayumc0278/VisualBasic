Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Integer
        a = Val(TextBox1.Text)
        souwa(a)
    End Sub

    Private Sub souwa(ByVal x As Integer)
        Dim i, value As Integer
        For i = 1 To x
            value += i
        Next
        MessageBox.Show("総和は" & value & "です", "総和")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
