Imports System.Data.OleDb

Public Class Curriculum_Vitae

    Dim invest As Investigadores
    Dim asis As Asiste
    Dim conf As Conferencias
    Dim aut As Autores

    Private Sub ButtonGenera_Click(sender As Object, e As EventArgs) Handles ButtonGenera.Click

        realizarCV()

    End Sub

    Public Sub realizarCV()

        Dim selectinvest As String = ""
        Dim i As Integer
        selectinvest = ComboBoxInvest.SelectedItem
        invest = New Investigadores
        asis = New Asiste
        conf = New Conferencias
        aut = New Autores

        invest.leerTodosInvestigador()
        asis.leerAsisteTodos()
        conf.leerTodosConferencia()

        If selectinvest = "" Then
            MessageBox.Show("Error no se ha seleccionado ningún investigador. Por favor introduzca un ivestigador.", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            i = 1
            While i <= invest.gestorInvestigador.listaInv.Count
                If (invest.gestorInvestigador.listaInv(i).Nombre & " " &
                    invest.gestorInvestigador.listaInv(i).Apellidos).Equals(selectinvest) Then
                    invest = invest.gestorInvestigador.listaInv(i)
                End If
                i = i + 1
            End While

            RichTextBoxInvest.ResetText()

            RichTextBoxInvest.Font = New Font("Times New Roman", 12, FontStyle.Regular)
            RichTextBoxInvest.Text = "CURRICULUM VITAE" & vbNewLine & vbNewLine
            RichTextBoxInvest.Text += "DATOS DEL INVESTIGADOR " & vbNewLine
            RichTextBoxInvest.Text += "Nombre: " & Me.invest.Nombre & vbNewLine
            RichTextBoxInvest.Text += "Apellidos: " & Me.invest.Apellidos & vbNewLine
            RichTextBoxInvest.Text += "Despacho: " & Me.invest.Despacho & vbNewLine
            RichTextBoxInvest.Text += "Edificio: " & Me.invest.Edificio & vbNewLine
            RichTextBoxInvest.Text += "Departamento: " & Me.invest.Departamento & vbNewLine
            RichTextBoxInvest.Text += "Teléfono: " & Me.invest.Telefono & vbNewLine
            RichTextBoxInvest.Text += "Email: " & Me.invest.Email & vbNewLine & vbNewLine
            RichTextBoxInvest.Text += "CONFERENCIAS A LAS QUE HA ASISTIDO EL INVESTIGADOR " & vbNewLine

            asis.leerAsiste(invest.idInvest)
            For Each Me.asis In asis.gestorasiste.listaAs
                conf.leerConferencia(asis.Conferencia)
                If (Me.asis.Invest.Equals(invest.idInvest)) Then

                    RichTextBoxInvest.Text += Me.conf.Nombre & vbNewLine

                End If
            Next

            RichTextBoxInvest.Text += vbNewLine & "ARTÍCULOS QUE HA PUBLICADO EL INVESTIGADOR " & vbNewLine

            'aut.leerAutores(invest.idInvest)
            'For Each Me.asis In asis.gestorasiste.listaAs
            '    conf.leerConferencia(asis.Conferencia)
            '    If (Me.asis.Invest.Equals(invest.idInvest)) Then

            '        RichTextBoxInvest.Text += Me.conf.Nombre & vbNewLine

            '    End If
            'Next

            RichTextBoxInvest.Text += vbNewLine & conf.Fecha_inicio.Year & vbNewLine

            'RichTextBoxInvest.Text += "NOMBRE" & vbTab & "LUGAR" & vbTab & "FECHA INICIO" & vbTab & "FECHA FIN" & vbNewLine
            'FALTA PONER FOR CON LAS CONFERENCIAS DEL INVESTIGADOR
            'RichTextBoxInvest.Text += Strings.Left(prod.DescripcionProducto, 12) & vbTab & prod.cantidad.ToString() & vbTab & prod.calcularPrecioProductos().ToString() & "€" & vbNewLine

            'Lista_de_autores. Título. Conferencia (Siglas). pp.
            'pag_inicio-pag_fin. Lugar de celebración. Año de celebración.
            'Ejemplo: G. Rosado, David, Cruz-Lemus, José A. y Genero,Marcela.
            'Proyecto CV-BD: Construcción de una aplicación para gestión de CV en la asignatura de Bases de Datos. XXV
            'Jornadas de Enseñanza Universitaria de la Informática (JENUI2017). pp. 177-185. Cáceres (España). 2017.


            '    TextoFichaPer.Text = TextoFichaPer.Text & vbCrLf & "PELICULAS EN LAS QUE PARTICIPA" & vbCrLf & vbCrLf
            '    lista_Peliculas = person.leerPeliculas(person._IdPersona)
            '    k = 0
            '    While k < lista_Peliculas.Count
            '        Pel = lista_Peliculas(k)
            '        TextoFichaPer.Text = TextoFichaPer.Text &
            '            "   PELICULA " & k + 1 & vbCrLf &
            '            "   IdPelicula: " & Pel._IdPelicula & vbCrLf &
            '            "   Titulo : " & Pel._Titulo & vbCrLf
            '        lista_Roles = Per.leerRol(selectperso, Pel._IdPelicula)
            '        j = 0
            '        If lista_Roles.Count = 1 Then
            '            TextoFichaPer.Text = TextoFichaPer.Text & "   Rol: "
            '        Else
            '            TextoFichaPer.Text = TextoFichaPer.Text & "   Roles: "
            '        End If
            '        While j < lista_Roles.Count
            '            If lista_Roles.Count > 1 Then
            '                Rol = lista_Roles(j)
            '                TextoFichaPer.Text += TextoFichaPer.Text & Rol._IdRol & "  "
            '            End If
            '            If lista_Roles.Count = 1 Then
            '                Rol = lista_Roles(j)
            '                TextoFichaPer.Text = TextoFichaPer.Text & Rol._IdRol & "  "
            '            End If
            '            j = j + 1
            '        End While
            '        k = k + 1
            '        TextoFichaPer.Text = TextoFichaPer.Text & "." & vbCrLf
            '    End While
            'End If
            'ListaDesple.Text = ""
        End If
    End Sub
    Private Sub actualizarInvestigadores()

        Try
            invest = New Investigadores
            Me.invest.leerTodosInvestigador()

            For Each Me.invest In Me.invest.gestorInvestigador.listaInv
                ComboBoxInvest.Items.Add(Me.invest.Nombre & " " & Me.invest.Apellidos)
            Next
        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ButtonAtras_Click(sender As Object, e As EventArgs) Handles ButtonAtras.Click

        Me.Dispose()

    End Sub

    Private Sub Curriculum_Vitae_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarInvestigadores()

    End Sub
End Class