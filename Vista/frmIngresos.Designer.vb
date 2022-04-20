<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIngresos
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
        Me.dgvIngresos = New System.Windows.Forms.DataGridView()
        Me.colIdEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNombreEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFechaIngreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvFichasPorEquipo = New System.Windows.Forms.DataGridView()
        Me.colFicha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRealizar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colRealizado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIdEquipo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblObsercaciones = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNombreCliente = New System.Windows.Forms.Label()
        Me.lblNombreEquipo = New System.Windows.Forms.Label()
        Me.btnESC = New System.Windows.Forms.Button()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFichasPorEquipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvIngresos
        '
        Me.dgvIngresos.AllowUserToAddRows = False
        Me.dgvIngresos.AllowUserToDeleteRows = False
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdEquipo, Me.colNombreEquipo, Me.colCliente, Me.colEstado, Me.colFechaIngreso})
        Me.dgvIngresos.Location = New System.Drawing.Point(13, 345)
        Me.dgvIngresos.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.ReadOnly = True
        Me.dgvIngresos.RowHeadersVisible = False
        Me.dgvIngresos.Size = New System.Drawing.Size(865, 272)
        Me.dgvIngresos.TabIndex = 0
        '
        'colIdEquipo
        '
        Me.colIdEquipo.Frozen = True
        Me.colIdEquipo.HeaderText = "ID Equi."
        Me.colIdEquipo.Name = "colIdEquipo"
        Me.colIdEquipo.ReadOnly = True
        Me.colIdEquipo.Width = 80
        '
        'colNombreEquipo
        '
        Me.colNombreEquipo.Frozen = True
        Me.colNombreEquipo.HeaderText = "Nombre Equipo"
        Me.colNombreEquipo.Name = "colNombreEquipo"
        Me.colNombreEquipo.ReadOnly = True
        Me.colNombreEquipo.Width = 280
        '
        'colCliente
        '
        Me.colCliente.Frozen = True
        Me.colCliente.HeaderText = "Cliente"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.ReadOnly = True
        Me.colCliente.Width = 280
        '
        'colEstado
        '
        Me.colEstado.Frozen = True
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Width = 110
        '
        'colFechaIngreso
        '
        Me.colFechaIngreso.Frozen = True
        Me.colFechaIngreso.HeaderText = "Ingreso"
        Me.colFechaIngreso.Name = "colFechaIngreso"
        Me.colFechaIngreso.ReadOnly = True
        Me.colFechaIngreso.Width = 110
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(745, 634)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 34)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgvFichasPorEquipo
        '
        Me.dgvFichasPorEquipo.AllowUserToAddRows = False
        Me.dgvFichasPorEquipo.AllowUserToDeleteRows = False
        Me.dgvFichasPorEquipo.AllowUserToResizeColumns = False
        Me.dgvFichasPorEquipo.AllowUserToResizeRows = False
        Me.dgvFichasPorEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFichasPorEquipo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFicha, Me.colRealizar, Me.colRealizado, Me.colFecha})
        Me.dgvFichasPorEquipo.Location = New System.Drawing.Point(13, 102)
        Me.dgvFichasPorEquipo.MultiSelect = False
        Me.dgvFichasPorEquipo.Name = "dgvFichasPorEquipo"
        Me.dgvFichasPorEquipo.ReadOnly = True
        Me.dgvFichasPorEquipo.RowHeadersVisible = False
        Me.dgvFichasPorEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFichasPorEquipo.Size = New System.Drawing.Size(865, 173)
        Me.dgvFichasPorEquipo.TabIndex = 10
        '
        'colFicha
        '
        Me.colFicha.Frozen = True
        Me.colFicha.HeaderText = "Ficha"
        Me.colFicha.Name = "colFicha"
        Me.colFicha.ReadOnly = True
        Me.colFicha.Width = 80
        '
        'colRealizar
        '
        Me.colRealizar.Frozen = True
        Me.colRealizar.HeaderText = "Realizar"
        Me.colRealizar.Name = "colRealizar"
        Me.colRealizar.ReadOnly = True
        Me.colRealizar.Width = 300
        '
        'colRealizado
        '
        Me.colRealizado.Frozen = True
        Me.colRealizado.HeaderText = "Realizado"
        Me.colRealizado.Name = "colRealizado"
        Me.colRealizado.ReadOnly = True
        Me.colRealizado.Width = 380
        '
        'colFecha
        '
        Me.colFecha.Frozen = True
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "ID Equipo"
        '
        'txtIdEquipo
        '
        Me.txtIdEquipo.Location = New System.Drawing.Point(84, 32)
        Me.txtIdEquipo.Name = "txtIdEquipo"
        Me.txtIdEquipo.Size = New System.Drawing.Size(63, 22)
        Me.txtIdEquipo.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 317)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(865, 24)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TRABAJOS PENDIENTES"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblObsercaciones)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblNombreCliente)
        Me.GroupBox1.Controls.Add(Me.lblNombreEquipo)
        Me.GroupBox1.Location = New System.Drawing.Point(164, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(714, 84)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion"
        '
        'lblObsercaciones
        '
        Me.lblObsercaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObsercaciones.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblObsercaciones.Location = New System.Drawing.Point(290, 55)
        Me.lblObsercaciones.Name = "lblObsercaciones"
        Me.lblObsercaciones.Size = New System.Drawing.Size(418, 19)
        Me.lblObsercaciones.TabIndex = 7
        Me.lblObsercaciones.Text = "lblObservaciones"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(249, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Obs."
        '
        'lblTipo
        '
        Me.lblTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblTipo.Location = New System.Drawing.Point(93, 55)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(150, 19)
        Me.lblTipo.TabIndex = 5
        Me.lblTipo.Text = "lblTipo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Tipo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(412, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Equipo"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCliente.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblNombreCliente.Location = New System.Drawing.Point(466, 23)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(242, 19)
        Me.lblNombreCliente.TabIndex = 1
        Me.lblNombreCliente.Text = "CLIENTE CLIENTE"
        '
        'lblNombreEquipo
        '
        Me.lblNombreEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEquipo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblNombreEquipo.Location = New System.Drawing.Point(93, 23)
        Me.lblNombreEquipo.Name = "lblNombreEquipo"
        Me.lblNombreEquipo.Size = New System.Drawing.Size(313, 19)
        Me.lblNombreEquipo.TabIndex = 0
        Me.lblNombreEquipo.Text = "EQUIPO EQUIPO"
        '
        'btnESC
        '
        Me.btnESC.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnESC.Location = New System.Drawing.Point(170, 73)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(40, 23)
        Me.btnESC.TabIndex = 15
        Me.btnESC.Text = "ESC"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'frmIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnESC
        Me.ClientSize = New System.Drawing.Size(895, 678)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtIdEquipo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvFichasPorEquipo)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvIngresos)
        Me.Controls.Add(Me.btnESC)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos"
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFichasPorEquipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvIngresos As DataGridView
    Friend WithEvents colIdEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colNombreEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colCliente As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents colFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvFichasPorEquipo As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtIdEquipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNombreCliente As Label
    Friend WithEvents lblNombreEquipo As Label
    Friend WithEvents colFicha As DataGridViewTextBoxColumn
    Friend WithEvents colRealizar As DataGridViewTextBoxColumn
    Friend WithEvents colRealizado As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents lblObsercaciones As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTipo As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnESC As Button
End Class
