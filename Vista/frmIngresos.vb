Imports Entidades
Public Class frmIngresos
    Dim objLogica As New Logica.nFichas
    Dim objLogicaEquipos As New Logica.nEquipos
    Dim objLogicaClientes As New Logica.nClientes
    Dim objLogicaFichas As New Logica.nFichas

    Private Sub txtIdEquipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdEquipo.KeyDown
        If e.KeyCode = 13 Then
            If txtIdEquipo.Text <> "" Then
                Call CargaInfoEquipos()
                Call CargaGrillaFichasPorEquipo()
            End If
        End If
    End Sub





    Sub CargaInfoEquipos()
        Dim objEquipos As New eEquipos
        Dim objCliente As New eClientes

        objEquipos = objLogicaEquipos.BuscaEquipo(txtIdEquipo.Text)

        If objEquipos.IdCliente <> Nothing Then ' SI ENCUENTRA EL EQUIPO BUSCA EL NOMBRE DEL CLIENTE Y MUESTRA AMBOS DATOS EN PANTALLA.
            objCliente = objLogicaClientes.BuscaCliente(objEquipos.IdCliente)

            lblNombreEquipo.Text = objEquipos.Nombre
            lblTipo.Text = objEquipos.Tipo
            lblObsercaciones.Text = objEquipos.Observaciones
            lblNombreCliente.Text = objCliente.Nombre
        Else
            txtIdEquipo.Text = ""
        End If
    End Sub

    Sub CargaGrillaFichasPorEquipo()
        Dim objFichas As New List(Of eFichas)

        objFichas = objLogica.BuscaFichasPorEquipo(txtIdEquipo.Text)

        Me.dgvFichasPorEquipo.Rows.Clear()

        For Each item As eFichas In objFichas
            If item.Id <> Nothing Then
                dgvFichasPorEquipo.Rows.Add(item.Id, item.Realizar, item.Realizado, item.Fecha)
            Else
                MessageBox.Show("Error al mostrar las Fichas.")
            End If
        Next
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        txtIdEquipo.Text = ""
        lblNombreEquipo.Text = ""
        lblNombreCliente.Text = ""
        lblTipo.Text = ""
        lblObsercaciones.Text = ""
        txtIdEquipo.Focus()
    End Sub

    Private Sub frmIngresos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnESC.PerformClick()
        txtIdEquipo.Focus()
    End Sub

    Private Sub frmIngresos_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        txtIdEquipo.Focus()
    End Sub

    Private Sub txtIdEquipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdEquipo.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then 'ELIMINA BEEP
            e.Handled = True
        End If
    End Sub
End Class