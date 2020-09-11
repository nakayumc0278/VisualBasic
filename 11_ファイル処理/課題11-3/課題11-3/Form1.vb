Public Class Form1
    Dim address(100, 10) As String
    Dim n As Integer = FreeFile()
    Dim i, rec, maxrec As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FileOpen(n, "H:\課題11-3-2.txt", OpenMode.input)
           i = 0
        Do Until EOF(n)
            i += 1
            Input(n, address(i, 1))
            Input(n, address(i, 2))
            Input(n, address(i, 3))
        Loop
        maxrec = i
        FileClose(n)
                For i = 1 To maxrec
            For j = 1 To 6
                TextBox1.Text &= address(i, j) & "　　　　　"
            Next
            textbox1.Text &= vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
