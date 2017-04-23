Imports System.Data.SqlClient
Public Class CEvents
    Private _Event As CEvent
    'constructor
    Public Sub New()
        _Event = New CEvent
    End Sub
    Public ReadOnly Property CurrentObject() As CEvent
        Get
            Return _Event
        End Get
    End Property
    Public Sub CreatNewEvent()
        Clear()
        _Event.isNewEvent = True
    End Sub
    Public Sub Clear()
        _Event = New CEvent
    End Sub
    Public Function Save() As Integer
        Return _Event.Save
    End Function
    Public Function GetAllEvents() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllEvents", Nothing)
    End Function
    Public Function GetAllEventTypeIDs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllEventTypeIDs", Nothing)
    End Function
    Public Function GetAllSemesterIDs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllSemesterIDs", Nothing)
    End Function
    Public Function GetEventByID(strID As String) As CEvent
        Dim params As New ArrayList
        params.Add(New SqlParameter("eventID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetEventByID", params))
        Return _Event
    End Function
    Public Function GetEventDateByID(strID As String) As Date
        Dim sqlDR As SqlDataReader
        Dim params As New ArrayList
        params.Add(New SqlParameter("eventID", strID))
        sqlDR = myDB.GetDataReaderBySP("dbo.sp_GetEventByID", params)
        Using sqlDR
            If sqlDR.Read() Then
                Return sqlDR.Item("EndDate")
            Else 'error fake date
                Return CDate("00/00/0000")
            End If
        End Using
    End Function
    Private Function FillObject(sqlDR As SqlDataReader) As CEvent
        Using sqlDR
            If sqlDR.Read() Then 'found record
                With _Event
                    .EventID = sqlDR.Item("EventID") & ""
                    .EventDescription = sqlDR.Item("EventDescription") & ""
                    .EventTypeID = sqlDR.Item("EventTypeID") & ""
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                    .StartDate = sqlDR.Item("StartDate") & ""
                    .EndDate = sqlDR.Item("EndDate") & ""
                    .Location = sqlDR.Item("Location") & ""
                End With
            End If
        End Using
        sqlDR.Close()
        Return _Event
    End Function
End Class
