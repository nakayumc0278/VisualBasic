Public Class Form1
    Private Sub btn_cmd_Click(sender As Object, e As EventArgs) Handles btn_cmd.Click
        Dim talk, Agree, data, opt As Integer
        Dim a, b, c, d, f, g As Integer
        '通話料金
        If chk_endless.Checked = False Then
            talk = txt_talktime.Text * 20
            lbl_talk.Text = talk
        ElseIf chk_endless.Checked = True Then
            talk = 0
        End If
        '契約期間
        If cbo_agreeyaer.SelectedIndex = 0 Or cbo_agreeyaer.SelectedIndex = 1 Then
            Agree = 3000
        ElseIf cbo_agreeyaer.SelectedIndex = 2 Or cbo_agreeyaer.SelectedIndex = 3 Then
            Agree = 3000 * 0.8
        End If
        'データ通信プラン
        If lst_data.SelectedIndex = 0 Then
            data = 800
        ElseIf lst_data.SelectedIndex = 1 Then
            data = 1500
        ElseIf lst_data.SelectedIndex = 2 Then
            data = 2000
        ElseIf lst_data.SelectedIndex = 3 Then
            data = 3000
        ElseIf lst_data.SelectedIndex = 4 Then
            data = 5000
        End If
        'オプション
        If chk_endless.Checked = False Then
            a = 0
        ElseIf chk_endless.Checked = True Then
            a = 1800
        End If
        If chk_sms.Checked = False Then
            b = 0
        ElseIf chk_sms.Checked = True Then
            b = 200
        End If
        If chk_onlinestrage.Checked = False Then
            c = 0
        ElseIf chk_onlinestrage.Checked = True Then
            c = 300
        End If
        If chk_support.Checked = False Then
            d = 0
        ElseIf chk_support.Checked = True Then
            d = 500
        End If
        If chk_comp.Checked = False Then
            f = 0
        ElseIf chk_comp.Checked = True Then
            f = 300
        End If
        If chk_virus.Checked = False Then
            g = 0
        ElseIf chk_virus.Checked = True Then
            g = 100
        End If
        opt = a + b + c + d + f + g

        lbl_talk.Text = talk
        lbl_kihon.Text = Agree
        lbl_data.Text = data
        lbl_option.Text = opt

        lbl_sum.Text = talk + Agree + data + opt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txt_talktime.Text = ""
        cbo_agreeyaer.SelectedIndex = -1
        lst_data.SelectedIndex = -1
        chk_endless.Checked = False
        chk_sms.Checked = False
        chk_onlinestrage.Checked = False
        chk_support.Checked = False
        chk_comp.Checked = False
        chk_virus.Checked = False
        lbl_talk.Text = ""
        lbl_kihon.Text = ""
        lbl_data.Text = ""
        lbl_option.Text = ""
        lbl_sum.Text = ""
    End Sub
    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        Me.Close()
    End Sub

End Class
