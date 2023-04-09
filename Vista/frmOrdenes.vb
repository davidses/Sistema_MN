Imports Entidades

Public Class frmOrdenes
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub mnuIngreso_Click(sender As Object, e As EventArgs) Handles mnuIngreso.Click
        frmIngreso2.Show()
    End Sub

    Private Sub mnuServicioTecnico_Click(sender As Object, e As EventArgs) Handles mnuServicioTecnico.Click
        frmTerminados.Show()
    End Sub

    Private Sub frmOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LimpiaTxt()
        txtOrden.Focus()
    End Sub
    Private Sub btnLimpia_Click(sender As Object, e As EventArgs) Handles btnLimpia.Click
        Call LimpiaTxt()
        txtOrden.Focus()
    End Sub

    Private Sub LimpiaTxt()
        txtOrden.Text = ""
        lblUbicacion.Text = ""
        lblEstado.Text = ""
        lblFechaIngreso.Text = ""
        lblPropietario.Text = ""
        lblDomicilio.Text = ""
        lblTelefono.Text = ""
        lblEmail.Text = ""
        lblEquipo.Text = ""
        lblDiagnostico.Text = ""
        lblFechaTerminado.Text = ""
        lblTrabajos.Text = ""
        lblOtros.Text = ""
        lblImporte.Text = ""
        lblTecnico.Text = ""
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        If e.KeyCode = 13 Then
            If txtOrden.Text <> "" Then
                Call BuscaOrden()
            End If
        End If
    End Sub

    Sub BuscaOrden()
        Dim objOrden As New eOrdenes
        objOrden = objLogicaOrdenes.BuscaOrden2(txtOrden.Text)

        If objOrden.Orden <> "" Then ' SE ENCONTRO LA ORDEN
            'Estado("EDITANDO")
            Call CargaDatosOrden(objOrden)
        Else ' NO SE ENCONTRO LA FICHA
            'Estado("NUEVO")
        End If
    End Sub

    Private Sub CargaDatosOrden(ByVal datos As eOrdenes)
        Dim fechaIngreso As Date
        Dim fechaTerminado As Date

        Me.lblUbicacion.Text = datos.Ubicacion
        Me.lblEstado.Text = datos.Estado
        If datos.FechaIngreso <> Nothing Then
            fechaIngreso = datos.FechaIngreso
            Me.lblFechaIngreso.Text = Format(fechaIngreso, "dd/MM/yyyy")
        End If
        Me.lblPropietario.Text = datos.Propietario
        Me.lblDomicilio.Text = datos.Domicilio
        Me.lblTelefono.Text = datos.Telefono
        Me.lblEmail.Text = datos.Email
        Me.lblEquipo.Text = datos.Equipo
        Me.lblDiagnostico.Text = datos.Diagnostico
        If datos.FechaTerminado <> Nothing Then
            fechaTerminado = datos.FechaTerminado
            Me.lblFechaTerminado.Text = Format(fechaTerminado, "dd/MM/yyyy")
        End If
        Me.lblTrabajos.Text = datos.Trabajos
        Me.lblOtros.Text = datos.Otros
        Me.lblImporte.Text = datos.Importe
        Me.lblTecnico.Text = datos.Tecnico
    End Sub

    Private Sub txtOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrden.KeyPress
        Call SoloNumeros(e)
        If Asc(e.KeyChar) = Keys.Enter Then 'ELIMINA BEEP
            e.Handled = True
        End If
    End Sub

    Private Sub F3PRESUPUESTADOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F3PRESUPUESTADOSToolStripMenuItem.Click
        frmPresupuestados.Show()
    End Sub
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub F4BUSCARPORToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles F4BUSCARPORToolStripMenuItem.Click
        frmOrdenesBusqueda.Show()
    End Sub

    Private Sub REPORTESToolStripMenuItem_Click(sender As Object, e As EventArgs)

        frmReporteOrden.Show()
    End Sub
End Class