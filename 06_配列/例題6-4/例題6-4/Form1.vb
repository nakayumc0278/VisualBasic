Public Class Form1
    Dim jyunban As Integer = 2
    Dim box(,) As Integer = {{0, 0, 0}, {0, 0, 0}, {0, 0, 0}}
    Dim i, j As Integer

    Private Sub cmdSTART_Click(sender As Object, e As EventArgs) Handles cmdSTART.Click
        lbl_Next.Text = "〇の番です"

        If RadioButton1.Checked Then
            If jyunban = 1 Then
                box(0, 0) = 1
            ElseIf jyunban = 2 Then
                box(0, 0) = 2
            End If
        End If
        If RadioButton2.Checked Then
            If jyunban = 1 Then
                box(0, 1) = 1
            ElseIf jyunban = 2 Then
                box(0, 1) = 2
            End If
        End If
        If RadioButton3.Checked Then
            If jyunban = 1 Then
                box(0, 2) = 1
            ElseIf jyunban = 2 Then
                box(0, 2) = 2
            End If
        End If
        If RadioButton4.Checked Then
            If jyunban = 1 Then
                box(1, 0) = 1
            ElseIf jyunban = 2 Then
                box(1, 0) = 2
            End If
        End If
        If RadioButton5.Checked Then
            If jyunban = 1 Then
                box(1, 1) = 1
            ElseIf jyunban = 2 Then
                box(1, 1) = 2
            End If
        End If
        If RadioButton6.Checked Then
            If jyunban = 1 Then
                box(1, 2) = 1
            ElseIf jyunban = 2 Then
                box(1, 2) = 2
            End If
        End If
        If RadioButton7.Checked Then
            If jyunban = 1 Then
                box(2, 0) = 1
            ElseIf jyunban = 2 Then
                box(2, 0) = 2
            End If
        End If
        If RadioButton8.Checked Then
            If jyunban = 1 Then
                box(2, 1) = 1
            ElseIf jyunban = 2 Then
                box(2, 1) = 2
            End If
        End If
        If RadioButton9.Checked Then
            If jyunban = 1 Then
                box(2, 2) = 1
            ElseIf jyunban = 2 Then
                box(2, 2) = 2
            End If
        End If

        If box(0, 0) = 1 Then
            Label1.Text = "〇"
        ElseIf box(0, 0) = 2 Then
            Label1.Text = "×"
        End If
        If box(0, 1) = 1 Then
            Label2.Text = "〇"
        ElseIf box(0, 1) = 2 Then
            Label2.Text = "×"
        End If
        If box(0, 2) = 1 Then
            Label3.Text = "〇"
        ElseIf box(0, 2) = 2 Then
            Label3.Text = "×"
        End If
        If box(1, 0) = 1 Then
            Label4.Text = "〇"
        ElseIf box(1, 0) = 2 Then
            Label4.Text = "×"
        End If
        If box(1, 1) = 1 Then
            Label5.Text = "〇"
        ElseIf box(1, 1) = 2 Then
            Label5.Text = "×"
        End If
        If box(1, 2) = 1 Then
            Label6.Text = "〇"
        ElseIf box(1, 2) = 2 Then
            Label6.Text = "×"
        End If
        If box(2, 0) = 1 Then
            Label7.Text = "〇"
        ElseIf box(2, 0) = 2 Then
            Label7.Text = "×"
        End If
        If box(2, 1) = 1 Then
            Label8.Text = "〇"
        ElseIf box(2, 1) = 2 Then
            Label8.Text = "×"
        End If
        If box(2, 2) = 1 Then
            Label9.Text = "〇"
        ElseIf box(2, 2) = 2 Then
            Label9.Text = "×"
        End If
        For i = 0 To 2
            If box(i, 0) = 1 And box(i, 1) = 1 And box(i, 2) = 1 Then
                MessageBox.Show("〇の勝ちです")
            ElseIf box(i, 0) = 2 And box(i, 1) = 2 And box(i, 2) = 2 Then
                MessageBox.Show("xの勝ちです")
            End If
        Next
        For j = 0 To 2
            If box(0, j) = 1 And box(1, j) = 1 And box(2, j) = 1 Then
                MessageBox.Show("〇の勝ちです")
            ElseIf box(0, j) = 2 And box(1, j) = 2 And box(2, j) = 2 Then
                MessageBox.Show("xの勝ちです")
            End If
        Next
        For i = 0 To 2
            If box(0, 0) = 1 And box(1, 1) = 1 And box(2, 2) = 1 Then
                MessageBox.Show("〇の勝ちです")
            ElseIf box(0, 0) = 2 And box(1, 1) = 2 And box(2, 2) = 2 Then
                MessageBox.Show("xの勝ちです")
            End If
        Next
        For i = 0 To 2
            If box(0, 2) = 1 And box(1, 1) = 1 And box(2, 0) = 1 Then
                MessageBox.Show("〇の勝ちです")
            ElseIf box(0, 2) = 2 And box(1, 1) = 2 And box(2, 0) = 2 Then
                MessageBox.Show("xの勝ちです")
            End If
        Next

        If jyunban = 1 Then
            jyunban = 2
        ElseIf jyunban = 2 Then
            jyunban = 1
        End If

        If jyunban = 1 Then
            lbl_Next.Text = "〇の番です"
        ElseIf jyunban = 2 Then
            lbl_Next.Text = "xの番です"
        End If
    End Sub


    Private Sub cmdCLR_Click(sender As Object, e As EventArgs) Handles cmdCLR.Click
        For i = 0 To 2
            For j = 0 To 2
                box(i, j) = 0
            Next
        Next
        jyunban = 1
        If RadioButton1.Visible Then
            lbl_Next.Text = "〇の番です"
        End If
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        Label8.Text = ""
        Label9.Text = ""
    End Sub
End Class