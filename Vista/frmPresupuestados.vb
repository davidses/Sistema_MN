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
                dgvPresupuestados.Rows.Add(item.Orden, item.Propietario, item.Equipo, item.Telefono, item.Trabajos)
            Else
                MessageBox.Show("Error al carga los datos")
            End If
        Next

    End Sub

    Private Sub dgvPresupuestados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPresupuestados.SelectionChanged

        ' String Nombre = dgvPersonas .CurrentRow.Cells[0].Value.ToString(); 

        txtTrabajos.Text = dgvPresupuestados.CurrentRow.Cells(4).Value.ToString


    End Sub
End Class