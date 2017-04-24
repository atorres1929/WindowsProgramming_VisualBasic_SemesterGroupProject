Imports System.Data.SqlClient
Public Class CCourse
    Private _mstrCourseID As String
    Private _mstrCourseName As String
    Private _isNewCourse As Boolean

    Public Sub New()
        _mstrCourseID = ""
        _mstrCourseName = ""
    End Sub

#Region "Properties"
    Public Property CourseID As String
        Get
            Return _mstrCourseID
        End Get
        Set(strVal As String)
            _mstrCourseID = strVal
        End Set
    End Property
    Public Property CourseName As String
        Get
            Return _mstrCourseName
        End Get
        Set(strVal As String)
            _mstrCourseName = strVal
        End Set
    End Property
    Public Property IsNewCourse As Boolean
        Get
            Return _isNewCourse
        End Get
        Set(blnVal As Boolean)
            _isNewCourse = blnVal
        End Set
    End Property
#End Region

    Public ReadOnly Property GetSaveParameters() As ArrayList
        Get
            Dim params As New ArrayList
<<<<<<< Updated upstream
            params.Add(New SqlParameter("courseID", _mstrCourseID))
            params.Add(New SqlParameter("courseName", _mstrCourseDescription))
=======
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            params.Add(New SqlParameter("CourseDescription", _mstrCourseDescription))
            Return params
        End Get
    End Property
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we can't create a new record with duplicate id)
        If IsNewCourse Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("CourseID", _mstrCourseID))
            Dim strRes As String = myDB.GetSingleValueFromSP("sp_CheckCourseIDExists", params)
            If Not strRes = 0 Then
                Return -1 'not UNIQUE!
            End If
        End If
        'if not a new Course, or it is new and has a unique id, then do the save (update or insert)
        Return myDB.ExecSP("sp_SaveCourse", GetSaveParameters)
    End Function
End Class

            params.Add(New SqlParameter("CourseName", _mstrCourseName))