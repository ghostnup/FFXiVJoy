Imports System.Runtime.InteropServices
Imports System.Drawing.Imaging
Imports System.Drawing

Module Draw_BP
    Public Const WM_SysCommand As Integer = &H112
    Public Const SC_MOVE As Integer = &HF012
    Public Const SC_NCLBUTTONDOWN = &HA1
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function SendMessage(ByVal hWnd As Integer, ByVal Msg As UInteger, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", EntryPoint:="ReleaseCapture")> _
    Public Function ReleaseCapture() As Integer
    End Function
    Public Sub DrawBP(ByVal Forma As Object, ByVal bitmap As Bitmap, ByVal opacity As Byte)
        If bitmap.PixelFormat <> PixelFormat.Format32bppArgb Then
            Throw New ApplicationException("The bitmap must be 32ppp with alpha-channel.")
        End If
        Dim screenDc As IntPtr = Win32.GetDC(IntPtr.Zero)
        Dim memDc As IntPtr = Win32.CreateCompatibleDC(screenDc)
        Dim hBitmap As IntPtr = IntPtr.Zero
        Dim oldBitmap As IntPtr = IntPtr.Zero

        Try
            hBitmap = bitmap.GetHbitmap(Color.FromArgb(0))
            oldBitmap = Win32.SelectObject(memDc, hBitmap)
            Dim size As New Win32.Size(bitmap.Width, bitmap.Height)
            Dim pointSource As New Win32.Point(0, 0)
            Dim topPos As New Win32.Point(Forma.Left, Forma.Top)
            Dim blend As New Win32.BLENDFUNCTION()
            blend.BlendOp = Win32.AC_SRC_OVER
            blend.BlendFlags = 0
            blend.SourceConstantAlpha = opacity
            blend.AlphaFormat = Win32.AC_SRC_ALPHA

            Win32.UpdateLayeredWindow(Forma.Handle, screenDc, topPos, size, memDc, pointSource, _
            0, blend, Win32.ULW_ALPHA)
        Finally
            Win32.ReleaseDC(IntPtr.Zero, screenDc)
            If hBitmap <> IntPtr.Zero Then
                Win32.SelectObject(memDc, oldBitmap)
                Win32.DeleteObject(hBitmap)
            End If
            Win32.DeleteDC(memDc)
        End Try
    End Sub
    Public Class Win32
        Public Enum Bool
            [False] = 0
            [True]
        End Enum


        <StructLayout(LayoutKind.Sequential)> _
        Public Structure Point
            Public x As Int32
            Public y As Int32

            Public Sub New(ByVal x As Int32, ByVal y As Int32)
                Me.x = x
                Me.y = y
            End Sub
        End Structure


        <StructLayout(LayoutKind.Sequential)> _
        Public Structure Size
            Public cx As Int32
            Public cy As Int32

            Public Sub New(ByVal cx As Int32, ByVal cy As Int32)
                Me.cx = cx
                Me.cy = cy
            End Sub
        End Structure


        <StructLayout(LayoutKind.Sequential, Pack:=1)> _
        Private Structure ARGB
            Public Blue As Byte
            Public Green As Byte
            Public Red As Byte
            Public Alpha As Byte
        End Structure


        <StructLayout(LayoutKind.Sequential, Pack:=1)> _
        Public Structure BLENDFUNCTION
            Public BlendOp As Byte
            Public BlendFlags As Byte
            Public SourceConstantAlpha As Byte
            Public AlphaFormat As Byte
        End Structure


        Public Const ULW_COLORKEY As Int32 = &H1
        Public Const ULW_ALPHA As Int32 = &H2
        Public Const ULW_OPAQUE As Int32 = &H4

        Public Const AC_SRC_OVER As Byte = &H0
        Public Const AC_SRC_ALPHA As Byte = &H1


        Public Declare Auto Function UpdateLayeredWindow Lib "user32.dll" (ByVal hwnd As IntPtr, ByVal hdcDst As IntPtr, ByRef pptDst As Point, ByRef psize As Size, ByVal hdcSrc As IntPtr, ByRef pprSrc As Point, _
        ByVal crKey As Int32, ByRef pblend As BLENDFUNCTION, ByVal dwFlags As Int32) As Bool

        Public Declare Auto Function GetDC Lib "user32.dll" (ByVal hWnd As IntPtr) As IntPtr

        <DllImport("user32.dll", ExactSpelling:=True)> _
        Public Shared Function ReleaseDC(ByVal hWnd As IntPtr, ByVal hDC As IntPtr) As Integer
        End Function

        Public Declare Auto Function CreateCompatibleDC Lib "gdi32.dll" (ByVal hDC As IntPtr) As IntPtr

        Public Declare Auto Function DeleteDC Lib "gdi32.dll" (ByVal hdc As IntPtr) As Bool

        <DllImport("gdi32.dll", ExactSpelling:=True)> _
        Public Shared Function SelectObject(ByVal hDC As IntPtr, ByVal hObject As IntPtr) As IntPtr
        End Function

        Public Declare Auto Function DeleteObject Lib "gdi32.dll" (ByVal hObject As IntPtr) As Bool
    End Class
End Module

