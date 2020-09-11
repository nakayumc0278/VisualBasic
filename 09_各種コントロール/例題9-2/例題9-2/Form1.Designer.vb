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
        Me.grpWork = New System.Windows.Forms.GroupBox()
        Me.rdoStudent = New System.Windows.Forms.RadioButton()
        Me.rdoSalaryman = New System.Windows.Forms.RadioButton()
        Me.rdoSelfEmp = New System.Windows.Forms.RadioButton()
        Me.rdoOther = New System.Windows.Forms.RadioButton()
        Me.GrpSex = New System.Windows.Forms.GroupBox()
        Me.rdoMan = New System.Windows.Forms.RadioButton()
        Me.rdoWoman = New System.Windows.Forms.RadioButton()
        Me.cmdEnter = New System.Windows.Forms.Button()
        Me.rdoEnd = New System.Windows.Forms.Button()
        Me.lblAnser = New System.Windows.Forms.Label()
        Me.grpWork.SuspendLayout()
        Me.GrpSex.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpWork
        '
        Me.grpWork.Controls.Add(Me.rdoOther)
        Me.grpWork.Controls.Add(Me.rdoSelfEmp)
        Me.grpWork.Controls.Add(Me.rdoSalaryman)
        Me.grpWork.Controls.Add(Me.rdoStudent)
        Me.grpWork.Location = New System.Drawing.Point(44, 25)
        Me.grpWork.Name = "grpWork"
        Me.grpWork.Size = New System.Drawing.Size(108, 113)
        Me.grpWork.TabIndex = 0
        Me.grpWork.TabStop = False
        Me.grpWork.Text = "職種"
        '
        'rdoStudent
        '
        Me.rdoStudent.AutoSize = True
        Me.rdoStudent.Location = New System.Drawing.Point(17, 20)
        Me.rdoStudent.Name = "rdoStudent"
        Me.rdoStudent.Size = New System.Drawing.Size(47, 16)
        Me.rdoStudent.TabIndex = 0
        Me.rdoStudent.TabStop = True
        Me.rdoStudent.Text = "学生"
        Me.rdoStudent.UseVisualStyleBackColor = True
        '
        'rdoSalaryman
        '
        Me.rdoSalaryman.AutoSize = True
        Me.rdoSalaryman.Location = New System.Drawing.Point(17, 42)
        Me.rdoSalaryman.Name = "rdoSalaryman"
        Me.rdoSalaryman.Size = New System.Drawing.Size(76, 16)
        Me.rdoSalaryman.TabIndex = 1
        Me.rdoSalaryman.TabStop = True
        Me.rdoSalaryman.Text = "サラリーマン"
        Me.rdoSalaryman.UseVisualStyleBackColor = True
        '
        'rdoSelfEmp
        '
        Me.rdoSelfEmp.AutoSize = True
        Me.rdoSelfEmp.Location = New System.Drawing.Point(17, 64)
        Me.rdoSelfEmp.Name = "rdoSelfEmp"
        Me.rdoSelfEmp.Size = New System.Drawing.Size(59, 16)
        Me.rdoSelfEmp.TabIndex = 2
        Me.rdoSelfEmp.TabStop = True
        Me.rdoSelfEmp.Text = "自営業"
        Me.rdoSelfEmp.UseVisualStyleBackColor = True
        '
        'rdoOther
        '
        Me.rdoOther.AutoSize = True
        Me.rdoOther.Location = New System.Drawing.Point(17, 86)
        Me.rdoOther.Name = "rdoOther"
        Me.rdoOther.Size = New System.Drawing.Size(54, 16)
        Me.rdoOther.TabIndex = 3
        Me.rdoOther.TabStop = True
        Me.rdoOther.Text = "その他"
        Me.rdoOther.UseVisualStyleBackColor = True
        '
        'GrpSex
        '
        Me.GrpSex.Controls.Add(Me.rdoWoman)
        Me.GrpSex.Controls.Add(Me.rdoMan)
        Me.GrpSex.Location = New System.Drawing.Point(158, 25)
        Me.GrpSex.Name = "GrpSex"
        Me.GrpSex.Size = New System.Drawing.Size(82, 68)
        Me.GrpSex.TabIndex = 1
        Me.GrpSex.TabStop = False
        Me.GrpSex.Text = "性別"
        '
        'rdoMan
        '
        Me.rdoMan.AutoSize = True
        Me.rdoMan.Location = New System.Drawing.Point(17, 18)
        Me.rdoMan.Name = "rdoMan"
        Me.rdoMan.Size = New System.Drawing.Size(47, 16)
        Me.rdoMan.TabIndex = 0
        Me.rdoMan.TabStop = True
        Me.rdoMan.Text = "男性"
        Me.rdoMan.UseVisualStyleBackColor = True
        '
        'rdoWoman
        '
        Me.rdoWoman.AutoSize = True
        Me.rdoWoman.Location = New System.Drawing.Point(17, 42)
        Me.rdoWoman.Name = "rdoWoman"
        Me.rdoWoman.Size = New System.Drawing.Size(47, 16)
        Me.rdoWoman.TabIndex = 1
        Me.rdoWoman.TabStop = True
        Me.rdoWoman.Text = "女性"
        Me.rdoWoman.UseVisualStyleBackColor = True
        '
        'cmdEnter
        '
        Me.cmdEnter.Location = New System.Drawing.Point(165, 100)
        Me.cmdEnter.Name = "cmdEnter"
        Me.cmdEnter.Size = New System.Drawing.Size(75, 23)
        Me.cmdEnter.TabIndex = 2
        Me.cmdEnter.Text = "結果"
        Me.cmdEnter.UseVisualStyleBackColor = True
        '
        'rdoEnd
        '
        Me.rdoEnd.Location = New System.Drawing.Point(165, 129)
        Me.rdoEnd.Name = "rdoEnd"
        Me.rdoEnd.Size = New System.Drawing.Size(75, 23)
        Me.rdoEnd.TabIndex = 3
        Me.rdoEnd.Text = "終了"
        Me.rdoEnd.UseVisualStyleBackColor = True
        '
        'lblAnser
        '
        Me.lblAnser.AutoEllipsis = True
        Me.lblAnser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnser.Location = New System.Drawing.Point(44, 176)
        Me.lblAnser.Name = "lblAnser"
        Me.lblAnser.Size = New System.Drawing.Size(196, 23)
        Me.lblAnser.TabIndex = 4
        Me.lblAnser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 219)
        Me.Controls.Add(Me.lblAnser)
        Me.Controls.Add(Me.rdoEnd)
        Me.Controls.Add(Me.cmdEnter)
        Me.Controls.Add(Me.GrpSex)
        Me.Controls.Add(Me.grpWork)
        Me.Name = "Form1"
        Me.Text = "例題9-2 ラジオボタン"
        Me.grpWork.ResumeLayout(False)
        Me.grpWork.PerformLayout()
        Me.GrpSex.ResumeLayout(False)
        Me.GrpSex.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpWork As GroupBox
    Friend WithEvents rdoOther As RadioButton
    Friend WithEvents rdoSelfEmp As RadioButton
    Friend WithEvents rdoSalaryman As RadioButton
    Friend WithEvents rdoStudent As RadioButton
    Friend WithEvents GrpSex As GroupBox
    Friend WithEvents rdoWoman As RadioButton
    Friend WithEvents rdoMan As RadioButton
    Friend WithEvents cmdEnter As Button
    Friend WithEvents rdoEnd As Button
    Friend WithEvents lblAnser As Label
End Class
