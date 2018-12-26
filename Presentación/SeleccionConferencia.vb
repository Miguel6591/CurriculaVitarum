Imports System.Data.OleDb

Public Class SeleccionConferencia

    Dim invest As Investigadores
    Dim conf As Conferencias
    Dim asis As Asiste

    Private Sub ListBoxListConf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxListConf.SelectedIndexChanged

        ListBoxAsisConf.Items.Clear()

        Dim i As Integer
        conf = New Conferencias
        asis = New Asiste
        invest = New Investigadores
        i = 1
        asis.leerAsisteTodos()
        conf.leerTodosConferencia()

        While i <= conf.gestorconferencia.listaConf.Count
            If conf.gestorconferencia.listaConf(i).Nombre = ListBoxListConf.SelectedItem Then
                conf = conf.gestorconferencia.listaConf(i)
            End If
            i = i + 1
        End While

        TextBoxConInvesti.Text = conf.idConferencia

        asis.leerAsiste(conf.idConferencia)

        For Each Me.asis In asis.gestorasiste.listaAs
            invest.leerIdInvestigador(asis.Invest)
            If (Me.asis.Conferencia.Equals(conf.idConferencia)) Then

                ListBoxAsisConf.Items.Add(invest.Nombre & " " & invest.Apellidos)

            End If
        Next


    End Sub

    Private Sub ListBoxAsisConf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAsisConf.SelectedIndexChanged

        Dim ente As Integer

        asis = New Asiste
        invest = New Investigadores

        invest.leerTodosInvestigador()
        ente = 1
        While ente <= invest.gestorInvestigador.listaInv.Count
            If (invest.gestorInvestigador.listaInv(ente).Nombre & " " &
                invest.gestorInvestigador.listaInv(ente).Apellidos).Equals(ListBoxAsisConf.SelectedItem) Then
                invest = invest.gestorInvestigador.listaInv(ente)
            End If

            ente = ente + 1
        End While

        TextBoxAsisInvesti.Text = invest.Nombre & " " & invest.Apellidos

    End Sub

    Private Sub ListBoxConfInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConfInv.SelectedIndexChanged

        Dim selIdInvestigador As String = ListBoxConfInv.SelectedItem
        Dim ine As Integer
        invest = New Investigadores

        ' listaInvestigadores =
        invest.leerTodosInvestigador()
        ine = 1
        While ine <= invest.gestorInvestigador.listaInv.Count
            If (invest.gestorInvestigador.listaInv(ine).Nombre = selIdInvestigador) Then
                invest = invest.gestorInvestigador.listaInv(ine)
            End If
            ine = ine + 1
        End While

        TextBoxConferenInve.Text = invest.idInvest

    End Sub

    Private Sub ButtonAsistirConfInv_Click(sender As Object, e As EventArgs) Handles ButtonAsistirConfInv.Click

        invest = New Investigadores
        conf = New Conferencias
        asis = New Asiste

        ' autor.leerAutoresTodos()

        If (TextBoxConferenInve.Text.Equals("") Or TextBoxConInvesti.Text.Equals("")) Then
            MessageBox.Show("No se puede añadir un investigador a una conferencia si no se rellenan todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'try
            asis = New Asiste(TextBoxConInvesti.Text, TextBoxConferenInve.Text)

            If Me.asis.insertarAsiste() = 1 Then

                actualizarAsiste()
                actualizarInvestigadores()
                'actualizarConferencias()
                ' actualizarAutores()
                limpiarCampos()
                ListBoxAsisConf.Items.Clear()
                MessageBox.Show("El investigador se ha añadido correctamente a la conferencia", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al añadir el investigador a la conferencia.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
                limpiarCampos()
            End If
            'Catch ex As Exception
            '    MessageBox.Show("Introduzca valores enteros o decimales en el campo." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
            '    limpiarCampos()
            'End Try
            'Else
            'MessageBox.Show("Un investigador ya tiene ese orden en ese artículo. Introduzca otro orden", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If


        End If

    End Sub

    Private Sub ButtonModifConfInv_Click(sender As Object, e As EventArgs) Handles ButtonModifConfInv.Click

    End Sub

    Private Sub ButtonElAsInv_Click(sender As Object, e As EventArgs) Handles ButtonElAsInv.Click

        Try
            If (TextBoxConferenInve.Text.Equals("") Or TextBoxConInvesti.Text.Equals("")) Then
                MessageBox.Show("No se puede eliminar un investigador de una conferencia si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                'errorr1 = False
                'For Each Me.autor In autor.gestorAutor.listaAut
                '    If (Me.autor.Articulo.Equals(TextBoxListArt.Text) And
                '        Me.autor.Invest.Equals(TextBoxListInv.Text)) Then
                '        errorr1 = False
                '    End If
                'Next


                asis = New Asiste(TextBoxConInvesti.Text, TextBoxConferenInve.Text)

                If MessageBox.Show("¿ Quiere eliminar este investigador de la conferencia?", "Eliminar investigador de una conferencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    'For Each Me.autor In autor.gestorAutor.listaAut
                    '    If (Me.autor.Articulo.Equals(TextBoxListArt.Text) And
                    '        Me.autor.Invest.Equals(TextBoxListInv.Text)) Then
                    '        errorr1 = False
                    '    End If
                    'Next

                    If Me.asis.eliminarAsiste() = 1 Then
                        'If errorr1 = False Then
                        'actualizarConferencias()
                        actualizarAsiste()
                        actualizarInvestigadores()
                        limpiarCampos()
                        ListBoxAsisConf.Items.Clear()
                        MessageBox.Show("El investigador se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Else
                        '    MessageBox.Show("Error. El investigador no es autor de ese artículo.", "Error",
                        '                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                        '    limpiarCampos()
                        'End If
                    End If

                Else
                    limpiarCampos()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el investigador de la conferencia.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCampos()
        End Try


    End Sub

    Private Sub actualizarConferencias()

        limpiarCampos()

        Try
            conf = New Conferencias
            'listaConferencias = 
            Me.conf.leerTodosConferencia()

            For Each Me.conf In Me.conf.gestorconferencia.listaConf
                ListBoxListConf.Items.Add(Me.conf.Nombre)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub actualizarInvestigadores()

        limpiarCampos()
        ListBoxConfInv.Items.Clear()

        Try
            invest = New Investigadores
            'listaInvestigadores =
            Me.invest.leerTodosInvestigador()

            For Each Me.invest In Me.invest.gestorInvestigador.listaInv
                ListBoxConfInv.Items.Add(Me.invest.Nombre)
            Next
        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub actualizarAsiste()

        limpiarCampos()

        Try
            asis = New Asiste
            'listaInvestigadores =
            Me.asis.leerAsisteTodos()

            For Each Me.asis In Me.asis.gestorasiste.listaAs
               ' ListBoxListConf.Items.Add(Me.asis.Conferencia)
            Next
        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    Private Sub limpiarCampos()

        TextBoxConferenInve.Clear()
        TextBoxAsisInvesti.Clear()
        TextBoxConInvesti.Clear()

    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click

        Me.Dispose()

    End Sub

    Private Sub SeleccionConferencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarConferencias()
        'actualizarAsiste()
        actualizarInvestigadores()

    End Sub

End Class