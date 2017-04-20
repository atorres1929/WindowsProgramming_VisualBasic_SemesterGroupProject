Imports System.Data.SqlClient

Public Class CAudits

    Private _mAudit As CAudit

    Public Sub New()
        _mAudit = New CAudit
    End Sub

    Public ReadOnly Property CurrentObject() As CAudit
        Get
            Return _mAudit
        End Get
    End Property

    Public Sub CreateNewAudit()
        Clear()

    End Sub

    Public Sub Clear()
        _mAudit = New CAudit
    End Sub

    Public Function FillObject(reader As SqlDataReader) As CAudit
        Using reader
            If reader.Read() Then 'found record
                With _mAudit
                    .UKID = reader.Item("UKID") & ""
                    .PantherID = reader.Item("PID") & ""
                    .AccessTimeStamp = reader.Item("ACCESSTIMESTAMP") & ""
                    .Success = reader.Item("SUCCESS") & ""
                End With
            End If
        End Using
        reader.Close()
        Return _mAudit
    End Function


End Class
