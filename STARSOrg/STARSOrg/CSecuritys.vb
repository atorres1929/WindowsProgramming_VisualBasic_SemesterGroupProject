Public Class CSecuritys

    Private _mSecurity As CSecurity

    Public ReadOnly Property CurrentObject() As CSecurity
        Get
            Return _mSecurity
        End Get
    End Property

    Public Sub CreateNewSecurity()
        Clear()
        _mSecurity.IsNewSecurity = True
    End Sub

    Public Sub Clear()
        _mSecurity = New CSecurity
    End Sub

    Public Function Login() As Integer
        Return _mSecurity.Login()
    End Function

End Class
