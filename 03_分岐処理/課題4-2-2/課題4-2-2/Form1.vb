Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nen, goraku, sum As Double
        nen = Val(TextBox1.Text)
        goraku = Val(TextBox2.Text)

        sum = goraku / nen * 100

        If sum < 10 Then
            Label3.Text = "もっと使ってもOKです"
        ElseIf sum < 20 Then
            Label3.Text = "使ってもOKです"
        ElseIf sum < 40 Then
            Label3.Text = "ちょうどいいくらいです"
        ElseIf sum < 60 Then
            Label3.Text = "ちょっと使いすぎです"
        Else
            Label3.Text = "使いすぎです"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
