Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As String
        Dim b, c As Integer
        b = 1

        a = InputBox("暗号を入力してください", "暗号を入力")
        If a <> "0480210761" Then
            b = 0
        End If
        Try
            c = 114514 / b
        Catch
            a = InputBox("暗号が間違っています。再入力してください", "再入力してください")
        Finally
            If a = "0480210761" Then


                MsgBox("暗号が読み込まれました。")
            Else
                MsgBox("暗号が間違っています。")
            End If
        End Try
    End Sub
End Class
