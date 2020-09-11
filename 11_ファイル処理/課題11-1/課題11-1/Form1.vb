Public Class Form1
    Dim n As Integer = FreeFile()

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FileOpen(n, "H:\課題 11-3-2.txt", OpenMode.Input)
        Input(n, TextBox1.Text)
        FileClose(n)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        FileOpen(n, "H:\課題 11-3-2.txt", OpenMode.Output)
        WriteLine(n, TextBox1.Text)
        FileClose(n)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim d As DialogResult
        PrintDialog1.Document = PrintDocument1
        d = PrintDialog1.ShowDialog()
        If d = DialogResult.OK Then
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawString(TextBox1.Text, New Font("MSゴシック", 12), New SolidBrush(Color.Black), 10, 10)
    End Sub
End Class
