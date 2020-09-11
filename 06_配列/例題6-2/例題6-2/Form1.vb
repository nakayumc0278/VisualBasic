Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a() As Integer = {151, 81, 102, 96, 15, 68}
        Dim namae() As String = {"商社", "金融", "製造業", "サービス", "マスコミ", "その他"}
        Dim i, kei As Integer
        Dim p(5) As Single

        kei = 0
        TextBox1.Text &= "就業先" & ControlChars.Tab & "学生数" & ControlChars.Tab & "割合" & ControlChars.CrLf

        For i = 0 To 5
            kei = kei + a(i)
        Next

        For i = 0 To 5
            p(i) = a(i) / kei
            TextBox1.Text &= namae(i) & ControlChars.Tab & Str(a(i)) & ControlChars.Tab & Format(p(i), "###.0%") & ControlChars.CrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
