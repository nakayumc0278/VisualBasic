Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, c As Integer
        a = Val(InputBox("aの値を入力しなさい", "aの値を入力"))
        b = Val(InputBox("bの値を入力しなさい", "bの値を入力"))
        Try
            c = a \ b
        Catch
            MsgBox("bの値では割り算できません", MsgBoxStyle.OkCancel, "エラー表示")
            b = Val(InputBox("bの値を入力しなさい", "bの値を再入力"))
        Finally
            c = a \ b
        End Try
        MsgBox("答えは" & c & "です", MsgBoxStyle.OkOnly, "答え")
    End Sub
End Class
