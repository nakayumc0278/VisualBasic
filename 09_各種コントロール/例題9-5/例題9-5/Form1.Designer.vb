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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstType = New System.Windows.Forms.ListBox()
        Me.lstOs = New System.Windows.Forms.ListBox()
        Me.lstApp = New System.Windows.Forms.ListBox()
        Me.lstPcs = New System.Windows.Forms.ListBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblOs = New System.Windows.Forms.Label()
        Me.lblApp = New System.Windows.Forms.Label()
        Me.lblPcs = New System.Windows.Forms.Label()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "種類"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "OS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "アプリケーション"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "数量"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(493, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "数量"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 12)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "アプリケーション"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(493, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "OS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(309, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 12)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "種類"
        '
        'lstType
        '
        Me.lstType.FormattingEnabled = True
        Me.lstType.ItemHeight = 12
        Me.lstType.Items.AddRange(New Object() {"デスクトップ", "ノート", "タブレット"})
        Me.lstType.Location = New System.Drawing.Point(311, 44)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(96, 40)
        Me.lstType.TabIndex = 8
        '
        'lstOs
        '
        Me.lstOs.FormattingEnabled = True
        Me.lstOs.ItemHeight = 12
        Me.lstOs.Items.AddRange(New Object() {"Windows", "Linux", "macOS"})
        Me.lstOs.Location = New System.Drawing.Point(495, 44)
        Me.lstOs.Name = "lstOs"
        Me.lstOs.Size = New System.Drawing.Size(64, 40)
        Me.lstOs.TabIndex = 9
        '
        'lstApp
        '
        Me.lstApp.FormattingEnabled = True
        Me.lstApp.ItemHeight = 12
        Me.lstApp.Items.AddRange(New Object() {"ワープロ", "表計算", "プレゼンテーション", "データベース", "ビデオ編集"})
        Me.lstApp.Location = New System.Drawing.Point(311, 120)
        Me.lstApp.Name = "lstApp"
        Me.lstApp.Size = New System.Drawing.Size(96, 64)
        Me.lstApp.TabIndex = 10
        '
        'lstPcs
        '
        Me.lstPcs.FormattingEnabled = True
        Me.lstPcs.ItemHeight = 12
        Me.lstPcs.Items.AddRange(New Object() {"1", "2", "3", "5", "10", "50", "100"})
        Me.lstPcs.Location = New System.Drawing.Point(495, 122)
        Me.lstPcs.Name = "lstPcs"
        Me.lstPcs.Size = New System.Drawing.Size(64, 40)
        Me.lstPcs.TabIndex = 11
        '
        'lblType
        '
        Me.lblType.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblType.Location = New System.Drawing.Point(110, 25)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(99, 19)
        Me.lblType.TabIndex = 12
        Me.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOs
        '
        Me.lblOs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOs.Location = New System.Drawing.Point(110, 54)
        Me.lblOs.Name = "lblOs"
        Me.lblOs.Size = New System.Drawing.Size(99, 19)
        Me.lblOs.TabIndex = 13
        Me.lblOs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblApp
        '
        Me.lblApp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblApp.Location = New System.Drawing.Point(110, 82)
        Me.lblApp.Name = "lblApp"
        Me.lblApp.Size = New System.Drawing.Size(99, 19)
        Me.lblApp.TabIndex = 14
        Me.lblApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPcs
        '
        Me.lblPcs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPcs.Location = New System.Drawing.Point(110, 111)
        Me.lblPcs.Name = "lblPcs"
        Me.lblPcs.Size = New System.Drawing.Size(99, 19)
        Me.lblPcs.TabIndex = 15
        Me.lblPcs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(48, 161)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnter.TabIndex = 16
        Me.cmdEnter.Text = "表示"
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(146, 161)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "終了"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 205)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdEnter)
        Me.Controls.Add(Me.lblPcs)
        Me.Controls.Add(Me.lblApp)
        Me.Controls.Add(Me.lblOs)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.lstPcs)
        Me.Controls.Add(Me.lstApp)
        Me.Controls.Add(Me.lstOs)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "例題9-5 リストボックス"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lstType As ListBox
    Friend WithEvents lstOs As ListBox
    Friend WithEvents lstApp As ListBox
    Friend WithEvents lstPcs As ListBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblOs As Label
    Friend WithEvents lblApp As Label
    Friend WithEvents lblPcs As Label
    Friend WithEvents cmdEnter As Button
    Friend WithEvents Button2 As Button
End Class
