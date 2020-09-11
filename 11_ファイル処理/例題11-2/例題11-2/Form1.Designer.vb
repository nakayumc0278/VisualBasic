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
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbn女性 = New System.Windows.Forms.RadioButton()
        Me.rbn男性 = New System.Windows.Forms.RadioButton()
        Me.btn登録 = New System.Windows.Forms.Button()
        Me.btn保存 = New System.Windows.Forms.Button()
        Me.btn追加 = New System.Windows.Forms.Button()
        Me.btn開く = New System.Windows.Forms.Button()
        Me.btn表示 = New System.Windows.Forms.Button()
        Me.btn印刷 = New System.Windows.Forms.Button()
        Me.btn終了 = New System.Windows.Forms.Button()
        Me.lblレコード数表示 = New System.Windows.Forms.Label()
        Me.btn前 = New System.Windows.Forms.Button()
        Me.btn次 = New System.Windows.Forms.Button()
        Me.tbx部員番号 = New System.Windows.Forms.TextBox()
        Me.tbx氏名 = New System.Windows.Forms.TextBox()
        Me.cbo学年 = New System.Windows.Forms.ComboBox()
        Me.cbo学科 = New System.Windows.Forms.ComboBox()
        Me.tbx経験年数 = New System.Windows.Forms.TextBox()
        Me.tbxデータ表示 = New System.Windows.Forms.TextBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(55, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(55, 12)
        Me.label1.TabIndex = 0
        Me.label1.Text = "部員番号:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(79, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "氏名:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(79, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "学科:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 12)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "経験年数:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(79, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 12)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "学年:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbn女性)
        Me.GroupBox1.Controls.Add(Me.rbn男性)
        Me.GroupBox1.Location = New System.Drawing.Point(57, 175)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(115, 41)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "性別"
        '
        'rbn女性
        '
        Me.rbn女性.AutoSize = True
        Me.rbn女性.Location = New System.Drawing.Point(60, 18)
        Me.rbn女性.Name = "rbn女性"
        Me.rbn女性.Size = New System.Drawing.Size(47, 16)
        Me.rbn女性.TabIndex = 1
        Me.rbn女性.TabStop = True
        Me.rbn女性.Text = "女性"
        Me.rbn女性.UseVisualStyleBackColor = True
        '
        'rbn男性
        '
        Me.rbn男性.AutoSize = True
        Me.rbn男性.Location = New System.Drawing.Point(6, 18)
        Me.rbn男性.Name = "rbn男性"
        Me.rbn男性.Size = New System.Drawing.Size(47, 16)
        Me.rbn男性.TabIndex = 0
        Me.rbn男性.TabStop = True
        Me.rbn男性.Text = "男性"
        Me.rbn男性.UseVisualStyleBackColor = True
        '
        'btn登録
        '
        Me.btn登録.Location = New System.Drawing.Point(278, 27)
        Me.btn登録.Name = "btn登録"
        Me.btn登録.Size = New System.Drawing.Size(75, 23)
        Me.btn登録.TabIndex = 6
        Me.btn登録.Text = "登録"
        Me.btn登録.UseVisualStyleBackColor = True
        '
        'btn保存
        '
        Me.btn保存.Location = New System.Drawing.Point(278, 56)
        Me.btn保存.Name = "btn保存"
        Me.btn保存.Size = New System.Drawing.Size(75, 23)
        Me.btn保存.TabIndex = 7
        Me.btn保存.Text = "保存"
        Me.btn保存.UseVisualStyleBackColor = True
        '
        'btn追加
        '
        Me.btn追加.Location = New System.Drawing.Point(278, 85)
        Me.btn追加.Name = "btn追加"
        Me.btn追加.Size = New System.Drawing.Size(75, 23)
        Me.btn追加.TabIndex = 8
        Me.btn追加.Text = "追加"
        Me.btn追加.UseVisualStyleBackColor = True
        '
        'btn開く
        '
        Me.btn開く.Location = New System.Drawing.Point(359, 27)
        Me.btn開く.Name = "btn開く"
        Me.btn開く.Size = New System.Drawing.Size(75, 23)
        Me.btn開く.TabIndex = 9
        Me.btn開く.Text = "開く"
        Me.btn開く.UseVisualStyleBackColor = True
        '
        'btn表示
        '
        Me.btn表示.Location = New System.Drawing.Point(359, 56)
        Me.btn表示.Name = "btn表示"
        Me.btn表示.Size = New System.Drawing.Size(75, 23)
        Me.btn表示.TabIndex = 10
        Me.btn表示.Text = "表示"
        Me.btn表示.UseVisualStyleBackColor = True
        '
        'btn印刷
        '
        Me.btn印刷.Location = New System.Drawing.Point(359, 85)
        Me.btn印刷.Name = "btn印刷"
        Me.btn印刷.Size = New System.Drawing.Size(75, 23)
        Me.btn印刷.TabIndex = 11
        Me.btn印刷.Text = "印刷"
        Me.btn印刷.UseVisualStyleBackColor = True
        '
        'btn終了
        '
        Me.btn終了.Location = New System.Drawing.Point(359, 114)
        Me.btn終了.Name = "btn終了"
        Me.btn終了.Size = New System.Drawing.Size(75, 23)
        Me.btn終了.TabIndex = 12
        Me.btn終了.Text = "終了"
        Me.btn終了.UseVisualStyleBackColor = True
        '
        'lblレコード数表示
        '
        Me.lblレコード数表示.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblレコード数表示.Location = New System.Drawing.Point(326, 164)
        Me.lblレコード数表示.Name = "lblレコード数表示"
        Me.lblレコード数表示.Size = New System.Drawing.Size(108, 23)
        Me.lblレコード数表示.TabIndex = 13
        Me.lblレコード数表示.Text = "1 / 1"
        Me.lblレコード数表示.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btn前
        '
        Me.btn前.Location = New System.Drawing.Point(326, 190)
        Me.btn前.Name = "btn前"
        Me.btn前.Size = New System.Drawing.Size(39, 23)
        Me.btn前.TabIndex = 14
        Me.btn前.Text = "<<"
        Me.btn前.UseVisualStyleBackColor = True
        '
        'btn次
        '
        Me.btn次.Location = New System.Drawing.Point(395, 190)
        Me.btn次.Name = "btn次"
        Me.btn次.Size = New System.Drawing.Size(39, 23)
        Me.btn次.TabIndex = 15
        Me.btn次.Text = ">>"
        Me.btn次.UseVisualStyleBackColor = True
        '
        'tbx部員番号
        '
        Me.tbx部員番号.Location = New System.Drawing.Point(116, 35)
        Me.tbx部員番号.Name = "tbx部員番号"
        Me.tbx部員番号.Size = New System.Drawing.Size(100, 19)
        Me.tbx部員番号.TabIndex = 16
        '
        'tbx氏名
        '
        Me.tbx氏名.Location = New System.Drawing.Point(116, 60)
        Me.tbx氏名.Name = "tbx氏名"
        Me.tbx氏名.Size = New System.Drawing.Size(100, 19)
        Me.tbx氏名.TabIndex = 17
        '
        'cbo学年
        '
        Me.cbo学年.FormattingEnabled = True
        Me.cbo学年.Location = New System.Drawing.Point(116, 111)
        Me.cbo学年.Name = "cbo学年"
        Me.cbo学年.Size = New System.Drawing.Size(100, 20)
        Me.cbo学年.TabIndex = 18
        '
        'cbo学科
        '
        Me.cbo学科.FormattingEnabled = True
        Me.cbo学科.Location = New System.Drawing.Point(116, 85)
        Me.cbo学科.Name = "cbo学科"
        Me.cbo学科.Size = New System.Drawing.Size(100, 20)
        Me.cbo学科.TabIndex = 19
        '
        'tbx経験年数
        '
        Me.tbx経験年数.Location = New System.Drawing.Point(116, 137)
        Me.tbx経験年数.Name = "tbx経験年数"
        Me.tbx経験年数.Size = New System.Drawing.Size(100, 19)
        Me.tbx経験年数.TabIndex = 20
        '
        'tbxデータ表示
        '
        Me.tbxデータ表示.Location = New System.Drawing.Point(12, 258)
        Me.tbxデータ表示.Multiline = True
        Me.tbxデータ表示.Name = "tbxデータ表示"
        Me.tbxデータ表示.Size = New System.Drawing.Size(463, 180)
        Me.tbxデータ表示.TabIndex = 21
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 450)
        Me.Controls.Add(Me.tbxデータ表示)
        Me.Controls.Add(Me.tbx経験年数)
        Me.Controls.Add(Me.cbo学科)
        Me.Controls.Add(Me.cbo学年)
        Me.Controls.Add(Me.tbx氏名)
        Me.Controls.Add(Me.tbx部員番号)
        Me.Controls.Add(Me.btn次)
        Me.Controls.Add(Me.btn前)
        Me.Controls.Add(Me.lblレコード数表示)
        Me.Controls.Add(Me.btn終了)
        Me.Controls.Add(Me.btn印刷)
        Me.Controls.Add(Me.btn表示)
        Me.Controls.Add(Me.btn開く)
        Me.Controls.Add(Me.btn追加)
        Me.Controls.Add(Me.btn保存)
        Me.Controls.Add(Me.btn登録)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = " 例題11-2 部活動部員名簿の作成"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbn女性 As RadioButton
    Friend WithEvents rbn男性 As RadioButton
    Friend WithEvents btn登録 As Button
    Friend WithEvents btn保存 As Button
    Friend WithEvents btn追加 As Button
    Friend WithEvents btn開く As Button
    Friend WithEvents btn表示 As Button
    Friend WithEvents btn印刷 As Button
    Friend WithEvents btn終了 As Button
    Friend WithEvents lblレコード数表示 As Label
    Friend WithEvents btn前 As Button
    Friend WithEvents btn次 As Button
    Friend WithEvents tbx部員番号 As TextBox
    Friend WithEvents tbx氏名 As TextBox
    Friend WithEvents cbo学年 As ComboBox
    Friend WithEvents cbo学科 As ComboBox
    Friend WithEvents tbx経験年数 As TextBox
    Friend WithEvents tbxデータ表示 As TextBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
End Class
