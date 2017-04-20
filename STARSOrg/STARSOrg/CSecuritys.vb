Imports System.Data.SqlClient

Public Class CSecuritys

    Private _mSecurity As CSecurity

    Public Sub New()
        _mSecurity = New CSecurity
    End Sub
    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _mSecurity
        End Get
    End Property

    Public Sub CreateNewSecurity()
        Clear()
    End Sub

    Public Sub Clear()
        _mSecurity = New CSecurity
    End Sub

    Public Function Login() As Integer
        Return _mSecurity.Login()
    End Function

    Public Function FillObject(reader As SqlDataReader) As CSecurity
        Using reader
            If reader.Read() Then 'found record
                With _mSecurity
                    .PantherID = reader.Item("PID") & ""
                    .UserID = reader.Item("UserID") & ""
                    .Password = reader.Item("Password") & ""
                    .SecRole = reader.Item("SecRole") & ""
                End With
            End If
        End Using
        reader.Close()
        Return _mSecurity
    End Function

End Class
