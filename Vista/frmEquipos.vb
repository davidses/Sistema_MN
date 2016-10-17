Imports Entidades

Public Class frmEquipos

    Dim objLogica As New Logica.nEquipos

    Private Sub frmEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LlenarComboClientes()
        Estado("NADA")
        txtId.Focus()
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            Call BuscaEquipos()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub IngresaEquipo()
        Dim Equipo As New eEquipos

        Equipo.Id = Trim(txtId.Text)
        Equipo.IdCliente = cboCliente.SelectedValue.ToString
        Equipo.Tipo = Trim(cboTipo.Text)
        Equipo.Nombre = Trim(txtNombre.Text)
        Equipo.Observacion = Trim(txtObservacion.Text)

        If objLogica.IngresarEqupo(Equipo) Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al ingresar los datos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ModificaEquipo()
        Dim Equipo As New eEquipos

        Equipo.Id = Trim(txtId.Text)
        Equipo.IdCliente = cboCliente.SelectedValue.ToString
        Equipo.Tipo = Trim(cboTipo.Text)
        Equipo.Nombre = Trim(txtNombre.Text)
        Equipo.Observacion = Trim(txtObservacion.Text)

        If objLogica.ModificaEquipo(Equipo) Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al modificar los datos", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtId.Enabled = True
                Me.cboCliente.Enabled = False
                Me.cboTipo.Enabled = False
                Me.txtNombre.Enabled = False
                Me.txtObservacion.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.lblInfo.Text = ""
                Call limpiaTxt()
                Me.txtId.Focus()
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtId.Enabled = False
                Me.cboCliente.Enabled = True
                Me.cboTipo.Enabled = True
                Me.txtNombre.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
                Me.lblInfo.Text = "NUEVO"
                Me.lblInfo.ForeColor = Color.Green
                Me.cboCliente.Focus()
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtId.Enabled = False
                Me.cboCliente.Enabled = True
                Me.cboTipo.Enabled = True
                Me.txtNombre.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
                Me.lblInfo.Text = "EDITANDO"
                Me.lblInfo.ForeColor = Color.SteelBlue
                Me.cboCliente.Focus()
        End Select

    End Sub

    Sub LimpiaTxt()
        txtId.Text = ""
        cboCliente.Text = ""
        cboCliente.SelectedValue = 0
        cboTipo.Text = ""
        txtNombre.Text = ""
        txtObservacion.Text = ""
    End Sub

    Sub LlenarComboClientes()
        Dim list = objLogica.LlenarComboClientes

        cboCliente.DataSource = list
        cboCliente.DisplayMember = "Nombre"
        cboCliente.ValueMember = "Id"
    End Sub

    Sub BuscaEquipos()
        Dim objEquipos As New eEquipos
        objEquipos = objLogica.BuscaEquipo(txtId.Text)

        ' Si encuentra un equipo lo carga, sino, prepara el form para la carga de uno nuevo.
        If objEquipos.Id <> "" Then
            Call CargaDatos(objEquipos)
            Call Estado("EDITANDO")
        Else
            Call Estado("NUEVO")
        End If
    End Sub

    Private Sub CargaDatos(ByVal datos As eEquipos)
        txtId.Text = datos.Id
        cboCliente.SelectedValue = datos.IdCliente
        cboTipo.Text = datos.Tipo
        txtNombre.Text = datos.Nombre
        txtObservacion.Text = datos.Observacion
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Call Estado("NADA")
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case btnGuardar.Text
            Case "Guardar"
                Call IngresaEquipo()
            Case "Modificar"
                Call ModificaEquipo()
        End Select
    End Sub
End Class