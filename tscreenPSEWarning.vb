Public Class tscreenPSEWarning
    Private Sub buttonPSEOff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPSEOff.Click
        'OPEN LEVEL TOUCH SCREEN FORM
        gamePSE = 0
        tscreenDoYouHaveACodeName.Show()

    End Sub

    Private Sub buttonPSEON_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonPSEON.Click
        gamePSE = 1
        tscreenDoYouHaveACodeName.Show()
    End Sub

    Private Sub PSEWarning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tscreenLevel.Close()
    End Sub

    Private Sub timerBlinkWarning_Tick(sender As System.Object, e As System.EventArgs) Handles timerBlinkWarning.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
        Else
            Label1.Visible = True
        End If
    End Sub
End Class