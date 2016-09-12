Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb


Public Class BaseDatos

    ' http://pabletoreto.blogspot.com.ar/2012/12/tres-capas-en-vbnet.html

    Private sNombreBd As String = "bd.mdb"
    Private sConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=""" & sNombreBd & """"
    'Dim conexion As String = ConfigurationManager.ConnectionStrings("cnn").ConnectionString

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
                oCon = New OleDbConnection
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

    Public Function MostrarDatos() As List(Of Entidades.eClientes)
        Dim lista As New List(Of Entidades.eClientes)
        Dim dr As OleDbDataReader = Nothing
        Using Sql As New OleDbConnection(sConString)
            Sql.Open()
            Using cmd As New OleDbCommand("SeleccionarDatos", Sql)
                cmd.Connection = Sql
                cmd.CommandType = CommandType.StoredProcedure
                dr = cmd.ExecuteReader
                While dr.Read
                    Dim list As New Entidades.eClientes
                    list.Id = dr.Item("Id")
                    list.Nombre = dr.Item("Nombre")
                    list.Direccion = dr.Item("Direccion")
                    list.Telefono = dr.Item("Telefono")
                    list.Observacion = dr.Item("Observacion")
                    lista.Add(list)
                End While
            End Using
        End Using
        Return lista
    End Function


    Public Shared Sub Main()

    End Sub
End Class
