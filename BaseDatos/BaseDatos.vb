' http://pabletoreto.blogspot.com.ar/2012/12/tres-capas-en-vbnet.html

Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class BaseDatos

    Private sConString As String = "Server=localhost; Database=siscontrol; User=root; Password=rootroot"




    ' ----------------------------- E Q U I P O S ------------------------------------------


    Function LlenarComboClientes() As List(Of eClientes)
        Try
            Dim lista As New List(Of eClientes)
            Dim dr As OleDbDataReader = Nothing
            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                Using oCmd As New OleDbCommand("SELECT * FROM Clientes ORDER BY Nombre ASC", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    dr = oCmd.ExecuteReader
                    While dr.Read
                        Dim list As New Entidades.eClientes
                        list.Id = dr.Item("Id")
                        list.Nombre = dr.Item("Nombre")
                        list.Direccion = dr.Item("Direccion")
                        list.Telefono = dr.Item("Telefono")
                        list.Observaciones = dr.Item("Observacion")
                        lista.Add(list)
                    End While
                End Using
            End Using

            Return lista
        Catch ex As Exception

        End Try
    End Function


    Public Function BuscaEquipo(ByVal Id As String) As eEquipos
        Try
            Dim lEquipo As New eEquipos
            Dim drEquipo As OleDbDataReader = Nothing

            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                If Id <> "" Then
                    ' BUSCA EL EQUIPO POR ID
                    Using oCmd As New OleDbCommand("SELECT * FROM Equipos WHERE Id = " & Id, oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        drEquipo = oCmd.ExecuteReader
                        While drEquipo.Read
                            lEquipo.Id = drEquipo.Item("Id")
                            lEquipo.IdCliente = drEquipo.Item("Id_Cliente")
                            lEquipo.Tipo = drEquipo.Item("Tipo")
                            lEquipo.Nombre = drEquipo.Item("Nombre")
                            lEquipo.Observacion = drEquipo.Item("Observacion")
                        End While
                    End Using
                End If
            End Using

            Return lEquipo

        Catch ex As Exception

        End Try

    End Function

    Function IngresaEquipo(Equipo As eEquipos) As Boolean
        ' Si no recibe datos, crea una excepcion
        If Equipo Is Nothing Then
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As OleDbTransaction = Nothing

        Try
            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New OleDbCommand("INSERT INTO Equipos (Id,Id_Cliente,Tipo,Nombre,Observacion) VALUES (@id, @id_cliente, @tipo,@nombre, @observacion)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@Id", Equipo.Id)
                    oCmd.Parameters.AddWithValue("@Id_Cliente", Equipo.IdCliente)
                    oCmd.Parameters.AddWithValue("@Tipo", Equipo.Tipo)
                    oCmd.Parameters.AddWithValue("@nombre", Equipo.Nombre)
                    oCmd.Parameters.AddWithValue("@observacion", Equipo.Observacion)

                    ' Ejecuta la consulta y verifica que se haya afectado un registro
                    If (oCmd.ExecuteNonQuery = 1) Then
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Controlamos la excepcion del rollback
            Try
                oTrans.Rollback()
            Catch
                ' Aca no escribimos nada.
            End Try

            Return False
            'Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificaEquipo(Equipo As eEquipos) As Boolean
        ' Si no recibe datos, crea una excepcion
        If Equipo Is Nothing Then
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As OleDbTransaction = Nothing

        Try
            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("UPDATE Equipos SET Nombre = '" & Equipo.Nombre & _
                                              "', Id_Cliente = '" & Equipo.IdCliente & _
                                              "', Tipo = '" & Equipo.Tipo & _
                                              "', Observacion = '" & Equipo.Observacion & _
                                              "' WHERE Id = " & Equipo.Id, oCon, oTrans)
                    cmd.Transaction = oTrans
                    cmd.CommandType = CommandType.Text

                    If (cmd.ExecuteNonQuery = 1) Then
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            Try
                oTrans.Rollback()
            Catch

            End Try

            Return False
            Throw New ArgumentException("Verificar ModificarDatos")
        End Try
    End Function
    ' ------------------------------- FIN EQUIPOS ------------------------------------------






    '----------------------------- C L I E N T E S     -------------------------------------


    Function Autocompletar_txtNombreCliente() As List(Of eClientes)   ' FUNCION DE AUTOCOMPLETADO DEL CAMPO  NOMBRE DE CLIENTES.
        Try
            Dim lista As New List(Of eClientes)
            Dim dr As MySqlDataReader = Nothing
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM Clientes", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    dr = oCmd.ExecuteReader
                    While dr.Read
                        Dim list As New Entidades.eClientes
                        list.Id = dr.Item("IdClientes")
                        list.Nombre = dr.Item("Nombre")
                        list.Direccion = dr.Item("Direccion")
                        list.Telefono = dr.Item("Telefono")
                        list.Observaciones = dr.Item("Observaciones")
                        lista.Add(list)
                    End While
                End Using
            End Using

            Return lista
        Catch ex As Exception

        End Try

    End Function

    Public Function BuscaCliente(Optional ByVal Id As String = "", Optional ByVal Nombre As String = "") As eClientes
        Try
            Dim lCliente As New eClientes
            Dim dr As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                If Id <> "" Then    ' BUSCA EL CLIENTE POR ID
                    Using oCmd As New MySqlCommand("SELECT * FROM Clientes WHERE IdClientes = " & Id, oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        dr = oCmd.ExecuteReader
                        While dr.Read
                            lCliente.Id = dr.Item("IdClientes")
                            lCliente.Nombre = dr.Item("Nombre")
                            lCliente.Direccion = dr.Item("Direccion")
                            lCliente.Telefono = dr.Item("Telefono")
                            lCliente.Observaciones = dr.Item("Observaciones")
                        End While
                    End Using

                ElseIf Nombre <> "" Then  ' BUSCA EL CLIENTE POR NOMBRE
                    Using oCmd As New MySqlCommand("SELECT * FROM Clientes WHERE Nombre = """ & Nombre & """", oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        dr = oCmd.ExecuteReader
                        While dr.Read
                            lCliente.Id = dr.Item("IdClientes")
                            lCliente.Nombre = dr.Item("Nombre")
                            lCliente.Direccion = dr.Item("Direccion")
                            lCliente.Telefono = dr.Item("Telefono")
                            lCliente.Observaciones = dr.Item("Observaciones")
                        End While
                    End Using
                End If
            End Using

            Return lCliente

        Catch ex As Exception

        End Try

    End Function


    Public Function ObtenerClientes() As DataSet    ' FUNCION QUE DEVUELVE TODOS LOS CLIENTES
        Try
            Dim ds As New DataSet
            Dim da As MySqlDataAdapter
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                da = New MySqlDataAdapter("SELECT IdClientes, Nombre FROM Clientes ORDER BY Nombre ASC", oCon)
                da.Fill(ds, "Clientes")
            End Using

            Return ds
        Catch ex As Exception

        End Try

    End Function

    Public Function IngresarCliente(Cli As eClientes) As Boolean
        If Cli Is Nothing Then      ' SI NO RECIBE DATOS CREA UNA EXCEPCION
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New MySqlCommand("INSERT INTO Clientes (Nombre,Direccion,Telefono,Observaciones) VALUES (@nombre, @direccion, @telefono, @observaciones)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@nombre", Cli.Nombre)
                    oCmd.Parameters.AddWithValue("@direccion", Cli.Direccion)
                    oCmd.Parameters.AddWithValue("@telefono", Cli.Telefono)
                    oCmd.Parameters.AddWithValue("@observaciones", Cli.Observaciones)

                    If (oCmd.ExecuteNonQuery = 1) Then  ' EJECUTA LA CONSULTA Y VERIFICA QUE SE HAYA AFECTADO UN REGISTRO 
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception  ' CONTROLAMOS LA EXCEPCION DE ROLLBACK
            Try
                oTrans.Rollback()
            Catch
                ' Aca no escribimos nada.
            End Try

            Return False
            'Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificarCliente(Cli As eClientes) As Boolean
        If Cli Is Nothing Then    ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE Clientes SET Nombre = '" & Cli.Nombre &
                                              "', Direccion = '" & Cli.Direccion &
                                              "', Telefono = '" & Cli.Telefono &
                                              "', Observaciones = '" & Cli.Observaciones &
                                              "' WHERE IdClientes = " & Cli.Id, oCon, oTrans)
                    cmd.Transaction = oTrans
                    cmd.CommandType = CommandType.Text

                    If (cmd.ExecuteNonQuery = 1) Then
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            Try
                oTrans.Rollback()
            Catch

            End Try

            Return False
            Throw New ArgumentException("Verificar ModificarDatos")
        End Try
    End Function

    Public Function EliminarCliente(ByVal id As String) As Boolean
        Dim trans As MySqlTransaction = Nothing
        Try
            Using Sql As New MySqlConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("DELETE FROM Clientes WHERE IdClientes = " & id, Sql, trans)
                    cmd.CommandType = CommandType.Text
                    'cmd.Parameters.AddWithValue("@id", param)
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
            'Throw New ArgumentException("Error en BorrarDatos")
        End Try
    End Function

    '--------------------------------- FIN CLIENTES ---------------------------------------------





    Public Shared Sub Main()

    End Sub
End Class
