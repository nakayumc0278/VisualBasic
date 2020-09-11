Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Label1
            .Text = ""
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.Silver
            .ForeColor = Color.Red
            .TextAlign = ContentAlignment.MiddleCenter
        End With
        With Label2
            .Text = ""
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.Silver
            .ForeColor = Color.Red
            .TextAlign = ContentAlignment.MiddleCenter
        End With
        With Timer1
            .Interval = 1
            .Start()
        End With
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Today
        If RadioButton1.Checked = True Then
            Label2.Text = DateTime.Now.ToString("tt h:mm:ss")
        ElseIf RadioButton2.Checked = True Then
            Label2.Text = TimeOfDay
        End If
    End Sub
End Class
