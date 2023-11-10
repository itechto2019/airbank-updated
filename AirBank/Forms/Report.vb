Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class Report
    Private Sub Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New ReportData() ' Replace with your actual report class name
        ReportViewer.ReportSource = report
    End Sub
End Class