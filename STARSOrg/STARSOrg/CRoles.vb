Imports System.Data.SqlClient
Public Class CRoles
    'Represents the ROLE table and its associated business rules
    Private _Role As CRole
    'constructor
    Public Sub New()
        'instantiate the CRole object
        _Role = New CRole
    End Sub

    Public ReadOnly Property CurrentObject() As CRole
        'exposes the CRole object to the GUI layer
        Get
            Return _Role
        End Get
    End Property
    Public Sub CreateNewRole()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Role.IsNewRole = True
    End Sub
    Public Sub Clear()
        _Role = New CRole
    End Sub
    Public Function Save() As Integer
        Return _Role.Save
    End Function
    Public Function GetAllRoles() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllRoles", Nothing)
    End Function
    Public Function GetRoleByID(strID As String) As CRole
        Dim params As New ArrayList
        params.Add(New SqlParameter("roleID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetRoleByID", params))
        Return _Role
    End Function
    Private Function FillObject(sqlDR As SqlDataReader) As CRole
        Using sqlDR
            If sqlDR.Read() Then 'found the role record
                With _Role
                    .RoleID = sqlDR.Item("RoleID") & ""
                    .RoleDescription = sqlDR.Item("RoleDescription") & ""
                End With
            End If
        End Using
        sqlDR.Close()
        Return _Role
    End Function
End Class
