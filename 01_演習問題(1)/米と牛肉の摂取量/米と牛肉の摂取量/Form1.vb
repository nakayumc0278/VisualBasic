Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim raice, beef
        raice = 2200 * 0.85 / 3.52
        beef = 2200 * 0.15 / 1.96
        Label2.Text = Format(raice, "###.#")
        Label3.Text = Format(beef, "###.#")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
