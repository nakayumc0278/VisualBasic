Public Class オームの計算
    Private Sub オームの計算_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Option1.Checked = True
        Label3.Text = "計算する対象を選択してください！"
    End Sub

    Private Sub Option1_CheckedChanged(sender As Object, e As EventArgs) Handles Option1.CheckedChanged
        If Option1.Checked = True Then
            Label1.Text = "電圧[Ⅴ]"
            Label2.Text = "抵抗[Ω]"
            Label3.Text = "電流を選択"
        End If
    End Sub

    Private Sub Option2_CheckedChanged(sender As Object, e As EventArgs) Handles Option2.CheckedChanged
        If Option2.Checked = True Then
            Label1.Text = "電流[Ａ]"
            Label2.Text = "抵抗[Ω]"
            Label3.Text = "電圧を選択"
        End If
    End Sub

    Private Sub Option3_CheckedChanged(sender As Object, e As EventArgs) Handles Option3.CheckedChanged
        If Option3.Checked = True Then
            Label1.Text = "電圧[Ⅴ]"
            Label2.Text = "電流[Ａ]"
            Label3.Text = "抵抗を選択"
        End If
    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        Dim ans As Double, sans As String
        If Option1.Checked Then
            ans = Val(Text1.Text) / Val(Text2.Text)
            If Math.Abs(ans) < 1 Then
                If ans < 0 Then
                    sans = "-0" & Str(Math.Abs(ans))
                Else
                    sans = "-" & Str(ans)
                End If
            Else
                sans = Str(ans)
            End If
            Label3.Text = "電流は、" & sans & "[Ａ]です。" '結果表示

        ElseIf Option2.Checked = True Then
            ans = Val(Text1.Text) * (Text2.Text)
            If Math.Abs(ans) < 1 Then
                If ans < 0 Then
                    sans = "-0" & Str(Math.Abs(ans))
                Else
                    sans = "0" & Str(Math.Abs(ans))
                End If
            Else
                sans = Str(ans)
            End If
            Label3.Text = "電圧は、" & sans & "[Ⅴ]です。"

        ElseIf Option3.Checked = True Then
            ans = Val(Text1.Text) / (Text2.Text)
            If Math.Abs(ans) < 1 Then
                If ans < 0 Then
                    sans = "-0" & Str(Math.Abs(ans))
                Else
                    sans = "0" & Str(Math.Abs(ans))
                End If
            Else
                sans = Str(ans)
            End If
            Label3.Text = "抵抗は、" & sans & "[Ω]です。"
        End If

    End Sub

    Private Sub Command2_Click(sender As Object, e As EventArgs) Handles Command2.Click
        Text1.Text = ""
        Text2.Text = ""
        Label3.Text = "計算する対象を選択してください"
    End Sub

    Private Sub Command3_Click(sender As Object, e As EventArgs) Handles Command3.Click
        Dim res As MsgBoxResult
        res = MsgBox("終了しますか。", vbYesNo, "確認")
        If res = vbNo Then
            Exit Sub
        End If
        Close()
    End Sub
End Class
