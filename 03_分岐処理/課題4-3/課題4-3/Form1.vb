Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim koku, sugaku, rika, shakai, eigo
        koku = TextBox1.Text
        sugaku = TextBox2.Text
        rika = TextBox3.Text
        shakai = TextBox4.Text
        eigo = TextBox5.Text

        Select Case koku
            Case >= 80
                Label6.Text = "優"
            Case >= 60
                Label6.Text = "良"
            Case Is >= 40
                Label6.Text = "可"
            Case Else
                Label6.Text = "不可"
        End Select

        Select Case sugaku
            Case >= 80
                Label7.Text = "優"
            Case >= 60
                Label7.Text = "良"
            Case Is >= 40
                Label7.Text = "可"
            Case Else
                Label7.Text = "不可"
        End Select

        Select Case rika
            Case >= 80
                Label8.Text = "優"
            Case >= 60
                Label8.Text = "良"
            Case Is >= 40
                Label8.Text = "可"
            Case Else
                Label8.Text = "不可"
        End Select

        Select Case shakai
            Case >= 80
                Label9.Text = "優"
            Case >= 60
                Label9.Text = "良"
            Case Is >= 40
                Label9.Text = "可"
            Case Else
                Label9.Text = "不可"
        End Select

        Select Case eigo
            Case >= 80
                Label10.Text = "優"
            Case >= 60
                Label10.Text = "良"
            Case Is >= 40
                Label10.Text = "可"
            Case Else
                Label10.Text = "不可"
        End Select

        If Label6.Text = "不可" Or Label7.Text = "不可" Or Label8.Text = "不可" Or Label9.Text = "不可" Or Label10.Text = "不可" Then
            Label11.Text = "不合格"
        Else
            Label11.Text = "合格"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
