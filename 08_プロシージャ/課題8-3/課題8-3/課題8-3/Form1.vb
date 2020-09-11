Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name() As String = {"a", "b", "c", "d", "e"}
        Dim hei() As Single = {"162.0", "148.7", "172.5", "165.3", "182.6"}
        Dim rank() As Integer = {"0", "0", "0", "0", "0"}
        Call Ranking(name, hei, rank)
    End Sub
    Private Sub Ranking(ByVal a() As String, ByVal b() As Single, ByVal c() As Integer)
        Dim i As Integer
        For i = 0 To 4
            c(i) = 1
            If b(i) < b(0) Then
                c(i) += 1
            End If
            If b(i) < b(1) Then
                c(i) += 1
            End If
            If b(i) < b(2) Then
                c(i) += 1
            End If
            If b(i) < b(3) Then
                c(i) += 1
            End If
            If b(i) < b(4) Then
                c(i) += 1
            End If
            TextBox1.Text &= a(i) & vbTab & Format(b(i), "###.0") & vbTab & c(i) & vbCrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
