
Public Class frmPrincipal
    Dim objLogica As New Logica.nGeneral

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmIngresos" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmIngresos As New frmIngresos
        frmIngresos.MdiParent = Me
        frmIngresos.WindowState = FormWindowState.Normal
        frmIngresos.Show()
    End Sub

    Private Sub tmrHoraFecha_Tick(sender As Object, e As EventArgs) Handles tmrHoraFecha.Tick
        tslHoraFecha.Text = Format(Date.Now, "HH:mm - dddd dd/MM/yyyy")
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Log As New Logica.nClientes

        objLogica.ConfigurarBD()

        If objLogica.PruebaConexion = True Then
            tssInfoDB.Text = "CONECTADO"
            tssInfoDB.ForeColor = Color.Green
        Else
            tssInfoDB.Text = "DESCONECTADO"
            tssInfoDB.ForeColor = Color.Red
        End If

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

    Private Sub ConexionBDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConexionBDToolStripMenuItem.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmConexionnBD" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmConexionBD As New frmConexionBD
        frmConexionBD.MdiParent = Me
        frmConexionBD.WindowState = FormWindowState.Normal
        frmConexionBD.Show()
    End Sub


End Class
