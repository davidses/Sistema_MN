<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFichas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFicha = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.txtIdEquipo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreEquipo = New System.Windows.Forms.TextBox()
        Me.grbInformacion = New System.Windows.Forms.GroupBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtRealizar = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRealizado = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnESC = New System.Windows.Forms.Button()
        Me.grbInformacion.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(0, 11)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(616, 39)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Fichas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFicha
        '
        Me.txtFicha.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtFicha.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtFicha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFicha.Location = New System.Drawing.Point(130, 85)
        Me.txtFicha.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFicha.MaxLength = 50
        Me.txtFicha.Name = "txtFicha"
        Me.txtFicha.Size = New System.Drawing.Size(91, 22)
        Me.txtFicha.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(429, 88)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Fecha"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(130, 505)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(459, 106)
        Me.txtObservaciones.TabIndex = 9
        '
        'txtImporte
        '
        Me.txtImporte.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(130, 475)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtImporte.MaxLength = 25
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(91, 22)
        Me.txtImporte.TabIndex = 8
        '
        'txtIdEquipo
        '
        Me.txtIdEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtIdEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdEquipo.Location = New System.Drawing.Point(130, 112)
        Me.txtIdEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIdEquipo.MaxLength = 50
        Me.txtIdEquipo.Name = "txtIdEquipo"
        Me.txtIdEquipo.Size = New System.Drawing.Size(91, 22)
        Me.txtIdEquipo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(70, 478)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Importe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 508)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Observaciones"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 115)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID Equipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 88)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FICHA"
        '
        'txtNombreEquipo
        '
        Me.txtNombreEquipo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEquipo.Location = New System.Drawing.Point(239, 112)
        Me.txtNombreEquipo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombreEquipo.MaxLength = 50
        Me.txtNombreEquipo.Name = "txtNombreEquipo"
        Me.txtNombreEquipo.Size = New System.Drawing.Size(350, 22)
        Me.txtNombreEquipo.TabIndex = 4
        '
        'grbInformacion
        '
        Me.grbInformacion.Controls.Add(Me.lblCliente)
        Me.grbInformacion.Location = New System.Drawing.Point(130, 151)
        Me.grbInformacion.Name = "grbInformacion"
        Me.grbInformacion.Size = New System.Drawing.Size(459, 55)
        Me.grbInformacion.TabIndex = 28
        Me.grbInformacion.TabStop = False
        Me.grbInformacion.Text = "Información del cliente"
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.Location = New System.Drawing.Point(30, 27)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(48, 16)
        Me.lblCliente.TabIndex = 0
        Me.lblCliente.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(72, 219)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 16)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"INGRESO", "PENDIENTE", "TERMINADO", "ENTREGADO"})
        Me.cboEstado.Location = New System.Drawing.Point(130, 216)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(133, 24)
        Me.cboEstado.TabIndex = 5
        '
        'txtRealizar
        '
        Me.txtRealizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRealizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRealizar.Location = New System.Drawing.Point(130, 247)
        Me.txtRealizar.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRealizar.MaxLength = 150
        Me.txtRealizar.Multiline = True
        Me.txtRealizar.Name = "txtRealizar"
        Me.txtRealizar.Size = New System.Drawing.Size(459, 106)
        Me.txtRealizar.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(65, 250)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 16)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Realizar"
        '
        'txtRealizado
        '
        Me.txtRealizado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRealizado.Location = New System.Drawing.Point(130, 361)
        Me.txtRealizado.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRealizado.MaxLength = 150
        Me.txtRealizado.Multiline = True
        Me.txtRealizado.Name = "txtRealizado"
        Me.txtRealizado.Size = New System.Drawing.Size(459, 106)
        Me.txtRealizado.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(53, 364)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Realizado"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(514, 665)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(320, 646)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 42)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(220, 646)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 42)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Modificar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(481, 85)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(108, 22)
        Me.dtpFecha.TabIndex = 2
        '
        'btnESC
        '
        Me.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnESC.Location = New System.Drawing.Point(12, 11)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(75, 23)
        Me.btnESC.TabIndex = 39
        Me.btnESC.Text = "Button1"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'frmFichas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnESC
        Me.ClientSize = New System.Drawing.Size(612, 700)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtRealizado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRealizar)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboEstado)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.grbInformacion)
        Me.Controls.Add(Me.txtNombreEquipo)
        Me.Controls.Add(Me.txtFicha)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.txtIdEquipo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnESC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFichas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FICHAS"
        Me.grbInformacion.ResumeLayout(False)
        Me.grbInformacion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents txtFicha As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents txtIdEquipo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents grbInformacion As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents txtRealizar As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtRealizado As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents lblCliente As Label
    Friend WithEvents btnESC As Button
End Class
