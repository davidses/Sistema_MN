
Imports Entidades

Public Class frmPrincipal
    Dim objLogica As New Logica.nGeneral
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub tsbSalir_Click(sender As Object, e As EventArgs) Handles tsbSalir.Click
        Me.Close()
    End Sub


    Private Sub tmrHoraFecha_Tick(sender As Object, e As EventArgs) Handles tmrHoraFecha.Tick
        tslHoraFecha.Text = Format(Date.Now, "HH:mm - dddd dd/MM/yyyy")
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        objLogica.ConfigurarBD()

        If objLogica.PruebaConexion = True Then
            tssInfoDB.Text = "CONECTADO"
            tssInfoDB.ForeColor = Color.Green
        Else
            tssInfoDB.Text = "DESCONECTADO"
            tssInfoDB.ForeColor = Color.Red
        End If

        lblEquiposEnVentas.Text = objLogicaOrdenes.ObtenerStockEquipos.stockVentas
        lblEquiposEnTaller.Text = objLogicaOrdenes.ObtenerStockEquipos.stockTaller

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

    Private Sub tsbTerminados_Click(sender As Object, e As EventArgs) Handles tsbTerminados.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmTerminados" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmTerminados As New frmTerminados
        frmTerminados.MdiParent = Me
        frmTerminados.WindowState = FormWindowState.Normal
        frmTerminados.Show()
    End Sub

    Private Sub tsnIngresos_Click(sender As Object, e As EventArgs) Handles tsnOrdenes.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmOrdenes" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmOrdenes As New frmOrdenes
        frmOrdenes.MdiParent = Me
        frmOrdenes.WindowState = FormWindowState.Normal
        frmOrdenes.Show()
    End Sub

    Private Sub tsbEquiposVenta_Click(sender As Object, e As EventArgs) Handles tsbEquiposVenta.Click
        For Each f As Form In Me.MdiChildren
            If f.Name = "frmEquiposVenta" Then
                f.Activate()
                Exit Sub
            End If
        Next

        Dim frmEquiposVenta As New frmEquiposVenta
        frmEquiposVenta.MdiParent = Me
        frmEquiposVenta.WindowState = FormWindowState.Normal
        frmEquiposVenta.Show()
    End Sub

    Private Sub frmPrincipal_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated

    End Sub

    Private Sub frmPrincipal_Enter(sender As Object, e As EventArgs) Handles MyBase.Enter

    End Sub

    Private Sub tmrStockEquipos_Tick(sender As Object, e As EventArgs) Handles tmrStockEquipos.Tick
        lblEquiposEnVentas.Text = objLogicaOrdenes.ObtenerStockEquipos.stockVentas
        lblEquiposEnTaller.Text = objLogicaOrdenes.ObtenerStockEquipos.stockTaller
    End Sub
End Class
