Imports System.Threading

Public Class tscreenGameRunning

    Private Sub tscreenGameRunning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tscreenEnterMaze.Close()
        'FLAG FOR ENTERED MAZE
        mazeEntered = 0
        'START GAME
        setSystemMode(2)
    End Sub
    Private Sub timerBlink_Tick(sender As System.Object, e As System.EventArgs) Handles timerBlink.Tick
        If Label1.Visible = True Then
            Label1.Visible = False
            Label2.Visible = True
        Else
            Label1.Visible = True
            Label2.Visible = False
        End If
    End Sub

    Private Sub timerCheckForGameEnd_Tick(sender As System.Object, e As System.EventArgs) Handles timerCheckForGameEnd.Tick
        If gameRunning = 0 Then
            'GAME HAS ENDED
            tscreenCollectScorecard.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        gameExited = 1
    End Sub

    Private Sub timerCheckGameExit_Tick(sender As System.Object, e As System.EventArgs) Handles timerCheckGameExit.Tick
        If gameTurnButton = 1 Then
            If mazeEntered = 1 Then
                gameExited = 1
            End If
        End If
    End Sub
End Class