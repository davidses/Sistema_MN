<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCambioUbiOrdenes
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
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.rabVenta = New System.Windows.Forms.RadioButton()
        Me.rabTaller = New System.Windows.Forms.RadioButton()
        Me.txtControl = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtOrden
        '
        Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Location = New System.Drawing.Point(139, 30)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(100, 40)
        Me.txtOrden.TabIndex = 1
        Me.txtOrden.Text = "3838"
        Me.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSalir.Location = New System.Drawing.Point(149, 241)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 4
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'rabVenta
        '
        Me.rabVenta.Appearance = System.Windows.Forms.Appearance.Button
        Me.rabVenta.Checked = True
        Me.rabVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rabVenta.Location = New System.Drawing.Point(12, 90)
        Me.rabVenta.Name = "rabVenta"
        Me.rabVenta.Size = New System.Drawing.Size(172, 99)
        Me.rabVenta.TabIndex = 2
        Me.rabVenta.TabStop = True
        Me.rabVenta.Text = "VENTAS"
        Me.rabVenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rabVenta.UseVisualStyleBackColor = True
        '
        'rabTaller
        '
        Me.rabTaller.Appearance = System.Windows.Forms.Appearance.Button
        Me.rabTaller.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rabTaller.Location = New System.Drawing.Point(190, 90)
        Me.rabTaller.Name = "rabTaller"
        Me.rabTaller.Size = New System.Drawing.Size(172, 99)
        Me.rabTaller.TabIndex = 3
        Me.rabTaller.Text = "TALLER"
        Me.rabTaller.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rabTaller.UseVisualStyleBackColor = True
        '
        'txtControl
        '
        Me.txtControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControl.Location = New System.Drawing.Point(12, 195)
        Me.txtControl.Multiline = True
        Me.txtControl.Name = "txtControl"
        Me.txtControl.ReadOnly = True
        Me.txtControl.Size = New System.Drawing.Size(350, 40)
        Me.txtControl.TabIndex = 5
        '
        'frmCambioUbiOrdenes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnSalir
        Me.ClientSize = New System.Drawing.Size(379, 270)
        Me.Controls.Add(Me.txtControl)
        Me.Controls.Add(Me.rabTaller)
        Me.Controls.Add(Me.rabVenta)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtOrden)
        Me.Name = "frmCambioUbiOrdenes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cambio de ubicacion para ordenes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOrden As TextBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents rabVenta As RadioButton
    Friend WithEvents rabTaller As RadioButton
    Friend WithEvents txtControl As TextBox
End Class
