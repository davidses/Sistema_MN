Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Public Class nTerminados
    Dim objDatos As New BaseDatos.BaseDatos

    'Public Function UltimoIdFicha() As eFichas
    'Return objDatos.UltimoIdFicha
    'End Function

    Public Function BuscaOrden(ByVal Orden As String) As eTerminados
        Return objDatos.BuscaOrden(Orden)
    End Function

    'Public Function BuscaFichasPorEquipo(ByVal id As String) As List(Of eFichas)
    'Return objDatos.BuscaFichaPorEquipo(id)
    'End Function

    Public Function IngresaTerminados(Terminado As eTerminados) As Boolean
        Return objDatos.IngresaTerminados(Terminado)
    End Function

    Public Function ModificarTerminado(Terminado As eTerminados) As Boolean
        Return objDatos.ModificarTerminado(Terminado)
    End Function

    Public Function EliminarTerminado(orden As String) As Boolean
        Return objDatos.EliminarTerminado(orden)
    End Function

    Public Function BuscaTerminadosMensual(mes As Integer, tecnico As String) As List(Of eTerminados)
        Return objDatos.BuscaTerminadosMensual(mes, tecnico)
    End Function

End Class
