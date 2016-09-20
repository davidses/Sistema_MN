Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data


Public Class Clase_logica
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function BuscaCliente(Optional ByVal Id As String = "", Optional ByVal Nombre As String = "") As List(Of eClientes)
        Return objDatos.BuscaCliente(Id, Nombre)
    End Function

    Public Function Autocompletar_txtNombreCliente() As List(Of eClientes)
        Return objDatos.Autocompletar_txtNombreCliente
    End Function
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
    Public Function ObtenerClientes() As DataSet
        Return objDatos.ObtenerClientes
    End Function

    Public Shared Sub Main()

    End Sub
End Class
