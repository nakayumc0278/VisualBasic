Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eigo As Integer
        eigo = Val(TextBox1.Text)
        If eigo >= 80 Then
            Label2.Text = "優"
        ElseIf eigo >= 60 Then
            Label2.Text = "良"
        Else
            Label2.Text = "可"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
