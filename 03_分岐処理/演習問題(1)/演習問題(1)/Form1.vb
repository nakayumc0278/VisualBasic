Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim weight, height, bmi As Double
        weight = TextBox2.Text
        height = TextBox1.Text

        bmi = weight / (height * height)
        Select Case bmi
            Case <= 18.5
                Label3.Text = "やせ"
            Case <= 25
                Label3.Text = "標準"
            Case <= 30
                Label3.Text = "肥満"
            Case < 30
                Label3.Text = "高度肥満"
        End Select
        Label4.Text = bmi
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
