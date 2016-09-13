Imports Entidades
Imports Logica
Imports System.Windows.Forms

Public Class frmCliente

    Private Sub frmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Dim objnegocio As New Logica.Clase_logica

    Private Sub Show_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub cargar()
        Dim bs As New BindingSource

        bs.DataSource = objnegocio.Mostrar
        DataGridView1.DataSource = bs
        BindingNavigator1.BindingSource = bs
        txtId.DataBindings.Clear()
        txtId.DataBindings.Add(New Binding("text", bs, "Id"))
        txtNombre.DataBindings.Clear()
        txtNombre.DataBindings.Add(New Binding("text", bs, "Nombre"))
        txtDireccion.DataBindings.Clear()
        txtDireccion.DataBindings.Add(New Binding("text", bs, "Direccion"))
        txtTelefono.DataBindings.Clear()
        txtTelefono.DataBindings.Add(New Binding("text", bs, "Telefono"))
        txtObservacion.DataBindings.Clear()
        txtObservacion.DataBindings.Add(New Binding("text", bs, "Observacion"))

    End Sub

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles btnAgregar.Click
        Dim lista As New eClientes

        If (Not (String.IsNullOrEmpty(txtId.Text))) Then
            lista.Id = Trim(txtId.Text)
        Else
            ErrorProvider1.SetError(txtId, "Id")
        End If

        If (Not (String.IsNullOrEmpty(txtNombre.Text))) Then
            lista.Nombre = txtNombre.Text
        Else
            ErrorProvider1.SetError(txtNombre, "Nombre")
        End If

        If (Not (String.IsNullOrEmpty(txtDireccion.Text))) Then
            lista.Direccion = txtDireccion.Text
        Else
            ErrorProvider1.SetError(txtDireccion, "Direccion")
        End If

        If (Not (String.IsNullOrEmpty(txtTelefono.Text))) Then
            lista.Telefono = txtTelefono.Text
        Else
            ErrorProvider1.SetError(txtTelefono, "Telefono")
        End If

        If (Not (String.IsNullOrEmpty(txtObservacion.Text))) Then
            lista.Observacion = txtObservacion.Text
        Else
            ErrorProvider1.SetError(txtObservacion, "Observacion")
        End If

        If objnegocio.IngresarDatos(lista) = True Then
            MessageBox.Show("datos agregados exitosamente")
            cargar()
        Else
            MessageBox.Show("Datos no se agregaron")
        End If

    End Sub

    Private Sub BModificar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnModificar.Click
        Dim lista As New eClientes

        lista.Id = CStr(DataGridView1.CurrentRow.Cells(0).Value)

        'If (Not (String.IsNullOrEmpty(TNombres.Text))) Then
        '    lista.nombres = TNombres.Text
        'Else
        '    ErrorProvider1.SetError(TNombres, "Nombres")
        'End If

        'If (Not (String.IsNullOrEmpty(TCargo.Text))) Then
        '    lista.cargo = TCargo.Text
        'Else
        '    ErrorProvider1.SetError(TCargo, "Cargo")
        'End If

        'If (Not (String.IsNullOrEmpty(TJefe.Text))) Then
        '    lista.jefe = TJefe.Text
        'Else
        '    ErrorProvider1.SetError(TJefe, "Jefe")
        'End If

        'If (Not (String.IsNullOrEmpty(TDepartamento.Text))) Then
        '    lista.departamento = TDepartamento.Text
        'Else
        '    ErrorProvider1.SetError(TDepartamento, "Departamento")
        'End If

        'If objnegocio.ModificarDatos(lista) = True Then
        '    MessageBox.Show("Datos se modificaron exitosamente")
        '    cargar()
        'Else
        '    MessageBox.Show("Datos no se modificaron")
        'End If
    End Sub

    Private Sub BEliminar_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        'Dim codigo As String = CStr(DataGridView1.CurrentRow.Cells(0).Value)
        'If objnegocio.EliminarDatos(codigo) = True Then
        '    MessageBox.Show("Registro eliminado")
        '    cargar()
        'Else
        '    MessageBox.Show("registro no fue eliminado")
        'End If
    End Sub

End Class