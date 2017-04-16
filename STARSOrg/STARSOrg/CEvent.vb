Imports System.Data.SqlClient
Public Class CEvent
    Private _mstrEventID As String
    Private _mstrEventDescription As String
    Private _mstrEventTypeID As String
    Private _mstrSemesterID As String
    Private _mstrStartDate As String
    Private _mstrEndDate As String
    Private _mstrLocation As String
    Private _isNewEvent As Boolean

    Public Sub New()
        _mstrEventID = ""
        _mstrEventDescription = ""
        _mstrEventTypeID = ""
        _mstrSemesterID = ""
        _mstrStartDate = ""
        _mstrEndDate = ""
        _mstrLocation = ""
    End Sub

#Region "Properties"
    Public Property EventID As String
        Get
            Return _mstrEventID
        End Get
        Set(strVal As String)
            _mstrEventID = strVal
        End Set
    End Property
    Public Property EventDescription As String
        Get
            Return _mstrEventDescription
        End Get
        Set(strVal As String)
            _mstrEventDescription = strVal
        End Set
    End Property
    Public Property EventTypeID As String
        Get
            Return _mstrEventTypeID
        End Get
        Set(strVal As String)
            _mstrEventTypeID = strVal
        End Set
    End Property
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property StartDate As String
        Get
            Return _mstrStartDate
        End Get
        Set(strVal As String)
            _mstrStartDate = strVal
        End Set
    End Property
    Public Property EndDate As String
        Get
            Return _mstrEndDate
        End Get
        Set(strVal As String)
            _mstrEndDate = strVal
        End Set
    End Property
    Public Property Location As String
        Get
            Return _mstrLocation
        End Get
        Set(strVal As String)
            _mstrLocation = strVal
        End Set
    End Property
    Public Property isNewEvent As Boolean
        Get
            Return _isNewEvent
        End Get
        Set(blnVal As Boolean)
            _isNewEvent = blnVal
        End Set
    End Property
#End Region
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("eventDescription", _mstrEventDescription))
            params.Add(New SqlParameter("eventTypeID", _mstrEventTypeID))
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("startDate", _mstrEndDate))
            params.Add(New SqlParameter("endDate", _mstrEndDate))
            params.Add(New SqlParameter("location", _mstrLocation))
            Return params
        End Get
    End Property
    Public Function Save() As Integer
        If isNewEvent Then
            Return 0 'TODO
        End If
        Return 0 'TODO
    End Function
End Class