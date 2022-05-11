Public Class tscreenDoYouHaveACodeName

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'YES
        tscreenPlayerID.Show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'NO
        tscreenInstructions.Show()
    End Sub

    Private Sub timerAlternateButtons_Tick(sender As System.Object, e As System.EventArgs) Handles timerAlternateButtons.Tick
        If Button1.Visible = True Then
            Button1.Visible = False
            Button2.Visible = True
        Else
            Button2.Visible = False
            Button1.Visible = True

        End If
    End Sub

    Private Sub tscreenDoYouHaveACodeName_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If pseOnOff = 1 Then
            'PSE WARNING SCREEN ENABLED
            tscreenPSEWarning.Close()
        Else
            tscreenLevel.Close()
        End If
    End Sub
End Class