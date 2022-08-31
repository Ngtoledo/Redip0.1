<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm03Consultas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cmbEmpleados = New System.Windows.Forms.ComboBox()
        Me.Grilla = New System.Windows.Forms.DataGridView()
        Me.btnListar = New System.Windows.Forms.Button()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Lavender
        Me.btnExit.Location = New System.Drawing.Point(579, 0)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 41)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(393, 70)
        Me.dtpHasta.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpHasta.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(149, 33)
        Me.dtpHasta.TabIndex = 3
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl3.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl3.Location = New System.Drawing.Point(328, 77)
        Me.Lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(58, 25)
        Me.Lbl3.TabIndex = 0
        Me.Lbl3.Text = "HASTA:"
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl1.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl1.Location = New System.Drawing.Point(13, 49)
        Me.Lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(82, 25)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "EMPLEADO:"
        '
        'dtpDesde
        '
        Me.dtpDesde.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(393, 14)
        Me.dtpDesde.MaxDate = New Date(2050, 12, 31, 0, 0, 0, 0)
        Me.dtpDesde.MinDate = New Date(2020, 1, 1, 0, 0, 0, 0)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(149, 33)
        Me.dtpDesde.TabIndex = 2
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.Lavender
        Me.lbl2.Location = New System.Drawing.Point(328, 19)
        Me.lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(57, 25)
        Me.lbl2.TabIndex = 0
        Me.lbl2.Text = "DESDE:"
        '
        'cmbEmpleados
        '
        Me.cmbEmpleados.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbEmpleados.FormattingEnabled = True
        Me.cmbEmpleados.Location = New System.Drawing.Point(102, 41)
        Me.cmbEmpleados.Name = "cmbEmpleados"
        Me.cmbEmpleados.Size = New System.Drawing.Size(189, 33)
        Me.cmbEmpleados.TabIndex = 1
        '
        'Grilla
        '
        Me.Grilla.BackgroundColor = System.Drawing.Color.DarkSlateBlue
        Me.Grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Grilla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.Grilla.Location = New System.Drawing.Point(18, 119)
        Me.Grilla.Name = "Grilla"
        Me.Grilla.Size = New System.Drawing.Size(432, 220)
        Me.Grilla.TabIndex = 23
        Me.Grilla.Visible = False
        '
        'btnListar
        '
        Me.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListar.ForeColor = System.Drawing.Color.Lavender
        Me.btnListar.Location = New System.Drawing.Point(456, 119)
        Me.btnListar.Name = "btnListar"
        Me.btnListar.Size = New System.Drawing.Size(147, 37)
        Me.btnListar.TabIndex = 4
        Me.btnListar.Text = "LISTAR"
        Me.btnListar.UseVisualStyleBackColor = True
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.Lavender
        Me.lbl4.Location = New System.Drawing.Point(489, 278)
        Me.lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(114, 25)
        Me.lbl4.TabIndex = 0
        Me.lbl4.Text = "TOTAL VENDIDO:"
        Me.lbl4.Visible = False
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTotal.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Violet
        Me.lblTotal.Location = New System.Drawing.Point(492, 306)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(109, 32)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotal.Visible = False
        '
        'Column1
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.HeaderText = "PRODUCTO"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 150
        '
        'Column2
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.HeaderText = "CLIENTE"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 150
        '
        'Column3
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Agency FB", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column3.HeaderText = "PRECIO"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 80
        '
        'Frm03Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(615, 359)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.btnListar)
        Me.Controls.Add(Me.Grilla)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.dtpDesde)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.cmbEmpleados)
        Me.Controls.Add(Me.btnExit)
        Me.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Frm03Consultas"
        Me.Text = "Frm03Consultas"
        CType(Me.Grilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents Lbl3 As Label
    Friend WithEvents Lbl1 As Label
    Friend WithEvents dtpDesde As DateTimePicker
    Friend WithEvents lbl2 As Label
    Friend WithEvents cmbEmpleados As ComboBox
    Friend WithEvents Grilla As DataGridView
    Friend WithEvents btnListar As Button
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
