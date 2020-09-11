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
        Me.cmdEND = New System.Windows.Forms.Button()
        Me.cmdCLR = New System.Windows.Forms.Button()
        Me.cmdCLT = New System.Windows.Forms.Button()
        Me.chkORG = New System.Windows.Forms.CheckBox()
        Me.chkBNN = New System.Windows.Forms.CheckBox()
        Me.chkAPPL = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'cmdEND
        '
        Me.cmdEND.Location = New System.Drawing.Point(177, 92)
        Me.cmdEND.Name = "cmdEND"
        Me.cmdEND.Size = New System.Drawing.Size(75, 23)
        Me.cmdEND.TabIndex = 11
        Me.cmdEND.Text = "終了"
        Me.cmdEND.UseVisualStyleBackColor = True
        '
        'cmdCLR
        '
        Me.cmdCLR.Location = New System.Drawing.Point(177, 63)
        Me.cmdCLR.Name = "cmdCLR"
        Me.cmdCLR.Size = New System.Drawing.Size(75, 23)
        Me.cmdCLR.TabIndex = 10
        Me.cmdCLR.Text = "クリア"
        Me.cmdCLR.UseVisualStyleBackColor = True
        '
        'cmdCLT
        '
        Me.cmdCLT.Location = New System.Drawing.Point(177, 34)
        Me.cmdCLT.Name = "cmdCLT"
        Me.cmdCLT.Size = New System.Drawing.Size(75, 23)
        Me.cmdCLT.TabIndex = 9
        Me.cmdCLT.Text = "選択"
        Me.cmdCLT.UseVisualStyleBackColor = True
        '
        'chkORG
        '
        Me.chkORG.AutoSize = True
        Me.chkORG.Location = New System.Drawing.Point(74, 96)
        Me.chkORG.Name = "chkORG"
        Me.chkORG.Size = New System.Drawing.Size(61, 16)
        Me.chkORG.TabIndex = 8
        Me.chkORG.Text = "オレンジ"
        Me.chkORG.UseVisualStyleBackColor = True
        '
        'chkBNN
        '
        Me.chkBNN.AutoSize = True
        Me.chkBNN.Location = New System.Drawing.Point(74, 67)
        Me.chkBNN.Name = "chkBNN"
        Me.chkBNN.Size = New System.Drawing.Size(54, 16)
        Me.chkBNN.TabIndex = 7
        Me.chkBNN.Text = "バナナ"
        Me.chkBNN.UseVisualStyleBackColor = True
        '
        'chkAPPL
        '
        Me.chkAPPL.AutoSize = True
        Me.chkAPPL.Location = New System.Drawing.Point(74, 38)
        Me.chkAPPL.Name = "chkAPPL"
        Me.chkAPPL.Size = New System.Drawing.Size(51, 16)
        Me.chkAPPL.TabIndex = 6
        Me.chkAPPL.Text = "りんご"
        Me.chkAPPL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 148)
        Me.Controls.Add(Me.cmdEND)
        Me.Controls.Add(Me.cmdCLR)
        Me.Controls.Add(Me.cmdCLT)
        Me.Controls.Add(Me.chkORG)
        Me.Controls.Add(Me.chkBNN)
        Me.Controls.Add(Me.chkAPPL)
        Me.Name = "Form1"
        Me.Text = "課題9-1チェックボックス(その2)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdEND As Button
    Friend WithEvents cmdCLR As Button
    Friend WithEvents cmdCLT As Button
    Friend WithEvents chkORG As CheckBox
    Friend WithEvents chkBNN As CheckBox
    Friend WithEvents chkAPPL As CheckBox
End Class
