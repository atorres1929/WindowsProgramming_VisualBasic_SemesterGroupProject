Imports System.Data.SqlClient
Public Class CMembers
    Private _Member As CMember
    Private _Role As CRole


    Public Sub New()
        _Member = New CMember
        _Role = New CRole
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property


    Public Sub CreateNewMember()
        Clear()
        _Member.IsNewMember = True

    End Sub

    'clear screen
    Public Sub Clear()
        _Member = New CMember
        _Role = New CRole

    End Sub

    'calls save function in frmMember
    Public Function Save() As Integer
        Return _Member.Save
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllMembers", Nothing)
    End Function

    'fill the personal information of the member that is on th elist
    Private Function FillObject(sqlDR As SqlDataReader) As CMember
        Using sqlDR
            If sqlDR.Read() Then
                With _Member
                    .PantherID = sqlDR.Item("PID") & ""
                    .FirstName = sqlDR.Item("FName") & ""
                    .LastName = sqlDR.Item("LName") & ""
                    .MiddleIn = sqlDR.Item("MI") & ""
                    .Email = sqlDR.Item("Email") & ""
                    .PhoneNumber = sqlDR.Item("Phone") & ""
                    .Picture = sqlDR.Item("PhotoPath") & ""

                End With
                With _Role
                    .RoleID = sqlDR.Item("RoleID") & ""
                End With
            End If
            sqlDR.Close()
            ' Return _Role
            Return _Member

        End Using
    End Function
End Class
