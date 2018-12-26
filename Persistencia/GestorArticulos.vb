Imports System.Data.OleDb

Public Class GestorArticulos

    Dim ListaArticulos As Collection
    Dim agent As AgenteBD
    Dim dr As OleDbDataReader
    Dim art As Articulos

    Public Property listaArt As Collection
        Get
            Return ListaArticulos
        End Get
        Set(value As Collection)
            ListaArticulos = value
        End Set
    End Property

    Sub New()
        ListaArticulos = New Collection
    End Sub

    Public Function readIdArtic(ByVal idArticulo As Integer, ByVal a As Articulos) As Collection

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM ARTICULOS WHERE IdArticulo=" & idArticulo & ";")
        While dr.Read()
            a.IdArticulo = dr(0)
            a.Titulo = dr(1)
            a.Conferencia = dr(2)
            a.pag_inicio = dr(3)
            a.pag_fin = dr(4)

            ListaArticulos.Add(a)
        End While
        Return ListaArticulos

    End Function

    Public Function readAllArtic() As Collection

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM ARTICULOS ORDER BY IdArticulo;")
        While dr.Read

            art = New Articulos(dr("IdArticulo"), dr("Titulo"),
                                dr("Conferencia"), dr("pag_inicio"),
                                dr("pag_fin"))

            listaArt.Add(art)
        End While

        Return listaArt

    End Function

    Public Sub insertArtic(ByVal a As Articulos)

        agent = AgenteBD.getAgente

        dr = agent.read("INSERT INTO Articulos (IdArticulo, Titulo, Conferencia, pag_inicio, pag_fin )" &
                        " VALUES ('" & a.IdArticulo & "', '" & a.Titulo & "', '" & a.Conferencia & "', '" & a.pag_inicio & "', '" & a.pag_fin & "');")

    End Sub

    Public Function updateArtic(ByVal a As Articulos) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("UPDATE Articulos SET Titulo ='" & a.Titulo & "' ,Conferencia ='" & a.Conferencia &
                            "' ,pag_inicio ='" & a.pag_inicio & "' ,pag_fin ='" & a.pag_fin & "'WHERE IdArticulo=" & a.IdArticulo & ";")

    End Function

    Public Function deleteArtic(ByVal a As Articulos) As Integer

        agent = AgenteBD.getAgente()

        Return agent.update("DELETE FROM Articulos WHERE IdArticulo=" & a.IdArticulo & ";")

    End Function

End Class
