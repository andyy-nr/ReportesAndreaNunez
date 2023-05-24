Imports Microsoft.Reporting.WinForms

Public Class frmVistaPrevia
    Private Sub frmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class