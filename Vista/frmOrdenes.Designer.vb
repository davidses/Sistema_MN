<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdenes
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.grbIngreso = New System.Windows.Forms.GroupBox()
        Me.lblDiagnostico = New System.Windows.Forms.Label()
        Me.lblEquipo = New System.Windows.Forms.Label()
        Me.lblFechaIngreso = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDomicilio = New System.Windows.Forms.Label()
        Me.lblPropietario = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblTecnico = New System.Windows.Forms.Label()
        Me.lblImporte = New System.Windows.Forms.Label()
        Me.lblOtros = New System.Windows.Forms.Label()
        Me.lblTrabajos = New System.Windows.Forms.Label()
        Me.lblFechaTerminado = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.mnsPrincipal = New System.Windows.Forms.MenuStrip()
        Me.mnuIngreso = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuServicioTecnico = New System.Windows.Forms.ToolStripMenuItem()
        Me.F3PRESUPUESTADOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.F4BUSCARPORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLimpia = New System.Windows.Forms.Button()
        Me.F10CAMBNIODEUBIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grbIngreso.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.mnsPrincipal.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(435, 501)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(146, 33)
        Me.btnSalir.TabIndex = 16
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'grbIngreso
        '
        Me.grbIngreso.BackColor = System.Drawing.SystemColors.Control
        Me.grbIngreso.Controls.Add(Me.lblDiagnostico)
        Me.grbIngreso.Controls.Add(Me.lblEquipo)
        Me.grbIngreso.Controls.Add(Me.lblFechaIngreso)
        Me.grbIngreso.Controls.Add(Me.GroupBox1)
        Me.grbIngreso.Controls.Add(Me.Label8)
        Me.grbIngreso.Controls.Add(Me.Label7)
        Me.grbIngreso.Controls.Add(Me.Label2)
        Me.grbIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbIngreso.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grbIngreso.Location = New System.Drawing.Point(14, 126)
        Me.grbIngreso.Name = "grbIngreso"
        Me.grbIngreso.Size = New System.Drawing.Size(490, 369)
        Me.grbIngreso.TabIndex = 79
        Me.grbIngreso.TabStop = False
        Me.grbIngreso.Text = "INGRESO"
        '
        'lblDiagnostico
        '
        Me.lblDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDiagnostico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiagnostico.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDiagnostico.Location = New System.Drawing.Point(100, 269)
        Me.lblDiagnostico.Name = "lblDiagnostico"
        Me.lblDiagnostico.Size = New System.Drawing.Size(379, 92)
        Me.lblDiagnostico.TabIndex = 10
        Me.lblDiagnostico.Text = "EQUIPO LENTO. SSD240 + W10 + BACKUP"
        '
        'lblEquipo
        '
        Me.lblEquipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEquipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquipo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEquipo.Location = New System.Drawing.Point(100, 241)
        Me.lblEquipo.Name = "lblEquipo"
        Me.lblEquipo.Size = New System.Drawing.Size(379, 21)
        Me.lblEquipo.TabIndex = 9
        Me.lblEquipo.Text = "LENOVO IDEAPAD 330"
        Me.lblEquipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaIngreso
        '
        Me.lblFechaIngreso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaIngreso.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaIngreso.Location = New System.Drawing.Point(98, 38)
        Me.lblFechaIngreso.Name = "lblFechaIngreso"
        Me.lblFechaIngreso.Size = New System.Drawing.Size(98, 21)
        Me.lblFechaIngreso.TabIndex = 4
        Me.lblFechaIngreso.Text = "03/03/2022"
        Me.lblFechaIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.lblDomicilio)
        Me.GroupBox1.Controls.Add(Me.lblPropietario)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 152)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CLIENTE"
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEmail.Location = New System.Drawing.Point(111, 110)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(315, 21)
        Me.lblEmail.TabIndex = 8
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefono
        '
        Me.lblTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTelefono.Location = New System.Drawing.Point(111, 83)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(160, 21)
        Me.lblTelefono.TabIndex = 7
        Me.lblTelefono.Text = "3514920672"
        Me.lblTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDomicilio
        '
        Me.lblDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomicilio.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblDomicilio.Location = New System.Drawing.Point(111, 57)
        Me.lblDomicilio.Name = "lblDomicilio"
        Me.lblDomicilio.Size = New System.Drawing.Size(315, 21)
        Me.lblDomicilio.TabIndex = 6
        Me.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPropietario
        '
        Me.lblPropietario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPropietario.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblPropietario.Location = New System.Drawing.Point(111, 27)
        Me.lblPropietario.Name = "lblPropietario"
        Me.lblPropietario.Size = New System.Drawing.Size(315, 21)
        Me.lblPropietario.TabIndex = 5
        Me.lblPropietario.Text = "MARIANA DE LOS ANGELES"
        Me.lblPropietario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(63, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "E-MAIL"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(44, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "TELEFONO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(43, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DOMICILIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(25, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PROPIETARIO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(-2, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "DIAGNOSTICO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(36, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 83
        Me.Label7.Text = "EQUIPO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(11, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "FECHA ING."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox2.Controls.Add(Me.lblTecnico)
        Me.GroupBox2.Controls.Add(Me.lblImporte)
        Me.GroupBox2.Controls.Add(Me.lblOtros)
        Me.GroupBox2.Controls.Add(Me.lblTrabajos)
        Me.GroupBox2.Controls.Add(Me.lblFechaTerminado)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(511, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(511, 369)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SERVICIO TECNICO"
        '
        'lblTecnico
        '
        Me.lblTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTecnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTecnico.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTecnico.Location = New System.Drawing.Point(91, 340)
        Me.lblTecnico.Name = "lblTecnico"
        Me.lblTecnico.Size = New System.Drawing.Size(98, 21)
        Me.lblTecnico.TabIndex = 15
        Me.lblTecnico.Text = "ADRIAN"
        Me.lblTecnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblImporte
        '
        Me.lblImporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblImporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImporte.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblImporte.Location = New System.Drawing.Point(401, 340)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(98, 21)
        Me.lblImporte.TabIndex = 14
        Me.lblImporte.Text = "7500"
        Me.lblImporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOtros
        '
        Me.lblOtros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblOtros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOtros.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblOtros.Location = New System.Drawing.Point(91, 241)
        Me.lblOtros.Name = "lblOtros"
        Me.lblOtros.Size = New System.Drawing.Size(408, 90)
        Me.lblOtros.TabIndex = 13
        Me.lblOtros.Text = "ROTURA EN CARCAZA PARTE SUPERIOR IZQUIERDA. LA TECLA ""L"" NO FUNCIONA. EL WIFI FAL" &
    "LA AVECES"
        '
        'lblTrabajos
        '
        Me.lblTrabajos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTrabajos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrabajos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblTrabajos.Location = New System.Drawing.Point(91, 66)
        Me.lblTrabajos.Name = "lblTrabajos"
        Me.lblTrabajos.Size = New System.Drawing.Size(408, 159)
        Me.lblTrabajos.TabIndex = 12
        Me.lblTrabajos.Text = "INSTALACION DE WINDOWS 10 EN SSD240 CON BACKUP."
        '
        'lblFechaTerminado
        '
        Me.lblFechaTerminado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaTerminado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblFechaTerminado.Location = New System.Drawing.Point(91, 38)
        Me.lblFechaTerminado.Name = "lblFechaTerminado"
        Me.lblFechaTerminado.Size = New System.Drawing.Size(98, 21)
        Me.lblFechaTerminado.TabIndex = 11
        Me.lblFechaTerminado.Text = "08/03/2022"
        Me.lblFechaTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(39, 241)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 88
        Me.Label15.Text = "OTROS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(30, 344)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 85
        Me.Label11.Text = "TECNICO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(329, 344)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "IMPORTE $"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(21, 69)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(63, 13)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "TRABAJOS"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(14, 41)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 13)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "FECHA TER."
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(0, 24)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(1033, 45)
        Me.Label16.TabIndex = 81
        Me.Label16.Text = "Ordenes de trabajo"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Location = New System.Drawing.Point(192, 85)
        Me.txtOrden.MaxLength = 5
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(74, 20)
        Me.txtOrden.TabIndex = 1
        Me.txtOrden.Text = "6568"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(125, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "ORDEN"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(416, 88)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 91
        Me.Label9.Text = "UBICACION"
        '
        'mnsPrincipal
        '
        Me.mnsPrincipal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIngreso, Me.mnuServicioTecnico, Me.F3PRESUPUESTADOSToolStripMenuItem, Me.F4BUSCARPORToolStripMenuItem, Me.F10CAMBNIODEUBIToolStripMenuItem})
        Me.mnsPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.mnsPrincipal.Name = "mnsPrincipal"
        Me.mnsPrincipal.Size = New System.Drawing.Size(1031, 24)
        Me.mnsPrincipal.TabIndex = 92
        Me.mnsPrincipal.Text = "Principal"
        '
        'mnuIngreso
        '
        Me.mnuIngreso.Name = "mnuIngreso"
        Me.mnuIngreso.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.mnuIngreso.Size = New System.Drawing.Size(90, 20)
        Me.mnuIngreso.Text = "F1 - INGRESO"
        '
        'mnuServicioTecnico
        '
        Me.mnuServicioTecnico.Name = "mnuServicioTecnico"
        Me.mnuServicioTecnico.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.mnuServicioTecnico.Size = New System.Drawing.Size(143, 20)
        Me.mnuServicioTecnico.Text = "F2 - SERVICIO TECNICO"
        '
        'F3PRESUPUESTADOSToolStripMenuItem
        '
        Me.F3PRESUPUESTADOSToolStripMenuItem.Name = "F3PRESUPUESTADOSToolStripMenuItem"
        Me.F3PRESUPUESTADOSToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.F3PRESUPUESTADOSToolStripMenuItem.Size = New System.Drawing.Size(139, 20)
        Me.F3PRESUPUESTADOSToolStripMenuItem.Text = "F3 - PRESUPUESTADOS"
        '
        'F4BUSCARPORToolStripMenuItem
        '
        Me.F4BUSCARPORToolStripMenuItem.Name = "F4BUSCARPORToolStripMenuItem"
        Me.F4BUSCARPORToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.F4BUSCARPORToolStripMenuItem.Size = New System.Drawing.Size(102, 20)
        Me.F4BUSCARPORToolStripMenuItem.Text = "F4 - BUSQUEDA"
        '
        'lblUbicacion
        '
        Me.lblUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblUbicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUbicacion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblUbicacion.Location = New System.Drawing.Point(511, 85)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(167, 21)
        Me.lblUbicacion.TabIndex = 2
        Me.lblUbicacion.Text = "TALLER"
        Me.lblUbicacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstado
        '
        Me.lblEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstado.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lblEstado.Location = New System.Drawing.Point(856, 85)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(166, 21)
        Me.lblEstado.TabIndex = 3
        Me.lblEstado.Text = "REPARADA"
        Me.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(786, 88)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 96
        Me.Label10.Text = "ESTADO"
        '
        'btnLimpia
        '
        Me.btnLimpia.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnLimpia.Location = New System.Drawing.Point(36, 27)
        Me.btnLimpia.Name = "btnLimpia"
        Me.btnLimpia.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpia.TabIndex = 98
        Me.btnLimpia.Text = "LIMPIA"
        Me.btnLimpia.UseVisualStyleBackColor = True
        '
        'F10CAMBNIODEUBIToolStripMenuItem
        '
        Me.F10CAMBNIODEUBIToolStripMenuItem.Name = "F10CAMBNIODEUBIToolStripMenuItem"
        Me.F10CAMBNIODEUBIToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F10
        Me.F10CAMBNIODEUBIToolStripMenuItem.Size = New System.Drawing.Size(132, 20)
        Me.F10CAMBNIODEUBIToolStripMenuItem.Text = "F10 - CAMBIO DE UBI"
        '
        'frmOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnLimpia
        Me.ClientSize = New System.Drawing.Size(1031, 538)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.btnLimpia)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbIngreso)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.mnsPrincipal)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.mnsPrincipal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordenes de trabajo"
        Me.grbIngreso.ResumeLayout(False)
        Me.grbIngreso.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.mnsPrincipal.ResumeLayout(False)
        Me.mnsPrincipal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents grbIngreso As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtOrden As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblDiagnostico As Label
    Friend WithEvents lblEquipo As Label
    Friend WithEvents lblFechaIngreso As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDomicilio As Label
    Friend WithEvents lblPropietario As Label
    Friend WithEvents lblTecnico As Label
    Friend WithEvents lblImporte As Label
    Friend WithEvents lblOtros As Label
    Friend WithEvents lblTrabajos As Label
    Friend WithEvents lblFechaTerminado As Label
    Friend WithEvents mnsPrincipal As MenuStrip
    Friend WithEvents mnuIngreso As ToolStripMenuItem
    Friend WithEvents mnuServicioTecnico As ToolStripMenuItem
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnLimpia As Button
    Friend WithEvents F3PRESUPUESTADOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F4BUSCARPORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents F10CAMBNIODEUBIToolStripMenuItem As ToolStripMenuItem
End Class
