Public Class Form1
    Private Sub cmdCLT_Click(sender As Object, e As EventArgs) Handles cmdCLT.Click
        Dim msg As String
        If chkAPPL.Checked Then
            msg = "りんご"
        ElseIf chkBNN.Checked Then
            msg = "バナナ"
        ElseIf chkORG.Checked Then
            msg = "オレンジ"
        End If
        msg &= "が選択されました。"
        MessageBox.Show(msg, "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub cmdCLR_Click(sender As Object, e As EventArgs) Handles cmdCLR.Click
        chkORG.Checked = False
        chkAPPL.Checked = False
        chkBNN.Checked = False
    End Sub

    Private Sub cmdEND_Click(sender As Object, e As EventArgs) Handles cmdEND.Click
        Me.Close()
    End Sub
End Class
