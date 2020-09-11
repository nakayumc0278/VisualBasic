Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, r, s, c, t As Single

        Label2.Text &= "  a   sin(a)     cos(a)     tan(a)" & vbCrLf
        Label2.Text &= "-------------------------------" & vbCrLf

        For a = 0 To 90 Step 10
            r = a * 3.14159 / 180
            s = Math.Sin(r)
            c = Math.Cos(r)
            t = Math.Tan(r)

            Label2.Text &= (Format(a, " 00"))
            Label2.Text &= (Format(s, "  00.###0"))
            Label2.Text &= (Format(c, "  00.###0"))

            If a = 90 Then
                Label2.Text &= "   ∞" & vbCrLf
            Else
                Label2.Text &= (Format(t, " 00.###0")) & vbCrLf
            End If
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
