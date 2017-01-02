Public Class JoyMapBox

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If IsNothing(MainForm.Tag) = False Then Label1.Text = "按下手柄按键添加……" & MainForm.Tag
    End Sub
End Class