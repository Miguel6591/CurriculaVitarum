Imports System.Data.OleDb

Public Class GestorAsiste

    Dim ListaAsiste As Collection
    Dim agent As AgenteBD
    Dim dr As OleDbDataReader
    Dim asis As Asiste

    Public Property listaAs As Collection
        Get
            Return ListaAsiste
        End Get
        Set(value As Collection)
            ListaAsiste = value
        End Set
    End Property

    Public Sub New()
        ListaAsiste = New Collection
    End Sub

    Public Sub readAsist(ByVal Conferencia As Integer, ByVal asi As Asiste)

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM ASISTE WHERE Conferencia= " & Conferencia & ";")

        While dr.Read()
            asi.Conferencia = dr("Conferencia")
            asi.Invest = dr("Invest")
        End While

    End Sub

    Public Function readAllAsist()

        agent = AgenteBD.getAgente
        dr = agent.read("SELECT * FROM ASISTE ORDER BY Conferencia;")
        While dr.Read

            asis = New Asiste(dr("Conferencia"), dr("Invest"))
            listaAs.Add(asis)
        End While
        Return listaAs

    End Function

    Public Function insertAsist(ByVal asi As Asiste) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("INSERT INTO ASISTE (Conferencia, Invest)" &
                        " VALUES ('" & asi.Conferencia & "', '" & asi.Invest & "');")

    End Function

    Public Function updateAsist(ByVal asi As Asiste)

        agent = AgenteBD.getAgente

        Return agent.update("UPDATE ASISTE SET Conferencia='" & asi.Conferencia & "'WHERE Invest=" & asi.Invest & ";")

    End Function

    Public Function deleteAsist(ByVal asi As Asiste)

        agent = AgenteBD.getAgente()

        Return agent.update("DELETE FROM Asiste WHERE Invest=" & asi.Invest & " AND Conferencia=" & asi.Conferencia & ";")

    End Function
   
End Class
