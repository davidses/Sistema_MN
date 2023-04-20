
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

        Call ActualizaUbicacionEstado()

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

    Private Sub tmrStockEquipos_Tick(sender As Object, e As EventArgs) Handles tmrStockEquipos.Tick

        Call ActualizaUbicacionEstado()
    End Sub

    Private Sub ActualizaUbicacionEstado()
        '(0) TOTAL VENTAS
        '(1) V-INGRESADOS
        '(2) V-PRESUPUESTADOS
        '(3) V-AVISADOS
        '(4) V-ESPERANDO
        '(5) V-CONFIRMADO
        '(6) V-TERMINADOS
        '(7) TOTAL TALLER
        '(8) T-INGRESADOS
        '(9) T-PRESUPUESTADOS
        '(10) T-AVISADOS
        '(11) T-ESPERANDO
        '(12) T-CONFIRMADO
        '(13) T-TERMINADOS


        Dim UbicacionesEstados As Array = objLogicaOrdenes.ObtenerUbicacionEstado

        lblEquiposEnVentas.Text = UbicacionesEstados(0)
        lblEquiposVentasIngresados.Text = UbicacionesEstados(1)
        lblEquiposVentasPresu.Text = UbicacionesEstados(2)
        lblEquiposVentasAvisados.Text = UbicacionesEstados(3)
        lblEquiposVentasEsperando.Text = UbicacionesEstados(4)
        lblEquiposVentasConfirmados.Text = UbicacionesEstados(5)
        lblEquiposVentasTerm.Text = UbicacionesEstados(6)

        lblEquiposEnTaller.Text = UbicacionesEstados(7)
        lblEquiposTallerIngresados.Text = UbicacionesEstados(8)
        lblEquiposTallerPresu.Text = UbicacionesEstados(9)
        lblEquiposTallerAvisados.Text = UbicacionesEstados(10)
        lblEquiposTallerEsperando.Text = UbicacionesEstados(11)
        lblEquiposTallerConfirmados.Text = UbicacionesEstados(12)
        lblEquiposTallerTerm.Text = UbicacionesEstados(13)

    End Sub

    Private Sub tssVersion_Click(sender As Object, e As EventArgs) Handles tssVersion.Click

    End Sub
End Class
