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
        Me.BGM1 = New System.Windows.Forms.Button()
        Me.BGM2 = New System.Windows.Forms.Button()
        Me.終了 = New System.Windows.Forms.Button()
        Me.BGM1_STOP = New System.Windows.Forms.Button()
        Me.BGM2_STOP = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BGM1
        '
        Me.BGM1.Location = New System.Drawing.Point(27, 13)
        Me.BGM1.Name = "BGM1"
        Me.BGM1.Size = New System.Drawing.Size(75, 23)
        Me.BGM1.TabIndex = 0
        Me.BGM1.Text = "BGM1"
        Me.BGM1.UseVisualStyleBackColor = True
        '
        'BGM2
        '
        Me.BGM2.Location = New System.Drawing.Point(108, 13)
        Me.BGM2.Name = "BGM2"
        Me.BGM2.Size = New System.Drawing.Size(75, 23)
        Me.BGM2.TabIndex = 1
        Me.BGM2.Text = "BGM2"
        Me.BGM2.UseVisualStyleBackColor = True
        '
        '終了
        '
        Me.終了.Location = New System.Drawing.Point(189, 13)
        Me.終了.Name = "終了"
        Me.終了.Size = New System.Drawing.Size(75, 23)
        Me.終了.TabIndex = 2
        Me.終了.Text = "終了"
        Me.終了.UseVisualStyleBackColor = True
        '
        'BGM1_STOP
        '
        Me.BGM1_STOP.Location = New System.Drawing.Point(27, 13)
        Me.BGM1_STOP.Name = "BGM1_STOP"
        Me.BGM1_STOP.Size = New System.Drawing.Size(75, 23)
        Me.BGM1_STOP.TabIndex = 3
        Me.BGM1_STOP.Text = "Stop"
        Me.BGM1_STOP.UseVisualStyleBackColor = True
        '
        'BGM2_STOP
        '
        Me.BGM2_STOP.Location = New System.Drawing.Point(108, 13)
        Me.BGM2_STOP.Name = "BGM2_STOP"
        Me.BGM2_STOP.Size = New System.Drawing.Size(75, 23)
        Me.BGM2_STOP.TabIndex = 4
        Me.BGM2_STOP.Text = "Stop"
        Me.BGM2_STOP.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 50)
        Me.Controls.Add(Me.BGM2_STOP)
        Me.Controls.Add(Me.BGM1_STOP)
        Me.Controls.Add(Me.終了)
        Me.Controls.Add(Me.BGM2)
        Me.Controls.Add(Me.BGM1)
        Me.Name = "Form1"
        Me.Text = "例題13-1 BGM再生"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BGM1 As Button
    Friend WithEvents BGM2 As Button
    Friend WithEvents 終了 As Button
    Friend WithEvents BGM1_STOP As Button
    Friend WithEvents BGM2_STOP As Button
End Class
