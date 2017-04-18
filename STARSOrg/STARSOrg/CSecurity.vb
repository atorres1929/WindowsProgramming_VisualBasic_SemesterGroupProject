Imports System.Data.SqlClient

Public Class CSecurity

    Private _mstrPantherID As String
    Private _mstrUserID As String
    Private _mstrPassword As String
    Private _mstrNewPassword As String
    Private _mstrSecRole As String
    Private _IsNewSecurity As Boolean

    Public Sub New()
        _mstrPantherID = ""
        _mstrUserID = ""
        _mstrPassword = ""
        _mstrSecRole = ""
        _IsNewSecurity = False
    End Sub

    Public Property PantherID As String
        Get
            Return _mstrPantherID
        End Get
        Set(newPantherID As String)
            _mstrPantherID = newPantherID
        End Set
    End Property

    Public Property UserID As String
        Get
            Return _mstrUserID
        End Get
        Set(newUserId As String)
            _mstrUserID = newUserId
        End Set
    End Property

    Public Property Password As String
        Get
            Return _mstrPassword
        End Get
        Set(password As String)
            _mstrPassword = password
        End Set
    End Property

    Public Property NewPassword As String
        Get
            Return _mstrNewPassword
        End Get
        Set(newPassword As String)
            _mstrNewPassword = newPassword
        End Set
    End Property

    Public Property SecRole As String
        Get
            Return _mstrSecRole
        End Get
        Set(newSecRole As String)
            _mstrSecRole = newSecRole
        End Set
    End Property

    Public Property IsNewSecurity As Boolean
        Get
            Return _IsNewSecurity
        End Get
        Set(isNewSecurity As Boolean)
            _IsNewSecurity = isNewSecurity
        End Set
    End Property

    Public Function GetLoginParameters() As ArrayList
        Dim params As New ArrayList
        params.Add(New SqlParameter("username", _mstrUserID))
        params.Add(New SqlParameter("password", _mstrPassword))
        Return params
    End Function

    Public Function GetUpdatePasswordParameters() As ArrayList
        Dim params As New ArrayList
        params.Add(New SqlParameter("username", _mstrUserID))
        params.Add(New SqlParameter("password", _mstrPassword))
        params.Add(New SqlParameter("newPassword", _mstrNewPassword))
    End Function

    Public Function Login() As Integer
        Return myDB.ExecSP("sp_Login", GetLoginParameters)
    End Function

    Public Function UpdatePassword() As Integer
        Return myDB.ExecSP("sp_UpdatePassword", GetUpdatePasswordParameters)
    End Function



End Class
