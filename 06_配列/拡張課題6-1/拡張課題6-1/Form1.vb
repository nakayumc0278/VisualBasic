Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ei(0, 11), wa(0, 11) As String
        Dim suu As Integer
        ei(0, 0) = "January"
        ei(0, 1) = "Feburary"
        ei(0, 2) = "March"
        ei(0, 3) = "Aplil"
        ei(0, 4) = "May"
        ei(0, 5) = "June"
        ei(0, 6) = "July"
        ei(0, 7) = "August"
        ei(0, 8) = "September"
        ei(0, 9) = "October"
        ei(0, 10) = "November"
        ei(0, 11) = "December"
        wa(0, 0) = "睦月"
        wa(0, 1) = "如月"
        wa(0, 2) = "弥生"
        wa(0, 3) = "卯月"
        wa(0, 4) = "皐月"
        wa(0, 5) = "水無月"
        wa(0, 6) = "文月"
        wa(0, 7) = "葉月"
        wa(0, 8) = "長月"
        wa(0, 9) = "神無月"
        wa(0, 10) = "霜月"
        wa(0, 11) = "師走"

        suu = TextBox1.Text
        If RadioButton1.Checked Then
            If suu = 1 Then
                Label1.Text = ei(0, 0)
            ElseIf suu = 2 Then
                Label1.Text = ei(0, 1)
            ElseIf suu = 3 Then
                Label1.Text = ei(0, 2)
            ElseIf suu = 4 Then
                Label1.Text = ei(0, 3)
            ElseIf suu = 5 Then
                Label1.Text = ei(0, 4)
            ElseIf suu = 6 Then
                Label1.Text = ei(0, 5)
            ElseIf suu = 7 Then
                Label1.Text = ei(0, 6)
            ElseIf suu = 8 Then
                Label1.Text = ei(0, 7)
            ElseIf suu = 9 Then
                Label1.Text = ei(0, 8)
            ElseIf suu = 10 Then
                Label1.Text = ei(0, 9)
            ElseIf suu = 11 Then
                Label1.Text = ei(0, 10)
            ElseIf suu = 12 Then
                Label1.Text = ei(0, 11)
            End If
        ElseIf RadioButton2.Checked Then
            If suu = 1 Then
                Label1.Text = wa(0, 0)
            ElseIf suu = 2 Then
                Label1.Text = wa(0, 1)
            ElseIf suu = 3 Then
                Label1.Text = wa(0, 2)
            ElseIf suu = 4 Then
                Label1.Text = wa(0, 3)
            ElseIf suu = 5 Then
                Label1.Text = wa(0, 4)
            ElseIf suu = 6 Then
                Label1.Text = wa(0, 5)
            ElseIf suu = 7 Then
                Label1.Text = wa(0, 6)
            ElseIf suu = 8 Then
                Label1.Text = wa(0, 7)
            ElseIf suu = 9 Then
                Label1.Text = wa(0, 8)
            ElseIf suu = 10 Then
                Label1.Text = wa(0, 9)
            ElseIf suu = 11 Then
                Label1.Text = wa(0, 10)
            ElseIf suu = 12 Then
                Label1.Text = wa(0, 11)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
