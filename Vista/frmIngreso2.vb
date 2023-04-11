Imports Entidades

Public Class frmIngreso2
    Dim objLogicaOrdenes As New Logica.nOrdenes


    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmIngreso2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Estado("NADA")
    End Sub

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtOrden.Enabled = True
                Me.dtpFecha.Enabled = False
                Me.txtPropietario.Enabled = False
                Me.txtDomicilio.Enabled = False
                Me.txtTelefono.Enabled = False
                Me.txtEmail.Enabled = False
                Me.txtEquipo.Enabled = False
                Me.txtDiagnostico.Enabled = False
                Me.cboEstado.Enabled = False
                Me.cboUbicacion.Enabled = False
                Me.btnImprimir.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Call limpiaTxt()
                Me.txtOrden.Focus()
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtOrden.Enabled = False
                Me.dtpFecha.Enabled = True
                Me.txtPropietario.Enabled = True
                Me.txtDomicilio.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtEmail.Enabled = True
                Me.txtEquipo.Enabled = True
                Me.txtDiagnostico.Enabled = True
                Me.cboEstado.Enabled = True
                Me.cboEstado.Text = "1 - INGRESO"
                Me.cboUbicacion.Enabled = True
                Me.cboUbicacion.Text = "1 - VENTAS"
                Me.btnImprimir.Enabled = False
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
                Me.btnEliminar.Enabled = False
                Me.txtPropietario.Focus()
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtOrden.Enabled = False
                Me.dtpFecha.Enabled = True
                Me.txtPropietario.Enabled = True
                Me.txtDomicilio.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtEmail.Enabled = True
                Me.txtEquipo.Enabled = True
                Me.txtDiagnostico.Enabled = True
                Me.cboEstado.Enabled = True
                Me.cboUbicacion.Enabled = True
                Me.btnImprimir.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
                Me.txtPropietario.Focus()
        End Select
    End Sub

    Private Sub limpiaTxt()
        Me.txtOrden.Text = ""
        Me.dtpFecha.Text = ""
        Me.txtPropietario.Text = ""
        Me.txtDomicilio.Text = ""
        Me.txtTelefono.Text = ""
        Me.txtEmail.Text = ""
        Me.txtEquipo.Text = ""
        Me.txtDiagnostico.Text = ""
        Me.cboEstado.Text = ""
        Me.cboUbicacion.Text = ""
    End Sub

    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        If e.KeyCode = 13 Then
            If txtOrden.Text = "" Then
                Call OrdenNueva()
            Else
                Call BuscaOrden()
            End If
        End If
    End Sub
    Sub OrdenNueva()
        txtOrden.Text = objLogicaOrdenes.BuscaUltimaOrden + 1
        Estado("NUEVO")
    End Sub

    Sub BuscaOrden()
        Dim objOrden As New eOrdenes
        objOrden = objLogicaOrdenes.BuscaOrden2(txtOrden.Text)

        If objOrden.Id <> "" Then ' SE ENCONTRO LA ORDEN
            Estado("EDITANDO")
            Call CargaDatosOrden(objOrden)
        Else ' NO SE ENCONTRO LA FICHA
            Estado("NUEVO")
        End If
    End Sub



    Private Sub CargaDatosOrden(ByVal datos As eOrdenes)
        Dim fecha As Date = datos.FechaIngreso

        Me.dtpFecha.Text = Format(fecha, "dd/MM/yyyy")
        Me.txtPropietario.Text = datos.Propietario
        Me.txtDomicilio.Text = datos.Domicilio
        Me.txtTelefono.Text = datos.Telefono
        Me.txtEmail.Text = datos.Email
        Me.txtEquipo.Text = datos.Equipo
        Me.txtDiagnostico.Text = datos.Diagnostico
        Me.cboEstado.Text = datos.Estado
        Me.cboUbicacion.Text = datos.Ubicacion
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call Estado("NADA")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Guardar" Then
            Call GuardaOrden()
        Else
            Call ModificaOrden()
        End If
    End Sub

    Private Sub GuardaOrden()
        Dim orden As New eOrdenes
        Dim fecha As Date = dtpFecha.Value

        orden.Orden = Trim(txtOrden.Text)
        orden.FechaIngreso = Format(fecha, "yyyy-MM-dd")
        orden.Propietario = Trim(txtPropietario.Text)
        orden.Domicilio = Trim(txtDomicilio.Text)
        orden.Telefono = Trim(txtTelefono.Text)
        orden.Email = Trim(txtEmail.Text)
        orden.Equipo = Trim(txtEquipo.Text)
        orden.Diagnostico = Trim(txtDiagnostico.Text)
        orden.Ubicacion = Trim(cboUbicacion.Text)
        orden.Estado = Trim(cboEstado.Text)

        If objLogicaOrdenes.GuardaOrden(orden) Then
            If MessageBox.Show("¿Desea imprimir la ORDEN de ingreso?", "Impresion de orden", MessageBoxButtons.YesNo) = vbYes Then
                Call ImprimeOrden()
            End If
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al ingresar los datos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ModificaOrden()
        Dim orden As New eOrdenes
        Dim fecha As Date = dtpFecha.Value

        orden.Orden = Trim(txtOrden.Text)
        orden.FechaIngreso = Format(fecha, "yyyy-MM-dd")
        orden.Propietario = Trim(txtPropietario.Text)
        orden.Domicilio = Trim(txtDomicilio.Text)
        orden.Telefono = Trim(txtTelefono.Text)
        orden.Email = Trim(txtEmail.Text)
        orden.Equipo = Trim(txtEquipo.Text)
        orden.Diagnostico = Trim(txtDiagnostico.Text)
        orden.Ubicacion = Trim(cboUbicacion.Text)
        orden.Estado = Trim(cboEstado.Text)

        If objLogicaOrdenes.ModificaOrden(orden) = True Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al modificar los datos.", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub txtOrden_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOrden.KeyPress
        Call SoloNumeros(e)
        If Asc(e.KeyChar) = Keys.Enter Then 'ELIMINA BEEP
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        Call ImprimeOrden()
    End Sub

    Sub ImprimeOrden()
        frmReporteOrden.pNumOrden = txtOrden.Text
        frmReporteOrden.pFecha = dtpFecha.Text
        frmReporteOrden.pPropietario = txtPropietario.Text
        If txtDomicilio.Text = "" Then
            frmReporteOrden.pDomicilio = " "
        Else
            frmReporteOrden.pDomicilio = txtDomicilio.Text
        End If
        If txtTelefono.Text = "" Then
            frmReporteOrden.pTelefono = " "
        Else
            frmReporteOrden.pTelefono = txtTelefono.Text
        End If
        If txtEmail.Text = "" Then
            frmReporteOrden.pEmail = " "
        Else
            frmReporteOrden.pEmail = txtEmail.Text
        End If
        frmReporteOrden.pEquipo = txtEquipo.Text
        frmReporteOrden.pDiagnostico = txtDiagnostico.Text

        frmReporteOrden.ShowDialog()
    End Sub


End Class