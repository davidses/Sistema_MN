Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data

Public Class nEquipos
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function LlenarComboClientes() As List(Of eClientes)
        Return objDatos.LlenarComboClientes
    End Function

    Public Function IngresarEqupo(Equipo As eEquipos) As Boolean
        Return objDatos.IngresaEquipo(Equipo)
    End Function

    Public Function BuscaEquipo(ByVal Id As String) As eEquipos
        Return objDatos.BuscaEquipo(Id)
    End Function

    Public Function ModificaEquipo(Equipo As eEquipos) As Boolean
        Return objDatos.ModificaEquipo(Equipo)
    End Function

    'Public Function EliminarEquipo(id As String) As Boolean
    '    Return objDatos.EliminarCliente(id)
    'End Function
    'Public Function ObtenerEquipo() As DataSet
    '    Return objDatos.ObtenerClientes
    'End Function

End Class
