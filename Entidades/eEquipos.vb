Public Class eEquipos

    Private Id_ As String
    Private IdCliente_ As String
    Private Tipo_ As String
    Private Nombre_ As String
    Private Observacion_ As String

    Public Property Id() As String
        Get
            Return Id_
        End Get
        Set(ByVal value As String)
            Id_ = value
        End Set
    End Property

    Public Property IdCliente() As String
        Get
            Return IdCliente_
        End Get
        Set(ByVal value As String)
            IdCliente_ = value
        End Set
    End Property

    Public Property Tipo() As String
        Get
            Return Tipo_
        End Get
        Set(ByVal value As String)
            Tipo_ = value
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

    Public Property Observacion() As String
        Get
            Return Observacion_
        End Get
        Set(ByVal value As String)
            Observacion_ = value
        End Set
    End Property


    End Class
