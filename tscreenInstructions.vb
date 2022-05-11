Public Class tscreenInstructions

    Private Sub timerBlinkOK_Tick(sender As System.Object, e As System.EventArgs) Handles timerBlinkOK.Tick
        If Button1.Visible = True Then
            Button1.Visible = False
        Else
            Button1.Visible = True
        End If
    End Sub

    Private Sub timerTimeOut_Tick(sender As System.Object, e As System.EventArgs) Handles timerTimeOut.Tick
        'TIMEOUT IN THIS CASE JUST GO TO ENTER MAZE
        tscreenEnterMaze.Show()
    End Sub

    Private Sub tscreenInstructions_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If gamePlayerNumber = 0 Then
            'NO PLAYER
            tscreenDoYouHaveACodeName.Close()
        Else
            tscreenPlayerID.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        tscreenEnterMaze.Show()
    End Sub
End Class