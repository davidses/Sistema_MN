Imports System.Data
Imports System.Data.OleDb

Public Class BaseDatos

    Private sNombreBd As String = "bd.mdb"
    Private sConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=""" & sNombreBd & """"

    Private oCon As OleDbConnection = Nothing
    Private oComm As OleDbCommand = Nothing
    Private oTrans As OleDbTransaction = Nothing
    Private oParam() As OleDbParameter = Nothing

    Public Sub Conectar()

        Try
            If Not Me.oCon Is Nothing Then
                If Me.oCon.State.Equals(ConnectionState.Closed) Then
                    ' La base de datos ya se encuentra abierta
                End If
            End If

            If Me.oCon Is Nothing Then
                Me.oCon.ConnectionString = sConString
            End If

            Me.oCon.Open()

            If Me.oCon.State <> ConnectionState.Open Then
                MsgBox("Error al conectar con la base de datos" & Me.oCon.Database)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Shared Sub Main()

    End Sub
End Class
