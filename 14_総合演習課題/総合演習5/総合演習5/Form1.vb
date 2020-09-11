Public Class Form1
    Dim hand As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Appearance = Appearance.Button
        RadioButton2.Appearance = Appearance.Button
        RadioButton3.Appearance = Appearance.Button

        RadioButton1.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton2.BackgroundImageLayout = ImageLayout.Stretch
        RadioButton3.BackgroundImageLayout = ImageLayout.Stretch

        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False

        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        hand = 1
        Label4.Visible = True
        Label5.Visible = False
        Label6.Visible = False

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        hand = 2
        Label4.Visible = False
        Label5.Visible = True
        Label6.Visible = False
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        hand = 3
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rd As New Random

        rd.Next(0, 3)

    End Sub
End Class
