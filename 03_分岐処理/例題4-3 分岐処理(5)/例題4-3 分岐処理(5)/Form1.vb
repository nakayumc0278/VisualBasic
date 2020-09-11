Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kazei, zeigaku As Long
        kazei = Val(TextBox1.Text)
        Select Case kazei
            Case 1000 To 329900
                zeigaku = kazei * 0.1
            Case 3300000 To 8999000
                zeigaku = kazei * 0.2 - 330000
            Case 9000000 To 17999000
                zeigaku = kazei * 0.3 - 1230000
            Case Else
                zeigaku = kazei * 0.37 - 2490000
        End Select
        Label3.Text = Format(zeigaku, "\\###,###,###,###")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        Label3.Text = ""
    End Sub
End Class
