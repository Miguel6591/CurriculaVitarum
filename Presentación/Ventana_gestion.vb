Imports System.Data.OleDb

Public Class Ventana_gestion

    Dim invest As Investigadores
    Dim art As Articulos
    Dim conf As Conferencias
    Dim autor As Autores

    Private errorr1 As Boolean

    Private Sub Ventana_gestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarInvestigadores()
        actualizarArticulos()
        actualizarConferencias()

    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click

        Me.Dispose()
        Ventana_Principal.Show()

    End Sub
    'Private Sub ponerNumero(e As System.Windows.Forms.KeyPressEventArgs)

    '    If Char.IsDigit(e.KeyChar) Then
    '        e.Handled = False
    '    ElseIf Char.IsControl(e.KeyChar) Then
    '        e.Handled = False
    '    Else
    '        e.Handled = True
    '    End If

    'End Sub


    'Private Sub TextBoxIdInv_TextKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxIdInv.KeyPress
    '    ponerNumero(e)
    'End Sub

    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  Pestaña investigadores %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    Private Sub ListBoxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvestigadores.SelectedIndexChanged

        Dim selectIdInvestigador As String = ListBoxInvestigadores.SelectedItem
        Dim i As Integer
        invest = New Investigadores()
        autor = New Autores()
        art = New Articulos()
        invest.leerTodosInvestigador()

        If ListBoxInvestigadores.SelectedItem > 0 Then
            i = 1
            While i <= invest.gestorInvestigador.listaInv.Count
                If invest.gestorInvestigador.listaInv(i).idInvest = selectIdInvestigador Then
                    invest = invest.gestorInvestigador.listaInv(i)
                End If
                i = i + 1
            End While

            TextBoxIdInv.Text = invest.idInvest
            TextBoxNombreInv.Text = invest.Nombre
            TextBoxApellidosInv.Text = invest.Apellidos
            TextBoxDespachoInv.Text = invest.Despacho
            TextBoxEdificioInv.Text = invest.Edificio
            TextBoxDeptInv.Text = invest.Departamento
            TextBoxTelfInv.Text = invest.Telefono
            TextBoxEmailInv.Text = invest.Email

            Dim listaArticulos2 As New Collection
            autor.leerAutores(TextBoxIdInv.Text)
            listaArticulos2 = art.leerIdArticulo(autor.Articulo)

            For Each Me.art In listaArticulos2
                TextBoxArtRelacionados.Text = Me.art.Titulo
            Next

        End If

    End Sub

    Private Sub ButtonAñadirInv_Click(sender As Object, e As EventArgs) Handles ButtonAñadirInv.Click

        Try

            If (TextBoxIdInv.Text.Equals("") Or TextBoxNombreInv.Text.Equals("") Or TextBoxApellidosInv.Text.Equals("") Or
                TextBoxDespachoInv.Text.Equals("") Or TextBoxEdificioInv.Text.Equals("") Or TextBoxDeptInv.Text.Equals("") Or
                TextBoxTelfInv.Text.Equals("") Or TextBoxEmailInv.Text.Equals("")) Then
                MessageBox.Show("No se puede añadir un investigador si no se rellenan todos los campos", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else
                errorr1 = False
                For Each investi In invest.gestorInvestigador.listaInv
                    If (investi.idInvest.Equals(TextBoxIdInv)) Then
                        errorr1 = True
                    End If
                Next

                If errorr1 = False Then

                    invest = New Investigadores(TextBoxIdInv.Text, TextBoxNombreInv.Text, TextBoxApellidosInv.Text, TextBoxDespachoInv.Text,
                                             TextBoxEdificioInv.Text, TextBoxDeptInv.Text, TextBoxTelfInv.Text, TextBoxEmailInv.Text)
                    invest.insertarInvestigador()
                    actualizarInvestigadores()
                    limpiarCamposInvestigadores()
                    MessageBox.Show("El investigador se ha añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Un investigador ya existe con el mismo IdIvestigador,no puedes añadirlo.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpiarCamposInvestigadores()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Introduzca valores enteros o decimales en los campos." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
            limpiarCamposInvestigadores()
        End Try

    End Sub

    Private Sub ButtonModficarInv_Click(sender As Object, e As EventArgs) Handles ButtonModficarInv.Click

        Try
            If (TextBoxIdInv.Text.Equals("") Or TextBoxNombreInv.Text.Equals("") Or TextBoxApellidosInv.Text.Equals("") Or
                    TextBoxDespachoInv.Text.Equals("") Or TextBoxEdificioInv.Text.Equals("") Or TextBoxDeptInv.Text.Equals("") Or
                    TextBoxTelfInv.Text.Equals("") Or TextBoxEmailInv.Text.Equals("")) Then
                MessageBox.Show("No se puede modificar un investigador si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                Me.invest = New Investigadores(TextBoxIdInv.Text, TextBoxNombreInv.Text, TextBoxApellidosInv.Text, TextBoxDespachoInv.Text,
                                                  TextBoxEdificioInv.Text, TextBoxDeptInv.Text, TextBoxTelfInv.Text, TextBoxEmailInv.Text)
                If Me.invest.modificarInvestigador() = 1 Then

                    MessageBox.Show("El investigador se ha modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    actualizarInvestigadores()
                    limpiarCamposInvestigadores()

                Else
                    MessageBox.Show("Error al modificar el investigador.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCamposInvestigadores()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Introduzca valores enteros o decimales en los campos." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
        End Try

    End Sub

    Private Sub ButtonEliminarInv_Click(sender As Object, e As EventArgs) Handles ButtonEliminarInv.Click

        Try
            If (TextBoxIdInv.Text.Equals("")) Then
                MessageBox.Show("No se puede eliminar un investigador si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.invest = New Investigadores(TextBoxIdInv.Text, TextBoxNombreInv.Text, TextBoxApellidosInv.Text, TextBoxDespachoInv.Text,
                                                  TextBoxEdificioInv.Text, TextBoxDeptInv.Text, TextBoxTelfInv.Text, TextBoxEmailInv.Text)
                If MessageBox.Show("¿ Quiere eliminar este investigador ?", "Eliminar investigador", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

                    If Me.invest.eliminarInvestigador() = 1 Then

                        MessageBox.Show("El investigador se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        actualizarInvestigadores()
                        limpiarCamposInvestigadores()

                    End If
                Else
                    limpiarCamposInvestigadores()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el investigador.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCamposInvestigadores()
        End Try

    End Sub

    Private Sub ButtonLimpiarInv_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarInv.Click

        limpiarCamposInvestigadores()

    End Sub

    Private Sub CheckBoxConferencia_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConferencia.CheckedChanged

        If (CheckBoxConferencia.Checked = True) Then
            ButtonListaConfer.Enabled = True
        Else
            ButtonListaConfer.Enabled = False
        End If

    End Sub

    Private Sub ButtonListaConfer_Click(sender As Object, e As EventArgs) Handles ButtonListaConfer.Click

        Dim selec_conf As New SeleccionConferencia
        selec_conf.Show()
        CheckBoxConferencia.Checked = False

    End Sub

    Private Sub ButtonGenerarCV_Click(sender As Object, e As EventArgs) Handles ButtonGenerarCV.Click

        Dim cv As New Curriculum_Vitae
        cv.Show()

    End Sub

    Private Sub limpiarCamposInvestigadores()

        TextBoxIdInv.Clear()
        TextBoxNombreInv.Clear()
        TextBoxApellidosInv.Clear()
        TextBoxDespachoInv.Clear()
        TextBoxEdificioInv.Clear()
        TextBoxDeptInv.Clear()
        TextBoxTelfInv.Clear()
        TextBoxEmailInv.Clear()
        TextBoxArtRelacionados.Clear()

    End Sub
    Private Sub ButtonArticulos_Click(sender As Object, e As EventArgs) Handles ButtonArticulos.Click

        Dim vent_asig As New Asignar_Articulos
        vent_asig.Show()

    End Sub


    Private Sub TextBoxTelfInv_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxTelfInv.KeyPress

        If (Char.IsDigit(e.KeyChar) And TextBoxTelfInv.SelectionStart < 9) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  Pestaña artículos %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%

    Private Sub ListBoxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxArticulos.SelectedIndexChanged

        Dim selectIdArticulo As Integer = ListBoxArticulos.SelectedItem
        Dim i As Integer
        art = New Articulos
        art.leerTodosArticulos()

        If ListBoxArticulos.SelectedItem > 0 Then
            i = 1
            While i <= art.gestarticulo.listaArt.Count
                If art.gestarticulo.listaArt(i).IdArticulo = selectIdArticulo Then
                    art = art.gestarticulo.listaArt(i)
                End If
                i = i + 1
            End While

            TextBoxIdArt.Text = art.IdArticulo
            TextBoxTituloArt.Text = art.Titulo
            TextBoxConferenciaArt.Text = art.Conferencia
            TextBoxPagIniArt.Text = art.pag_inicio
            TextBoxPagFinArt.Text = art.pag_fin

        End If
    End Sub

    Private Sub ButtonAñadirArt_Click(sender As Object, e As EventArgs) Handles ButtonAñadirArt.Click

        Try

            If (TextBoxIdArt.Text.Equals("") Or TextBoxTituloArt.Text.Equals("") Or TextBoxConferenciaArt.Text.Equals("") Or
                TextBoxPagIniArt.Text.Equals("") Or TextBoxPagFinArt.Text.Equals("")) Then
                MessageBox.Show("No se puede añadir un artículo si no se rellenan todos los campos", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                errorr1 = False
                For Each arti As Articulos In art.gestarticulo.listaArt
                    If (arti.IdArticulo.Equals(TextBoxIdArt.Text)) Then
                        errorr1 = True
                    End If
                Next

                If Not errorr1 Then
                    art = New Articulos(TextBoxIdArt.Text, TextBoxTituloArt.Text, TextBoxConferenciaArt.Text,
                                                    TextBoxPagIniArt.Text, TextBoxPagFinArt.Text)
                    If Me.art.pag_inicio < Me.art.pag_fin Then

                        art.insertarArticulo()
                        actualizarArticulos()
                        limpiarCamposArticulos()
                        MessageBox.Show("El artículo se ha añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("La página de inicio del artículo debe ser menor que la página de finalización. Por favor introduzca una paginación correcta", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                        TextBoxPagIniArt.Clear()
                        TextBoxPagFinArt.Clear()
                    End If
                Else
                    MessageBox.Show("Un artículo ya existe con el mismo IdArtículo, no puedes añadirlo.", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    limpiarCamposArticulos()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Introduzca valores enteros o decimales en los campos." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
        End Try

    End Sub

    Private Sub ButtonModificarArt_Click(sender As Object, e As EventArgs) Handles ButtonModificarArt.Click

        Try
            If (TextBoxIdArt.Text.Equals("") Or TextBoxTituloArt.Text.Equals("") Or TextBoxConferenciaArt.Text.Equals("") Or
                TextBoxPagIniArt.Text.Equals("") Or TextBoxPagFinArt.Text.Equals("")) Then
                MessageBox.Show("No se puede modificar un artículo si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                art = New Articulos(TextBoxIdArt.Text, TextBoxTituloArt.Text, TextBoxConferenciaArt.Text,
                                                TextBoxPagIniArt.Text, TextBoxPagFinArt.Text)
                If Me.art.modificarArticulo() = 1 Then
                    If Me.art.pag_inicio < Me.art.pag_fin Then
                        MessageBox.Show("El artículo se ha modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        actualizarArticulos()
                        limpiarCamposArticulos()
                    Else
                        MessageBox.Show("La página de inicio del artículo debe ser menor que la página de finalización. Por favor introduzca una paginación correcta", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                        TextBoxPagIniArt.Clear()
                        TextBoxPagFinArt.Clear()
                    End If
                Else
                    MessageBox.Show("Error al modificar el artículo.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCamposArticulos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Introduzca valores enteros o decimales en los campos." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
        End Try

    End Sub

    Private Sub ButtonEliminarArt_Click(sender As Object, e As EventArgs) Handles ButtonEliminarArt.Click

        Try
            If (TextBoxIdArt.Text.Equals("")) Then
                MessageBox.Show("No se puede eliminar un artículo si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else

                Me.art = New Articulos(TextBoxIdArt.Text, TextBoxTituloArt.Text, TextBoxConferenciaArt.Text,
                                                 TextBoxPagIniArt.Text, TextBoxPagFinArt.Text)
                If MessageBox.Show("¿ Quiere eliminar este artículo?", "Eliminar artículo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

                    If Me.art.eliminarArticulo() = 1 Then

                        MessageBox.Show("El artículo se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        actualizarArticulos()
                        limpiarCamposArticulos()

                    End If
                Else
                    limpiarCamposArticulos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar el artículo.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCamposArticulos()
        End Try

    End Sub

    Private Sub ButtonLimpiarArt_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarArt.Click

        limpiarCamposArticulos()

    End Sub

    Private Sub limpiarCamposArticulos()

        TextBoxIdArt.Clear()
        TextBoxTituloArt.Clear()
        TextBoxConferenciaArt.Clear()
        TextBoxPagIniArt.Clear()
        TextBoxPagFinArt.Clear()

    End Sub

    Private Sub TextBoxPagIniArt_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPagIniArt.KeyPress


        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub TextBoxPagFinArt_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBoxPagFinArt.KeyPress

        If (Char.IsDigit(e.KeyChar)) Then
            e.Handled = False
        ElseIf (Char.IsControl(e.KeyChar)) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub


    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%  Pestaña conferencias %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    Private Sub ListBoxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConferencias.SelectedIndexChanged

        Dim selectIdConferencia As Integer = ListBoxConferencias.SelectedItem
        Dim i As Integer
        conf = New Conferencias
        conf.leerTodosConferencia()

        If ListBoxConferencias.SelectedItem > 0 Then
            i = 1
            While i <= conf.gestorconferencia.listaConf.Count
                If conf.gestorconferencia.listaConf(i).idConferencia = selectIdConferencia Then
                    conf = conf.gestorconferencia.listaConf(i)
                End If
                i = i + 1
            End While

            TextBoxIdConf.Text = conf.idConferencia
            TextBoxSiglasConf.Text = conf.Siglas
            TextBoxNombreConf.Text = conf.Nombre
            TextBoxLugarConf.Text = conf.Lugar
            DateTimePickerInicioConf.Text = conf.Fecha_inicio
            DateTimePickerFinConf.Text = conf.Fecha_fin

        End If

    End Sub

    Private Sub ButtonAñadirConf_Click(sender As Object, e As EventArgs) Handles ButtonAñadirConf.Click

        If (TextBoxIdConf.Text.Equals("") Or TextBoxSiglasConf.Text.Equals("") Or TextBoxNombreConf.Text.Equals("") Or
            TextBoxLugarConf.Text.Equals("") Or DateTimePickerInicioConf.Text.Equals("") Or DateTimePickerFinConf.Text.Equals("")) Then
            MessageBox.Show("No se puede añadir una conferencia si no se rellenan todos los campos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            errorr1 = False

            For Each confere As Conferencias In conf.gestorconferencia.listaConf
                If (confere.idConferencia.Equals(TextBoxIdConf.Text)) Then
                    errorr1 = True
                End If
            Next
            Try
                If errorr1 = False Then

                    conf = New Conferencias(TextBoxIdConf.Text, TextBoxSiglasConf.Text, TextBoxNombreConf.Text, TextBoxLugarConf.Text,
                                                DateTimePickerInicioConf.Text, DateTimePickerFinConf.Text)
                    If Me.conf.insertarConferencia() = 1 Then
                        If Me.conf.Fecha_fin >= Me.conf.Fecha_inicio Then

                            actualizarConferencias()
                            limpiarCamposConferencias()
                            MessageBox.Show("La conferencia se ha añadido correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("La fecha de inicio de la conferencia debe ser menor que la fecha de finalización. Por favor introduzca una fecha correcta", "Error",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error)

                            DateTimePickerFinConf.Value = DateTime.Now
                        End If
                    Else
                        MessageBox.Show("Error al añadir la conferencia.", "Error",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error)
                        limpiarCamposConferencias()
                    End If
                Else
                    'Throw New Exception
                End If
            Catch ex As Exception
                MessageBox.Show("Introduzca valores enteros o decimales en el campo." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
                    limpiarCamposConferencias()
            End Try

        End If

    End Sub

    Private Sub ButtonModificarConf_Click(sender As Object, e As EventArgs) Handles ButtonModificarConf.Click

        Try
            If (TextBoxIdConf.Text.Equals("") Or TextBoxSiglasConf.Text.Equals("") Or TextBoxNombreConf.Text.Equals("") Or
                TextBoxLugarConf.Text.Equals("") Or DateTimePickerInicioConf.Text.Equals("") Or DateTimePickerFinConf.Text.Equals("")) Then
                MessageBox.Show("No se puede añadir una conferencia si no se rellenan todos los campos", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)

            Else

                conf = New Conferencias(TextBoxIdConf.Text, TextBoxSiglasConf.Text, TextBoxNombreConf.Text, TextBoxLugarConf.Text,
                                             DateTimePickerInicioConf.Text, DateTimePickerFinConf.Text)
                If Me.conf.modificarConferencia() = 1 Then
                    If Me.conf.Fecha_fin >= Me.conf.Fecha_inicio Then

                        MessageBox.Show("La conferencia se ha modificado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        actualizarConferencias()
                        limpiarCamposConferencias()
                    Else
                        MessageBox.Show("La fecha de inicio de la conferencia debe ser menor que la fecha de finalización. Por favor introduzca una fecha correcta", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)

                        DateTimePickerFinConf.Value = DateTime.Now

                    End If
                Else
                    MessageBox.Show("Error al modificar la conferencia.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiarCamposConferencias()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Introduzca valores enteros o decimales en los campos." + vbCr & ControlChars.CrLf & ex.Message & ControlChars.CrLf & ex.Source())
        End Try

    End Sub

    Private Sub ButtonEliminarConf_Click(sender As Object, e As EventArgs) Handles ButtonEliminarConf.Click

        Try
            If (TextBoxIdConf.Text.Equals("")) Then
                MessageBox.Show("No se puede eliminar una conferencia si algún campo esta vacío", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                Me.conf = New Conferencias(TextBoxIdConf.Text, TextBoxSiglasConf.Text, TextBoxNombreConf.Text, TextBoxLugarConf.Text,
                                            DateTimePickerInicioConf.Text, DateTimePickerFinConf.Text)

                If MessageBox.Show("¿ Quiere eliminar esta conferencia?", "Eliminar conferencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.OK Then

                    If Me.conf.eliminarConferencia() = 1 Then

                        actualizarConferencias()
                        limpiarCamposConferencias()
                        MessageBox.Show("La conferencia se ha eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    End If

                Else
                    limpiarCamposConferencias()
                End If

            End If
        Catch ex As Exception
            MessageBox.Show("Error al eliminar la conferencia.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
            limpiarCamposConferencias()
        End Try


    End Sub

    Private Sub ButtonLimpiarConf_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarConf.Click

        limpiarCamposConferencias()

    End Sub

    Private Sub limpiarCamposConferencias()

        TextBoxIdConf.Clear()
        TextBoxSiglasConf.Clear()
        TextBoxNombreConf.Clear()
        TextBoxLugarConf.Clear()
        DateTimePickerInicioConf.Value = DateTime.Now
        DateTimePickerFinConf.Value = DateTime.Now
    End Sub


    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Pestaña de articulos del investigador %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    Private Sub ListBoxArtInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxArtInv.SelectedIndexChanged

        'ListBoxAutInv.Items.Clear()

        ''Dim seleccionaAutor As String = ListBoxArtInv.SelectedItem
        'Dim i As Integer
        'art = New Articulos
        'autor = New Autores
        'invest = New Investigadores

        'i = 1
        'While i <= listaArticulos.Count
        '    If listaArticulos(i).Titulo = ListBoxArtInv.SelectedItem Then
        '        art = listaArticulos(i)
        '    End If
        '    i = i + 1
        'End While
        'Dim sel As String = ListBoxArtInv.SelectedItem

        'TextBoxListArt.Text = art.Titulo
        'autor.leerAutores(sel)
        'listaInvestigadores = invest.leerIdInvestigador(autor.Invest)

        'For Each investi As Investigadores In listaInvestigadores
        '    ListBoxAutInv.Items.Add(investi.Nombre & " " & investi.Apellidos)
        'Next

        'TextBoxOrdenArt.Clear()
        
    End Sub

    Private Sub ListBoxAutInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAutInv.SelectedIndexChanged

    End Sub

    Private Sub ListBoxInvInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvInv.SelectedIndexChanged

        'Dim selIdInvestigador As String = ListBoxInvInv.SelectedItem
        'Dim ine As Integer
        'invest = New Investigadores

        'ine = 1
        'While ine <= listaInvestigadores.Count
        '    If (listaInvestigadores(ine).Nombre = selIdInvestigador) Then
        '        invest = listaInvestigadores(ine)
        '    End If
        '    ine = ine + 1
        'End While

        'TextBoxListInv.Text = Me.invest.Nombre & " " & Me.invest.Apellidos

    End Sub

    Private Sub ButtonAñArt_Click(sender As Object, e As EventArgs) Handles ButtonAñArt.Click

    End Sub

    Private Sub ButtonMoArt_Click(sender As Object, e As EventArgs) Handles ButtonMoArt.Click

    End Sub

    Private Sub ButtonElArt_Click(sender As Object, e As EventArgs) Handles ButtonElArt.Click

    End Sub


    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Pestaña de conferencias del investigador %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    Private Sub ListBoxListConf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxListConf.SelectedIndexChanged

    End Sub

    Private Sub ListBoxAsisConf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAsisConf.SelectedIndexChanged

    End Sub

    Private Sub ListBoxConfInv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxConfInv.SelectedIndexChanged

    End Sub

    Private Sub CheckBoxOyente_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxOyente.CheckedChanged

    End Sub

    Private Sub CheckBoxConferenciante_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxConferenciante.CheckedChanged

    End Sub

    Private Sub ButtonAsistirConfInv_Click(sender As Object, e As EventArgs) Handles ButtonAsistirConfInv.Click

    End Sub

    Private Sub ButtonModifConfInv_Click(sender As Object, e As EventArgs) Handles ButtonModifConfInv.Click

    End Sub

    Private Sub ButtonElAsInv_Click(sender As Object, e As EventArgs) Handles ButtonElAsInv.Click

    End Sub


    ''%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%% Métodos de actualizar %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%


    Private Sub actualizarInvestigadores()

        limpiarCamposInvestigadores()
        ListBoxInvestigadores.Items.Clear()
        ' ListBoxInvInv.Items.Clear()
        Try
            invest = New Investigadores

            Me.invest.leerTodosInvestigador()

            For Each Me.invest In invest.gestorInvestigador.listaInv
                ListBoxInvestigadores.Items.Add(Me.invest.idInvest)
                '  ListBoxInvInv.Items.Add(Me.invest.Nombre)
            Next
            
        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub actualizarConferencias()

        limpiarCamposConferencias()
        ListBoxConferencias.Items.Clear()

        Try
            conf = New Conferencias
            'listaConferencias = 
            Me.conf.leerTodosConferencia()

            For Each Me.conf In conf.gestorconferencia.listaConf
                ListBoxConferencias.Items.Add(Me.conf.idConferencia)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub actualizarArticulos()

        limpiarCamposArticulos()
        ListBoxArticulos.Items.Clear()
        ListBoxArtInv.Items.Clear()
        Try
            art = New Articulos

            Me.art.leerTodosArticulos()

            For Each Me.art In art.gestarticulo.listaArt
                ListBoxArticulos.Items.Add(Me.art.IdArticulo)
                '  ListBoxArtInv.Items.Add(Me.art.Titulo)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

End Class