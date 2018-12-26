Imports System.Data.OleDb

Public Class Autor_Articulo

    Dim art As Articulos
    Dim autor As Autores
    Dim invest As Investigadores


    Private Sub Autor_Articulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        actualizarArticulos()

    End Sub

    Private Sub ListBoxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxArticulos.SelectedIndexChanged

        ListBoxInvestigadores.Items.Clear()

        Dim i As Integer
        Dim seleccionaArtic As String = ListBoxArticulos.SelectedItem.ToString
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

        autor.leerAutores(art.IdArticulo)

        For Each Me.autor In autor.gestorAutor.listaAut
            invest.leerIdInvestigador(autor.Invest)
            If (Me.autor.Articulo.Equals(art.IdArticulo)) Then

                ListBoxInvestigadores.Items.Add(invest.Nombre & " " & invest.Apellidos)

            End If
        Next

        TextBoxOrden.Clear()

    End Sub

    Private Sub ListBoxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInvestigadores.SelectedIndexChanged

        Dim i As Integer
        Dim j As Integer

        art = New Articulos
        autor = New Autores
        invest = New Investigadores
        i = 1
        art.leerTodosArticulos()
        invest.leerTodosInvestigador()
        autor.leerAutoresTodos()
        While i <= invest.gestorInvestigador.listaInv.Count
            If (invest.gestorInvestigador.listaInv(i).Nombre & " " &
                invest.gestorInvestigador.listaInv(i).Apellidos).Equals(ListBoxInvestigadores.SelectedItem) Then
                invest = invest.gestorInvestigador.listaInv(i)

            End If
            i = i + 1

        End While

        j = 1
        While j <= art.gestarticulo.listaArt.Count
            If art.gestarticulo.listaArt(j).Titulo.Equals(ListBoxArticulos.SelectedItem) Then
                art = art.gestarticulo.listaArt(j)
            End If
            j = j + 1
        End While

        For Each Me.autor In autor.gestorAutor.listaAut

            TextBoxOrden.Text = autor.leerAutoresOrden(invest.idInvest, art.IdArticulo)

        Next


    End Sub

    Private Sub actualizarArticulos()

        ListBoxArticulos.Items.Clear()

        Try
            art = New Articulos
            art.leerTodosArticulos()

            For Each Me.art In art.gestarticulo.listaArt
                ListBoxArticulos.Items.Add(art.Titulo)
            Next

        Catch Ex As NullReferenceException
            MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub ButtonAtraAutor_Click(sender As Object, e As EventArgs) Handles ButtonAtraAutor.Click

        Me.Dispose()
        Ventana_Principal.Show()

    End Sub

End Class