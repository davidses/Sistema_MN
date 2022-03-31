Public Class eFichas

    Private Id_ As String
    Private Fecha_ As String
    Private Realizar_ As String
    Private Realizado_ As String
    Private Importe_ As String
    Private Observaciones_ As String
    Private Equipos_IdEquipos_ As String
    Private Estado_ As String

    Public Property Id() As String
        Get
            Return Id_
        End Get
        Set(ByVal value As String)
            Id_ = value
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

    Public Property Realizar() As String
        Get
            Return Realizar_
        End Get
        Set(ByVal value As String)
            Realizar_ = value
        End Set
    End Property

    Public Property Realizado() As String
        Get
            Return Realizado_
        End Get
        Set(ByVal value As String)
            Realizado_ = value
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

    Public Property Observaciones() As String
        Get
            Return Observaciones_
        End Get
        Set(ByVal value As String)
            Observaciones_ = value
        End Set
    End Property

    Public Property Equipos_IdEquipos() As String
        Get
            Return Equipos_IdEquipos_
        End Get
        Set(ByVal value As String)
            Equipos_IdEquipos_ = value
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
