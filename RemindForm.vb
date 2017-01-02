Imports System.Security.Permissions
Imports System.Threading

Public Class RemindForm
    Private Const WS_EX_NOACTIVATE As Int32 = &H8000000
    Private Const WS_EX_LAYERED As Int32 = &H80000
    Private Const WS_EX_TOOLWINDOW As Int32 = &H80

    Private Const WS_POPUP As Int32 = &H80000000


    Dim X, Y As Integer
    Dim int As Integer = 0
    Dim dir As Boolean
    Private BP As Bitmap
    Dim FT As Font = New Font("Webdings", 50, FontStyle.Regular, GraphicsUnit.Pixel)

    Dim stopwatch = New Stopwatch()

    Private Sub ShowReminder(ByVal Text As String, ByVal s As Double)
        If BP IsNot Nothing Then BP.Dispose() '释放旧图片
        BP = New Bitmap(Me.Width, Me.Height)
        Using G As Graphics = Graphics.FromImage(BP)
            G.SmoothingMode = Drawing2D.SmoothingMode.HighQuality
            G.CompositingMode = Drawing2D.CompositingMode.SourceOver
            G.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAliasGridFit
            X = 10 : Y = 10
            '绘制阴影
            For J As Integer = 1 To 4
                Using lg As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, 1), Color.FromArgb(90 - 90 / 5 * J, 0, 0, 0), Color.FromArgb(100 - J * 20, 0, 0, 0))
                    G.DrawString(Text, FT, lg, X + J, Y + J)
                End Using
            Next
            '绘制光晕
            For I As Integer = 1 To 4
                Using lg As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, 1), Color.FromArgb((90 - 90 / 5 * I) * s, Color.LightYellow), Color.FromArgb((90 - 90 / 5 * I) * s, Color.LightYellow))
                    G.DrawString(Text, FT, lg, X - I, Y)
                    G.DrawString(Text, FT, lg, X - I, Y - I)
                    G.DrawString(Text, FT, lg, X, Y - I)
                    G.DrawString(Text, FT, lg, X + I, Y - I)
                    G.DrawString(Text, FT, lg, X + I, Y)
                    G.DrawString(Text, FT, lg, X + I, Y + I)
                    G.DrawString(Text, FT, lg, X, Y + I)
                    G.DrawString(Text, FT, lg, X - I, Y + I)
                End Using
            Next
            '绘制轮廓
            For I As Integer = 1 To 2
                Using lg As New Drawing2D.LinearGradientBrush(New Point(0, 0), New Point(0, 1), Color.FromArgb(90 - 90 / 3 * I, 0, 0, 0), Color.FromArgb(90 - 90 / 3 * I, 0, 0, 0))
                    G.DrawString(Text, FT, lg, X - I, Y)
                    G.DrawString(Text, FT, lg, X - I, Y - I)
                    G.DrawString(Text, FT, lg, X, Y - I)
                    G.DrawString(Text, FT, lg, X + I, Y - I)
                    G.DrawString(Text, FT, lg, X + I, Y)
                    G.DrawString(Text, FT, lg, X + I, Y + I)
                    G.DrawString(Text, FT, lg, X, Y + I)
                    G.DrawString(Text, FT, lg, X - I, Y + I)
                End Using
            Next
            '绘制前景
            Using lg As New Drawing2D.LinearGradientBrush(New Point(X, Y), New Point(X, Y + FT.Height), Color.YellowGreen, Color.DarkGreen)
                G.DrawString(Text, FT, lg, X, Y)
            End Using
        End Using
        Me.BackgroundImage = BP
        DrawBP(Me, BP, 180)
    End Sub

    Private Sub RemindForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If MainForm.RemindPos <> Nothing Then Me.Location = MainForm.RemindPos
        stopwatch.Start()
    End Sub
    Private Sub RemindForm_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        ReleaseCapture()
        SendMessage(sender.Handle.ToInt32(), WM_SysCommand, SC_MOVE, 0)
    End Sub
    Protected Overloads Overrides ReadOnly Property CreateParams() As CreateParams
        <PermissionSetAttribute(SecurityAction.LinkDemand, Name:="FullTrust")>
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            cp.Style = WS_POPUP
            cp.ExStyle = WS_EX_TOOLWINDOW Or WS_EX_NOACTIVATE Or WS_EX_LAYERED
            Return cp
        End Get
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ShowReminder("N", Math.Abs(Math.Cos(stopwatch.ElapsedMilliseconds * 0.001)))
    End Sub

    Private Sub RemindForm_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        MainForm.RemindPos = Me.Location
    End Sub
End Class