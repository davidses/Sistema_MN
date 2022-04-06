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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvIngresos
        '
        Me.dgvIngresos.AllowUserToAddRows = False
        Me.dgvIngresos.AllowUserToDeleteRows = False
        Me.dgvIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIngresos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colIdEquipo, Me.colNombreEquipo, Me.colCliente, Me.colEstado, Me.colFechaIngreso})
        Me.dgvIngresos.Location = New System.Drawing.Point(13, 288)
        Me.dgvIngresos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvIngresos.Name = "dgvIngresos"
        Me.dgvIngresos.ReadOnly = True
        Me.dgvIngresos.RowHeadersVisible = False
        Me.dgvIngresos.Size = New System.Drawing.Size(865, 329)
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
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(133, 34)
        Me.btnSalir.TabIndex = 9
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(865, 173)
        Me.DataGridView1.TabIndex = 10
        '
        'frmIngresos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(895, 678)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvIngresos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmIngresos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresos"
        CType(Me.dgvIngresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvIngresos As DataGridView
    Friend WithEvents colIdEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colNombreEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colCliente As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
    Friend WithEvents colFechaIngreso As DataGridViewTextBoxColumn
    Friend WithEvents btnSalir As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
