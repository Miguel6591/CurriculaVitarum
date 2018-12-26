Imports System.Data.OleDb

Public Class GestorConferencias

    Dim ListaConferencias As Collection
    Dim agent As AgenteBD
    Dim dr As OleDbDataReader
    Dim confe As Conferencias

    Public Property listaConf As Collection
        Get
            Return ListaConferencias
        End Get
        Set(value As Collection)
            ListaConferencias = value
        End Set
    End Property

    Sub New()
        ListaConferencias = New Collection
    End Sub

    Public Sub readConf(ByVal idConferencia As Integer, ByVal c As Conferencias)

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM Conferencias WHERE idConferencia=" & idConferencia & ";")

        While dr.Read()
            c.idConferencia = dr("idConferencia")
            c.Siglas = dr("Siglas")
            c.Nombre = dr("Nombre")
            c.Lugar = dr("Lugar")
            c.Fecha_inicio = dr("Fecha_inicio")
            c.Fecha_fin = dr("Fecha_fin")

        End While
    End Sub

    Public Function readAllConf() As Collection

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM Conferencias ORDER BY idConferencia;")
        While dr.Read

            confe = New Conferencias(dr("idConferencia"), dr("Siglas"),
                                     dr("Nombre"), dr("Lugar"),
                                     dr("Fecha_inicio"), dr("Fecha_fin"))
            listaConf.Add(confe)

        End While

        Return listaConf

    End Function

    Public Function insertConf(ByVal c As Conferencias) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("INSERT INTO Conferencias (idConferencia, Siglas, Nombre, Lugar, Fecha_inicio, Fecha_fin )" &
                        " VALUES ('" & c.idConferencia & "', '" & c.Siglas & "', '" & c.Nombre & "', '" & c.Lugar & "', '" & c.Fecha_inicio & "', '" & c.Fecha_fin & "');")

    End Function

    Public Function updateConf(ByVal c As Conferencias) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("UPDATE Conferencias SET Siglas ='" & c.Siglas & "' ,Nombre ='" & c.Nombre &
                        "' ,Lugar ='" & c.Lugar & "' ,Fecha_inicio ='" & c.Fecha_inicio &
                        "' ,Fecha_fin ='" & c.Fecha_fin & "'WHERE idConferencia=" & c.idConferencia & ";")

    End Function

    Public Function deleteConf(ByVal c As Conferencias) As Integer

        agent = AgenteBD.getAgente()

        Return agent.update("DELETE FROM Conferencias WHERE idConferencia=" & c.idConferencia & ";")

    End Function

End Class
