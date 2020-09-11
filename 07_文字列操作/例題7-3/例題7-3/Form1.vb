Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i, j, k As Integer
        Dim str1, str2 As String
        str1 = TextBox1.Text
        str2 = TextBox2.Text
        k = Len(str2)
        i = 1
        j = 0
        Do
            i = InStr(i, str1, str2)
            If i > 0 Then
                i = i + k
                j = j + 1
            End If
        Loop Until i = 0
        Label3.Text = j
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
