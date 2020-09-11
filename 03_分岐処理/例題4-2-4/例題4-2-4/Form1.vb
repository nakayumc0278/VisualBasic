Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ten As Integer
        ten = Val(TextBox1.Text)
        If ten >= 80 And TextBox2.Text = "A" Then
            'ten >= 80 と TextBox2.text = "A" の同時成立が条件
            Label3.Text = "合格です"
        Else
            Label3.Text = "不合格です"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
