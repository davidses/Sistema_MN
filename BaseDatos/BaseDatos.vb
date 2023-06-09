﻿Imports Entidades
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
                Return True
            End Using
        Catch ex As Exception
            Return False
        End Try
    End Function


    ' ---------------------------- T E R M I N A D O S ------------------------------------

    Function IngresaTerminados(Terminado As eTerminados) As Boolean
        If Terminado Is Nothing Then  ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New MySqlCommand("INSERT INTO egresos (Orden,Fecha,Cliente,marca_modelo,Trabajos,Importe,Tecnico,Estado) VALUES (@Orden, @Fecha, @Cliente, @marca_modelo, @Trabajos, @Importe, @Tecnico, @Estado)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@Orden", Terminado.Orden)
                    oCmd.Parameters.AddWithValue("@Fecha", Terminado.Fecha)
                    oCmd.Parameters.AddWithValue("@Cliente", Terminado.Cliente)
                    oCmd.Parameters.AddWithValue("@marca_modelo", Terminado.MarcaModelo)
                    oCmd.Parameters.AddWithValue("@Trabajos", Terminado.Trabajos)
                    If Terminado.Importe = "" Then
                        oCmd.Parameters.AddWithValue("@Importe", "0")
                    Else
                        oCmd.Parameters.AddWithValue("@Importe", Terminado.Importe)
                    End If
                    oCmd.Parameters.AddWithValue("@Tecnico", Terminado.Tecnico)
                    oCmd.Parameters.AddWithValue("@Estado", Terminado.Estado)

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

    Public Function BuscaOrden(ByVal Orden As String) As eTerminados
        Try
            Dim lOrden As New eTerminados
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                If Orden <> "" Then   ' BUSCA LA ORDEN
                    Using oCmd As New MySqlCommand("SELECT * FROM egresos WHERE Orden = " & Orden, oCon)
                        oCmd.Connection = oCon
                        oCmd.CommandType = CommandType.Text
                        drOrdenes = oCmd.ExecuteReader
                        While drOrdenes.Read
                            lOrden.Id = drOrdenes.Item("id")
                            lOrden.Orden = drOrdenes.Item("orden")
                            lOrden.Fecha = drOrdenes.Item("fecha")
                            lOrden.Cliente = drOrdenes.Item("cliente")
                            lOrden.MarcaModelo = drOrdenes.Item("marca_modelo")
                            lOrden.Trabajos = drOrdenes.Item("trabajos")
                            lOrden.Importe = drOrdenes.Item("importe")
                            lOrden.Tecnico = drOrdenes.Item("tecnico")
                            lOrden.Estado = drOrdenes.Item("estado")
                        End While
                    End Using
                End If
            End Using

            Return lOrden

        Catch ex As Exception

        End Try
    End Function

    Public Function ModificarTerminado(Terminado As eTerminados) As Boolean
        If Terminado Is Nothing Then    ' SI NO RECIBE DATOS, CREA UNA EXCEPCION
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE egresos SET Fecha = '" & Terminado.Fecha &
                                              "', cliente = '" & Terminado.Cliente &
                                              "', marca_modelo = '" & Terminado.MarcaModelo &
                                              "', trabajos = '" & Terminado.Trabajos &
                                              "', importe = '" & Terminado.Importe &
                                              "', tecnico = '" & Terminado.Tecnico &
                                              "', estado = '" & Terminado.Estado &
                                              "' WHERE orden = " & Terminado.Orden, oCon, oTrans)
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

    Public Function EliminarTerminado(ByVal Orden As String) As Boolean
        Dim trans As MySqlTransaction = Nothing
        Try
            Using Sql As New MySqlConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("DELETE FROM egresos WHERE orden = " & Orden, Sql, trans)
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

    Public Function BuscaTerminadosMensual(mes As Integer, tecnico As String) As List(Of eTerminados)

        Try
            Dim lOrdenes As New List(Of eTerminados)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM egresos WHERE MONTH(fecha) = """ & mes & """ AND tecnico = """ & tecnico & """")
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim Orden As New eTerminados

                        Orden.Id = drOrdenes.Item("id")
                        Orden.Orden = drOrdenes.Item("orden")
                        If drOrdenes.Item("fecha") <> Nothing Then Orden.Fecha = drOrdenes.Item("fecha")
                        Orden.Cliente = drOrdenes.Item("cliente")
                        Orden.MarcaModelo = drOrdenes.Item("marca_modelo")
                        Orden.Trabajos = drOrdenes.Item("trabajos")
                        Orden.Importe = drOrdenes.Item("importe")
                        Orden.Tecnico = drOrdenes.Item("tecnico")
                        Orden.Estado = drOrdenes.Item("estado")

                        lOrdenes.Add(Orden)
                    End While
                End Using
            End Using

            Return lOrdenes

        Catch ex As Exception


        End Try

    End Function

    ' ---------------------------------------- FIN TERMINADOS -----------------------------------------------




    ' ---------------------------------------- O R D E N E S  -----------------------------------------------
    Public Function UltimaOrden() As Integer

        Try
            Dim lOrden As New eOrdenes
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT orden FROM ordenes ORDER BY orden DESC", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader

                    drOrdenes.Read()
                    lOrden.Orden = drOrdenes.Item("orden")

                End Using
            End Using

            Return lOrden.Orden

        Catch ex As Exception

        End Try
    End Function
    Public Function BuscaOrden2(ByVal Orden As String) As eOrdenes
        Try
            Dim lOrden As New eOrdenes
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM ordenes WHERE Orden = " & Orden, oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        lOrden.Id = drOrdenes.Item("id")
                        lOrden.Orden = drOrdenes.Item("orden")
                        lOrden.Ubicacion = drOrdenes.Item("ubicacion")
                        lOrden.Estado = drOrdenes.Item("estado")
                        If drOrdenes.Item("fechaingreso") IsNot DBNull.Value Then lOrden.FechaIngreso = drOrdenes.Item("fechaingreso")
                        lOrden.Propietario = drOrdenes.Item("propietario")
                        lOrden.Domicilio = drOrdenes.Item("domicilio")
                        lOrden.Telefono = drOrdenes.Item("telefono")
                        lOrden.Email = drOrdenes.Item("email")
                        lOrden.Equipo = drOrdenes.Item("equipo")
                        lOrden.Diagnostico = drOrdenes.Item("diagnostico")
                        If drOrdenes.Item("fechaterminado") IsNot DBNull.Value Then lOrden.FechaTerminado = drOrdenes.Item("fechaterminado")
                        If drOrdenes.Item("trabajos") IsNot DBNull.Value Then lOrden.Trabajos = drOrdenes.Item("trabajos")
                        If drOrdenes.Item("otros") IsNot DBNull.Value Then lOrden.Otros = drOrdenes.Item("otros")
                        If drOrdenes.Item("importe") IsNot DBNull.Value Then lOrden.Importe = drOrdenes.Item("importe")
                        If drOrdenes.Item("tecnico") IsNot DBNull.Value Then lOrden.Tecnico = drOrdenes.Item("tecnico")
                    End While
                End Using
            End Using

            Return lOrden

        Catch ex As Exception

        End Try

    End Function

    Function GuardaOrden(orden As eOrdenes) As Boolean

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using oCmd As New MySqlCommand("INSERT INTO ordenes (orden,fechaingreso,propietario,domicilio,telefono,email,equipo,diagnostico,ubicacion,estado) VALUES (@Orden, @FechaIngreso, @Propietario, @Domicilio, @Telefono, @Email, @Equipo, @Diagnostico, @Ubicacion, @Estado)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text
                    oCmd.Parameters.AddWithValue("@Orden", orden.Orden)
                    oCmd.Parameters.AddWithValue("@FechaIngreso", orden.FechaIngreso)
                    oCmd.Parameters.AddWithValue("@Propietario", orden.Propietario)
                    oCmd.Parameters.AddWithValue("@Domicilio", orden.Domicilio)
                    oCmd.Parameters.AddWithValue("@Telefono", orden.Telefono)
                    oCmd.Parameters.AddWithValue("@Email", orden.Email)
                    oCmd.Parameters.AddWithValue("@Equipo", orden.Equipo)
                    oCmd.Parameters.AddWithValue("@Diagnostico", orden.Diagnostico)
                    oCmd.Parameters.AddWithValue("@Ubicacion", orden.Ubicacion)
                    oCmd.Parameters.AddWithValue("@Estado", orden.Estado)

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
        End Try
    End Function

    Public Function ModificaOrden(orden As eOrdenes) As Boolean

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE ordenes SET fechaingreso = '" & orden.FechaIngreso &
                                              "', propietario = '" & orden.Propietario &
                                              "', domicilio = '" & orden.Domicilio &
                                              "', telefono = '" & orden.Telefono &
                                              "', email = '" & orden.Email &
                                              "', equipo = '" & orden.Equipo &
                                              "', diagnostico = '" & orden.Diagnostico &
                                              "', ubicacion = '" & orden.Ubicacion &
                                              "', estado = '" & orden.Estado &
                                              "' WHERE orden = " & orden.Orden, oCon, oTrans)
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

    Public Function ModificaOrdenST(orden As eOrdenes) As Boolean

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE ordenes SET fechaterminado = '" & orden.FechaTerminado &
                                              "', trabajos = '" & orden.Trabajos &
                                              "', importe = '" & orden.Importe &
                                              "', tecnico = '" & orden.Tecnico &
                                              "', ubicacion = '" & orden.Ubicacion &
                                              "', estado = '" & orden.Estado &
                                              "' WHERE orden = " & orden.Orden, oCon, oTrans)
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

    Public Function ModificaUbiOrden(orden As String, ubi As String) As Boolean

        Dim oTrans As MySqlTransaction = Nothing

        Try
            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New MySqlCommand("UPDATE ordenes SET ubicacion = '" & ubi &
                                              "' WHERE orden = " & orden, oCon, oTrans)
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


    Public Function ObtenerStockEquipos() As (List(Of eOrdenes), List(Of eOrdenes))

        Try
            Dim lOrden As New List(Of eOrdenes)
            Dim lOrden2 As New List(Of eOrdenes)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado <> '8 - ENTREGADO'", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim orden As New eOrdenes

                        orden.Id = drOrdenes.Item("id")
                        orden.Orden = drOrdenes.Item("orden")

                        lOrden.Add(orden)
                    End While
                End Using
                oCon.Close()
                oCon.Open()

                Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado <> '8 - ENTREGADO'", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim orden As New eOrdenes

                        orden.Id = drOrdenes.Item("id")
                        orden.Orden = drOrdenes.Item("orden")

                        lOrden2.Add(orden)
                    End While
                End Using

            End Using

            Return (lOrden, lOrden2)

        Catch ex As Exception

        End Try

    End Function

    Public Function ObtenerUbicacionEstado() As Array
        Dim cantidadEquipos(13) As Integer
        Dim drOrdenes As MySqlDataReader = Nothing

        '(0) TOTAL VENTAS
        '(1) V-INGRESADOS
        '(2) V-PRESUPUESTADOS
        '(3) V-AVISADOS
        '(4) V-ESPERANDO
        '(5) V-CONFIRMADO
        '(6) V-TERMINADOS
        '(7) TOTAL TALLER
        '(8) T-INGRESADOS
        '(9) T-PRESUPUESTADOS
        '(10) T-AVISADOS
        '(11) T-ESPERANDO
        '(12) T-CONFIRMADO
        '(13) T-TERMINADOS

        Using oCon As New MySqlConnection(sConString)

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TOTAL VENTAS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado <> '8 - ENTREGADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(0) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - INGRESADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado = '1 - INGRESO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(1) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - PRESUPUESTADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado = '2 - PRESUPUESTADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(2) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - AVISADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado = '3 - AVISADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(3) += 1
                End While
            End Using
            oCon.Close()
            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - ESPERANDO }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado = '3a - ESPERANDO CONF.'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(4) += 1
                End While
            End Using
            oCon.Close()
            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - CONFIRMADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND estado = '4 - CONFIRMADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(5) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { VENTAS - TERMINADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '1 - VENTAS' AND (estado = '5 - NO CONFIRMA' OR estado = '6 - REPARADO' OR estado = '7 - SIN REPARACION')", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(6) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TOTAL TALLER }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado <> '8 - ENTREGADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(7) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - INGRESADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado = '1 - INGRESO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(8) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - PRESUPUESTADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado = '2 - PRESUPUESTADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(9) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - AVISADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado = '3 - AVISADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(10) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - ESPERANDO }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado = '3a - ESPERANDO CONF.'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(11) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - CONFIRMADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND estado = '4 - CONFIRMADO'", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    cantidadEquipos(12) += 1
                End While
            End Using
            oCon.Close()

            ' OBTENEMOS EL NUMERO DE EQUIPOS { TALLER - TERMINADOS }
            oCon.Open()
            Using oCmd As New MySqlCommand("SELECT id, orden FROM ordenes WHERE Ubicacion = '2 - TALLER' AND (estado = '5 - NO CONFIRMA' OR estado = '6 - REPARADO' OR estado = '7 - SIN REPARACION')", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                drOrdenes = oCmd.ExecuteReader
                While drOrdenes.Read
                    Dim orden As New eOrdenes

                    orden.Id = drOrdenes.Item("id")
                    cantidadEquipos(13) += 1
                End While
            End Using
            oCon.Close()

        End Using

        Return cantidadEquipos

    End Function

    Function ObtenerAvisar() As List(Of eOrdenes)

        Try
            Dim lOrdenes As New List(Of eOrdenes)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM ordenes WHERE estado = '2 - PRESUPUESTADO' OR estado = '5 - NO CONFIRMA' OR estado = '6 - REPARADO' OR estado = '7 - SIN REPARACION' ORDER BY estado ASC", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim Orden As New eOrdenes

                        Orden.Id = drOrdenes.Item("id")
                        Orden.Orden = drOrdenes.Item("orden")
                        Orden.Ubicacion = drOrdenes.Item("ubicacion")
                        Orden.Estado = drOrdenes.Item("estado")
                        If drOrdenes.Item("fechaingreso") IsNot DBNull.Value Then Orden.FechaIngreso = drOrdenes.Item("fechaingreso")
                        Orden.Propietario = drOrdenes.Item("propietario")
                        Orden.Domicilio = drOrdenes.Item("domicilio")
                        Orden.Telefono = drOrdenes.Item("telefono")
                        Orden.Email = drOrdenes.Item("email")
                        Orden.Equipo = drOrdenes.Item("equipo")
                        Orden.Diagnostico = drOrdenes.Item("diagnostico")
                        If drOrdenes.Item("fechaterminado") IsNot DBNull.Value Then Orden.FechaTerminado = drOrdenes.Item("fechaterminado")
                        If drOrdenes.Item("trabajos") IsNot DBNull.Value Then Orden.Trabajos = drOrdenes.Item("trabajos")
                        If drOrdenes.Item("otros") IsNot DBNull.Value Then Orden.Otros = drOrdenes.Item("otros")
                        If drOrdenes.Item("importe") IsNot DBNull.Value Then Orden.Importe = drOrdenes.Item("importe")
                        If drOrdenes.Item("tecnico") IsNot DBNull.Value Then Orden.Tecnico = drOrdenes.Item("tecnico")

                        lOrdenes.Add(Orden)
                    End While
                End Using
            End Using

            Return lOrdenes

        Catch ex As Exception


        End Try

    End Function

    Function BuscarPorNombre(nombre As String) As List(Of eOrdenes)
        Try
            Dim lOrdenes As New List(Of eOrdenes)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM ordenes WHERE propietario LIKE '%" & nombre & "%'", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim Orden As New eOrdenes

                        Orden.Id = drOrdenes.Item("id")
                        Orden.Orden = drOrdenes.Item("orden")
                        Orden.Ubicacion = drOrdenes.Item("ubicacion")
                        Orden.Estado = drOrdenes.Item("estado")
                        If drOrdenes.Item("fechaingreso") IsNot DBNull.Value Then Orden.FechaIngreso = drOrdenes.Item("fechaingreso")
                        Orden.Propietario = drOrdenes.Item("propietario")
                        Orden.Domicilio = drOrdenes.Item("domicilio")
                        Orden.Telefono = drOrdenes.Item("telefono")
                        Orden.Email = drOrdenes.Item("email")
                        Orden.Equipo = drOrdenes.Item("equipo")
                        Orden.Diagnostico = drOrdenes.Item("diagnostico")
                        If drOrdenes.Item("fechaterminado") IsNot DBNull.Value Then Orden.FechaTerminado = drOrdenes.Item("fechaterminado")
                        If drOrdenes.Item("trabajos") IsNot DBNull.Value Then Orden.Trabajos = drOrdenes.Item("trabajos")
                        If drOrdenes.Item("otros") IsNot DBNull.Value Then Orden.Otros = drOrdenes.Item("otros")
                        If drOrdenes.Item("importe") IsNot DBNull.Value Then Orden.Importe = drOrdenes.Item("importe")
                        If drOrdenes.Item("tecnico") IsNot DBNull.Value Then Orden.Tecnico = drOrdenes.Item("tecnico")

                        lOrdenes.Add(Orden)
                    End While
                End Using
            End Using

            Return lOrdenes

        Catch ex As Exception

        End Try

    End Function

    Function BuscarOrdenPorEstado(estado As String) As List(Of eOrdenes)
        Try
            Dim lOrdenes As New List(Of eOrdenes)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM ordenes WHERE estado = '" & estado & "'", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim Orden As New eOrdenes

                        Orden.Id = drOrdenes.Item("id")
                        Orden.Orden = drOrdenes.Item("orden")
                        Orden.Ubicacion = drOrdenes.Item("ubicacion")
                        Orden.Estado = drOrdenes.Item("estado")
                        If drOrdenes.Item("fechaingreso") IsNot DBNull.Value Then Orden.FechaIngreso = drOrdenes.Item("fechaingreso")
                        Orden.Propietario = drOrdenes.Item("propietario")
                        Orden.Domicilio = drOrdenes.Item("domicilio")
                        Orden.Telefono = drOrdenes.Item("telefono")
                        Orden.Email = drOrdenes.Item("email")
                        Orden.Equipo = drOrdenes.Item("equipo")
                        Orden.Diagnostico = drOrdenes.Item("diagnostico")
                        If drOrdenes.Item("fechaterminado") IsNot DBNull.Value Then Orden.FechaTerminado = drOrdenes.Item("fechaterminado")
                        If drOrdenes.Item("trabajos") IsNot DBNull.Value Then Orden.Trabajos = drOrdenes.Item("trabajos")
                        If drOrdenes.Item("otros") IsNot DBNull.Value Then Orden.Otros = drOrdenes.Item("otros")
                        If drOrdenes.Item("importe") IsNot DBNull.Value Then Orden.Importe = drOrdenes.Item("importe")
                        If drOrdenes.Item("tecnico") IsNot DBNull.Value Then Orden.Tecnico = drOrdenes.Item("tecnico")

                        lOrdenes.Add(Orden)
                    End While
                End Using
            End Using

            Return lOrdenes

        Catch ex As Exception

        End Try

    End Function

    Function BuscarOrdenPorUbicacion(ubicacion As String) As List(Of eOrdenes)
        Try
            Dim lOrdenes As New List(Of eOrdenes)
            Dim drOrdenes As MySqlDataReader = Nothing

            Using oCon As New MySqlConnection(sConString)
                oCon.Open()
                Using oCmd As New MySqlCommand("SELECT * FROM ordenes WHERE ubicacion = '" & ubicacion & "' AND estado <> '8 - ENTREGADO'", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    drOrdenes = oCmd.ExecuteReader
                    While drOrdenes.Read
                        Dim Orden As New eOrdenes

                        Orden.Id = drOrdenes.Item("id")
                        Orden.Orden = drOrdenes.Item("orden")
                        Orden.Ubicacion = drOrdenes.Item("ubicacion")
                        Orden.Estado = drOrdenes.Item("estado")
                        If drOrdenes.Item("fechaingreso") IsNot DBNull.Value Then Orden.FechaIngreso = drOrdenes.Item("fechaingreso")
                        Orden.Propietario = drOrdenes.Item("propietario")
                        Orden.Domicilio = drOrdenes.Item("domicilio")
                        Orden.Telefono = drOrdenes.Item("telefono")
                        Orden.Email = drOrdenes.Item("email")
                        Orden.Equipo = drOrdenes.Item("equipo")
                        Orden.Diagnostico = drOrdenes.Item("diagnostico")
                        If drOrdenes.Item("fechaterminado") IsNot DBNull.Value Then Orden.FechaTerminado = drOrdenes.Item("fechaterminado")
                        If drOrdenes.Item("trabajos") IsNot DBNull.Value Then Orden.Trabajos = drOrdenes.Item("trabajos")
                        If drOrdenes.Item("otros") IsNot DBNull.Value Then Orden.Otros = drOrdenes.Item("otros")
                        If drOrdenes.Item("importe") IsNot DBNull.Value Then Orden.Importe = drOrdenes.Item("importe")
                        If drOrdenes.Item("tecnico") IsNot DBNull.Value Then Orden.Tecnico = drOrdenes.Item("tecnico")

                        lOrdenes.Add(Orden)
                    End While
                End Using
            End Using

            Return lOrdenes

        Catch ex As Exception

        End Try
    End Function



    Public Shared Sub Main()

    End Sub

End Class
