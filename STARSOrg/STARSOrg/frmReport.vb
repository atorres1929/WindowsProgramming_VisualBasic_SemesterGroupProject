Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmReport
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Role As CRole

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class