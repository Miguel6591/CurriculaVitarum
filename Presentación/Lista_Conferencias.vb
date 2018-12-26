Imports System.Data.OleDb

Public Class Lista_Conferencias

    Dim confer As Conferencias
    Dim asis As Asiste
    Dim inv As Investigadores

    Private Sub ListBoxListaConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxListaConferencias.SelectedIndexChanged

        Dim selectIdConferencia As String = ListBoxListaConferencias.SelectedItem

        Dim i As Integer
        confer = New Conferencias
        asis = New Asiste
        inv = New Investigadores
        i = 1
        confer.leerTodosConferencia()
        asis.leerAsisteTodos()

        While i <= confer.gestorconferencia.listaConf.Count
            If confer.gestorconferencia.listaConf(i).Nombre = selectIdConferencia Then
                confer = confer.gestorconferencia.listaConf(i)
            End If
            i = i + 1

        End While

        TextBoxIdConf.Text = confer.idConferencia
        TextBoxSiglasConf.Text = confer.Siglas
        TextBoxNombreConf.Text = confer.Nombre
        TextBoxLugarConf.Text = confer.Lugar
        DateTimePickerInicioConf.Text = confer.Fecha_inicio
        DateTimePickerFinConf.Text = confer.Fecha_fin

        asis.leerAsiste(confer.idConferencia)

        For Each Me.asis In asis.gestorasiste.listaAs
            inv.leerIdInvestigador(asis.Invest)
            If (Me.asis.Conferencia.Equals(confer.idConferencia)) Then

                TextBoxInvest.Text = Me.inv.Nombre & " " & Me.inv.Apellidos

            End If
        Next

    End Sub

    Private Sub actualizarConferencias()

        ListBoxListaConferencias.Items.Clear()

        Try
            confer = New Conferencias

            Me.confer.leerTodosConferencia()

            For Each Me.confer In confer.gestorconferencia.listaConf
                ListBoxListaConferencias.Items.Add(confer.Nombre)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click

        Me.Dispose()
        Ventana_Principal.Show()

    End Sub

    Private Sub Lista_Conferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        actualizarConferencias()
    End Sub

End Class