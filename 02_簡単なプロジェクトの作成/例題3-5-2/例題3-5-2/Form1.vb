Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kosu, tanka, kin As Long
        kosu = Val(Microsoft.VisualBasic.Left（TextBox1.Text, 3))
        tanka = Val(Microsoft.VisualBasic.Right(TextBox1.Text, 6))

        kin = kosu * tanka
        Label3.Text = Format(kin, "#,##0")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
