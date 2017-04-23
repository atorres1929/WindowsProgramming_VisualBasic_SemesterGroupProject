Imports System.Data.SqlClient
Public Class CCourses
    'NOTE: CLASSES WHICH ARE PLURAL FORMS ARE MANAGERS FOR SINGULAR FORMS
    'Represents the Course table and its associated business rules
    Private _Course As CCourse
    'constructor
    Public Sub New()
        'instantiate the CCourse object
        _Course = New CCourse
    End Sub

    Public ReadOnly Property CurrentObject() As CCourse
        'exposes the CCourse object to the GUI layer
        Get
            Return _Course
        End Get
    End Property
    Public Sub CreateNewCourse()
        'call this when clearing the edit portion of the screen to add a new Course
        Clear()
        _Course.IsNewCourse = True
    End Sub
    Public Sub Clear()
        _Course = New CCourse
    End Sub
    Public Function Save() As Integer
        Return _Course.Save
    End Function
    Public Function GetAllCourses() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllCourses", Nothing)
    End Function
    Public Function GetCourseByID(strID As String) As CCourse
        Dim params As New ArrayList
        params.Add(New SqlParameter("CourseID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetCourseByID", params))
        Return _Course
    End Function
    Private Function FillObject(sqlDR As SqlDataReader) As CCourse
        Using sqlDR
            If sqlDR.Read() Then 'found the Course record
                With _Course
                    .CourseID = sqlDR.Item("CourseID") & ""
                    .CourseDescription = sqlDR.Item("CourseDescription") & ""
                End With
            End If
        End Using
        sqlDR.Close()
        Return _Course
    End Function
End Class
