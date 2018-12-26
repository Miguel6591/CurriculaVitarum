Imports System.Data.OleDb

Public Class AgenteBD

    Public Shared RutaBD As String
    Private Shared CadConexion = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD = Nothing

    Private Sub New()

        AgenteBD.mConexion = New OleDbConnection
        AgenteBD.mConexion.ConnectionString = (CadConexion & RutaBD)
        AgenteBD.mConexion.Open()

    End Sub

    Public Shared Function getAgente() As AgenteBD

        If (mInstancia Is Nothing) Then
            mInstancia = New AgenteBD
        End If

        Return mInstancia

    End Function

    Public Function read(ByVal sql As String) As OleDbDataReader

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()

    End Function

    Public Function update(ByVal sql As String) As Integer

        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()

    End Function

    Public Function delete(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

End Class


