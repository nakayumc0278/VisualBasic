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
        Me.cbo_agreeyaer = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_talktime = New System.Windows.Forms.TextBox()
        Me.lst_data = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chk_virus = New System.Windows.Forms.CheckBox()
        Me.chk_comp = New System.Windows.Forms.CheckBox()
        Me.chk_support = New System.Windows.Forms.CheckBox()
        Me.chk_onlinestrage = New System.Windows.Forms.CheckBox()
        Me.chk_sms = New System.Windows.Forms.CheckBox()
        Me.chk_endless = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cmd = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_talk = New System.Windows.Forms.Label()
        Me.lbl_data = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_kihon = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_option = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_sum = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_agreeyaer
        '
        Me.cbo_agreeyaer.FormattingEnabled = True
        Me.cbo_agreeyaer.Items.AddRange(New Object() {"1年未満", "3年以上", "5年以上", "10年以上"})
        Me.cbo_agreeyaer.Location = New System.Drawing.Point(27, 79)
        Me.cbo_agreeyaer.Name = "cbo_agreeyaer"
        Me.cbo_agreeyaer.Size = New System.Drawing.Size(121, 20)
        Me.cbo_agreeyaer.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 12)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "通話時間(分)"
        '
        'txt_talktime
        '
        Me.txt_talktime.Location = New System.Drawing.Point(27, 38)
        Me.txt_talktime.Name = "txt_talktime"
        Me.txt_talktime.Size = New System.Drawing.Size(121, 19)
        Me.txt_talktime.TabIndex = 2
        Me.txt_talktime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lst_data
        '
        Me.lst_data.FormattingEnabled = True
        Me.lst_data.ItemHeight = 12
        Me.lst_data.Items.AddRange(New Object() {"1GB", "3GB", "6GB", "10GB", "50GB"})
        Me.lst_data.Location = New System.Drawing.Point(48, 124)
        Me.lst_data.Name = "lst_data"
        Me.lst_data.Size = New System.Drawing.Size(81, 64)
        Me.lst_data.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chk_virus)
        Me.GroupBox1.Controls.Add(Me.chk_comp)
        Me.GroupBox1.Controls.Add(Me.chk_support)
        Me.GroupBox1.Controls.Add(Me.chk_onlinestrage)
        Me.GroupBox1.Controls.Add(Me.chk_sms)
        Me.GroupBox1.Controls.Add(Me.chk_endless)
        Me.GroupBox1.Location = New System.Drawing.Point(155, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(160, 150)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "オプション"
        '
        'chk_virus
        '
        Me.chk_virus.AutoSize = True
        Me.chk_virus.Location = New System.Drawing.Point(6, 128)
        Me.chk_virus.Name = "chk_virus"
        Me.chk_virus.Size = New System.Drawing.Size(85, 16)
        Me.chk_virus.TabIndex = 10
        Me.chk_virus.Text = "ウイルス対策"
        Me.chk_virus.UseVisualStyleBackColor = True
        '
        'chk_comp
        '
        Me.chk_comp.AutoSize = True
        Me.chk_comp.Location = New System.Drawing.Point(6, 106)
        Me.chk_comp.Name = "chk_comp"
        Me.chk_comp.Size = New System.Drawing.Size(87, 16)
        Me.chk_comp.TabIndex = 9
        Me.chk_comp.Text = "あんしん補償"
        Me.chk_comp.UseVisualStyleBackColor = True
        '
        'chk_support
        '
        Me.chk_support.AutoSize = True
        Me.chk_support.Location = New System.Drawing.Point(6, 84)
        Me.chk_support.Name = "chk_support"
        Me.chk_support.Size = New System.Drawing.Size(86, 16)
        Me.chk_support.TabIndex = 8
        Me.chk_support.Text = "電話サポート"
        Me.chk_support.UseVisualStyleBackColor = True
        '
        'chk_onlinestrage
        '
        Me.chk_onlinestrage.AutoSize = True
        Me.chk_onlinestrage.Location = New System.Drawing.Point(6, 62)
        Me.chk_onlinestrage.Name = "chk_onlinestrage"
        Me.chk_onlinestrage.Size = New System.Drawing.Size(151, 16)
        Me.chk_onlinestrage.TabIndex = 7
        Me.chk_onlinestrage.Text = "オンラインストレージサービス"
        Me.chk_onlinestrage.UseVisualStyleBackColor = True
        '
        'chk_sms
        '
        Me.chk_sms.AutoSize = True
        Me.chk_sms.Location = New System.Drawing.Point(6, 40)
        Me.chk_sms.Name = "chk_sms"
        Me.chk_sms.Size = New System.Drawing.Size(90, 16)
        Me.chk_sms.TabIndex = 6
        Me.chk_sms.Text = "SMSオプション"
        Me.chk_sms.UseVisualStyleBackColor = True
        '
        'chk_endless
        '
        Me.chk_endless.AutoSize = True
        Me.chk_endless.Location = New System.Drawing.Point(6, 18)
        Me.chk_endless.Name = "chk_endless"
        Me.chk_endless.Size = New System.Drawing.Size(68, 16)
        Me.chk_endless.TabIndex = 5
        Me.chk_endless.Text = "かけ放題"
        Me.chk_endless.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 12)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "データ通信プラン"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "契約期間"
        '
        'btn_cmd
        '
        Me.btn_cmd.Location = New System.Drawing.Point(21, 330)
        Me.btn_cmd.Name = "btn_cmd"
        Me.btn_cmd.Size = New System.Drawing.Size(75, 23)
        Me.btn_cmd.TabIndex = 7
        Me.btn_cmd.Text = "計算"
        Me.btn_cmd.UseVisualStyleBackColor = True
        '
        'btn_end
        '
        Me.btn_end.Location = New System.Drawing.Point(262, 330)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 23)
        Me.btn_end.TabIndex = 8
        Me.btn_end.Text = "終了"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "通話料金"
        '
        'lbl_talk
        '
        Me.lbl_talk.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_talk.Location = New System.Drawing.Point(63, 214)
        Me.lbl_talk.Name = "lbl_talk"
        Me.lbl_talk.Size = New System.Drawing.Size(89, 19)
        Me.lbl_talk.TabIndex = 10
        Me.lbl_talk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_data
        '
        Me.lbl_data.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_data.Location = New System.Drawing.Point(63, 250)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(89, 19)
        Me.lbl_data.TabIndex = 12
        Me.lbl_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(61, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "データ通信料"
        '
        'lbl_kihon
        '
        Me.lbl_kihon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_kihon.Location = New System.Drawing.Point(205, 214)
        Me.lbl_kihon.Name = "lbl_kihon"
        Me.lbl_kihon.Size = New System.Drawing.Size(89, 19)
        Me.lbl_kihon.TabIndex = 14
        Me.lbl_kihon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(203, 238)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 12)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "オプション料金"
        '
        'lbl_option
        '
        Me.lbl_option.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_option.Location = New System.Drawing.Point(205, 250)
        Me.lbl_option.Name = "lbl_option"
        Me.lbl_option.Size = New System.Drawing.Size(89, 19)
        Me.lbl_option.TabIndex = 16
        Me.lbl_option.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(203, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 12)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "基本料金"
        '
        'lbl_sum
        '
        Me.lbl_sum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_sum.Location = New System.Drawing.Point(63, 293)
        Me.lbl_sum.Name = "lbl_sum"
        Me.lbl_sum.Size = New System.Drawing.Size(231, 19)
        Me.lbl_sum.TabIndex = 18
        Me.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(61, 281)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 12)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "合計金額"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(102, 330)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "リセット"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 369)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_sum)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lbl_option)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_kihon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_talk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_cmd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lst_data)
        Me.Controls.Add(Me.txt_talktime)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbo_agreeyaer)
        Me.Name = "Form1"
        Me.Text = "拡張課題9-3 携帯電話の料金計算"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbo_agreeyaer As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_talktime As TextBox
    Friend WithEvents lst_data As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chk_virus As CheckBox
    Friend WithEvents chk_comp As CheckBox
    Friend WithEvents chk_support As CheckBox
    Friend WithEvents chk_onlinestrage As CheckBox
    Friend WithEvents chk_sms As CheckBox
    Friend WithEvents chk_endless As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_cmd As Button
    Friend WithEvents btn_end As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_talk As Label
    Friend WithEvents lbl_data As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lbl_kihon As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_option As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_sum As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
End Class
