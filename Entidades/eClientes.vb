Public Class eClientes

    Private Id_ As String
    Private Nombre_ As String
    Private Direccion_ As String
    Private Telefono_ As String
    Private Observaciones_ As String

    Public Property Id() As String
        Get
            Return Id_
        End Get
        Set(ByVal value As String)
            Id_ = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Nombre_
        End Get
        Set(ByVal value As String)
            Nombre_ = value
        End Set
    End Property

    Public Property Direccion() As String
        Get
            Return Direccion_
        End Get
        Set(ByVal value As String)
            Direccion_ = value
        End Set
    End Property

    Public Property Telefono() As String
        Get
            Return Telefono_
        End Get
        Set(ByVal value As String)
            Telefono_ = value
        End Set
    End Property

    Public Property Observaciones() As String
        Get
            Return Observaciones_
        End Get
        Set(ByVal value As String)
            Observaciones_ = value
        End Set
    End Property


    Public Shared Sub Main()

    End Sub

End Class
