Imports Entidades

Public Class frmFichas
    Dim objLogica As New Logica.nFichas
    Dim objLogicaEquipos As New Logica.nEquipos
    Dim objLogicaClientes As New Logica.nClientes
    Dim objLogicaFichas As New Logica.nFichas

    Private Sub frmFichas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Estado("NADA")
    End Sub

    Private Sub txtFicha_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFicha.KeyDown
        If e.KeyCode = 13 Then
            If txtFicha.Text <> "" Then
                Call BuscaFicha()
            Else
                txtFicha.Text = UltimaFicha()
                Estado("NUEVO")
                cboEstado.Text = "INGRESO"
            End If
        End If
    End Sub

    Private Sub txtIdEquipo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIdEquipo.KeyDown
        If e.KeyCode = 13 Then
            If txtIdEquipo.Text <> "" Then
                Call BuscaEquipos()
            End If
        End If
    End Sub

    Private Sub btnESC_Click(sender As Object, e As EventArgs) Handles btnESC.Click
        Estado("NADA")
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If btnGuardar.Text = "Guardar" Then
            Call IngresaFicha()
        Else
            Call ModificaFicha()
        End If
    End Sub
    Private Sub txtFicha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFicha.KeyPress
        Call SoloNumeros(e)
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Call EliminaFicha()
    End Sub





    Sub BuscaFicha()
        Dim objFichas As New eFichas
        objFichas = objLogicaFichas.BuscaFicha(txtFicha.Text)

        If objFichas.Id <> "" Then ' SE ENCONTRO LA FICHA
            Estado("EDITANDO")
            Call CargaDatosFicha(objFichas)
            Call BuscaEquipos()
        Else ' NO SE ENCONTRO LA FICHA
            Estado("NADA")
        End If
    End Sub

    Sub BuscaEquipos()
        Dim objEquipos As New eEquipos
        objEquipos = objLogicaEquipos.BuscaEquipo(txtIdEquipo.Text)

        If objEquipos.Id <> "" Then   ' Si encuentra un equipo lo carga, sino, prepara el form para la carga de uno nuevo.
            Call CargaDatosEquipos(objEquipos)
        Else
            ' crea qel euipo ***************
        End If
    End Sub

    Private Sub IngresaFicha()
        Dim Ficha As New eFichas
        Dim fecha As Date = dtpFecha.Value

        Ficha.Id = Trim(txtFicha.Text)
        Ficha.Fecha = Format(fecha, "yyyy-MM-dd") ' yyyy.MM.dd
        Ficha.Equipos_IdEquipos = Trim(txtIdEquipo.Text)
        Ficha.Estado = Trim(cboEstado.Text)
        Ficha.Realizar = Trim(txtRealizar.Text)
        Ficha.Realizado = Trim(txtRealizado.Text)
        Ficha.Importe = Trim(txtImporte.Text)
        Ficha.Observaciones = Trim(txtObservaciones.Text)

        If objLogicaFichas.IngresaFicha(Ficha) Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al ingresar los datos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub ModificaFicha()
        Dim Ficha As New eFichas
        Dim fecha As Date = dtpFecha.Value

        Ficha.Id = Trim(txtFicha.Text)
        Ficha.Fecha = Format(fecha, "yyyy-MM-dd")
        Ficha.Equipos_IdEquipos = Trim(txtIdEquipo.Text)
        Ficha.Estado = Trim(cboEstado.Text)
        Ficha.Realizar = Trim(txtRealizar.Text)
        Ficha.Realizado = Trim(txtRealizado.Text)
        Ficha.Importe = Trim(txtImporte.Text)
        Ficha.Observaciones = Trim(txtObservaciones.Text)

        If objLogicaFichas.ModificarFicha(Ficha) = True Then
            Call Estado("NADA")
        Else
            MessageBox.Show("Ocurrio un problema al modificar los datos.", "Modificar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub EliminaFicha()
        If MessageBox.Show("¿Seguro que desea eliminar la ficha?", "Eliminar ficha", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If objLogicaFichas.EliminarFicha(txtFicha.Text) Then
                Call Estado("NADA")
            Else
                MessageBox.Show("Ocurrio un problema al eliminar la ficha.", "Eliminar datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CargaDatosFicha(ByVal datos As eFichas)
        Dim fecha As Date = datos.Fecha

        txtFicha.Text = datos.Id
        dtpFecha.Text = Format(fecha, "dd/MM/yyyy")
        txtIdEquipo.Text = datos.Equipos_IdEquipos
        cboEstado.Text = datos.Estado
        txtRealizar.Text = datos.Realizar
        txtRealizado.Text = datos.Realizado
        txtImporte.Text = datos.Importe
        txtObservaciones.Text = datos.Observaciones
    End Sub

    Private Sub CargaDatosEquipos(ByVal datos As eEquipos)
        Dim objCliente As New eClientes
        objCliente = objLogicaClientes.BuscaCliente(datos.IdCliente)

        txtNombreEquipo.Text = datos.Nombre
        lblCliente.Text = objCliente.Nombre
    End Sub

    Private Function UltimaFicha() As Integer
        Dim objFicha As New eFichas
        Dim Id_ As Integer
        objFicha = objLogica.UltimoIdFicha

        If objFicha Is Nothing Then
            Id_ = 1
        Else
            Id_ = objFicha.Id + 1
        End If

        Return Id_

    End Function

    Private Sub Estado(Est As String)
        Select Case Est
            Case "NADA" ' estando en el que el abm no esta pediente de ninguna accion
                Me.txtFicha.Enabled = True
                Me.dtpFecha.Enabled = True
                Me.txtIdEquipo.Enabled = False
                Me.txtNombreEquipo.Enabled = False
                Me.grbInformacion.Enabled = False
                Me.lblCliente.Text = ""
                Me.cboEstado.Enabled = False
                Me.txtRealizar.Enabled = False
                Me.txtRealizado.Enabled = False
                Me.txtImporte.Enabled = False
                Me.txtObservaciones.Enabled = False
                Me.btnGuardar.Enabled = False
                Me.btnEliminar.Enabled = False
                Call limpiaTxt()
                Me.txtFicha.Focus()

            Case "NUEVO" ' estado del abm en el que esta creando un nuevo registro
                Me.txtFicha.Enabled = False
                Me.dtpFecha.Enabled = True
                Me.txtIdEquipo.Enabled = True
                Me.txtNombreEquipo.Enabled = True
                Me.grbInformacion.Enabled = True
                Me.lblCliente.Text = ""
                Me.cboEstado.Enabled = True
                Me.txtRealizar.Enabled = True
                Me.txtRealizado.Enabled = True
                Me.txtImporte.Enabled = True
                Me.txtObservaciones.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Guardar"
                Me.btnEliminar.Enabled = False
                Me.txtIdEquipo.Focus()

            Case "EDITANDO" ' estado del abm en el que esta editando un registro
                Me.txtFicha.Enabled = False
                Me.dtpFecha.Enabled = True
                Me.txtIdEquipo.Enabled = True
                Me.txtNombreEquipo.Enabled = True
                Me.grbInformacion.Enabled = True
                Me.lblCliente.Text = ""
                Me.cboEstado.Enabled = True
                Me.txtRealizar.Enabled = True
                Me.txtRealizado.Enabled = True
                Me.txtImporte.Enabled = True
                Me.txtObservaciones.Enabled = True
                Me.btnGuardar.Enabled = True
                Me.btnGuardar.Text = "Modificar"
                Me.btnEliminar.Enabled = True
                Me.txtIdEquipo.Focus()
        End Select
    End Sub

    Private Sub limpiaTxt()
        Me.txtFicha.Text = ""
        Me.txtIdEquipo.Text = ""
        Me.txtNombreEquipo.Text = ""
        Me.cboEstado.Text = ""
        Me.txtRealizar.Text = ""
        Me.txtRealizado.Text = ""
        Me.txtImporte.Text = ""
        Me.txtObservaciones.Text = ""
    End Sub

    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub


End Class