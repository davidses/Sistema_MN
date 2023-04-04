Imports System.Windows
Imports BaseDatos

Public Class nGeneral
    Dim objDatos As New BaseDatos.BaseDatos

    Public Function ConfigurarBD() As Boolean
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

        objDatos.sConString = "Server=" & strConfig(0) & " ;Port=" & strConfig(1) & " ;Database=" & strConfig(2) & " ;Uid=" & strConfig(3) & " ;Pwd=" & strConfig(4)

        Return True
    End Function

    Public Function PruebaConexion() As Boolean
        Return objDatos.PruebaConexion()
    End Function

    Public Function ObtenerConexion() As String
        Return objDatos.sConString
    End Function

    Public Shared Sub Main()

    End Sub

End Class
