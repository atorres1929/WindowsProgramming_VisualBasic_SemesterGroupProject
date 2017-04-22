Imports System.Data.SqlClient
Public Class CRSVP
    Private _mstrEventID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrEmail As String
    'Private eventNotPassed As Boolean

    'constructor
    Public Sub New()
        _mstrEventID = "" 'may need to be referenced
        _mstrFName = ""
        _mstrLName = ""
        _mstrEmail = ""
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
    Public Property FName As String
        Get
            Return _mstrFName
        End Get
        Set(strVal As String)
            _mstrFName = strVal
        End Set
    End Property
    Public Property LName As String
        Get
            Return _mstrLName
        End Get
        Set(strVal As String)
            _mstrLName = strVal
        End Set
    End Property
    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strVal As String)
            _mstrEmail = strVal
        End Set
    End Property
#End Region
    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("fName", _mstrFName))
            params.Add(New SqlParameter("lName", _mstrLName))
            params.Add(New SqlParameter("email", _mstrEmail))
            Return params
        End Get
    End Property
    Public Function Save() As Integer
        Return myDB.ExecSP("sp_SaveRSVP", GetSaveParameters)
    End Function

    Public Function GetReportData(strID As String) As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("eventID", strID))
        Return myDB.GetDataAdapterBySP("dbo.sp_GetRSVPsByEventID", params)
    End Function
End Class
