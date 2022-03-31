'Imports System.Windows.Forms
'Imports System
'Imports System.Collections.Generic
'Imports System.ComponentModel
'Imports System.Data
'Imports System.Drawing
'Imports System.Linq
'Imports System.Text
'Imports System.Windows.Forms


Public Class frmPrincipal

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmIngreso" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmIngreso As New frmIngreso
        frmIngreso.MdiParent = Me
        frmIngreso.WindowState = FormWindowState.Normal
        frmIngreso.Show()
    End Sub

    Private Sub tmrHoraFecha_Tick(sender As Object, e As EventArgs) Handles tmrHoraFecha.Tick
        tslHoraFecha.Text = Format(Date.Now, "HH:mm - dddd dd/MM/yyyy")
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Log As New Logica.nClientes
    End Sub

    Private Sub ToolStripButton4_Click(sender As Object, e As EventArgs) Handles ToolStripButton4.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmClientes" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmClientes As New frmClientes
        frmClientes.MdiParent = Me
        frmClientes.WindowState = FormWindowState.Normal
        frmClientes.Show()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmEquipos" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmequipos As New frmEquipos
        frmequipos.MdiParent = Me
        frmequipos.WindowState = FormWindowState.Normal
        frmequipos.Show()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmFichas" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmFichas As New frmFichas
        frmFichas.MdiParent = Me
        frmFichas.WindowState = FormWindowState.Normal
        frmFichas.Show()
    End Sub
End Class
