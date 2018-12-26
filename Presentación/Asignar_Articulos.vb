Imports System.Data.OleDb

Public Class Asignar_Articulos

    Dim art As Articulos
    Dim autor As Autores
    Dim invest As Investigadores
    Dim ListaArticulos As New Collection
    Dim listaInvestigadores As New Collection
    Dim errorr1 As Boolean

    Private Sub ListBoxArtInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxArtInv.SelectedIndexChanged

        ListBoxAutInv.Items.Clear()

        Dim i As Integer
        Dim seleccionaArtic As String = ListBoxArtInv.SelectedItem.ToString
        art = New Articulos
        autor = New Autores
        invest = New Investigadores

        art.leerTodosArticulos()
        autor.leerAutoresTodos()
        i = 1
        While i <= art.gestarticulo.listaArt.Count
            If art.gestarticulo.listaArt(i).Titulo = seleccionaArtic Then
                art = art.gestarticulo.listaArt(i)
            End If
            i = i + 1
        End While

        TextBoxListArt.Text = art.IdArticulo

        autor.leerAutores(art.IdArticulo)

        For Each Me.autor In autor.gestorAutor.listaAut
            invest.leerIdInvestigador(autor.Invest)
            If (Me.autor.Articulo.Equals(art.IdArticulo)) Then

                ListBoxAutInv.Items.Add(invest.Nombre & " " & invest.Apellidos)

            End If
        Next

        TextBoxOrdenArt.Clear()

    End Sub

    Private Sub ListBoxAutInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAutInv.SelectedIndexChanged

        Dim en As Integer
        Dim j As Integer
        autor = New Autores
        invest = New Investigadores

        invest.leerTodosInvestigador()
        en = 1
        While en <= invest.gestorInvestigador.listaInv.Count
            If (invest.gestorInvestigador.listaInv(en).Nombre & " " &
                invest.gestorInvestigador.listaInv(en).Apellidos).Equals(ListBoxAutInv.SelectedItem) Then
                invest = invest.gestorInvestigador.listaInv(en)
            End If
            en = en + 1
        End While

        TextBoxListAut.Text = invest.Nombre & " " & invest.Apellidos

        j = 1
        While j <= art.gestarticulo.listaArt.Count
            If art.gestarticulo.listaArt(j).Titulo.Equals(ListBoxArtInv.SelectedItem) Then
                art = art.gestarticulo.listaArt(j)
            End If
            j = j + 1
        End While

        For Each Me.autor In autor.gestorAutor.listaAut

            TextBoxOrdenArt.Text = autor.leerAutoresOrden(invest.idInvest, art.IdArticulo)

        Next

    End Sub

    Private Sub ListBoxInvInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvInv.SelectedIndexChanged

        Dim selIdInvestigador As String = ListBoxInvInv.SelectedItem
        Dim ine As Integer
        invest = New Investigadores

        ' listaInvestigadores =
        invest.leerTodosInvestigador()
        ine = 1
        While ine <= invest.gestorInvestigador.listaInv.Count
            If (invest.gestorInvestigador.listaInv(ine).Nombre & " " &
                invest.gestorInvestigador.listaInv(ine).Apellidos).Equals(selIdInvestigador) Then
                invest = invest.gestorInvestigador.listaInv(ine)
            End If
            ine = ine + 1
        End While

        TextBoxListInv.Text = invest.idInvest

    End Sub

    Private Sub ButtonAñArt_Click(sender As Object, e As EventArgs) Handles ButtonAñArt.Click

        'Dim errorr1 As Boolean
        invest = New Investigadores
        art = New Articulos
        autor = New Autores
        Dim autor1 As New Autores
        ' autor.leerAutoresTodos()

        If (TextBoxListArt.Text.Equals("") Or TextBoxListInv.Text.Equals("") Or TextBoxOrdenArt.Text.Equals("")) Then
            MessageBox.Show("No se puede añadir un investigador al artículo si no se rellenan todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            'try
            autor = New Autores(TextBoxListInv.Text, TextBoxListArt.Text, TextBoxOrdenArt.Text)

            If Me.autor.insertarAutores() = 1 Then

                actualizarArticulos()
                ' actualizarAutores()
                limpiarCampos()
                ListBoxAutInv.Items.Clear()
                MessageBox.Show("El investigador se ha añadido correctamente al artículo", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else
                MessageBox.Show("Error al añadir el investigador al artículo.", "Error",
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

    Private Sub ButtonMoArt_Click(sender As Object, e As EventArgs) Handles ButtonMoArt.Click

    End Sub

    Private Sub ButtonElArt_Click(sender As Object, e As EventArgs) Handles ButtonElArt.Click

        Try
            If (TextBoxListInv.Text.Equals("") Or TextBoxListArt.Text.Equals("")) Then
                MessageBox.Show("No se puede eliminar un investigador de un artículo si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                'errorr1 = False
                'For Each Me.autor In autor.gestorAutor.listaAut
                '    If (Me.autor.Articulo.Equals(TextBoxListArt.Text) And
                '        Me.autor.Invest.Equals(TextBoxListInv.Text)) Then
                '        errorr1 = False
                '    End If
                'Next


                autor = New Autores(TextBoxListInv.Text, TextBoxListArt.Text)

                If MessageBox.Show("¿ Quiere eliminar este investigador del artículo?", "Eliminar investigador de un artículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then
                    'For Each Me.autor In autor.gestorAutor.listaAut
                    '    If (Me.autor.Articulo.Equals(TextBoxListArt.Text) And
                    '        Me.autor.Invest.Equals(TextBoxListInv.Text)) Then
                    '        errorr1 = False
                    '    End If
                    'Next

                    If Me.autor.eliminarAutores() = 1 Then
                        'If errorr1 = False Then
                        actualizarArticulos()
                        actualizarAutores()
                        limpiarCampos()
                        ListBoxAutInv.Items.Clear()
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
            MessageBox.Show("Error al eliminar el investigador del artículo.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCampos()
        End Try


    End Sub

    Private Sub actualizarArticulos()

        limpiarCampos()
        ListBoxArtInv.Items.Clear()

        Try
            art = New Articulos
            ' ListaArticulos =
            Me.art.leerTodosArticulos()

            For Each Me.art In Me.art.gestarticulo.listaArt
                ListBoxArtInv.Items.Add(Me.art.Titulo)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub actualizarInvestigadores()

        limpiarCampos()
        ListBoxInvInv.Items.Clear()

        Try
            invest = New Investigadores
            'listaInvestigadores =
            Me.invest.leerTodosInvestigador()

            For Each Me.invest In Me.invest.gestorInvestigador.listaInv
                ListBoxInvInv.Items.Add(Me.invest.Nombre & " " & Me.invest.Apellidos)
            Next
        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub actualizarAutores()

        limpiarCampos()
        ListBoxAutInv.Items.Clear()
        Try
            autor = New Autores
            Me.autor.leerAutoresTodos()

            For Each Me.autor In Me.autor.gestorAutor.listaAut
                ListBoxAutInv.Items.Add(Me.autor.Invest)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub limpiarCampos()

        TextBoxListArt.Clear()
        TextBoxListAut.Clear()
        TextBoxOrdenArt.Clear()
        TextBoxListInv.Clear()

    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click

        Me.Dispose()

    End Sub

    Private Sub Asignar_Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarArticulos()
        actualizarInvestigadores()

    End Sub

End Class