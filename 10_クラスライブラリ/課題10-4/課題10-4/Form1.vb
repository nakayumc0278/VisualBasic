Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim kaisu As Integer = TextBox1.Text
        Dim i, u, v, w, x, y, z As Integer

        For i = 1 To kaisu

            Randomize()
            Dim value As Integer = CInt(Int((6 * Rnd()) + 1))

            Select Case value
                Case 1
                    u += 1
                Case 2
                    v += 1
                Case 3
                    w += 1
                Case 4
                    x += 1
                Case 5
                    y += 1
                Case 6
                    z += 1
            End Select
        Next

        Label_1.Text = u
        Label_2.Text = v
        Label_3.Text = w
        Label_4.Text = x
        Label_5.Text = y
        Label_6.Text = z
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
