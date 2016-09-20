Imports Entidades
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.OleDb

Public Class BaseDatos
    ' http://pabletoreto.blogspot.com.ar/2012/12/tres-capas-en-vbnet.html
    Private sNombreBd As String = "bd.mdb"
    Private sConString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data source=""" & sNombreBd & """"

    ' FUNCION DE AUTOCOMPLETADO DE NOMBRE DE CLIENTES
    Function Autocompletar_txtNombreCliente() As List(Of eClientes)
        Dim lista As New List(Of eClientes)
        Dim dr As OleDbDataReader = Nothing
        Using oCon As New OleDbConnection(sConString)
            oCon.Open()
            Using oCmd As New OleDbCommand("SELECT * FROM Clientes", oCon)
                oCmd.Connection = oCon
                oCmd.CommandType = CommandType.Text
                dr = oCmd.ExecuteReader
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

    Public Function BuscaCliente(Optional ByVal Id As String = "", Optional ByVal Nombre As String = "") As List(Of eClientes)
        Dim lCliente As New List(Of eClientes)
        Dim dr As OleDbDataReader = Nothing

        Using oCon As New OleDbConnection(sConString)
            oCon.Open()
            If Id <> "" Then
                ' BUSCA EL CLIENTE POR ID
                Using oCmd As New OleDbCommand("SELECT * FROM Clientes WHERE Id = " & Id, oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    dr = oCmd.ExecuteReader
                    While dr.Read
                        Dim list As New eClientes
                        list.Id = dr.Item("Id")
                        list.Nombre = dr.Item("Nombre")
                        list.Direccion = dr.Item("Direccion")
                        list.Telefono = dr.Item("Telefono")
                        list.Observacion = dr.Item("Observacion")
                        lCliente.Add(list)
                    End While
                End Using

            ElseIf Nombre <> "" Then
                ' BUSCA EL CLIENTE POR NOMBRE
                Using oCmd As New OleDbCommand("SELECT * FROM Clientes WHERE Nombre = """ & Nombre & """", oCon)
                    oCmd.Connection = oCon
                    oCmd.CommandType = CommandType.Text
                    dr = oCmd.ExecuteReader
                    While dr.Read
                        Dim list As New eClientes
                        list.Id = dr.Item("Id")
                        list.Nombre = dr.Item("Nombre")
                        list.Direccion = dr.Item("Direccion")
                        list.Telefono = dr.Item("Telefono")
                        list.Observacion = dr.Item("Observacion")
                        lCliente.Add(list)
                    End While
                End Using
            End If
        End Using

        Return lCliente

    End Function

    ' FUNCION QUE DEVUELVE TODOS LOS CLIENTES
    Public Function ObtenerClientes() As DataSet
        Dim ds As New DataSet
        Dim da As OleDbDataAdapter
        Using oCon As New OleDbConnection(sConString)
            oCon.Open()
            da = New OleDbDataAdapter("SELECT Id, Nombre FROM Clientes ORDER BY Nombre ASC", oCon)
            da.Fill(ds, "Clientes")
        End Using

        Return ds
    End Function

   

    Public Function MostrarDatos() As List(Of Entidades.eClientes)
        Dim lista As New List(Of Entidades.eClientes)
        Dim dr As OleDbDataReader = Nothing
        Using oCon As New OleDbConnection(sConString)
            oCon.Open()
            Using cmd As New OleDbCommand("SELECT * FROM Clientes", oCon)
                cmd.Connection = oCon
                cmd.CommandType = CommandType.Text
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

    Public Function IngresarDatos(datos As eClientes) As Boolean
        ' Si no recibe datos, crea una excepcion
        If datos Is Nothing Then
            Throw New ArgumentException("No se recibieron datos en InsertarDatos")
        End If

        Dim oTrans As OleDbTransaction = Nothing
        Dim Nombre As String = datos.Nombre
        Dim Direccion As String = datos.Direccion
        Dim Telefono As String = datos.Telefono
        Dim Observacion As String = datos.Observacion

        Try
            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)

                Using oCmd As New OleDbCommand("INSERT INTO Clientes (Nombre,Direccion,Telefono,Observacion) VALUES (@nombre, @direccion, @telefono, @observacion)", oCon, oTrans)
                    oCmd.Transaction = oTrans
                    oCmd.CommandType = CommandType.Text

                    oCmd.Parameters.AddWithValue("@nombre", Nombre)
                    oCmd.Parameters.AddWithValue("@direccion", Direccion)
                    oCmd.Parameters.AddWithValue("@telefono", Telefono)
                    oCmd.Parameters.AddWithValue("@observacion", Observacion)

                    ' ejecuta la consulta y verifica que se haya afectado un registro
                    If (oCmd.ExecuteNonQuery = 1) Then
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Controlamos la excepcion del rollback
            Try
                oTrans.Rollback()
            Catch
                ' Aca no escribimos nada.
            End Try

            Return False
            Throw New ArgumentException("Verificar InsertarDatos")
        End Try
    End Function

    Public Function ModificarDatos(datos As eClientes) As Boolean

        If datos Is Nothing Then
            Throw New ArgumentException("no se recibieron datos en ModificarDatos")
        End If

        Dim oTrans As OleDbTransaction = Nothing
        Dim Id As String = datos.Id
        Dim Nombre As String = datos.Nombre
        Dim Direccion As String = datos.Direccion
        Dim Telefono As String = datos.Telefono
        Dim Observacion As String = datos.Observacion

        Try

            Using oCon As New OleDbConnection(sConString)
                oCon.Open()
                oTrans = oCon.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("UPDATE Clientes SET Nombre = @nombre, Direccion = @direccion, Telefono = @telefono, Observacion = @observacion WHERE ID = @id", oCon, oTrans)
                    cmd.Transaction = oTrans
                    cmd.CommandType = CommandType.Text
                    cmd.Parameters.AddWithValue("@id", Id)
                    cmd.Parameters.AddWithValue("@nombre", Nombre)
                    cmd.Parameters.AddWithValue("@direccion", Direccion)
                    cmd.Parameters.AddWithValue("@telefono", Telefono)
                    cmd.Parameters.AddWithValue("@observacion", Observacion)
                    If (cmd.ExecuteNonQuery = 1) Then
                        oTrans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            Try
                oTrans.Rollback()
            Catch

            End Try

            Return False
            Throw New ArgumentException("Verificar ModificarDatos")
        End Try
    End Function

    Public Function EliminarDatos(param As String) As Boolean
        Dim trans As OleDbTransaction = Nothing
        Try
            Using Sql As New OleDbConnection(sConString)
                Sql.Open()
                trans = Sql.BeginTransaction(IsolationLevel.ReadCommitted)
                Using cmd As New OleDbCommand("BorrarDatos", Sql, trans)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@id", param)
                    If (cmd.ExecuteNonQuery = 1) Then
                        trans.Commit()
                        Return True
                    Else
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            trans.Rollback()
            Throw New ArgumentException("Error en BorrarDatos")
        End Try
    End Function

    Public Shared Sub Main()

    End Sub
End Class
