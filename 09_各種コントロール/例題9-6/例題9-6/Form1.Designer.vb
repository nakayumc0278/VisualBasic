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
        Me.lbl_judge = New System.Windows.Forms.Label()
        Me.txt_hei = New System.Windows.Forms.TextBox()
        Me.txt_wei = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.pic_wow = New System.Windows.Forms.PictureBox()
        Me.pic_smile = New System.Windows.Forms.PictureBox()
        Me.pic_judge = New System.Windows.Forms.PictureBox()
        CType(Me.pic_wow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_smile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_judge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "身長"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "体重"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "結果"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "cm"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(184, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "kg"
        '
        'lbl_judge
        '
        Me.lbl_judge.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_judge.Location = New System.Drawing.Point(75, 136)
        Me.lbl_judge.Name = "lbl_judge"
        Me.lbl_judge.Size = New System.Drawing.Size(129, 19)
        Me.lbl_judge.TabIndex = 5
        Me.lbl_judge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_hei
        '
        Me.txt_hei.Location = New System.Drawing.Point(75, 57)
        Me.txt_hei.Name = "txt_hei"
        Me.txt_hei.Size = New System.Drawing.Size(100, 19)
        Me.txt_hei.TabIndex = 6
        Me.txt_hei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_wei
        '
        Me.txt_wei.Location = New System.Drawing.Point(75, 97)
        Me.txt_wei.Name = "txt_wei"
        Me.txt_wei.Size = New System.Drawing.Size(100, 19)
        Me.txt_wei.TabIndex = 7
        Me.txt_wei.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(34, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "判定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(129, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "終了"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'pic_wow
        '
        Me.pic_wow.Image = Global.例題9_6.My.Resources.Resources.画像２
        Me.pic_wow.Location = New System.Drawing.Point(444, 126)
        Me.pic_wow.Name = "pic_wow"
        Me.pic_wow.Size = New System.Drawing.Size(92, 89)
        Me.pic_wow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_wow.TabIndex = 12
        Me.pic_wow.TabStop = False
        Me.pic_wow.UseWaitCursor = True
        '
        'pic_smile
        '
        Me.pic_smile.Image = Global.例題9_6.My.Resources.Resources.画像１
        Me.pic_smile.Location = New System.Drawing.Point(444, 26)
        Me.pic_smile.Name = "pic_smile"
        Me.pic_smile.Size = New System.Drawing.Size(92, 86)
        Me.pic_smile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_smile.TabIndex = 11
        Me.pic_smile.TabStop = False
        '
        'pic_judge
        '
        Me.pic_judge.Location = New System.Drawing.Point(242, 26)
        Me.pic_judge.Name = "pic_judge"
        Me.pic_judge.Size = New System.Drawing.Size(175, 175)
        Me.pic_judge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_judge.TabIndex = 10
        Me.pic_judge.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 244)
        Me.Controls.Add(Me.pic_wow)
        Me.Controls.Add(Me.pic_smile)
        Me.Controls.Add(Me.pic_judge)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_wei)
        Me.Controls.Add(Me.txt_hei)
        Me.Controls.Add(Me.lbl_judge)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "例題9-6 ピクチャボックス(その2)"
        CType(Me.pic_wow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_smile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_judge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_judge As Label
    Friend WithEvents txt_hei As TextBox
    Friend WithEvents txt_wei As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents pic_judge As PictureBox
    Friend WithEvents pic_smile As PictureBox
    Friend WithEvents pic_wow As PictureBox
End Class
