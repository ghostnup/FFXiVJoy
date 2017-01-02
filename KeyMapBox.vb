Imports System.Text.RegularExpressions

Public NotInheritable Class KeyMapBox

    Dim mixStr As String, keyCode As UShort

    Private Sub MapperBox1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CenterToParent()
        Me.TopMost = True
        KeyBox1.Text = "空"
        keyCode = 0
    End Sub
    Private Sub MapperBox1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        GC.Collect()
    End Sub

    Private Sub MapperBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim str As String, tmp As Short

        str = e.KeyData.ToString().ToUpper()

        If str.IndexOf("CONTROL") > -1 Then
            tmp = 1
        End If
        If str.IndexOf("ALT") > -1 Then
            tmp = tmp + 2
        End If
        If str.IndexOf("SHIFT") > -1 Then
            tmp = tmp + 4
        End If
        Select Case tmp
            Case 0
                KeyBox1.Text = ""
            Case 1
                KeyBox1.Text = "CTRL"
            Case 2
                KeyBox1.Text = "ALT"
            Case 3
                KeyBox1.Text = "CTRL+ALT"
            Case 4
                KeyBox1.Text = "SHIFT"
            Case 5
                KeyBox1.Text = "CTRL+SHIFT"
            Case 6
                KeyBox1.Text = "SHIFT+ALT"
            Case 7
                KeyBox1.Text = "CTRL+SHIFT+ALT"
        End Select
        str = e.KeyValue
        keyCode = str
        mixStr = str
        If str >= 16 And str <= 18 Then
            str = ""
            keyCode = 0
        Else
            str = e.KeyCode.ToString().ToUpper()
            str = Regex.Replace(str, "^D(?<num>\d)", "${num}")
            If tmp > 0 Then str = "+" & str : mixStr = KeyBox1.Text & "+" & keyCode
        End If

        str = Regex.Replace(str, "^UP", "↑")
        KeyBox1.Text = KeyBox1.Text & str.Replace("NUMPAD", "NUM").Replace("CAPITAL", "CAPS").Replace("NUMLOCK", "NUMLK").Replace("RETURN", "ENTER").Replace("OEMTILDE", "`") _
                                        .Replace("INSERT", "INS").Replace("DELETE", "DEL").Replace("DIVIDE", "/").Replace("MULTIPLY", "*").Replace("DECIMAL", ".") _
                                        .Replace("OEMMINUS", "-").Replace("OEMPLUS", "=").Replace("ADD", "NUM+").Replace("SUBTRACT", "NUM-") _
                                        .Replace("OEMOPENBRACKETS", "[").Replace("OEM6", "]").Replace("OEM5", "\").Replace("OEM1", ";").Replace("OEM7", "'") _
                                        .Replace("OEMCOMMA", ",").Replace("OEMPERIOD", ".").Replace("OEMQUESTION", "/").Replace("PAGEUP", "PGUP").Replace("NEXT", "PGDN") _
                                        .Replace("LEFT", "←").Replace("RIGHT", "→").Replace("DOWN", "↓").Replace("ESCAPE", "ESC")
    End Sub

    Private Sub MapperBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Dim str As String, a As Short, btn As iButton = MainForm.btnPressNum
        str = e.KeyValue

        str = KeyBox1.Text

        If str.IndexOf("ALT") > -1 Then
            btn.ALT = True
        Else
            btn.ALT = False
        End If

        If str.IndexOf("CTRL") > -1 Then
            btn.CTRL = True
        Else
            btn.CTRL = False
        End If

        If str.IndexOf("SHIFT") > -1 Then
            btn.SHIFT = True
        Else
            btn.SHIFT = False
        End If

        If keyCode = 0 Then
            btn.Text = "Fn"
        Else
            a = Strings.InStrRev(KeyBox1.Text.Substring(0, KeyBox1.Text.Length - 1), "+")
            str = str.Substring(a)
            btn.Text = str
        End If
        btn.Tag = mixStr
        mixStr = Nothing : keyCode = Nothing : btn = Nothing
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim btn As iButton = MainForm.btnPressNum
        btn.Tag = Nothing
        btn.Text = Nothing
        btn.ALT = False
        btn.CTRL = False
        btn.SHIFT = False
        btn.TagJump = Nothing
        btn.JumpMode = 0
        Me.Close()
    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        Me.Close()
    End Sub

    Protected Overrides Function ProcessDialogKey(ByVal keyData As Keys) As Boolean

        If keyData = Keys.Left Or keyData = Keys.Right Or keyData = Keys.Up Or keyData = Keys.Down Then
            Return False '如果是方向键返回FALSE,意思是继续执行form的keydown事件.

        Else
            Return MyBase.ProcessDialogKey(keyData)

        End If

    End Function
End Class
