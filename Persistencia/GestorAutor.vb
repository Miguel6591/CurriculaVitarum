Imports System.Data.OleDb

Public Class GestorAutor

    Dim ListaAutores As Collection
    Dim agent As AgenteBD
    Dim dr As OleDbDataReader
    Dim autor As Autores

    Public Property listaAut As Collection
        Get
            Return ListaAutores
        End Get
        Set(value As Collection)
            ListaAutores = value
        End Set
    End Property

    Sub New()
        ListaAutores = New Collection
    End Sub

    Public Sub readAutor(ByVal Invest As Integer, ByVal aut As Autores)

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM Autor WHERE Invest=" & Invest & ";")

        While dr.Read()
            aut.Invest = dr("Invest")
            aut.Articulo = dr("Articulo")
            aut.orden = dr("orden")

        End While
    End Sub

    Public Function readAutorOrden(ByVal Invest As Integer, ByVal Articulo As Integer, ByVal aut As Autores) As Integer

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM Autor WHERE Invest=" & Invest & " AND Articulo=" & Articulo & ";")
        While dr.Read
            aut.Invest = dr("Invest")
            aut.Articulo = dr("Articulo")
            aut.orden = dr("orden")
        End While
        Return aut.orden
    End Function

    Public Function readAllAutor()

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM Autor ORDER BY Invest;")
        While dr.Read

            autor = New Autores(dr("Invest"), dr("Articulo"), dr("orden"))

            listaAut.Add(autor)
        End While
        Return listaAut

    End Function

    Public Function insertAutor(ByVal aut As Autores) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("INSERT INTO Autor (Invest, Articulo, orden)" &
                        " VALUES ('" & aut.Invest & "', '" & aut.Articulo & "', '" & aut.orden & "');")

    End Function

    Public Function updateAutor(ByVal aut As Autores) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("UPDATE Autor SET orden='" & aut.orden & "'WHERE Invest=" & aut.Invest & " ,Articulo=" & aut.Articulo & ";")

    End Function

    Public Function deleteAutor(ByVal aut As Autores) As Integer

        agent = AgenteBD.getAgente()

        Return agent.update("DELETE FROM Autor WHERE Invest=" & aut.Invest & " AND Articulo=" & aut.Articulo & ";")

    End Function

End Class
