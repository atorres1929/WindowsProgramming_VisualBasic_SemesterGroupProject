Imports System.Data.SqlClient
Public Class CRSVPs
    Private _RSVP As CRSVP
    'constructor
    Public Sub New()
        _RSVP = New CRSVP
    End Sub
    Public ReadOnly Property CurrentObject As CRSVP
        Get
            Return _RSVP
        End Get
    End Property
    'Public Sub CreateNewRSVP()
    '    Clear()
    'End Sub
    'Public Sub Clear()
    '    _RSVP = New CRSVP
    'End Sub
    Public Function Save() As Integer
        Return _RSVP.Save
    End Function
    Public Function GetAllRSVPs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllRSVPs", Nothing)
    End Function
    'Public Function GetRSVPsByEventID(strID As String) As CRSVP
    '    Dim params As New ArrayList
    '    params.Add(New SqlParameter("eventID", strID))
    '    FillObject(myDB.GetDataReaderBySP("dbo.sp_GetRSVPsByEventID", params))
    '    Return _RSVP
    'End Function
End Class
