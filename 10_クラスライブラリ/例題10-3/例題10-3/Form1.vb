Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code, gakka As String
        Dim gakunen, gakuno As Integer
        Dim kamei() As String = {"工業化学科", "環境科学科", "情報技術科", "電 気 科", "機 械 科"}

        code = TextBox2.Text

        gakka = code.Substring(0, 1)
        gakunen = Val(code.Substring(1, 1))
        gakuno = Val(code.Substring(2, 2))

        Select Case gakka
            Case "C"
                Label7.Text = kamei(0)
            Case "S"
                Label7.Text = kamei(1)
            Case "I"
                Label7.Text = kamei(2)
            Case "E"
                Label7.Text = kamei(3)
            Case "M"
                Label7.Text = kamei(4)
        End Select

        Label8.Text = gakunen
        Label9.Text = gakuno
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class
