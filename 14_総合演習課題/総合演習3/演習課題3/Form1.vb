Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Label1.Text = "求めたい値を上記の選択肢から選択してください。"
    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label2.Text = "溶質"
            Label4.Text = "g"
            Label3.Text = "溶媒"
            Label1.Text = "濃度計算が選択されました。液体に溶かした物質の濃度を計算します。"
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label2.Text = "濃度"
            Label4.Text = "%"
            Label3.Text = "溶液"
            Label1.Text = "溶質計算が選択されました。溶液中に含まれる溶質の量を計算します。"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked = True Then
            Label2.Text = "濃度"
            Label4.Text = "%"
            Label3.Text = "溶質"
            Label1.Text = "溶媒計算が選択されました。その濃度の溶液にするにはどれくらいの液体が必要なのかを計算します。"
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ans, eki As Double
        If RadioButton1.Checked = True Then
            ans = Val(TextBox1.Text) / (Val(TextBox1.Text) + (TextBox2.Text)) * 100
            Label6.Text = "濃度は" & Format(ans, "#0.##0") & "%です。"
        ElseIf RadioButton2.Checked = True Then
            ans = Val(TextBox2.Text) * Val(TextBox1.Text) / 100
            Label6.Text = "溶質は" & Format(ans, "#0.##0") & "gです。"
        ElseIf RadioButton3.Checked = True Then
            eki = Val(TextBox2.Text) / (Val(TextBox1.Text) / 100)
            ans = eki - Val(TextBox2.Text)
            Label6.Text = "溶媒は" & Format(ans, "#0.##0") & "gです。" & "溶液としては" & eki & "になるようにしてください。"
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        Label2.Text = "溶質"
        Label3.Text = "溶媒"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show("終了しますか。", "確認", MessageBoxButtons.YesNo)
        Me.Close()
    End Sub
End Class
