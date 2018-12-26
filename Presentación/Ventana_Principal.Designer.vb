<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Principal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ButtonRutaBD = New System.Windows.Forms.Button()
        Me.ButtonConectarBD = New System.Windows.Forms.Button()
        Me.ListBoxRuta = New System.Windows.Forms.ListBox()
        Me.LabelBD = New System.Windows.Forms.Label()
        Me.GroupBoxConexion = New System.Windows.Forms.GroupBox()
        Me.GroupBoxGestion = New System.Windows.Forms.GroupBox()
        Me.ButtonGestion = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButtonMostrarConf = New System.Windows.Forms.Button()
        Me.ButtonMostrarAutoresArt = New System.Windows.Forms.Button()
        Me.GroupBoxConexion.SuspendLayout()
        Me.GroupBoxGestion.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonRutaBD
        '
        Me.ButtonRutaBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRutaBD.ForeColor = System.Drawing.Color.Black
        Me.ButtonRutaBD.Location = New System.Drawing.Point(16, 28)
        Me.ButtonRutaBD.Name = "ButtonRutaBD"
        Me.ButtonRutaBD.Size = New System.Drawing.Size(91, 33)
        Me.ButtonRutaBD.TabIndex = 0
        Me.ButtonRutaBD.Text = "Ruta BD"
        Me.ButtonRutaBD.UseVisualStyleBackColor = True
        '
        'ButtonConectarBD
        '
        Me.ButtonConectarBD.Enabled = False
        Me.ButtonConectarBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConectarBD.ForeColor = System.Drawing.Color.Black
        Me.ButtonConectarBD.Location = New System.Drawing.Point(16, 77)
        Me.ButtonConectarBD.Name = "ButtonConectarBD"
        Me.ButtonConectarBD.Size = New System.Drawing.Size(93, 33)
        Me.ButtonConectarBD.TabIndex = 2
        Me.ButtonConectarBD.Text = "Conectar BD"
        Me.ButtonConectarBD.UseVisualStyleBackColor = True
        '
        'ListBoxRuta
        '
        Me.ListBoxRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxRuta.FormattingEnabled = True
        Me.ListBoxRuta.Location = New System.Drawing.Point(135, 31)
        Me.ListBoxRuta.Name = "ListBoxRuta"
        Me.ListBoxRuta.Size = New System.Drawing.Size(427, 30)
        Me.ListBoxRuta.TabIndex = 3
        '
        'LabelBD
        '
        Me.LabelBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelBD.ForeColor = System.Drawing.Color.Black
        Me.LabelBD.Location = New System.Drawing.Point(132, 85)
        Me.LabelBD.Name = "LabelBD"
        Me.LabelBD.Size = New System.Drawing.Size(366, 33)
        Me.LabelBD.TabIndex = 4
        '
        'GroupBoxConexion
        '
        Me.GroupBoxConexion.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBoxConexion.Controls.Add(Me.LabelBD)
        Me.GroupBoxConexion.Controls.Add(Me.ButtonRutaBD)
        Me.GroupBoxConexion.Controls.Add(Me.ListBoxRuta)
        Me.GroupBoxConexion.Controls.Add(Me.ButtonConectarBD)
        Me.GroupBoxConexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConexion.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxConexion.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxConexion.Name = "GroupBoxConexion"
        Me.GroupBoxConexion.Size = New System.Drawing.Size(606, 129)
        Me.GroupBoxConexion.TabIndex = 5
        Me.GroupBoxConexion.TabStop = False
        Me.GroupBoxConexion.Text = "Conexión a la base de datos"
        '
        'GroupBoxGestion
        '
        Me.GroupBoxGestion.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBoxGestion.Controls.Add(Me.ButtonGestion)
        Me.GroupBoxGestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxGestion.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxGestion.Location = New System.Drawing.Point(12, 162)
        Me.GroupBoxGestion.Name = "GroupBoxGestion"
        Me.GroupBoxGestion.Size = New System.Drawing.Size(606, 113)
        Me.GroupBoxGestion.TabIndex = 6
        Me.GroupBoxGestion.TabStop = False
        Me.GroupBoxGestion.Text = "Gestión de base de datos"
        '
        'ButtonGestion
        '
        Me.ButtonGestion.Enabled = False
        Me.ButtonGestion.ForeColor = System.Drawing.Color.Black
        Me.ButtonGestion.Location = New System.Drawing.Point(200, 35)
        Me.ButtonGestion.Name = "ButtonGestion"
        Me.ButtonGestion.Size = New System.Drawing.Size(211, 56)
        Me.ButtonGestion.TabIndex = 0
        Me.ButtonGestion.Text = "Gestión de registros de la base de datos"
        Me.ButtonGestion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.ButtonMostrarConf)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrarAutoresArt)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 290)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 165)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consultas"
        '
        'ButtonMostrarConf
        '
        Me.ButtonMostrarConf.Enabled = False
        Me.ButtonMostrarConf.ForeColor = System.Drawing.Color.Black
        Me.ButtonMostrarConf.Location = New System.Drawing.Point(352, 47)
        Me.ButtonMostrarConf.Name = "ButtonMostrarConf"
        Me.ButtonMostrarConf.Size = New System.Drawing.Size(186, 89)
        Me.ButtonMostrarConf.TabIndex = 1
        Me.ButtonMostrarConf.Text = "Mostrar lista de conferencias"
        Me.ButtonMostrarConf.UseVisualStyleBackColor = True
        '
        'ButtonMostrarAutoresArt
        '
        Me.ButtonMostrarAutoresArt.Enabled = False
        Me.ButtonMostrarAutoresArt.ForeColor = System.Drawing.Color.Black
        Me.ButtonMostrarAutoresArt.Location = New System.Drawing.Point(82, 47)
        Me.ButtonMostrarAutoresArt.Name = "ButtonMostrarAutoresArt"
        Me.ButtonMostrarAutoresArt.Size = New System.Drawing.Size(186, 89)
        Me.ButtonMostrarAutoresArt.TabIndex = 0
        Me.ButtonMostrarAutoresArt.Text = "Mostrar autores de los artículos"
        Me.ButtonMostrarAutoresArt.UseVisualStyleBackColor = True
        '
        'Ventana_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(630, 467)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBoxGestion)
        Me.Controls.Add(Me.GroupBoxConexion)
        Me.Name = "Ventana_Principal"
        Me.Text = "Generador de Curriculum Vitae"
        Me.GroupBoxConexion.ResumeLayout(False)
        Me.GroupBoxGestion.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ButtonRutaBD As System.Windows.Forms.Button
    Friend WithEvents ButtonConectarBD As System.Windows.Forms.Button
    Friend WithEvents ListBoxRuta As System.Windows.Forms.ListBox
    Friend WithEvents LabelBD As System.Windows.Forms.Label
    Friend WithEvents GroupBoxConexion As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxGestion As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonGestion As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonMostrarConf As System.Windows.Forms.Button
    Friend WithEvents ButtonMostrarAutoresArt As System.Windows.Forms.Button

End Class
