Public Class tscreenLevel

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        gameDifficulity = 3
        If pseOnOff = 1 Then
            tscreenPSEWarning.Show()
        Else
            tscreenDoYouHaveACodeName.Show()
        End If

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        gameDifficulity = 2
        If pseOnOff = 2 Then
            tscreenPSEWarning.Show()
        Else
            tscreenDoYouHaveACodeName.Show()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        gameDifficulity = 1
        If pseOnOff = 1 Then
            tscreenPSEWarning.Show()
        Else
            tscreenDoYouHaveACodeName.Show()
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        gameDifficulity = 0
        If pseOnOff = 1 Then
            tscreenPSEWarning.Show()
        Else
            tscreenDoYouHaveACodeName.Show()
        End If
    End Sub

    Private Sub tscreenLevel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'LOG TRANSACTION IN DATABASE
        setSystemMode(0)
        Dim transactionDoc As Domino.NotesDocument
        transactionDoc = ndDatabase.CreateDocument

        transactionDoc.ReplaceItemValue("form", "transaction")
        transactionDoc.ReplaceItemValue("transactionAmount", currentBalance)
        transactionDoc.ReplaceItemValue("transactionType", transactionType)
        transactionDoc.ComputeWithForm(True, False)
        transactionDoc.Save(True, False)

        'RESET CURRENT BALANCE
        If currentBalance = 5 Then
            tscreenGetTicketBelow.Close()
        Else
            BillReader.Close()
            tscreenInsertPaymentScreen.Close()
        End If

        currentBalance = 0


        'TURN OFF BILL READER
        SerialPortBC.Write("LOFF" & vbCr)
    End Sub
End Class