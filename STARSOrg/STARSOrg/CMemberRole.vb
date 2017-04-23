Imports System.Data.SqlClient

Public Class CMemberRole
    'TODO MEMBERROLE

    Private _mstrRoleID As String
        Private _mstrPID As String
    Private _mstrSemesterID As String
    Private _isNewMemberRole As Boolean
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

    Public Property IsNewMemberRole As Boolean
        Get
            Return _isNewMemberRole

        End Get
        Set(blnVal As Boolean)
            _isNewMemberRole = blnVal
        End Set
    End Property
#End Region

    Public Sub New()
        _mstrRoleID = ""
        _mstrPID = ""
        _mstrSemesterID = " "

    End Sub

    Public ReadOnly Property GetMemberRoleParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("RoleID", _mstrRoleID))
            ' one for the combo box 
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            Return params
        End Get
    End Property

    Public Function Save() As Integer

        If IsNewMemberRole Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            Dim strRESULT As String = myDB.GetSingleValueFromSP("sp_CheckMemberRolePID", params)
            If Not strRESULT = 0 Then
                Return -1
            End If
        End If
        Return myDB.ExecSP("sp_SaveMemberRole", GetMemberRoleParameters)
    End Function



End Class
