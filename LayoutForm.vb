Imports System.Drawing.Drawing2D

Public Class LayoutForm

    Private BP As Bitmap
    Dim m_items As New ArrayList From {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        OpenFileDialog1.DefaultExt = "bmp"
        OpenFileDialog1.Filter = "BMP文件(*.bmp)|*.bmp"
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnDefault_Click(sender As Object, e As EventArgs) Handles btnDefault.Click
        Panel1.BackgroundImage = My.Resources.microsoftxbox360
    End Sub

    Private Sub LayoutForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Panel1.BackgroundImage = My.Resources.microsoftxbox360
        Dim p, p2 As New GraphicsPath
        p.AddEllipse(JoyLeft.ClientRectangle)
        p2.AddRectangle(New Rectangle(33, 0, 34, 100))
        p2.AddRectangle(New Rectangle(0, 33, 33, 34))
        p2.AddRectangle(New Rectangle(67, 33, 33, 34))

        JoyLeft.Region = New Region(p)
        JoyRight.Region = New Region(p)
        DPAD.Region = New Region(p2)
    End Sub

    Private Sub btnDetectJoy1_Click(sender As Object, e As EventArgs)
        Dim btn As PictureBox = New PictureBox
        AddHandler btn.HandleCreated, AddressOf JoyStick_HandleCreated
        btn.Width = 36
        btn.Height = 36
        Panel1.Controls.Add(btn)
        btn.BringToFront()

        Dim i As Byte
        i = 11
        m_items.Item(i) = btn

        AddHandler CType(m_items(i), PictureBox).Paint, AddressOf picButton_Paint
        AddHandler CType(m_items(i), PictureBox).MouseDown, AddressOf JoyStick_MouseDown
    End Sub

    Private Sub JoyStick_HandleCreated(sender As Object, e As EventArgs) Handles JoyLeft.HandleCreated, JoyRight.HandleCreated, DPAD.HandleCreated
        sender.BackColor = Color.FromArgb(150, Color.Aqua)
    End Sub

    Private Sub JoyStick_MouseDown(sender As Object, e As MouseEventArgs) Handles JoyLeft.MouseDown, JoyRight.MouseDown, DPAD.MouseDown
        sender.BringToFront()
        ReleaseCapture()
        SendMessage(sender.Handle.ToInt32(), WM_SysCommand, SC_MOVE, 0)
    End Sub

    Private Sub JoyStick_Paint(sender As Object, e As PaintEventArgs) Handles JoyLeft.Paint, JoyRight.Paint
        Dim rect As RectangleF = JoyLeft.DisplayRectangle
        rect.Inflate(-1.5F, -1.5F)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.DrawEllipse(New Pen(Brushes.Black, 3), rect)
    End Sub

    Private Sub DPAD_Paint(sender As Object, e As PaintEventArgs) Handles DPAD.Paint
        Dim rect As Rectangle = New Rectangle(33, 0, 33, 99)
        Dim rect2 As Rectangle = New Rectangle(0, 33, 99, 33)
        rect.Inflate(-1, -1) : rect2.Inflate(-1, -1)

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.DrawRectangle(New Pen(Brushes.Black, 3), rect)
        e.Graphics.DrawRectangle(New Pen(Brushes.Black, 3), rect2)
    End Sub
    Private Sub picButton_Paint(sender As Object, e As PaintEventArgs)
        Dim rect(0) As RectangleF
        rect(0) = CType(sender, PictureBox).DisplayRectangle
        rect(0).Offset(-0.5F, -0.5F)
        rect(0).Inflate(-1.5F, -1.5F)

        e.Graphics.DrawRectangles(New Pen(Brushes.Black, 3), rect)
    End Sub

    Private Sub chkJoy1_CheckedChanged(sender As Object, e As EventArgs) Handles chkJoy1.CheckedChanged
        JoyLeft.Visible = chkJoy1.Checked
    End Sub

    Private Sub chkJoy2_CheckedChanged(sender As Object, e As EventArgs) Handles chkJoy2.CheckedChanged
        JoyRight.Visible = chkJoy2.Checked
    End Sub

    Private Sub chkDPad_CheckedChanged(sender As Object, e As EventArgs) Handles chkDPad.CheckedChanged
        DPAD.Visible = chkDPad.Checked
    End Sub

    Private Sub btnAddButton_Click(sender As Object, e As EventArgs) Handles btnAddButton.Click
        JoyMapBox.ShowDialog(Me)
    End Sub

    Private Sub JoyLeft_Move(sender As Object, e As EventArgs) Handles JoyLeft.Move
        Dim pX, pY As Integer
        pX = JoyLeft.Location.X : pY = JoyLeft.Location.Y
        With MainForm
            .btnJoyStick1.Location = New Point(pX - 6, pY + 32)
            .btnJoyStick2.Location = New Point(pX + 70, pY + 32)
            .btnJoyStick3.Location = New Point(pX + 32, pY + 70)
            .btnJoyStick4.Location = New Point(pX + 32, pY - 6)
            .btnJoyStick5.Location = New Point(pX + 32, pY + 32)
        End With
    End Sub

    Private Sub DPAD_Move(sender As Object, e As EventArgs) Handles DPAD.Move
        Dim pX, pY As Integer
        pX = DPAD.Location.X : pY = DPAD.Location.Y
        With MainForm
            .btnJoyStick10.Location = New Point(pX - 6, pY + 32)
            .btnJoyStick11.Location = New Point(pX + 70, pY + 32)
            .btnJoyStick12.Location = New Point(pX + 32, pY + 70)
            .btnJoyStick13.Location = New Point(pX + 32, pY - 6)
        End With
    End Sub

    Private Sub JoyRight_Move(sender As Object, e As EventArgs) Handles JoyRight.Move
        Dim pX, pY As Integer
        pX = JoyRight.Location.X : pY = JoyRight.Location.Y
        With MainForm
            .btnJoyStick14.Location = New Point(pX - 6, pY + 32)
            .btnJoyStick15.Location = New Point(pX + 70, pY + 32)
            .btnJoyStick16.Location = New Point(pX + 32, pY + 70)
            .btnJoyStick17.Location = New Point(pX + 32, pY - 6)
            .btnJoyStick18.Location = New Point(pX + 32, pY + 32)
        End With
    End Sub
End Class
