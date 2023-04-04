Imports System.Runtime.InteropServices
Imports Entidades

Public Class frmPresupuestados
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub frmPresupuestados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call CargaPresupuestados()
    End Sub

    Private Sub CargaPresupuestados()
        Dim objPresupuestados As New List(Of eOrdenes)

        objPresupuestados = objLogicaOrdenes.ObtenerPresupuestados

        Me.dgvPresupuestados.Rows.Clear()

        For Each item As eOrdenes In objPresupuestados
            If item.Id <> Nothing Then
                dgvPresupuestados.Rows.Add(item.Orden, item.Propietario, item.Equipo, item.Telefono)
            Else
                MessageBox.Show("Error al carga los datos")
            End If
        Next


        'Dim objFichas As New List(Of eFichas)

        'objFichas = objLogica.BuscaFichasPorEquipo(txtIdEquipo.Text)

        'Me.dgvFichasPorEquipo.Rows.Clear()

        'For Each item As eFichas In objFichas
        'If item.Id <> Nothing Then
        'dgvFichasPorEquipo.Rows.Add(item.Id, item.Realizar, item.Realizado, item.Fecha)
        'Else
        'MessageBox.Show("Error al mostrar las Fichas.")
        'End If
        'Next
    End Sub
End Class