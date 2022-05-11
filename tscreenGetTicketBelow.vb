Public Class tscreenGetTicketBelow

    Private Sub timerBlinkArrow_Tick(sender As System.Object, e As System.EventArgs) Handles timerBlinkArrow.Tick
        If PictureBox1.Visible = False Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If

        If printScorecard = 1 Then
            Stop
            Scorecard.Show()
            printScorecard = 0
        End If
    End Sub

    Private Sub timerGoToNextScreen_Tick(sender As System.Object, e As System.EventArgs) Handles timerGoToNextScreen.Tick
        tscreenLevel.Show()
    End Sub

    Private Sub tscreenGetTicketBelow_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'PRINT TICKETS
        BillReader.Close()
        tscreenInsertPaymentScreen.Close()
    End Sub

    Private Sub timerPrintTickets_Tick(sender As System.Object, e As System.EventArgs) Handles timerPrintTickets.Tick
        Ticket.Show()
    End Sub
End Class