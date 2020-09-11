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
        Me.chkAPPL = New System.Windows.Forms.CheckBox()
        Me.chkBNN = New System.Windows.Forms.CheckBox()
        Me.chkORG = New System.Windows.Forms.CheckBox()
        Me.cmdCLT = New System.Windows.Forms.Button()
        Me.cmdCLR = New System.Windows.Forms.Button()
        Me.cmdEND = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkAPPL
        '
        Me.chkAPPL.AutoSize = True
        Me.chkAPPL.Location = New System.Drawing.Point(66, 38)
        Me.chkAPPL.Name = "chkAPPL"
        Me.chkAPPL.Size = New System.Drawing.Size(51, 16)
        Me.chkAPPL.TabIndex = 0
        Me.chkAPPL.Text = "りんご"
        Me.chkAPPL.UseVisualStyleBackColor = True
        '
        'chkBNN
        '
        Me.chkBNN.AutoSize = True
        Me.chkBNN.Location = New System.Drawing.Point(66, 67)
        Me.chkBNN.Name = "chkBNN"
        Me.chkBNN.Size = New System.Drawing.Size(54, 16)
        Me.chkBNN.TabIndex = 1
        Me.chkBNN.Text = "バナナ"
        Me.chkBNN.UseVisualStyleBackColor = True
        '
        'chkORG
        '
        Me.chkORG.AutoSize = True
        Me.chkORG.Location = New System.Drawing.Point(66, 96)
        Me.chkORG.Name = "chkORG"
        Me.chkORG.Size = New System.Drawing.Size(61, 16)
        Me.chkORG.TabIndex = 2
        Me.chkORG.Text = "オレンジ"
        Me.chkORG.UseVisualStyleBackColor = True
        '
        'cmdCLT
        '
        Me.cmdCLT.Location = New System.Drawing.Point(169, 34)
        Me.cmdCLT.Name = "cmdCLT"
        Me.cmdCLT.Size = New System.Drawing.Size(75, 23)
        Me.cmdCLT.TabIndex = 3
        Me.cmdCLT.Text = "選択"
        Me.cmdCLT.UseVisualStyleBackColor = True
        '
        'cmdCLR
        '
        Me.cmdCLR.Location = New System.Drawing.Point(169, 63)
        Me.cmdCLR.Name = "cmdCLR"
        Me.cmdCLR.Size = New System.Drawing.Size(75, 23)
        Me.cmdCLR.TabIndex = 4
        Me.cmdCLR.Text = "クリア"
        Me.cmdCLR.UseVisualStyleBackColor = True
        '
        'cmdEND
        '
        Me.cmdEND.Location = New System.Drawing.Point(169, 92)
        Me.cmdEND.Name = "cmdEND"
        Me.cmdEND.Size = New System.Drawing.Size(75, 23)
        Me.cmdEND.TabIndex = 5
        Me.cmdEND.Text = "終了"
        Me.cmdEND.UseVisualStyleBackColor = True
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
        Me.Text = "例題9-1 チェックボックス(その１)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkAPPL As CheckBox
    Friend WithEvents chkBNN As CheckBox
    Friend WithEvents chkORG As CheckBox
    Friend WithEvents cmdCLT As Button
    Friend WithEvents cmdCLR As Button
    Friend WithEvents cmdEND As Button
End Class
