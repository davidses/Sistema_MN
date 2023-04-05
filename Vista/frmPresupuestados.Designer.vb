<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuestados
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvPresupuestados = New System.Windows.Forms.DataGridView()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTrabajos = New System.Windows.Forms.TextBox()
        Me.colOt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTrabajos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPresupuestados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPresupuestados
        '
        Me.dgvPresupuestados.AllowUserToAddRows = False
        Me.dgvPresupuestados.AllowUserToDeleteRows = False
        Me.dgvPresupuestados.AllowUserToResizeColumns = False
        Me.dgvPresupuestados.AllowUserToResizeRows = False
        Me.dgvPresupuestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresupuestados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colOt, Me.colCliente, Me.colEquipo, Me.colTelefono, Me.colTrabajos})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(254, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPresupuestados.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvPresupuestados.Location = New System.Drawing.Point(12, 12)
        Me.dgvPresupuestados.MultiSelect = False
        Me.dgvPresupuestados.Name = "dgvPresupuestados"
        Me.dgvPresupuestados.ReadOnly = True
        Me.dgvPresupuestados.RowHeadersVisible = False
        Me.dgvPresupuestados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPresupuestados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPresupuestados.ShowCellErrors = False
        Me.dgvPresupuestados.ShowCellToolTips = False
        Me.dgvPresupuestados.ShowEditingIcon = False
        Me.dgvPresupuestados.ShowRowErrors = False
        Me.dgvPresupuestados.Size = New System.Drawing.Size(758, 281)
        Me.dgvPresupuestados.TabIndex = 0
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(334, 497)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(111, 28)
        Me.btnSalir.TabIndex = 1
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTrabajos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(758, 180)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TRABAJOS"
        '
        'txtTrabajos
        '
        Me.txtTrabajos.Location = New System.Drawing.Point(14, 26)
        Me.txtTrabajos.Multiline = True
        Me.txtTrabajos.Name = "txtTrabajos"
        Me.txtTrabajos.Size = New System.Drawing.Size(728, 148)
        Me.txtTrabajos.TabIndex = 3
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
        Me.colTelefono.Width = 170
        '
        'colTrabajos
        '
        Me.colTrabajos.Frozen = True
        Me.colTrabajos.HeaderText = "TRABAJOS"
        Me.colTrabajos.Name = "colTrabajos"
        Me.colTrabajos.ReadOnly = True
        Me.colTrabajos.Visible = False
        '
        'frmPresupuestados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 532)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgvPresupuestados)
        Me.Name = "frmPresupuestados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presupuestados"
        CType(Me.dgvPresupuestados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvPresupuestados As DataGridView
    Friend WithEvents btnSalir As Button
    Friend WithEvents colOt As DataGridViewTextBoxColumn
    Friend WithEvents colCliente As DataGridViewTextBoxColumn
    Friend WithEvents colEquipo As DataGridViewTextBoxColumn
    Friend WithEvents colTelefono As DataGridViewTextBoxColumn
    Friend WithEvents colTrabajos As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTrabajos As TextBox
End Class
