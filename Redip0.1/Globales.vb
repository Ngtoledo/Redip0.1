Imports System.Data.OleDb
Module Globales

    Public Conexion As New OleDbConnection
    Public Comando As New OleDbCommand
    Public CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source= AltaEA_DB.mdb"
    Public Adaptador As New OleDbDataAdapter
    Public DS As DataSet
    Public DR As OleDbDataReader


    Public frmActual As Form = Nothing
    Public Sub AbrirFrmHijo(frmHijo As Form, panelFrmHijo As Panel)
        If frmActual IsNot Nothing Then
            frmActual.Close()
        End If
        frmActual = frmHijo
        frmHijo.TopLevel = False
        frmHijo.FormBorderStyle = FormBorderStyle.None
        panelFrmHijo.Controls.Add(frmHijo)
        panelFrmHijo.Tag = frmHijo
        frmHijo.BringToFront()
        frmHijo.Show()
    End Sub
    Public Sub LlenarCombo(combo As ComboBox, tabla As String, value As String, member As String)
        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = tabla
        Adaptador = New OleDbDataAdapter(Comando)
        DS = New DataSet
        Adaptador.Fill(DS)
        combo.DataSource = DS.Tables(0)
        combo.ValueMember = value
        combo.DisplayMember = member
        combo.SelectedIndex = -1
        Conexion.Close()
    End Sub
    Public Function BuscarId(Nombre As String, Tabla As String, IdTabla As String, Colum As String) As Integer
        Dim Id As Integer
        Dim ConexionTabla As New OleDb.OleDbConnection
        Dim ComandoTabla As New OleDb.OleDbCommand
        Dim DRtabla As OleDbDataReader

        ConexionTabla.ConnectionString = CadenaConexion
        ConexionTabla.Open()
        ComandoTabla.Connection = ConexionTabla
        ComandoTabla.CommandType = CommandType.TableDirect
        ComandoTabla.CommandText = Tabla
        DRtabla = ComandoTabla.ExecuteReader

        If DRtabla.HasRows Then
            Do While DRtabla.Read
                If DRtabla(Colum) = Nombre Then
                    Id = DRtabla(IdTabla)
                End If
            Loop
        End If
        ConexionTabla.Close()
        Return Id
    End Function
    Public Function BuscarDato(num As Integer, Tabla As String, IdTabla As String, Colum As String) As String
        Dim Dato As String = ""
        Dim Conexion As New OleDb.OleDbConnection
        Dim Comando As New OleDb.OleDbCommand
        Dim DR As OleDbDataReader

        Conexion.ConnectionString = CadenaConexion
        Conexion.Open()
        Comando.Connection = Conexion
        Comando.CommandType = CommandType.TableDirect
        Comando.CommandText = Tabla

        DR = Comando.ExecuteReader

        If DR.HasRows Then
            Do While DR.Read
                If DR(IdTabla) = num Then
                    Dato = DR(Colum)
                End If
            Loop
        End If
        Conexion.Close()
        Return Dato
    End Function

End Module
