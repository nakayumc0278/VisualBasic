Public Class Form1
    Private work, sex As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        work = "学生"
        rdoStudent.Checked = True
        rdoMan.Checked = True
    End Sub
    Private Sub rdostudent_CheckedChenged(sender As Object, e As EventArgs) Handles rdoStudent.CheckedChanged
        work = "学生"
    End Sub
    Private Sub rdoSalaryman_CheckedChenged(sender As Object, e As EventArgs) Handles rdoSalaryman.CheckedChanged
        work = "サラリーマン"
    End Sub
    Private Sub rdoSelfEmp_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSelfEmp.CheckedChanged
        work = "自営業"
    End Sub
    Private Sub rdoOther_checked(sender As Object, e As EventArgs) Handles rdoOther.CheckedChanged
        work = "その他"
    End Sub
    Private Sub rdoMan_Checked(sender As Object, e As EventArgs) Handles rdoMan.CheckedChanged
        sex = "男性"
    End Sub
    Private Sub rdoWoman_Chencked(sender As Object, e As EventArgs) Handles rdoWoman.CheckedChanged
        sex = "女性"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmdEnter.Click
        lblAnser.Text = work & "," & sex
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles rdoEnd.Click
        Me.Close()
    End Sub
End Class
