Public Class CSecurity

    Private _mPantherID As String
    Private _mUserID As String
    Private _mPassword As String
    Private _mSecRole As String

    Public Sub New()
        _mPantherID = ""
        _mUserID = ""
        _mPassword = ""
        _mSecRole = ""
    End Sub

    Public Property PantherID As String
        Get
            Return _mPantherID
        End Get
        Set(newPantherID As String)
            _mPantherID = newPantherID
        End Set
    End Property

    Public Property UserID As String
        Get
            Return _mUserID
        End Get
        Set(newUserId As String)
            _mUserID = newUserId
        End Set
    End Property

    Public Property Password As String
        Get
            Return _mPassword
        End Get
        Set(newPassword As String)
            _mPassword = newPassword
        End Set
    End Property

    Public Property SecRole As String
        Get
            Return _mSecRole
        End Get
        Set(newSecRole As String)
            _mSecRole = newSecRole
        End Set
    End Property

    Public Sub LogIn()

    End Sub

End Class
