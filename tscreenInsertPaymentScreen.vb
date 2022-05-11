Imports System.Threading

Public Class tscreenInsertPaymentScreen
    Private threadAttractLasers As Thread
    Dim photoIndex As Integer = 2
    Private Sub AttractScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ATTRACT LASER MODE THREAD
        tscreenCollectScorecard.Close()
        formAttractScreen = Me
        'Me.TopMost = True
        labelOneGamePrice.Text = CStr(OneGamePrice)
        labelThreeGamePrice.Text = CStr(ThreeGamePrice)
        'labelMazer.Left = Me.Width
        BillReader.Show()
        setSystemMode(1)
    End Sub

    Private Sub PhotoTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PhotoTimer.Tick
        ' PictureBoxAttractScreen.ImageLocation = "c:\\mazerlaser\\attractscreenphotos\\" & CStr(photoIndex) & ".jpg"
        PictureBoxAttractScreen.Image = Image.FromFile("c:\MazerLazer\AttractScreenPhotos\" & CStr(photoIndex) & ".jpg")
        photoIndex = photoIndex + 1
        If photoIndex > AttractScreenPhotoCount Then
            photoIndex = 1
        End If
    End Sub

    Private Sub timerCheckCurrentCredit_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerCheckCurrentCredit.Tick
        If currentBalanceChange = 1 Then
            currentBalanceChange = 0
            labelCurrentCredit.Text = CStr(currentBalance)
            If currentBalance <= 2 Then
                labelNeededCredit.Text = CStr(OneGamePrice - currentBalance)
            End If
        End If
        If currentBalance >= 2 Then
            'If currentBalance = 5 Then
            'PRINT OUT TICKETS
            'setSystemMode(0)
            'tscreenGetTicketBelow.Show()
            'Else
            setSystemMode(0)
            tscreenLevel.Show()
            'End If
        End If
    End Sub

    Private Sub timerBlinkInsertBills_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerBlinkInsertBills.Tick
        If Label11.Visible = True Then
            Label11.Visible = False
            Label14.Visible = True
            labelMazer.Visible = True
            labelLazer.Visible = False
        Else
            Label11.Visible = True
            Label14.Visible = False
            labelMazer.Visible = False
            labelLazer.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        currentBalance = currentBalance + 1
        currentBalanceChange = 1
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        currentBalance = currentBalance + 5
        currentBalanceChange = 1
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Scorecard.Show()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        'CREATE TICKET RECORD

        Ticket.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub timerAttractMode_Tick(sender As System.Object, e As System.EventArgs) Handles timerAttractMode.Tick
        If systemMode = 0 Then
            setSystemMode(1)
        Else
            setSystemMode(0)
        End If
    End Sub
End Class