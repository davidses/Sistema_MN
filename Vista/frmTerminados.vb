Imports Entidades

Public Class frmTerminados
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub frmTerminados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estado("NADA")
        Me.txtOrden.Focus()
    End Sub

    Private Sub txtFicha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrden.KeyPress
        Call SoloNumeros(e)
        If Asc(e.KeyChar) = Keys.Enter Then 'ELIMINA BEEP
            e.Handled = True
        End If

    End Sub

    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        If e.KeyCode = 13 Then
            If txtOrden.Text <> "" Then
                Call BuscaOrden()
            End If
        End If
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

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtOrden.Enabled = True
                Me.dtpFecha.Text = ""
                Me.dtpFecha.Enabled = False
                Me.txtTrabajos.Enabled = False
                Me.txtImporte.Enabled = False
                Me.cboTecnico.Enabled = False
                Me.cboEstado.Enabled = False
                Me.cboUbicacion.Enabled = False
                Me.btnGuardar.Enabled = False
                Call limpiaTxt()
                Me.txtOrden.Focus()
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtOrden.Enabled = False
                Me.dtpFecha.Enabled = True
                Me.txtTrabajos.Enabled = True
                Me.txtImporte.Enabled = True
                Me.cboTecnico.Enabled = True
                Me.cboEstado.Enabled = True
                Me.cboUbicacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.txtTrabajos.Focus()
        End Select
    End Sub

    Private Sub limpiaTxt()
        Me.txtOrden.Text = ""
        Me.lblCliente.Text = ""
        Me.lblEquipo.Text = ""
        Me.txtTrabajos.Text = ""
        Me.txtImporte.Text = ""
        Me.cboTecnico.Text = ""
        Me.cboEstado.Text = ""
        Me.cboUbicacion.Text = ""
    End Sub

    Sub BuscaOrden()
        Dim objOrden As New eOrdenes
        objOrden = objLogicaOrdenes.BuscaOrden2(txtOrden.Text)

        If objOrden.Orden <> "" Then ' SE ENCONTRO LA ORDEN
            Estado("EDITANDO")
            Call CargaDatosOrden(objOrden)
        Else ' NO SE ENCONTRO LA FICHA
            Estado("NADA")
        End If
    End Sub

    Private Sub CargaDatosOrden(ByVal datos As eOrdenes)
        Dim fecha As Date

        If datos.FechaTerminado <> Nothing Then
            fecha = datos.FechaTerminado
            dtpFecha.Text = Format(fecha, "dd/MM/yyyy")
        End If

        lblCliente.Text = datos.Propietario
        lblEquipo.Text = datos.Equipo
        txtTrabajos.Text = datos.Trabajos
        txtImporte.Text = datos.Importe
        cboTecnico.Text = datos.Tecnico
        cboEstado.Text = datos.Estado
        cboUbicacion.Text = datos.Ubicacion
    End Sub

    'Private Sub IngresaTerminado()
    'Dim Orden As New eTerminados
    'Dim fecha As Date = dtpFecha.Value

    '    Orden.Orden = Trim(txtOrden.Text)
    '    Orden.Fecha = Format(fecha, "yyyy-MM-dd")
    '    Orden.Cliente = Trim(txtCliente.Text)
    '    Orden.MarcaModelo = Trim(txtMarcaModelo.Text)
    '    Orden.Trabajos = Trim(txtTrabajos.Text)
    '    Orden.Importe = Trim(txtImporte.Text)
    '    Orden.Tecnico = Trim(cboTecnico.Text)
    '    Orden.Estado = Trim(cboEstado.Text)

    'If objLogicaOrdenes.IngresaTerminados(Orden) Then
    'Call Estado("NADA")
    'Else
    '        MessageBox.Show("Ocurrio un problema al ingresar los datos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
    'End Sub

    Private Sub ModificaTerminado()
        Dim Orden As New eOrdenes
        Dim fecha As Date = dtpFecha.Value

        Orden.Orden = Trim(txtOrden.Text)
        Orden.FechaTerminado = Format(fecha, "yyyy-MM-dd")
        Orden.Trabajos = Trim(txtTrabajos.Text)
        Orden.Importe = Trim(txtImporte.Text)
        Orden.Tecnico = Trim(cboTecnico.Text)
        Orden.Estado = Trim(cboEstado.Text)
        Orden.Ubicacion = Trim(cboUbicacion.Text)

        If objLogicaOrdenes.ModificaOrdenST(Orden) = True Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al modificar los datos.", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub


    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Guardar" Then
            'Call IngresaTerminado()
        Else
            Call ModificaTerminado()
        End If
    End Sub

    'Private Sub EliminaTerminado()
    'If MessageBox.Show("¿Seguro que desea eliminar la ficha?", "Eliminar ficha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
    'If objLogicaOrdenes.EliminarTerminado(txtOrden.Text) Then
    'Call Estado("NADA")
    'Else
    '            MessageBox.Show("Ocurrio un problema al eliminar la Orden.", "Eliminar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
    'End If
    'End If
    'End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Estado("NADA")
    End Sub

    'Private Sub btnEliminar_Click(sender As Object, e As EventArgs)
    'Call EliminaTerminado()
    'End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmTerminadosListados.Show()
    End Sub


End Class