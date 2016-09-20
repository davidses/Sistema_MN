Imports Entidades
Imports System.Windows.Forms

Public Class frmClientes

    Dim objLogica As New Logica.Clase_logica

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Autocompletar_txtnombre()
        Estado("NADA")
        txtNombre.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Select Case btnGuardar.Text
            Case "Guardar"
                Dim lista As New eClientes

                lista.Nombre = Trim(txtNombre.Text)
                lista.Direccion = Trim(txtDireccion.Text)
                lista.Telefono = Trim(txtTelefono.Text)
                lista.Observacion = Trim(txtObservacion.Text)

                If objLogica.IngresarDatos(lista) = True Then
                    MessageBox.Show("Registro ingresado")
                Else
                    MessageBox.Show("Ocurrio un problema al ingresar los datos")
                End If

            Case "Modificar"
                Dim lista As New eClientes

                lista.Id = "2"
                lista.Nombre = Trim(txtNombre.Text)
                lista.Direccion = Trim(txtDireccion.Text)
                lista.Telefono = Trim(txtTelefono.Text)
                lista.Observacion = Trim(txtObservacion.Text)

                If objLogica.ModificarDatos(lista) = True Then
                    MessageBox.Show("Registro modificado")
                Else
                    MessageBox.Show("Ocurrio un problema al modificar lo datos.")
                End If
        End Select
    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = 13 Then
            Dim list As New List(Of eClientes)
            list = objLogica.BuscaCliente(, txtNombre.Text)

            Call CargaDatos(list)
        End If
    End Sub

    Private Sub txtId_KeyDown(sender As Object, e As KeyEventArgs) Handles txtId.KeyDown
        If e.KeyCode = 13 Then
            Dim list As New List(Of eClientes)
            list = objLogica.BuscaCliente(txtId.Text)

            Call CargaDatos(list)
        End If
    End Sub

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtId.Enabled = True
                Me.txtDireccion.Enabled = False
                Me.txtTelefono.Enabled = False
                Me.txtObservacion.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Me.lblInfo.Text = "F3 = Busca"
                Me.lblInfo.ForeColor = Color.Black
                Call limpiaTxt()
                Me.txtNombre.Focus()
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtId.Enabled = False
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
                Me.lblInfo.Text = "NUEVO"
                Me.lblInfo.ForeColor = Color.Green
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtId.Enabled = False
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
                Me.lblInfo.Text = "EDITANDO"
                Me.lblInfo.ForeColor = Color.LightSkyBlue
        End Select
    End Sub

    Private Sub CargaDatos(ByVal datos As List(Of eClientes))
        txtId.Text = datos(0).Id
        txtNombre.Text = datos(0).Nombre
        txtDireccion.Text = datos(0).Direccion
        txtTelefono.Text = datos(0).Telefono
        txtObservacion.Text = datos(0).Observacion
    End Sub
    Private Sub Autocompletar_txtnombre()
        Dim list = objLogica.Autocompletar_txtNombreCliente

        For Each item In list
            txtNombre.AutoCompleteCustomSource.Add(item.Nombre)
        Next
    End Sub

    Private Sub limpiaTxt()
        txtId.Text = ""
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtTelefono.Text = ""
        txtObservacion.Text = ""
    End Sub

    Private Sub btnEsc_Click(sender As Object, e As EventArgs) Handles btnEsc.Click
        Call Estado("NADA")
    End Sub

   
   
    
End Class