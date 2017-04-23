Imports System.Data.SqlClient
Public Class CSemester
    Private _mstrSemesterID As String
    Private _mstrSemesterDescription As String
    Private _isNewSemester As Boolean

    Public Sub New()
        _mstrSemesterID = ""
        _mstrSemesterDescription = ""
    End Sub

#Region "Properties"
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property SemesterDescription As String
        Get
            Return _mstrSemesterDescription
        End Get
        Set(strVal As String)
            _mstrSemesterDescription = strVal
        End Set
    End Property
    Public Property IsNewSemester As Boolean
        Get
            Return _isNewSemester
        End Get
        Set(blnVal As Boolean)
            _isNewSemester = blnVal
        End Set
    End Property
#End Region

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            params.Add(New SqlParameter("SemesterDescription", _mstrSemesterDescription))
            Return params
        End Get
    End Property
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we can't create a new record with duplicate id)
        If IsNewSemester Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("SemesterID", _mstrSemesterID))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckSemesterIDExists", params)
            If Not strRes = 0 Then
                Return -1 'not UNIQUE!
            End If
        End If
        'if not a new Semester, or it is new and has a unique id, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveSemester", GetSaveParameters)
    End Function
End Class
