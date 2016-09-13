Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic

Public Class Clase_logica
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function Mostrar() As List(Of eClientes)
        Return objDatos.MostrarDatos
    End Function

    Public Function IngresarDatos(datos As eClientes) As Boolean
        Return objDatos.IngresarDatos(datos)
    End Function

    Public Function ModificarDatos(datos As eClientes) As Boolean
        Return objDatos.ModificarDatos(datos)
    End Function

    Public Function EliminarDatos(id As String) As Boolean
        Return objDatos.EliminarDatos(id)
    End Function

    Public Shared Sub Main()

    End Sub
End Class
