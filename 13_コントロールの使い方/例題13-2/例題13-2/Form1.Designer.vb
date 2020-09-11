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
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.cmdKakunin = New System.Windows.Forms.Button()
        Me.cmdpic = New System.Windows.Forms.Button()
        Me.cmdSyuryo = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.lblDate.Location = New System.Drawing.Point(45, 27)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(107, 15)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "今日の日付は？"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("MS UI Gothic", 11.0!)
        Me.lblTime.Location = New System.Drawing.Point(45, 48)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(107, 15)
        Me.lblTime.TabIndex = 1
        Me.lblTime.Text = "現在の時刻は？"
        '
        'cmdKakunin
        '
        Me.cmdKakunin.Location = New System.Drawing.Point(39, 279)
        Me.cmdKakunin.Name = "cmdKakunin"
        Me.cmdKakunin.Size = New System.Drawing.Size(75, 23)
        Me.cmdKakunin.TabIndex = 2
        Me.cmdKakunin.Text = "確認"
        Me.cmdKakunin.UseVisualStyleBackColor = True
        '
        'cmdpic
        '
        Me.cmdpic.Location = New System.Drawing.Point(194, 279)
        Me.cmdpic.Name = "cmdpic"
        Me.cmdpic.Size = New System.Drawing.Size(75, 23)
        Me.cmdpic.TabIndex = 3
        Me.cmdpic.Text = "絵表示"
        Me.cmdpic.UseVisualStyleBackColor = True
        '
        'cmdSyuryo
        '
        Me.cmdSyuryo.Location = New System.Drawing.Point(360, 279)
        Me.cmdSyuryo.Name = "cmdSyuryo"
        Me.cmdSyuryo.Size = New System.Drawing.Size(75, 23)
        Me.cmdSyuryo.TabIndex = 4
        Me.cmdSyuryo.Text = "終了"
        Me.cmdSyuryo.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.例題13_2.My.Resources.Resources.J0148757
        Me.PictureBox1.Location = New System.Drawing.Point(39, 86)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(396, 167)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 331)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cmdSyuryo)
        Me.Controls.Add(Me.cmdpic)
        Me.Controls.Add(Me.cmdKakunin)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "Form1"
        Me.Text = "例題13-2 ボタンコントロール"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents cmdKakunin As Button
    Friend WithEvents cmdpic As Button
    Friend WithEvents cmdSyuryo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
