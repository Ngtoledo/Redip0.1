Public Class frm00
    Private Sub frm00_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelTop.Visible = False
        pctAnimacion.Visible = False
        TimerBtn.Start()
        Frm01.btnExit.Visible = False
    End Sub
    Private Sub TimerBtn_Tick(sender As Object, e As EventArgs) Handles TimerBtn.Tick
        btnInicio.Visible = True
        BtnVenta.Visible = True
        btnConsultas.Visible = True
        btnReportes.Visible = True
        btnExit.Visible = True
        TimerBtn.Stop()
    End Sub
    Private Sub btnInicio_Click_1(sender As Object, e As EventArgs) Handles btnInicio.Click
        panelTop.Visible = True
        pctAnimacion.Visible = True
        AbrirFrmHijo(New Frm01(), PanelPpal)
    End Sub
    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub BtnVenta_Click(sender As Object, e As EventArgs) Handles BtnVenta.Click
        panelTop.Visible = True
        pctAnimacion.Visible = True
        AbrirFrmHijo(New Frm02Ventas(), PanelPpal)
    End Sub
    Private Sub btnConsultas_Click_1(sender As Object, e As EventArgs) Handles btnConsultas.Click
        panelTop.Visible = True
        pctAnimacion.Visible = True
        AbrirFrmHijo(New Frm03Consultas(), PanelPpal)
    End Sub
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        panelTop.Visible = True
        pctAnimacion.Visible = True
        AbrirFrmHijo(New Frm04Reportes(), PanelPpal)
    End Sub
End Class
