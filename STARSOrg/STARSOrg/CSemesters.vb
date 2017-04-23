Imports System.Data.SqlClient
Public Class CSemesters
    'NOTE: CLASSES WHICH ARE PLURAL FORMS ARE MANAGERS FOR SINGULAR FORMS
    'Represents the Semester table and its associated business rules
    Private _Semester As CSemester
    'constructor
    Public Sub New()
        'instantiate the CSemester object
        _Semester = New CSemester
    End Sub

    Public ReadOnly Property CurrentObject() As CSemester
        'exposes the CSemester object to the GUI layer
        Get
            Return _Semester
        End Get
    End Property
    Public Sub CreateNewSemester()
        'call this when clearing the edit portion of the screen to add a new Semester
        Clear()
        _Semester.IsNewSemester = True
    End Sub
    Public Sub Clear()
        _Semester = New CSemester
    End Sub
    Public Function Save() As Integer
        Return _Semester.Save
    End Function
    Public Function GetAllSemesters() As SqlDataReader
        Return myDB.GetDataReaderBySP("dbo.sp_GetAllSemesters", Nothing)
    End Function
    Public Function GetSemesterByID(strID As String) As CSemester
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterID", strID))
        FillObject(myDB.GetDataReaderBySP("dbo.sp_GetSemesterByID", params))
        Return _Semester
    End Function
    Private Function FillObject(sqlDR As SqlDataReader) As CSemester
        Using sqlDR
            If sqlDR.Read() Then 'found the Semester record
                With _Semester
                    .SemesterID = sqlDR.Item("SemesterID") & ""
                    .SemesterDescription = sqlDR.Item("SemesterDescription") & ""
                End With
            End If
        End Using
        sqlDR.Close()
        Return _Semester
    End Function
End Class
