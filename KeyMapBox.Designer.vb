<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KeyMapBox
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.KeyBox1 = New System.Windows.Forms.TextBox()
        Me.btnESC = New FFXiVJoy.iButton()
        Me.btnClear = New FFXiVJoy.iButton()
        Me.SuspendLayout()
        '
        'KeyBox1
        '
        Me.KeyBox1.BackColor = System.Drawing.Color.White
        Me.KeyBox1.Enabled = False
        Me.KeyBox1.Font = New System.Drawing.Font("微软雅黑", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.KeyBox1.Location = New System.Drawing.Point(12, 11)
        Me.KeyBox1.MaxLength = 25
        Me.KeyBox1.Name = "KeyBox1"
        Me.KeyBox1.ReadOnly = True
        Me.KeyBox1.ShortcutsEnabled = False
        Me.KeyBox1.Size = New System.Drawing.Size(361, 29)
        Me.KeyBox1.TabIndex = 1
        Me.KeyBox1.Text = "空"
        Me.KeyBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnESC
        '
        Me.btnESC.AntiAlias = False
        Me.btnESC.BackColor = System.Drawing.Color.Transparent
        Me.btnESC.FlatAppearance.BorderSize = 0
        Me.btnESC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnESC.Font = New System.Drawing.Font("新宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnESC.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnESC.Location = New System.Drawing.Point(98, 43)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(87, 26)
        Me.btnESC.TabIndex = 11
        Me.btnESC.TabStop = False
        Me.btnESC.TagJump = Nothing
        Me.btnESC.TagLock = False
        Me.btnESC.Text = "退出"
        Me.btnESC.TextColor = System.Drawing.Color.Black
        Me.btnESC.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.AntiAlias = False
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("新宋体", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClear.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnClear.Location = New System.Drawing.Point(199, 43)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 26)
        Me.btnClear.TabIndex = 10
        Me.btnClear.TabStop = False
        Me.btnClear.TagJump = Nothing
        Me.btnClear.TagLock = False
        Me.btnClear.Text = "清除"
        Me.btnClear.TextColor = System.Drawing.Color.Black
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'KeyMapBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(385, 73)
        Me.Controls.Add(Me.btnESC)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.KeyBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "KeyMapBox"
        Me.Padding = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "按下要映射的按键(ESC退出)"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KeyBox1 As System.Windows.Forms.TextBox

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。

    End Sub
    Friend WithEvents btnESC As FFXiVJoy.iButton
    Friend WithEvents btnClear As FFXiVJoy.iButton
End Class
