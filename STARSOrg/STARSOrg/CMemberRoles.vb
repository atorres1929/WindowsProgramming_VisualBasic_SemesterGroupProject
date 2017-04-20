Imports System.Data.SqlClient
Public Class CMemberRoles
    'TODO MEMBERROLEs
    Private _MemberRole As CMemberRole

    Public Sub New()
        _MemberRole = New CMemberRole
    End Sub

    Public ReadOnly Property CurrentMember() As CMemberRole
        Get
            Return _MemberRole
        End Get
    End Property

    Public Function GetMemberRolePID(strID As String) As CMemberRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("PID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetMemberRolePID", params))
        Return _MemberRole
    End Function

    Private Function FillObject(sqlDR As SqlDataReader) As CMemberRole
        Using sqlDR
            If sqlDR.Read() Then
                With _MemberRole
                    .PID = sqlDR.Item("PID") & ""
                    .RoleID = sqlDR.Item("RoleID") & ""
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                End With
            End If

        End Using
        ''sqlDR.Close()
        Return _MemberRole
    End Function
End Class
