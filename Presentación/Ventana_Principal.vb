Imports System.Data.OleDb

Public Class Ventana_Principal

    Private Sub ButtonRutaBD_Click(sender As Object, e As EventArgs) Handles ButtonRutaBD.Click

        Dim Ruta As New OpenFileDialog()

        Ruta.Filter = "Archivo de Base de Datos (*.accdb)|*.accdb|Todos los archivos(*.*)|*.*"
        If (Ruta.ShowDialog() = DialogResult.OK) Then
            Try
                ListBoxRuta.Items.Add(IO.Path.GetFullPath(Ruta.FileName))
                AgenteBD.RutaBD = Ruta.FileName

            Catch Ex As Exception
                MessageBox.Show(Ex.Message, Ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            ButtonRutaBD.Enabled = False
            ButtonConectarBD.Enabled = True

        End If

    End Sub

    Private Sub ButtonConectarBD_Click(sender As Object, e As EventArgs) Handles ButtonConectarBD.Click

        LabelBD.ForeColor = Color.Green
        LabelBD.Text = "Se ha conectado correctamente con la base de datos."
        ButtonConectarBD.Enabled = False

        If (ButtonConectarBD.Enabled = False) Then

            ButtonGestion.Enabled = True
            ButtonMostrarAutoresArt.Enabled = True
            ButtonMostrarConf.Enabled = True

        Else
            ButtonGestion.Enabled = False
            ButtonMostrarAutoresArt.Enabled = False
            ButtonMostrarConf.Enabled = False

        End If
       
    End Sub

    Private Sub ButtonGestion_Click(sender As Object, e As EventArgs) Handles ButtonGestion.Click

        Dim vent_gest As New Ventana_gestion
        Try
            vent_gest.Show()
        Catch Ex As InvalidCastException
            MessageBox.Show("Ningún campo de ninguna tabla debe tener valores nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As IndexOutOfRangeException
            MessageBox.Show("Error, no coinciden los campos. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As OleDbException
            MessageBox.Show("Error, base de datos incorrecta. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try
    End Sub

    Private Sub ButtonMostrarAutoresArt_Click(sender As Object, e As EventArgs) Handles ButtonMostrarAutoresArt.Click

        Dim most_autores As New Autor_Articulo
        Try
            most_autores.Show()
        Catch Ex As InvalidCastException
            MessageBox.Show("Ningún campo de ninguna tabla debe tener valores nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As IndexOutOfRangeException
            MessageBox.Show("Error, no coinciden los campos. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As OleDbException
            MessageBox.Show("Error, base de datos incorrecta. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try

    End Sub

    Private Sub ButtonMostrarConf_Click(sender As Object, e As EventArgs) Handles ButtonMostrarConf.Click

        Dim list_conf As New Lista_Conferencias
        Try
            list_conf.Show()
        Catch Ex As InvalidCastException
            MessageBox.Show("Ningún campo de ninguna tabla debe tener valores nulos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As IndexOutOfRangeException
            MessageBox.Show("Error, no coinciden los campos. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        Catch Ex As OleDbException
            MessageBox.Show("Error, base de datos incorrecta. Se reiniciará la aplicación para poder introducir la base de datos correcta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Restart()
        End Try

    End Sub
End Class
