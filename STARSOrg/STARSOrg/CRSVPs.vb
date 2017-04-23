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
    Public Function Save() As Integer
        Return _RSVP.Save
    End Function
    Public Function GetAllRSVPs() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllRSVPs", Nothing)
    End Function
End Class
