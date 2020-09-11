Public Class Form1
    Dim meibo(100, 6) As String
    Dim i, j, rec, maxrec, s As Integer
    Dim n As Integer = FreeFile()

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbo学科.SelectedIndex = -1
        cbo学年.SelectedIndex = -1

        With cbo学科.Items
            .Add("工業化学")
            .Add("環境科学")
            .Add("情報技術")
            .Add("電気　　")
            .Add("機械　　")
        End With
        With cbo学年.Items
            .Add("１年")
            .Add("２年")
            .Add("３年")
            .Add("職員")
        End With
        newdata()
        rec = 1
        maxrec = 0
        lblレコード数表示.Text = "1/新規"
    End Sub

    Sub setdata()
        meibo(rec, 1) = tbx部員番号.Text
        meibo(rec, 2) = tbx氏名.Text
        meibo(rec, 3) = cbo学年.Text
        meibo(rec, 4) = cbo学科.Text
        meibo(rec, 5) = tbx経験年数.Text
        If rbn男性.Checked Then
            meibo(rec, 6) = "男"
        Else
            meibo(rec, 6) = "女"
        End If
    End Sub

    Sub getdata()
        tbx部員番号.Text = meibo(i, 1)
        tbx氏名.Text = meibo(i, 2)
        cbo学科.Text = meibo(i, 3)
        cbo学年.Text = meibo(i, 4)
        tbx経験年数.Text = meibo(i, 5)
        If meibo(i, 6) = "男" Then
            rbn男性.Checked = True
        Else
            rbn女性.Checked = True
        End If
    End Sub

    Sub newdata()
        tbx部員番号.Text = ""
        tbx氏名.Text = ""
        cbo学科.Text = ""
        cbo学年.Text = ""
        tbx経験年数.Text = ""
        rbn女性.Checked = True
    End Sub

    Private Sub btn登録_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn登録.Click
        setdata()
        If rec > maxrec Then
            maxrec += 1
            rbn女性.Checked = True
            lblレコード数表示.Text = Str(rec) & "/" & Str(maxrec)
        End If
    End Sub

    Private Sub btn保存_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn保存.Click
        FileOpen(n, "H:\名簿.txt", OpenMode.Output)
        For i = 1 To maxrec
            WriteLine(n, meibo(i, 1), meibo(i, 2), meibo(i, 3), meibo(i, 4), meibo(i, 5), meibo(i, 6))
        Next
        FileClose(n)
    End Sub

    Private Sub btn追加_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn追加.Click
        FileOpen(n, "H:\名簿.txt", OpenMode.Append)
        For i = 1 To maxrec
            WriteLine(n, meibo(i, 1), meibo(i, 2), meibo(i, 3), meibo(i, 4), meibo(i, 5), meibo(i, 6))
        Next
        FileClose(n)
    End Sub

    Private Sub btn開く_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn開く.Click
        FileOpen(n, "H:\名簿.txt", OpenMode.Input)
        i = 0
        Do Until EOF(n)
            i += 1
            Input(n, meibo(i, 1))
            Input(n, meibo(i, 2))
            Input(n, meibo(i, 3))
            Input(n, meibo(i, 4))
            Input(n, meibo(i, 5))
            Input(n, meibo(i, 6))
        Loop
        maxrec = i
        FileClose(n)
        rec = 1
        getdata()
        lblレコード数表示.Text = Str(rec) & "/" & Str(maxrec)
    End Sub


    Private Sub btn表示_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn表示.Click
        For i = 1 To maxrec
            For j = 1 To 6
                tbxデータ表示.Text &= meibo(i, j) & vbTab
            Next
            tbxデータ表示.Text &= vbCrLf
        Next
    End Sub

    Private Sub btn印刷_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn印刷.Click
        Dim d As DialogResult
        PrintDialog1.Document = PrintDocument1
        d = PrintDialog1.ShowDialog()
        If d = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub printdocument1_pritpage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(tbxデータ表示.Text, New Font("MS明朝", 10), New SolidBrush(Color.Black), 10, 10)
    End Sub

    Private Sub btn終了_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn終了.Click
        Close()
    End Sub

    Private Sub btn前_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn前.Click
        If rec = 1 Then
            Exit Sub
        End If
        rec -= 1
        getdata()
        lblレコード数表示.Text = Str(rec) & "/" & Str(maxrec)
    End Sub

    Private Sub btn次_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn次.Click
        If rec = maxrec Then
            newdata()
            rec = maxrec + 1
            getdata()
            lblレコード数表示.Text = Str(rec) & "/" & Str(maxrec)
        Else
            rec += 1
            getdata()
            lblレコード数表示.Text = Str(rec) & "/" & Str(maxrec)
        End If
    End Sub
End Class
