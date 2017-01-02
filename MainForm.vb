#Region "Imports directives"

Imports System.Reflection
Imports System.Text.RegularExpressions
Imports System.Threading
Imports SharpDX.DirectInput
Imports SharpDX.XInput

#End Region

Public Structure JoyKey
    Shared A As String = "A"
    Shared B As String = "B"
    Shared X As String = "X"
    Shared Y As String = "Y"
    Shared RIGHT_SHOULDER As String = "RIGHT_SHOULDER"
    Shared LEFT_SHOULDER As String = "LEFT_SHOULDER"
    Shared LTRIGGER As String = "LTRIGGER"
    Shared RTRIGGER As String = "RTRIGGER"

    Shared DPAD_UP As String = "DPAD_UP"
    Shared DPAD_DOWN As String = "DPAD_DOWN"
    Shared DPAD_LEFT As String = "DPAD_LEFT"
    Shared DPAD_RIGHT As String = "DPAD_RIGHT"
    Shared START As String = "START"
    Shared BACK As String = "BACK"

    Shared LEFT_THUMB As String = "LEFT_THUMB"
    Shared RIGHT_THUMB As String = "RIGHT_THUMB"

    Shared LTHUMB_UP As String = "LTHUMB_UP"
    Shared LTHUMB_DOWN As String = "LTHUMB_DOWN"
    Shared LTHUMB_RIGHT As String = "LTHUMB_RIGHT"
    Shared LTHUMB_LEFT As String = "LTHUMB_LEFT"
    Shared LTHUMB_UPLEFT As String = "LTHUMB_UPLEFT"
    Shared LTHUMB_UPRIGHT As String = "LTHUMB_UPRIGHT"
    Shared LTHUMB_DOWNRIGHT As String = "LTHUMB_DOWNRIGHT"
    Shared LTHUMB_DOWNLEFT As String = "LTHUMB_DOWNLEFT"

    Shared RTHUMB_UP As String = "RTHUMB_UP"
    Shared RTHUMB_DOWN As String = "RTHUMB_DOWN"
    Shared RTHUMB_RIGHT As String = "RTHUMB_RIGHT"
    Shared RTHUMB_LEFT As String = "RTHUMB_LEFT"
    Shared RTHUMB_UPLEFT As String = "RTHUMB_UPLEFT"
    Shared RTHUMB_UPRIGHT As String = "RTHUMB_UPRIGHT"
    Shared RTHUMB_DOWNRIGHT As String = "RTHUMB_DOWNRIGHT"
    Shared RTHUMB_DOWNLEFT As String = "RTHUMB_DOWNLEFT"

    Shared Combo As String = "Combo"
End Structure

Public Class MainForm
    Private lastPacket(3) As UIntPtr

    Public btnPressNum As iButton = Nothing

    Private RT, LT As Byte
    Private burstList As New ArrayList
    Private safeBtn As New List(Of String)
    Private thread1 As Threading.Thread = Nothing
    Private thread2 As Threading.Thread = Nothing
    Private Shared btWaitHandle As New ManualResetEventSlim(False)

    Private frm(24) As Form

    Private _JoyButtonList As IEnumerable(Of Button) = Nothing
    Private _pageButtonList As IEnumerable(Of Button) = Nothing

    Private XBOXMode As Boolean = True
    Private glbGUID(0) As Guid
    Private myJoystick As Joystick = Nothing
    Private myController As Controller = Nothing
    Private Shared dxWaitHandle As New AutoResetEvent(False)
    Const WM_DEVICECHANGE = &H219

    Private page(8, 99, 13) As Dictionary(Of String, String)
    Private sourceBtn As iButton
    Private switchMode As Boolean
    Private currentPage As Byte = 1
    Private cbJob As Byte

    Public RemindPos As Point = New Point(750, 300)

    Delegate Sub AppendText(myString As String)
    Public myDelegate As AppendText
    Public myDelegate2 As AppendText

    Dim JoyKeyPair As New Dictionary(Of String, String)

    Public Sub addText(myString As String)
        TextBox1.AppendText(vbNewLine & myString)
    End Sub 'AddListItemMethod

    Public Sub addText2(myString As String)
        TextBox2.Text = myString
    End Sub 'AddListItemMethod

    Private ReadOnly Property JoyButtonList() As IEnumerable(Of iButton)
        Get
            If _JoyButtonList Is Nothing Then
                _JoyButtonList = Panel1.Controls.OfType(Of iButton)()
            End If
            Return _JoyButtonList
        End Get
    End Property

    Private ReadOnly Property pageButtonList() As IEnumerable(Of iButton)
        Get
            If _pageButtonList Is Nothing Then
                _pageButtonList = PanelPage.Controls.OfType(Of iButton)()
            End If
            Return _pageButtonList
        End Get
    End Property

    Public Sub New()

        Dim createdNew As Boolean
        ' 创建mutex
        Dim mutex As System.Threading.Mutex =
            New System.Threading.Mutex(True, Application.ProductName, createdNew)
        If createdNew = False Then
            MsgBox("本程序已经有一个实例的正在运行。", MsgBoxStyle.Exclamation)
            End
        End If

        ' 释放mutex
        mutex.ReleaseMutex()

        ' 此调用是设计器所必需的。
        InitializeComponent()

        ' 在 InitializeComponent() 调用之后添加任何初始化。
        For Each btn As iButton In Me.JoyButtonList
            AddHandler btn.MouseUp, AddressOf btnJoyStick_MouseUp
            AddHandler btn.TextChanged, AddressOf btnJoyStick_TextChanged
        Next
        For Each btn As iButton In Me.pageButtonList
            AddHandler btn.CheckedChanged, AddressOf btnPage_CheckedChanged
            AddHandler btn.MouseDown, AddressOf btnPage_MouseDown
        Next
        For Each mnu As ToolStripItem In AddJobMnuItem.DropDownItems
            If TypeOf mnu Is ToolStripSeparator Then Continue For
            AddHandler mnu.Click, AddressOf AddJob_Click
        Next

        JoyKeyPair.Add(JoyKey.LTHUMB_LEFT, 1)
        JoyKeyPair.Add(JoyKey.LTHUMB_RIGHT, 2)
        JoyKeyPair.Add(JoyKey.LTHUMB_DOWN, 3)
        JoyKeyPair.Add(JoyKey.LTHUMB_UP, 4)
        JoyKeyPair.Add(JoyKey.LEFT_THUMB, 5)
        JoyKeyPair.Add(JoyKey.X, 6)
        JoyKeyPair.Add(JoyKey.B, 7)
        JoyKeyPair.Add(JoyKey.A, 8)
        JoyKeyPair.Add(JoyKey.Y, 9)
        JoyKeyPair.Add(JoyKey.DPAD_LEFT, 10)
        JoyKeyPair.Add(JoyKey.DPAD_RIGHT, 11)
        JoyKeyPair.Add(JoyKey.DPAD_DOWN, 12)
        JoyKeyPair.Add(JoyKey.DPAD_UP, 13)
        JoyKeyPair.Add(JoyKey.RTHUMB_LEFT, 14)
        JoyKeyPair.Add(JoyKey.RTHUMB_RIGHT, 15)
        JoyKeyPair.Add(JoyKey.RTHUMB_DOWN, 16)
        JoyKeyPair.Add(JoyKey.RTHUMB_UP, 17)
        JoyKeyPair.Add(JoyKey.RIGHT_THUMB, 18)
        JoyKeyPair.Add(JoyKey.LEFT_SHOULDER, 19)
        JoyKeyPair.Add(JoyKey.RIGHT_SHOULDER, 20)
        JoyKeyPair.Add(JoyKey.LTRIGGER, 21)
        JoyKeyPair.Add(JoyKey.RTRIGGER, 22)
        JoyKeyPair.Add(JoyKey.BACK, 23)
        JoyKeyPair.Add(JoyKey.START, 24)
        JoyKeyPair.Add(JoyKey.Combo, 25)
        JoyKeyPair.Add("L", "L")
        JoyKeyPair.Add("R", "R")

        'Dim objProcess As Process
        'objProcess = New Process()
        'objProcess = System.Diagnostics.Process.GetCurrentProcess()

        'objProcess.PriorityClass = ProcessPriorityClass.AboveNormal
    End Sub

    Private Function JOY2BTN(ByVal joy As String) As iButton
        Dim num As String
        If JoyKeyPair.ContainsKey(joy.ToString) Then
            num = JoyKeyPair.Item(joy.ToString)
        Else
            Console.WriteLine("未知按钮:{0}", joy)
            Return Nothing
        End If

        Return GetControlByName("btnJoyStick" & num)
    End Function

    Private Function GetControlByName(ByVal Name As String) As iButton
        Dim info As Reflection.FieldInfo = Me.GetType().GetField("_" & Name,
        System.Reflection.BindingFlags.NonPublic Or
        System.Reflection.BindingFlags.Instance Or
        System.Reflection.BindingFlags.Public Or
        System.Reflection.BindingFlags.IgnoreCase)

        If info Is Nothing Then
            Return Nothing
        Else
            Dim obj As iButton = info.GetValue(Me)
            Return obj
        End If
    End Function

    ''' <summary>
    ''' 创建程序配置XML文件
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub saveConfigXML()
        Dim xmlFileName As String = "FFXiVJoy"
        Try
            Dim writer As New Xml.XmlTextWriter(Application.StartupPath & "\" & xmlFileName & ".cfg", System.Text.Encoding.GetEncoding("utf-8"))
            '使用自动缩进便于阅读
            writer.Formatting = Xml.Formatting.Indented
            writer.WriteRaw("<?xml version=""1.0"" encoding=""utf-8"" ?>")
            '书写根元素()
            writer.WriteStartElement("Configuration")
            writer.WriteElementString("Profile", ConfigBox1.Text)
            '关闭根元素
            writer.WriteFullEndElement()
            '将XML写入文件并关闭writer
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' 读取程序配置XML文件
    ''' </summary>
    ''' <remarks></remarks>
    Private Function readConfigXML() As Boolean
        Dim xmlFileName As String = "FFXiVJoy"
        Try
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & xmlFileName & ".cfg") Then
                Dim doc As New Xml.XmlDocument
                doc.Load(Application.StartupPath.Trim & "\" & xmlFileName & ".cfg")

                Dim xmlProfile As Xml.XmlNode = doc.SelectSingleNode("//Configuration").Item("Profile")

                Dim tmp As Integer = ConfigBox1.FindString(xmlProfile.InnerText)
                ConfigBox1.SelectedIndex = tmp

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            Return False
        End Try
    End Function

    ''' <summary>
    ''' 创建XML文件
    ''' </summary>
    ''' <param name="xmlFileName">要创建的XML文件名</param>
    ''' <remarks></remarks>
    Private Sub writeXML(ByVal xmlFileName As String)
        Try
            Dim writer As New Xml.XmlTextWriter(Application.StartupPath & "\" & xmlFileName & ".xmlprofile", System.Text.Encoding.GetEncoding("utf-8"))
            '使用自动缩进便于阅读
            writer.Formatting = Xml.Formatting.Indented
            writer.WriteRaw("<?xml version=""1.0"" encoding=""utf-8"" ?>")
            '书写根元素()
            writer.WriteStartElement("Configuration")

            '书写2级元素()
            writer.WriteStartElement("AutoSwitch")
            '添加子元素()
            writer.WriteElementString("Enabled", btnJob.Checked)
            '添加子元素()
            Dim jobs As String = vbNullString
            For Each item As ToolStripItem In jobMenu.Items
                If jobMenu.Items.IndexOf(item) = jobMenu.Items.Count - 3 Then Exit For
                If TypeOf item Is ToolStripSeparator Then Continue For
                jobs = jobs & "," & item.Name
            Next
            If jobs = ",通用" Then jobs = ""
            writer.WriteElementString("Jobs", jobs.Replace(",通用,", ""))
            writer.WriteEndElement()

            '书写2级元素()
            writer.WriteStartElement("Assignments")

            For job = 0 To 13
                writer.WriteStartElement("Job" & job)
                '添加子元素()
                For pge = 1 To 8
                    writer.WriteStartElement("Page" & pge)
                    '添加子元素()
                    For num = 1 To 25
                        '添加次级元素
                        If IsNothing(page(pge, num, job)) = False Then
                            writer.WriteStartElement("Button" & num)
                            With page(pge, num, job)
                                writer.WriteElementString("Text", .Item("Text"))
                                writer.WriteElementString("ALT", .Item("ALT"))
                                writer.WriteElementString("SHIFT", .Item("SHIFT"))
                                writer.WriteElementString("CTRL", .Item("CTRL"))
                                writer.WriteElementString("Tag", .Item("Tag"))
                                writer.WriteElementString("TagJump", .Item("TagJump"))
                                writer.WriteElementString("AutoFire", .Item("AutoFire"))
                                writer.WriteElementString("AutoLock", .Item("AutoLock"))
                                writer.WriteElementString("Remind", .Item("Remind"))
                                writer.WriteElementString("JumpMode", .Item("JumpMode"))
                            End With
                            writer.WriteEndElement()
                        End If
                    Next
                    For num = 98 To 99
                        '添加次级元素
                        If IsNothing(page(pge, num, job)) = False Then
                            writer.WriteStartElement("Button" & num)
                            With page(pge, num, job)
                                writer.WriteElementString("Text", .Item("Text"))
                                writer.WriteElementString("ALT", .Item("ALT"))
                                writer.WriteElementString("SHIFT", .Item("SHIFT"))
                                writer.WriteElementString("CTRL", .Item("CTRL"))
                                writer.WriteElementString("Tag", .Item("Tag"))
                                writer.WriteElementString("TagJump", .Item("TagJump"))
                                writer.WriteElementString("AutoFire", .Item("AutoFire"))
                                writer.WriteElementString("AutoLock", .Item("AutoLock"))
                                writer.WriteElementString("Remind", .Item("Remind"))
                                writer.WriteElementString("JumpMode", .Item("JumpMode"))
                            End With
                            writer.WriteEndElement()
                        End If
                    Next
                    writer.WriteEndElement()
                Next
                writer.WriteEndElement()
            Next
            writer.WriteEndElement()
            '关闭根元素
            writer.WriteFullEndElement()
            '将XML写入文件并关闭writer
            writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace, MsgBoxStyle.Critical)
        End Try
    End Sub

    ''' <summary>
    ''' 读取XML文件
    ''' </summary>
    ''' <param name="xmlFileName">要读取的XML文件名</param>
    ''' <remarks></remarks>
    Private Function readXML(ByVal xmlFileName As String) As Boolean
        Try
            If My.Computer.FileSystem.FileExists(Application.StartupPath & "\" & xmlFileName & ".xmlprofile") Then
                Dim doc As New Xml.XmlDocument
                doc.Load(Application.StartupPath.Trim & "\" & xmlFileName & ".xmlprofile")

                Dim xmlAutoSwitch As Xml.XmlNode = doc.SelectSingleNode("//AutoSwitch").Item("Enabled")
                AutoSwitchMnuItem.Checked = xmlAutoSwitch.InnerText

                Dim xmlJobs As Xml.XmlNode = doc.SelectSingleNode("//AutoSwitch").Item("Jobs")
                Dim jobs() As String = xmlJobs.InnerText.Split(",")
                For Each item As String In jobs
                    If item = "" Then Exit For
                    AddJobMnuItem.DropDownItems.Find(item & "MenuItem", False)(0).PerformClick()
                Next

                For i = 0 To 13
                    Dim joblist As Xml.XmlNodeList = doc.SelectSingleNode("//Job" & i).ChildNodes
                    For Each list0 As Xml.XmlNode In joblist
                        Dim list As Xml.XmlNodeList = list0.ChildNodes
                        For Each xn As Xml.XmlNode In list
                            Dim nls As Xml.XmlNodeList = xn.ChildNodes
                            page(Regex.Match(list0.Name, "\d+").Value, Regex.Match(xn.Name, "\d+").Value, i) = New Dictionary(Of String, String)
                            For Each xn1 As Xml.XmlNode In nls
                                tmp = xn.Name.Replace("Button", "").Replace("L", 98).Replace("R", 99)
                                With page(Regex.Match(list0.Name, "\d+").Value, tmp, i)
                                    Select Case xn1.Name
                                        Case "Text"
                                            .Item("Text") = xn1.InnerText
                                        Case "ALT"
                                            .Item("ALT") = xn1.InnerText
                                        Case "SHIFT"
                                            .Item("SHIFT") = xn1.InnerText
                                        Case "CTRL"
                                            .Item("CTRL") = xn1.InnerText
                                        Case "Tag"
                                            .Item("Tag") = xn1.InnerText
                                        Case "TagJump"
                                            .Item("TagJump") = xn1.InnerText
                                        Case "AutoFire"
                                            .Item("AutoFire") = xn1.InnerText
                                        Case "AutoLock"
                                            .Item("AutoLock") = xn1.InnerText
                                        Case "Remind"
                                            .Item("Remind") = xn1.InnerText
                                        Case "JumpMode"
                                            .Item("JumpMode") = xn1.InnerText
                                    End Select
                                End With
                            Next
                        Next
                    Next
                Next
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & ex.StackTrace)
            Return False
        End Try
    End Function

    Private Sub joyDown(keyORbtn As Object)
        Dim obj As iButton = Nothing
        If TypeOf keyORbtn Is String Then
            obj = JOY2BTN(keyORbtn)
        ElseIf TypeOf keyORbtn Is iButton Then
            obj = keyORbtn
        End If
        If IsNothing(obj) Then Exit Sub

        obj.AnimateDown()
        kbDownChar(obj.Tag)

        Select Case obj.JumpMode
            Case 1 To 2
                If TypeOf keyORbtn Is String Then safeBtn.Remove(keyORbtn)
                safePerformClick(GetControlByName("btnPage" & obj.TagJump))
            Case 3
                If TypeOf keyORbtn Is String Then safeBtn.Remove(keyORbtn)
                switchMode = True
                copySwitch(obj, obj.TagJump)
        End Select
    End Sub

    Private Sub joyDownAnimate(ByVal key As String)
        Dim obj As iButton = JOY2BTN(key)

        If IsNothing(obj) Then Exit Sub
        obj.AnimateDown()
    End Sub

    Private Sub joyUp(ByVal key As String)
        Dim obj As iButton = JOY2BTN(key)

        If IsNothing(obj) Then Exit Sub

        obj.AnimateUp()
        kbUpChar(obj.Tag)

        If obj.JumpMode = 2 Then safeBtn.Remove(key) : safePerformClick(GetControlByName("btnPage" & obj.TagJump))
        If obj.JumpMode = 3 Then
            safeBtn.Remove(key) : copySwitch(obj)
            If switchMode = True Then
                Dim btnList As List(Of iButton) = JoyButtonList.ToList
                btnList.Remove(obj)
                For Each item In btnList
                    If item.ButtonState = 1 Then joyDown(item)
                Next
                switchMode = False
            End If
        End If
    End Sub

    Private Sub joyUpAnimate(ByVal key As String)
        Dim obj As iButton = JOY2BTN(key)

        If IsNothing(obj) Then Exit Sub
        obj.AnimateUp()
        kbUpChar(obj.Tag)
    End Sub

    Delegate Sub PerformClickCallback([iButton] As iButton)
    Private Sub safePerformClick(ByVal [iButton] As iButton)
        If [iButton].InvokeRequired Then
            Dim d As New PerformClickCallback(AddressOf safePerformClick)
            Me.Invoke(d, New Object() {[iButton]})
        Else
            switchPage([iButton])
        End If
    End Sub

    Private Sub BurstThread()
        Dim dupList As New ArrayList
        Dim code As New Dictionary(Of Byte, String)
        Do
            btWaitHandle.Wait()

            code.Clear()

            Try
                For Each i In burstList
                    btWaitHandle.Wait()
                    Dim obj As iButton = GetControlByName("btnJoyStick" & i)
                    obj.AnimateDown()
                    kbDownChar(obj.Tag)
                    code.Add(i, obj.Tag)
                Next
            Catch e As Exception
                Console.WriteLine("Error:{0}", e.Message)
            End Try
            Thread.Sleep(20)
            For Each j In code
                Dim obj As iButton = GetControlByName("btnJoyStick" & j.Key)
                obj.AnimateUp()
                kbUpChar(j.Value)
            Next
            Thread.Sleep(20)
        Loop
    End Sub

    Private Sub TimerXInput_Tick(sender As Object, e As EventArgs) Handles TimerXInput.Tick
        If IsNothing(myController) Then Exit Sub

        Dim state As SharpDX.XInput.State = myController.GetState()

        If (lastPacket(myController.UserIndex) = state.PacketNumber) Then Exit Sub

        Dim keystroke As SharpDX.XInput.Keystroke
        Dim xbutton As SharpDX.XInput.GamepadButtonFlags
        Dim lTrigger As Byte = state.Gamepad.LeftTrigger : Dim rTrigger As Byte = state.Gamepad.RightTrigger

        myController.GetKeystroke(DeviceQueryType.Any, keystroke)
        xbutton = state.Gamepad.Buttons

        TextBox1.AppendText(lTrigger.ToString() & vbTab _
                            & rTrigger.ToString() & vbTab _
                            & state.Gamepad.LeftThumbX.ToString() & vbTab _
                            & state.Gamepad.LeftThumbY.ToString() & vbTab _
                            & state.Gamepad.RightThumbX.ToString() & vbTab _
                            & state.Gamepad.RightThumbY.ToString() & vbTab _
                            & state.Gamepad.Buttons.ToString() & vbNewLine
                            )
        TextBox2.AppendText(keystroke.VirtualKey.ToString() & vbTab _
                            & keystroke.Flags.ToString() & vbNewLine
                            )
        lastPacket(myController.UserIndex) = state.PacketNumber
    End Sub

    Private Sub btnConfig_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConfig.MouseUp
        If e.Button = MouseButtons.Left Then
            btWaitHandle.Reset()
            burstList.Clear()
            btWaitHandle.Set()

            Dim frm As Form = New LayoutForm
            frm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnJoyStick_MouseUp(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            btWaitHandle.Reset()
            burstList.Clear()
            btWaitHandle.Set()

            Dim frm As Form = New KeyMapBox
            btnPressNum = sender
            frm.ShowDialog(Me)
        End If
    End Sub

    Private Sub btnJoyStick_TextChanged(sender As Object, e As EventArgs)
        Dim myText As Object = CType(sender, iButton)
        Dim fontname As String
        fontname = myText.Font.Name

        If myText.Text.Length <= 2 Then
            myText.Font = New Font(fontname, 11)
        Else
            myText.Font = New Font(fontname, 8)
        End If
    End Sub

    Private Sub AbortThreads()
        Try
            thread1.Abort()
        Catch a As ThreadAbortException
            thread1.Join()
            thread1 = Nothing
        Catch a As NullReferenceException
        End Try
        Try
            thread2.Abort()
        Catch a As ThreadAbortException
            thread2.Join()
            thread2 = Nothing
        Catch a As NullReferenceException
        End Try
    End Sub

    Private Sub MainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        AbortThreads()
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SavePageConfig()
        saveConfigXML()
        writeXML(ConfigBox1.Text)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Icon = My.Resources.Joystick
        With NotifyIcon1
            .Icon = Me.Icon
            .Text = Application.ProductName
            .BalloonTipText = .Text
        End With

        myDelegate = New AppendText(AddressOf addText)
        myDelegate2 = New AppendText(AddressOf addText2)

        Dim bkbmp As Bitmap
        bkbmp = My.Resources.microsoftxbox360
        bkbmp.MakeTransparent(bkbmp.GetPixel(0, 0))
        PictureBox1.Image = bkbmp

        ResetDevice()
        ConfigBox1_Update()
        If readConfigXML() = False Then saveConfigXML()
        'ReduceMemory()
    End Sub

    Private Sub 置顶显示ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 置顶显示ToolStripMenuItem.Click
        置顶显示ToolStripMenuItem.Checked = Not 置顶显示ToolStripMenuItem.Checked
        Me.TopMost = 置顶显示ToolStripMenuItem.Checked
    End Sub

    Private Sub 关于ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 关于ToolStripMenuItem1.Click
        AboutBox.ShowDialog(Me)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Dim C1, C2 As Color
        C1 = Color.FromKnownColor(KnownColor.LightGreen)
        C2 = Color.FromKnownColor(KnownColor.LightBlue)
        Using LG As Drawing2D.LinearGradientBrush = New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, Panel1.Height), C1, C2)
            e.Graphics.FillRectangle(LG, New Rectangle(0, 0, Panel1.Width, Panel1.Height))
        End Using
    End Sub

    Private Function EnumDevice() As Dictionary(Of String, Guid)
        Dim dInput As New DirectInput()
        Dim myList As New Dictionary(Of String, Guid)
        Dim devInstance As New DeviceInstance, joystickGuid As Guid
        Dim Controllers As List(Of Controller) = {New Controller(0), New Controller(1), New Controller(2), New Controller(3)}.ToList

        ' Looking for all Joysticks/Gamepads
        For Each devInstance In dInput.GetDevices(SharpDX.DirectInput.DeviceType.Gamepad, DeviceEnumerationFlags.AttachedOnly)
            joystickGuid = devInstance.InstanceGuid
            myList.Add(devInstance.InstanceName, joystickGuid)

            Console.WriteLine("Found Gamepad")
            Console.WriteLine("GUID: {0}", joystickGuid)
            Console.WriteLine("NAME: {0}", devInstance.InstanceName)
        Next
        For Each devInstance In dInput.GetDevices(SharpDX.DirectInput.DeviceType.Joystick, DeviceEnumerationFlags.AttachedOnly)
            joystickGuid = devInstance.InstanceGuid
            myList.Add(devInstance.InstanceName, joystickGuid)

            Console.WriteLine("Found Joystick")
            Console.WriteLine("GUID: {0}", joystickGuid)
            Console.WriteLine("NAME: {0}", devInstance.InstanceName)
        Next

        Return myList
    End Function

    Private Sub ResetDevice()
        Dim myList As Dictionary(Of String, Guid) = EnumDevice()
        Dim listGUID, valueList As List(Of Guid)
        Dim myFlag As Boolean = False
        Dim prevGuid As Guid

        listGUID = glbGUID.ToList
        valueList = myList.Values.ToList

        If glbGUID.Except(valueList).Count > 0 OrElse valueList.Except(glbGUID).Count > 0 Then myFlag = True

        If myFlag = True Then
            If DeviceBox1.SelectedIndex > -1 Then prevGuid = glbGUID(DeviceBox1.SelectedIndex) : Console.WriteLine(prevGuid)
            With DeviceBox1
                .Items.Clear()
                If myList.Count = 0 Then ReDim glbGUID(0)
                For Each kvPair As KeyValuePair(Of String, Guid) In myList
                    ReDim Preserve glbGUID(.Items.Count)
                    glbGUID(.Items.Count) = kvPair.Value
                    .Items.Add(kvPair.Key)
                    If prevGuid = kvPair.Value Then .SelectedIndex = (.Items.Count - 1)
                Next
            End With

            If (DeviceBox1.Items.Count > 0) Then
                If DeviceBox1.SelectedIndex = -1 Then DeviceBox1.SelectedIndex = 0

                If IsNothing(thread1) OrElse thread1.IsAlive = False Then
                    thread1 = New Threading.Thread(AddressOf JoystickInupt_Thread)
                    thread1.Start()
                    'thread1.IsBackground = True
                    thread1.Priority = ThreadPriority.Highest
                End If
                If IsNothing(thread2) OrElse thread2.IsAlive = False Then
                    thread2 = New Threading.Thread(AddressOf BurstThread)
                    thread2.Start()
                    'thread2.IsBackground = True
                    thread2.Priority = ThreadPriority.Highest
                End If

                DeviceBox1.Enabled = True
                btnConfig.Enabled = True
                CType(jobMenu.Items("通用"), ToolStripMenuItem).Checked = True
                SelectJob("通用")
            Else
                AbortThreads()
                DeviceBox1.Enabled = False
                btnConfig.Enabled = False
            End If
        End If
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = WM_DEVICECHANGE Then ResetDevice()
        MyBase.WndProc(m)
    End Sub

    Private Sub DeviceBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DeviceBox1.SelectedIndexChanged
        Dim dInput As New DirectInput()

        If IsNothing(myJoystick) = False Then myJoystick.Unacquire()
        ' Instantiate the joystick
        myJoystick = New Joystick(dInput, glbGUID(DeviceBox1.SelectedIndex))

        ' Set BufferSize in order to use buffered data.
        myJoystick.Properties.BufferSize = 128
        myJoystick.SetNotification(dxWaitHandle)
        ' Acquire the joystick
        myJoystick.Acquire()
        myJoystick.Poll()

        ToolTip2.SetToolTip(DeviceBox1, DeviceBox1.Text)
    End Sub

    Private Sub playSound(ByVal str As String)
        Dim file As String
        file = Application.StartupPath & "\" & str

        If My.Computer.FileSystem.FileExists(file) Then
            Dim player As New System.Media.SoundPlayer()
            player.SoundLocation = file & vbCr & vbLf
            player.Load()
            player.Play()
        End If
    End Sub

    Private Sub bstListAdd(ByVal num As Byte)
        If burstList.Contains(num) = False Then
            burstList.Add(num)
        End If
    End Sub

    Private Sub bstListDel(ByVal num As Byte)
        If burstList.Contains(num) = True Then
            burstList.Remove(num)
        End If
    End Sub

    Private Sub JoystickInupt_Thread()
        '=============================================================================
        '                               定义变量
        '=============================================================================
        Dim datas As JoystickUpdate()
        Dim joyState As JoystickState
        Dim Controllers As Array = {New Controller(0), New Controller(1), New Controller(2), New Controller(3)}
        Dim joyButton() As Boolean
        Dim xbutton As SharpDX.XInput.GamepadButtonFlags
        Dim LTHUMB_X, LTHUMB_Y, RTHUMB_X, RTHUMB_Y As Short
        Dim oldbtn_flag As New List(Of String)

        Dim xinput_button As New Dictionary(Of String, Integer)
        With xinput_button
            .Add("DPAD_UP", &H1)
            .Add("DPAD_DOWN", &H2)
            .Add("DPAD_LEFT", &H4)
            .Add("DPAD_RIGHT", &H8)
            .Add("START", &H10)
            .Add("BACK", &H20)
            .Add("LEFT_THUMB", &H40)
            .Add("RIGHT_THUMB", &H80)
            .Add("LEFT_SHOULDER", &H100)
            .Add("RIGHT_SHOULDER", &H200)
            .Add("A", &H1000)
            .Add("B", &H2000)
            .Add("X", &H4000)
            .Add("Y", &H8000)
        End With
        '=============================================================================
        '                                   END
        '=============================================================================

        Do
            If (myJoystick.Information.Type = SharpDX.DirectInput.DeviceType.Gamepad) AndAlso (XBOXMode = True) Then
                For Each item As Controller In Controllers
                    If item.IsConnected Then lastPacket(item.UserIndex) = item.GetState.PacketNumber
                Next
            End If

            dxWaitHandle.WaitOne()

            Try
                If (myJoystick.Information.Type = SharpDX.DirectInput.DeviceType.Gamepad) AndAlso (XBOXMode = True) Then
                    For Each item As Controller In Controllers
                        If item.IsConnected AndAlso (lastPacket(item.UserIndex) <> item.GetState.PacketNumber) Then
                            myController = item
                            GoTo Line_XInput
                        End If
                    Next
                End If

                '=============================================================================
                '                           DirectInput Method
                '=============================================================================
                datas = myJoystick.GetBufferedData()
                joyState = myJoystick.GetCurrentState()
                joyButton = joyState.Buttons

                For Each mystate In datas
                    Me.Invoke(myDelegate, mystate.ToString())
                Next

                Me.Invoke(myDelegate2, myJoystick.GetCurrentState().ToString)

                If IsNothing(myController) Then GoTo Line_END
Line_XInput:
                '=============================================================================
                '                               XInput Method
                '=============================================================================

                Dim state As SharpDX.XInput.Gamepad = myController.GetState().Gamepad
                Dim lTrigger As Byte = state.LeftTrigger : Dim rTrigger As Byte = state.RightTrigger
                Dim btn_flag As New List(Of String)

                xbutton = state.Buttons
                LTHUMB_X = state.LeftThumbX : LTHUMB_Y = state.LeftThumbY
                RTHUMB_X = state.RightThumbX : RTHUMB_Y = state.RightThumbY

                'Console.WriteLine("{0}  {1} {2} {3} {4} {5} {6}", lTrigger, rTrigger, state.LeftThumbX, state.LeftThumbY, state.RightThumbX, state.RightThumbY, state.Buttons)

                'BUTTON
                For Each item As KeyValuePair(Of String, Integer) In xinput_button
                    If (xbutton And item.Value) Then btn_flag.Add(item.Key)
                Next
                'TRIGGER
                If lTrigger > 30 Then btn_flag.Add("LTRIGGER")
                If rTrigger > 30 Then btn_flag.Add("RTRIGGER")
                If lTrigger > 30 And rTrigger > 30 Then btn_flag.Add("Combo")
                'LTHUMB
                Select Case LTHUMB_X
                    Case < -15000
                        btn_flag.Add("LTHUMB_LEFT")
                    Case > 15000
                        btn_flag.Add("LTHUMB_RIGHT")
                End Select
                Select Case LTHUMB_Y
                    Case < -15000
                        btn_flag.Add("LTHUMB_DOWN")
                    Case > 15000
                        btn_flag.Add("LTHUMB_UP")
                End Select
                'RTHUMB
                Select Case RTHUMB_X
                    Case < -15000
                        btn_flag.Add("RTHUMB_LEFT")
                    Case > 15000
                        btn_flag.Add("RTHUMB_RIGHT")
                End Select
                Select Case RTHUMB_Y
                    Case < -15000
                        btn_flag.Add("RTHUMB_DOWN")
                    Case > 15000
                        btn_flag.Add("RTHUMB_UP")
                End Select

                Dim pressbtn As List(Of String) = btn_flag.Except(oldbtn_flag).ToList
                If (pressbtn.Contains("Combo")) Then 'Combo
                    Call joyUpAnimate("L") : Call joyUpAnimate("R")
                    Call joyDownAnimate(JoyKey.LTRIGGER) : Call joyDownAnimate(JoyKey.RTRIGGER)

                    With JOY2BTN(JoyKey.Combo)
                        If .AutoLock = False OrElse .TagLock = False Then
                            If .AutoFire Then bstListAdd(25) Else Call joyDown(JoyKey.Combo)
                        End If
                        If .AutoLock Then .TagLock = Not .TagLock
                    End With
                    pressbtn.Remove("LTRIGGER") : pressbtn.Remove("RTRIGGER")
                End If
                pressbtn.Remove("Combo")
                For Each btn In pressbtn
                    With JOY2BTN(btn)
                        If .AutoLock = False OrElse .TagLock = False Then
                            If .AutoFire Then bstListAdd(JoyKeyPair.Item(btn)) Else Call joyDown(btn)
                        End If
                        If .AutoLock Then
                            .TagLock = Not .TagLock
                            If .Remind Then
                                number = JoyKeyPair.Item(btn)
                                If .TagLock AndAlso IsNothing(frm(number)) Then
                                    Me.Invoke(Sub()
                                                  frm(number) = New RemindForm
                                                  frm(number).Show()
                                              End Sub)
                                    playSound("toggleon.wav")
                                Else
                                    Me.Invoke(Sub()
                                                  frm(number).Dispose()
                                                  frm(number) = Nothing
                                              End Sub)
                                    playSound("toggleoff.wav")
                                    .TagLock = False
                                End If
                            End If
                        End If
                    End With
                Next

                Dim releasebtn As List(Of String) = oldbtn_flag.Except(btn_flag).Reverse.ToList
                Dim pT As Boolean = False
                For Each item As String In releasebtn
                    Select Case item
                        Case "Combo"
                            With JOY2BTN(JoyKey.Combo)
                                If .TagLock = False Then
                                    If .AutoFire Then bstListDel(25) Else Call joyUpAnimate(JoyKey.Combo)
                                End If
                            End With
                        Case "LTRIGGER"
                            If releasebtn.Contains(JoyKey.Combo) And pT = False Then
                                Call joyUpAnimate(JoyKey.LTRIGGER)
                                Call joyDown("R")
                            Else
                                Call joyUpAnimate("L")
                                With JOY2BTN(JoyKey.LTRIGGER)
                                    If .TagLock = False Then
                                        If .AutoFire Then bstListDel(21) Else Call joyUp(JoyKey.LTRIGGER)
                                    End If
                                End With
                            End If
                            pT = True
                        Case "RTRIGGER"
                            If releasebtn.Contains(JoyKey.Combo) And pT = False Then
                                Call joyUpAnimate(JoyKey.RTRIGGER)
                                Call joyDown("L")
                            Else
                                Call joyUpAnimate("R")
                                With JOY2BTN(JoyKey.RTRIGGER)
                                    If .TagLock = False Then
                                        If .AutoFire Then bstListDel(22) Else Call joyUp(JoyKey.RTRIGGER)
                                    End If
                                End With
                            End If
                            pT = True
                    End Select
                Next
                releasebtn.Remove("Combo") : releasebtn.Remove("LTRIGGER") : releasebtn.Remove("RTRIGGER")
                For Each btn As String In releasebtn
                    With JOY2BTN(btn)
                        If .TagLock = False Then
                            If .AutoFire Then bstListDel(JoyKeyPair.Item(btn)) Else Call joyUp(btn)
                        End If
                    End With
                Next

                safeBtn = btn_flag.ToList
                safeBtn.Remove(JoyKey.LTRIGGER)
                safeBtn.Remove(JoyKey.RTRIGGER)
                safeBtn.Remove(JoyKey.Combo)

                oldbtn_flag = btn_flag
Line_END:
            Catch e As SharpDX.SharpDXException
                If e.HResult = -2147024866 Then Exit Sub
            End Try
        Loop

    End Sub

    Private Sub AutoMnuItem_Click(sender As Object, e As EventArgs) Handles AutoMnuItem.Click
        sourceBtn.AutoFire = AutoMnuItem.Checked
    End Sub

    Private Sub LockMnuItem_Click(sender As Object, e As EventArgs) Handles LockMnuItem.Click
        sourceBtn.AutoLock = LockMnuItem.Checked
    End Sub

    Private Sub RemindMnuItem_Click(sender As Object, e As EventArgs) Handles RemindMnuItem.Click
        sourceBtn.Remind = RemindMnuItem.Checked
    End Sub

    Private Sub ClearMnuItem_Click(sender As Object, e As EventArgs) Handles ClearMnuItem.Click
        Dim obj As iButton = btnMenu.SourceControl

        Call JmpRefine()

        obj.Text = Nothing : obj.Tag = Nothing
        obj.ALT = False : obj.CTRL = False : obj.SHIFT = False
        obj.JumpMode = 0 : obj.AutoLock = False : obj.AutoFire = False
    End Sub

    Private Sub btnMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles btnMenu.Opening
        sourceBtn = btnMenu.SourceControl
        AutoMnuItem.Checked = sourceBtn.AutoFire
        LockMnuItem.Checked = sourceBtn.AutoLock
        RemindMnuItem.Checked = sourceBtn.Remind
        Select Case sourceBtn.JumpMode
            Case 0
                JmpNMnuItem.Checked = True
                JmpAMnuItem.Checked = False : JmpSMnuItem.Checked = False : JmpCMnuItem.Checked = False
            Case 1
                JmpAMnuItem.Checked = True
                'JmpAMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1).BackColor = Color.Chocolate
                For Each item In JmpAMnuItem.DropDownItems
                    CType(item, ToolStripMenuItem).Checked = False
                Next
                CType(JmpAMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1), ToolStripMenuItem).Checked = True
                JmpNMnuItem.Checked = False : JmpSMnuItem.Checked = False : JmpCMnuItem.Checked = False
            Case 2
                JmpSMnuItem.Checked = True
                'JmpSMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1).BackColor = Color.Chocolate
                For Each item In JmpSMnuItem.DropDownItems
                    CType(item, ToolStripMenuItem).Checked = False
                Next
                CType(JmpSMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1), ToolStripMenuItem).Checked = True
                JmpAMnuItem.Checked = False : JmpNMnuItem.Checked = False : JmpCMnuItem.Checked = False
            Case 3
                JmpCMnuItem.Checked = True
                'JmpCMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1).BackColor = Color.Chocolate
                For Each item In JmpCMnuItem.DropDownItems
                    CType(item, ToolStripMenuItem).Checked = False
                Next
                CType(JmpCMnuItem.DropDownItems(CInt(sourceBtn.TagJump) - 1), ToolStripMenuItem).Checked = True
                JmpAMnuItem.Checked = False : JmpNMnuItem.Checked = False : JmpSMnuItem.Checked = False
        End Select
    End Sub

    Private Function JmpRefine(Optional btn As iButton = Nothing, Optional pge As Byte = Nothing) As Byte
        Dim num As Byte, tmpStr As String, tmpPage As String = Nothing

        If IsNothing(btn) Then btn = sourceBtn
        If IsNothing(pge) Then pge = currentPage

        tmpStr = btn.Name.Replace("btnJoyStick", "")
        If tmpStr = "L" Then
            num = 98
        ElseIf tmpStr = "R" Then
            num = 99
        Else
            num = CByte(tmpStr)
        End If

        If btn.JumpMode = 2 Then
            tmpPage = btn.TagJump
        ElseIf IsNothing(page(pge, num, cbJob)) = False AndAlso page(pge, num, cbJob).Item("JumpMode") = 2 Then
            tmpPage = page(pge, num, cbJob).Item("TagJump")
        End If
        If tmpPage <> Nothing AndAlso IsNothing(page(tmpPage, num, cbJob)) = False AndAlso page(tmpPage, num, cbJob).Item("JumpMode") = 2 Then page(tmpPage, num, cbJob).Item("JumpMode") = 1

        Return num
    End Function

    Private Sub JmpNMnuItem_Click(sender As Object, e As EventArgs) Handles JmpNMnuItem.Click
        Dim obj As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Call JmpRefine()

        sourceBtn.JumpMode = 0
        sourceBtn.TagJump = ""
        sourceBtn = Nothing
    End Sub

    Private Sub jmpAPageMenu_Click(sender As Object, e As EventArgs)
        Dim obj As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Call JmpRefine()

        sourceBtn.JumpMode = 1
        sourceBtn.TagJump = obj.Text
        sourceBtn = Nothing
    End Sub

    Private Sub jmpSPageMenu_Click(sender As Object, e As EventArgs)
        Dim obj As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim num As Byte = JmpRefine()

        sourceBtn.JumpMode = 2
        sourceBtn.TagJump = obj.Text

        If IsNothing(page(obj.Text, num, cbJob)) Then
            page(obj.Text, num, cbJob) = New Dictionary(Of String, String)
            With page(obj.Text, num, cbJob)
                .Item("Text") = Nothing
                .Item("ALT") = False
                .Item("SHIFT") = False
                .Item("CTRL") = False
                .Item("Tag") = Nothing
                .Item("TagJump") = Nothing
                .Item("AutoFire") = False
                .Item("AutoLock") = False
                .Item("Remind") = False
                .Item("JumpMode") = 0
            End With
        End If

        Dim tmpPage As String = Nothing
        If page(obj.Text, num, cbJob).Item("JumpMode") = 2 Then
            tmpPage = page(obj.Text, num, cbJob).Item("TagJump")
            If tmpPage <> Nothing AndAlso IsNothing(page(tmpPage, num, cbJob)) = False AndAlso page(tmpPage, num, cbJob).ContainsKey("JumpMode") AndAlso page(tmpPage, num, cbJob).Item("JumpMode") = 2 Then page(tmpPage, num, cbJob).Item("JumpMode") = 1
        End If
        page(obj.Text, num, cbJob).Item("JumpMode") = 2
        page(obj.Text, num, cbJob).Item("TagJump") = currentPage
        sourceBtn = Nothing
    End Sub

    Private Sub jmpCPageMenu_Click(sender As Object, e As EventArgs)
        Dim obj As ToolStripMenuItem = CType(sender, ToolStripMenuItem)

        Call JmpRefine()

        sourceBtn.JumpMode = 3
        sourceBtn.TagJump = obj.Text
        sourceBtn = Nothing
    End Sub

    Private Sub SavePageConfig(Optional ByVal pagelist As List(Of iButton) = Nothing)
        If IsNothing(pagelist) Then pagelist = Me.pageButtonList.ToList
        Dim num As Byte, tmpStr As String

        For Each item As iButton In pagelist
            If item.Checked Then
                For Each btn As iButton In JoyButtonList()
                    tmpStr = btn.Name.Replace("btnJoyStick", "")
                    If tmpStr = "L" Then
                        num = 98
                    ElseIf tmpStr = "R" Then
                        num = 99
                    Else
                        num = CByte(tmpStr)
                    End If
                    If btn.Text = "" AndAlso btn.ALT = False AndAlso btn.SHIFT = False AndAlso btn.CTRL = False AndAlso btn.AutoFire = False AndAlso btn.AutoLock = False AndAlso btn.JumpMode = 0 Then
                        page(item.Tag, num, cbJob) = Nothing
                    Else
                        If IsNothing(page(item.Tag, num, cbJob)) Then page(item.Tag, num, cbJob) = New Dictionary(Of String, String)
                        With page(item.Tag, num, cbJob)
                            .Item("Text") = btn.Text
                            .Item("ALT") = btn.ALT
                            .Item("SHIFT") = btn.SHIFT
                            .Item("CTRL") = btn.CTRL
                            .Item("Tag") = btn.Tag
                            .Item("TagJump") = btn.TagJump
                            .Item("AutoFire") = btn.AutoFire
                            .Item("AutoLock") = btn.AutoLock
                            .Item("Remind") = btn.Remind
                            .Item("JumpMode") = btn.JumpMode
                        End With
                    End If
                Next
            End If
        Next
    End Sub

    Private Sub switchPage(obj As iButton)
        Dim pagelist As List(Of iButton) = Me.pageButtonList.ToList
        Dim num As Byte

        Try
            For Each t In safeBtn
                Call joyUp(t)
            Next
        Catch ex As Exception
            Console.WriteLine("Error:{0}", ex.Message)
        End Try

        btWaitHandle.Reset()

        obj.Checked = True
        pagelist.Remove(obj)

        JmpAMnuItem.DropDownItems.Clear()
        JmpSMnuItem.DropDownItems.Clear()
        JmpCMnuItem.DropDownItems.Clear()
        For i = 1 To pageButtonList.Count
            JmpAMnuItem.DropDownItems.Add(i, Nothing, New EventHandler(AddressOf jmpAPageMenu_Click))
            JmpSMnuItem.DropDownItems.Add(i, Nothing, New EventHandler(AddressOf jmpSPageMenu_Click))
            JmpCMnuItem.DropDownItems.Add(i, Nothing, New EventHandler(AddressOf jmpCPageMenu_Click))
        Next
        Dim j As Byte = CInt(obj.Text) - 1
        JmpAMnuItem.DropDownItems(j).Enabled = False
        JmpAMnuItem.DropDownItems(j).BackColor = Color.Gray
        JmpSMnuItem.DropDownItems(j).Enabled = False
        JmpSMnuItem.DropDownItems(j).BackColor = Color.Gray
        JmpCMnuItem.DropDownItems(j).Enabled = False
        JmpCMnuItem.DropDownItems(j).BackColor = Color.Gray

        For Each item As iButton In pagelist
            If item.Checked Then SavePageConfig(pagelist) : item.Checked = False
        Next

        Dim ReserveList As New ArrayList
        Dim tmpStr As String
        For Each btn As iButton In JoyButtonList()
            Try
                tmpStr = btn.Name.Replace("btnJoyStick", "")
                If tmpStr = "L" Then
                    num = 98
                ElseIf tmpStr = "R" Then
                    num = 99
                Else
                    num = CByte(tmpStr)
                End If

                If IsNothing(page(obj.Tag, num, cbJob)) Then
                    btn.Text = Nothing
                    btn.ALT = False
                    btn.SHIFT = False
                    btn.CTRL = False
                    btn.Tag = Nothing
                    btn.TagJump = Nothing
                    btn.AutoFire = False
                    btn.AutoLock = False
                    btn.Remind = False
                    btn.JumpMode = 0
                Else
                    With page(obj.Tag, num, cbJob)
                        btn.Text = .Item("Text")
                        btn.ALT = .Item("ALT")
                        btn.SHIFT = .Item("SHIFT")
                        btn.CTRL = .Item("CTRL")
                        btn.Tag = .Item("Tag")
                        btn.TagJump = .Item("TagJump")
                        btn.AutoFire = .Item("AutoFire")
                        btn.AutoLock = .Item("AutoLock")
                        btn.Remind = .Item("Remind")
                        btn.JumpMode = .Item("JumpMode")
                    End With
                End If
            Catch ex As Exception
            End Try

            If burstList.Contains(num) AndAlso btn.AutoFire AndAlso btn.AutoLock Then
                ReserveList.Add(num)
            End If
        Next

        burstList.Clear()
        burstList.AddRange(ReserveList)
        btWaitHandle.Set()

        currentPage = obj.Tag
    End Sub

    Private Sub copySwitch(obj As iButton, Optional pge As String = Nothing)
        Dim num As Byte, tmpPage As String

        Try
            For Each t In safeBtn
                Call joyUp(t)
            Next
        Catch ex As Exception
            Console.WriteLine("Error:{0}", ex.Message)
        End Try

        btWaitHandle.Reset()

        Dim ReserveList As New ArrayList
        Dim tmpStr As String
        Dim safeButtonList As List(Of iButton) = JoyButtonList.ToList
        safeButtonList.Remove(obj)

        If IsNothing(pge) Then tmpPage = currentPage Else tmpPage = pge

        For Each btn As iButton In safeButtonList
            tmpStr = btn.Name.Replace("btnJoyStick", "")
            If tmpStr = "L" Then
                num = 98
            ElseIf tmpStr = "R" Then
                num = 99
            Else
                num = CByte(tmpStr)
            End If

            If IsNothing(page(tmpPage, num, cbJob)) Then
                btn.Invoke(Sub()
                               btn.Text = Nothing
                               btn.ALT = False
                               btn.SHIFT = False
                               btn.CTRL = False
                               btn.Tag = Nothing
                               btn.TagJump = Nothing
                               btn.AutoFire = False
                               btn.AutoLock = False
                               btn.JumpMode = 0
                           End Sub)
            Else
                With page(tmpPage, num, cbJob)
                    btn.Invoke(Sub()
                                   btn.Text = .Item("Text")
                                   btn.ALT = .Item("ALT")
                                   btn.SHIFT = .Item("SHIFT")
                                   btn.CTRL = .Item("CTRL")
                                   btn.Tag = .Item("Tag")
                                   btn.TagJump = .Item("TagJump")
                                   btn.AutoFire = .Item("AutoFire")
                                   btn.AutoLock = .Item("AutoLock")
                                   btn.Remind = .Item("Remind")
                                   btn.JumpMode = .Item("JumpMode")
                               End Sub)
                End With
            End If
            If burstList.Contains(num) AndAlso btn.AutoFire AndAlso btn.AutoLock Then
                ReserveList.Add(num)
            End If
        Next

        burstList.Clear()
        burstList.AddRange(ReserveList)
        btWaitHandle.Set()
    End Sub

    Private Sub btnPage_CheckedChanged(sender As Object, e As EventArgs)
        Dim obj As iButton = CType(sender, iButton)
        If obj.Checked = True Then switchPage(obj)
    End Sub

    Private Sub btnPage_MouseDown(sender As Object, e As MouseEventArgs)
        Dim obj As iButton = CType(sender, iButton)
        If e.Button = MouseButtons.Right Then obj.PerformClick()
    End Sub

    Private Sub ConfigBox1_TextChanged(sender As Object, e As EventArgs) Handles ConfigBox1.TextChanged
        ReDim page(8, 99, 13)

        If ConfigBox1.Text.Replace(" ", "") = "" Then
            ConfigBox1_Update()
        Else
            Dim rtn As Boolean = readXML(ConfigBox1.Text)
            If rtn = False Then writeXML(ConfigBox1.Text)
        End If

        btnPage1.PerformClick()
        switchPage(btnPage1)
    End Sub

    Private Sub ConfigBox1_Update()
        Dim mFileInfo As System.IO.FileInfo
        Dim mDirInfo As New System.IO.DirectoryInfo(Application.StartupPath)
        For Each mFileInfo In mDirInfo.GetFiles("*.xmlprofile")
            ConfigBox1.Items.Add(System.IO.Path.GetFileNameWithoutExtension(mFileInfo.Name))
        Next

        If ConfigBox1.Items.Count <= 0 Then ConfigBox1.Items.Add("Config1")
        ConfigBox1.SelectedIndex = 0
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

#Region "隐藏到托盘"
    Private Sub hideForm()
        'ShowInTaskbar = False                   '不在任务栏显示
        Visible = False
    End Sub
    '显示form
    Private Sub showForm()
        Visible = True
        'ShowInTaskbar = True                   '在任务栏显示
        WindowState = FormWindowState.Normal   '因为之前最小化了,现在要恢复为常规窗体显示

        If IsNothing(currentPage) <> False Then
            Dim btn As iButton = GetControlByName("btnPage" & currentPage)
            btn.PerformClick()
        End If
    End Sub
#End Region

    Private Sub 打开主窗口ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开主窗口ToolStripMenuItem.Click
        Call showForm()
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick
        Call showForm()
    End Sub

    Private Sub MainForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        If WindowState = FormWindowState.Minimized Then Call hideForm()
    End Sub

    Private Sub 退出ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem1.Click
        End
    End Sub

    Private Sub 保存设置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存配置ToolStripMenuItem.Click
        SavePageConfig()
        writeXML(ConfigBox1.Text)
        ToolTip1.Show("已经保存", btnProfile, 0, -70, 2000)
    End Sub

    Private Sub 重命名ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 重命名ToolStripMenuItem.Click
        Dim pName = InputBox("输入重命名的名称", "重命名", ConfigBox1.Text)
        If pName <> Nothing Then
            FileSystem.Rename(Application.StartupPath.Trim & "\" & ConfigBox1.Text & ".xmlprofile", pName & ".xmlprofile")
            ConfigBox1.Items.Insert(ConfigBox1.SelectedIndex, pName)
            ConfigBox1.Items.Remove(ConfigBox1.Text)
            ConfigBox1.SelectedItem = pName
        End If
    End Sub

    Private Sub 另存为ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 另存为ToolStripMenuItem.Click
        Dim pName = InputBox("输入配置名称", "另存为...", ConfigBox1.Text & "副本")
        If pName <> Nothing Then
            writeXML(pName)
            ConfigBox1.Items.Add(pName)
            ConfigBox1.SelectedItem = pName
        End If
    End Sub

    Private Sub 添加配置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 添加配置ToolStripMenuItem.Click
        Dim pName = InputBox("输入新的配置名称", "添加配置", "Config" & (ConfigBox1.Items.Count + 1))
        If pName <> Nothing Then
            ConfigBox1.Items.Add(pName)
            ConfigBox1.SelectedItem = pName
            ReDim page(8, 99, 13)
            btnPage1.PerformClick()
            writeXML(pName)
        End If
    End Sub

    Private Sub 删除配置ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除配置ToolStripMenuItem.Click
        Dim p = MsgBox("是否确认删除当前配置？", MsgBoxStyle.Exclamation Or MsgBoxStyle.OkCancel, "删除配置")
        If p = MsgBoxResult.Ok Then
            Dim fpath = Application.StartupPath.Trim & "\" & ConfigBox1.Text & ".xmlprofile"
            If IO.File.Exists(fpath) Then
                '删除文件file的方法1:删除到回收站里面。
                My.Computer.FileSystem.DeleteFile(fpath, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.DoNothing)
                '删除文件file的方法2:直接从硬盘上删除。
                'IO.File.Delete(fpath)
            End If

            Dim t = ConfigBox1.SelectedIndex
            ConfigBox1.Items.Remove(ConfigBox1.SelectedItem)
            If ConfigBox1.Items.Count = 0 Then ConfigBox1.Items.Add("Config1")
            If t >= 1 Then ConfigBox1.SelectedIndex = t - 1 Else ConfigBox1.SelectedIndex = 0
        End If
    End Sub

    Private Sub 打开配置文件夹ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开配置文件夹ToolStripMenuItem.Click
        System.Diagnostics.Process.Start(Application.StartupPath.Trim)
    End Sub

    Private Sub pageMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles pageMenu.Opening
        sourceBtn = pageMenu.SourceControl
        复制页ToolStripMenuItem.DropDownItems.Clear()
        For i = 1 To pageButtonList.Count
            If i = Int(sourceBtn.Tag) Then Continue For
            复制页ToolStripMenuItem.DropDownItems.Add(i, Nothing, New EventHandler(AddressOf copyPageMenu_Click))
        Next
    End Sub

    Private Sub copyPageMenu_Click(sender As Object, e As EventArgs)
        Dim obj As ToolStripMenuItem = CType(sender, ToolStripMenuItem)
        Dim num As Byte, tmpStr As String

        SavePageConfig()
        For Each btn As iButton In JoyButtonList()
            tmpStr = btn.Name.Replace("btnJoyStick", "")
            If tmpStr = "L" Then
                num = 98
            ElseIf tmpStr = "R" Then
                num = 99
            Else
                num = CByte(tmpStr)
            End If
            If IsNothing(page(obj.Text, num, cbJob)) Then
                If IsNothing(page(sourceBtn.Tag, num, cbJob)) Then
                    Continue For
                Else
                    With page(sourceBtn.Tag, num, cbJob)
                        If .Item("JumpMode") = 2 Then JmpRefine(btn)
                        .Item("Text") = Nothing
                        .Item("ALT") = False
                        .Item("SHIFT") = False
                        .Item("CTRL") = False
                        .Item("Tag") = Nothing
                        .Item("TagJump") = Nothing
                        .Item("AutoFire") = False
                        .Item("AutoLock") = False
                        .Item("Remind") = False
                        .Item("JumpMode") = 0
                    End With
                End If
            Else
                If IsNothing(page(sourceBtn.Tag, num, cbJob)) Then page(sourceBtn.Tag, num, cbJob) = New Dictionary(Of String, String)
                Dim target As Dictionary(Of String, String) = page(obj.Text, num, cbJob)
                With page(sourceBtn.Tag, num, cbJob)
                    .Item("Text") = target.Item("Text")
                    .Item("ALT") = target.Item("ALT")
                    .Item("SHIFT") = target.Item("SHIFT")
                    .Item("CTRL") = target.Item("CTRL")
                    .Item("Tag") = target.Item("Tag")
                    .Item("AutoFire") = target.Item("AutoFire")
                    .Item("AutoLock") = target.Item("AutoLock")
                    .Item("Remind") = target.Item("Remind")
                    If .ContainsKey("JumpMode") AndAlso .Item("JumpMode") = 2 Then JmpRefine(btn)
                    Dim tmpA As Integer = target.Item("JumpMode")
                    If tmpA = 2 Then
                        tJump = 1
                    Else
                        tJump = tmpA
                    End If
                    If target.Item("TagJump") = sourceBtn.Tag Then
                        .Item("TagJump") = Nothing
                        tJump = 0
                    Else
                        .Item("TagJump") = target.Item("TagJump")
                    End If
                    .Item("JumpMode") = tJump
                End With
            End If
        Next
        switchPage(sourceBtn)
    End Sub

    Private Sub 清除页ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 清除页ToolStripMenuItem.Click
        Dim obj As iButton = pageMenu.SourceControl
        Dim num As Byte, tmpStr As String

        For Each btn As iButton In JoyButtonList()
            tmpStr = btn.Name.Replace("btnJoyStick", "")
            If tmpStr = "L" Then
                num = 98
            ElseIf tmpStr = "R" Then
                num = 99
            Else
                num = CByte(tmpStr)
            End If
            If IsNothing(btn) = False AndAlso btn.JumpMode = 2 Then JmpRefine(btn)
            page(obj.Tag, num, cbJob) = Nothing
        Next
        switchPage(obj)
    End Sub

    Private Sub jobMenu_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles jobMenu.Opening
        AutoSwitchMnuItem.Checked = TimerScanMemory.Enabled
        For Each mnu As ToolStripItem In AddJobMnuItem.DropDownItems
            If TypeOf mnu Is ToolStripSeparator Then Continue For
            If jobMenu.Items.ContainsKey(mnu.Text) Then mnu.Enabled = False Else mnu.Enabled = True
        Next
    End Sub

    Private Sub AddJob_Click(sender As Object, e As EventArgs)
        Dim mnu As New ToolStripMenuItem()
        mnu.Text = CType(sender, ToolStripMenuItem).Text
        mnu.Image = CType(sender, ToolStripMenuItem).Image
        mnu.Name = CType(sender, ToolStripMenuItem).Text
        mnu.DropDownItems.Add("删除")
        jobMenu.Items.Insert(jobMenu.Items.Count - 3, mnu)
        AddHandler mnu.Click, AddressOf Job_Click
        AddHandler mnu.CheckedChanged, AddressOf Job_CheckedChanged
        AddHandler mnu.DropDownItems.Item(0).Click, AddressOf JobDelelte_Click
    End Sub

    Private Sub Job_Click(sender As Object, e As EventArgs) Handles 通用.Click
        AutoSwitchMnuItem.Checked = False
        SelectJob(CType(sender, ToolStripMenuItem).Text)
    End Sub

    Private Sub Job_CheckedChanged(sender As Object, e As EventArgs) Handles 通用.CheckedChanged
        If CType(sender, ToolStripMenuItem).Checked = True Then btnJob.Text = CType(sender, ToolStripMenuItem).Text
    End Sub

    Private Sub JobDelelte_Click(sender As Object, e As EventArgs)
        Dim mnu As ToolStripMenuItem = CType(sender, ToolStripMenuItem).OwnerItem
        If CType(mnu, ToolStripMenuItem).Checked = True Then SelectJob("通用")
        jobMenu.Items.Remove(mnu)
    End Sub

    Private Structure JobEnum
        Const 骑士 = 19
        Const 战士 = 21
        Const 黑骑 = 32
        Const 白魔 = 24
        Const 学者 = 28
        Const 占星 = 33
        Const 武僧 = 20
        Const 龙骑 = 22
        Const 忍者 = 30
        Const 诗人 = 23
        Const 机工 = 31
        Const 黑魔 = 25
        Const 召唤 = 27
    End Structure

    Private Function Job2Value(job As String) As Byte
        Dim ret As Byte
        Select Case job
            Case "通用"
                ret = 0
            Case "骑士"
                ret = 1
            Case "战士"
                ret = 2
            Case "黑骑"
                ret = 3
            Case "白魔"
                ret = 4
            Case "学者"
                ret = 5
            Case "占星"
                ret = 6
            Case "武僧"
                ret = 7
            Case "龙骑"
                ret = 8
            Case "忍者"
                ret = 9
            Case "诗人"
                ret = 10
            Case "机工"
                ret = 11
            Case "黑魔"
                ret = 12
            Case "召唤"
                ret = 13
            Case Else
                Console.WriteLine("未知职业:{0}", job)
                ret = 0
        End Select
        Return ret
    End Function

    Private Function Job2MemCode(id As String) As Byte
        Dim arr() = GetType(JobEnum).GetFields
        Dim item As FieldInfo = Array.Find(Of FieldInfo)(arr, Function(x) (x.Name = id))

        If item IsNot Nothing Then Return item.GetValue(New JobEnum)
        Return 0
    End Function

    Private Function MemCode2Job(code As Byte) As String
        Dim arr() = GetType(JobEnum).GetFields
        Dim item As FieldInfo = Array.Find(Of FieldInfo)(arr, Function(x) (x.GetValue(New JobEnum) = code))

        If item IsNot Nothing Then Return item.Name
        Return "通用"
    End Function

    Private Sub TimerScanMemory_Tick(sender As Object, e As EventArgs) Handles TimerScanMemory.Tick
        Dim rMem As New ReadMemory("FFXIVGAME")

        Dim jobID As Integer
        If rMem.IsWow64 = True Then
            jobID = rMem.ReadInt64(&H15F5DF0) 'DX11地址
        Else
            jobID = rMem.ReadInt32(&HFE04B4)  'DX9地址
        End If

        If jobID <> -1 Then
            SelectJob(MemCode2Job(jobID))
        End If

        rMem = Nothing
    End Sub

    Private Sub SelectJob(job As String)
        Dim flag As Boolean， noswitch As Boolean
        cbJob = Job2Value(job)

        If job = btnJob.Text Then Exit Sub

        For Each mnu As ToolStripItem In jobMenu.Items
            If jobMenu.Items.IndexOf(mnu) = jobMenu.Items.Count - 3 Then Exit For
            If TypeOf mnu Is ToolStripSeparator Then Continue For
            If mnu.Text = job Then
                flag = True
                CType(mnu, ToolStripMenuItem).Checked = True
            Else
                CType(mnu, ToolStripMenuItem).Checked = False
            End If
        Next

        If flag = False Then
            If btnJob.Text = "通用" Then noswitch = True
            cbJob = 0
            CType(jobMenu.Items("通用"), ToolStripMenuItem).Checked = True
            If noswitch = False Then switchPage(GetControlByName("btnPage" & currentPage))
        End If

        If job = btnJob.Text Then switchPage(GetControlByName("btnPage" & currentPage))
    End Sub

    Private Sub btnJob_MouseUp(sender As Object, e As MouseEventArgs) Handles btnJob.MouseUp
        jobMenu.Show(MousePosition)
    End Sub

    Private Sub btnProfile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnProfile.MouseUp
        profileMenu.Show(MousePosition)
    End Sub

    Private Sub AutoSwitchMnuItem_CheckedChanged(sender As Object, e As EventArgs) Handles AutoSwitchMnuItem.CheckedChanged
        TimerScanMemory.Enabled = AutoSwitchMnuItem.Checked
        btnJob.CheckBox = AutoSwitchMnuItem.Checked
        btnJob.Checked = AutoSwitchMnuItem.Checked
    End Sub

End Class
