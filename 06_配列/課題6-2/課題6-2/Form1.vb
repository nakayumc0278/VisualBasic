Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a(5, 4), sum(5) As Integer
        Dim i, j As Integer
        Dim avg(5) As Double
        Label1.Text &= "国 数 理 社 英 合計 平均" & ControlChars.CrLf
        a(0, 0) = 65
        a(0, 1) = 71
        a(0, 2) = 74
        a(0, 3) = 82
        a(0, 4) = 97

        a(1, 0) = 84
        a(1, 1) = 83
        a(1, 2) = 74
        a(1, 3) = 64
        a(1, 4) = 65

        a(2, 0) = 74
        a(2, 1) = 74
        a(2, 2) = 78
        a(2, 3) = 80
        a(2, 4) = 78

        a(3, 0) = 90
        a(3, 1) = 90
        a(3, 2) = 90
        a(3, 3) = 90
        a(3, 4) = 90

        a(4, 0) = 87
        a(4, 1) = 78
        a(4, 2) = 85
        a(4, 3) = 60
        a(4, 4) = 88

        a(5, 0) = 93
        a(5, 1) = 95
        a(5, 2) = 94
        a(5, 3) = 92
        a(5, 4) = 95

        For i = 0 To 5
            For j = 0 To 4
                Label1.Text &= a(i, j) & ControlChars.Tab
                Label1.Text &= (" ")
                sum(i) = a(i, j) + sum(i)
            Next
            Label1.Text &= (sum(i)) & ControlChars.NullChar
            Label1.Text &= ControlChars.Tab
            Label1.Text &= (" ")
            avg(i) = sum(i) / 5.0
            Label1.Text &= Format(avg(i), "###.#")
            Label1.Text &= ControlChars.CrLf
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
