Imports System
Imports System.IO
Imports System.Data

Friend Module DebugLog
    Private filePath As String
    Private fileStream As FileStream
    Private streamWriter As StreamWriter

    Public Sub writeDebug(ByVal debugText)
        If debugFlag = 1 Then 'WRITE TO IMMEDIATE WINDOW SCREEN
            Debug.WriteLine(debugText)
        ElseIf debugFlag = 2 Then 'WRITE TO FILE
            Try
                logDateTime = Date.Today.Month.ToString + "/" + Date.Today.Day.ToString + "/" + Date.Today.Year.ToString & " (" & Date.Now.TimeOfDay.ToString + ") "
                WriteLog(logDateTime & debugText)
            Catch
                'WRITE TO LOG FAILED
            End Try '
        Else
            'DO NOTHING

        End If
    End Sub

    Public Sub OpenFile()
        Dim strPath As String
        logDate = Date.Today.Month.ToString + "-" + Date.Today.Day.ToString + "-" + Date.Today.Year.ToString

        strPath = debugFilePath + "\MazerLazerLog (" + logDate + ").log"
        If System.IO.File.Exists(strPath) Then
            fileStream = New FileStream(strPath, FileMode.Append, FileAccess.Write)
        Else
            fileStream = New FileStream(strPath, FileMode.Create, FileAccess.Write)
        End If
        streamWriter = New StreamWriter(fileStream)
    End Sub

    Public Sub WriteLog(ByVal strComments As String)
        OpenFile()
        streamWriter.WriteLine(strComments)
        CloseFile()
    End Sub

    Public Sub CloseFile()
        streamWriter.Close()
        fileStream.Close()
    End Sub
End Module
