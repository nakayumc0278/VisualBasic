Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str1 As String = TextBox1.Text
        Dim str2 As String = ""
        Dim i As Integer = 0
        Dim j As Integer
        For j = Len(str1) To 1 Step -1
            str2 &= Asc(str1(i)) & "　"
            i = i + 1
        Next
        Label3.Text = str2
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
