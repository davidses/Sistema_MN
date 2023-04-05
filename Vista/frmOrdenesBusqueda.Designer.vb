<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenesBusqueda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPorNombre = New System.Windows.Forms.TabPage()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.tabPorEstado = New System.Windows.Forms.TabPage()
        Me.btnBuscarEstado = New System.Windows.Forms.Button()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.dgvBuscados = New System.Windows.Forms.DataGridView()
        Me.colOt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTrabajos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabPorNombre.SuspendLayout()
        Me.tabPorEstado.SuspendLayout()
        CType(Me.dgvBuscados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(393, 506)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 28)
        Me.btnSalir.TabIndex = 2
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabPorNombre)
        Me.TabControl1.Controls.Add(Me.tabPorEstado)
        Me.TabControl1.Location = New System.Drawing.Point(191, 21)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(522, 96)
        Me.TabControl1.TabIndex = 96
        '
        'tabPorNombre
        '
        Me.tabPorNombre.Controls.Add(Me.btnBuscar)
        Me.tabPorNombre.Controls.Add(Me.txtNombre)
        Me.tabPorNombre.Location = New System.Drawing.Point(4, 22)
        Me.tabPorNombre.Name = "tabPorNombre"
        Me.tabPorNombre.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPorNombre.Size = New System.Drawing.Size(514, 70)
        Me.tabPorNombre.TabIndex = 0
        Me.tabPorNombre.Text = "POR NOMBRE              "
        Me.tabPorNombre.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(371, 25)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(112, 21)
        Me.btnBuscar.TabIndex = 95
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(25, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(319, 21)
        Me.txtNombre.TabIndex = 94
        '
        'tabPorEstado
        '
        Me.tabPorEstado.Controls.Add(Me.btnBuscarEstado)
        Me.tabPorEstado.Controls.Add(Me.cboEstado)
        Me.tabPorEstado.Location = New System.Drawing.Point(4, 22)
        Me.tabPorEstado.Name = "tabPorEstado"
        Me.tabPorEstado.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPorEstado.Size = New System.Drawing.Size(514, 70)
        Me.tabPorEstado.TabIndex = 1
        Me.tabPorEstado.Text = "POR ESTADO                  "
        Me.tabPorEstado.UseVisualStyleBackColor = True
        '
        'btnBuscarEstado
        '
        Me.btnBuscarEstado.Location = New System.Drawing.Point(376, 25)
        Me.btnBuscarEstado.Name = "btnBuscarEstado"
        Me.btnBuscarEstado.Size = New System.Drawing.Size(112, 23)
        Me.btnBuscarEstado.TabIndex = 99
        Me.btnBuscarEstado.Text = "Buscar"
        Me.btnBuscarEstado.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Items.AddRange(New Object() {"1 - INGRESO", "2 - PRESUPUESTADO", "3 - AVISADO", "3a - ESPERANDO CONF.", "4 - CONFIRMADO", "5 - NO CONFIRMA", "6 - REPARADO", "7 - SIN REPARACION"})
        Me.cboEstado.Location = New System.Drawing.Point(25, 25)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(319, 23)
        Me.cboEstado.TabIndex = 98
        '
        'dgvBuscados
        '
        Me.dgvBuscados.AllowUserToAddRows = False
        Me.dgvBuscados.AllowUserToDeleteRows = False
        Me.dgvBuscados.AllowUserToResizeColumns = False
        Me.dgvBuscados.AllowUserToResizeRows = False
        Me.dgvBuscados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuscados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOt, Me.colCliente, Me.colEquipo, Me.colTelefono, Me.colTrabajos, Me.colEstado})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvBuscados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBuscados.Location = New System.Drawing.Point(15, 137)
        Me.dgvBuscados.MultiSelect = False
        Me.dgvBuscados.Name = "dgvBuscados"
        Me.dgvBuscados.ReadOnly = True
        Me.dgvBuscados.RowHeadersVisible = False
        Me.dgvBuscados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvBuscados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuscados.ShowCellErrors = False
        Me.dgvBuscados.ShowCellToolTips = False
        Me.dgvBuscados.ShowEditingIcon = False
        Me.dgvBuscados.ShowRowErrors = False
        Me.dgvBuscados.Size = New System.Drawing.Size(868, 360)
        Me.dgvBuscados.TabIndex = 4
        '
        'colOt
        '
        Me.colOt.Frozen = True
        Me.colOt.HeaderText = "ORDEN"
        Me.colOt.Name = "colOt"
        Me.colOt.ReadOnly = True
        Me.colOt.Width = 60
        '
        'colCliente
        '
        Me.colCliente.Frozen = True
        Me.colCliente.HeaderText = "CLIENTE"
        Me.colCliente.Name = "colCliente"
        Me.colCliente.ReadOnly = True
        Me.colCliente.Width = 270
        '
        'colEquipo
        '
        Me.colEquipo.Frozen = True
        Me.colEquipo.HeaderText = "EQUIPO"
        Me.colEquipo.Name = "colEquipo"
        Me.colEquipo.ReadOnly = True
        Me.colEquipo.Width = 240
        '
        'colTelefono
        '
        Me.colTelefono.Frozen = True
        Me.colTelefono.HeaderText = "TELEFONO"
        Me.colTelefono.Name = "colTelefono"
        Me.colTelefono.ReadOnly = True
        Me.colTelefono.Width = 120
        '
        'colTrabajos
        '
        Me.colTrabajos.Frozen = True
        Me.colTrabajos.HeaderText = "TRABAJOS"
        Me.colTrabajos.Name = "colTrabajos"
        Me.colTrabajos.ReadOnly = True
        Me.colTrabajos.Visible = False
        '
        'colEstado
        '
        Me.colEstado.Frozen = True
        Me.colEstado.HeaderText = "ESTADO"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Width = 160
        '
        'frmOrdenesBusqueda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 546)
        Me.Controls.Add(Me.dgvBuscados)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "frmOrdenesBusqueda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Busqueda de ordenes"
        Me.TabControl1.ResumeLayout(False)
        Me.tabPorNombre.ResumeLayout(False)
        Me.tabPorNombre.PerformLayout()
        Me.tabPorEstado.ResumeLayout(False)
        CType(Me.dgvBuscados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabPorNombre As TabPage
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents tabPorEstado As TabPage
    Friend WithEvents cboEstado As ComboBox
    Friend WithEvents dgvBuscados As DataGridView
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnBuscarEstado As Button
    Friend WithEvents colOt As DataGridViewTextBoxColumn
    Friend WithEvents colCliente As DataGridViewTextBoxColumn
    Friend WithEvents colEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colTelefono As DataGridViewTextBoxColumn
    Friend WithEvents colTrabajos As DataGridViewTextBoxColumn
    Friend WithEvents colEstado As DataGridViewTextBoxColumn
End Class
