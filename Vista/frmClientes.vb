Imports Entidades
Imports System.Windows.Forms

Public Class frmClientes

    Dim objLogica As New Logica.Clase_logica

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

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtDireccion.Enabled = False
                Me.txtTelefono.Enabled = False
                Me.txtObservacion.Enabled = False
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservacion.Enabled = True
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
        End Select
    End Sub

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estado("NADA")
    End Sub
End Class