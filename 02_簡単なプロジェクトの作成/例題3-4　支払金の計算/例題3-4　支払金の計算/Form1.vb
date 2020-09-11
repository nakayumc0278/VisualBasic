Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mkosu, rkosu, mkin, rkin, goukei As Integer

        mkosu = Val(TextBox1.Text)
        rkosu = Val(TextBox2.Text)
        mkin = mkosu * 300
        rkin = rkosu * 200
        goukei = mkin + rkin

        Label7.Text = mkin
        Label8.Text = rkin
        Label6.Text = goukei
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
