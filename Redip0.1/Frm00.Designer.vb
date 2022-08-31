<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm00
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm00))
        Me.lblLogo = New System.Windows.Forms.Label()
        Me.panelTop = New System.Windows.Forms.Panel()
        Me.pctAnimacion = New System.Windows.Forms.PictureBox()
        Me.TimerBtn = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPpal = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnConsultas = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.panelTop.SuspendLayout()
        CType(Me.pctAnimacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPpal.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblLogo
        '
        Me.lblLogo.AutoSize = True
        Me.lblLogo.Font = New System.Drawing.Font("Agency FB", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogo.ForeColor = System.Drawing.Color.Lavender
        Me.lblLogo.Location = New System.Drawing.Point(65, 12)
        Me.lblLogo.Name = "lblLogo"
        Me.lblLogo.Size = New System.Drawing.Size(235, 34)
        Me.lblLogo.TabIndex = 0
        Me.lblLogo.Text = "ALTA - Entregas Argentina"
        '
        'panelTop
        '
        Me.panelTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.panelTop.Controls.Add(Me.lblLogo)
        Me.panelTop.Controls.Add(Me.pctAnimacion)
        Me.panelTop.Location = New System.Drawing.Point(0, 0)
        Me.panelTop.Name = "panelTop"
        Me.panelTop.Size = New System.Drawing.Size(614, 61)
        Me.panelTop.TabIndex = 0
        '
        'pctAnimacion
        '
        Me.pctAnimacion.Image = Global.Redip0._1.My.Resources.Resources.A
        Me.pctAnimacion.Location = New System.Drawing.Point(0, 0)
        Me.pctAnimacion.Name = "pctAnimacion"
        Me.pctAnimacion.Size = New System.Drawing.Size(64, 61)
        Me.pctAnimacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctAnimacion.TabIndex = 0
        Me.pctAnimacion.TabStop = False
        '
        'TimerBtn
        '
        Me.TimerBtn.Interval = 5000
        '
        'PanelPpal
        '
        Me.PanelPpal.BackColor = System.Drawing.Color.Black
        Me.PanelPpal.Controls.Add(Me.PanelMenu)
        Me.PanelPpal.Controls.Add(Me.PictureBox1)
        Me.PanelPpal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelPpal.Location = New System.Drawing.Point(0, 61)
        Me.PanelPpal.Name = "PanelPpal"
        Me.PanelPpal.Size = New System.Drawing.Size(614, 359)
        Me.PanelPpal.TabIndex = 5
        '
        'PanelMenu
        '
        Me.PanelMenu.Controls.Add(Me.btnReportes)
        Me.PanelMenu.Controls.Add(Me.btnConsultas)
        Me.PanelMenu.Controls.Add(Me.BtnVenta)
        Me.PanelMenu.Controls.Add(Me.btnInicio)
        Me.PanelMenu.Location = New System.Drawing.Point(429, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(185, 359)
        Me.PanelMenu.TabIndex = 0
        '
        'btnReportes
        '
        Me.btnReportes.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.Lavender
        Me.btnReportes.Location = New System.Drawing.Point(0, 132)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(185, 44)
        Me.btnReportes.TabIndex = 4
        Me.btnReportes.Text = "REPORTES DE VENTAS"
        Me.btnReportes.UseVisualStyleBackColor = True
        Me.btnReportes.Visible = False
        '
        'btnConsultas
        '
        Me.btnConsultas.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConsultas.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsultas.ForeColor = System.Drawing.Color.Lavender
        Me.btnConsultas.Location = New System.Drawing.Point(0, 88)
        Me.btnConsultas.Name = "btnConsultas"
        Me.btnConsultas.Size = New System.Drawing.Size(185, 44)
        Me.btnConsultas.TabIndex = 3
        Me.btnConsultas.Text = "VENTAS POR EMPLEADO"
        Me.btnConsultas.UseVisualStyleBackColor = True
        Me.btnConsultas.Visible = False
        '
        'BtnVenta
        '
        Me.BtnVenta.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.ForeColor = System.Drawing.Color.Lavender
        Me.BtnVenta.Location = New System.Drawing.Point(0, 44)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(185, 44)
        Me.BtnVenta.TabIndex = 2
        Me.BtnVenta.Text = "NUEVA VENTA"
        Me.BtnVenta.UseVisualStyleBackColor = True
        Me.BtnVenta.Visible = False
        '
        'btnInicio
        '
        Me.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.SlateBlue
        Me.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInicio.Font = New System.Drawing.Font("Agency FB", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInicio.ForeColor = System.Drawing.Color.Lavender
        Me.btnInicio.Location = New System.Drawing.Point(0, 0)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(185, 44)
        Me.btnInicio.TabIndex = 1
        Me.btnInicio.Text = "AGREGAR CLIENTES"
        Me.btnInicio.UseVisualStyleBackColor = True
        Me.btnInicio.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Redip0._1.My.Resources.Resources.redipGif
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(432, 359)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
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
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = True
        Me.btnExit.Visible = False
        '
        'frm00
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(614, 420)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.panelTop)
        Me.Controls.Add(Me.PanelPpal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm00"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redip 1.0"
        Me.panelTop.ResumeLayout(False)
        Me.panelTop.PerformLayout()
        CType(Me.pctAnimacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPpal.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pctAnimacion As PictureBox
    Friend WithEvents lblLogo As Label
    Friend WithEvents panelTop As Panel
    Friend WithEvents TimerBtn As Timer
    Friend WithEvents PanelPpal As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnInicio As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents BtnVenta As Button
    Friend WithEvents btnConsultas As Button
    Friend WithEvents btnReportes As Button
End Class
