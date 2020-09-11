Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = TextBox2.Text
        Dim str3 As String = TextBox3.Text
        Dim i, j, k As Integer
        k = Len(str2)
        j = Len(str3)
        i = 1
        Do
            i = InStr(i, str1, str2)
            If i > 0 Then
                str1 = Mid(str1, 1, i - 1) & str3 & Mid(str1, i + k, Len(str1) - i - k + 1)
            End If
        Loop Until i = 0
        Label5.Text = str1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
