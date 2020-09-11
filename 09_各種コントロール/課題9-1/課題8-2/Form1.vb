Public Class Form1
    Private Sub cmdCLT_Click(sender As Object, e As EventArgs) Handles cmdCLT.Click
        Dim msg As String
        Dim a As String = ""
        Dim b As String = ""
        Dim o As String = ""
        If chkAPPL.Checked = True Then
            Apple(a)
        ElseIf chkAPPL.Checked = True And chkBNN.Checked = True Then
            Apple(a)
            Banana(b)
        ElseIf chkAPPL.Checked = True And chkORG.Checked = True Then
            Apple(a)
            Orange(o)
        End If
        If chkBNN.Checked = True Then
            Banana(b)
        ElseIf chkBNN.Checked = True And chkORG.Checked = True Then
            Banana(b)
            Orange(o)
        End If
        If chkORG.Checked Then
            Orange(o)
        End If
        If chkAPPL.Checked = False And chkBNN.Checked = False And chkORG.Checked = False Then
            MessageBox.Show("選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        If chkAPPL.Checked = True Or chkBNN.Checked = True Or chkORG.Checked = True Then
            MessageBox.Show(a & b & o & "が選択されました。", "結果", MessageBoxButtons.OK, MessageBoxIcon.None)
        End If
        a = ""
        b = ""
        o = ""
    End Sub

    Private Sub Apple(ByRef ringo)
        If chkBNN.Checked = True Or chkORG.Checked = True Then
            ringo = "りんご と "
        Else
            ringo = "りんご"
        End If
    End Sub
    Private Sub Banana(ByRef yellow)
        If chkORG.Checked = True Then
            yellow = "バナナ と "
        Else
            yellow = "バナナ"
        End If
    End Sub
    Private Sub Orange(ByRef mikan)
        mikan = "オレンジ"
    End Sub

    Private Sub cmdCLR_Click(sender As Object, e As EventArgs) Handles cmdCLR.Click
        chkORG.Checked = False
        chkAPPL.Checked = False
        chkBNN.Checked = False
    End Sub
    Private Sub cmdEND_Click(sender As Object, e As EventArgs) Handles cmdEND.Click
        Me.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
