Public Class Conferencias

    Private midConferencia As Integer
    Private mSiglas As String
    Private mNombre As String
    Private mLugar As String
    Private mFecha_inicio As DateTime
    Private mFecha_fin As DateTime
    Dim mgestorconferencia As New GestorConferencias

    Sub New()

        Me.gestorconferencia = New GestorConferencias

    End Sub

    Public Sub New(ByVal idConferencia As Integer, ByVal Siglas As String, ByVal Nombre As String,
                   ByVal Lugar As String, ByVal Fecha_inicio As DateTime, ByVal Fecha_fin As DateTime)
        Me.midConferencia = idConferencia
        Me.mSiglas = Siglas
        Me.mNombre = Nombre
        Me.mLugar = Lugar
        Me.mFecha_inicio = Fecha_inicio
        Me.Fecha_fin = Fecha_fin
        Me.gestorconferencia = New GestorConferencias

    End Sub

    Public Property idConferencia As Integer
        Get
            Return Me.midConferencia
        End Get
        Set(ByVal value As Integer)
            Me.midConferencia = value
        End Set
    End Property

    Public Property Siglas As String
        Get
            Return Me.mSiglas
        End Get
        Set(ByVal value As String)
            Me.mSiglas = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return Me.mNombre
        End Get
        Set(ByVal value As String)
            Me.mNombre = value
        End Set
    End Property

    Public Property Lugar As String
        Get
            Return Me.mLugar
        End Get
        Set(ByVal value As String)
            Me.mLugar = value
        End Set
    End Property

    Public Property Fecha_inicio As DateTime
        Get
            Return Me.mFecha_inicio
        End Get
        Set(ByVal value As DateTime)
            Me.mFecha_inicio = value
        End Set
    End Property

    Public Property Fecha_fin As DateTime
        Get
            Return Me.mFecha_fin
        End Get
        Set(ByVal value As DateTime)
            Me.mFecha_fin = value
        End Set
    End Property

    Public Property gestorconferencia As GestorConferencias
        Get
            Return Me.mgestorconferencia
        End Get
        Set(ByVal value As GestorConferencias)
            Me.mgestorconferencia = value
        End Set
    End Property


    Public Sub leerConferencia(ByVal idConferencia As Integer)

        gestorconferencia.readConf(idConferencia, Me)

    End Sub

    Public Function leerTodosConferencia() As Collection

        Return gestorconferencia.readAllConf()

    End Function

    Public Function insertarConferencia() As Integer

        Return gestorconferencia.insertConf(Me)

    End Function

    Public Function modificarConferencia() As Integer

        Return gestorconferencia.updateConf(Me)

    End Function

    Public Function eliminarConferencia() As Integer

        Return gestorconferencia.deleteConf(Me)

    End Function

End Class
