Imports BaseDatos
Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Public Class nFichas
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function UltimoIdFicha() As eFichas
        Return objDatos.UltimoIdFicha
    End Function

    Public Function BuscaFicha(ByVal Id As String) As eFichas
        Return objDatos.BuscaFicha(Id)
    End Function

    Public Function IngresaFicha(Ficha As eFichas) As Boolean
        Return objDatos.IngresaFicha(Ficha)
    End Function
    Public Function ModificarFicha(Ficha As eFichas) As Boolean
        Return objDatos.ModificarFicha(Ficha)
    End Function
    Public Function EliminarFicha(id As String) As Boolean
        Return objDatos.EliminarFicha(id)
    End Function

End Class
