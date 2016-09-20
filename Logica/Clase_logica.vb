Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data


Public Class Clase_logica
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function BuscaCliente(Optional ByVal Id As String = "", Optional ByVal Nombre As String = "") As eClientes
        Return objDatos.BuscaCliente(Id, Nombre)
    End Function

    Public Function Autocompletar_txtNombreCliente() As List(Of eClientes)
        Return objDatos.Autocompletar_txtNombreCliente
    End Function
    Public Function Mostrar() As List(Of eClientes)
        Return objDatos.MostrarDatos
    End Function

    Public Function IngresarCliente(Cli As eClientes) As Boolean
        Return objDatos.IngresarCliente(Cli)
    End Function

    Public Function ModificarCliente(Cli As eClientes) As Boolean
        Return objDatos.ModificarCliente(Cli)
    End Function

    Public Function EliminarCliente(id As String) As Boolean
        Return objDatos.EliminarCliente(id)
    End Function
    Public Function ObtenerClientes() As DataSet
        Return objDatos.ObtenerClientes
    End Function

    Public Shared Sub Main()

    End Sub
End Class
