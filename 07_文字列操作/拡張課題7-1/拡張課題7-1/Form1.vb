Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = ""
        Dim str3 As String = ""
        Dim i, j As Integer
        j = Len(str1)
        i = InStr(str1, "　")
        str2 = Mid(str1, 1, i)
        str2 = RTrim(str2)

        str3 = Mid(str1, i, j)

        Label3.Text = str2
        Label5.Text = str3
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
