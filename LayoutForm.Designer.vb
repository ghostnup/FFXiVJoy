<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LayoutForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabBackground = New System.Windows.Forms.TabPage()
        Me.TabJoystick = New System.Windows.Forms.TabPage()
        Me.cmbYAxis2 = New System.Windows.Forms.ComboBox()
        Me.cmbXAxis2 = New System.Windows.Forms.ComboBox()
        Me.cmbYAxis1 = New System.Windows.Forms.ComboBox()
        Me.cmbXAxis1 = New System.Windows.Forms.ComboBox()
        Me.TabDPad = New System.Windows.Forms.TabPage()
        Me.cmbDRt = New System.Windows.Forms.ComboBox()
        Me.cmbDLf = New System.Windows.Forms.ComboBox()
        Me.cmbDDn = New System.Windows.Forms.ComboBox()
        Me.cmbDUp = New System.Windows.Forms.ComboBox()
        Me.TabButton = New System.Windows.Forms.TabPage()
        Me.TabTrigger = New System.Windows.Forms.TabPage()
        Me.cmbRT = New System.Windows.Forms.ComboBox()
        Me.cmbLT = New System.Windows.Forms.ComboBox()
        Me.TabCombine = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DPAD = New System.Windows.Forms.PictureBox()
        Me.JoyRight = New System.Windows.Forms.PictureBox()
        Me.JoyLeft = New System.Windows.Forms.PictureBox()
        Me.btnOpen = New FFXiVJoy.iButton()
        Me.btnDefault = New FFXiVJoy.iButton()
        Me.chkJoy2 = New FFXiVJoy.iButton()
        Me.btnYAxis2 = New FFXiVJoy.iButton()
        Me.btnXAxis2 = New FFXiVJoy.iButton()
        Me.btnYAxis1 = New FFXiVJoy.iButton()
        Me.btnXAxis1 = New FFXiVJoy.iButton()
        Me.chkJoy1 = New FFXiVJoy.iButton()
        Me.btnDRt = New FFXiVJoy.iButton()
        Me.btnDLf = New FFXiVJoy.iButton()
        Me.btnDDn = New FFXiVJoy.iButton()
        Me.btnDUp = New FFXiVJoy.iButton()
        Me.chkDPad = New FFXiVJoy.iButton()
        Me.btnClearButton = New FFXiVJoy.iButton()
        Me.btnAddButton = New FFXiVJoy.iButton()
        Me.btnRemoveButton = New FFXiVJoy.iButton()
        Me.btnRT = New FFXiVJoy.iButton()
        Me.btnLT = New FFXiVJoy.iButton()
        Me.chkTrigger = New FFXiVJoy.iButton()
        Me.btnClearCB = New FFXiVJoy.iButton()
        Me.btnAddCB = New FFXiVJoy.iButton()
        Me.btnRemoveCB = New FFXiVJoy.iButton()
        Me.TabControl1.SuspendLayout()
        Me.TabBackground.SuspendLayout()
        Me.TabJoystick.SuspendLayout()
        Me.TabDPad.SuspendLayout()
        Me.TabButton.SuspendLayout()
        Me.TabTrigger.SuspendLayout()
        Me.TabCombine.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DPAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoyRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JoyLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabBackground)
        Me.TabControl1.Controls.Add(Me.TabJoystick)
        Me.TabControl1.Controls.Add(Me.TabDPad)
        Me.TabControl1.Controls.Add(Me.TabButton)
        Me.TabControl1.Controls.Add(Me.TabTrigger)
        Me.TabControl1.Controls.Add(Me.TabCombine)
        Me.TabControl1.Location = New System.Drawing.Point(0, 258)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(513, 174)
        Me.TabControl1.TabIndex = 42
        '
        'TabBackground
        '
        Me.TabBackground.Controls.Add(Me.btnOpen)
        Me.TabBackground.Controls.Add(Me.btnDefault)
        Me.TabBackground.Location = New System.Drawing.Point(4, 22)
        Me.TabBackground.Name = "TabBackground"
        Me.TabBackground.Padding = New System.Windows.Forms.Padding(3)
        Me.TabBackground.Size = New System.Drawing.Size(505, 148)
        Me.TabBackground.TabIndex = 0
        Me.TabBackground.Text = "背景"
        Me.TabBackground.UseVisualStyleBackColor = True
        '
        'TabJoystick
        '
        Me.TabJoystick.Controls.Add(Me.chkJoy2)
        Me.TabJoystick.Controls.Add(Me.btnYAxis2)
        Me.TabJoystick.Controls.Add(Me.btnXAxis2)
        Me.TabJoystick.Controls.Add(Me.btnYAxis1)
        Me.TabJoystick.Controls.Add(Me.btnXAxis1)
        Me.TabJoystick.Controls.Add(Me.chkJoy1)
        Me.TabJoystick.Controls.Add(Me.cmbYAxis2)
        Me.TabJoystick.Controls.Add(Me.cmbXAxis2)
        Me.TabJoystick.Controls.Add(Me.cmbYAxis1)
        Me.TabJoystick.Controls.Add(Me.cmbXAxis1)
        Me.TabJoystick.Location = New System.Drawing.Point(4, 22)
        Me.TabJoystick.Name = "TabJoystick"
        Me.TabJoystick.Padding = New System.Windows.Forms.Padding(3)
        Me.TabJoystick.Size = New System.Drawing.Size(505, 148)
        Me.TabJoystick.TabIndex = 1
        Me.TabJoystick.Text = "摇杆"
        Me.TabJoystick.UseVisualStyleBackColor = True
        '
        'cmbYAxis2
        '
        Me.cmbYAxis2.FormattingEnabled = True
        Me.cmbYAxis2.Location = New System.Drawing.Point(279, 113)
        Me.cmbYAxis2.Name = "cmbYAxis2"
        Me.cmbYAxis2.Size = New System.Drawing.Size(186, 20)
        Me.cmbYAxis2.TabIndex = 12
        '
        'cmbXAxis2
        '
        Me.cmbXAxis2.FormattingEnabled = True
        Me.cmbXAxis2.Location = New System.Drawing.Point(279, 47)
        Me.cmbXAxis2.Name = "cmbXAxis2"
        Me.cmbXAxis2.Size = New System.Drawing.Size(186, 20)
        Me.cmbXAxis2.TabIndex = 11
        '
        'cmbYAxis1
        '
        Me.cmbYAxis1.FormattingEnabled = True
        Me.cmbYAxis1.Location = New System.Drawing.Point(38, 113)
        Me.cmbYAxis1.Name = "cmbYAxis1"
        Me.cmbYAxis1.Size = New System.Drawing.Size(186, 20)
        Me.cmbYAxis1.TabIndex = 8
        '
        'cmbXAxis1
        '
        Me.cmbXAxis1.DisplayMember = "Table1.Column1"
        Me.cmbXAxis1.FormattingEnabled = True
        Me.cmbXAxis1.Location = New System.Drawing.Point(38, 47)
        Me.cmbXAxis1.Name = "cmbXAxis1"
        Me.cmbXAxis1.Size = New System.Drawing.Size(186, 20)
        Me.cmbXAxis1.TabIndex = 6
        Me.cmbXAxis1.ValueMember = "Table1.Column1"
        '
        'TabDPad
        '
        Me.TabDPad.Controls.Add(Me.btnDRt)
        Me.TabDPad.Controls.Add(Me.btnDLf)
        Me.TabDPad.Controls.Add(Me.btnDDn)
        Me.TabDPad.Controls.Add(Me.btnDUp)
        Me.TabDPad.Controls.Add(Me.chkDPad)
        Me.TabDPad.Controls.Add(Me.cmbDRt)
        Me.TabDPad.Controls.Add(Me.cmbDLf)
        Me.TabDPad.Controls.Add(Me.cmbDDn)
        Me.TabDPad.Controls.Add(Me.cmbDUp)
        Me.TabDPad.Location = New System.Drawing.Point(4, 22)
        Me.TabDPad.Name = "TabDPad"
        Me.TabDPad.Size = New System.Drawing.Size(505, 148)
        Me.TabDPad.TabIndex = 2
        Me.TabDPad.Text = "十字键"
        Me.TabDPad.UseVisualStyleBackColor = True
        '
        'cmbDRt
        '
        Me.cmbDRt.FormattingEnabled = True
        Me.cmbDRt.Location = New System.Drawing.Point(306, 110)
        Me.cmbDRt.Name = "cmbDRt"
        Me.cmbDRt.Size = New System.Drawing.Size(186, 20)
        Me.cmbDRt.TabIndex = 22
        '
        'cmbDLf
        '
        Me.cmbDLf.FormattingEnabled = True
        Me.cmbDLf.Location = New System.Drawing.Point(306, 68)
        Me.cmbDLf.Name = "cmbDLf"
        Me.cmbDLf.Size = New System.Drawing.Size(186, 20)
        Me.cmbDLf.TabIndex = 21
        '
        'cmbDDn
        '
        Me.cmbDDn.FormattingEnabled = True
        Me.cmbDDn.Location = New System.Drawing.Point(54, 110)
        Me.cmbDDn.Name = "cmbDDn"
        Me.cmbDDn.Size = New System.Drawing.Size(186, 20)
        Me.cmbDDn.TabIndex = 18
        '
        'cmbDUp
        '
        Me.cmbDUp.FormattingEnabled = True
        Me.cmbDUp.Location = New System.Drawing.Point(54, 68)
        Me.cmbDUp.Name = "cmbDUp"
        Me.cmbDUp.Size = New System.Drawing.Size(186, 20)
        Me.cmbDUp.TabIndex = 17
        '
        'TabButton
        '
        Me.TabButton.Controls.Add(Me.btnClearButton)
        Me.TabButton.Controls.Add(Me.btnAddButton)
        Me.TabButton.Controls.Add(Me.btnRemoveButton)
        Me.TabButton.Location = New System.Drawing.Point(4, 22)
        Me.TabButton.Name = "TabButton"
        Me.TabButton.Size = New System.Drawing.Size(505, 148)
        Me.TabButton.TabIndex = 3
        Me.TabButton.Text = "按键"
        Me.TabButton.UseVisualStyleBackColor = True
        '
        'TabTrigger
        '
        Me.TabTrigger.Controls.Add(Me.btnRT)
        Me.TabTrigger.Controls.Add(Me.btnLT)
        Me.TabTrigger.Controls.Add(Me.chkTrigger)
        Me.TabTrigger.Controls.Add(Me.cmbRT)
        Me.TabTrigger.Controls.Add(Me.cmbLT)
        Me.TabTrigger.Location = New System.Drawing.Point(4, 22)
        Me.TabTrigger.Name = "TabTrigger"
        Me.TabTrigger.Size = New System.Drawing.Size(505, 148)
        Me.TabTrigger.TabIndex = 4
        Me.TabTrigger.Text = "扳机键"
        Me.TabTrigger.UseVisualStyleBackColor = True
        '
        'cmbRT
        '
        Me.cmbRT.FormattingEnabled = True
        Me.cmbRT.Location = New System.Drawing.Point(306, 82)
        Me.cmbRT.Name = "cmbRT"
        Me.cmbRT.Size = New System.Drawing.Size(186, 20)
        Me.cmbRT.TabIndex = 27
        '
        'cmbLT
        '
        Me.cmbLT.FormattingEnabled = True
        Me.cmbLT.Location = New System.Drawing.Point(54, 82)
        Me.cmbLT.Name = "cmbLT"
        Me.cmbLT.Size = New System.Drawing.Size(186, 20)
        Me.cmbLT.TabIndex = 25
        '
        'TabCombine
        '
        Me.TabCombine.Controls.Add(Me.btnClearCB)
        Me.TabCombine.Controls.Add(Me.btnAddCB)
        Me.TabCombine.Controls.Add(Me.btnRemoveCB)
        Me.TabCombine.Location = New System.Drawing.Point(4, 22)
        Me.TabCombine.Name = "TabCombine"
        Me.TabCombine.Size = New System.Drawing.Size(505, 148)
        Me.TabCombine.TabIndex = 5
        Me.TabCombine.Text = "自定义组合键"
        Me.TabCombine.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DPAD)
        Me.Panel1.Controls.Add(Me.JoyRight)
        Me.Panel1.Controls.Add(Me.JoyLeft)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(511, 254)
        Me.Panel1.TabIndex = 0
        '
        'DPAD
        '
        Me.DPAD.Location = New System.Drawing.Point(128, 147)
        Me.DPAD.Name = "DPAD"
        Me.DPAD.Size = New System.Drawing.Size(100, 100)
        Me.DPAD.TabIndex = 2
        Me.DPAD.TabStop = False
        Me.DPAD.Visible = False
        '
        'JoyRight
        '
        Me.JoyRight.Location = New System.Drawing.Point(281, 147)
        Me.JoyRight.Name = "JoyRight"
        Me.JoyRight.Size = New System.Drawing.Size(100, 100)
        Me.JoyRight.TabIndex = 1
        Me.JoyRight.TabStop = False
        Me.JoyRight.Visible = False
        '
        'JoyLeft
        '
        Me.JoyLeft.Location = New System.Drawing.Point(54, 57)
        Me.JoyLeft.Name = "JoyLeft"
        Me.JoyLeft.Size = New System.Drawing.Size(100, 100)
        Me.JoyLeft.TabIndex = 0
        Me.JoyLeft.TabStop = False
        Me.JoyLeft.Visible = False
        '
        'btnOpen
        '
        Me.btnOpen.AntiAlias = False
        Me.btnOpen.BackColor = System.Drawing.Color.Transparent
        Me.btnOpen.FlatAppearance.BorderSize = 0
        Me.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpen.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnOpen.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnOpen.Location = New System.Drawing.Point(187, 40)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(131, 31)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.TagJump = Nothing
        Me.btnOpen.TagLock = False
        Me.btnOpen.Text = "浏览"
        Me.btnOpen.TextColor = System.Drawing.Color.Black
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'btnDefault
        '
        Me.btnDefault.AntiAlias = False
        Me.btnDefault.BackColor = System.Drawing.Color.Transparent
        Me.btnDefault.FlatAppearance.BorderSize = 0
        Me.btnDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDefault.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDefault.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnDefault.Location = New System.Drawing.Point(187, 77)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(131, 31)
        Me.btnDefault.TabIndex = 2
        Me.btnDefault.TagJump = Nothing
        Me.btnDefault.TagLock = False
        Me.btnDefault.Text = "使用默认"
        Me.btnDefault.TextColor = System.Drawing.Color.Black
        Me.btnDefault.UseVisualStyleBackColor = False
        '
        'chkJoy2
        '
        Me.chkJoy2.AntiAlias = False
        Me.chkJoy2.BackColor = System.Drawing.Color.Transparent
        Me.chkJoy2.CheckBox = True
        Me.chkJoy2.FlatAppearance.BorderSize = 0
        Me.chkJoy2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkJoy2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chkJoy2.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.chkJoy2.Location = New System.Drawing.Point(249, 15)
        Me.chkJoy2.Name = "chkJoy2"
        Me.chkJoy2.Size = New System.Drawing.Size(24, 118)
        Me.chkJoy2.TabIndex = 19
        Me.chkJoy2.TagJump = Nothing
        Me.chkJoy2.TagLock = False
        Me.chkJoy2.Text = "启用右摇杆"
        Me.chkJoy2.TextColor = System.Drawing.Color.Black
        Me.chkJoy2.UseVisualStyleBackColor = False
        '
        'btnYAxis2
        '
        Me.btnYAxis2.AntiAlias = False
        Me.btnYAxis2.BackColor = System.Drawing.Color.Transparent
        Me.btnYAxis2.FlatAppearance.BorderSize = 0
        Me.btnYAxis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYAxis2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnYAxis2.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnYAxis2.Location = New System.Drawing.Point(279, 82)
        Me.btnYAxis2.Name = "btnYAxis2"
        Me.btnYAxis2.Size = New System.Drawing.Size(80, 26)
        Me.btnYAxis2.TabIndex = 18
        Me.btnYAxis2.TagJump = Nothing
        Me.btnYAxis2.TagLock = False
        Me.btnYAxis2.Text = "检测Y轴"
        Me.btnYAxis2.TextColor = System.Drawing.Color.Black
        Me.btnYAxis2.UseVisualStyleBackColor = False
        '
        'btnXAxis2
        '
        Me.btnXAxis2.AntiAlias = False
        Me.btnXAxis2.BackColor = System.Drawing.Color.Transparent
        Me.btnXAxis2.FlatAppearance.BorderSize = 0
        Me.btnXAxis2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXAxis2.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnXAxis2.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnXAxis2.Location = New System.Drawing.Point(279, 15)
        Me.btnXAxis2.Name = "btnXAxis2"
        Me.btnXAxis2.Size = New System.Drawing.Size(80, 26)
        Me.btnXAxis2.TabIndex = 17
        Me.btnXAxis2.TagJump = Nothing
        Me.btnXAxis2.TagLock = False
        Me.btnXAxis2.Text = "检测X轴"
        Me.btnXAxis2.TextColor = System.Drawing.Color.Black
        Me.btnXAxis2.UseVisualStyleBackColor = False
        '
        'btnYAxis1
        '
        Me.btnYAxis1.AntiAlias = False
        Me.btnYAxis1.BackColor = System.Drawing.Color.Transparent
        Me.btnYAxis1.FlatAppearance.BorderSize = 0
        Me.btnYAxis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYAxis1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnYAxis1.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnYAxis1.Location = New System.Drawing.Point(38, 82)
        Me.btnYAxis1.Name = "btnYAxis1"
        Me.btnYAxis1.Size = New System.Drawing.Size(80, 26)
        Me.btnYAxis1.TabIndex = 16
        Me.btnYAxis1.TagJump = Nothing
        Me.btnYAxis1.TagLock = False
        Me.btnYAxis1.Text = "检测Y轴"
        Me.btnYAxis1.TextColor = System.Drawing.Color.Black
        Me.btnYAxis1.UseVisualStyleBackColor = False
        '
        'btnXAxis1
        '
        Me.btnXAxis1.AntiAlias = False
        Me.btnXAxis1.BackColor = System.Drawing.Color.Transparent
        Me.btnXAxis1.FlatAppearance.BorderSize = 0
        Me.btnXAxis1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnXAxis1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnXAxis1.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnXAxis1.Location = New System.Drawing.Point(38, 15)
        Me.btnXAxis1.Name = "btnXAxis1"
        Me.btnXAxis1.Size = New System.Drawing.Size(80, 26)
        Me.btnXAxis1.TabIndex = 15
        Me.btnXAxis1.TagJump = Nothing
        Me.btnXAxis1.TagLock = False
        Me.btnXAxis1.Text = "检测X轴"
        Me.btnXAxis1.TextColor = System.Drawing.Color.Black
        Me.btnXAxis1.UseVisualStyleBackColor = False
        '
        'chkJoy1
        '
        Me.chkJoy1.AntiAlias = False
        Me.chkJoy1.BackColor = System.Drawing.Color.Transparent
        Me.chkJoy1.CheckBox = True
        Me.chkJoy1.FlatAppearance.BorderSize = 0
        Me.chkJoy1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkJoy1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chkJoy1.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.chkJoy1.Location = New System.Drawing.Point(8, 15)
        Me.chkJoy1.Name = "chkJoy1"
        Me.chkJoy1.Size = New System.Drawing.Size(24, 118)
        Me.chkJoy1.TabIndex = 13
        Me.chkJoy1.TagJump = Nothing
        Me.chkJoy1.TagLock = False
        Me.chkJoy1.Text = "启用左摇杆"
        Me.chkJoy1.TextColor = System.Drawing.Color.Black
        Me.chkJoy1.UseVisualStyleBackColor = False
        '
        'btnDRt
        '
        Me.btnDRt.AntiAlias = False
        Me.btnDRt.BackColor = System.Drawing.Color.Transparent
        Me.btnDRt.FlatAppearance.BorderSize = 0
        Me.btnDRt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDRt.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDRt.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnDRt.Location = New System.Drawing.Point(260, 102)
        Me.btnDRt.Name = "btnDRt"
        Me.btnDRt.Size = New System.Drawing.Size(40, 40)
        Me.btnDRt.TabIndex = 27
        Me.btnDRt.TagJump = Nothing
        Me.btnDRt.TagLock = False
        Me.btnDRt.Text = "→"
        Me.btnDRt.TextColor = System.Drawing.Color.Black
        Me.btnDRt.UseVisualStyleBackColor = False
        '
        'btnDLf
        '
        Me.btnDLf.AntiAlias = False
        Me.btnDLf.BackColor = System.Drawing.Color.Transparent
        Me.btnDLf.FlatAppearance.BorderSize = 0
        Me.btnDLf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDLf.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDLf.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnDLf.Location = New System.Drawing.Point(260, 57)
        Me.btnDLf.Name = "btnDLf"
        Me.btnDLf.Size = New System.Drawing.Size(40, 40)
        Me.btnDLf.TabIndex = 26
        Me.btnDLf.TagJump = Nothing
        Me.btnDLf.TagLock = False
        Me.btnDLf.Text = "←"
        Me.btnDLf.TextColor = System.Drawing.Color.Black
        Me.btnDLf.UseVisualStyleBackColor = False
        '
        'btnDDn
        '
        Me.btnDDn.AntiAlias = False
        Me.btnDDn.BackColor = System.Drawing.Color.Transparent
        Me.btnDDn.FlatAppearance.BorderSize = 0
        Me.btnDDn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDDn.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDDn.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnDDn.Location = New System.Drawing.Point(8, 102)
        Me.btnDDn.Name = "btnDDn"
        Me.btnDDn.Size = New System.Drawing.Size(40, 40)
        Me.btnDDn.TabIndex = 25
        Me.btnDDn.TagJump = Nothing
        Me.btnDDn.TagLock = False
        Me.btnDDn.Text = "↓"
        Me.btnDDn.TextColor = System.Drawing.Color.Black
        Me.btnDDn.UseVisualStyleBackColor = False
        '
        'btnDUp
        '
        Me.btnDUp.AntiAlias = False
        Me.btnDUp.BackColor = System.Drawing.Color.Transparent
        Me.btnDUp.FlatAppearance.BorderSize = 0
        Me.btnDUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDUp.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDUp.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnDUp.Location = New System.Drawing.Point(8, 57)
        Me.btnDUp.Name = "btnDUp"
        Me.btnDUp.Size = New System.Drawing.Size(40, 40)
        Me.btnDUp.TabIndex = 24
        Me.btnDUp.TagJump = Nothing
        Me.btnDUp.TagLock = False
        Me.btnDUp.Text = "↑"
        Me.btnDUp.TextColor = System.Drawing.Color.Black
        Me.btnDUp.UseVisualStyleBackColor = False
        '
        'chkDPad
        '
        Me.chkDPad.AntiAlias = False
        Me.chkDPad.BackColor = System.Drawing.Color.Transparent
        Me.chkDPad.CheckBox = True
        Me.chkDPad.FlatAppearance.BorderSize = 0
        Me.chkDPad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkDPad.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chkDPad.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.chkDPad.Location = New System.Drawing.Point(8, 8)
        Me.chkDPad.Name = "chkDPad"
        Me.chkDPad.Size = New System.Drawing.Size(487, 34)
        Me.chkDPad.TabIndex = 23
        Me.chkDPad.TagJump = Nothing
        Me.chkDPad.TagLock = False
        Me.chkDPad.Text = "启用十字键"
        Me.chkDPad.TextColor = System.Drawing.Color.Black
        Me.chkDPad.UseVisualStyleBackColor = False
        '
        'btnClearButton
        '
        Me.btnClearButton.AntiAlias = False
        Me.btnClearButton.BackColor = System.Drawing.Color.Transparent
        Me.btnClearButton.FlatAppearance.BorderSize = 0
        Me.btnClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClearButton.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnClearButton.Location = New System.Drawing.Point(187, 96)
        Me.btnClearButton.Name = "btnClearButton"
        Me.btnClearButton.Size = New System.Drawing.Size(131, 31)
        Me.btnClearButton.TabIndex = 7
        Me.btnClearButton.TagJump = Nothing
        Me.btnClearButton.TagLock = False
        Me.btnClearButton.Text = "清空按钮"
        Me.btnClearButton.TextColor = System.Drawing.Color.Black
        Me.btnClearButton.UseVisualStyleBackColor = False
        '
        'btnAddButton
        '
        Me.btnAddButton.AntiAlias = False
        Me.btnAddButton.BackColor = System.Drawing.Color.Transparent
        Me.btnAddButton.FlatAppearance.BorderSize = 0
        Me.btnAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAddButton.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnAddButton.Location = New System.Drawing.Point(187, 22)
        Me.btnAddButton.Name = "btnAddButton"
        Me.btnAddButton.Size = New System.Drawing.Size(131, 31)
        Me.btnAddButton.TabIndex = 6
        Me.btnAddButton.TagJump = Nothing
        Me.btnAddButton.TagLock = False
        Me.btnAddButton.Text = "添加按钮"
        Me.btnAddButton.TextColor = System.Drawing.Color.Black
        Me.btnAddButton.UseVisualStyleBackColor = False
        '
        'btnRemoveButton
        '
        Me.btnRemoveButton.AntiAlias = False
        Me.btnRemoveButton.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveButton.FlatAppearance.BorderSize = 0
        Me.btnRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveButton.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRemoveButton.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnRemoveButton.Location = New System.Drawing.Point(187, 59)
        Me.btnRemoveButton.Name = "btnRemoveButton"
        Me.btnRemoveButton.Size = New System.Drawing.Size(131, 31)
        Me.btnRemoveButton.TabIndex = 5
        Me.btnRemoveButton.TagJump = Nothing
        Me.btnRemoveButton.TagLock = False
        Me.btnRemoveButton.Text = "删除按钮"
        Me.btnRemoveButton.TextColor = System.Drawing.Color.Black
        Me.btnRemoveButton.UseVisualStyleBackColor = False
        '
        'btnRT
        '
        Me.btnRT.AntiAlias = False
        Me.btnRT.BackColor = System.Drawing.Color.Transparent
        Me.btnRT.FlatAppearance.BorderSize = 0
        Me.btnRT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRT.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRT.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnRT.Location = New System.Drawing.Point(260, 71)
        Me.btnRT.Name = "btnRT"
        Me.btnRT.Size = New System.Drawing.Size(40, 40)
        Me.btnRT.TabIndex = 30
        Me.btnRT.TagJump = Nothing
        Me.btnRT.TagLock = False
        Me.btnRT.Text = "RT"
        Me.btnRT.TextColor = System.Drawing.Color.Black
        Me.btnRT.UseVisualStyleBackColor = False
        '
        'btnLT
        '
        Me.btnLT.AntiAlias = False
        Me.btnLT.BackColor = System.Drawing.Color.Transparent
        Me.btnLT.FlatAppearance.BorderSize = 0
        Me.btnLT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLT.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnLT.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnLT.Location = New System.Drawing.Point(8, 71)
        Me.btnLT.Name = "btnLT"
        Me.btnLT.Size = New System.Drawing.Size(40, 40)
        Me.btnLT.TabIndex = 29
        Me.btnLT.TagJump = Nothing
        Me.btnLT.TagLock = False
        Me.btnLT.Text = "LT"
        Me.btnLT.TextColor = System.Drawing.Color.Black
        Me.btnLT.UseVisualStyleBackColor = False
        '
        'chkTrigger
        '
        Me.chkTrigger.AntiAlias = False
        Me.chkTrigger.BackColor = System.Drawing.Color.Transparent
        Me.chkTrigger.CheckBox = True
        Me.chkTrigger.FlatAppearance.BorderSize = 0
        Me.chkTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkTrigger.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chkTrigger.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.chkTrigger.Location = New System.Drawing.Point(8, 8)
        Me.chkTrigger.Name = "chkTrigger"
        Me.chkTrigger.Size = New System.Drawing.Size(487, 34)
        Me.chkTrigger.TabIndex = 28
        Me.chkTrigger.TagJump = Nothing
        Me.chkTrigger.TagLock = False
        Me.chkTrigger.Text = "启用扳机键"
        Me.chkTrigger.TextColor = System.Drawing.Color.Black
        Me.chkTrigger.UseVisualStyleBackColor = False
        '
        'btnClearCB
        '
        Me.btnClearCB.AntiAlias = False
        Me.btnClearCB.BackColor = System.Drawing.Color.Transparent
        Me.btnClearCB.FlatAppearance.BorderSize = 0
        Me.btnClearCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearCB.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnClearCB.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnClearCB.Location = New System.Drawing.Point(187, 96)
        Me.btnClearCB.Name = "btnClearCB"
        Me.btnClearCB.Size = New System.Drawing.Size(131, 31)
        Me.btnClearCB.TabIndex = 7
        Me.btnClearCB.TagJump = Nothing
        Me.btnClearCB.TagLock = False
        Me.btnClearCB.Text = "清空组合键"
        Me.btnClearCB.TextColor = System.Drawing.Color.Black
        Me.btnClearCB.UseVisualStyleBackColor = False
        '
        'btnAddCB
        '
        Me.btnAddCB.AntiAlias = False
        Me.btnAddCB.BackColor = System.Drawing.Color.Transparent
        Me.btnAddCB.FlatAppearance.BorderSize = 0
        Me.btnAddCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCB.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnAddCB.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnAddCB.Location = New System.Drawing.Point(187, 22)
        Me.btnAddCB.Name = "btnAddCB"
        Me.btnAddCB.Size = New System.Drawing.Size(131, 31)
        Me.btnAddCB.TabIndex = 6
        Me.btnAddCB.TagJump = Nothing
        Me.btnAddCB.TagLock = False
        Me.btnAddCB.Text = "添加组合键"
        Me.btnAddCB.TextColor = System.Drawing.Color.Black
        Me.btnAddCB.UseVisualStyleBackColor = False
        '
        'btnRemoveCB
        '
        Me.btnRemoveCB.AntiAlias = False
        Me.btnRemoveCB.BackColor = System.Drawing.Color.Transparent
        Me.btnRemoveCB.FlatAppearance.BorderSize = 0
        Me.btnRemoveCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRemoveCB.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRemoveCB.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnRemoveCB.Location = New System.Drawing.Point(187, 59)
        Me.btnRemoveCB.Name = "btnRemoveCB"
        Me.btnRemoveCB.Size = New System.Drawing.Size(131, 31)
        Me.btnRemoveCB.TabIndex = 5
        Me.btnRemoveCB.TagJump = Nothing
        Me.btnRemoveCB.TagLock = False
        Me.btnRemoveCB.Text = "删除组合键"
        Me.btnRemoveCB.TextColor = System.Drawing.Color.Black
        Me.btnRemoveCB.UseVisualStyleBackColor = False
        '
        'LayoutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "LayoutForm"
        Me.ShowInTaskbar = False
        Me.Text = "手柄按键设定"
        Me.TabControl1.ResumeLayout(False)
        Me.TabBackground.ResumeLayout(False)
        Me.TabJoystick.ResumeLayout(False)
        Me.TabDPad.ResumeLayout(False)
        Me.TabButton.ResumeLayout(False)
        Me.TabTrigger.ResumeLayout(False)
        Me.TabCombine.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.DPAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoyRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JoyLeft, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabBackground As System.Windows.Forms.TabPage
    Friend WithEvents TabJoystick As System.Windows.Forms.TabPage
    Friend WithEvents TabDPad As System.Windows.Forms.TabPage
    Friend WithEvents TabTrigger As System.Windows.Forms.TabPage
    Friend WithEvents TabCombine As System.Windows.Forms.TabPage
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbYAxis1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbXAxis1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbYAxis2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbXAxis2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDRt As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDLf As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDDn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDUp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRT As System.Windows.Forms.ComboBox
    Friend WithEvents cmbLT As System.Windows.Forms.ComboBox

    Public Sub New()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
    End Sub

    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DPAD As System.Windows.Forms.PictureBox
    Friend WithEvents JoyRight As System.Windows.Forms.PictureBox
    Friend WithEvents JoyLeft As System.Windows.Forms.PictureBox
    Friend WithEvents chkJoy1 As FFXiVJoy.iButton
    Friend WithEvents btnYAxis2 As FFXiVJoy.iButton
    Friend WithEvents btnXAxis2 As FFXiVJoy.iButton
    Friend WithEvents btnYAxis1 As FFXiVJoy.iButton
    Friend WithEvents btnXAxis1 As FFXiVJoy.iButton
    Friend WithEvents btnDRt As FFXiVJoy.iButton
    Friend WithEvents btnDLf As FFXiVJoy.iButton
    Friend WithEvents btnDDn As FFXiVJoy.iButton
    Friend WithEvents btnDUp As FFXiVJoy.iButton
    Friend WithEvents chkDPad As FFXiVJoy.iButton
    Friend WithEvents btnRT As FFXiVJoy.iButton
    Friend WithEvents btnLT As FFXiVJoy.iButton
    Friend WithEvents chkTrigger As FFXiVJoy.iButton
    Friend WithEvents btnOpen As FFXiVJoy.iButton
    Friend WithEvents btnDefault As FFXiVJoy.iButton
    Friend WithEvents TabButton As System.Windows.Forms.TabPage
    Friend WithEvents btnClearButton As FFXiVJoy.iButton
    Friend WithEvents btnAddButton As FFXiVJoy.iButton
    Friend WithEvents btnRemoveButton As FFXiVJoy.iButton
    Friend WithEvents btnClearCB As FFXiVJoy.iButton
    Friend WithEvents btnAddCB As FFXiVJoy.iButton
    Friend WithEvents btnRemoveCB As FFXiVJoy.iButton
    Friend WithEvents chkJoy2 As FFXiVJoy.iButton

End Class
