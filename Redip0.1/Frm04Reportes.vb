Imports System.Data.OleDb
Imports System.Drawing.Drawing2D
Imports System.Drawing
Public Class Frm04Reportes
    Private Sub Frm04Reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pctGrafico.Refresh()
        frm00.btnExit.Visible = False
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frm00.panelTop.Visible = False
        frm00.btnExit.Visible = True
        frm00.btnExit.BringToFront()
    End Sub
    Private Sub btnCalcular_Click_1(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Try
            lblFechaMenor.Text = DateMin()
            lblFechaMayor.Text = DateMax()
            lblVentaMinima.Text = BuscarFechaMenorVenta()
            lblVentaMaxima.Text = BuscarFechaMayorVenta()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        pctGrafico.Visible = True
    End Sub
    Private Sub btnImprimir_Click_1(sender As Object, e As EventArgs) Handles btnImprimir.Click
        DialogoImprimir.ShowDialog()
        DialogoPreimpresion.ShowDialog()
        DocumentoImprimir.PrinterSettings = DialogoImprimir.PrinterSettings
        DocumentoImprimir.Print()
    End Sub
    Function DateMin() As Date
        Dim FechaMin As Date = Date.Now
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Ventas"
        DR = Comando.ExecuteReader
        If DR.HasRows Then
            While DR.Read
                If FechaMin > DR("FechaVenta") Then
                    FechaMin = Convert.ToDateTime(DR("FechaVenta"))
                End If
            End While
        End If
        Conexion.Close()
        Return FechaMin
    End Function
    Function DateMax() As Date
        Dim FechaMax As Date
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = "Ventas"
        DR = Comando.ExecuteReader
        If DR.HasRows Then
            While DR.Read
                If FechaMax < DR("FechaVenta") Then
                    FechaMax = Convert.ToDateTime(DR("FechaVenta"))
                End If
            End While
        End If
        Conexion.Close()
        Return FechaMax
    End Function
    Public Function BuscarFechaMayorVenta() As Date
        Dim CantidadMax As Integer = 0
        Dim FechaMax As Date = Date.Now
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT FechaVenta, Count(IdVenta) AS CantidadVenta FROM Ventas GROUP BY FechaVenta"
        DR = Comando.ExecuteReader
        If DR.HasRows Then
            While DR.Read
                If CantidadMax < DR("CantidadVenta") Then
                    FechaMax = Convert.ToDateTime(DR("FechaVenta"))
                    CantidadMax = DR("CantidadVenta")
                End If
            End While
        End If
        Conexion.Close()
        Return FechaMax
    End Function
    Public Function BuscarFechaMenorVenta() As Date
        Dim CantidadMin As Integer = 10000
        Dim FechaMin As Date = Date.Now
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT FechaVenta, Count(IdVenta) AS CantidadVenta FROM Ventas GROUP BY FechaVenta"
        DR = Comando.ExecuteReader
        If DR.HasRows Then
            While DR.Read
                If CantidadMin > DR("CantidadVenta") Then
                    FechaMin = Convert.ToDateTime(DR("FechaVenta"))
                    CantidadMin = DR("CantidadVenta")
                End If
            End While
        End If
        Conexion.Close()
        Return FechaMin
    End Function
    Private Sub pctGrafico_Paint(sender As Object, e As PaintEventArgs) Handles pctGrafico.Paint
        Dim Cont As Integer
        Dim FechaMin As Date = Date.Now

        Dim Grafico As Graphics
        Grafico = e.Graphics

        Dim PosXFecha As Integer = 5
        Dim PosX1 As Integer = 20
        Dim PosY1 As Integer = 205
        Dim PosX2 As Integer = 40

        Dim LapizRojo As New Pen(Brushes.Red, 10)
        Dim LapizAzul As New Pen(Brushes.Blue, 10)
        Dim LapizNegro As New Pen(Brushes.Black, 2)

        Dim LetraPri As New Font("Agency FB", 14)
        Dim LetraSecu As New Font("Agency FB", 12)
        Dim LetraTer As New Font("Agency FB", 10)
        Dim Titulo As String = "REPORTE DE VENTAS"
        Dim SubTitulo As String = "Desde: " & DateMin() & "   Hasta: " & DateMax()
        Dim FecMin As String = "Venta menor registrada: " & BuscarFechaMenorVenta()
        Dim FecMax As String = "Venta mayor registrada: " & BuscarFechaMayorVenta()

        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT FechaVenta, Count(IdVenta) AS CantidadVenta FROM Ventas GROUP BY FechaVenta"
        DR = Comando.ExecuteReader

        Grafico.SmoothingMode = SmoothingMode.AntiAlias
        Grafico.DrawString(Titulo, LetraPri, Brushes.Black, 5, 5) 'punto de inicio titulo
        Grafico.DrawString(SubTitulo, LetraSecu, Brushes.Black, 5, 30) 'punto de inicio  desde hasta
        Grafico.DrawString(FecMin, LetraSecu, Brushes.Red, 400, 5)
        Grafico.DrawString(FecMax, LetraSecu, Brushes.Red, 400, 20)

        If DR.HasRows Then
            While DR.Read
                Grafico.DrawString(DR("FechaVenta"), LetraTer, Brushes.Blue, PosXFecha, 210)   'pie PRIMERA FECHA
                PosXFecha = PosXFecha + 60 'corremos x a la derecha imprime luego siguiente FECHA
                If DR("CantidadVenta") <> 0 Then
                    Dim Aux As Integer = 10
                    Cont = 0
                    PosY1 = 205
                    While Cont < DR("CantidadVenta")
                        Grafico.DrawLine(LapizRojo, PosX1, PosY1, PosX2, PosY1) ' inicio de barra cant= 1 
                        PosY1 = PosY1 - Aux ' si cant = 2 la barra va arriba 
                        Cont = Cont + 1
                    End While
                    Grafico.DrawString(DR("CantidadVenta"), LetraPri, Brushes.Black, PosX1 + 5, PosY1 - 15)
                    PosX1 = PosX1 + 60
                    PosX2 = PosX2 + 60
                End If
            End While
        End If
        Conexion.Close()
    End Sub
    Private Sub DocumentoImprimir_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles DocumentoImprimir.PrintPage

        Dim Cont As Integer = 0
        Dim FechaMin As Date = Date.Now

        Dim PosXFecha As Integer = 5
        Dim PosX1 As Integer = 20
        Dim PosY1 As Integer = 205
        Dim PosX2 As Integer = 40

        Dim LapizRojo As New Pen(Brushes.Red, 10)
        Dim LapizAzul As New Pen(Brushes.Blue, 10)
        Dim LapizNegro As New Pen(Brushes.Black, 2)

        Dim LetraPri As New Font("Agency FB", 14)
        Dim LetraSecu As New Font("Agency FB", 12)
        Dim LetraTer As New Font("Agency FB", 10)
        Dim Titulo As String = "REPORTE DE VENTAS"
        Dim SubTitulo As String = "Desde: " & DateMin() & "   Hasta: " & DateMax()
        Dim FecMin As String = "Venta menor registrada: " & BuscarFechaMenorVenta()
        Dim FecMax As String = "Venta mayor registrada: " & BuscarFechaMayorVenta()

        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.Text
        Comando.CommandText = "SELECT FechaVenta, Count(IdVenta) AS CantidadVenta FROM Ventas GROUP BY FechaVenta"
        DR = Comando.ExecuteReader

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
        e.Graphics.DrawString(Titulo, LetraPri, Brushes.Black, 5, 5) 'punto de inicio titulo
        e.Graphics.DrawString(SubTitulo, LetraSecu, Brushes.Black, 5, 30) 'punto de inicio  desde hasta
        e.Graphics.DrawString(FecMin, LetraSecu, Brushes.Red, 400, 5)
        e.Graphics.DrawString(FecMax, LetraSecu, Brushes.Red, 400, 20)

        If DR.HasRows Then
            While DR.Read
                e.Graphics.DrawString(DR("FechaVenta"), LetraTer, Brushes.Blue, PosXFecha, 210)   'pie PRIMERA FECHA
                PosXFecha = PosXFecha + 60 'corremos x a la derecha imprime luego siguiente FECHA
                If DR("CantidadVenta") <> 0 Then
                    Dim Aux As Integer = 10
                    Cont = 0
                    PosY1 = 205
                    While Cont < DR("CantidadVenta")
                        e.Graphics.DrawLine(LapizRojo, PosX1, PosY1, PosX2, PosY1) ' inicio de barra cant= 1 
                        PosY1 = PosY1 - Aux
                        Cont = Cont + 1
                    End While
                    e.Graphics.DrawString(DR("CantidadVenta"), LetraPri, Brushes.Black, PosX1 + 5, PosY1 - 15)
                    PosX1 = PosX1 + 60
                    PosX2 = PosX2 + 60
                End If
            End While
        End If
        Conexion.Close()
    End Sub
    Private Sub DialogoPreimpresion_Load(sender As Object, e As EventArgs) Handles DialogoPreimpresion.Load
        DialogoPreimpresion.Document = DocumentoImprimir
    End Sub

End Class