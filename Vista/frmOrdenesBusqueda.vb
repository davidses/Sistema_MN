Imports Entidades
Public Class frmOrdenesBusqueda
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim objBuscados As New List(Of eOrdenes)
        objBuscados = objLogicaOrdenes.BuscarPorNombre(txtNombre.Text)

        Call Cargadatos(objBuscados)
    End Sub

    Private Sub btnBuscarEstado_Click(sender As Object, e As EventArgs) Handles btnBuscarEstado.Click
        Dim objBuscados As New List(Of eOrdenes)
        objBuscados = objLogicaOrdenes.BuscarOrdenPorEstado(cboEstado.Text)

        Call Cargadatos(objBuscados)
    End Sub

    Private Sub Cargadatos(lista As List(Of eOrdenes))

        Me.dgvBuscados.Rows.Clear()

        If lista IsNot Nothing Then
            For Each item As eOrdenes In lista
                If item.Id <> Nothing Then
                    dgvBuscados.Rows.Add(item.Orden, item.Propietario, item.Equipo, item.Telefono, item.Trabajos, item.Estado)
                Else
                    MessageBox.Show("Error al carga los datos")
                End If
            Next
        End If

    End Sub

    Private Sub txtNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = 13 Then
            If txtNombre.Text <> "" Then
                btnBuscar.PerformClick()
            End If
        End If
    End Sub

    Private Sub frmOrdenesBusqueda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Focus()
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then 'ELIMINA BEEP
            e.Handled = True
        End If
    End Sub

    Private Sub btnBuscaPorUbicacion_Click(sender As Object, e As EventArgs) Handles btnBuscaPorUbicacion.Click
        Dim objBuscados As New List(Of eOrdenes)
        objBuscados = objLogicaOrdenes.BuscaOrdenPorUbicacion(cboUbicaciones.Text)

        If objBuscados IsNot Nothing Then Call Cargadatos(objBuscados)

    End Sub
End Class