Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kodukai, k As Integer
        kodukai = 1
        For k = 2 To 100
            kodukai = kodukai * 2
            If kodukai >= 10000 Then Exit For
        Next k
        Label1.Text = Format(k, "###日目")
        Label2.Text = Format(kodukai, "###,###円です")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
