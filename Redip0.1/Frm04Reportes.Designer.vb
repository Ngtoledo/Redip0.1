<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm04Reportes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm04Reportes))
        Me.lblFechaMayor = New System.Windows.Forms.Label()
        Me.lblFechaMenor = New System.Windows.Forms.Label()
        Me.lblVentaMaxima = New System.Windows.Forms.Label()
        Me.lblVentaMinima = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblthree = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblOne = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DialogoImprimir = New System.Windows.Forms.PrintDialog()
        Me.DocumentoImprimir = New System.Drawing.Printing.PrintDocument()
        Me.DialogoPreimpresion = New System.Windows.Forms.PrintPreviewDialog()
        Me.pctGrafico = New System.Windows.Forms.PictureBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.btnCalcular = New System.Windows.Forms.Button()
        CType(Me.pctGrafico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFechaMayor
        '
        Me.lblFechaMayor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaMayor.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMayor.ForeColor = System.Drawing.Color.Black
        Me.lblFechaMayor.Location = New System.Drawing.Point(494, 327)
        Me.lblFechaMayor.Name = "lblFechaMayor"
        Me.lblFechaMayor.Size = New System.Drawing.Size(109, 23)
        Me.lblFechaMayor.TabIndex = 0
        Me.lblFechaMayor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFechaMenor
        '
        Me.lblFechaMenor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblFechaMenor.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaMenor.ForeColor = System.Drawing.Color.Black
        Me.lblFechaMenor.Location = New System.Drawing.Point(494, 297)
        Me.lblFechaMenor.Name = "lblFechaMenor"
        Me.lblFechaMenor.Size = New System.Drawing.Size(109, 23)
        Me.lblFechaMenor.TabIndex = 0
        Me.lblFechaMenor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVentaMaxima
        '
        Me.lblVentaMaxima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVentaMaxima.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentaMaxima.ForeColor = System.Drawing.Color.Black
        Me.lblVentaMaxima.Location = New System.Drawing.Point(157, 327)
        Me.lblVentaMaxima.Name = "lblVentaMaxima"
        Me.lblVentaMaxima.Size = New System.Drawing.Size(105, 23)
        Me.lblVentaMaxima.TabIndex = 0
        Me.lblVentaMaxima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVentaMinima
        '
        Me.lblVentaMinima.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVentaMinima.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVentaMinima.ForeColor = System.Drawing.Color.Black
        Me.lblVentaMinima.Location = New System.Drawing.Point(157, 298)
        Me.lblVentaMinima.Name = "lblVentaMinima"
        Me.lblVentaMinima.Size = New System.Drawing.Size(105, 23)
        Me.lblVentaMinima.TabIndex = 0
        Me.lblVentaMinima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFour
        '
        Me.lblFour.AutoSize = True
        Me.lblFour.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFour.ForeColor = System.Drawing.Color.Lavender
        Me.lblFour.Location = New System.Drawing.Point(361, 326)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(127, 25)
        Me.lblFour.TabIndex = 0
        Me.lblFour.Text = "Fecha última venta:"
        '
        'lblthree
        '
        Me.lblthree.AutoSize = True
        Me.lblthree.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblthree.ForeColor = System.Drawing.Color.Lavender
        Me.lblthree.Location = New System.Drawing.Point(356, 296)
        Me.lblthree.Name = "lblthree"
        Me.lblthree.Size = New System.Drawing.Size(132, 25)
        Me.lblthree.TabIndex = 0
        Me.lblthree.Text = "Fecha primer venta:"
        '
        'lblTwo
        '
        Me.lblTwo.AutoSize = True
        Me.lblTwo.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTwo.ForeColor = System.Drawing.Color.Lavender
        Me.lblTwo.Location = New System.Drawing.Point(12, 325)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(138, 25)
        Me.lblTwo.TabIndex = 0
        Me.lblTwo.Text = "Fecha venta máxima:"
        '
        'lblOne
        '
        Me.lblOne.AutoSize = True
        Me.lblOne.Font = New System.Drawing.Font("Agency FB", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOne.ForeColor = System.Drawing.Color.Lavender
        Me.lblOne.Location = New System.Drawing.Point(16, 295)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(134, 25)
        Me.lblOne.TabIndex = 0
        Me.lblOne.Text = "Fecha venta mínima:"
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
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'DialogoImprimir
        '
        Me.DialogoImprimir.UseEXDialog = True
        '
        'DocumentoImprimir
        '
        '
        'DialogoPreimpresion
        '
        Me.DialogoPreimpresion.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.DialogoPreimpresion.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.DialogoPreimpresion.ClientSize = New System.Drawing.Size(400, 300)
        Me.DialogoPreimpresion.Enabled = True
        Me.DialogoPreimpresion.Icon = CType(resources.GetObject("DialogoPreimpresion.Icon"), System.Drawing.Icon)
        Me.DialogoPreimpresion.Name = "DialogoPreimpresion"
        Me.DialogoPreimpresion.Visible = False
        '
        'pctGrafico
        '
        Me.pctGrafico.BackColor = System.Drawing.Color.White
        Me.pctGrafico.Location = New System.Drawing.Point(12, 52)
        Me.pctGrafico.Name = "pctGrafico"
        Me.pctGrafico.Size = New System.Drawing.Size(591, 231)
        Me.pctGrafico.TabIndex = 11
        Me.pctGrafico.TabStop = False
        Me.pctGrafico.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.Lavender
        Me.btnImprimir.Location = New System.Drawing.Point(323, 2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(147, 37)
        Me.btnImprimir.TabIndex = 13
        Me.btnImprimir.Text = "IMPRIMIR"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCalcular
        '
        Me.btnCalcular.FlatAppearance.BorderColor = System.Drawing.Color.Lavender
        Me.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCalcular.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.ForeColor = System.Drawing.Color.Lavender
        Me.btnCalcular.Location = New System.Drawing.Point(156, 2)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(147, 37)
        Me.btnCalcular.TabIndex = 12
        Me.btnCalcular.Text = "CALCULAR"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Frm04Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.ClientSize = New System.Drawing.Size(615, 359)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblFechaMayor)
        Me.Controls.Add(Me.lblFechaMenor)
        Me.Controls.Add(Me.lblVentaMaxima)
        Me.Controls.Add(Me.lblVentaMinima)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblthree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Controls.Add(Me.pctGrafico)
        Me.Font = New System.Drawing.Font("Agency FB", 18.0!, System.Drawing.FontStyle.Bold)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 7, 4, 7)
        Me.Name = "Frm04Reportes"
        Me.Text = "Frm04Reportes"
        CType(Me.pctGrafico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFechaMayor As Label
    Friend WithEvents lblFechaMenor As Label
    Friend WithEvents lblVentaMaxima As Label
    Friend WithEvents lblVentaMinima As Label
    Friend WithEvents lblFour As Label
    Friend WithEvents lblthree As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblOne As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents DialogoImprimir As PrintDialog
    Friend WithEvents DocumentoImprimir As Printing.PrintDocument
    Friend WithEvents DialogoPreimpresion As PrintPreviewDialog
    Friend WithEvents pctGrafico As PictureBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents btnCalcular As Button
End Class
