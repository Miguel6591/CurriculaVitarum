Imports System.Data.OleDb

Public Class GestorInvestigadores

    Dim ListaInvestigadores As Collection
    Dim agent As AgenteBD
    Dim dr As OleDbDataReader
    Dim invest As Investigadores

    Public Property listaInv As Collection
        Get
            Return Me.ListaInvestigadores
        End Get
        Set(value As Collection)
            Me.ListaInvestigadores = value
        End Set
    End Property

    Public Sub New()
        Me.ListaInvestigadores = New Collection
    End Sub

    Public Function readIdInv(ByVal idInvest As Integer, ByVal inv As Investigadores) As Collection


        agent = AgenteBD.getAgente()
        dr = agent.read("SELECT * FROM INVESTIGADORES WHERE iDInvest=" & idInvest & ";")

        While dr.Read()
            inv.idInvest = Convert.ToInt32(dr(0))
            inv.Nombre = dr(1).ToString
            inv.Apellidos = dr(2).ToString
            inv.Despacho = dr(3).ToString
            inv.Edificio = dr(4).ToString
            inv.Departamento = dr(5).ToString
            inv.Telefono = dr(6).ToString
            inv.Email = dr(7).ToString

            listaInv.Add(inv)
        End While
        Return listaInv

    End Function

    Public Function readAllInv() As Collection

        agent = AgenteBD.getAgente()
        dr = agent.read("SELECT * FROM INVESTIGADORES ORDER BY idInvest;")

        While dr.Read()

            invest = New Investigadores(dr("idInvest"), dr("Nombre"),
                                        dr("Apellidos"), dr("Despacho"),
                                        dr("Edificio"), dr("Departamento"),
                                        dr("Teléfono"), dr("Email"))
            listaInv.Add(invest)
        End While

        Return listaInv

    End Function

    Public Sub insertInv(ByVal inv As Investigadores)

        agent = AgenteBD.getAgente

        dr = agent.read("INSERT INTO Investigadores VALUES ('" & inv.idInvest & "', '" & inv.Nombre & "', '" & inv.Apellidos &
                        "', '" & inv.Despacho & "', '" & inv.Edificio & "', '" & inv.Departamento &
                        "', '" & inv.Telefono & "', '" & inv.Email & "');")

    End Sub

    Public Function updateInv(ByVal inv As Investigadores) As Integer

        agent = AgenteBD.getAgente

        Return agent.update("UPDATE Investigadores SET Nombre='" & inv.Nombre & "',Apellidos='" & inv.Apellidos & "',Despacho='" & inv.Despacho &
                            "',Edificio='" & inv.Edificio & "',Departamento='" & inv.Departamento & "',Teléfono='" & inv.Telefono &
                            "',Email='" & inv.Email & "'WHERE idInvest=" & inv.idInvest & ";")

    End Function

    Public Function deleteInv(ByVal inv As Investigadores) As Integer

        agent = AgenteBD.getAgente()

        Return agent.update("DELETE FROM Investigadores WHERE idInvest=" & inv.idInvest & ";")

    End Function

End Class
