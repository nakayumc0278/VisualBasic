Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = ""
        Dim str3 As String = ""
        Dim str4, str5 As String

        str2 = UCase(str1)

        str4 = Mid(str1, 1, 1)
        str4 = UCase(str4)
        str5 = Mid(str1, 2)


        Label3.Text = str2
        Label5.Text = str4 & str5
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
