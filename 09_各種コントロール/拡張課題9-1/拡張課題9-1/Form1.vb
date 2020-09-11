Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim year, ans As Integer
        year = TextBox1.Text
        If rdo_Meiji.Checked = True Then
            ans = 1868 + year - 1
        ElseIf rdo_Taisyo.Checked = True Then
            ans = 1912 + year - 1
        ElseIf rdo_Showa.Checked = True Then
            ans = 1926 + year - 1
        ElseIf rdo_Heisei.Checked = True Then
            ans = 1989 + year - 1
        ElseIf rdo_Reiwa.Checked = True Then
            ans = 2019 + year - 1
        End If
        Label3.Text = ans
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
