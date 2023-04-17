Imports System.ComponentModel
Imports System.Drawing.Printing
Imports Microsoft.Reporting.WinForms
Imports Microsoft.ReportingServices.ReportProcessing.ReportObjectModel

Public Class frmReporteOrden
    Public pNumOrden As String
    Public pFecha As String
    Public pPropietario As String
    Public pDomicilio As String
    Public pTelefono As String
    Public pEmail As String
    Public pEquipo As String
    Public pDiagnostico As String

    Private Sub frmReporteOrden_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()

        Dim pg = New PageSettings

        pg.Margins.Left = 20
        pg.Margins.Right = 20
        pg.Margins.Top = 10
        pg.Margins.Bottom = 5

        Me.ReportViewer1.SetPageSettings(pg)

        Dim rparamNumOrden As ReportParameter = New ReportParameter
        Dim rparamNumOrdenBarra As ReportParameter = New ReportParameter
        Dim rparamFecha As ReportParameter = New ReportParameter
        Dim rparamPropietario As ReportParameter = New ReportParameter
        Dim rparamDomicilio As ReportParameter = New ReportParameter
        Dim rparamTelefono As ReportParameter = New ReportParameter
        Dim rparamEmail As ReportParameter = New ReportParameter
        Dim rparamEquipo As ReportParameter = New ReportParameter
        Dim rparamDiagnostico As ReportParameter = New ReportParameter

        rparamNumOrden = New ReportParameter("ParamNumOrden", pNumOrden)
        rparamNumOrdenBarra = New ReportParameter("ParamNumOrdenBarra", "*" & pNumOrden & "*")
        rparamFecha = New ReportParameter("ParamFecha", pFecha)
        rparamPropietario = New ReportParameter("ParamPropietario", pPropietario)
        rparamDomicilio = New ReportParameter("ParamDomicilio", pDomicilio)
        rparamTelefono = New ReportParameter("ParamTelefono", pTelefono)
        rparamEmail = New ReportParameter("ParamEmail", pEmail)
        rparamEquipo = New ReportParameter("ParamEquipo", pEquipo)
        rparamDiagnostico = New ReportParameter("ParamDiagnostico", pDiagnostico)

        ReportViewer1.LocalReport.SetParameters(rparamNumOrden)
        ReportViewer1.LocalReport.SetParameters(rparamNumOrdenBarra)
        ReportViewer1.LocalReport.SetParameters(rparamFecha)
        ReportViewer1.LocalReport.SetParameters(rparamPropietario)
        ReportViewer1.LocalReport.SetParameters(rparamDomicilio)
        ReportViewer1.LocalReport.SetParameters(rparamTelefono)
        ReportViewer1.LocalReport.SetParameters(rparamEmail)
        ReportViewer1.LocalReport.SetParameters(rparamEquipo)
        ReportViewer1.LocalReport.SetParameters(rparamDiagnostico)

        ReportViewer1.RefreshReport()


    End Sub
End Class