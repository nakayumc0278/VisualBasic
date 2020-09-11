Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pic_wow.Visible = True
        pic_smile.Visible = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hei, wei, kihon As Single
        pic_wow.Visible = False
        pic_smile.Visible = False
        hei = Val(txt_hei.Text)
        wei = Val(txt_wei.Text)
        kihon = (hei - 100) * 0.9
        If wei >= kihon * 1.1 Then
            lbl_judge.ForeColor = Color.Red
            lbl_judge.Text = "太りすぎです"
            pic_judge.Image = pic_wow.Image
            pic_judge.Visible = True
        Else
            lbl_judge.ForeColor = Color.Blue
            lbl_judge.Text = "標準です"
            pic_judge.Image = pic_smile.Image
            pic_judge.Visible = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

End Class
