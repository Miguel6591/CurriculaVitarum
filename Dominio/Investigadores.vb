Public Class Investigadores

    Private midInvest As Integer
    Private mNombre As String
    Private mApellidos As String
    Private mDespacho As String
    Private mEdificio As String
    Private mDepartamento As String
    Private mTelefono As String
    Private mEmail As String
    Dim mgestorInvestigador As New GestorInvestigadores

    Public Sub New(ByVal idInvest As Integer, ByVal Nombre As String, ByVal Apellidos As String, ByVal Despacho As String, ByVal Edificio As String,
                  ByVal Departamento As String, ByVal Telefono As String, ByVal Email As String)

        Me.midInvest = idInvest
        Me.mNombre = Nombre
        Me.mApellidos = Apellidos
        Me.mDespacho = Despacho
        Me.mEdificio = Edificio
        Me.mDepartamento = Departamento
        Me.mTelefono = Telefono
        Me.mEmail = Email
        Me.gestorInvestigador = New GestorInvestigadores

    End Sub

    Sub New()

        Me.gestorInvestigador = New GestorInvestigadores

    End Sub

    Public Property idInvest As Integer
        Get
            Return Me.midInvest
        End Get
        Set(ByVal value As Integer)
            Me.midInvest = value
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

    Public Property Apellidos As String
        Get
            Return Me.mApellidos
        End Get
        Set(ByVal value As String)
            Me.mApellidos = value
        End Set
    End Property

    Public Property Despacho As String
        Get
            Return Me.mDespacho
        End Get
        Set(ByVal value As String)
            Me.mDespacho = value
        End Set
    End Property

    Public Property Edificio As String
        Get
            Return Me.mEdificio
        End Get
        Set(ByVal value As String)
            Me.mEdificio = value
        End Set
    End Property

    Public Property Departamento As String
        Get
            Return Me.mDepartamento
        End Get
        Set(ByVal value As String)
            Me.mDepartamento = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return Me.mTelefono
        End Get
        Set(ByVal value As String)
            Me.mTelefono = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return Me.mEmail
        End Get
        Set(ByVal value As String)
            Me.mEmail = value
        End Set
    End Property

    Public Property gestorInvestigador As GestorInvestigadores
        Get
            Return Me.mgestorInvestigador
        End Get
        Set(ByVal value As GestorInvestigadores)
            Me.mgestorInvestigador = value
        End Set
    End Property

    'Public Sub leerInvestigador()

    '    gestorInvestigador.readInv(Me)

    'End Sub

    Public Function leerIdInvestigador(ByVal idInvest As Integer) As Collection

        Return gestorInvestigador.readIdInv(idInvest, Me)

    End Function

    Public Function leerTodosInvestigador() As Collection

        Return gestorInvestigador.readAllInv()

    End Function

    Public Sub insertarInvestigador()

        gestorInvestigador.insertInv(Me)

    End Sub

    Public Function modificarInvestigador() As Integer

        Return gestorInvestigador.updateInv(Me)

    End Function

    Public Function eliminarInvestigador() As Integer

        Return gestorInvestigador.deleteInv(Me)

    End Function

End Class
