Imports System.Data.SqlClient

Public Class CMemberRole
    'TODO MEMBERROLE

    Private _mstrRoleID As String
        Private _mstrPID As String
        Private _mstrSemesterID As String
#Region "Member_Role Properties"
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property

    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
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
#End Region

    Public Sub New()
        _mstrRoleID = ""
        _mstrPID = ""
        _mstrSemesterID = " "

    End Sub



End Class
