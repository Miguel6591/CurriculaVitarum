<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Conferencias
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
        Me.GroupBoxDatosConferencia = New System.Windows.Forms.GroupBox()
        Me.LabelInvest = New System.Windows.Forms.Label()
        Me.LabelNombreConf = New System.Windows.Forms.Label()
        Me.LabelIdentificadorConf = New System.Windows.Forms.Label()
        Me.LabelSiglasConf = New System.Windows.Forms.Label()
        Me.LabelLugarConf = New System.Windows.Forms.Label()
        Me.LabelFecInicioConf = New System.Windows.Forms.Label()
        Me.DateTimePickerFinConf = New System.Windows.Forms.DateTimePicker()
        Me.LabelFecFinConf = New System.Windows.Forms.Label()
        Me.DateTimePickerInicioConf = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxIdConf = New System.Windows.Forms.TextBox()
        Me.TextBoxLugarConf = New System.Windows.Forms.TextBox()
        Me.TextBoxSiglasConf = New System.Windows.Forms.TextBox()
        Me.TextBoxNombreConf = New System.Windows.Forms.TextBox()
        Me.GroupBoxConferencias = New System.Windows.Forms.GroupBox()
        Me.ListBoxListaConferencias = New System.Windows.Forms.ListBox()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.TextBoxInvest = New System.Windows.Forms.TextBox()
        Me.GroupBoxDatosConferencia.SuspendLayout()
        Me.GroupBoxConferencias.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxDatosConferencia
        '
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelInvest)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.TextBoxInvest)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelNombreConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelIdentificadorConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelSiglasConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelLugarConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelFecInicioConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.DateTimePickerFinConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.LabelFecFinConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.DateTimePickerInicioConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.TextBoxIdConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.TextBoxLugarConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.TextBoxSiglasConf)
        Me.GroupBoxDatosConferencia.Controls.Add(Me.TextBoxNombreConf)
        Me.GroupBoxDatosConferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxDatosConferencia.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxDatosConferencia.Location = New System.Drawing.Point(308, 12)
        Me.GroupBoxDatosConferencia.Name = "GroupBoxDatosConferencia"
        Me.GroupBoxDatosConferencia.Size = New System.Drawing.Size(528, 358)
        Me.GroupBoxDatosConferencia.TabIndex = 45
        Me.GroupBoxDatosConferencia.TabStop = False
        Me.GroupBoxDatosConferencia.Text = "Datos de la conferencia"
        '
        'LabelInvest
        '
        Me.LabelInvest.AutoSize = True
        Me.LabelInvest.ForeColor = System.Drawing.Color.Black
        Me.LabelInvest.Location = New System.Drawing.Point(17, 225)
        Me.LabelInvest.Name = "LabelInvest"
        Me.LabelInvest.Size = New System.Drawing.Size(104, 34)
        Me.LabelInvest.TabIndex = 34
        Me.LabelInvest.Text = "Investigadores " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que asisten:"
        '
        'LabelNombreConf
        '
        Me.LabelNombreConf.AutoSize = True
        Me.LabelNombreConf.ForeColor = System.Drawing.Color.Black
        Me.LabelNombreConf.Location = New System.Drawing.Point(17, 92)
        Me.LabelNombreConf.Name = "LabelNombreConf"
        Me.LabelNombreConf.Size = New System.Drawing.Size(62, 17)
        Me.LabelNombreConf.TabIndex = 24
        Me.LabelNombreConf.Text = "Nombre:"
        '
        'LabelIdentificadorConf
        '
        Me.LabelIdentificadorConf.AutoSize = True
        Me.LabelIdentificadorConf.ForeColor = System.Drawing.Color.Black
        Me.LabelIdentificadorConf.Location = New System.Drawing.Point(17, 29)
        Me.LabelIdentificadorConf.Name = "LabelIdentificadorConf"
        Me.LabelIdentificadorConf.Size = New System.Drawing.Size(89, 17)
        Me.LabelIdentificadorConf.TabIndex = 22
        Me.LabelIdentificadorConf.Text = "Identificador:"
        '
        'LabelSiglasConf
        '
        Me.LabelSiglasConf.AutoSize = True
        Me.LabelSiglasConf.ForeColor = System.Drawing.Color.Black
        Me.LabelSiglasConf.Location = New System.Drawing.Point(17, 59)
        Me.LabelSiglasConf.Name = "LabelSiglasConf"
        Me.LabelSiglasConf.Size = New System.Drawing.Size(50, 17)
        Me.LabelSiglasConf.TabIndex = 23
        Me.LabelSiglasConf.Text = "Siglas:"
        '
        'LabelLugarConf
        '
        Me.LabelLugarConf.AutoSize = True
        Me.LabelLugarConf.ForeColor = System.Drawing.Color.Black
        Me.LabelLugarConf.Location = New System.Drawing.Point(17, 123)
        Me.LabelLugarConf.Name = "LabelLugarConf"
        Me.LabelLugarConf.Size = New System.Drawing.Size(49, 17)
        Me.LabelLugarConf.TabIndex = 25
        Me.LabelLugarConf.Text = "Lugar:"
        '
        'LabelFecInicioConf
        '
        Me.LabelFecInicioConf.AutoSize = True
        Me.LabelFecInicioConf.ForeColor = System.Drawing.Color.Black
        Me.LabelFecInicioConf.Location = New System.Drawing.Point(17, 157)
        Me.LabelFecInicioConf.Name = "LabelFecInicioConf"
        Me.LabelFecInicioConf.Size = New System.Drawing.Size(107, 17)
        Me.LabelFecInicioConf.TabIndex = 26
        Me.LabelFecInicioConf.Text = "Fecha de inicio:"
        '
        'DateTimePickerFinConf
        '
        Me.DateTimePickerFinConf.Location = New System.Drawing.Point(144, 184)
        Me.DateTimePickerFinConf.Name = "DateTimePickerFinConf"
        Me.DateTimePickerFinConf.Size = New System.Drawing.Size(247, 23)
        Me.DateTimePickerFinConf.TabIndex = 33
        '
        'LabelFecFinConf
        '
        Me.LabelFecFinConf.AutoSize = True
        Me.LabelFecFinConf.ForeColor = System.Drawing.Color.Black
        Me.LabelFecFinConf.Location = New System.Drawing.Point(17, 189)
        Me.LabelFecFinConf.Name = "LabelFecFinConf"
        Me.LabelFecFinConf.Size = New System.Drawing.Size(70, 17)
        Me.LabelFecFinConf.TabIndex = 27
        Me.LabelFecFinConf.Text = "Fecha fin:"
        '
        'DateTimePickerInicioConf
        '
        Me.DateTimePickerInicioConf.Location = New System.Drawing.Point(144, 152)
        Me.DateTimePickerInicioConf.Name = "DateTimePickerInicioConf"
        Me.DateTimePickerInicioConf.Size = New System.Drawing.Size(247, 23)
        Me.DateTimePickerInicioConf.TabIndex = 32
        '
        'TextBoxIdConf
        '
        Me.TextBoxIdConf.Location = New System.Drawing.Point(144, 26)
        Me.TextBoxIdConf.Name = "TextBoxIdConf"
        Me.TextBoxIdConf.Size = New System.Drawing.Size(60, 23)
        Me.TextBoxIdConf.TabIndex = 28
        '
        'TextBoxLugarConf
        '
        Me.TextBoxLugarConf.Location = New System.Drawing.Point(144, 120)
        Me.TextBoxLugarConf.Name = "TextBoxLugarConf"
        Me.TextBoxLugarConf.Size = New System.Drawing.Size(338, 23)
        Me.TextBoxLugarConf.TabIndex = 31
        '
        'TextBoxSiglasConf
        '
        Me.TextBoxSiglasConf.Location = New System.Drawing.Point(144, 56)
        Me.TextBoxSiglasConf.Name = "TextBoxSiglasConf"
        Me.TextBoxSiglasConf.Size = New System.Drawing.Size(102, 23)
        Me.TextBoxSiglasConf.TabIndex = 29
        '
        'TextBoxNombreConf
        '
        Me.TextBoxNombreConf.Location = New System.Drawing.Point(144, 89)
        Me.TextBoxNombreConf.Name = "TextBoxNombreConf"
        Me.TextBoxNombreConf.Size = New System.Drawing.Size(338, 23)
        Me.TextBoxNombreConf.TabIndex = 30
        '
        'GroupBoxConferencias
        '
        Me.GroupBoxConferencias.Controls.Add(Me.ListBoxListaConferencias)
        Me.GroupBoxConferencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxConferencias.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxConferencias.Location = New System.Drawing.Point(24, 12)
        Me.GroupBoxConferencias.Name = "GroupBoxConferencias"
        Me.GroupBoxConferencias.Size = New System.Drawing.Size(260, 378)
        Me.GroupBoxConferencias.TabIndex = 46
        Me.GroupBoxConferencias.TabStop = False
        Me.GroupBoxConferencias.Text = "Lista de conferencias"
        '
        'ListBoxListaConferencias
        '
        Me.ListBoxListaConferencias.ForeColor = System.Drawing.Color.Black
        Me.ListBoxListaConferencias.FormattingEnabled = True
        Me.ListBoxListaConferencias.ItemHeight = 16
        Me.ListBoxListaConferencias.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxListaConferencias.Name = "ListBoxListaConferencias"
        Me.ListBoxListaConferencias.Size = New System.Drawing.Size(236, 340)
        Me.ListBoxListaConferencias.TabIndex = 21
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAtras.Location = New System.Drawing.Point(761, 385)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(75, 42)
        Me.ButtonAtras.TabIndex = 47
        Me.ButtonAtras.Text = "Atrás"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'TextBoxInvest
        '
        Me.TextBoxInvest.Location = New System.Drawing.Point(144, 225)
        Me.TextBoxInvest.Multiline = True
        Me.TextBoxInvest.Name = "TextBoxInvest"
        Me.TextBoxInvest.Size = New System.Drawing.Size(338, 115)
        Me.TextBoxInvest.TabIndex = 48
        '
        'Lista_Conferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 439)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.GroupBoxConferencias)
        Me.Controls.Add(Me.GroupBoxDatosConferencia)
        Me.Name = "Lista_Conferencias"
        Me.Text = "Listado de conferencias"
        Me.GroupBoxDatosConferencia.ResumeLayout(False)
        Me.GroupBoxDatosConferencia.PerformLayout()
        Me.GroupBoxConferencias.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBoxDatosConferencia As System.Windows.Forms.GroupBox
    Friend WithEvents LabelNombreConf As System.Windows.Forms.Label
    Friend WithEvents LabelIdentificadorConf As System.Windows.Forms.Label
    Friend WithEvents LabelSiglasConf As System.Windows.Forms.Label
    Friend WithEvents LabelLugarConf As System.Windows.Forms.Label
    Friend WithEvents LabelFecInicioConf As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerFinConf As System.Windows.Forms.DateTimePicker
    Friend WithEvents LabelFecFinConf As System.Windows.Forms.Label
    Friend WithEvents DateTimePickerInicioConf As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBoxIdConf As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLugarConf As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSiglasConf As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNombreConf As System.Windows.Forms.TextBox
    Friend WithEvents LabelInvest As System.Windows.Forms.Label
    Friend WithEvents GroupBoxConferencias As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxListaConferencias As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents TextBoxInvest As System.Windows.Forms.TextBox
End Class
