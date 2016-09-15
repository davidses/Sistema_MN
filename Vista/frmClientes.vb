Imports Entidades
Imports System.Windows.Forms

Public Class frmClientes

    Dim objLogica As New Logica.Clase_logica

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargaCbolientes()
        Estado("NADA")
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

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtDireccion.Enabled = False
                Me.txtTelefono.Enabled = False
                Me.txtObservacion.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtDireccion.Enabled = True
                Me.txtTelefono.Enabled = True
                Me.txtObservacion.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
        End Select
    End Sub

    Private Sub CargaCbolientes()
        Dim bsClientes As New BindingSource
        bsClientes.DataSource = objLogica.Mostrar

        bsClientes.Sort = "Nombre Desc"

        If Not bsClientes.IsSorted = True Then
            bsClientes.Sort = "Nombre Asc"
        End If

        If bsClientes.IsSorted = True Then
            Me.cboNombre.DataSource = bsClientes
            Me.cboNombre.DisplayMember = "Nombre"
        End If

        ''CARGA EL COMBOBOX CON LOS CLIENTES 
        'Dim oDvProveedores As DataView = New DataView(frmRetenciones.oDsProveedores.Tables(0))

        'oDvProveedores.Sort = "Nombre"
        'frmRetenciones.cboProveedores.DataSource = oDvProveedores
        'frmRetenciones.cboProveedores.DisplayMember = "Nombre"
        'frmRetenciones.cboProveedores.ValueMember = "CUIT"

        'Private Sub cargar()
        '    Dim bs As New BindingSource
        '    bs.DataSource = objnegocio.Mostrar
        '    DataGridView1.DataSource = bs
        '    BindingNavigator1.BindingSource = bs
        '    TCodigo.DataBindings.Clear()
        '    TCodigo.DataBindings.Add(New Binding("text", bs, "codigo"))
        '    TNombres.DataBindings.Clear()
        '    TNombres.DataBindings.Add(New Binding("text", bs, "nombres"))
        '    TCargo.DataBindings.Clear()
        '    TCargo.DataBindings.Add(New Binding("text", bs, "cargo"))
        '    TJefe.DataBindings.Clear()
        '    TJefe.DataBindings.Add(New Binding("text", bs, "jefe"))
        '    TDepartamento.DataBindings.Clear()
        '    TDepartamento.DataBindings.Add(New Binding("text", bs, "departamento"))
        'End Sub

    End Sub
End Class