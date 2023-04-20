Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data

Public Class nOrdenes

    Dim objDatos As New BaseDatos.BaseDatos

    Public Function BuscaOrden2(ByVal Orden As String) As eOrdenes
        If Orden <> "" Then
            Return objDatos.BuscaOrden2(Orden)
        Else
            Return Nothing
        End If
    End Function

    Public Function GuardaOrden(orden As eOrdenes) As Boolean
        If orden Is Nothing Then
            Return Nothing
        Else
            Return objDatos.GuardaOrden(orden)
        End If
    End Function

    Public Function ModificaOrden(orden As eOrdenes) As Boolean
        If orden Is Nothing Then
            Return Nothing
        Else
            Return objDatos.ModificaOrden(orden)
        End If
    End Function

    Public Function ModificaOrdenST(orden As eOrdenes) As Boolean
        If orden Is Nothing Then
            Return Nothing
        Else
            Return objDatos.ModificaOrdenST(orden)
        End If
    End Function

    Public Function ModificaUbiOrden(orden As String, ubi As String) As Boolean
        If orden Is Nothing Then
            Return Nothing
        Else
            Return objDatos.ModificaUbiOrden(orden, ubi)
        End If
    End Function

    Public Function ObtenerStockEquipos() As (stockVentas As Integer, stockTaller As Integer)
        Dim sVentas As Integer
        Dim sTaller As Integer

        sVentas = objDatos.ObtenerStockEquipos.Item1.Count
        sTaller = objDatos.ObtenerStockEquipos.Item2.Count

        Return (sVentas, sTaller)

    End Function

    Public Function ObtenerAvisar() As List(Of eOrdenes)
        Return objDatos.ObtenerAvisar()
    End Function

    Public Function ObtenerUbicacionEstado() As Array
        Return objDatos.ObtenerUbicacionEstado
    End Function

    Public Function BuscarPorNombre(nombre As String) As List(Of eOrdenes)
        Return objDatos.BuscarPorNombre(nombre)
    End Function

    Public Function BuscarOrdenPorEstado(estado As String) As List(Of eOrdenes)
        Return objDatos.BuscarOrdenPorEstado(estado)
    End Function

    Public Function BuscaUltimaOrden() As Integer
        Return objDatos.UltimaOrden
    End Function

    Public Function BuscaOrdenPorUbicacion(ubicacion As String) As List(Of eOrdenes)
        Return objDatos.BuscarOrdenPorUbicacion(ubicacion)
    End Function

End Class
