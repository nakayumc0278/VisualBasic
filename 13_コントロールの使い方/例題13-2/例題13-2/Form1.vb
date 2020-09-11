Public Class Form1
    Inherits System.Windows.Forms.Form
    Dim flag As Boolean = True
    Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        cmdKakunin.BackColor = Color.AntiqueWhite
        lblDate.Text = "現在の日付と時刻を表示します。"
        lblTime.Text = "[確認]ボタンをクリックしてください。"
    End Sub

    Private Sub cmdKakunin_Click(sender As System.Object, e As System.EventArgs) Handles cmdKakunin.Click
        flag = Not flag
        If flag = True Then
            cmdKakunin.BackColor = Color.AntiqueWhite
            cmdKakunin.Text = "ｽﾄｯﾌﾟｳｫｯﾁ"
        Else
            cmdKakunin.BackColor = Color.DarkSalmon
            cmdKakunin.Text = "現在時刻"
        End If
        With lblTime
            .Text = ""
            .BorderStyle = BorderStyle.Fixed3D
            .BackColor = Color.Azure
            .ForeColor = Color.Red
            .TextAlign = ContentAlignment.MiddleCenter
        End With

        With Timer1
            .Interval = 1
            .Start()
        End With

        lblDate.Text = CStr(Today)
        'lblTime.Text = TimeOfDay
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTime.Text = TimeOfDay
        Timer2.Enabled = False
    End Sub

    Dim datStart As Date
    Dim flg As Boolean = True

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Dim timespan As TimeSpan
        flg = Not flg
        timespan = DateTime.op_Subtraction(Now(), datStart)
        lblTime.Text = Format(timespan.Minutes, "00") & ":" & Format(timespan.Seconds, "00") & ":" & Format(timespan.Milliseconds, "000")
    End Sub
    Private Sub cmdKakunin_MouseDown(ByVal Sender As Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdKakunin.MouseDown
        flg = Not flg
        Dim timespan As TimeSpan
        Timer1.Enabled = False
        Timer2.Enabled = True
        lblTime.Text = Format(timespan.Minutes, "00") & ":" & Format(timespan.Seconds, "00") & ":" & Format(timespan.Milliseconds, "000")
        datStart = Now()
    End Sub

    Private Sub cmdKakunin_MouseUp(ByVal Sender As Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdKakunin.MouseUp
        If flg = True Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If
    End Sub

    Private Sub cmdpic_KeyUp(ByVal Sender As Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmdpic.KeyUp
        cmdpic.BackColor = Color.Azure
        PictureBox1.Visible = True
    End Sub

    Private Sub cmdpic_KeyDown(ByVal sender As Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmdpic.KeyDown
        cmdpic.BackColor = Color.LightGray
        PictureBox1.Visible = False
    End Sub

    Private Sub cmdpic_MouseUp(ByVal sender As Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdpic.MouseUp
        cmdpic.BackColor = Color.Azure
        PictureBox1.Visible = False
    End Sub

    Private Sub cmdpic_MouseDown(ByVal sender As Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles cmdpic.MouseDown
        cmdpic.BackColor = Color.LightGray
        PictureBox1.Visible = True
    End Sub

    Private Sub cmdpic_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpic.MouseHover
        cmdpic.BackColor = Color.LightGreen
        PictureBox1.Visible = True
    End Sub

    Private Sub cmdpic_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdpic.MouseLeave
        cmdpic.BackColor = Color.LightPink
        PictureBox1.Visible = False
    End Sub

    Private Sub cmdSyuryo_Click(sender As Object, e As EventArgs) Handles cmdSyuryo.Click
        Close()
    End Sub
End Class
