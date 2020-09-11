Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String = TextBox1.Text
        Dim str2 As String = str.Substring(0, 3)
        Dim str3 As String = str.Substring(3, 3)
        Dim a, r, s As Single

        a = Val(str3)
        r = a * Math.PI / 180
        Select Case str2
            Case "sin"
                s = Math.Sin(r)
            Case "cos"
                s = Math.Cos(r)
            Case "tan"
                s = Math.Tan(r)
        End Select
        s = Format(s, "0.#####")
        Label5.Text &= str2 & str3 & "°" & "の値は" & s & "です" & vbCrLf

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
End Class
