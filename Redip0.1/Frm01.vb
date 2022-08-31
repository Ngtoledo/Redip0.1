Imports System.Data.OleDb
Imports System.IO
Public Class Frm01
    Private Sub Frm01_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frm00.btnExit.Visible = False
    End Sub
    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        AddCustomer()
    End Sub
    Private Sub AddCustomer()
        Try
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Clientes"

            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            Dim Tabla As DataTable = DS.Tables(0)
            Dim Fila As DataRow = Tabla.NewRow()

            Fila("Nombre") = TxtName.Text
            Fila("Domicilio") = TxtAdress.Text & " " & TxtNumb.Text
            Fila("Telefono") = TxtPhone.Text

            Tabla.Rows.Add(Fila)
            Dim ComandoParaGrabar As New OleDbCommandBuilder(Adaptador)
            Adaptador.Update(Tabla)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Conexion.Close()
        MessageBox.Show("Datos grabados con éxito!")
        TxtName.Text = ""
        TxtAdress.Text = ""
        TxtNumb.Text = ""
        TxtPhone.Text = ""
    End Sub
    Private Sub TxtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtName.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Space) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtNumb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumb.KeyPress
        If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TxtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPhone.KeyPress
        If IsNumeric(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub ControlTxt()
        If TxtName.Text <> "" AndAlso TxtAdress.Text <> "" AndAlso
        TxtNumb.Text <> "" AndAlso TxtPhone.Text <> "" Then
            btnAddCustomer.Enabled = True
        End If
    End Sub
    Private Sub TxtName_TextChanged(sender As Object, e As EventArgs) Handles TxtName.TextChanged
        ControlTxt()
    End Sub
    Private Sub TxtAdress_TextChanged(sender As Object, e As EventArgs) Handles TxtAdress.TextChanged
        ControlTxt()
    End Sub
    Private Sub TxtNumb_TextChanged(sender As Object, e As EventArgs) Handles TxtNumb.TextChanged
        ControlTxt()
    End Sub
    Private Sub TxtPhone_TextChanged(sender As Object, e As EventArgs) Handles TxtPhone.TextChanged
        ControlTxt()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        frm00.panelTop.Visible = False
        frm00.btnExit.Visible = True
        frm00.btnExit.BringToFront()
    End Sub
    Private Sub btnExportar_Click(sender As Object, e As EventArgs) Handles btnExportar.Click

        DialogoGuardar.AddExtension = True
        DialogoGuardar.Filter = "Archivos TXT (.txt)|.txt|Todos los archivos (.)|."
        DialogoGuardar.DefaultExt = ".txt"
        DialogoGuardar.FileName = "Reporte.txt"
        DialogoGuardar.FilterIndex = 2
        DialogoGuardar.RestoreDirectory = True
        DialogoGuardar.ShowDialog()
        Try
            Dim objArch = New StreamWriter(DialogoGuardar.FileName, False, System.Text.Encoding.UTF8)
            Conexion.ConnectionString = CadenaConexion
            Conexion.Open()
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.TableDirect
            Comando.CommandText = "Clientes"
            Adaptador = New OleDbDataAdapter(Comando)
            DS = New DataSet
            Adaptador.Fill(DS)

            DR = Comando.ExecuteReader

            If DR.HasRows Then
                Do While DR.Read
                    objArch.Write(DR("IdCliente"))
                    objArch.Write("--")
                    objArch.Write(DR("Nombre"))
                    objArch.Write("--")
                    objArch.Write(DR("Domicilio"))
                    objArch.Write("--")
                    objArch.WriteLine(DR("Telefono"))
                Loop
            End If
            objArch.Close()
            Conexion.Close()

            MessageBox.Show("Archivo guardado")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class