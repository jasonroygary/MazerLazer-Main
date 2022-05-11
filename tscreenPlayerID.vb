Imports System
Imports System.Text
Imports System.String

Public Class tscreenPlayerID
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        textUserNumber.Text = textUserNumber.Text + "0"
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        textUserNumber.Text = textUserNumber.Text + "1"
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        textUserNumber.Text = textUserNumber.Text + "2"
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        textUserNumber.Text = textUserNumber.Text + "3"
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        textUserNumber.Text = textUserNumber.Text + "4"
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        textUserNumber.Text = textUserNumber.Text + "5"
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        textUserNumber.Text = textUserNumber.Text + "6"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        textUserNumber.Text = textUserNumber.Text + "7"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        textUserNumber.Text = textUserNumber.Text + "8"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        textUserNumber.Text = textUserNumber.Text + "9"
    End Sub

    Private Sub Button12_Click(sender As System.Object, e As System.EventArgs) Handles Button12.Click
        getPlayerDoc(textUserNumber.Text)
    End Sub

    Private Sub timerUpdateUX_Tick(sender As System.Object, e As System.EventArgs) Handles timerUpdateUX.Tick
        If IsNothing(playerDoc) Then
            labelPlayerFirstName.Text = ""
            labelPlayerLastName.Text = ""
            labelPlayerCodeName.Text = ""
            labelPlayerLaserTagLevel.Text = ""
            Label3.Visible = False
        Else
            'WE HAVE A PLAYER DOCUMENT
            'UPDATE UX
            dominoObject = playerDoc.GetItemValue("playerNameFirst")
            playerFirstName = dominoObject(0)
            dominoObject = playerDoc.GetItemValue("playerNameLast")
            playerLastName = dominoObject(0)
            dominoObject = playerDoc.GetItemValue("playerCodeName")
            playerCodeName = dominoObject(0)
            dominoObject = playerDoc.GetItemValue("playerCurrentLevel")
            playerCurrentLevel = dominoObject(0)

            Label3.Visible = True
            labelPlayerFirstName.Text = playerFirstName
            labelPlayerLastName.Text = playerLastName
            labelPlayerCodeName.Text = playerCodeName
            labelPlayerLaserTagLevel.Text = playerCurrentLevel

        End If
    End Sub

    Private Sub Button11_Click(sender As System.Object, e As System.EventArgs) Handles Button11.Click
        textUserNumber.Text = ""
    End Sub

    Private Sub tscreenPlayerID_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        tscreenDoYouHaveACodeName.Close()
    End Sub

    Private Sub Button13_Click(sender As System.Object, e As System.EventArgs) Handles Button13.Click
        tscreenInstructions.Show()
    End Sub

    Private Sub timerBlinkContinue_Tick(sender As System.Object, e As System.EventArgs)
        If Button13.Visible = True Then
            Button13.Visible = False
        Else
            Button13.Visible = True
        End If
    End Sub

    Private Sub timerTimeout_Tick(sender As System.Object, e As System.EventArgs) Handles timerTimeout.Tick
        tscreenInstructions.Show()
    End Sub
End Class