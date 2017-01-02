Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.ComponentModel

Public Class iButton
    Inherits System.Windows.Forms.Button

    ' 常量设置
    Private Class Consts
        Public Const DefaultHeight As Integer = 36
        Public Const DefaultWidth As Integer = 36
        Public Const DefaultFontName As String = "Calibri"
        Public Const DefaultFontSize As Integer = 11
        Public Const PosOffset As Integer = 0
    End Class
    Enum jmpmode
        None = 0
        OneWay = 1
        Switch = 2
        CopySwitch = 3
    End Enum
    Enum btnState
        Normal = 0
        Press = 1
    End Enum
    Private Structure GradientColor
        Dim highColor As Color
        Dim mediumColor As Color
        Dim lowColor As Color
    End Structure

    Public mFont As New Font("Calibri", 7)

    Private my_mouseDown As Boolean = False '鼠标按下
    Private my_mouseHover As Boolean = False '鼠标移到上面
    Private my_focus As Boolean = False '鼠标移到上面
    Private m_textcolor As Color = System.Drawing.Color.Black '字体颜色

    Private _aniFlag As Boolean = False
    Protected Overrides Sub InitLayout()
        Me.FlatAppearance.BorderSize = 0
        Me.FlatStyle = Windows.Forms.FlatStyle.Flat
        MyBase.InitLayout()
        'set back color   
        Me.BackColor = System.Drawing.Color.Transparent
    End Sub
    Public Sub New()
        MyBase.New()
        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        '在 InitializeComponent() 调用之后添加任何初始化,true表示将指定的样式应用到控件

        '设置控件样式位能够充分地更改控件行为
        'Me.SetStyle(ControlStyles.DoubleBuffer Or ControlStyles.UserPaint Or _
        'ControlStyles.AllPaintingInWmPaint Or ControlStyles.ResizeRedraw, True)

        '关联事件委托
        AddHandler Me.MouseDown, AddressOf my_OnMouseDown
        AddHandler Me.MouseUp, AddressOf my_OnMouseUp
        AddHandler Me.MouseEnter, AddressOf my_OnMouseEnter
        AddHandler Me.MouseLeave, AddressOf my_OnMouseLeave

        Height = Consts.DefaultHeight
        Width = Consts.DefaultWidth
        Font = New Font(Consts.DefaultFontName, Consts.DefaultFontSize)

        ReDraw()
    End Sub

#Region "PROPERTIES"
    ' 内部成员
    Private _tagJump As String
    Private _antiAlias As Boolean = False
    Private _spcALT As Boolean = False
    Private _spcCTRL As Boolean = False
    Private _spcSHIFT As Boolean = False
    Private _spcAutoFire As Boolean = False
    Private _spcAutoLock As Boolean = False
    Private _spcRemind As Boolean = False
    Private _spcJumpMode As jmpmode
    Private _aprState As btnState
    Private _tagLock As Boolean = False
    Private _checked As Boolean = False
    Private _checkbox As Boolean = False
    Private _state As Boolean = False

    Private _colorActiveText As Color = Color.Black
    Private _colorInactiveText As Color = Color.White

    Private _colorHigh As Color = Color.FromArgb(250, 250, 250)
    Private _colorMedium As Color = Color.FromArgb(240, 240, 240)
    Private _colorLow As Color = Color.FromArgb(160, 160, 160)

    Private _colorAniHigh As Color = Color.LawnGreen
    Private _colorAniMedium As Color = Color.LawnGreen
    Private _colorAniLow As Color = Color.ForestGreen
    ' 按钮文字颜色
    <Description("按钮文字颜色。")>
    Public Property TextColor() As Color
        Get
            Return m_textcolor
        End Get
        Set(ByVal Value As Color)
            m_textcolor = Value
            Me.Invalidate()
        End Set
    End Property

    ' 显示状态
    <Description("显示状态"),
     Category("Appearance"), DefaultValue(btnState.Normal)>
    Public ReadOnly Property ButtonState() As btnState
        Get
            Return _aprState
        End Get
    End Property

    ' 抗锯齿模式
    <Description("启用文字抗锯齿"),
     Category("Appearance"), DefaultValue(True)>
    Public Property AntiAlias() As Boolean
        Get
            Return _antiAlias
        End Get
        Set(ByVal value As Boolean)
            _antiAlias = value
            Invalidate()
        End Set
    End Property

    ' 附加跳转数据
    <Description("附加跳转数据"), _
     Category("Data")> _
    Public Property TagJump() As String
        Get
            Return _tagJump
        End Get
        Set(ByVal value As String)
            _tagJump = value
        End Set
    End Property

    ' 锁定状态
    <Description("锁定状态"), _
     Category("Data")> _
    Public Property TagLock() As Boolean
        Get
            Return _tagLock
        End Get
        Set(ByVal value As Boolean)
            _tagLock = value
        End Set
    End Property

    ' 检查框模式
    <Description("启用检查框按钮模式"), _
     Category("Behavior"), DefaultValue(False)> _
    Public Property CheckBox() As Boolean
        Get
            Return _checkbox
        End Get
        Set(ByVal value As Boolean)
            _checkbox = value
            Invalidate()
        End Set
    End Property

    ' 检查框模式
    <Description("检查框状态"), _
     Category("Behavior"), DefaultValue(False)> _
    Public Property Checked() As Boolean
        Get
            Return _checked
        End Get
        Set(ByVal value As Boolean)
            _checked = value
            Invalidate()
        End Set
    End Property

    ' ALT标志
    <Description("显示ALT标志"), _
     Category("Special"), DefaultValue(False)> _
    Public Property ALT() As Boolean
        Get
            Return _spcALT
        End Get
        Set(ByVal value As Boolean)
            _spcALT = value
            Invalidate()
        End Set
    End Property

    ' CTRL标志
    <Description("显示CTRL标志"), _
     Category("Special"), DefaultValue(False)> _
    Public Property CTRL() As Boolean
        Get
            Return _spcCTRL
        End Get
        Set(ByVal value As Boolean)
            _spcCTRL = value
            Invalidate()
        End Set
    End Property

    ' SHIFT标志
    <Description("显示SHIFT标志"), _
     Category("Special"), DefaultValue(False)> _
    Public Property SHIFT() As Boolean
        Get
            Return _spcSHIFT
        End Get
        Set(ByVal value As Boolean)
            _spcSHIFT = value
            Invalidate()
        End Set
    End Property

    ' 连发标志
    <Description("显示连发标志"), _
     Category("Special"), DefaultValue(False)> _
    Public Property AutoFire() As Boolean
        Get
            Return _spcAutoFire
        End Get
        Set(ByVal value As Boolean)
            _spcAutoFire = value
            Invalidate()
        End Set
    End Property

    ' 自动锁定标志
    <Description("显示自动锁定标志"),
     Category("Special"), DefaultValue(False)>
    Public Property AutoLock() As Boolean
        Get
            Return _spcAutoLock
        End Get
        Set(ByVal value As Boolean)
            _spcAutoLock = value
            If value Then
                _spcJumpMode = 0
            Else
                _tagLock = False
            End If
            Invalidate()
        End Set
    End Property

    ' 显示提醒标志
    <Description("显示提醒"),
     Category("Special"), DefaultValue(False)>
    Public Property Remind() As Boolean
        Get
            Return _spcRemind
        End Get
        Set(ByVal value As Boolean)
            _spcRemind = value
            If value Then
                _spcAutoLock = True
            End If
            Invalidate()
        End Set
    End Property

    ' 切换跳转标志
    <Description("跳转模式"), _
     Category("Special"), DefaultValue(jmpmode.OneWay)> _
    Public Property JumpMode() As jmpmode
        Get
            Return _spcJumpMode
        End Get
        Set(ByVal value As jmpmode)
            _spcJumpMode = value
            If value Then _spcAutoLock = False
            Invalidate()
        End Set
    End Property
#End Region

    Public Function AnimateDown()
        If (Enabled = True) And (_aniFlag = False) Then
            _aniFlag = True
            Invalidate()
        End If
        Return vbNull
    End Function
    Public Function AnimateUp()
        If (Enabled = True) And (_aniFlag = True) Then
            _aniFlag = False
            Invalidate()
        End If
        Return vbNull
    End Function
    Private Sub ReDraw()
        Dim path As New System.Drawing.Drawing2D.GraphicsPath
        Dim points() As Point = {New Point(0, 2), _
                                 New Point(2, 0), _
                                 New Point(Width - 2, 0), _
                                 New Point(Width, 2), _
                                 New Point(Width, Height - 3), _
                                 New Point(Width - 3, Height), _
                                 New Point(3, Height), _
                                 New Point(0, Height - 3), _
                                 New Point(0, 2)
                                 }

        path.AddLines(points)

        MyBase.Region = New Region(path)
    End Sub
    Protected Overrides Sub OnPaint(ByVal pevent As System.Windows.Forms.PaintEventArgs)
        '鼠标按下的状态处理
        If (Enabled = False) Then '画不可用状态
            DrawDisableButton(pevent.Graphics)
            _aprState = btnState.Normal
        ElseIf (_aniFlag) Then
            DrawAnimateButton(pevent.Graphics)
            _aprState = btnState.Press
        ElseIf (my_mouseDown) Then '画鼠标按下状态
            DrawMouseDownButton(pevent.Graphics)
            _aprState = btnState.Normal
        ElseIf (my_mouseHover) Then '画鼠标移动到其上状态
            DrawMouseHoverButton(pevent.Graphics)
            _aprState = btnState.Normal
        ElseIf (my_focus) Then '有焦点，但鼠标未移动到其上
            DrawContainFocusButton(pevent.Graphics)
            _aprState = btnState.Normal
        ElseIf (_checkbox) Then
            If (_checked) Then DrawMouseDownButton(pevent.Graphics) : _aprState = btnState.Press Else DrawNormalButton(pevent.Graphics) : _aprState = btnState.Normal
        Else '一般情况下
            DrawNormalButton(pevent.Graphics)
            _aprState = btnState.Normal
        End If
        '写文本
        WriteText(pevent.Graphics)
    End Sub
    Private Sub my_OnMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        my_mouseDown = True '鼠标按下
    End Sub
    '鼠标松开状态的处理
    Private Sub my_OnMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
        my_mouseDown = False '鼠标松开
        '重新绘制控件时发生 Paint 事件。PaintEventArgs 指定绘制控件所用的 Graphics
        '以及绘制控件所在的 ClipRectangle。
        Invalidate()
    End Sub
    '鼠标进入
    Private Sub my_OnMouseEnter(ByVal sender As Object, ByVal e As EventArgs)
        my_mouseHover = True '鼠标移动到其上
        '
        Invalidate()
    End Sub
    '鼠标移开
    Private Sub my_OnMouseLeave(ByVal sender As Object, ByVal e As EventArgs)
        my_mouseHover = False '鼠标移开
        '
        Invalidate()
    End Sub

    Private Sub DrawBorder(ByVal g As Graphics, ByVal state As Integer)
        Dim p As Pen = Pens.Black
        Dim path As New System.Drawing.Drawing2D.GraphicsPath
        Dim points() As Point = {New Point(1, 1), _
                                 New Point(Width - 2, 1), _
                                 New Point(Width - 1, 2), _
                                 New Point(Width - 1, Height - 2), _
                                 New Point(Width - 2, Height - 1), _
                                 New Point(2, Height - 1), _
                                 New Point(1, Height - 2), _
                                 New Point(1, 1)
                                }
        path.AddLines(points)

        If (state = 1) Then '绘制一般边框
            '绘制一个画笔，高光点，宽度2
            'p = New Pen(SystemColors.ControlLightLight, 2)
            p = New Pen(Brushes.Transparent, 0)
        ElseIf (state = 2) Then '绘制移动到其上的边框
            '与一般边框用高光区别的是显示黄色
            p = New Pen(Color.Yellow, 2)
            g.DrawPath(p, path)
        ElseIf (state = 3) Then '绘制按下的显示边框
            '与一般边框用高光区别的是显示暗褐色
            p = New Pen(Color.AntiqueWhite, 2)
        ElseIf (state = 4) Then '绘制不可用状态边框
            '与一般边框用高光区别的是显示亮色
            p = New Pen(SystemColors.ControlLightLight, 2)
        ElseIf (state = 5) Then '绘制有焦点但鼠标不在其上的状态
            '与一般边框用高光区别的是显示兰色
            p = New Pen(Color.SkyBlue, 2)
        End If
        g.DrawPath(p, path)

        Dim symbol_Z() As Point = {New Point(Width / 2 - 5, Height - 6), _
                             New Point(Width / 2 - 1, Height - 6), _
                             New Point(Width / 2 - 5, Height - 2), _
                             New Point(Width / 2 - 1, Height - 2)}
        Dim symbol_v() As Point = {New Point(Width / 2 + 1, Height - 5), _
                             New Point(Width / 2 + 3, Height - 3), _
                             New Point(Width / 2 + 5, Height - 5)}
        Dim symbol_one() As Point = {New Point(Width / 2 + 1, Height - 4), _
                             New Point(Width / 2 + 6, Height - 4), _
                             New Point(Width / 2 + 4, Height - 6), _
                             New Point(Width / 2 + 6, Height - 4), _
                             New Point(Width / 2 + 4, Height - 2)}
        Dim symbol_copy() As Point = {New Point(Width / 2 + 1, Height - 4),
                             New Point(Width / 2 + 3, Height - 2),
                             New Point(Width / 2 + 5, Height - 4),
                             New Point(Width / 2 + 3, Height - 6),
                             New Point(Width / 2 + 1, Height - 4)}

        If (_spcAutoFire) Then g.DrawLine(New Pen(Brushes.Orange, 2), 1, 2, Width - 1, 2) : g.DrawLine(Pens.Orange, 1, 3, Width - 1, 3)
        Select Case _spcJumpMode
            Case jmpmode.None
                If (_spcAutoLock) Then g.DrawLine(New Pen(Brushes.Blue, 3), 1, Height - 2, Width - 1, Height - 2) : g.DrawLine(Pens.Blue, 1, Height - 4, Width - 1, Height - 4)
            Case jmpmode.OneWay
                g.DrawLine(New Pen(Brushes.DarkOrchid, 6), 1, Height - 4, Width - 1, Height - 4) : g.DrawLines(Pens.White, symbol_Z) : g.DrawLines(Pens.White, symbol_one)
            Case jmpmode.Switch
                g.DrawLine(New Pen(Brushes.DarkOrchid, 6), 1, Height - 4, Width - 1, Height - 4) : g.DrawLines(Pens.White, symbol_Z) : g.DrawLines(Pens.White, symbol_v)
            Case jmpmode.CopySwitch
                g.DrawLine(New Pen(Brushes.DarkOrchid, 6), 1, Height - 4, Width - 1, Height - 4) : g.DrawLines(Pens.White, symbol_Z) : g.DrawLines(Pens.White, symbol_copy)
        End Select

        '//做完如上的处理后再对可用和不可用做圆化边缘处理（也就是把按钮的4个角进行圆化处理）
        Dim path2 As New System.Drawing.Drawing2D.GraphicsPath
        Dim points2() As Point = {New Point(0, 2), _
                                  New Point(2, 0), _
                                  New Point(Width - 3, 0), _
                                  New Point(Width - 1, 2), _
                                  New Point(Width - 1, Height - 3), _
                                  New Point(Width - 3, Height - 1), _
                                  New Point(2, Height - 1), _
                                  New Point(0, Height - 3), _
                                  New Point(0, 2)
                                 }
        path2.AddLines(points2)
        If (state = 4) Then '不可用时
            '使用画笔，Color.FromArgb(161, 161, 146)是从一个32位的ARGB值创建系统颜色，宽度为1
            p = New Pen(SystemColors.ControlDark, 1)
        Else 'draw normal style border
            '采用默认的黑色进行绘制边角
            p = Pens.Black
        End If
        g.DrawPath(p, path2)
    End Sub
    '动画按钮
    Private Sub DrawAnimateButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        '绘制背景，用高光点颜色
        gColor.highColor = _colorAniHigh
        gColor.mediumColor = _colorAniMedium
        gColor.lowColor = _colorAniLow
        PaintBack(g, gColor)
        '绘制边框
        DrawBorder(g, 1)
    End Sub
    '一般状态
    Private Sub DrawNormalButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        '绘制背景，用高光点颜色
        gColor.highColor = _colorHigh
        gColor.mediumColor = _colorMedium
        gColor.lowColor = _colorLow
        PaintBack(g, gColor)
        '绘制边框
        DrawBorder(g, 1)
    End Sub
    '鼠标移动到其上的状态
    Private Sub DrawMouseHoverButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        If (_checkbox) AndAlso (_checked) Then
            gColor.highColor = Color.LightGoldenrodYellow
            gColor.mediumColor = Color.Goldenrod
            gColor.lowColor = Color.Gold
        Else
            gColor.highColor = _colorHigh
            gColor.mediumColor = _colorMedium
            gColor.lowColor = _colorLow
        End If
        PaintBack(g, gColor)

        DrawBorder(g, 2)
    End Sub
    Private Sub DrawMouseDownButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        '绘制背景，用三维元素的亮色
        gColor.highColor = Color.LightGoldenrodYellow
        gColor.mediumColor = Color.Goldenrod
        gColor.lowColor = Color.Gold
        PaintBack(g, gColor)

        DrawBorder(g, 3)
    End Sub
    Private Sub DrawDisableButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        '亮色
        gColor.lowColor = SystemColors.ControlLight
        gColor.mediumColor = gColor.lowColor
        gColor.highColor = gColor.lowColor
        PaintBack(g, gColor)

        DrawBorder(g, 4)
    End Sub
    Private Sub DrawContainFocusButton(ByVal g As Graphics)
        Dim gColor As GradientColor
        '高光点
        If (_checkbox) AndAlso (_checked) Then
            gColor.highColor = Color.LightGoldenrodYellow
            gColor.mediumColor = Color.Goldenrod
            gColor.lowColor = Color.Gold
        Else
            gColor.highColor = _colorHigh
            gColor.mediumColor = _colorMedium
            gColor.lowColor = _colorLow
        End If

        PaintBack(g, gColor)

        DrawBorder(g, 5)
    End Sub
    '绘制背景色
    Private Sub PaintBack(ByVal g As Graphics, ByVal c As GradientColor)
        Dim _brush, _brush2 As LinearGradientBrush
        Dim rect As Rectangle = New Rectangle(1, 1, Width - 1, Height / 2 + 2)
        Dim rect2 As Rectangle = New Rectangle(1, Height / 2 + 1, Width - 1, Height / 2 - 1)
        '填充时采用：单色画刷，相对与（0，0）坐标（3，3）的位置，大小为宽-6，高-6
        'g.FillRectangle(New SolidBrush(c), 2, 2, Width - 4, Height - 4)

        _brush = New LinearGradientBrush(rect, _
             c.highColor, c.highColor, LinearGradientMode.Vertical)
        _brush2 = New LinearGradientBrush(rect2, _
             c.mediumColor, c.lowColor, LinearGradientMode.Vertical)

        g.FillRectangle(_brush2, rect2)
        g.FillRectangle(_brush, rect)
    End Sub
    '写文本
    Private Sub WriteText(ByVal g As Graphics)
        Dim b, s As New SolidBrush(Color.Black)
        Dim _format As New StringFormat
        '写文本
        If (Enabled) Then '如果控件可用，则黑色文字
            b = New SolidBrush(m_textcolor)
            s = Brushes.LightGray
        Else '如果控件不可用，则灰色文字
            b = Brushes.Gray
            s = Brushes.Transparent
        End If

        g.InterpolationMode = InterpolationMode.HighQualityBicubic

        If _antiAlias Then
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Else
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.ClearTypeGridFit
        End If

        _format.Alignment = StringAlignment.Center
        _format.Trimming = StringTrimming.Word

        Dim bounds As RectangleF = New RectangleF(Consts.PosOffset + 1, 1, _
             Me.DisplayRectangle.Width - Consts.PosOffset - 1, Me.DisplayRectangle.Height)
        Dim boundsShadow As RectangleF = New RectangleF(Consts.PosOffset + 1.5, 1.5,
         Me.DisplayRectangle.Width - Consts.PosOffset - 1, Me.DisplayRectangle.Height)

        If (_spcALT = True) OrElse (_spcCTRL = True) OrElse (_spcSHIFT = True) Then
            Dim bounds2 As RectangleF = New RectangleF(1, 2, _
             Me.DisplayRectangle.Width - 2, Me.DisplayRectangle.Height / 3)
            Dim i As Byte
            If _spcALT Then i += 1
            If _spcCTRL Then i += 2
            If _spcSHIFT Then i += 4

            _format.LineAlignment = StringAlignment.Near

            Select Case i
                Case 1
                    g.DrawString("ALT", mFont, b, bounds2, _format)
                Case 2
                    g.DrawString("CTRL", mFont, b, bounds2, _format)
                Case 4
                    g.DrawString("SHIFT", mFont, b, bounds2, _format)
                Case 3
                    g.DrawString("At+Ct", mFont, b, bounds2, _format)
                Case 5
                    g.DrawString("At+Sh", mFont, b, bounds2, _format)
                Case 6
                    g.DrawString("Ct+Sh", mFont, b, bounds2, _format)
                Case 7
                    g.DrawString("C+S+A", mFont, b, bounds2, _format)
            End Select
        End If

        _format.LineAlignment = StringAlignment.Center
        g.DrawString(Text, Font, s, boundsShadow, _format)
        g.DrawString(Text, Font, b, bounds, _format)
    End Sub

    Public Event CheckedChanged(sender As Object, e As EventArgs)

    Protected Overrides Sub OnClick(e As EventArgs)
        If CheckBox AndAlso _checked = False Then
            _checked = Not _checked
            RaiseEvent CheckedChanged(Me, e)
        End If
        MyBase.OnClick(e)
        Invalidate()
    End Sub
    Protected Overrides Sub OnResize(ByVal e As System.EventArgs)
        ReDraw()
        MyBase.Refresh()
    End Sub

    Private Sub iButton_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus
        my_focus = True
    End Sub

    Private Sub iButton_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus
        my_focus = False
    End Sub
End Class
