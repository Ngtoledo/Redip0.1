<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm01
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
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl4 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAdress = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.TxtNumb = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.DialogoGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'Lbl1
        '
        Me.Lbl1.AutoSize = True
        Me.Lbl1.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl1.Location = New System.Drawing.Point(78, 47)
        Me.Lbl1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(89, 31)
        Me.Lbl1.TabIndex = 0
        Me.Lbl1.Text = "NOMBRE :"
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Enabled = False
        Me.btnAddCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomer.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomer.ForeColor = System.Drawing.Color.Lavender
        Me.btnAddCustomer.Location = New System.Drawing.Point(450, 233)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(164, 37)
        Me.btnAddCustomer.TabIndex = 5
        Me.btnAddCustomer.Text = "AGREGAR CLIENTE"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'Lbl2
        '
        Me.Lbl2.AutoSize = True
        Me.Lbl2.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl2.Location = New System.Drawing.Point(78, 110)
        Me.Lbl2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(68, 31)
        Me.Lbl2.TabIndex = 0
        Me.Lbl2.Text = "CALLE :"
        '
        'Lbl4
        '
        Me.Lbl4.AutoSize = True
        Me.Lbl4.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl4.Location = New System.Drawing.Point(78, 179)
        Me.Lbl4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl4.Name = "Lbl4"
        Me.Lbl4.Size = New System.Drawing.Size(96, 31)
        Me.Lbl4.TabIndex = 0
        Me.Lbl4.Text = "TELÉFONO :"
        '
        'TxtName
        '
        Me.TxtName.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TxtName.Location = New System.Drawing.Point(174, 42)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(350, 36)
        Me.TxtName.TabIndex = 1
        '
        'TxtAdress
        '
        Me.TxtAdress.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TxtAdress.Location = New System.Drawing.Point(153, 105)
        Me.TxtAdress.Name = "TxtAdress"
        Me.TxtAdress.Size = New System.Drawing.Size(205, 36)
        Me.TxtAdress.TabIndex = 2
        '
        'TxtPhone
        '
        Me.TxtPhone.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TxtPhone.Location = New System.Drawing.Point(181, 174)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(343, 36)
        Me.TxtPhone.TabIndex = 4
        Me.TxtPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl3
        '
        Me.Lbl3.AutoSize = True
        Me.Lbl3.ForeColor = System.Drawing.Color.Lavender
        Me.Lbl3.Location = New System.Drawing.Point(383, 110)
        Me.Lbl3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(43, 31)
        Me.Lbl3.TabIndex = 0
        Me.Lbl3.Text = "N° :"
        '
        'TxtNumb
        '
        Me.TxtNumb.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.TxtNumb.Location = New System.Drawing.Point(433, 105)
        Me.TxtNumb.Name = "TxtNumb"
        Me.TxtNumb.Size = New System.Drawing.Size(91, 36)
        Me.TxtNumb.TabIndex = 3
        Me.TxtNumb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnExportar
        '
        Me.btnExportar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExportar.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExportar.ForeColor = System.Drawing.Color.Lavender
        Me.btnExportar.Location = New System.Drawing.Point(450, 276)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(164, 37)
        Me.btnExportar.TabIndex = 6
        Me.btnExportar.Text = "EXPORTAR REGISTROS"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'DialogoGuardar
        '
        Me.DialogoGuardar.FileName = "Registros"
        '
        'Frm01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(614, 359)
        Me.Controls.Add(Me.btnExportar)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TxtNumb)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.TxtPhone)
        Me.Controls.Add(Me.TxtAdress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Lbl4)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.Lbl1)
        Me.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl1 As Label
    Friend WithEvents btnAddCustomer As Button
    Friend WithEvents Lbl2 As Label
    Friend WithEvents Lbl4 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents TxtAdress As TextBox
    Friend WithEvents TxtPhone As TextBox
    Friend WithEvents Lbl3 As Label
    Friend WithEvents TxtNumb As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnExportar As Button
    Friend WithEvents DialogoGuardar As SaveFileDialog
End Class
