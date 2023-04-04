Public Class frmTerminadosListados
    Dim objLogicaOrdenes As New Logica.nTerminados

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim mes As Integer = Format(dtpMes.Value, "MM")
        Dim tecnico As String = cboTecnico.Text

        dgvMensual.DataSource = objLogicaOrdenes.BuscaTerminadosMensual(mes, tecnico)

    End Sub
End Class