Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = ""
        Dim m, x, y, pi As Double
        Dim i, n, tmp As Long
        Dim dig As Integer = 1
        m = 0
        n = Int(TextBox1.Text)
        tmp = n / 10

        For i = 1 To n

            x = Rnd()
            y = Rnd()

            If x * x + y * y <= 1 Then
                m += 1
            End If

            pi = m / n * 4

            If i = 10 * dig Then

                Label1.Text &= "回数=" & i & "　　　　　" & "pi=" & pi * tmp & vbCrLf
                dig *= 10
                tmp /= 10
            End If


        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
