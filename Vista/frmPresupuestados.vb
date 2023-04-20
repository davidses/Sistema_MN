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

        objPresupuestados = objLogicaOrdenes.ObtenerAvisar

        Me.dgvPresupuestados.Rows.Clear()

        For Each item As eOrdenes In objPresupuestados
            If item.Id <> Nothing Then
                dgvPresupuestados.Rows.Add(item.Orden, item.Propietario, item.Equipo, item.Telefono, item.Estado, item.Trabajos)
            Else
                MessageBox.Show("Error al carga los datos")
            End If
        Next

        For Each fila As DataGridViewRow In dgvPresupuestados.Rows
            If fila.Cells("colEstado").Value = "2 - PRESUPUESTADO" Then
                fila.DefaultCellStyle.BackColor = Color.White
            End If
            If fila.Cells("colEstado").Value = "5 - NO CONFIRMA" Then
                fila.DefaultCellStyle.BackColor = Color.PowderBlue
            End If
            If fila.Cells("colEstado").Value = "6 - REPARADO" Then
                fila.DefaultCellStyle.BackColor = Color.PowderBlue
            End If
            If fila.Cells("colEstado").Value = "7 - SIN REPARACION" Then
                fila.DefaultCellStyle.BackColor = Color.PowderBlue
            End If
        Next

    End Sub

    Private Sub dgvPresupuestados_SelectionChanged(sender As Object, e As EventArgs) Handles dgvPresupuestados.SelectionChanged
        txtTrabajos.Text = dgvPresupuestados.CurrentRow.Cells(5).Value.ToString
    End Sub
End Class