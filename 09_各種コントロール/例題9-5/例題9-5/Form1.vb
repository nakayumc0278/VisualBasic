Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click
        lblType.Text = lstType.SelectedItem
        lblOs.Text = lstOs.SelectedItem
        lblApp.Text = lstApp.SelectedItem
        lblPcs.Text = lstPcs.SelectedItem

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
