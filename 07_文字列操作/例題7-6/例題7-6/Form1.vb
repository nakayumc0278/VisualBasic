Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String
        Dim str2 As String
        Dim i As Integer
        str1 = TextBox1.Text
        str2 = ""
        For i = Len(str1) To 1 Step -1
            str2 = str2 & Mid(str1, i, 1)
        Next
        Label1.Text = str2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
