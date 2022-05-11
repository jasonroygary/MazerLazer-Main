Public Class tscreenCollectScorecard

    Private Sub timerBlinkArrow_Tick(sender As System.Object, e As System.EventArgs) Handles timerBlinkArrow.Tick
        If PictureBox1.Visible = False Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
        If printScorecard = 1 Then
            Scorecard.Show()
            printScorecard = 0
        End If
    End Sub

    Private Sub timerReturnToPaymentScreen_Tick(sender As System.Object, e As System.EventArgs) Handles timerReturnToPaymentScreen.Tick
        tscreenInsertPaymentScreen.Show()
    End Sub

    Private Sub tscreenCollectScorecard_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tscreenGameRunning.Close()
    End Sub
End Class