Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim y, m, d, s As Integer
        y = TextBox1.Text
        m = TextBox2.Text
        d = TextBox3.Text
        If (m < 2) Then
            m = m + 12
            y = y - 1
        End If
        zeller(y, m, d, s)

        Select Case (s)
            Case 1
                Label4.Text = ("日曜日")
            Case 2
                Label4.Text = ("月曜日")
            Case 3
                Label4.Text = ("火曜日")
            Case 4
                Label4.Text = ("水曜日")
            Case 5
                Label4.Text = ("木曜日")
            Case 6
                Label4.Text = ("金曜日")
            Case 0
                Label4.Text = ("土曜日")
        End Select

    End Sub
    Private Function zeller(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByRef z As Integer)
        Dim x As Integer
        x = a + a / 4 - a / 100 + a / 400 + (13 * b + 8) / 5 + c
        z = x Mod 7
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
