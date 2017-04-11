Imports System.Data.SqlClient
Public Class CMember
    'each line in the Member table
    Private _mstrPantherID As String
    Private _mstrFirstName As String
    Private _mstrLastName As String
    Private _mstrMiddleIn As String
    Private _mstrEmail As String

    'does this work since its a masked textbox
    'Private _mstrPhoneNumber As String

    'do i pass the string location of the picture
    'Private _mstrPicture As String

    Private _IsNewMember As Boolean

    'Constructor for a New Member
    Public Sub New()
        _mstrFirstName = ""
        _mstrLastName = ""
        _mstrEmail = ""
        _mstrMiddleIn = ""
        _mstrPantherID = ""
        '_mstrPhoneNumber=""
        '_mstrPicture=""
    End Sub


#Region "Member Properties"

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

    'Public Property PhoneNumber As String
    '    Get
    '        Return _mstrPhoneNumber
    '    End Get
    '    Set(strval As String)
    '        _mstrPhoneNumber = strval
    '    End Set
    'End Property

    'Public Property Picture As String
    '    Get
    '        Return _mstrPicture
    '    End Get
    '    Set(strval As String)
    '        _mstrPicture = strval
    '    End Set
    'End Property

    Public Property IsNewMember As Boolean
        Get
            Return _IsNewMember
        End Get
        Set(blnval As Boolean)
            _IsNewMember = blnval
        End Set
    End Property
#End Region

End Class
