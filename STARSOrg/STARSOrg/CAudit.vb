Public Class CAudit
    Private _mintUKID As Integer
    Private _mstrPantherID As String
    Private _mdtmAccessTimeStamp As DateTime
    Private _blnSuccess As Boolean

    Public Sub New()
        _mintUKID = -1
        _mstrPantherID = ""
        _mdtmAccessTimeStamp = Nothing
        _blnSuccess = False
    End Sub

    Public Property UKID As Integer
        Get
            Return _mintUKID
        End Get
        Set(newUKID As Integer)
            _mintUKID = newUKID
        End Set
    End Property

    Public Property PantherID As String
        Get
            Return _mstrPantherID
        End Get
        Set(newPantherID As String)
            _mstrPantherID = newPantherID
        End Set
    End Property

    Public Property AccessTimeStamp As DateTime
        Get
            Return _mdtmAccessTimeStamp
        End Get
        Set(newTimeStamp As DateTime)
            _mdtmAccessTimeStamp = newTimeStamp
        End Set
    End Property

    Public Property Success As Boolean
        Get
            Return _blnSuccess
        End Get
        Set(isSuccess As Boolean)
            _blnSuccess = isSuccess
        End Set
    End Property

End Class
