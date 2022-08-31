Imports System.Data.OleDb

Public Class Frm03Consultas
    Private Sub Frm03Consultas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm00.btnExit.Visible = False
        LlenarCombo(cmbEmpleados, "Empleados", "IdEmpleado", "NombreEmpleado")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frm00.panelTop.Visible = False
        frm00.btnExit.Visible = True
        frm00.btnExit.BringToFront()
    End Sub
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListarGrilla()
        Grilla.Visible = True
        lbl4.Visible = True
        lblTotal.Visible = True
    End Sub
    Private Sub ListarGrilla()
        Grilla.Rows.Clear()
        Dim total As Double
        Dim desde As Date = dtpDesde.Value.ToShortDateString
        Dim hasta As Date = dtpHasta.Value.ToShortDateString
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Ventas"
            Adaptador = New OleDbDataAdapter(Comando)
            DR = Comando.ExecuteReader

            If DR.HasRows Then
                Do While DR.Read
                    If DR("FechaVenta") >= desde And DR("FechaVenta") <= hasta Then
                        If DR("IdVendedor") = BuscarId(cmbEmpleados.Text, "Empleados", "IdEmpleado", "NombreEmpleado") Then
                            Grilla.Rows.Add(BuscarDato((DR("IdProducto")), "Productos", "IdProducto", "NombreProducto"),
                            BuscarDato((DR("IdCliente")), "Clientes", "IdCliente", "Nombre"),
                            BuscarDato((DR("IdProducto")), "Productos", "IdProducto", "ValorProducto"))
                            total = total + BuscarDato((DR("IdProducto")), "Productos", "IdProducto", "ValorProducto")
                        End If
                    End If
                Loop
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Conexion.Close()
        lblTotal.Text = total.ToString("C2")
        'cmbEmpleados.SelectedIndex = -1
    End Sub

End Class