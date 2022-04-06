Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb
Imports MySql.Data.MySqlClient

Public Class BaseDatos

    Public sConString As String

    Public Sub New()
        If sConString = Nothing Then
            Call ConfigBD()
        End If
    End Sub


    Sub ConfigBD()
        Dim TextoConfig As String = System.IO.File.ReadAllText("DatosBD.cfg")
        Dim strConfig() As String = Split(TextoConfig, ",")

        Dim lastNonEmpty As Integer = -1
        For i As Integer = 0 To strConfig.Length - 1
            If strConfig(i) <> "" Then
                lastNonEmpty += 1
                strConfig(lastNonEmpty) = strConfig(i)
            End If
        Next
        ReDim Preserve strConfig(lastNonEmpty)

        sConString = "Server=" & strConfig(0) & " ;Port=" & strConfig(1) & " ;Database=" & strConfig(2) & " ;Uid=" & strConfig(3) & " ;Pwd=" & strConfig(4)

    End Sub

    Function PruebaConexion() As Boolean
        Try
            Dim dr As MySqlDataReader = Nothing
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM Clientes", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    dr = oCmd.ExecuteReader
                    dr.Read()

                    If dr.Item("IdClientes") = Nothing Then
                        Return False
                    Else
                        Return True
                    End If

                End Using
            End Using
        Catch ex As Exception

        End Try
    End Function





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

    '--------------------------------- FIN CLIENTES ------------------------------------------





    ' ------------------------------- E Q U I P O S ------------------------------------------

    Function LlenarComboClientes() As List(Of eClientes)
        Try
            Dim lista As New List(Of eClientes)
            Dim dr As MySqlDataReader = Nothing
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM Clientes ORDER BY Nombre ASC", oCon)
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


    Public Function BuscaEquipo(ByVal Id As String) As eEquipos
        Try
            Dim lEquipo As New eEquipos
            Dim drEquipo As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                If Id <> "" Then   ' BUSCA EL EQUIPO POR ID
                    Using oCmd As New MySqlCommand("SELECT * FROM Equipos WHERE IdEquipos = " & Id, oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        drEquipo = oCmd.ExecuteReader
                        While drEquipo.Read
                            lEquipo.Id = drEquipo.Item("IdEquipos")
                            lEquipo.IdCliente = drEquipo.Item("Clientes_IdClientes")
                            lEquipo.Tipo = drEquipo.Item("Tipo")
                            lEquipo.Nombre = drEquipo.Item("Nombre")
                            lEquipo.Observaciones = drEquipo.Item("Observaciones")
                        End While
                    End Using
                End If
            End Using

            Return lEquipo

        Catch ex As Exception

        End Try

    End Function

    Function IngresaEquipo(Equipo As eEquipos) As Boolean
        If Equipo Is Nothing Then  ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New MySqlCommand("INSERT INTO Equipos (IdEquipos,Clientes_IdClientes,Tipo,Nombre,Observaciones) VALUES (@idEquipos, @Clientes_IdClientes, @tipo, @nombre, @observaciones)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@IdEquipos", Equipo.Id)
                    oCmd.Parameters.AddWithValue("@Clientes_IdClientes", Equipo.IdCliente)
                    oCmd.Parameters.AddWithValue("@Tipo", Equipo.Tipo)
                    oCmd.Parameters.AddWithValue("@nombre", Equipo.Nombre)
                    oCmd.Parameters.AddWithValue("@observaciones", Equipo.Observaciones)

                    If (oCmd.ExecuteNonQuery = 1) Then  ' EJECUTA LA CONSULTA Y VERIFICA QUE SE HAYA AFECTADO UN REGISTRO
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using

        Catch ex As Exception
            Try ' Controlamos la excepcion del rollback
                oTrans.Rollback()
            Catch
                ' Aca no escribimos nada.
            End Try

            Return False
            'Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificaEquipo(Equipo As eEquipos) As Boolean

        If Equipo Is Nothing Then ' Si no recibe datos, crea una excepcion
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE Equipos SET Nombre = '" & Equipo.Nombre &
                                              "', Clientes_IdClientes = '" & Equipo.IdCliente &
                                              "', Tipo = '" & Equipo.Tipo &
                                              "', Observaciones = '" & Equipo.Observaciones &
                                              "' WHERE idEquipos = " & Equipo.Id, oCon, oTrans)
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

    Public Function EliminarEquipo(ByVal id As String) As Boolean
        Dim trans As MySqlTransaction = Nothing
        Try
            Using Sql As New MySqlConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("DELETE FROM Equipos WHERE idEquipos = " & id, Sql, trans)
                    cmd.CommandType = CommandType.Text
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
            'Throw New ArgumentException("Error en BorrarDatos")
        End Try
    End Function

    ' ------------------------------- FIN EQUIPOS ------------------------------------------





    ' ------------------------------- F I C H A S ------------------------------------------

    Public Function UltimoIdFicha() As eFichas
        Try
            Dim lFichas As New eFichas
            Dim drFichas As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT idFichas FROM Fichas ORDER BY idFichas DESC", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drFichas = oCmd.ExecuteReader

                    drFichas.Read()
                    lFichas.Id = drFichas.Item("idFichas")
                End Using
            End Using

            Return lFichas
        Catch ex As Exception

        End Try
    End Function

    Public Function BuscaFicha(ByVal Id As String) As eFichas
        Try
            Dim lFicha As New eFichas
            Dim drFichas As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                If Id <> "" Then   ' BUSCA LA FICHA POR ID
                    Using oCmd As New MySqlCommand("SELECT * FROM Fichas WHERE idFichas = " & Id, oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        drFichas = oCmd.ExecuteReader
                        While drFichas.Read
                            lFicha.Id = drFichas.Item("idFichas")
                            lFicha.Fecha = drFichas.Item("Fecha")
                            lFicha.Realizar = drFichas.Item("Realizar")
                            lFicha.Realizado = drFichas.Item("Realizado")
                            lFicha.Importe = drFichas.Item("Importe")
                            lFicha.Observaciones = drFichas.Item("Observaciones")
                            lFicha.Equipos_IdEquipos = drFichas.Item("Equipos_idEquipos")
                            lFicha.Estado = drFichas.Item("Estado")
                        End While
                    End Using
                End If
            End Using

            Return lFicha

        Catch ex As Exception

        End Try
    End Function

    Function IngresaFicha(Ficha As eFichas) As Boolean
        If Ficha Is Nothing Then  ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New MySqlCommand("INSERT INTO Fichas (IdFichas,Fecha,Realizar,Realizado,Importe,Observaciones,Equipos_IdEquipos,Estado) VALUES (@IdFichas, @Fecha, @Realizar, @Realizado, @Importe, @Observaciones, @Equipos_IdEquipos, @Estado)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@IdFichas", Ficha.Id)
                    oCmd.Parameters.AddWithValue("@Fecha", Ficha.Fecha)
                    oCmd.Parameters.AddWithValue("@Realizar", Ficha.Realizar)
                    oCmd.Parameters.AddWithValue("@Realizado", Ficha.Realizado)
                    If Ficha.Importe = "" Then
                        oCmd.Parameters.AddWithValue("@Importe", "0")
                    Else
                        oCmd.Parameters.AddWithValue("@Importe", Ficha.Importe)
                    End If
                    oCmd.Parameters.AddWithValue("@Observaciones", Ficha.Observaciones)
                    oCmd.Parameters.AddWithValue("@Equipos_IdEquipos", Ficha.Equipos_IdEquipos)
                    oCmd.Parameters.AddWithValue("@Estado", Ficha.Estado)

                    If (oCmd.ExecuteNonQuery = 1) Then  ' EJECUTA LA CONSULTA Y VERIFICA QUE SE HAYA AFECTADO UN REGISTRO
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using

        Catch ex As Exception
            Try ' Controlamos la excepcion del rollback
                oTrans.Rollback()
            Catch
                ' Aca no escribimos nada.
            End Try

            Return False
            'Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificarFicha(Ficha As eFichas) As Boolean
        If Ficha Is Nothing Then    ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE Fichas SET Fecha = '" & Ficha.Fecha &
                                              "', Realizar = '" & Ficha.Realizar &
                                              "', Realizado = '" & Ficha.Realizado &
                                              "', Importe = '" & Ficha.Importe &
                                              "', Observaciones = '" & Ficha.Observaciones &
                                              "', Equipos_idEquipos = '" & Ficha.Equipos_IdEquipos &
                                              "', Estado = '" & Ficha.Estado &
                                              "' WHERE idFichas = " & Ficha.Id, oCon, oTrans)
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

    Public Function EliminarFicha(ByVal id As String) As Boolean
        Dim trans As MySqlTransaction = Nothing
        Try
            Using Sql As New MySqlConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("DELETE FROM fichas WHERE idFichas = " & id, Sql, trans)
                    cmd.CommandType = CommandType.Text
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
            'Throw New ArgumentException("Error en BorrarDatos")
        End Try
    End Function

    Public Shared Sub Main()


    End Sub


End Class
