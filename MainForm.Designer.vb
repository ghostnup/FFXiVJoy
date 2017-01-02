<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TimerXInput = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.MenuBar = New System.Windows.Forms.MenuStrip()
        Me.配置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.置顶显示ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.简单帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.关于ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnJoyStickR = New FFXiVJoy.iButton()
        Me.btnMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.JmpMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JmpNMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JmpAMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JmpSMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JmpCMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AutoMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemindMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnJoyStickL = New FFXiVJoy.iButton()
        Me.btnJoyStick25 = New FFXiVJoy.iButton()
        Me.btnJoyStick1 = New FFXiVJoy.iButton()
        Me.btnJoyStick5 = New FFXiVJoy.iButton()
        Me.btnJoyStick4 = New FFXiVJoy.iButton()
        Me.btnJoyStick3 = New FFXiVJoy.iButton()
        Me.btnJoyStick2 = New FFXiVJoy.iButton()
        Me.btnJoyStick14 = New FFXiVJoy.iButton()
        Me.btnJoyStick18 = New FFXiVJoy.iButton()
        Me.btnJoyStick17 = New FFXiVJoy.iButton()
        Me.btnJoyStick16 = New FFXiVJoy.iButton()
        Me.btnJoyStick15 = New FFXiVJoy.iButton()
        Me.btnJoyStick10 = New FFXiVJoy.iButton()
        Me.btnJoyStick13 = New FFXiVJoy.iButton()
        Me.btnJoyStick12 = New FFXiVJoy.iButton()
        Me.btnJoyStick11 = New FFXiVJoy.iButton()
        Me.btnJoyStick6 = New FFXiVJoy.iButton()
        Me.btnJoyStick9 = New FFXiVJoy.iButton()
        Me.btnJoyStick8 = New FFXiVJoy.iButton()
        Me.btnJoyStick7 = New FFXiVJoy.iButton()
        Me.btnJoyStick24 = New FFXiVJoy.iButton()
        Me.btnJoyStick23 = New FFXiVJoy.iButton()
        Me.btnJoyStick22 = New FFXiVJoy.iButton()
        Me.btnJoyStick21 = New FFXiVJoy.iButton()
        Me.btnJoyStick20 = New FFXiVJoy.iButton()
        Me.btnJoyStick19 = New FFXiVJoy.iButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DeviceBox1 = New System.Windows.Forms.ComboBox()
        Me.pageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.复制页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.清除页ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigBox1 = New System.Windows.Forms.ComboBox()
        Me.profileMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.保存配置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.重命名ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.另存为ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.添加配置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除配置ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
        Me.打开配置文件夹ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.NotifyMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.打开主窗口ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.jobMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.通用 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddJobMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.骑士MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.战士MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.黑骑MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripSeparator()
        Me.白魔MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.学者MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.占星MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripSeparator()
        Me.武僧MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.龙骑MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.忍者MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripSeparator()
        Me.诗人MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.机工MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripSeparator()
        Me.黑魔MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.召唤MenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutoSwitchMnuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerScanMemory = New System.Windows.Forms.Timer(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnConfig = New FFXiVJoy.iButton()
        Me.btnJob = New FFXiVJoy.iButton()
        Me.btnProfile = New FFXiVJoy.iButton()
        Me.PanelPage = New System.Windows.Forms.TableLayoutPanel()
        Me.btnPage8 = New FFXiVJoy.iButton()
        Me.btnPage1 = New FFXiVJoy.iButton()
        Me.btnPage7 = New FFXiVJoy.iButton()
        Me.btnPage2 = New FFXiVJoy.iButton()
        Me.btnPage6 = New FFXiVJoy.iButton()
        Me.btnPage3 = New FFXiVJoy.iButton()
        Me.btnPage5 = New FFXiVJoy.iButton()
        Me.btnPage4 = New FFXiVJoy.iButton()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuBar.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.btnMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pageMenu.SuspendLayout()
        Me.profileMenu.SuspendLayout()
        Me.NotifyMenu.SuspendLayout()
        Me.jobMenu.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.PanelPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.AcceptsReturn = True
        Me.TextBox1.Location = New System.Drawing.Point(13, 355)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(511, 56)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.TabStop = False
        '
        'TimerXInput
        '
        Me.TimerXInput.Interval = 10
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.Location = New System.Drawing.Point(13, 411)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(511, 69)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        '
        'MenuBar
        '
        Me.MenuBar.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.MenuBar.Font = New System.Drawing.Font("微软雅黑", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.MenuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.配置ToolStripMenuItem, Me.关于ToolStripMenuItem})
        Me.MenuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.MenuBar.Location = New System.Drawing.Point(0, 0)
        Me.MenuBar.Name = "MenuBar"
        Me.MenuBar.Size = New System.Drawing.Size(538, 25)
        Me.MenuBar.TabIndex = 8
        '
        '配置ToolStripMenuItem
        '
        Me.配置ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.置顶显示ToolStripMenuItem, Me.ToolStripSeparator1, Me.ToolStripMenuItem3, Me.ToolStripMenuItem1, Me.退出ToolStripMenuItem})
        Me.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem"
        Me.配置ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.配置ToolStripMenuItem.Text = "配置"
        '
        '置顶显示ToolStripMenuItem
        '
        Me.置顶显示ToolStripMenuItem.Name = "置顶显示ToolStripMenuItem"
        Me.置顶显示ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.置顶显示ToolStripMenuItem.Text = "置顶显示"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(121, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(124, 22)
        Me.ToolStripMenuItem3.Text = "开机启动"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(121, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.简单帮助ToolStripMenuItem, Me.ToolStripMenuItem2, Me.关于ToolStripMenuItem1})
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.关于ToolStripMenuItem.Text = "帮助"
        '
        '简单帮助ToolStripMenuItem
        '
        Me.简单帮助ToolStripMenuItem.Name = "简单帮助ToolStripMenuItem"
        Me.简单帮助ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.简单帮助ToolStripMenuItem.Text = "简单帮助"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(121, 6)
        '
        '关于ToolStripMenuItem1
        '
        Me.关于ToolStripMenuItem1.Name = "关于ToolStripMenuItem1"
        Me.关于ToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.关于ToolStripMenuItem1.Text = "关于"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnJoyStickR)
        Me.Panel1.Controls.Add(Me.btnJoyStickL)
        Me.Panel1.Controls.Add(Me.btnJoyStick25)
        Me.Panel1.Controls.Add(Me.btnJoyStick1)
        Me.Panel1.Controls.Add(Me.btnJoyStick5)
        Me.Panel1.Controls.Add(Me.btnJoyStick4)
        Me.Panel1.Controls.Add(Me.btnJoyStick3)
        Me.Panel1.Controls.Add(Me.btnJoyStick2)
        Me.Panel1.Controls.Add(Me.btnJoyStick14)
        Me.Panel1.Controls.Add(Me.btnJoyStick18)
        Me.Panel1.Controls.Add(Me.btnJoyStick17)
        Me.Panel1.Controls.Add(Me.btnJoyStick16)
        Me.Panel1.Controls.Add(Me.btnJoyStick15)
        Me.Panel1.Controls.Add(Me.btnJoyStick10)
        Me.Panel1.Controls.Add(Me.btnJoyStick13)
        Me.Panel1.Controls.Add(Me.btnJoyStick12)
        Me.Panel1.Controls.Add(Me.btnJoyStick11)
        Me.Panel1.Controls.Add(Me.btnJoyStick6)
        Me.Panel1.Controls.Add(Me.btnJoyStick9)
        Me.Panel1.Controls.Add(Me.btnJoyStick8)
        Me.Panel1.Controls.Add(Me.btnJoyStick7)
        Me.Panel1.Controls.Add(Me.btnJoyStick24)
        Me.Panel1.Controls.Add(Me.btnJoyStick23)
        Me.Panel1.Controls.Add(Me.btnJoyStick22)
        Me.Panel1.Controls.Add(Me.btnJoyStick21)
        Me.Panel1.Controls.Add(Me.btnJoyStick20)
        Me.Panel1.Controls.Add(Me.btnJoyStick19)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(11, 28)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 256)
        Me.Panel1.TabIndex = 40
        '
        'btnJoyStickR
        '
        Me.btnJoyStickR.AntiAlias = False
        Me.btnJoyStickR.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStickR.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStickR.FlatAppearance.BorderSize = 0
        Me.btnJoyStickR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStickR.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStickR.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStickR.Location = New System.Drawing.Point(277, 11)
        Me.btnJoyStickR.Name = "btnJoyStickR"
        Me.btnJoyStickR.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStickR.TabIndex = 67
        Me.btnJoyStickR.TagJump = Nothing
        Me.btnJoyStickR.TagLock = False
        Me.btnJoyStickR.Text = "cmbR"
        Me.btnJoyStickR.TextColor = System.Drawing.Color.Black
        Me.ToolTip1.SetToolTip(Me.btnJoyStickR, "组合键LT释放时")
        Me.btnJoyStickR.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JmpMnuItem, Me.ToolStripSeparator2, Me.AutoMnuItem, Me.LockMnuItem, Me.ToolStripMenuItem5, Me.ClearMnuItem})
        Me.btnMenu.Name = "ContextMenuStrip1"
        Me.btnMenu.Size = New System.Drawing.Size(101, 104)
        '
        'JmpMnuItem
        '
        Me.JmpMnuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JmpNMnuItem, Me.JmpAMnuItem, Me.JmpSMnuItem, Me.JmpCMnuItem})
        Me.JmpMnuItem.Name = "JmpMnuItem"
        Me.JmpMnuItem.Size = New System.Drawing.Size(100, 22)
        Me.JmpMnuItem.Text = "跳转"
        '
        'JmpNMnuItem
        '
        Me.JmpNMnuItem.Name = "JmpNMnuItem"
        Me.JmpNMnuItem.Size = New System.Drawing.Size(136, 22)
        Me.JmpNMnuItem.Text = "无跳转"
        '
        'JmpAMnuItem
        '
        Me.JmpAMnuItem.Name = "JmpAMnuItem"
        Me.JmpAMnuItem.Size = New System.Drawing.Size(136, 22)
        Me.JmpAMnuItem.Text = "单向跳转"
        '
        'JmpSMnuItem
        '
        Me.JmpSMnuItem.Name = "JmpSMnuItem"
        Me.JmpSMnuItem.Size = New System.Drawing.Size(136, 22)
        Me.JmpSMnuItem.Text = "按住切换"
        '
        'JmpCMnuItem
        '
        Me.JmpCMnuItem.Name = "JmpCMnuItem"
        Me.JmpCMnuItem.Size = New System.Drawing.Size(136, 22)
        Me.JmpCMnuItem.Text = "不跳页切换"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(97, 6)
        '
        'AutoMnuItem
        '
        Me.AutoMnuItem.CheckOnClick = True
        Me.AutoMnuItem.Name = "AutoMnuItem"
        Me.AutoMnuItem.Size = New System.Drawing.Size(100, 22)
        Me.AutoMnuItem.Text = "连发"
        '
        'LockMnuItem
        '
        Me.LockMnuItem.CheckOnClick = True
        Me.LockMnuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemindMnuItem})
        Me.LockMnuItem.Name = "LockMnuItem"
        Me.LockMnuItem.Size = New System.Drawing.Size(100, 22)
        Me.LockMnuItem.Text = "自锁"
        '
        'RemindMnuItem
        '
        Me.RemindMnuItem.CheckOnClick = True
        Me.RemindMnuItem.Name = "RemindMnuItem"
        Me.RemindMnuItem.Size = New System.Drawing.Size(124, 22)
        Me.RemindMnuItem.Text = "显示提醒"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(97, 6)
        '
        'ClearMnuItem
        '
        Me.ClearMnuItem.Name = "ClearMnuItem"
        Me.ClearMnuItem.Size = New System.Drawing.Size(100, 22)
        Me.ClearMnuItem.Text = "清除"
        '
        'btnJoyStickL
        '
        Me.btnJoyStickL.AntiAlias = False
        Me.btnJoyStickL.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStickL.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStickL.FlatAppearance.BorderSize = 0
        Me.btnJoyStickL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStickL.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStickL.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStickL.Location = New System.Drawing.Point(201, 11)
        Me.btnJoyStickL.Name = "btnJoyStickL"
        Me.btnJoyStickL.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStickL.TabIndex = 66
        Me.btnJoyStickL.TagJump = Nothing
        Me.btnJoyStickL.TagLock = False
        Me.btnJoyStickL.Text = "cmbL"
        Me.btnJoyStickL.TextColor = System.Drawing.Color.Black
        Me.ToolTip1.SetToolTip(Me.btnJoyStickL, "组合键RT释放时")
        Me.btnJoyStickL.UseVisualStyleBackColor = False
        '
        'btnJoyStick25
        '
        Me.btnJoyStick25.AntiAlias = False
        Me.btnJoyStick25.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick25.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick25.FlatAppearance.BorderSize = 0
        Me.btnJoyStick25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick25.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick25.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick25.Location = New System.Drawing.Point(239, 11)
        Me.btnJoyStick25.Name = "btnJoyStick25"
        Me.btnJoyStick25.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick25.TabIndex = 65
        Me.btnJoyStick25.TagJump = Nothing
        Me.btnJoyStick25.TagLock = False
        Me.btnJoyStick25.Text = "cmb25"
        Me.btnJoyStick25.TextColor = System.Drawing.Color.Black
        Me.ToolTip1.SetToolTip(Me.btnJoyStick25, "LT+RT组合键")
        Me.btnJoyStick25.UseVisualStyleBackColor = False
        '
        'btnJoyStick1
        '
        Me.btnJoyStick1.AntiAlias = False
        Me.btnJoyStick1.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick1.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick1.FlatAppearance.BorderSize = 0
        Me.btnJoyStick1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick1.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick1.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick1.Location = New System.Drawing.Point(48, 89)
        Me.btnJoyStick1.Name = "btnJoyStick1"
        Me.btnJoyStick1.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick1.TabIndex = 1
        Me.btnJoyStick1.TagJump = Nothing
        Me.btnJoyStick1.TagLock = False
        Me.btnJoyStick1.Text = "Joy1"
        Me.btnJoyStick1.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick1.UseVisualStyleBackColor = False
        '
        'btnJoyStick5
        '
        Me.btnJoyStick5.AntiAlias = False
        Me.btnJoyStick5.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick5.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick5.FlatAppearance.BorderSize = 0
        Me.btnJoyStick5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick5.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick5.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick5.Location = New System.Drawing.Point(86, 89)
        Me.btnJoyStick5.Name = "btnJoyStick5"
        Me.btnJoyStick5.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick5.TabIndex = 5
        Me.btnJoyStick5.TagJump = Nothing
        Me.btnJoyStick5.TagLock = False
        Me.btnJoyStick5.Text = "Joy5"
        Me.btnJoyStick5.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick5.UseVisualStyleBackColor = False
        '
        'btnJoyStick4
        '
        Me.btnJoyStick4.AntiAlias = False
        Me.btnJoyStick4.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick4.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick4.FlatAppearance.BorderSize = 0
        Me.btnJoyStick4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick4.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick4.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick4.Location = New System.Drawing.Point(86, 51)
        Me.btnJoyStick4.Name = "btnJoyStick4"
        Me.btnJoyStick4.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick4.TabIndex = 4
        Me.btnJoyStick4.TagJump = Nothing
        Me.btnJoyStick4.TagLock = False
        Me.btnJoyStick4.Text = "Joy4"
        Me.btnJoyStick4.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick4.UseVisualStyleBackColor = False
        '
        'btnJoyStick3
        '
        Me.btnJoyStick3.AntiAlias = False
        Me.btnJoyStick3.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick3.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick3.FlatAppearance.BorderSize = 0
        Me.btnJoyStick3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick3.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick3.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick3.Location = New System.Drawing.Point(86, 127)
        Me.btnJoyStick3.Name = "btnJoyStick3"
        Me.btnJoyStick3.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick3.TabIndex = 3
        Me.btnJoyStick3.TagJump = Nothing
        Me.btnJoyStick3.TagLock = False
        Me.btnJoyStick3.Text = "Joy3"
        Me.btnJoyStick3.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick3.UseVisualStyleBackColor = False
        '
        'btnJoyStick2
        '
        Me.btnJoyStick2.AntiAlias = False
        Me.btnJoyStick2.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick2.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick2.FlatAppearance.BorderSize = 0
        Me.btnJoyStick2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick2.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick2.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick2.Location = New System.Drawing.Point(124, 89)
        Me.btnJoyStick2.Name = "btnJoyStick2"
        Me.btnJoyStick2.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick2.TabIndex = 2
        Me.btnJoyStick2.TagJump = Nothing
        Me.btnJoyStick2.TagLock = False
        Me.btnJoyStick2.Text = "Joy2"
        Me.btnJoyStick2.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick2.UseVisualStyleBackColor = False
        '
        'btnJoyStick14
        '
        Me.btnJoyStick14.AntiAlias = False
        Me.btnJoyStick14.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick14.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick14.FlatAppearance.BorderSize = 0
        Me.btnJoyStick14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick14.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick14.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick14.Location = New System.Drawing.Point(275, 179)
        Me.btnJoyStick14.Name = "btnJoyStick14"
        Me.btnJoyStick14.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick14.TabIndex = 14
        Me.btnJoyStick14.TagJump = Nothing
        Me.btnJoyStick14.TagLock = False
        Me.btnJoyStick14.Text = "Joy14"
        Me.btnJoyStick14.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick14.UseVisualStyleBackColor = False
        '
        'btnJoyStick18
        '
        Me.btnJoyStick18.AntiAlias = False
        Me.btnJoyStick18.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick18.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick18.FlatAppearance.BorderSize = 0
        Me.btnJoyStick18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick18.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick18.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick18.Location = New System.Drawing.Point(313, 179)
        Me.btnJoyStick18.Name = "btnJoyStick18"
        Me.btnJoyStick18.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick18.TabIndex = 18
        Me.btnJoyStick18.TagJump = Nothing
        Me.btnJoyStick18.TagLock = False
        Me.btnJoyStick18.Text = "Joy18"
        Me.btnJoyStick18.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick18.UseVisualStyleBackColor = False
        '
        'btnJoyStick17
        '
        Me.btnJoyStick17.AntiAlias = False
        Me.btnJoyStick17.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick17.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick17.FlatAppearance.BorderSize = 0
        Me.btnJoyStick17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick17.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick17.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick17.Location = New System.Drawing.Point(313, 141)
        Me.btnJoyStick17.Name = "btnJoyStick17"
        Me.btnJoyStick17.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick17.TabIndex = 17
        Me.btnJoyStick17.TagJump = Nothing
        Me.btnJoyStick17.TagLock = False
        Me.btnJoyStick17.Text = "Joy17"
        Me.btnJoyStick17.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick17.UseVisualStyleBackColor = False
        '
        'btnJoyStick16
        '
        Me.btnJoyStick16.AntiAlias = False
        Me.btnJoyStick16.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick16.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick16.FlatAppearance.BorderSize = 0
        Me.btnJoyStick16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick16.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick16.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick16.Location = New System.Drawing.Point(313, 217)
        Me.btnJoyStick16.Name = "btnJoyStick16"
        Me.btnJoyStick16.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick16.TabIndex = 16
        Me.btnJoyStick16.TagJump = Nothing
        Me.btnJoyStick16.TagLock = False
        Me.btnJoyStick16.Text = "Joy16"
        Me.btnJoyStick16.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick16.UseVisualStyleBackColor = False
        '
        'btnJoyStick15
        '
        Me.btnJoyStick15.AntiAlias = False
        Me.btnJoyStick15.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick15.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick15.FlatAppearance.BorderSize = 0
        Me.btnJoyStick15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick15.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick15.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick15.Location = New System.Drawing.Point(351, 179)
        Me.btnJoyStick15.Name = "btnJoyStick15"
        Me.btnJoyStick15.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick15.TabIndex = 15
        Me.btnJoyStick15.TagJump = Nothing
        Me.btnJoyStick15.TagLock = False
        Me.btnJoyStick15.Text = "Joy15"
        Me.btnJoyStick15.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick15.UseVisualStyleBackColor = False
        '
        'btnJoyStick10
        '
        Me.btnJoyStick10.AntiAlias = False
        Me.btnJoyStick10.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick10.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick10.FlatAppearance.BorderSize = 0
        Me.btnJoyStick10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick10.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick10.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick10.Location = New System.Drawing.Point(122, 179)
        Me.btnJoyStick10.Name = "btnJoyStick10"
        Me.btnJoyStick10.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick10.TabIndex = 10
        Me.btnJoyStick10.TagJump = Nothing
        Me.btnJoyStick10.TagLock = False
        Me.btnJoyStick10.Text = "Joy10"
        Me.btnJoyStick10.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick10.UseVisualStyleBackColor = False
        '
        'btnJoyStick13
        '
        Me.btnJoyStick13.AntiAlias = False
        Me.btnJoyStick13.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick13.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick13.FlatAppearance.BorderSize = 0
        Me.btnJoyStick13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick13.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick13.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick13.Location = New System.Drawing.Point(160, 141)
        Me.btnJoyStick13.Name = "btnJoyStick13"
        Me.btnJoyStick13.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick13.TabIndex = 13
        Me.btnJoyStick13.TagJump = Nothing
        Me.btnJoyStick13.TagLock = False
        Me.btnJoyStick13.Text = "Joy13"
        Me.btnJoyStick13.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick13.UseVisualStyleBackColor = False
        '
        'btnJoyStick12
        '
        Me.btnJoyStick12.AntiAlias = False
        Me.btnJoyStick12.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick12.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick12.FlatAppearance.BorderSize = 0
        Me.btnJoyStick12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick12.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick12.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick12.Location = New System.Drawing.Point(160, 217)
        Me.btnJoyStick12.Name = "btnJoyStick12"
        Me.btnJoyStick12.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick12.TabIndex = 12
        Me.btnJoyStick12.TagJump = Nothing
        Me.btnJoyStick12.TagLock = False
        Me.btnJoyStick12.Text = "Joy12"
        Me.btnJoyStick12.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick12.UseVisualStyleBackColor = False
        '
        'btnJoyStick11
        '
        Me.btnJoyStick11.AntiAlias = False
        Me.btnJoyStick11.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick11.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick11.FlatAppearance.BorderSize = 0
        Me.btnJoyStick11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick11.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick11.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick11.Location = New System.Drawing.Point(198, 179)
        Me.btnJoyStick11.Name = "btnJoyStick11"
        Me.btnJoyStick11.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick11.TabIndex = 11
        Me.btnJoyStick11.TagJump = Nothing
        Me.btnJoyStick11.TagLock = False
        Me.btnJoyStick11.Text = "Joy11"
        Me.btnJoyStick11.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick11.UseVisualStyleBackColor = False
        '
        'btnJoyStick6
        '
        Me.btnJoyStick6.AntiAlias = False
        Me.btnJoyStick6.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick6.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick6.FlatAppearance.BorderSize = 0
        Me.btnJoyStick6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick6.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick6.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick6.Location = New System.Drawing.Point(353, 89)
        Me.btnJoyStick6.Name = "btnJoyStick6"
        Me.btnJoyStick6.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick6.TabIndex = 6
        Me.btnJoyStick6.TagJump = Nothing
        Me.btnJoyStick6.TagLock = False
        Me.btnJoyStick6.Text = "Joy6"
        Me.btnJoyStick6.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick6.UseVisualStyleBackColor = False
        '
        'btnJoyStick9
        '
        Me.btnJoyStick9.AntiAlias = False
        Me.btnJoyStick9.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick9.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick9.FlatAppearance.BorderSize = 0
        Me.btnJoyStick9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick9.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick9.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick9.Location = New System.Drawing.Point(391, 51)
        Me.btnJoyStick9.Name = "btnJoyStick9"
        Me.btnJoyStick9.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick9.TabIndex = 9
        Me.btnJoyStick9.TagJump = Nothing
        Me.btnJoyStick9.TagLock = False
        Me.btnJoyStick9.Text = "Joy9"
        Me.btnJoyStick9.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick9.UseVisualStyleBackColor = False
        '
        'btnJoyStick8
        '
        Me.btnJoyStick8.AntiAlias = False
        Me.btnJoyStick8.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick8.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick8.FlatAppearance.BorderSize = 0
        Me.btnJoyStick8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick8.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick8.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick8.Location = New System.Drawing.Point(391, 127)
        Me.btnJoyStick8.Name = "btnJoyStick8"
        Me.btnJoyStick8.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick8.TabIndex = 8
        Me.btnJoyStick8.TagJump = Nothing
        Me.btnJoyStick8.TagLock = False
        Me.btnJoyStick8.Text = "Joy8"
        Me.btnJoyStick8.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick8.UseVisualStyleBackColor = False
        '
        'btnJoyStick7
        '
        Me.btnJoyStick7.AntiAlias = False
        Me.btnJoyStick7.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick7.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick7.FlatAppearance.BorderSize = 0
        Me.btnJoyStick7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick7.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick7.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick7.Location = New System.Drawing.Point(429, 89)
        Me.btnJoyStick7.Name = "btnJoyStick7"
        Me.btnJoyStick7.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick7.TabIndex = 7
        Me.btnJoyStick7.TagJump = Nothing
        Me.btnJoyStick7.TagLock = False
        Me.btnJoyStick7.Text = "Joy7"
        Me.btnJoyStick7.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick7.UseVisualStyleBackColor = False
        '
        'btnJoyStick24
        '
        Me.btnJoyStick24.AntiAlias = False
        Me.btnJoyStick24.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick24.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick24.FlatAppearance.BorderSize = 0
        Me.btnJoyStick24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick24.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick24.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick24.Location = New System.Drawing.Point(299, 95)
        Me.btnJoyStick24.Name = "btnJoyStick24"
        Me.btnJoyStick24.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick24.TabIndex = 24
        Me.btnJoyStick24.TagJump = Nothing
        Me.btnJoyStick24.TagLock = False
        Me.btnJoyStick24.Text = "Joy24"
        Me.btnJoyStick24.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick24.UseVisualStyleBackColor = False
        '
        'btnJoyStick23
        '
        Me.btnJoyStick23.AntiAlias = False
        Me.btnJoyStick23.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick23.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick23.FlatAppearance.BorderSize = 0
        Me.btnJoyStick23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick23.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick23.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick23.Location = New System.Drawing.Point(186, 95)
        Me.btnJoyStick23.Name = "btnJoyStick23"
        Me.btnJoyStick23.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick23.TabIndex = 23
        Me.btnJoyStick23.TagJump = Nothing
        Me.btnJoyStick23.TagLock = False
        Me.btnJoyStick23.Text = "Joy23"
        Me.btnJoyStick23.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick23.UseVisualStyleBackColor = False
        '
        'btnJoyStick22
        '
        Me.btnJoyStick22.AntiAlias = False
        Me.btnJoyStick22.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick22.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick22.FlatAppearance.BorderSize = 0
        Me.btnJoyStick22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick22.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick22.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick22.Location = New System.Drawing.Point(470, 11)
        Me.btnJoyStick22.Name = "btnJoyStick22"
        Me.btnJoyStick22.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick22.TabIndex = 22
        Me.btnJoyStick22.TagJump = Nothing
        Me.btnJoyStick22.TagLock = False
        Me.btnJoyStick22.Text = "Joy22"
        Me.btnJoyStick22.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick22.UseVisualStyleBackColor = False
        '
        'btnJoyStick21
        '
        Me.btnJoyStick21.AntiAlias = False
        Me.btnJoyStick21.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick21.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick21.FlatAppearance.BorderSize = 0
        Me.btnJoyStick21.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick21.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick21.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick21.Location = New System.Drawing.Point(6, 11)
        Me.btnJoyStick21.Name = "btnJoyStick21"
        Me.btnJoyStick21.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick21.TabIndex = 21
        Me.btnJoyStick21.TagJump = Nothing
        Me.btnJoyStick21.TagLock = False
        Me.btnJoyStick21.Text = "Joy21"
        Me.btnJoyStick21.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick21.UseVisualStyleBackColor = False
        '
        'btnJoyStick20
        '
        Me.btnJoyStick20.AntiAlias = False
        Me.btnJoyStick20.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick20.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick20.FlatAppearance.BorderSize = 0
        Me.btnJoyStick20.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick20.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick20.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick20.Location = New System.Drawing.Point(385, 5)
        Me.btnJoyStick20.Name = "btnJoyStick20"
        Me.btnJoyStick20.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick20.TabIndex = 20
        Me.btnJoyStick20.TagJump = Nothing
        Me.btnJoyStick20.TagLock = False
        Me.btnJoyStick20.Text = "Joy20"
        Me.btnJoyStick20.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick20.UseVisualStyleBackColor = False
        '
        'btnJoyStick19
        '
        Me.btnJoyStick19.AntiAlias = False
        Me.btnJoyStick19.BackColor = System.Drawing.Color.Transparent
        Me.btnJoyStick19.ContextMenuStrip = Me.btnMenu
        Me.btnJoyStick19.FlatAppearance.BorderSize = 0
        Me.btnJoyStick19.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJoyStick19.Font = New System.Drawing.Font("Calibri", 8.0!)
        Me.btnJoyStick19.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJoyStick19.Location = New System.Drawing.Point(91, 5)
        Me.btnJoyStick19.Name = "btnJoyStick19"
        Me.btnJoyStick19.Size = New System.Drawing.Size(36, 36)
        Me.btnJoyStick19.TabIndex = 19
        Me.btnJoyStick19.TagJump = Nothing
        Me.btnJoyStick19.TagLock = False
        Me.btnJoyStick19.Text = "Joy19"
        Me.btnJoyStick19.TextColor = System.Drawing.Color.Black
        Me.btnJoyStick19.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(514, 254)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'DeviceBox1
        '
        Me.DeviceBox1.BackColor = System.Drawing.SystemColors.Control
        Me.DeviceBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DeviceBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DeviceBox1.Enabled = False
        Me.DeviceBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.DeviceBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeviceBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.DeviceBox1.FormattingEnabled = True
        Me.DeviceBox1.ItemHeight = 14
        Me.DeviceBox1.Location = New System.Drawing.Point(3, 3)
        Me.DeviceBox1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.DeviceBox1.Name = "DeviceBox1"
        Me.DeviceBox1.Size = New System.Drawing.Size(200, 22)
        Me.DeviceBox1.TabIndex = 41
        '
        'pageMenu
        '
        Me.pageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.复制页ToolStripMenuItem, Me.清除页ToolStripMenuItem})
        Me.pageMenu.Name = "ContextMenuStrip2"
        Me.pageMenu.Size = New System.Drawing.Size(113, 48)
        '
        '复制页ToolStripMenuItem
        '
        Me.复制页ToolStripMenuItem.Name = "复制页ToolStripMenuItem"
        Me.复制页ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.复制页ToolStripMenuItem.Text = "复制页"
        '
        '清除页ToolStripMenuItem
        '
        Me.清除页ToolStripMenuItem.Name = "清除页ToolStripMenuItem"
        Me.清除页ToolStripMenuItem.Size = New System.Drawing.Size(112, 22)
        Me.清除页ToolStripMenuItem.Text = "清除页"
        '
        'ConfigBox1
        '
        Me.ConfigBox1.BackColor = System.Drawing.SystemColors.Control
        Me.ConfigBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ConfigBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ConfigBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ConfigBox1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfigBox1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ConfigBox1.FormattingEnabled = True
        Me.ConfigBox1.ItemHeight = 14
        Me.ConfigBox1.Location = New System.Drawing.Point(244, 3)
        Me.ConfigBox1.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.ConfigBox1.Name = "ConfigBox1"
        Me.ConfigBox1.Size = New System.Drawing.Size(200, 22)
        Me.ConfigBox1.TabIndex = 47
        '
        'profileMenu
        '
        Me.profileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.保存配置ToolStripMenuItem, Me.重命名ToolStripMenuItem, Me.另存为ToolStripMenuItem, Me.ToolStripMenuItem4, Me.添加配置ToolStripMenuItem, Me.删除配置ToolStripMenuItem, Me.ToolStripMenuItem6, Me.打开配置文件夹ToolStripMenuItem})
        Me.profileMenu.Name = "profileMenu"
        Me.profileMenu.Size = New System.Drawing.Size(137, 148)
        '
        '保存配置ToolStripMenuItem
        '
        Me.保存配置ToolStripMenuItem.Name = "保存配置ToolStripMenuItem"
        Me.保存配置ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.保存配置ToolStripMenuItem.Text = "保存配置"
        '
        '重命名ToolStripMenuItem
        '
        Me.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem"
        Me.重命名ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.重命名ToolStripMenuItem.Text = "重命名"
        '
        '另存为ToolStripMenuItem
        '
        Me.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem"
        Me.另存为ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.另存为ToolStripMenuItem.Text = "另存为..."
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(133, 6)
        '
        '添加配置ToolStripMenuItem
        '
        Me.添加配置ToolStripMenuItem.Name = "添加配置ToolStripMenuItem"
        Me.添加配置ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.添加配置ToolStripMenuItem.Text = "添加配置"
        '
        '删除配置ToolStripMenuItem
        '
        Me.删除配置ToolStripMenuItem.Name = "删除配置ToolStripMenuItem"
        Me.删除配置ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.删除配置ToolStripMenuItem.Text = "删除配置"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(133, 6)
        '
        '打开配置文件夹ToolStripMenuItem
        '
        Me.打开配置文件夹ToolStripMenuItem.Name = "打开配置文件夹ToolStripMenuItem"
        Me.打开配置文件夹ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.打开配置文件夹ToolStripMenuItem.Text = "配置文件夹"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3000
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 1000
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "提示"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.NotifyMenu
        Me.NotifyIcon1.Visible = True
        '
        'NotifyMenu
        '
        Me.NotifyMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.打开主窗口ToolStripMenuItem, Me.退出ToolStripMenuItem1})
        Me.NotifyMenu.Name = "NotifyMenuStrip1"
        Me.NotifyMenu.Size = New System.Drawing.Size(137, 48)
        '
        '打开主窗口ToolStripMenuItem
        '
        Me.打开主窗口ToolStripMenuItem.Name = "打开主窗口ToolStripMenuItem"
        Me.打开主窗口ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.打开主窗口ToolStripMenuItem.Text = "打开主窗口"
        '
        '退出ToolStripMenuItem1
        '
        Me.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1"
        Me.退出ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.退出ToolStripMenuItem1.Text = "退出"
        '
        'jobMenu
        '
        Me.jobMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.通用, Me.ToolStripMenuItem11, Me.AddJobMnuItem, Me.AutoSwitchMnuItem})
        Me.jobMenu.Name = "jobMenu"
        Me.jobMenu.Size = New System.Drawing.Size(125, 76)
        '
        '通用
        '
        Me.通用.Image = CType(resources.GetObject("通用.Image"), System.Drawing.Image)
        Me.通用.Name = "通用"
        Me.通用.Size = New System.Drawing.Size(124, 22)
        Me.通用.Text = "通用"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(121, 6)
        '
        'AddJobMnuItem
        '
        Me.AddJobMnuItem.BackColor = System.Drawing.SystemColors.Control
        Me.AddJobMnuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.骑士MenuItem, Me.战士MenuItem, Me.黑骑MenuItem, Me.ToolStripMenuItem7, Me.白魔MenuItem, Me.学者MenuItem, Me.占星MenuItem, Me.ToolStripMenuItem8, Me.武僧MenuItem, Me.龙骑MenuItem, Me.忍者MenuItem, Me.ToolStripMenuItem9, Me.诗人MenuItem, Me.机工MenuItem, Me.ToolStripMenuItem10, Me.黑魔MenuItem, Me.召唤MenuItem})
        Me.AddJobMnuItem.Name = "AddJobMnuItem"
        Me.AddJobMnuItem.ShowShortcutKeys = False
        Me.AddJobMnuItem.Size = New System.Drawing.Size(124, 22)
        Me.AddJobMnuItem.Text = "+职业"
        '
        '骑士MenuItem
        '
        Me.骑士MenuItem.Image = CType(resources.GetObject("骑士MenuItem.Image"), System.Drawing.Image)
        Me.骑士MenuItem.Name = "骑士MenuItem"
        Me.骑士MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.骑士MenuItem.Text = "骑士"
        '
        '战士MenuItem
        '
        Me.战士MenuItem.Image = CType(resources.GetObject("战士MenuItem.Image"), System.Drawing.Image)
        Me.战士MenuItem.Name = "战士MenuItem"
        Me.战士MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.战士MenuItem.Text = "战士"
        '
        '黑骑MenuItem
        '
        Me.黑骑MenuItem.Image = CType(resources.GetObject("黑骑MenuItem.Image"), System.Drawing.Image)
        Me.黑骑MenuItem.Name = "黑骑MenuItem"
        Me.黑骑MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.黑骑MenuItem.Text = "黑骑"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(97, 6)
        '
        '白魔MenuItem
        '
        Me.白魔MenuItem.Image = CType(resources.GetObject("白魔MenuItem.Image"), System.Drawing.Image)
        Me.白魔MenuItem.Name = "白魔MenuItem"
        Me.白魔MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.白魔MenuItem.Text = "白魔"
        '
        '学者MenuItem
        '
        Me.学者MenuItem.Image = CType(resources.GetObject("学者MenuItem.Image"), System.Drawing.Image)
        Me.学者MenuItem.Name = "学者MenuItem"
        Me.学者MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.学者MenuItem.Text = "学者"
        '
        '占星MenuItem
        '
        Me.占星MenuItem.Image = CType(resources.GetObject("占星MenuItem.Image"), System.Drawing.Image)
        Me.占星MenuItem.Name = "占星MenuItem"
        Me.占星MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.占星MenuItem.Text = "占星"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(97, 6)
        '
        '武僧MenuItem
        '
        Me.武僧MenuItem.Image = CType(resources.GetObject("武僧MenuItem.Image"), System.Drawing.Image)
        Me.武僧MenuItem.Name = "武僧MenuItem"
        Me.武僧MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.武僧MenuItem.Text = "武僧"
        '
        '龙骑MenuItem
        '
        Me.龙骑MenuItem.Image = CType(resources.GetObject("龙骑MenuItem.Image"), System.Drawing.Image)
        Me.龙骑MenuItem.Name = "龙骑MenuItem"
        Me.龙骑MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.龙骑MenuItem.Text = "龙骑"
        '
        '忍者MenuItem
        '
        Me.忍者MenuItem.Image = CType(resources.GetObject("忍者MenuItem.Image"), System.Drawing.Image)
        Me.忍者MenuItem.Name = "忍者MenuItem"
        Me.忍者MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.忍者MenuItem.Text = "忍者"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(97, 6)
        '
        '诗人MenuItem
        '
        Me.诗人MenuItem.Image = CType(resources.GetObject("诗人MenuItem.Image"), System.Drawing.Image)
        Me.诗人MenuItem.Name = "诗人MenuItem"
        Me.诗人MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.诗人MenuItem.Text = "诗人"
        '
        '机工MenuItem
        '
        Me.机工MenuItem.Image = CType(resources.GetObject("机工MenuItem.Image"), System.Drawing.Image)
        Me.机工MenuItem.Name = "机工MenuItem"
        Me.机工MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.机工MenuItem.Text = "机工"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(97, 6)
        '
        '黑魔MenuItem
        '
        Me.黑魔MenuItem.Image = CType(resources.GetObject("黑魔MenuItem.Image"), System.Drawing.Image)
        Me.黑魔MenuItem.Name = "黑魔MenuItem"
        Me.黑魔MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.黑魔MenuItem.Text = "黑魔"
        '
        '召唤MenuItem
        '
        Me.召唤MenuItem.Image = CType(resources.GetObject("召唤MenuItem.Image"), System.Drawing.Image)
        Me.召唤MenuItem.Name = "召唤MenuItem"
        Me.召唤MenuItem.Size = New System.Drawing.Size(100, 22)
        Me.召唤MenuItem.Text = "召唤"
        '
        'AutoSwitchMnuItem
        '
        Me.AutoSwitchMnuItem.CheckOnClick = True
        Me.AutoSwitchMnuItem.Name = "AutoSwitchMnuItem"
        Me.AutoSwitchMnuItem.Size = New System.Drawing.Size(124, 22)
        Me.AutoSwitchMnuItem.Text = "自动切换"
        '
        'TimerScanMemory
        '
        Me.TimerScanMemory.Interval = 1000
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelPage, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.Padding = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(538, 316)
        Me.TableLayoutPanel1.TabIndex = 51
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.DeviceBox1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnConfig, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.ConfigBox1, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnJob, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnProfile, 5, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(522, 26)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'btnConfig
        '
        Me.btnConfig.AntiAlias = False
        Me.btnConfig.BackColor = System.Drawing.Color.Transparent
        Me.btnConfig.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnConfig.FlatAppearance.BorderSize = 0
        Me.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfig.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnConfig.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnConfig.Location = New System.Drawing.Point(206, 3)
        Me.btnConfig.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(22, 22)
        Me.btnConfig.TabIndex = 46
        Me.btnConfig.TagJump = Nothing
        Me.btnConfig.TagLock = False
        Me.btnConfig.Text = "i"
        Me.btnConfig.TextColor = System.Drawing.Color.Black
        Me.btnConfig.UseVisualStyleBackColor = False
        '
        'btnJob
        '
        Me.btnJob.AntiAlias = False
        Me.btnJob.BackColor = System.Drawing.Color.Transparent
        Me.btnJob.ContextMenuStrip = Me.jobMenu
        Me.btnJob.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnJob.FlatAppearance.BorderSize = 0
        Me.btnJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJob.Font = New System.Drawing.Font("新宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnJob.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnJob.Location = New System.Drawing.Point(448, 3)
        Me.btnJob.Margin = New System.Windows.Forms.Padding(4, 3, 1, 1)
        Me.btnJob.Name = "btnJob"
        Me.btnJob.Size = New System.Drawing.Size(45, 22)
        Me.btnJob.TabIndex = 50
        Me.btnJob.TagJump = Nothing
        Me.btnJob.TagLock = False
        Me.btnJob.Text = "通用"
        Me.btnJob.TextColor = System.Drawing.Color.Black
        Me.btnJob.UseVisualStyleBackColor = False
        '
        'btnProfile
        '
        Me.btnProfile.AntiAlias = False
        Me.btnProfile.BackColor = System.Drawing.Color.Transparent
        Me.btnProfile.ContextMenuStrip = Me.profileMenu
        Me.btnProfile.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Font = New System.Drawing.Font("Webdings", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnProfile.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnProfile.Location = New System.Drawing.Point(497, 3)
        Me.btnProfile.Margin = New System.Windows.Forms.Padding(3, 3, 3, 1)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(22, 22)
        Me.btnProfile.TabIndex = 48
        Me.btnProfile.TagJump = Nothing
        Me.btnProfile.TagLock = False
        Me.btnProfile.Text = ""
        Me.btnProfile.TextColor = System.Drawing.Color.Black
        Me.btnProfile.UseVisualStyleBackColor = False
        '
        'PanelPage
        '
        Me.PanelPage.ColumnCount = 8
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5!))
        Me.PanelPage.Controls.Add(Me.btnPage8, 7, 0)
        Me.PanelPage.Controls.Add(Me.btnPage1, 0, 0)
        Me.PanelPage.Controls.Add(Me.btnPage7, 6, 0)
        Me.PanelPage.Controls.Add(Me.btnPage2, 1, 0)
        Me.PanelPage.Controls.Add(Me.btnPage6, 5, 0)
        Me.PanelPage.Controls.Add(Me.btnPage3, 2, 0)
        Me.PanelPage.Controls.Add(Me.btnPage5, 4, 0)
        Me.PanelPage.Controls.Add(Me.btnPage4, 3, 0)
        Me.PanelPage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPage.Location = New System.Drawing.Point(8, 286)
        Me.PanelPage.Margin = New System.Windows.Forms.Padding(0)
        Me.PanelPage.Name = "PanelPage"
        Me.PanelPage.Padding = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.PanelPage.RowCount = 1
        Me.PanelPage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PanelPage.Size = New System.Drawing.Size(522, 30)
        Me.PanelPage.TabIndex = 41
        '
        'btnPage8
        '
        Me.btnPage8.AntiAlias = False
        Me.btnPage8.BackColor = System.Drawing.Color.Transparent
        Me.btnPage8.CheckBox = True
        Me.btnPage8.ContextMenuStrip = Me.pageMenu
        Me.btnPage8.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage8.FlatAppearance.BorderSize = 0
        Me.btnPage8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage8.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage8.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage8.Location = New System.Drawing.Point(451, 3)
        Me.btnPage8.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage8.Name = "btnPage8"
        Me.btnPage8.Size = New System.Drawing.Size(68, 22)
        Me.btnPage8.TabIndex = 52
        Me.btnPage8.Tag = "8"
        Me.btnPage8.TagJump = Nothing
        Me.btnPage8.TagLock = False
        Me.btnPage8.Text = "8"
        Me.btnPage8.TextColor = System.Drawing.Color.Black
        Me.btnPage8.UseVisualStyleBackColor = False
        '
        'btnPage1
        '
        Me.btnPage1.AntiAlias = False
        Me.btnPage1.BackColor = System.Drawing.Color.Transparent
        Me.btnPage1.CheckBox = True
        Me.btnPage1.ContextMenuStrip = Me.pageMenu
        Me.btnPage1.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage1.FlatAppearance.BorderSize = 0
        Me.btnPage1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage1.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage1.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage1.Location = New System.Drawing.Point(3, 3)
        Me.btnPage1.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage1.Name = "btnPage1"
        Me.btnPage1.Size = New System.Drawing.Size(64, 22)
        Me.btnPage1.TabIndex = 46
        Me.btnPage1.Tag = "1"
        Me.btnPage1.TagJump = Nothing
        Me.btnPage1.TagLock = False
        Me.btnPage1.Text = "1"
        Me.btnPage1.TextColor = System.Drawing.Color.Black
        Me.btnPage1.UseVisualStyleBackColor = False
        '
        'btnPage7
        '
        Me.btnPage7.AntiAlias = False
        Me.btnPage7.BackColor = System.Drawing.Color.Transparent
        Me.btnPage7.CheckBox = True
        Me.btnPage7.ContextMenuStrip = Me.pageMenu
        Me.btnPage7.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage7.FlatAppearance.BorderSize = 0
        Me.btnPage7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage7.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage7.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage7.Location = New System.Drawing.Point(387, 3)
        Me.btnPage7.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage7.Name = "btnPage7"
        Me.btnPage7.Size = New System.Drawing.Size(64, 22)
        Me.btnPage7.TabIndex = 53
        Me.btnPage7.Tag = "7"
        Me.btnPage7.TagJump = Nothing
        Me.btnPage7.TagLock = False
        Me.btnPage7.Text = "7"
        Me.btnPage7.TextColor = System.Drawing.Color.Black
        Me.btnPage7.UseVisualStyleBackColor = False
        '
        'btnPage2
        '
        Me.btnPage2.AntiAlias = False
        Me.btnPage2.BackColor = System.Drawing.Color.Transparent
        Me.btnPage2.CheckBox = True
        Me.btnPage2.ContextMenuStrip = Me.pageMenu
        Me.btnPage2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage2.FlatAppearance.BorderSize = 0
        Me.btnPage2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage2.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage2.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage2.Location = New System.Drawing.Point(67, 3)
        Me.btnPage2.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage2.Name = "btnPage2"
        Me.btnPage2.Size = New System.Drawing.Size(64, 22)
        Me.btnPage2.TabIndex = 47
        Me.btnPage2.Tag = "2"
        Me.btnPage2.TagJump = Nothing
        Me.btnPage2.TagLock = False
        Me.btnPage2.Text = "2"
        Me.btnPage2.TextColor = System.Drawing.Color.Black
        Me.btnPage2.UseVisualStyleBackColor = False
        '
        'btnPage6
        '
        Me.btnPage6.AntiAlias = False
        Me.btnPage6.BackColor = System.Drawing.Color.Transparent
        Me.btnPage6.CheckBox = True
        Me.btnPage6.ContextMenuStrip = Me.pageMenu
        Me.btnPage6.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage6.FlatAppearance.BorderSize = 0
        Me.btnPage6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage6.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage6.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage6.Location = New System.Drawing.Point(323, 3)
        Me.btnPage6.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage6.Name = "btnPage6"
        Me.btnPage6.Size = New System.Drawing.Size(64, 22)
        Me.btnPage6.TabIndex = 51
        Me.btnPage6.Tag = "6"
        Me.btnPage6.TagJump = Nothing
        Me.btnPage6.TagLock = False
        Me.btnPage6.Text = "6"
        Me.btnPage6.TextColor = System.Drawing.Color.Black
        Me.btnPage6.UseVisualStyleBackColor = False
        '
        'btnPage3
        '
        Me.btnPage3.AntiAlias = False
        Me.btnPage3.BackColor = System.Drawing.Color.Transparent
        Me.btnPage3.CheckBox = True
        Me.btnPage3.ContextMenuStrip = Me.pageMenu
        Me.btnPage3.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage3.FlatAppearance.BorderSize = 0
        Me.btnPage3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage3.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage3.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage3.Location = New System.Drawing.Point(131, 3)
        Me.btnPage3.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage3.Name = "btnPage3"
        Me.btnPage3.Size = New System.Drawing.Size(64, 22)
        Me.btnPage3.TabIndex = 48
        Me.btnPage3.Tag = "3"
        Me.btnPage3.TagJump = Nothing
        Me.btnPage3.TagLock = False
        Me.btnPage3.Text = "3"
        Me.btnPage3.TextColor = System.Drawing.Color.Black
        Me.btnPage3.UseVisualStyleBackColor = False
        '
        'btnPage5
        '
        Me.btnPage5.AntiAlias = False
        Me.btnPage5.BackColor = System.Drawing.Color.Transparent
        Me.btnPage5.CheckBox = True
        Me.btnPage5.ContextMenuStrip = Me.pageMenu
        Me.btnPage5.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage5.FlatAppearance.BorderSize = 0
        Me.btnPage5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage5.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage5.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage5.Location = New System.Drawing.Point(259, 3)
        Me.btnPage5.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage5.Name = "btnPage5"
        Me.btnPage5.Size = New System.Drawing.Size(64, 22)
        Me.btnPage5.TabIndex = 50
        Me.btnPage5.Tag = "5"
        Me.btnPage5.TagJump = Nothing
        Me.btnPage5.TagLock = False
        Me.btnPage5.Text = "5"
        Me.btnPage5.TextColor = System.Drawing.Color.Black
        Me.btnPage5.UseVisualStyleBackColor = False
        '
        'btnPage4
        '
        Me.btnPage4.AntiAlias = False
        Me.btnPage4.BackColor = System.Drawing.Color.Transparent
        Me.btnPage4.CheckBox = True
        Me.btnPage4.ContextMenuStrip = Me.pageMenu
        Me.btnPage4.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPage4.FlatAppearance.BorderSize = 0
        Me.btnPage4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPage4.Font = New System.Drawing.Font("Calibri", 11.0!)
        Me.btnPage4.JumpMode = FFXiVJoy.iButton.jmpmode.None
        Me.btnPage4.Location = New System.Drawing.Point(195, 3)
        Me.btnPage4.Margin = New System.Windows.Forms.Padding(0, 3, 0, 3)
        Me.btnPage4.Name = "btnPage4"
        Me.btnPage4.Size = New System.Drawing.Size(64, 22)
        Me.btnPage4.TabIndex = 49
        Me.btnPage4.Tag = "4"
        Me.btnPage4.TagJump = Nothing
        Me.btnPage4.TagLock = False
        Me.btnPage4.Text = "4"
        Me.btnPage4.TextColor = System.Drawing.Color.Black
        Me.btnPage4.UseVisualStyleBackColor = False
        '
        'ToolTip2
        '
        Me.ToolTip2.AutoPopDelay = 3000
        Me.ToolTip2.InitialDelay = 500
        Me.ToolTip2.ReshowDelay = 100
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(538, 341)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuBar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuBar
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FFXiV手柄助手"
        Me.MenuBar.ResumeLayout(False)
        Me.MenuBar.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.btnMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pageMenu.ResumeLayout(False)
        Me.profileMenu.ResumeLayout(False)
        Me.NotifyMenu.ResumeLayout(False)
        Me.jobMenu.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.PanelPage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TimerXInput As System.Windows.Forms.Timer
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents MenuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents 配置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 简单帮助ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 关于ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnJoyStick1 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick5 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick4 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick3 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick2 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick14 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick18 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick17 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick16 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick15 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick10 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick13 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick12 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick11 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick6 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick9 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick8 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick7 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick24 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick23 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick22 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick21 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick20 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick19 As FFXiVJoy.iButton
    Friend WithEvents DeviceBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfig As FFXiVJoy.iButton
    Friend WithEvents btnMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents AutoMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LockMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pageMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 复制页ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 清除页ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JmpMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents JmpAMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JmpSMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfigBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents btnProfile As FFXiVJoy.iButton
    Friend WithEvents btnPage6 As FFXiVJoy.iButton
    Friend WithEvents btnPage5 As FFXiVJoy.iButton
    Friend WithEvents btnPage4 As FFXiVJoy.iButton
    Friend WithEvents btnPage3 As FFXiVJoy.iButton
    Friend WithEvents btnPage2 As FFXiVJoy.iButton
    Friend WithEvents btnPage1 As FFXiVJoy.iButton
    Friend WithEvents btnPage8 As FFXiVJoy.iButton
    Friend WithEvents btnPage7 As FFXiVJoy.iButton
    Friend WithEvents btnJoyStick25 As FFXiVJoy.iButton
    Friend WithEvents JmpNMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 置顶显示ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemindMnuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents profileMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 保存配置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 添加配置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 删除配置ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 另存为ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 重命名ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 打开配置文件夹ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents NotifyMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents 打开主窗口ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JmpCMnuItem As ToolStripMenuItem
    Friend WithEvents btnJob As iButton
    Friend WithEvents jobMenu As ContextMenuStrip
    Friend WithEvents 通用 As ToolStripMenuItem
    Friend WithEvents AddJobMnuItem As ToolStripMenuItem
    Friend WithEvents 骑士MenuItem As ToolStripMenuItem
    Friend WithEvents 战士MenuItem As ToolStripMenuItem
    Friend WithEvents 黑骑MenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripSeparator
    Friend WithEvents 白魔MenuItem As ToolStripMenuItem
    Friend WithEvents 学者MenuItem As ToolStripMenuItem
    Friend WithEvents 占星MenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripSeparator
    Friend WithEvents 武僧MenuItem As ToolStripMenuItem
    Friend WithEvents 龙骑MenuItem As ToolStripMenuItem
    Friend WithEvents 忍者MenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripSeparator
    Friend WithEvents 诗人MenuItem As ToolStripMenuItem
    Friend WithEvents 机工MenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripSeparator
    Friend WithEvents 黑魔MenuItem As ToolStripMenuItem
    Friend WithEvents 召唤MenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripSeparator
    Friend WithEvents TimerScanMemory As Timer
    Friend WithEvents AutoSwitchMnuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents PanelPage As TableLayoutPanel
    Friend WithEvents btnJoyStickR As iButton
    Friend WithEvents btnJoyStickL As iButton
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents ToolTip1 As ToolTip
End Class
