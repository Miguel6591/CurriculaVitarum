Public Class Autores

    Private mInvest As Integer
    Private mArticulo As Integer
    Private mOrden As Integer
    Dim mgestorautor As New GestorAutor

    Public Sub New(ByVal Invest As Integer, ByVal Articulo As Integer)

        mInvest = Invest
        mArticulo = Articulo

    End Sub

    Public Sub New(ByVal Invest As Integer, ByVal Articulo As Integer, ByVal orden As Integer)

        mInvest = Invest
        mArticulo = Articulo
        mOrden = orden

    End Sub

    Sub New()

        Me.gestorAutor = New GestorAutor()

    End Sub

    Property Invest As Integer
        Get
            Return Me.mInvest
        End Get
        Set(value As Integer)
            Me.mInvest = value
        End Set
    End Property


    Property Articulo As Integer
        Get
            Return Me.mArticulo
        End Get
        Set(value As Integer)
            Me.mArticulo = value
        End Set
    End Property

    Property orden As Integer
        Get
            Return Me.mOrden
        End Get
        Set(value As Integer)
            Me.mOrden = value
        End Set
    End Property

    Property gestorAutor As GestorAutor
        Get
            Return Me.mgestorautor
        End Get
        Set(value As GestorAutor)
            Me.mgestorautor = value
        End Set
    End Property

    Public Sub leerAutores(ByVal Invest As Integer)

        gestorAutor.readAutor(Invest, Me)

    End Sub

    Public Function leerAutoresOrden(ByVal Invest As Integer, ByVal Articulo As Integer) As Integer

        Return gestorAutor.readAutorOrden(Invest, Articulo, Me)

    End Function

    Public Function leerAutoresTodos()

        Return gestorAutor.readAllAutor()

    End Function

    Public Function insertarAutores() As Integer

        Return gestorAutor.insertAutor(Me)

    End Function

    Public Function modificarAutores() As Integer

        Return gestorAutor.updateAutor(Me)

    End Function

    Public Function eliminarAutores() As Integer

        Return gestorAutor.deleteAutor(Me)

    End Function

End Class
