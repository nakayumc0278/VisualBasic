Public Class frmReidai94
    Private Sub frmReidai94_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmdDirection.Items.Add("左")
        cmdDirection.Items.Add("右")
        cmdDirection.Items.Add("上")
        cmdDirection.Items.Add("下")
        picIcon.Left = Me.Width / 2
        picIcon.Top = Me.Height / 2
    End Sub
    Private Sub From1_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Dim rc As Integer
        rc = MessageBox.Show("終了しますか", "終了", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
        If rc = Windows.Forms.DialogResult.Cancel Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdMove_Click(sender As Object, e As EventArgs) Handles cmdMove.Click
        Select Case cmdDirection.Text
            Case "左"
                picIcon.Left -= 10
            Case "右"
                picIcon.Left += 10
            Case "上"
                picIcon.Top -= 10
            Case "下"
                picIcon.Top += 10
        End Select
    End Sub
End Class
