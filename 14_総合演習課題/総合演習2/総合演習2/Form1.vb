Public Class Form1
    Dim enzan As Integer
    Dim saki As Long = 0
    Dim ato As Long = 0
    Private Sub btnX_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        If enzan <> 0 Then
            If ato = 0 Then
                ato = CType(sender, Windows.Forms.Button).Text
                TextBox1.Text = CStr(ato)
            Else
                ato = ato * 10 + CType(sender, Windows.Forms.Button).Text
                TextBox1.Text = CStr(ato)
            End If
        ElseIf saki = 0 Then
            saki = CType(sender, Windows.Forms.Button).Text
            TextBox1.Text = CStr(saki)
        Else
            saki = saki * 10 + CType(sender, Windows.Forms.Button).Text
            TextBox1.Text = CStr(saki)
        End If
    End Sub

    Private Sub btnON_Click(sender As Object, e As EventArgs) Handles btnON.Click
        TextBox1.Text = CStr(0)
        ato = 0
        saki = 0
        enzan = 0
    End Sub

    Private Sub btnOFF_Click(sender As Object, e As EventArgs) Handles btnOFF.Click
        Close()
    End Sub

    Private Sub BtnPLS_Click(sender As Object, e As EventArgs) Handles BtnPLS.Click
        enzan = 1
    End Sub

    Private Sub btnMNS_Click(sender As Object, e As EventArgs) Handles btnMNS.Click
        enzan = 2
    End Sub

    Private Sub btnEQL_Click(sender As Object, e As EventArgs) Handles btnEQL.Click
        Select Case enzan
            Case 1
                saki += ato
                TextBox1.Text = CStr(saki)
                ato = 0
                enzan = 0
            Case 2
                saki -= ato
                TextBox1.Text = CStr(saki)
                ato = 0
                enzan = 0
        End Select
    End Sub

    Private Sub btnCLR_Click(sender As Object, e As EventArgs) Handles btnCLR.Click
        saki = 0
        enzan = 0
        TextBox1.Text = ""
    End Sub
End Class
