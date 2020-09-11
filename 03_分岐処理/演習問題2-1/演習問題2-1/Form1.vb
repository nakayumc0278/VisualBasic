Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, height, bmi As Double
        height = TextBox1.Text
        weight = TextBox2.Text

        bmi = weight / (height * height)

        Select Case bmi
            Case <= 18.5
                Label5.Text = "痩せすぎです"
            Case <= 25
                Label5.Text = "標準です"
            Case <= 30
                Label5.Text = "肥満です"
            Case > 30
                Label5.Text = "高度肥満です"
        End Select
        Label4.Text = bmi
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
