Imports Entidades
Public Class frmCambioUbiOrdenes
    Dim objLogicaOrdenes As New Logica.nOrdenes

    Private Sub frmCambioUbiOrdenes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtOrden.Text = ""
        txtOrden.Focus()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub


    Private Sub txtOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles txtOrden.KeyDown
        If e.KeyCode = 13 Then
            If txtOrden.Text <> "" Then
                If rabVenta.Checked Then
                    objLogicaOrdenes.ModificaUbiOrden(txtOrden.Text, "1 - VENTAS")
                ElseIf rabTaller.Checked Then
                    objLogicaOrdenes.ModificaUbiOrden(txtOrden.Text, "2 - TALLER")
                End If

                txtControl.Text += txtOrden.Text + " - "
                txtOrden.Clear()
                txtOrden.Focus()
            End If
        End If
    End Sub

    Private Sub rabVenta_Click(sender As Object, e As EventArgs) Handles rabVenta.Click
        txtOrden.Focus()
    End Sub

    Private Sub rabTaller_Click(sender As Object, e As EventArgs) Handles rabTaller.Click
        txtOrden.Focus()
    End Sub

    Private Sub frmCambioUbiOrdenes_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        txtOrden.Focus()
    End Sub

    Private Sub frmCambioUbiOrdenes_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        txtControl.Clear()
    End Sub
End Class