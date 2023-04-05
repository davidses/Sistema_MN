<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Informacion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ESPACIADO = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tssInfoDB = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsnOrdenes = New System.Windows.Forms.ToolStripButton()
        Me.tsbTerminados = New System.Windows.Forms.ToolStripButton()
        Me.tsbEquiposVenta = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tsbSalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tslHoraFecha = New System.Windows.Forms.ToolStripLabel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguracionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConexionBDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrHoraFecha = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblEquiposTallerTerm = New System.Windows.Forms.Label()
        Me.lblEquiposTallerPresu = New System.Windows.Forms.Label()
        Me.lblEquiposTallerIngresados = New System.Windows.Forms.Label()
        Me.lblEquiposVentasTerm = New System.Windows.Forms.Label()
        Me.lblEquiposVentasPresu = New System.Windows.Forms.Label()
        Me.lblEquiposVentasIngresados = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblEquiposEnTaller = New System.Windows.Forms.Label()
        Me.lblEquiposEnVentas = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tmrStockEquipos = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Informacion, Me.ESPACIADO, Me.tssInfoDB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1370, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Informacion
        '
        Me.Informacion.AutoSize = False
        Me.Informacion.Name = "Informacion"
        Me.Informacion.Size = New System.Drawing.Size(200, 17)
        Me.Informacion.Text = "Desarrollado por ElcaTech - 2023"
        '
        'ESPACIADO
        '
        Me.ESPACIADO.AutoSize = False
        Me.ESPACIADO.Name = "ESPACIADO"
        Me.ESPACIADO.Size = New System.Drawing.Size(979, 17)
        '
        'tssInfoDB
        '
        Me.tssInfoDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tssInfoDB.Name = "tssInfoDB"
        Me.tssInfoDB.Size = New System.Drawing.Size(176, 17)
        Me.tssInfoDB.Spring = True
        Me.tssInfoDB.Text = "ToolStripStatusLabel2"
        Me.tssInfoDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(64, 64)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsnOrdenes, Me.tsbTerminados, Me.tsbEquiposVenta, Me.ToolStripButton5, Me.ToolStripSeparator1, Me.ToolStripButton4, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator4, Me.ToolStripButton1, Me.tsbSalir, Me.ToolStripSeparator2, Me.tslHoraFecha})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1370, 67)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsnOrdenes
        '
        Me.tsnOrdenes.AutoSize = False
        Me.tsnOrdenes.ForeColor = System.Drawing.Color.Black
        Me.tsnOrdenes.Image = CType(resources.GetObject("tsnOrdenes.Image"), System.Drawing.Image)
        Me.tsnOrdenes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsnOrdenes.Name = "tsnOrdenes"
        Me.tsnOrdenes.Size = New System.Drawing.Size(64, 64)
        Me.tsnOrdenes.Text = "ORDENES"
        Me.tsnOrdenes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsnOrdenes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsbTerminados
        '
        Me.tsbTerminados.AutoSize = False
        Me.tsbTerminados.Image = CType(resources.GetObject("tsbTerminados.Image"), System.Drawing.Image)
        Me.tsbTerminados.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTerminados.Name = "tsbTerminados"
        Me.tsbTerminados.Size = New System.Drawing.Size(64, 64)
        Me.tsbTerminados.Text = "TERMINADOS"
        Me.tsbTerminados.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbTerminados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbTerminados.Visible = False
        '
        'tsbEquiposVenta
        '
        Me.tsbEquiposVenta.AutoSize = False
        Me.tsbEquiposVenta.Image = CType(resources.GetObject("tsbEquiposVenta.Image"), System.Drawing.Image)
        Me.tsbEquiposVenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEquiposVenta.Name = "tsbEquiposVenta"
        Me.tsbEquiposVenta.Size = New System.Drawing.Size(64, 64)
        Me.tsbEquiposVenta.Text = "VENTAS"
        Me.tsbEquiposVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbEquiposVenta.Visible = False
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.AutoSize = False
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripButton5.Text = "Orden de trabajo"
        Me.ToolStripButton5.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(30, 50)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripButton4.Text = "Clientes"
        Me.ToolStripButton4.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripButton3.Text = "Equipos"
        Me.ToolStripButton3.Visible = False
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripButton2.Text = "Fichas"
        Me.ToolStripButton2.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(30, 50)
        Me.ToolStripSeparator4.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(55, 50)
        Me.ToolStripButton1.Text = "Imprimir"
        Me.ToolStripButton1.Visible = False
        '
        'tsbSalir
        '
        Me.tsbSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbSalir.AutoSize = False
        Me.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSalir.Image = CType(resources.GetObject("tsbSalir.Image"), System.Drawing.Image)
        Me.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSalir.Name = "tsbSalir"
        Me.tsbSalir.Size = New System.Drawing.Size(55, 50)
        Me.tsbSalir.Text = "ToolStripButton6"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(20, 50)
        '
        'tslHoraFecha
        '
        Me.tslHoraFecha.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tslHoraFecha.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslHoraFecha.Name = "tslHoraFecha"
        Me.tslHoraFecha.Size = New System.Drawing.Size(0, 64)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.ConfiguracionToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(93, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'ConfiguracionToolStripMenuItem
        '
        Me.ConfiguracionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConexionBDToolStripMenuItem})
        Me.ConfiguracionToolStripMenuItem.Name = "ConfiguracionToolStripMenuItem"
        Me.ConfiguracionToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguracionToolStripMenuItem.Text = "Configuracion"
        '
        'ConexionBDToolStripMenuItem
        '
        Me.ConexionBDToolStripMenuItem.Name = "ConexionBDToolStripMenuItem"
        Me.ConexionBDToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ConexionBDToolStripMenuItem.Text = "Conexion BD"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'tmrHoraFecha
        '
        Me.tmrHoraFecha.Enabled = True
        Me.tmrHoraFecha.Interval = 1000
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.lblEquiposTallerTerm)
        Me.Panel2.Controls.Add(Me.lblEquiposTallerPresu)
        Me.Panel2.Controls.Add(Me.lblEquiposTallerIngresados)
        Me.Panel2.Controls.Add(Me.lblEquiposVentasTerm)
        Me.Panel2.Controls.Add(Me.lblEquiposVentasPresu)
        Me.Panel2.Controls.Add(Me.lblEquiposVentasIngresados)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lblEquiposEnTaller)
        Me.Panel2.Controls.Add(Me.lblEquiposEnVentas)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1147, 91)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 636)
        Me.Panel2.TabIndex = 7
        '
        'lblEquiposTallerTerm
        '
        Me.lblEquiposTallerTerm.AutoSize = True
        Me.lblEquiposTallerTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposTallerTerm.Location = New System.Drawing.Point(194, 263)
        Me.lblEquiposTallerTerm.Name = "lblEquiposTallerTerm"
        Me.lblEquiposTallerTerm.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposTallerTerm.TabIndex = 15
        Me.lblEquiposTallerTerm.Text = "--"
        '
        'lblEquiposTallerPresu
        '
        Me.lblEquiposTallerPresu.AutoSize = True
        Me.lblEquiposTallerPresu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposTallerPresu.Location = New System.Drawing.Point(194, 238)
        Me.lblEquiposTallerPresu.Name = "lblEquiposTallerPresu"
        Me.lblEquiposTallerPresu.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposTallerPresu.TabIndex = 14
        Me.lblEquiposTallerPresu.Text = "--"
        '
        'lblEquiposTallerIngresados
        '
        Me.lblEquiposTallerIngresados.AutoSize = True
        Me.lblEquiposTallerIngresados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposTallerIngresados.Location = New System.Drawing.Point(194, 215)
        Me.lblEquiposTallerIngresados.Name = "lblEquiposTallerIngresados"
        Me.lblEquiposTallerIngresados.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposTallerIngresados.TabIndex = 13
        Me.lblEquiposTallerIngresados.Text = "--"
        '
        'lblEquiposVentasTerm
        '
        Me.lblEquiposVentasTerm.AutoSize = True
        Me.lblEquiposVentasTerm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposVentasTerm.Location = New System.Drawing.Point(194, 98)
        Me.lblEquiposVentasTerm.Name = "lblEquiposVentasTerm"
        Me.lblEquiposVentasTerm.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposVentasTerm.TabIndex = 12
        Me.lblEquiposVentasTerm.Text = "--"
        '
        'lblEquiposVentasPresu
        '
        Me.lblEquiposVentasPresu.AutoSize = True
        Me.lblEquiposVentasPresu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposVentasPresu.Location = New System.Drawing.Point(194, 74)
        Me.lblEquiposVentasPresu.Name = "lblEquiposVentasPresu"
        Me.lblEquiposVentasPresu.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposVentasPresu.TabIndex = 11
        Me.lblEquiposVentasPresu.Text = "--"
        '
        'lblEquiposVentasIngresados
        '
        Me.lblEquiposVentasIngresados.AutoSize = True
        Me.lblEquiposVentasIngresados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposVentasIngresados.Location = New System.Drawing.Point(194, 51)
        Me.lblEquiposVentasIngresados.Name = "lblEquiposVentasIngresados"
        Me.lblEquiposVentasIngresados.Size = New System.Drawing.Size(17, 16)
        Me.lblEquiposVentasIngresados.TabIndex = 10
        Me.lblEquiposVentasIngresados.Text = "--"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(94, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "TERMINADOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "PRESUPUESTADOS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(95, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "INGRESADOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(94, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "TERMINADOS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(63, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PRESUPUESTADOS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(95, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "INGRESADOS"
        '
        'lblEquiposEnTaller
        '
        Me.lblEquiposEnTaller.AutoSize = True
        Me.lblEquiposEnTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposEnTaller.Location = New System.Drawing.Point(193, 180)
        Me.lblEquiposEnTaller.Name = "lblEquiposEnTaller"
        Me.lblEquiposEnTaller.Size = New System.Drawing.Size(21, 20)
        Me.lblEquiposEnTaller.TabIndex = 3
        Me.lblEquiposEnTaller.Text = "--"
        '
        'lblEquiposEnVentas
        '
        Me.lblEquiposEnVentas.AutoSize = True
        Me.lblEquiposEnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEquiposEnVentas.Location = New System.Drawing.Point(193, 18)
        Me.lblEquiposEnVentas.Name = "lblEquiposEnVentas"
        Me.lblEquiposEnVentas.Size = New System.Drawing.Size(21, 20)
        Me.lblEquiposEnVentas.TabIndex = 2
        Me.lblEquiposEnVentas.Text = "--"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Equipos en OF. VENTAS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Equipos en OF. TALLER"
        '
        'tmrStockEquipos
        '
        Me.tmrStockEquipos.Enabled = True
        Me.tmrStockEquipos.Interval = 300000
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de administracion MUNDO NOTEBOOK"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguracionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Informacion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tslHoraFecha As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbSalir As System.Windows.Forms.ToolStripButton
    Friend WithEvents tmrHoraFecha As System.Windows.Forms.Timer
    Friend WithEvents ConexionBDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tssInfoDB As ToolStripStatusLabel
    Friend WithEvents ESPACIADO As ToolStripStatusLabel
    Friend WithEvents tsbTerminados As ToolStripButton
    Friend WithEvents tsnOrdenes As ToolStripButton
    Friend WithEvents tsbEquiposVenta As ToolStripButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblEquiposEnTaller As Label
    Friend WithEvents lblEquiposEnVentas As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tmrStockEquipos As Timer
    Friend WithEvents lblEquiposTallerTerm As Label
    Friend WithEvents lblEquiposTallerPresu As Label
    Friend WithEvents lblEquiposTallerIngresados As Label
    Friend WithEvents lblEquiposVentasTerm As Label
    Friend WithEvents lblEquiposVentasPresu As Label
    Friend WithEvents lblEquiposVentasIngresados As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
