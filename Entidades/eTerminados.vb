Public Class eTerminados

    Private Id_ As String
    Private Orden_ As String
    Private Fecha_ As String
    Private Cliente_ As String
    Private MarcaModelo_ As String
    Private Trabajos_ As String
    Private Importe_ As String
    Private Tecnico_ As String
    Private Estado_ As String

    Public Property Id() As String
        Get
            Return Id_
        End Get
        Set(ByVal value As String)
            Id_ = value
        End Set
    End Property

    Public Property Orden() As String
        Get
            Return Orden_
        End Get
        Set(ByVal value As String)
            Orden_ = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return Fecha_
        End Get
        Set(ByVal value As String)
            Fecha_ = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return Cliente_
        End Get
        Set(ByVal value As String)
            Cliente_ = value
        End Set
    End Property

    Public Property MarcaModelo() As String
        Get
            Return MarcaModelo_
        End Get
        Set(ByVal value As String)
            MarcaModelo_ = value
        End Set
    End Property

    Public Property Trabajos() As String
        Get
            Return Trabajos_
        End Get
        Set(ByVal value As String)
            Trabajos_ = value
        End Set
    End Property

    Public Property Importe() As String
        Get
            Return Importe_
        End Get
        Set(ByVal value As String)
            Importe_ = value
        End Set
    End Property

    Public Property Tecnico() As String
        Get
            Return Tecnico_
        End Get
        Set(ByVal value As String)
            Tecnico_ = value
        End Set
    End Property

    Public Property Estado() As String
        Get
            Return Estado_
        End Get
        Set(ByVal value As String)
            Estado_ = value
        End Set
    End Property
End Class
