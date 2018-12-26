Public Class Asiste

    Private mConferencia As Integer
    Private mInvest As Integer
    Dim mgestorasiste As New GestorAsiste

    Public Sub New(ByVal Conferencia As Integer, ByVal Invest As Integer)

        mConferencia = Conferencia
        mInvest = Invest

    End Sub

    Sub New()

        Me.gestorasiste = New GestorAsiste()

    End Sub

    Property Conferencia As Integer
        Get
            Return Me.mConferencia
        End Get
        Set(value As Integer)
            Me.mConferencia = value
        End Set
    End Property

    Property Invest As Integer
        Get
            Return Me.mInvest
        End Get
        Set(value As Integer)
            Me.mInvest = value
        End Set
    End Property

    Property gestorasiste As GestorAsiste
        Get
            Return Me.mgestorasiste
        End Get
        Set(value As GestorAsiste)
            Me.mgestorasiste = value
        End Set
    End Property

    Public Sub leerAsiste(ByVal Conferencia As Integer)

        gestorasiste.readAsist(Conferencia, Me)

    End Sub


    Public Function leerAsisteTodos() ' As Collection

        Return gestorasiste.readAllAsist()

    End Function

    Public Function insertarAsiste() As Integer

        Return gestorasiste.insertAsist(Me)

    End Function

    Public Function modificarAsiste() As Integer
        
        Return gestorasiste.updateAsist(Me)

    End Function

    Public Function eliminarAsiste() As Integer

        Return gestorasiste.deleteAsist(Me)

    End Function


End Class
