Imports System.Threading

Public Class Ticket
    Public ticketCount As Integer = 0
    Private Sub Ticket_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        createTicket()
        dominoObject = ticketDoc.GetItemValue("ticketUNID")
        ticketUNID = dominoObject(0)
        Label4.Text = "*" + ticketUNID + "*"

        'SET DATE
        Label2.Text = dateMonth + "/" + dateDay + "/" + dateYear

        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0.25
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0.25
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Top = 0.25
        PrintForm1.PrinterSettings.DefaultPageSettings.Margins.Left = 0.25
        createTicket()
        dominoObject = ticketDoc.GetItemValue("ticketUNID")
        ticketUNID = dominoObject(0)
        Label4.Text = "*" + ticketUNID + "*"
        Try
            PrintForm1.Print()
        Catch
            writeDebug("PRINT FAILED")
        End Try
        ticketCount = ticketCount + 1
        If ticketCount = ticketPrintCount Then
            ticketDoc.Remove(True)
            Timer1.Enabled = False
            Me.Close()
        End If
    End Sub
End Class