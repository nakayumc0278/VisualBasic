Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kokugo, sugaku, rika, syakai, eigo As Integer
        kokugo = TextBox5.Text
        sugaku = TextBox2.Text
        rika = TextBox4.Text
        syakai = TextBox3.Text
        eigo = TextBox1.Text

        If (eigo >= 80) Then
            Label6.Text = "優"
        ElseIf (eigo >= 60) Then
            Label6.Text = "良"

        ElseIf (eigo >= 40) Then
            Label6.Text = "可"
        Else
            Label6.Text = "不可"
        End If

        If (sugaku >= 80) Then
            Label7.Text = "優"
        ElseIf (sugaku >= 60) Then
            Label7.Text = "良"

        ElseIf (sugaku >= 40) Then
            Label7.Text = "可"
        Else
            Label7.Text = "不可"
        End If

        If (kokugo >= 80) Then
            Label8.Text = "優"
        ElseIf (kokugo >= 60) Then
            Label8.Text = "良"

        ElseIf (kokugo >= 40) Then
            Label8.Text = "可"
        Else
            Label8.Text = "不可"
        End If

        If (rika >= 80) Then
            Label9.Text = "優"
        ElseIf (rika >= 60) Then
            Label9.Text = "良"

        ElseIf (rika >= 40) Then
            Label9.Text = "可"
        Else
            Label9.Text = "不可"
        End If

        If (syakai >= 80) Then
            Label10.Text = "優"
        ElseIf (syakai >= 60) Then
            Label10.Text = "良"

        ElseIf (syakai >= 40) Then
            Label10.Text = "可"
        Else
            Label10.Text = "不可"
        End If

        If Label6.Text = "不可" Or Label7.Text = "不可" Or Label8.Text = "不可" Or Label9.Text = "不可" Or Label10.Text = "不可" Then
            Label12.Text = "不合格"
        Else
            Label12.Text = "合格"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
