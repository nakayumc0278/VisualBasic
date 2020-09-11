Public Class Form1
    Dim address(100, 10) As String
    Dim n As Integer = FreeFile()
    Dim i, rec, maxrec As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'newdata()
        rec = 1
        maxrec = 0
        label4.Text = "1/新規"
    End Sub

    Sub newdata()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub

    Sub setdata()
        address(rec, 1) = TextBox1.Text
        address(rec, 2) = TextBox2.Text
        address(rec, 3) = TextBox3.Text
    End Sub

    '追加
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        setdata()
        If rec > maxrec Then
            maxrec += 1
            Label4.Text = Str(rec) & " / " & Str(maxrec)
        End If
        newdata()
    End Sub

    '前
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If rec = 1 Then
            Exit Sub
        End If
        rec -= 1
        setdata()
        Label4.Text = Str(rec) & " / " & Str(maxrec)
    End Sub

    '次
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If rec = maxrec Then
            rec = maxrec + 1
            setdata()
            Label4.Text = Str(rec) & " / " & Str(maxrec)
        Else
            rec += 1
            setdata()
            Label4.Text = Str(rec) & " / " & Str(maxrec)
        End If
    End Sub

    '保存
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FileOpen(n, "H:\課題11-3-2.txt", OpenMode.Output)

        For i = 1 To maxrec
            WriteLine(n, address(i, 1), address(i, 2), address(i, 3))
        Next
        FileClose(n)
    End Sub
    '終了
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
