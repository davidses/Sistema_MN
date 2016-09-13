Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb


Public Class BaseDatos

    ' http://pabletoreto.blogspot.com.ar/2012/12/tres-capas-en-vbnet.html

    Private sNombreBd As String = "bd.mdb"
    Private sConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=""" & sNombreBd & """"
    'Dim conexion As String = ConfigurationManager.ConnectionStrings("cnn").ConnectionString

    'Private oCon As OleDbConnection = Nothing
    'Private oComm As OleDbCommand = Nothing
    'Private oTrans As OleDbTransaction = Nothing
    'Private oParam() As OleDbParameter = Nothing

    'Public Sub Conectar()
    '    Try
    '        If Not Me.oCon Is Nothing Then
    '            If Me.oCon.State.Equals(ConnectionState.Closed) Then
    '                ' La base de datos ya se encuentra abierta
    '            End If
    '        End If

    '        If Me.oCon Is Nothing Then
    '            oCon = New OleDbConnection
    '            Me.oCon.ConnectionString = sConString
    '        End If

    '        Me.oCon.Open()

    '        If Me.oCon.State <> ConnectionState.Open Then
    '            MsgBox("Error al conectar con la base de datos" & Me.oCon.Database)
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub

    Public Function MostrarDatos() As List(Of Entidades.eClientes)
        Dim lista As New List(Of Entidades.eClientes)
        Dim dr As OleDbDataReader = Nothing
        Using Sql As New OleDbConnection(sConString)
            Sql.Open()
            Using cmd As New OleDbCommand("SeleccionarDatos", Sql)
                cmd.Connection = Sql
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim list As New Entidades.eClientes
                    list.Id = dr.Item("Id")
                    list.Nombre = dr.Item("Nombre")
                    list.Direccion = dr.Item("Direccion")
                    list.Telefono = dr.Item("Telefono")
                    list.Observacion = dr.Item("Observacion")
                    lista.Add(list)
                End While
            End Using
        End Using
        Return lista
    End Function

    Public Function IngresarDatos(datos As eClientes) As Boolean

        If datos Is Nothing Then
            Throw New ArgumentException("no se recibieron datos en InsertarDatos")
        End If

        Dim trans As OleDbTransaction = Nothing

        Dim Id As String = datos.Id
        Dim Nombre As String = datos.Nombre
        Dim Direccion As String = datos.Direccion
        Dim Telefono As String = datos.Telefono
        Dim Observacion As String = datos.Observacion

        Try

            Using Sql As New OleDbConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("InsertarDatos", Sql, trans)
                    cmd.Transaction = trans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@direccion", Direccion)
                    cmd.Parameters.AddWithValue("@telefono", Telefono)
                    cmd.Parameters.AddWithValue("@Observacion", Observacion)
                    If (cmd.ExecuteNonQuery = 1) Then
                        trans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            trans.Rollback()
            Return False
            Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificarDatos(datos As eClientes) As Boolean

        If datos Is Nothing Then
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim trans As OleDbTransaction = Nothing
        Dim Id As String = datos.Id
        Dim Nombre As String = datos.Nombre
        Dim Direccion As String = datos.Direccion
        Dim Telefono As String = datos.Telefono
        Dim Observacion As String = datos.Observacion

        Try

            Using Sql As New OleDbConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("ModificarDatos", Sql, trans)
                    cmd.Transaction = trans
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@direccion", Direccion)
                    cmd.Parameters.AddWithValue("@telefono", Telefono)
                    cmd.Parameters.AddWithValue("@observacion", Observacion)
                    If (cmd.ExecuteNonQuery = 1) Then
                        trans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            trans.Rollback()
            Return False
            Throw New ArgumentException("Verificar ModificarDatos")
        End Try
    End Function

    Public Function EliminarDatos(param As String) As Boolean
        Dim trans As OleDbTransaction = Nothing
        Try
            Using Sql As New OleDbConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("BorrarDatos", Sql, trans)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id", param)
                    If (cmd.ExecuteNonQuery = 1) Then
                        trans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            trans.Rollback()
            Throw New ArgumentException("Error en BorrarDatos")
        End Try
    End Function


    Public Shared Sub Main()

    End Sub
End Class
