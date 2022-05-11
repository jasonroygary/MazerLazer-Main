Imports System.IO
Imports System
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic
Imports System.IO.Ports
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports MPOST

Public Class BillReader

#Region "Event Delegate Definitions"
    Private ConnectedDelegate As ConnectedEventHandler
    Private DisconnectedDelegate As DisconnectedEventHandler
    Private EscrowedDelegate As EscrowEventHandler
    Private StackedDelegate As StackedEventHandler
    Private ReturnedDelegate As ReturnedEventHandler
    Private RejectedDelegate As RejectedEventHandler
    Private PowerUpDelegate As PowerUpEventHandler
    Private PUPEscrowDelegate As PUPEscrowEventHandler
    Private CashBoxAttachedDelegate As CashBoxAttachedEventHandler
    Private CashBoxRemovedDelegate As CashBoxRemovedEventHandler
    Private CheatedDelegate As CheatedEventHandler
    Private JamDetectedDelegate As JamDetectedEventHandler
    Private JamClearedDelegate As JamClearedEventHandler
    Private StallDetectedDelegate As StallDetectedEventHandler
    Private StallClearedDelegate As StallClearedEventHandler
    Private PauseDetectedDelegate As PauseDetectedEventHandler
    Private PauseClearedDelegate As PauseClearedEventHandler
    Private CalibrateStartDelegate As CalibrateStartEventHandler
    Private CalibrateProgressDelegate As CalibrateProgressEventHandler
    Private CalibrateFinishDelegate As CalibrateFinishEventHandler
    Private DownloadStartDelegate As DownloadStartEventHandler
    Private DownloadProgressDelegate As DownloadProgressEventHandler
    Private DownloadFinishDelegate As DownloadFinishEventHandler
    Private DownloadRestartDelegate As DownloadRestartEventHandler
    Private StackerFullDelegate As StackerFullEventHandler

#End Region

    Public WithEvents SerialPortBillAcceptor As SerialPort = New System.IO.Ports.SerialPort("COM2", 9600, Parity.Even, 7, StopBits.One)
    Dim dataReceived As String = "" 'STRING THAT HAS SERIAL BUFFER IN IT CONCAT WITH INCOMMING DATA
    Private PupMode As PowerUp = PowerUp.A
    Private BillAcceptor As MPOST.Acceptor = New MPOST.Acceptor()

    Public Sub Tset()
        ConnectedDelegate = New ConnectedEventHandler(AddressOf HandleConnectedEvent)
        DisconnectedDelegate = New DisconnectedEventHandler(AddressOf HandleDisconnectedEvent)
        EscrowedDelegate = New EscrowEventHandler(AddressOf HandleEscrowedEvent)
        StackedDelegate = New StackedEventHandler(AddressOf HandleStackedEvent)
        ReturnedDelegate = New ReturnedEventHandler(AddressOf HandleReturnedEvent)
        RejectedDelegate = New RejectedEventHandler(AddressOf HandleRejectedEvent)
        PowerUpDelegate = New PowerUpEventHandler(AddressOf HandlePowerUpEvent)
        PUPEscrowDelegate = New PUPEscrowEventHandler(AddressOf HandlePUPEscrowEvent)
        CashBoxAttachedDelegate = New CashBoxAttachedEventHandler(AddressOf HandleCashBoxAttachedEvent)
        CashBoxRemovedDelegate = New CashBoxRemovedEventHandler(AddressOf HandleCashBoxRemovedEvent)
        CheatedDelegate = New CheatedEventHandler(AddressOf HandleCheatedEvent)
        JamDetectedDelegate = New JamDetectedEventHandler(AddressOf HandleJamDetectedEvent)
        JamClearedDelegate = New JamClearedEventHandler(AddressOf HandleJamClearedEvent)
        StallDetectedDelegate = New StallDetectedEventHandler(AddressOf HandleStallDetectedEvent)
        StallClearedDelegate = New StallClearedEventHandler(AddressOf HandleStallClearedEvent)
        PauseDetectedDelegate = New PauseDetectedEventHandler(AddressOf HandlePauseDetectedEvent)
        PauseClearedDelegate = New PauseClearedEventHandler(AddressOf HandlePauseClearedEvent)
        CalibrateStartDelegate = New CalibrateStartEventHandler(AddressOf HandleCalibrateStartEvent)
        CalibrateProgressDelegate = New CalibrateProgressEventHandler(AddressOf HandleCalibrateProgressEvent)
        CalibrateFinishDelegate = New CalibrateFinishEventHandler(AddressOf HandleCalibrateFinishEvent)
        DownloadStartDelegate = New DownloadStartEventHandler(AddressOf HandleDownloadStartEvent)
        DownloadProgressDelegate = New DownloadProgressEventHandler(AddressOf HandleDownloadProgressEvent)
        DownloadFinishDelegate = New DownloadFinishEventHandler(AddressOf HandleDownloadFinishEvent)
        DownloadRestartDelegate = New DownloadRestartEventHandler(AddressOf HandleDownloadRestartEvent)
        StackerFullDelegate = New StackerFullEventHandler(AddressOf HandleStackerFullEvent)

        ' Connect to the events.
        AddHandler BillAcceptor.OnConnected, ConnectedDelegate
        AddHandler BillAcceptor.OnDisconnected, DisconnectedDelegate
        AddHandler BillAcceptor.OnEscrow, EscrowedDelegate
        AddHandler BillAcceptor.OnStacked, StackedDelegate
        AddHandler BillAcceptor.OnReturned, ReturnedDelegate
        AddHandler BillAcceptor.OnRejected, RejectedDelegate
        AddHandler BillAcceptor.OnPowerUp, PowerUpDelegate
        AddHandler BillAcceptor.OnPUPEscrow, PUPEscrowDelegate
        AddHandler BillAcceptor.OnCheated, CheatedDelegate
        AddHandler BillAcceptor.OnCashBoxAttached, CashBoxAttachedDelegate
        AddHandler BillAcceptor.OnCashBoxRemoved, CashBoxRemovedDelegate
        AddHandler BillAcceptor.OnJamDetected, JamDetectedDelegate
        AddHandler BillAcceptor.OnJamCleared, JamClearedDelegate
        AddHandler BillAcceptor.OnStallDetected, StallDetectedDelegate
        AddHandler BillAcceptor.OnStallCleared, StallClearedDelegate
        AddHandler BillAcceptor.OnPauseDetected, PauseDetectedDelegate
        AddHandler BillAcceptor.OnPauseCleared, PauseClearedDelegate
        AddHandler BillAcceptor.OnCalibrateStart, CalibrateStartDelegate
        AddHandler BillAcceptor.OnCalibrateProgress, CalibrateProgressDelegate
        AddHandler BillAcceptor.OnCalibrateFinish, CalibrateFinishDelegate
        AddHandler BillAcceptor.OnDownloadStart, DownloadStartDelegate
        AddHandler BillAcceptor.OnDownloadProgress, DownloadProgressDelegate
        AddHandler BillAcceptor.OnDownloadFinish, DownloadFinishDelegate
        AddHandler BillAcceptor.OnDownloadRestart, DownloadRestartDelegate
        AddHandler BillAcceptor.OnStackerFull, StackerFullDelegate
    End Sub

    Public Sub ListEvent(ByVal test As String)
        writeDebug("BILL READER: " + test)

    End Sub
    Private Sub BillReader_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Tset()

        ListEvent("Command: BillAccepter.Open()")

        Try
            BillAcceptor.Open(SerialPortBillReaderNumber, PowerUp.A)
        Catch err As Exception
            Close()
        End Try
        Thread.Sleep(2000)
        Try
            BillAcceptor.EnableAcceptance = True
        Catch

        End Try
        'BillAcceptor.AutoStack = True

    End Sub


    Private Sub HandleConnectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(ConnectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Connected.")
        End If
    End Sub

    Private Sub HandleDisconnectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(DisconnectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Disconnected.")
        End If
    End Sub

    Private Sub HandleEscrowedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(EscrowedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Escrowed: " & DocInfoToString())
            If InStr(DocInfoToString, "1") Then
                '$1 BILL
                currentBalance = currentBalance + 1
                currentBalanceChange = 1
                If currentBalance = 3 Then
                    BillAcceptor.EnableAcceptance = False
                End If
                'Stack
                BillAcceptor.EscrowStack()
            ElseIf InStr(DocInfoToString, "5") Then
                BillAcceptor.EscrowReturn()

                '$5 BILL
                'CHECK TO SEE IF WE HAVE A BALANCE
                'If currentBalance = 0 Then
                'BillAcceptor.EscrowStack()
                'currentBalanceChange = 1
                'currentBalance = 5
                'BillAcceptor.EnableAcceptance = False
                'Else
                'WE ALREADY HAVE A BALANCE
                'WE NEED TO KICK THE BILL OUT
                'BillAcceptor.EscrowReturn()
                'End If
            End If
        End If
    End Sub

    Private Sub HandleStackedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(StackedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Stacked: " & DocInfoToString())
        End If
    End Sub

    Private Sub HandleReturnedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(ReturnedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Returned.")
        End If
    End Sub

    Private Sub HandleRejectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(RejectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Rejected.")
        End If
    End Sub

    Private Sub HandlePowerUpEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(PowerUpDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Power Up.")
        End If
    End Sub

    Private Sub HandlePUPEscrowEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(PUPEscrowDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Power Up with Escrow: " & DocInfoToString())
        End If
    End Sub

    Private Sub HandleCashBoxAttachedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CashBoxAttachedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Cassette Installed.")
        End If
    End Sub

    Private Sub HandleCashBoxRemovedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CashBoxRemovedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Cassette Removed.")
        End If
    End Sub
    Private Sub HandleStackerFullEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(StackerFullDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Cassette Full.")
        End If
    End Sub


    Private Sub HandleCheatedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CheatedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Cheat Detected.")
        End If
    End Sub

    Private Sub HandleJamDetectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(JamDetectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Jam Detected.")
        End If
    End Sub

    Private Sub HandleJamClearedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(JamClearedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Jam Cleared.")
        End If
    End Sub

    Private Sub HandleStallDetectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(StallDetectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Stall Detected.")
        End If
    End Sub

    Private Sub HandleStallClearedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(StallClearedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Stall Cleared.")
        End If
    End Sub

    Private Sub HandlePauseDetectedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(PauseDetectedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Pause Detected.")
        End If
    End Sub

    Private Sub HandlePauseClearedEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(PauseClearedDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Pause Cleared.")
        End If
    End Sub

    Private Sub HandleCalibrateStartEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CalibrateStartDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Calibrate Start.")
        End If
    End Sub

    Private Sub HandleCalibrateProgressEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CalibrateProgressDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Calibrate Progress.")
        End If
    End Sub

    Private Sub HandleCalibrateFinishEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(CalibrateFinishDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Calibrate Finish.")
        End If
    End Sub

    Private Sub HandleDownloadStartEvent(ByVal sender As Object, ByVal e As AcceptorDownloadEventArgs)
        If InvokeRequired Then
            BeginInvoke(DownloadStartDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Download Start:" & e.SectorCount.ToString())
        End If
    End Sub

    Private Sub HandleDownloadProgressEvent(ByVal sender As Object, ByVal e As AcceptorDownloadEventArgs)
        If InvokeRequired Then
            BeginInvoke(DownloadProgressDelegate, New Object() {sender, e})
        Else
            If e.SectorCount Mod 100 = 0 Then
                ListEvent("Event: Download Progress:" & e.SectorCount.ToString())
            End If
        End If
    End Sub

    Private Sub HandleDownloadFinishEvent(ByVal sender As Object, ByVal e As AcceptorDownloadFinishEventArgs)
        If InvokeRequired Then
            BeginInvoke(DownloadFinishDelegate, New Object() {sender, e})
        Else
            If e.Success Then
                ListEvent("Event: Download Finished: OK")
            Else
                ListEvent("Event: Download Finished: FAILED")
            End If
        End If
    End Sub

    Private Sub HandleDownloadRestartEvent(ByVal sender As Object, ByVal e As EventArgs)
        If InvokeRequired Then
            BeginInvoke(DownloadRestartDelegate, New Object() {sender, e})
        Else
            ListEvent("Event: Download Restart.")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        ListEvent("Command: BillAccepter.Open()")

        Try
            BillAcceptor.Open(SerialPortBillReaderNumber, PowerUp.A)
        Catch err As Exception
            Close()
        End Try

    End Sub
    Private Function DocInfoToString() As String
        If BillAcceptor.DocType = DocumentType.None Then
            Return "Doc Type: None"
        ElseIf BillAcceptor.DocType = DocumentType.NoValue Then
            Return "Doc Type: No Value"
        ElseIf BillAcceptor.DocType = DocumentType.Bill Then
            If BillAcceptor.Bill Is Nothing Then
                Return "Doc Type Bill = null"
            ElseIf (Not BillAcceptor.CapOrientationExt) Then
                Return "Doc Type Bill = " & BillAcceptor.Bill.ToString()
            Else
                Return "Doc Type Bill = " & BillAcceptor.Bill.ToString() & " (" & BillAcceptor.EscrowOrientation.ToString() & ")"
            End If
        ElseIf BillAcceptor.DocType = DocumentType.Barcode Then
            If BillAcceptor.BarCode Is Nothing Then
                Return "Doc Type Bar Code = null"
            Else
                Return "Doc Type Bar Code = " & BillAcceptor.BarCode
            End If
        ElseIf BillAcceptor.DocType = DocumentType.Coupon Then
            If BillAcceptor.Coupon Is Nothing Then
                Return "Doc Type Coupon = null"
            Else
                Return "Doc Type Coupon = " & BillAcceptor.Coupon.ToString()
            End If
        Else
            Return "Unknown Doc Type Error"
        End If
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        BillAcceptor.EnableAcceptance = True
        BillAcceptor.AutoStack = True
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
