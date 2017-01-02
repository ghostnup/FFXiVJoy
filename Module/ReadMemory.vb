Imports System.Runtime.InteropServices
Imports System.Security.Permissions
Imports Microsoft.Win32.SafeHandles

Public Class ReadMemory

    Public Declare Function OpenProcess Lib "kernel32" (ByVal dwDesiredAccess As ProcessAccessFlags, bInheritHandle As Boolean, processId As UInt32) As IntPtr

    <Flags>
    Public Enum ProcessAccessFlags As UInteger
        All = &H1F0FFF
        Terminate = &H1
        CreateThread = &H2
        VirtualMemoryOperation = &H8
        VirtualMemoryRead = &H10
        VirtualMemoryWrite = &H20
        DuplicateHandle = &H40
        CreateProcess = &H80
        SetQuota = &H100
        SetInformation = &H200
        QueryInformation = &H400
        QueryLimitedInformation = &H1000
        Synchronize = &H100000
    End Enum

    Public Enum WindowLongFlags As Integer
        GWL_EXSTYLE = -20
        GWLP_HINSTANCE = -6
        GWLP_HWNDPARENT = -8
        GWL_ID = -12
        GWL_STYLE = -16
        GWL_USERDATA = -21
        GWL_WNDPROC = -4
        DWLP_USER = &H8
        DWLP_MSGRESULT = &H0
        DWLP_DLGPROC = &H4
    End Enum

    <DllImport("Kernel32.dll", SetLastError:=True, CallingConvention:=CallingConvention.Winapi)>
    Public Shared Function IsWow64Process(ByVal hProcess As SafeHandleZeroOrMinusOneIsInvalid,
                                          ByRef wow64Process As Boolean) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Ansi, ExactSpelling:=True)>
    Public Shared Function GetProcAddress(ByVal hModule As IntPtr, ByVal procName As String) As IntPtr
    End Function

    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByVal lpModuleName As String) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Private Shared Function FindWindow(
    ByVal lpClassName As String,
    ByVal lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowLong")>
    Private Shared Function GetWindowLongPtr32(ByVal hWnd As HandleRef, <MarshalAs(UnmanagedType.I4)> nIndex As WindowLongFlags) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="GetWindowLongPtr")>
    Private Shared Function GetWindowLongPtr64(ByVal hWnd As HandleRef, <MarshalAs(UnmanagedType.I4)> nIndex As WindowLongFlags) As IntPtr
    End Function

    ' This static method is required because Win32 does not support GetWindowLongPtr directly
    Private Shared Function GetWindowLongPtr(ByVal hWnd As HandleRef, <MarshalAs(UnmanagedType.I4)> nIndex As WindowLongFlags) As IntPtr
        If Marshal.SizeOf(IntPtr.Zero) = 8 Then
            Return GetWindowLongPtr64(hWnd, nIndex)
        Else
            Return GetWindowLongPtr32(hWnd, nIndex)
        End If
    End Function

    <DllImport("user32.dll", SetLastError:=True)>
    Private Shared Function GetWindowThreadProcessId(ByVal hwnd As IntPtr,
                                                 ByRef lpdwProcessId As Integer) As Integer
    End Function

    <DllImport("Kernel32.dll")>
    Friend Shared Function GetCurrentProcess() As IntPtr
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Private Shared Function ReadProcessMemory(
          ByVal hProcess As IntPtr,
          ByVal lpBaseAddress As IntPtr,
          <Out()> ByVal lpBuffer() As Byte,
          ByVal dwSize As Integer,
          ByRef lpNumberOfBytesRead As Integer) As Boolean
    End Function

    <DllImport("kernel32.dll", SetLastError:=True)>
    Public Shared Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private hProcess, hInstance As IntPtr
    Private _Installed As Boolean

    Public Sub New(ByVal ProcessName As String)
        Install(ProcessName)
    End Sub

    Private Function Install(ByVal ClassName As String) As Boolean
        Dim handle, pid As Integer
        handle = FindWindow(ClassName, vbNullString)
        If handle = 0 Then Return False
        GetWindowThreadProcessId(handle, pid)
        If pid = 0 Then Return False
        hProcess = OpenProcess(ProcessAccessFlags.All, False, pid)
        If hProcess = 0 Then Return False
        hInstance = GetWindowLongPtr(New HandleRef(Me, handle), WindowLongFlags.GWLP_HINSTANCE)
        If handle = 0 Then Return False

        _Installed = True
        Return True
    End Function

    Private Sub Uninstall()
        If _Installed = False Then Return
        CloseHandle(hProcess)
    End Sub

    Public Function IsWow64() As Boolean
        If _Installed = False Then Return False

        Dim proc As Long, retVal As Boolean, result As Boolean
        Dim SafeHandle As New SafeUnmanagedMemoryHandle(hProcess, False)

        ' Now check to see if IsWow64Process function exists
        proc = GetProcAddress(GetModuleHandle("kernel32"), "IsWow64Process")

        If proc > 0 Then
            result = IsWow64Process(SafeHandle, retVal)
            If result Then
                retVal = Not retVal
            End If
        Else
            retVal = False
        End If

        Return retVal
    End Function

    <SecurityPermission(SecurityAction.Demand, UnmanagedCode:=True)>
    NotInheritable Class SafeUnmanagedMemoryHandle
        Inherits SafeHandleZeroOrMinusOneIsInvalid


        ' Set ownsHandle to true for the default constructor.
        Friend Sub New()
            MyBase.New(True)

        End Sub 'New

        ' Set the handle and set ownsHandle to true.
        Friend Sub New(ByVal preexistingHandle As IntPtr, ByVal ownsHandle As Boolean)
            MyBase.New(ownsHandle)
            SetHandle(preexistingHandle)

        End Sub 'New


        ' Perform any specific actions to release the 
        ' handle in the ReleaseHandle method.
        ' Often, you need to use Pinvoke to make
        ' a call into the Win32 API to release the 
        ' handle. In this case, however, we can use
        ' the Marshal class to release the unmanaged
        ' memory.
        Protected Overrides Function ReleaseHandle() As Boolean
            ' "handle" is the internal
            ' value for the IntPtr handle.
            ' If the handle was set,
            ' free it. Return success.
            If handle <> IntPtr.Zero Then

                ' Free the handle.
                Marshal.FreeHGlobal(handle)

                ' Set the handle to zero.
                handle = IntPtr.Zero

                ' Return success.
                Return True
            End If

            ' Return false. 
            Return False

        End Function
    End Class


    Public Function ReadInt64(ByVal address As Long) As Long
        If _Installed = False Then Return -1
        Dim h As Integer
        Dim buffer(8) As Byte
        Dim bytesRead As Integer

        h = ReadProcessMemory(hProcess, hInstance + address, buffer, 4, bytesRead)
        Uninstall()

        Return BitConverter.ToInt64(buffer, 0)
    End Function

    Public Function ReadInt32(ByVal address As Long) As Integer
        If _Installed = False Then Return -1
        Dim h As Integer
        Dim buffer(4) As Byte
        Dim bytesRead As Integer

        h = ReadProcessMemory(hProcess, hInstance + address, buffer, buffer.Length, bytesRead)
        Uninstall()

        Return BitConverter.ToInt32(buffer, 0)
    End Function

    Public Function ReadSingle(ByVal address As Long) As Single
        If _Installed = False Then Return 0
        Dim h As Integer
        Dim buffer(4) As Byte
        Dim bytesRead As Integer
        Dim ret As Single

        h = ReadProcessMemory(hProcess, hInstance + address, buffer, 4, bytesRead)
        Uninstall()

        ret = BitConverter.ToSingle(buffer, 0)
        Return ret
    End Function

    Public Function ReadDouble(ByVal address As Long) As Double
        If _Installed = False Then Return 0
        Dim h As Integer
        Dim buffer(8) As Byte
        Dim bytesRead As Integer

        h = ReadProcessMemory(hProcess, hInstance + address, buffer, 8, bytesRead)
        Uninstall()

        Return BitConverter.ToDouble(buffer, 0)
    End Function

    Public Function ReadString(ByVal address As Long) As String
        If _Installed = False Then Return vbNullString
        Dim h As Integer
        Dim buffer(32) As Byte
        Dim bytesRead As Integer

        h = ReadProcessMemory(hProcess, hInstance + address, buffer, buffer.Length, bytesRead)
        Uninstall()

        Return System.Text.UTF8Encoding.Unicode.GetString(buffer)
    End Function

End Class
