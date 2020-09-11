Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c, d, temp As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)

        If a < b Then
            temp = a
            a = b
            b = temp
            d = b - a
        End If
        If a > b Then
            d = a - b
        End If

        For i = 1 To 100

            If a = b Then
                d = a
                Exit For
            End If
            If b = d Then Exit For


            If b < d Then
                d = d - b
            End If
            If b > d Then
                d = b - d
            End If
        Next i
        TextBox4.Text = d

        c = (a * b) / d
        TextBox3.Text = c
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
