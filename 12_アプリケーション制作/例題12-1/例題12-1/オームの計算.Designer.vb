<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class オームの計算
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(オームの計算))
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Option2 = New System.Windows.Forms.RadioButton()
        Me.Option3 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Option1
        '
        Me.Option1.AutoSize = True
        Me.Option1.Location = New System.Drawing.Point(70, 32)
        Me.Option1.Name = "Option1"
        Me.Option1.Size = New System.Drawing.Size(47, 16)
        Me.Option1.TabIndex = 0
        Me.Option1.TabStop = True
        Me.Option1.Text = "電流"
        Me.Option1.UseVisualStyleBackColor = True
        '
        'Option2
        '
        Me.Option2.AutoSize = True
        Me.Option2.Location = New System.Drawing.Point(167, 32)
        Me.Option2.Name = "Option2"
        Me.Option2.Size = New System.Drawing.Size(47, 16)
        Me.Option2.TabIndex = 1
        Me.Option2.TabStop = True
        Me.Option2.Text = "電圧"
        Me.Option2.UseVisualStyleBackColor = True
        '
        'Option3
        '
        Me.Option3.AutoSize = True
        Me.Option3.Location = New System.Drawing.Point(260, 32)
        Me.Option3.Name = "Option3"
        Me.Option3.Size = New System.Drawing.Size(47, 16)
        Me.Option3.TabIndex = 2
        Me.Option3.TabStop = True
        Me.Option3.Text = "抵抗"
        Me.Option3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 12)
        Me.Label1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(193, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 4
        '
        'Text1
        '
        Me.Text1.Location = New System.Drawing.Point(78, 84)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(100, 19)
        Me.Text1.TabIndex = 5
        '
        'Text2
        '
        Me.Text2.Location = New System.Drawing.Point(257, 84)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(100, 19)
        Me.Text2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 12)
        Me.Label3.TabIndex = 7
        '
        'Command1
        '
        Me.Command1.Location = New System.Drawing.Point(70, 196)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(75, 23)
        Me.Command1.TabIndex = 8
        Me.Command1.Text = "計算開始"
        Me.Command1.UseVisualStyleBackColor = True
        '
        'Command2
        '
        Me.Command2.Location = New System.Drawing.Point(151, 196)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(75, 23)
        Me.Command2.TabIndex = 9
        Me.Command2.Text = "クリア"
        Me.Command2.UseVisualStyleBackColor = True
        '
        'Command3
        '
        Me.Command3.Location = New System.Drawing.Point(232, 196)
        Me.Command3.Name = "Command3"
        Me.Command3.Size = New System.Drawing.Size(75, 23)
        Me.Command3.TabIndex = 10
        Me.Command3.Text = "終了"
        Me.Command3.UseVisualStyleBackColor = True
        '
        'オームの計算
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 233)
        Me.Controls.Add(Me.Command3)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Option3)
        Me.Controls.Add(Me.Option2)
        Me.Controls.Add(Me.Option1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "オームの計算"
        Me.Text = "例題12-1 オームの計算"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Option1 As RadioButton
    Friend WithEvents Option2 As RadioButton
    Friend WithEvents Option3 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Text1 As TextBox
    Friend WithEvents Text2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Command1 As Button
    Friend WithEvents Command2 As Button
    Friend WithEvents Command3 As Button
End Class
