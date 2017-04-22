Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class frmReportEventsRSVP
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private RSVP As CRSVP

    Private Sub frmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.rpvReport.RefreshReport()
    End Sub

    Public Sub Display(strID As String)
        Me.Cursor = Cursors.WaitCursor
        RSVP = New CRSVP
        rpvReport.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptEventRSVPs.rdlc"
        ds = New DataSet
        da = RSVP.GetReportData(strID)
        da.Fill(ds)
        rpvReport.LocalReport.DataSources.Add(New ReportDataSource("dsRSVPs", ds.Tables(0)))
        rpvReport.SetDisplayMode(DisplayMode.PrintLayout)
        rpvReport.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class