Imports System.Runtime.InteropServices
Imports System.Threading
Module keyboard_event
    Const ShiftKey As Short = 16
    Const ControlKey As Short = 17
    Const AltKey As Short = 18
    Public Class WaitOne

        Shared autoEvent As New AutoResetEvent(False)

        <MTAThread()> _
        Shared Sub Press(ByVal str As String)
            kbDownChar(str)

            ThreadPool.QueueUserWorkItem(AddressOf WorkMethod, autoEvent)
            ' Wait for work method to signal.
            autoEvent.WaitOne()

            kbUpChar(str)
        End Sub

        Shared Sub WorkMethod(ByVal stateInfo As Object)
            ' Simulate time spent working.
            Thread.Sleep(20)
            ' Signal that work is finished.
            CType(stateInfo, AutoResetEvent).Set()
        End Sub

    End Class
    Public Function GetKeyboardCode(ByVal value As Char) As Int32
        Dim scan = BitConverter.GetBytes(NativeMethods.VkKeyScan(value))
        Return CInt(scan(0))
    End Function
    Public Sub kbDownChar(ByVal str As String)
        If IsNothing(str) OrElse str = "" Then Exit Sub
        Dim keys As Array
        keys = str.ToUpper().Split("+")

        For Each i As String In keys
            Select Case i
                Case "SHIFT" 'Contain Shift
                    kbDown(ShiftKey)
                Case "CTRL" ' Contain Ctrl
                    kbDown(ControlKey)
                Case "ALT" ' Contain Alt
                    kbDown(AltKey)
                Case Else
                    kbDown(CShort(i))
            End Select
        Next
    End Sub
    Public Sub kbUpChar(ByVal str As String)
        If IsNothing(str) OrElse str = "" Then Exit Sub
        Dim keys As Array
        keys = str.ToUpper().Split("+")

        For Each i As String In keys
            Select Case i
                Case "SHIFT" 'Contain Shift
                    kbUp(ShiftKey)
                Case "CTRL" ' Contain Ctrl
                    kbUp(ControlKey)
                Case "ALT" ' Contain Alt
                    kbUp(AltKey)
                Case Else
                    kbUp(CShort(i))
            End Select
        Next
    End Sub
    Public Sub kbPressChar(ByVal str As String)
        If IsNothing(str) = False AndAlso str <> "" Then WaitOne.Press(str)
    End Sub
    Public Function kbDown(ByVal vault As Byte) As Int32
        Dim code As Byte = vault
        NativeMethods.keybd_event(code, NativeMethods.MapVirtualKey(code, MapVirtualKeyMapTypes.MAPVK_VK_TO_VSC), 0, 0)
        Return CInt(code)
    End Function
    Public Function kbUp(ByVal vault As Byte) As Int32
        Dim code As Byte = vault
        NativeMethods.keybd_event(code, NativeMethods.MapVirtualKey(code, MapVirtualKeyMapTypes.MAPVK_VK_TO_VSC), KEYEVENTF_KEYUP, 0)
        Return CInt(code)
    End Function
    Public Function SendStringKeys(ByVal data As String) As Boolean
        If data Is Nothing Then Return False
        Dim tempList = New List(Of tagINPUT)
        Dim tempList2 = New List(Of tagINPUT)

        Dim keys As Array
        keys = data.ToUpper().Split("+")

        For Each i As String In keys
            Select Case i
                Case "SHIFT" 'Contain Shift
                    tempList.Add(GetKeyDownStructure(ShiftKey))
                    tempList2.Add(GetKeyUpStructure(ShiftKey))
                Case "CTRL" ' Contain Ctrl
                    tempList.Add(GetKeyDownStructure(ControlKey))
                    tempList2.Add(GetKeyUpStructure(ControlKey))
                Case "ALT" ' Contain Alt
                    tempList.Add(GetKeyDownStructure(AltKey))
                    tempList2.Add(GetKeyUpStructure(AltKey))
                Case Else
                    tempList.Add(GetKeyDownStructure(CShort(i)))
                    tempList2.Add(GetKeyUpStructure(CShort(i)))
            End Select
        Next
        Dim objSend = tempList.ToArray
        Dim nInput = CUInt(objSend.Count)
        nInput = NativeMethods.SendInput(CUInt(objSend.Count), objSend, Marshal.SizeOf(objSend(0)))

        Dim objSend2 = tempList2.ToArray
        Dim nInput2 = CUInt(objSend2.Count)
        Return nInput2 = NativeMethods.SendInput(CUInt(objSend2.Count), objSend2, Marshal.SizeOf(objSend2(0)))
    End Function

    Public Function SendKeyPress(ByVal key As Int32) As Boolean
        If ValidateKeyCode(key) = False Then Throw New ArgumentOutOfRangeException("key")
        Dim objSend() As tagINPUT = {GetKeyDownStructure(CShort(key))}
        Dim nInput = CUInt(objSend.Count)
        nInput = NativeMethods.SendInput(CUInt(objSend.Count), objSend, Marshal.SizeOf(objSend(0)))

        Dim objSend2() As tagINPUT = {GetKeyUpStructure(CShort(key))}
        Dim nInput2 = CUInt(objSend.Count)
        Return nInput2 = NativeMethods.SendInput(CUInt(objSend2.Count), objSend2, Marshal.SizeOf(objSend2(0)))
    End Function

    Public Function SendKeyUp(ByVal key As Int32) As Boolean
        If ValidateKeyCode(key) = False Then Throw New ArgumentOutOfRangeException("key")
        Dim objSend = New tagINPUT(0) {GetKeyUpStructure(CShort(key))}
        Dim nInput = CUInt(objSend.Count)
        Return nInput = NativeMethods.SendInput(CUInt(objSend.Count), objSend, Marshal.SizeOf(objSend(0)))
    End Function

    Public Function SendKeyDown(ByVal key As Int32) As Boolean
        If ValidateKeyCode(key) = False Then Throw New ArgumentOutOfRangeException("key")
        Dim objSend = New tagINPUT(0) {GetKeyDownStructure(CShort(key))}
        Dim nInput = CUInt(objSend.Count)
        Return nInput = NativeMethods.SendInput(CUInt(objSend.Count), objSend, Marshal.SizeOf(objSend(0)))
    End Function

    Private Function GetKeyDownStructure(ByVal key As Short) As tagINPUT
        Dim retVal = New tagINPUT With {.dwType = INPUTTYPE.KEYBOARD}
        With retVal.union.ki
            .dwExtraInfo = Nothing
            .dwFlags = 0
            .time = 10
            .wScan = 0
            .wVk = key
        End With
        Return retVal
    End Function

    Private Function GetKeyUpStructure(ByVal key As Short) As tagINPUT
        Dim retVal = New tagINPUT With {.dwType = INPUTTYPE.KEYBOARD}
        With retVal.union.ki
            .dwExtraInfo = Nothing
            .dwFlags = KEYEVENTF.KEYUP
            .time = 10
            .wScan = 0
            .wVk = key
        End With
        Return retVal
    End Function

    Public Function ValidateKeyCode(ByVal key As Int32) As Boolean
        If key < 1 OrElse key > 254 Then Return False
        Return True
    End Function


#Region "Structures"

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure tagHARDWAREINPUT
        Public uMsg As Int32
        Public wParamL As Int16
        Public wParamH As Int16
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure tagKEYBDINPUT
        Public wVk As Int16
        Public wScan As Int16
        Public dwFlags As KEYEVENTF
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure tagMOUSEINPUT
        Public dx As Int32
        Public dy As Int32
        Public mouseData As Int32
        Public dwFlags As MOUSEEVENTF
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Friend Structure tagINPUT
        Public dwType As INPUTTYPE
        Public union As UnionTag
        <StructLayout(LayoutKind.Explicit)>
        Public Structure UnionTag
            <FieldOffset(0)> Public mi As tagMOUSEINPUT
            <FieldOffset(0)> Public ki As tagKEYBDINPUT
            <FieldOffset(0)> Public hi As tagHARDWAREINPUT
        End Structure
    End Structure

#End Region

#Region "Enumerations"

    Friend Enum INPUTTYPE As UInt32
        MOUSE = 0
        KEYBOARD = 1
        HARDWARE = 2
    End Enum

    <Flags()>
    Friend Enum MOUSEEVENTF As UInt32
        MOVE = &H1  ' mouse move 
        LEFTDOWN = &H2  ' left button down 
        LEFTUP = &H4  ' left button up 
        RIGHTDOWN = &H8  ' right button down 
        RIGHTUP = &H10  ' right button up 
        MIDDLEDOWN = &H20  ' middle button down 
        MIDDLEUP = &H40  ' middle button up 
        XDOWN = &H80  ' x button down 
        XUP = &H100  ' x button down 
        WHEEL = &H800  ' wheel button rolled 
        HWHEEL = &H1000  ' hwheel button rolled 
        MOVE_NOCOALESCE = &H2000  ' do not coalesce mouse moves 
        VIRTUALDESK = &H4000  ' map to entire virtual desktop 
        ABSOLUTE = &H8000  ' absolute move 
    End Enum

    <Flags()>
    Friend Enum KEYEVENTF As UInt32
        EXTENDEDKEY = &H1
        KEYUP = &H2
        UNICODE = &H4
        SCANCODE = &H8
    End Enum
    Public Enum MapVirtualKeyMapTypes As UInt32
        ''' <summary>uCode is a virtual-key code and is translated into a scan code.
        ''' If it is a virtual-key code that does not distinguish between left- and 
        ''' right-hand keys, the left-hand scan code is returned. 
        ''' If there is no translation, the function returns 0.
        ''' </summary>
        ''' <remarks></remarks>
        MAPVK_VK_TO_VSC = &H0

        ''' <summary>uCode is a scan code and is translated into a virtual-key code that
        ''' does not distinguish between left- and right-hand keys. If there is no 
        ''' translation, the function returns 0.
        ''' </summary>
        ''' <remarks></remarks>
        MAPVK_VSC_TO_VK = &H1

        ''' <summary>uCode is a virtual-key code and is translated into an unshifted
        ''' character value in the low-order word of the return value. Dead keys (diacritics)
        ''' are indicated by setting the top bit of the return value. If there is no
        ''' translation, the function returns 0.
        ''' </summary>
        ''' <remarks></remarks>
        MAPVK_VK_TO_CHAR = &H2

        ''' <summary>Windows NT/2000/XP: uCode is a scan code and is translated into a
        ''' virtual-key code that distinguishes between left- and right-hand keys. If
        ''' there is no translation, the function returns 0.
        ''' </summary>
        ''' <remarks></remarks>
        MAPVK_VSC_TO_VK_EX = &H3

        ''' <summary>Not currently documented
        ''' </summary>
        ''' <remarks></remarks>
        MAPVK_VK_TO_VSC_EX = &H4
    End Enum
#End Region

#Region "注册键盘"
    Public Const KEYEVENTF_EXTENDEDKEY As Integer = &H1
    Public Const KEYEVENTF_KEYUP As Integer = &H2
    Public Const KEYEVENTF_KEYDOWN As Integer = &H0
    Public Const VK_SHIFT As Integer = &H10
    Public Const VK_SPACE As Integer = &H20
    Public Const VK_TAB As Integer = &H9
    Public Const KEY_A As Integer = &H41
    Public Const KEY_B As Integer = &H42
    Public Const KEY_C As Integer = &H43
    Public Const KEY_D As Integer = &H44
    Public Const KEY_E As Integer = &H45
    Public Const KEY_F As Integer = &H46
    Public Const KEY_G As Integer = &H47
    Public Const KEY_H As Integer = &H48
    Public Const KEY_I As Integer = &H49
    Public Const KEY_J As Integer = &H4A
    Public Const KEY_K As Integer = &H4B
    Public Const KEY_L As Integer = &H4C
    Public Const KEY_M As Integer = &H4D
    Public Const KEY_N As Integer = &H4E
    Public Const KEY_O As Integer = &H4F
    Public Const KEY_P As Integer = &H50
    Public Const KEY_Q As Integer = &H51
    Public Const KEY_R As Integer = &H52
    Public Const KEY_S As Integer = &H53
    Public Const KEY_T As Integer = &H54
    Public Const KEY_U As Integer = &H55
    Public Const KEY_V As Integer = &H56
    Public Const KEY_W As Integer = &H57
    Public Const KEY_X As Integer = &H58
    Public Const KEY_Y As Integer = &H59
    Public Const KEY_Z As Integer = &H5A
    Public Const KEY_0 As Integer = &H30
    Public Const KEY_1 As Integer = &H31
    Public Const KEY_2 As Integer = &H32
    Public Const KEY_3 As Integer = &H33
    Public Const KEY_4 As Integer = &H34
    Public Const KEY_5 As Integer = &H35
    Public Const KEY_6 As Integer = &H36
    Public Const KEY_7 As Integer = &H37
    Public Const KEY_8 As Integer = &H38
    Public Const KEY_9 As Integer = &H39
    Public Const VK_NUMPAD0 As Integer = &H60
    Public Const VK_NUMPAD1 As Integer = &H61
    Public Const VK_NUMPAD2 As Integer = &H62
    Public Const VK_NUMPAD3 As Integer = &H63
    Public Const VK_NUMPAD4 As Integer = &H64
    Public Const VK_NUMPAD5 As Integer = &H65
    Public Const VK_NUMPAD6 As Integer = &H66
    Public Const VK_NUMPAD7 As Integer = &H67
    Public Const VK_NUMPAD8 As Integer = &H68
    Public Const VK_NUMPAD9 As Integer = &H69
    Public Const VK_RETURN As Integer = &HD
    Public Const VK_OEM_PLUS As Integer = &HBB
    Public Const VK_OEM_1 As Integer = &HBA
    Public Const VK_OEM_COMMA As Integer = &HBC
    Public Const VK_OEM_MINUS As Integer = &HBD
    Public Const VK_OEM_PERIOD As Integer = &HBE
    Public Const VK_OEM_2 As Integer = &HBF
    Public Const VK_OEM_3 As Integer = &HC0
    Public Const VK_OEM_4 As Integer = &HDB
    Public Const VK_OEM_5 As Integer = &HDC
    Public Const VK_OEM_6 As Integer = &HDD
    Public Const VK_OEM_7 As Integer = &HDE
#End Region
    Private NotInheritable Class NativeMethods
        <DllImport("user32.dll", SetLastError:=True)>
        Friend Shared Function SendInput(<[In]()> ByVal nInput As UInt32,
  <[In](), MarshalAs(UnmanagedType.LPArray, ArraySubtype:=UnmanagedType.Struct, SizeParamindex:=0)> ByVal pInputs() As tagINPUT,
  <[In]()> ByVal cbInput As Int32) As UInt32
        End Function

        <DllImport("user32.dll", CallingConvention:=CallingConvention.StdCall, _
           CharSet:=CharSet.Unicode, EntryPoint:="keybd_event", _
           ExactSpelling:=True, SetLastError:=True)> _
        Public Shared Sub keybd_event(ByVal bVk As Byte, ByVal bScan As Byte, _
                              ByVal dwFlags As UInteger, ByVal dwExtraInfo As UIntPtr)
        End Sub

        <DllImport("User32.dll", SetLastError:=False, CallingConvention:=CallingConvention.StdCall, _
                   CharSet:=CharSet.Auto)> _
        Public Shared Function MapVirtualKey(ByVal uCode As UInt32, ByVal uMapType As MapVirtualKeyMapTypes) As UInt32
        End Function


        <DllImport("User32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
        Public Shared Function VkKeyScan(<[In]()> ByVal ch As Char) As UInt16
        End Function
    End Class
End Module
