Public Class ScoreboardScreen

    Private Sub ScoreboardScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IsNothing(CameraURL) Then
            AxXCast1.ChangeURL("http://lasertagorlando.com:8080/cam5")
        Else
            AxXCast1.ChangeURL(CameraURL)
        End If
        AxXCast1.bHideUI = True
    End Sub

    Private Sub timerUpdateScore_Tick(sender As System.Object, e As System.EventArgs) Handles timerUpdateScore.Tick
        'UPDATE SCOREBOARD
        labelScore.Text = CStr(gameScore)
        labelTime.Text = CStr(gameTimeRemaining)
        labelBeamsBroken.Text = CStr(gameBeamsBroken)
        labelRedBeams.Text = CStr(gameBeamsBrokenRed)
        labelGreenBeams.Text = CStr(gameBeamsBrokenGreen)
        labelBlueBeams.Text = CStr(gameBeamsBrokenBlue)
        labelBonusButtons.Text = CStr(gameButtonsPressed)
        labelDifficulity.Text = CStr(gameDifficulityLabels(gameDifficulity))
    End Sub
End Class