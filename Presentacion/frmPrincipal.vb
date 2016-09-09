Imports System.Windows.Forms

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
        Dim Log As New Logica.Class1
    End Sub
End Class
