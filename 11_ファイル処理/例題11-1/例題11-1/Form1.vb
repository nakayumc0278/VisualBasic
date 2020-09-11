Public Class Form1
    Private Sub 開くToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 開くToolStripMenuItem.Click
        Dim d As DialogResult
        Dim n As Integer = FreeFile()
        Dim readdata As String
        Const OpenFile As String = ""
        d = OpenFileDialog1.ShowDialog()
        If d = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        TextBox1.Text = ""
        Me.Text = "読み込み中"

        FileOpen(n, OpenFileDialog1.FileName, OpenMode.Input)
        Do Until EOF(n)
            readdata = LineInput(n)
            TextBox1.Text += readdata & vbCrLf
        Loop
        Me.Text = "例題11-1 簡易メモ帳"
        FileClose()
    End Sub

    Private Sub 印刷ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 印刷ToolStripMenuItem.Click
        Dim d As DialogResult
        PrintDialog1.Document = PrintDocument1
        d = PrintDialog1.ShowDialog()
        If d = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub 保存ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 保存ToolStripMenuItem.Click
        Dim d As DialogResult
        Dim n As Integer
        d = SaveFileDialog1.ShowDialog()
        If d = Windows.Forms.DialogResult.Cancel Then
            Exit Sub
        End If
        n = FreeFile()
        FileOpen(n, SaveFileDialog1.FileName, OpenMode.Output)
        Print(n, TextBox1.Text)
        Me.Text = "書き込み中"
        FileClose(n)
        Me.Text = "例題11-1 簡易メモ帳"
    End Sub

    Private Sub 終了ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles 終了ToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, New Font("MSゴシック", 12), New SolidBrush(Color.Black), 10, 10)
    End Sub
End Class
