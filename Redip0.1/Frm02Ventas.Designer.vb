<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm02Ventas
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
        Me.cmbClientes = New System.Windows.Forms.ComboBox()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnCargarVta = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbClientes
        '
        Me.cmbClientes.FormattingEnabled = True
        Me.cmbClientes.Location = New System.Drawing.Point(226, 46)
        Me.cmbClientes.Name = "cmbClientes"
        Me.cmbClientes.Size = New System.Drawing.Size(263, 39)
        Me.cmbClientes.TabIndex = 1
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl1.Location = New System.Drawing.Point(119, 54)
        Me.Lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(78, 31)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "CLIENTE:"
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl3.Location = New System.Drawing.Point(98, 170)
        Me.Lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(105, 31)
        Me.Lbl3.TabIndex = 0
        Me.Lbl3.Text = "PRODUCTO:"
        '
        'cmbProductos
        '
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(226, 162)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(263, 39)
        Me.cmbProductos.TabIndex = 3
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl2.Location = New System.Drawing.Point(104, 111)
        Me.Lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(99, 31)
        Me.Lbl2.TabIndex = 0
        Me.Lbl2.Text = "EMPLEADO:"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(226, 103)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(263, 39)
        Me.cmbEmpleados.TabIndex = 2
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl4.Location = New System.Drawing.Point(130, 233)
        Me.Lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(67, 31)
        Me.Lbl4.TabIndex = 0
        Me.Lbl4.Text = "FECHA:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(226, 228)
        Me.dtpFecha.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(263, 36)
        Me.dtpFecha.TabIndex = 4
        '
        'btnCargarVta
        '
        Me.btnCargarVta.Enabled = False
        Me.btnCargarVta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnCargarVta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCargarVta.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargarVta.ForeColor = System.Drawing.Color.Lavender
        Me.btnCargarVta.Location = New System.Drawing.Point(438, 310)
        Me.btnCargarVta.Name = "btnCargarVta"
        Me.btnCargarVta.Size = New System.Drawing.Size(164, 37)
        Me.btnCargarVta.TabIndex = 5
        Me.btnCargarVta.Text = "CARGAR VENTA"
        Me.btnCargarVta.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Lavender
        Me.btnExit.Location = New System.Drawing.Point(578, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 41)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Frm02Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(614, 359)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCargarVta)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.cmbProductos)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.cmbClientes)
        Me.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm02Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm02Ventas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents Lbl1 As Label
    Friend WithEvents Lbl3 As Label
    Friend WithEvents cmbProductos As ComboBox
    Friend WithEvents Lbl2 As Label
    Friend WithEvents cmbEmpleados As ComboBox
    Friend WithEvents Lbl4 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents btnCargarVta As Button
    Friend WithEvents btnExit As Button
End Class
