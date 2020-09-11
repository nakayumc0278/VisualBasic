<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.LblWeek = New System.Windows.Forms.Label()
        Me.LblDay = New System.Windows.Forms.Label()
        Me.LblMan = New System.Windows.Forms.Label()
        Me.LblYear = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblTimer
        '
        Me.lblTimer.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblTimer.Location = New System.Drawing.Point(216, 288)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(206, 29)
        Me.lblTimer.TabIndex = 9
        Me.lblTimer.Text = "Time"
        Me.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblWeek
        '
        Me.LblWeek.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblWeek.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblWeek.Location = New System.Drawing.Point(409, 213)
        Me.LblWeek.Name = "LblWeek"
        Me.LblWeek.Size = New System.Drawing.Size(139, 29)
        Me.LblWeek.TabIndex = 8
        Me.LblWeek.Text = "曜日"
        Me.LblWeek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblDay
        '
        Me.LblDay.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblDay.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblDay.Location = New System.Drawing.Point(303, 213)
        Me.LblDay.Name = "LblDay"
        Me.LblDay.Size = New System.Drawing.Size(100, 29)
        Me.LblDay.TabIndex = 7
        Me.LblDay.Text = "日"
        Me.LblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMan
        '
        Me.LblMan.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblMan.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblMan.Location = New System.Drawing.Point(197, 213)
        Me.LblMan.Name = "LblMan"
        Me.LblMan.Size = New System.Drawing.Size(100, 29)
        Me.LblMan.TabIndex = 6
        Me.LblMan.Text = "月"
        Me.LblMan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblYear
        '
        Me.LblYear.Font = New System.Drawing.Font("MS UI Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LblYear.ForeColor = System.Drawing.Color.MediumAquamarine
        Me.LblYear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblYear.Location = New System.Drawing.Point(74, 213)
        Me.LblYear.Name = "LblYear"
        Me.LblYear.Size = New System.Drawing.Size(117, 29)
        Me.LblYear.TabIndex = 5
        Me.LblYear.Text = "年"
        Me.LblYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.総合演習4.My.Resources.Resources.P1110292
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(616, 383)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.LblWeek)
        Me.Controls.Add(Me.LblDay)
        Me.Controls.Add(Me.LblMan)
        Me.Controls.Add(Me.LblYear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "時計"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTimer As Label
    Friend WithEvents LblWeek As Label
    Friend WithEvents LblDay As Label
    Friend WithEvents LblMan As Label
    Friend WithEvents LblYear As Label
    Friend WithEvents Timer1 As Timer
End Class
