Public Class tscreenEnterMaze

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label1.Left = Label1.Left - 30
        If Label1.Left < 0 Then
            'Timer2.Enabled = True
        End If
        If Label1.Left < 0 - Label1.Width Then
            'Timer1.Enabled = False
            Label1.Left = Me.Width
        End If
        Me.Refresh()
        If mazeEntered = 1 Then
            tscreenGameRunning.Show()
            mazeEntered = 0
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        mazeEntered = 1
    End Sub
    Private Sub tscreenEnterMaze_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tscreenInstructions.Close()
        Label1.Left = Me.Width
    End Sub
End Class