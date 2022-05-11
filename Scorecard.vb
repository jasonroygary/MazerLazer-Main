Imports System.Threading
Public Class Scorecard

    Private Sub Scorecard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Now As DateTime = DateTime.Now
        Dim dateMonth As String
        Dim dateDay As String
        Dim dateYear As String
        If Len(CStr(Now.Month)) = 1 Then
            dateMonth = "0" + CStr(Now.Month)
        Else
            dateMonth = CStr(Now.Month)
        End If
        If Len(CStr(Now.Day)) = 1 Then
            dateDay = "0" + CStr(Now.Day)
        Else
            dateDay = CStr(Now.Day)
        End If
        dateYear = Now.Year

        'SET DATE
        Label2.Text = dateMonth + "/" + dateDay + "/" + dateYear
        'UPDATE SCORECARD
        labelScore.Text = CStr(gameScore)
        labelTime.Text = CStr(gameTimeRemaining)
        labelBeamsBroken.Text = CStr(gameBeamsBroken)
        labelRed.Text = CStr(gameBeamsBrokenRed)
        labelGreen.Text = CStr(gameBeamsBrokenGreen)
        labelBlue.Text = CStr(gameBeamsBrokenBlue)
        labelButtons.Text = CStr(gameButtonsPressed)
        labelDifficulity.Text = CStr(gameDifficulityLabels(gameDifficulity))
        labelPlayerLevel.Text = gamePlayerLevel
        If gameTurnButton = 1 Then
            turn = "YES"
        Else
            turn = "NO"
        End If
        labelTurn.Text = turn

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0.25
        'PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0.25
        PrintForm1.Print()
        Timer1.Enabled = False
        thread.sleep(6000)
        Me.Close()
    End Sub
End Class