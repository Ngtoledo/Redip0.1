Imports System.Data.OleDb
Public Class Frm02Ventas
    Private Sub Frm02Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm00.btnExit.Visible = False
        LlenarCombo(cmbClientes, "Clientes", "IdCliente", "Nombre")
        LlenarCombo(cmbEmpleados, "Empleados", "IdEmpleado", "NombreEmpleado")
        LlenarCombo(cmbProductos, "Productos", "IdProducto", "NombreProducto")
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frm00.panelTop.Visible = False
        frm00.btnExit.Visible = True
        frm00.btnExit.BringToFront()
    End Sub
    Private Sub btnCargarVta_Click(sender As Object, e As EventArgs) Handles btnCargarVta.Click
        CargarVenta()
    End Sub
    Private Sub CargarVenta()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Ventas"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim Tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = Tabla.NewRow()

            Fila("IdProducto") = BuscarId(cmbProductos.Text, "Productos", "IdProducto", "NombreProducto")
            Fila("IdCliente") = BuscarId(cmbClientes.Text, "Clientes", "IdCliente", "Nombre")
            Fila("IdVendedor") = BuscarId(cmbEmpleados.Text, "Empleados", "IdEmpleado", "NombreEmpleado")
            Fila("FechaVenta") = dtpFecha.Value.ToShortDateString

            Tabla.Rows.Add(Fila)
            Dim ComandoParaGrabar As New OleDbCommandBuilder(Adaptador)
            Adaptador.Update(Tabla)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Conexion.Close()
        MessageBox.Show("Venta cargada")
        cmbClientes.SelectedIndex = -1
        cmbEmpleados.SelectedIndex = -1
        cmbProductos.SelectedIndex = -1
    End Sub
    Private Sub ControlCarga(cmb1 As ComboBox, cmb2 As ComboBox, cmb3 As ComboBox, dtp As DateTimePicker)
        If cmb1.SelectedIndex <> -1 And cmb2.SelectedIndex <> -1 And cmb3.SelectedIndex <> -1 Then
            btnCargarVta.Enabled = True
        Else
            btnCargarVta.Enabled = False
        End If
    End Sub
    Private Sub cmbClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClientes.SelectedIndexChanged
        ControlCarga(cmbClientes, cmbEmpleados, cmbProductos, dtpFecha)
    End Sub
    Private Sub cmbEmpleados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbEmpleados.SelectedIndexChanged
        ControlCarga(cmbClientes, cmbEmpleados, cmbProductos, dtpFecha)
    End Sub
    Private Sub cmbProductos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbProductos.SelectedIndexChanged
        ControlCarga(cmbClientes, cmbEmpleados, cmbProductos, dtpFecha)
    End Sub

End Class