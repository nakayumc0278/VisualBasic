Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        LblYear.BackColor = Color.Transparent
        LblMan.BackColor = Color.Transparent
        LblDay.BackColor = Color.Transparent
        LblWeek.BackColor = Color.Transparent

        With lblTimer
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

        Dim dtNow As DateTime = DateTime.Now
        Dim MyYear As Integer = dtNow.Year
        Dim MyMonth As Integer = dtNow.Month
        Dim MyDay As Integer = dtNow.Day
        Dim MyWeekday As DayOfWeek = dtNow.DayOfWeek

        LblYear.Text = MyYear & "年"
        LblMan.Text = MyMonth & "月"
        LblDay.Text = MyDay & "日"
        LblWeek.Text = "(" & WeekdayName(MyWeekday) & ")"

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTimer.Text = TimeOfDay
    End Sub
End Class
