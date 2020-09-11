Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kosu, tanka, sum1, sum2, sum, kosu1 As Double
        kosu = TextBox1.Text
        tanka = TextBox2.Text

        Select Case kosu
            Case > 100
                kosu1 = (kosu - 100)
                sum1 = tanka * 100
                sum2 = (kosu1 * tanka) * 0.8

                sum = sum1 + sum2
            Case Else
                sum = kosu * tanka
        End Select
        Label4.Text = sum
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
