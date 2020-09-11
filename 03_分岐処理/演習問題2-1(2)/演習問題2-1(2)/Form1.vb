Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, height, bmi As Double
        weight = TextBox2.Text
        height = TextBox1.Text

        bmi = weight / (height * height)
        If bmi <= 18.5 Then
            Label5.Text = "痩せすぎです"
        ElseIf bmi <= 25 Then
            Label5.Text = "標準です"
        ElseIf bmi <= 30 Then
            Label5.Text = "肥満です"
        ElseIf bmi > 30 Then
            Label5.Text = "高度肥満です"
        End If
        Label4.Text = bmi
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
