<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReidai94
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
        Me.cmdDirection = New System.Windows.Forms.ComboBox()
        Me.cmdMove = New System.Windows.Forms.Button()
        Me.picIcon = New System.Windows.Forms.PictureBox()
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdDirection
        '
        Me.cmdDirection.FormattingEnabled = True
        Me.cmdDirection.Location = New System.Drawing.Point(33, 32)
        Me.cmdDirection.Name = "cmdDirection"
        Me.cmdDirection.Size = New System.Drawing.Size(121, 20)
        Me.cmdDirection.TabIndex = 0
        '
        'cmdMove
        '
        Me.cmdMove.Location = New System.Drawing.Point(33, 59)
        Me.cmdMove.Name = "cmdMove"
        Me.cmdMove.Size = New System.Drawing.Size(75, 23)
        Me.cmdMove.TabIndex = 1
        Me.cmdMove.Text = "移動"
        Me.cmdMove.UseVisualStyleBackColor = True
        '
        'picIcon
        '
        Me.picIcon.Image = Global.例題9_4.My.Resources.Resources.B000XHAERO_09_THUMBZZZ
        Me.picIcon.Location = New System.Drawing.Point(353, 32)
        Me.picIcon.Name = "picIcon"
        Me.picIcon.Size = New System.Drawing.Size(75, 75)
        Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picIcon.TabIndex = 2
        Me.picIcon.TabStop = False
        '
        'frmReidai94
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(466, 450)
        Me.Controls.Add(Me.picIcon)
        Me.Controls.Add(Me.cmdMove)
        Me.Controls.Add(Me.cmdDirection)
        Me.Name = "frmReidai94"
        Me.Text = "例題9-4 コンボボックス"
        CType(Me.picIcon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdDirection As ComboBox
    Friend WithEvents cmdMove As Button
    Friend WithEvents picIcon As PictureBox
End Class
