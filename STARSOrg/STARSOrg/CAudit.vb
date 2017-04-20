Imports System.Data.SqlClient

Public Class CAudit
    Private _mintUKID As Integer
    Private _mstrPantherID As String
    Private _mdtmAccessTimeStamp As DateTime
    Private _mblnSuccess As Boolean

    Public Sub New()
        _mintUKID = -1
        _mstrPantherID = ""
        _mdtmAccessTimeStamp = Nothing
        _mblnSuccess = False
    End Sub

    Public Property UKID As Integer
        Get
            Return _mintUKID
        End Get
        Set(ukid As Integer)
            _mintUKID = ukid
        End Set
    End Property

    Public Property PantherID As String
        Get
            Return _mstrPantherID
        End Get
        Set(newPantherID As String)
            _mstrPantherID = newPantherID
        End Set
    End Property

    Public Property AccessTimeStamp As DateTime
        Get
            Return _mdtmAccessTimeStamp
        End Get
        Set(newTimeStamp As DateTime)
            _mdtmAccessTimeStamp = newTimeStamp
        End Set
    End Property

    Public Property Success As Boolean
        Get
            Return _mblnSuccess
        End Get
        Set(isSuccess As Boolean)
            _mblnSuccess = isSuccess
        End Set
    End Property

    'TODO possibly remove
    Public Function GetAuditParameters() As ArrayList
        Dim params As New ArrayList
        params.Add(New SqlParameter("UKID", _mintUKID))
        params.Add(New SqlParameter("PID", _mstrPantherID))
        params.Add(New SqlParameter("ACCESSTIMESTAMP", _mdtmAccessTimeStamp))
        params.Add(New SqlParameter("SUCCESS", _mblnSuccess))
        Return params
    End Function

End Class
