﻿Imports System.Data.SqlClient
Public Class CMember
    'each line in the Member table
    Private _mstrPantherID As String
    Private _mstrFirstName As String
    Private _mstrLastName As String
    Private _mstrMiddleIn As String
    Private _mstrEmail As String
    Private _mstrPhoneNumber As String
    Private _mstrRoleID As String
    Private _mstrSemster As String

    Private _mstrSearch As String

    Private _IsNewMember As Boolean

    'do i pass the string location of the picture
    Private _mstrPicture As String

#Region "Member Properties"

    Public Property Search As String
        Get
            Return _mstrSearch

        End Get
        Set(strVal As String)
            _mstrSearch = strVal
        End Set
    End Property
    Public Property Semester As String
        Get
            Return _mstrSemster
        End Get
        Set(strVal As String)
            _mstrSemster = strVal
        End Set
    End Property
    Public Property RoleID As String
        Get
            Return _mstrRoleID
        End Get
        Set(strVal As String)
            _mstrRoleID = strVal
        End Set
    End Property
    Public Property FirstName As String
        Get
            Return _mstrFirstName
        End Get
        Set(strVal As String)
            _mstrFirstName = strVal
        End Set
    End Property

    Public Property LastName As String
        Get
            Return _mstrLastName
        End Get
        Set(strval As String)
            _mstrLastName = strval
        End Set
    End Property

    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strval As String)
            _mstrEmail = strval
        End Set
    End Property

    Public Property MiddleIn As String
        Get
            Return _mstrMiddleIn
        End Get
        Set(strval As String)
            _mstrMiddleIn = strval
        End Set
    End Property

    Public Property PantherID As String
        Get
            Return _mstrPantherID
        End Get
        Set(strval As String)
            _mstrPantherID = strval
        End Set
    End Property

    Public Property PhoneNumber As String
        Get
            Return _mstrPhoneNumber
        End Get
        Set(strval As String)
            _mstrPhoneNumber = strval
        End Set
    End Property

    Public Property Picture As String
        Get
            Return _mstrPicture
        End Get
        Set(strval As String)
            _mstrPicture = strval
        End Set
    End Property

    Public Property IsNewMember As Boolean
        Get
            Return _IsNewMember
        End Get
        Set(blnval As Boolean)
            _IsNewMember = blnval
        End Set
    End Property
#End Region

    'Constructor for a New Member
    Public Sub New()
        _mstrFirstName = ""
        _mstrLastName = ""
        _mstrEmail = ""
        _mstrMiddleIn = ""
        _mstrPantherID = ""
        _mstrPhoneNumber = ""
        _mstrPicture = ""


    End Sub

    Public ReadOnly Property GetSaveParametersMembers() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPantherID))
            params.Add(New SqlParameter("FName", _mstrFirstName))
            params.Add(New SqlParameter("LName", _mstrLastName))
            params.Add(New SqlParameter("MI", _mstrMiddleIn))
            params.Add(New SqlParameter("Email", _mstrEmail))
            params.Add(New SqlParameter("Phone", _mstrPhoneNumber))
            params.Add(New SqlParameter("PhotoPath", _mstrPicture))
            Return params
        End Get
    End Property

    Public Function Save() As Integer
        If IsNewMember Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPantherID))
            Dim strRESULT As String = myDB.GetSingleValueFromSP("sp_CheckMemberPID", params)
            If Not strRESULT = 0 Then
                Return -1
            End If
        End If

        Return myDB.ExecSP("sp_SaveMember", GetSaveParametersMembers)
    End Function

    'Public ReadOnly Property GetSearchParameter() As ArrayList
    '    Get
    '        Dim paramSearch As ArrayList
    '        paramSearch.Add(New SqlParameter("LName", _mstrSearch))
    '        Return paramSearch
    '    End Get
    'End Property

    Public Function SearchMember() As Integer
        Dim paramSearch As New ArrayList
        paramSearch.Add(New SqlParameter("LNAme", _mstrSearch))
        Dim strSEARCHRESULT As String = myDB.GetSingleValueFromSP("sp_SearchMemebers", paramSearch)
        If Not strSEARCHRESULT = 0 Then
            Return -1
        End If
        Return myDB.ExecSP("sp_SearchMembers", GetSaveParametersMembers)

    End Function

    Public Function GetReportData(strID As String) As SqlDataAdapter
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        Return myDB.GetDataAdapterBySP("dbo.sp_GetMemberByPID", params)
    End Function
End Class
