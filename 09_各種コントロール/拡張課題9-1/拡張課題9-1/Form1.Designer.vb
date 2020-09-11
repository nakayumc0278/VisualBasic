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
        Me.grp_Gengo = New System.Windows.Forms.GroupBox()
        Me.rdo_Meiji = New System.Windows.Forms.RadioButton()
        Me.rdo_Taisyo = New System.Windows.Forms.RadioButton()
        Me.rdo_Showa = New System.Windows.Forms.RadioButton()
        Me.rdo_Heisei = New System.Windows.Forms.RadioButton()
        Me.rdo_Reiwa = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.grp_Gengo.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp_Gengo
        '
        Me.grp_Gengo.Controls.Add(Me.rdo_Reiwa)
        Me.grp_Gengo.Controls.Add(Me.rdo_Heisei)
        Me.grp_Gengo.Controls.Add(Me.rdo_Showa)
        Me.grp_Gengo.Controls.Add(Me.rdo_Taisyo)
        Me.grp_Gengo.Controls.Add(Me.rdo_Meiji)
        Me.grp_Gengo.Location = New System.Drawing.Point(53, 31)
        Me.grp_Gengo.Name = "grp_Gengo"
        Me.grp_Gengo.Size = New System.Drawing.Size(71, 137)
        Me.grp_Gengo.TabIndex = 0
        Me.grp_Gengo.TabStop = False
        Me.grp_Gengo.Text = "和暦"
        '
        'rdo_Meiji
        '
        Me.rdo_Meiji.AutoSize = True
        Me.rdo_Meiji.Location = New System.Drawing.Point(7, 19)
        Me.rdo_Meiji.Name = "rdo_Meiji"
        Me.rdo_Meiji.Size = New System.Drawing.Size(47, 16)
        Me.rdo_Meiji.TabIndex = 0
        Me.rdo_Meiji.TabStop = True
        Me.rdo_Meiji.Text = "明治"
        Me.rdo_Meiji.UseVisualStyleBackColor = True
        '
        'rdo_Taisyo
        '
        Me.rdo_Taisyo.AutoSize = True
        Me.rdo_Taisyo.Location = New System.Drawing.Point(7, 41)
        Me.rdo_Taisyo.Name = "rdo_Taisyo"
        Me.rdo_Taisyo.Size = New System.Drawing.Size(47, 16)
        Me.rdo_Taisyo.TabIndex = 1
        Me.rdo_Taisyo.TabStop = True
        Me.rdo_Taisyo.Text = "大正"
        Me.rdo_Taisyo.UseVisualStyleBackColor = True
        '
        'rdo_Showa
        '
        Me.rdo_Showa.AutoSize = True
        Me.rdo_Showa.Location = New System.Drawing.Point(7, 63)
        Me.rdo_Showa.Name = "rdo_Showa"
        Me.rdo_Showa.Size = New System.Drawing.Size(47, 16)
        Me.rdo_Showa.TabIndex = 2
        Me.rdo_Showa.TabStop = True
        Me.rdo_Showa.Text = "昭和"
        Me.rdo_Showa.UseVisualStyleBackColor = True
        '
        'rdo_Heisei
        '
        Me.rdo_Heisei.AutoSize = True
        Me.rdo_Heisei.Location = New System.Drawing.Point(7, 85)
        Me.rdo_Heisei.Name = "rdo_Heisei"
        Me.rdo_Heisei.Size = New System.Drawing.Size(47, 16)
        Me.rdo_Heisei.TabIndex = 3
        Me.rdo_Heisei.TabStop = True
        Me.rdo_Heisei.Text = "平成"
        Me.rdo_Heisei.UseVisualStyleBackColor = True
        '
        'rdo_Reiwa
        '
        Me.rdo_Reiwa.AutoSize = True
        Me.rdo_Reiwa.Location = New System.Drawing.Point(7, 107)
        Me.rdo_Reiwa.Name = "rdo_Reiwa"
        Me.rdo_Reiwa.Size = New System.Drawing.Size(47, 16)
        Me.rdo_Reiwa.TabIndex = 4
        Me.rdo_Reiwa.TabStop = True
        Me.rdo_Reiwa.Text = "令和"
        Me.rdo_Reiwa.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 19)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "和暦年"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(175, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "西暦"
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(177, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(141, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "計算"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(222, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "終了"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 203)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.grp_Gengo)
        Me.Name = "Form1"
        Me.Text = "拡張課題9-1 和暦の西暦変換"
        Me.grp_Gengo.ResumeLayout(False)
        Me.grp_Gengo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grp_Gengo As GroupBox
    Friend WithEvents rdo_Reiwa As RadioButton
    Friend WithEvents rdo_Heisei As RadioButton
    Friend WithEvents rdo_Showa As RadioButton
    Friend WithEvents rdo_Taisyo As RadioButton
    Friend WithEvents rdo_Meiji As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
