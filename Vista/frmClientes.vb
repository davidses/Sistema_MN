Imports Entidades
Imports System.Windows.Forms

Public Class frmClientes

    Dim objLogica As New Logica.nClientes

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Autocompletar_txtnombre()
        Estado("NADA")
        txtNombre.Focus()
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = 13 Then
            Call BuscaClientes()
        End If
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            Call BuscaClientes(True) ' le pasamos el parametro true para indicar que se dio enter en el control TXTID
        End If
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case btnGuardar.Text
            Case "Guardar"
                Call IngresaCliente()
            Case "Modificar"
                Call ModificaCliente()
        End Select
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Call EliminaCliente()
    End Sub

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtId.Enabled = True
                Me.txtDireccion.Enabled = False
                Me.txtTelefono.Enabled = False
                Me.txtObservaciones.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.lblInfo.Text = ""
                Call limpiaTxt()
                Me.txtNombre.Focus()
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtId.Enabled = False
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservaciones.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
                Me.lblInfo.Text = "NUEVO"
                Me.lblInfo.ForeColor = Color.Green
                Me.txtDireccion.Focus()
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtId.Enabled = False
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservaciones.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
                Me.lblInfo.Text = "EDITANDO"
                Me.lblInfo.ForeColor = Color.SteelBlue
                Me.txtDireccion.Focus()
        End Select
    End Sub

    Private Sub BuscaClientes(Optional ByVal desde_txtid As Boolean = False)
        Dim objCliente As New eClientes
        ' Pasamos como parametro el ID o el NOMBRE del Cliente, la funcion busca segun que parametro le pasamos de los dos.
        objCliente = objLogica.BuscaCliente(txtId.Text, txtNombre.Text)

        ' Si encuentra un cliente lo carga sino, prepara el form para la carga de uno nuevo.
        If objCliente.Id <> "" Then
            Call CargaDatos(objCliente)
            Call Estado("EDITANDO")
        Else
            If Not desde_txtid Then
                Call Estado("NUEVO")
            End If
        End If
    End Sub

    Private Sub IngresaCliente()
        Dim Cli As New eClientes
        Cli.Nombre = Trim(txtNombre.Text)
        Cli.Direccion = Trim(txtDireccion.Text)
        Cli.Telefono = Trim(txtTelefono.Text)
        Cli.Observaciones = Trim(txtObservaciones.Text)

        If objLogica.IngresarCliente(Cli) = True Then
            Call Autocompletar_txtnombre()
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al ingresar los datos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub ModificaCliente()
        Dim Cli As New eClientes

        Cli.Id = Trim(txtId.Text)
        Cli.Nombre = Trim(txtNombre.Text)
        Cli.Direccion = Trim(txtDireccion.Text)
        Cli.Telefono = Trim(txtTelefono.Text)
        Cli.Observaciones = Trim(txtObservaciones.Text)

        If objLogica.ModificarCliente(Cli) = True Then
            Call Autocompletar_txtnombre()
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al modificar los datos.", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EliminaCliente()
        If MessageBox.Show("¿Seguro que desea eliminar el cliente?", "Eliminar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If objLogica.EliminarCliente(txtId.Text) Then
                Call Autocompletar_txtnombre()
                Call Estado("NADA")
            Else
                MessageBox.Show("Ocurrio un problema al eliminar el cliente.", "Eliminar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CargaDatos(ByVal datos As eClientes)
        txtId.Text = datos.Id
        txtNombre.Text = datos.Nombre
        txtDireccion.Text = datos.Direccion
        txtTelefono.Text = datos.Telefono
        txtObservaciones.Text = datos.Observaciones
    End Sub
    Private Sub Autocompletar_txtnombre()
        Dim list = objLogica.Autocompletar_txtNombreCliente

        txtNombre.AutoCompleteCustomSource.Clear()
        For Each item In list
            txtNombre.AutoCompleteCustomSource.Add(item.Nombre)
        Next
    End Sub

    Private Sub limpiaTxt()
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtObservaciones.Text = ""
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Call Estado("NADA")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class