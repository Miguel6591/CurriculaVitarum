Public Class Articulos

    Private midArticulo As Integer
    Private mTitulo As String
    Private mConferencia As Integer
    Private mpag_inicio As Integer
    Private mpag_fin As Integer
    Dim mgestorarticulo As New GestorArticulos

    Sub New()

        Me.gestarticulo = New GestorArticulos

    End Sub

    Public Sub New(ByVal idArticulo As Integer, ByVal Titulo As String, ByVal ConferArticulo As Integer,
                   ByVal pag_inicio As Integer, ByVal pag_fin As Integer)
        Me.midArticulo = idArticulo
        Me.mTitulo = Titulo
        Me.mConferencia = ConferArticulo
        Me.mpag_inicio = pag_inicio
        Me.mpag_fin = pag_fin
        Me.gestarticulo = New GestorArticulos

    End Sub

    Public Property IdArticulo As Integer
        Get
            Return Me.midArticulo
        End Get
        Set(ByVal value As Integer)
            Me.midArticulo = value
        End Set
    End Property

    Public Property Titulo As String
        Get
            Return Me.mTitulo
        End Get
        Set(ByVal value As String)
            Me.mTitulo = value
        End Set
    End Property

    Property Conferencia As Integer
        Get
            Return Me.mConferencia
        End Get
        Set(value As Integer)
            Me.mConferencia = value
        End Set
    End Property

    Public Property pag_inicio As Integer
        Get
            Return Me.mpag_inicio
        End Get
        Set(ByVal value As Integer)
            Me.mpag_inicio = value
        End Set
    End Property

    Public Property pag_fin As Integer
        Get
            Return Me.mpag_fin
        End Get
        Set(ByVal value As Integer)
            Me.mpag_fin = value
        End Set
    End Property

    Public Property gestarticulo As GestorArticulos
        Get
            Return Me.mgestorarticulo
        End Get
        Set(ByVal value As GestorArticulos)
            Me.mgestorarticulo = value
        End Set
    End Property


    Public Function leerIdArticulo(ByVal idArticulo As Integer) As Collection

        Return gestarticulo.readIdArtic(idArticulo, Me)

    End Function

    Public Function leerTodosArticulos() As Collection

        Return gestarticulo.readAllArtic()

    End Function

    Public Sub insertarArticulo()

        gestarticulo.insertArtic(Me)

    End Sub

    Public Function modificarArticulo() As Integer

        Return gestarticulo.updateArtic(Me)

    End Function

    Public Function eliminarArticulo() As Integer

        Return gestarticulo.deleteArtic(Me)

    End Function

End Class
