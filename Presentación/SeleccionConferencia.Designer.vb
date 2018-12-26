<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionConferencia
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
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.TextBoxConInvesti = New System.Windows.Forms.TextBox()
        Me.TextBoxAsisInvesti = New System.Windows.Forms.TextBox()
        Me.TextBoxConferenInve = New System.Windows.Forms.TextBox()
        Me.LabelListConInv = New System.Windows.Forms.Label()
        Me.LabelAsisInv = New System.Windows.Forms.Label()
        Me.LabelConInv = New System.Windows.Forms.Label()
        Me.ButtonElAsInv = New System.Windows.Forms.Button()
        Me.ButtonModifConfInv = New System.Windows.Forms.Button()
        Me.GroupBoxAsisConf = New System.Windows.Forms.GroupBox()
        Me.ListBoxAsisConf = New System.Windows.Forms.ListBox()
        Me.ButtonAsistirConfInv = New System.Windows.Forms.Button()
        Me.GroupBoxListaConfInv = New System.Windows.Forms.GroupBox()
        Me.ListBoxConfInv = New System.Windows.Forms.ListBox()
        Me.GroupBoxListConf = New System.Windows.Forms.GroupBox()
        Me.ListBoxListConf = New System.Windows.Forms.ListBox()
        Me.GroupBoxAsisConf.SuspendLayout()
        Me.GroupBoxListaConfInv.SuspendLayout()
        Me.GroupBoxListConf.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Location = New System.Drawing.Point(770, 366)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(85, 43)
        Me.ButtonAtras.TabIndex = 3
        Me.ButtonAtras.Text = "Atrás"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'TextBoxConInvesti
        '
        Me.TextBoxConInvesti.Enabled = False
        Me.TextBoxConInvesti.Location = New System.Drawing.Point(731, 33)
        Me.TextBoxConInvesti.Name = "TextBoxConInvesti"
        Me.TextBoxConInvesti.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxConInvesti.TabIndex = 42
        '
        'TextBoxAsisInvesti
        '
        Me.TextBoxAsisInvesti.Location = New System.Drawing.Point(731, 70)
        Me.TextBoxAsisInvesti.Multiline = True
        Me.TextBoxAsisInvesti.Name = "TextBoxAsisInvesti"
        Me.TextBoxAsisInvesti.Size = New System.Drawing.Size(124, 136)
        Me.TextBoxAsisInvesti.TabIndex = 41
        '
        'TextBoxConferenInve
        '
        Me.TextBoxConferenInve.Enabled = False
        Me.TextBoxConferenInve.Location = New System.Drawing.Point(731, 228)
        Me.TextBoxConferenInve.Multiline = True
        Me.TextBoxConferenInve.Name = "TextBoxConferenInve"
        Me.TextBoxConferenInve.Size = New System.Drawing.Size(124, 20)
        Me.TextBoxConferenInve.TabIndex = 40
        '
        'LabelListConInv
        '
        Me.LabelListConInv.AutoSize = True
        Me.LabelListConInv.Location = New System.Drawing.Point(641, 231)
        Me.LabelListConInv.Name = "LabelListConInv"
        Me.LabelListConInv.Size = New System.Drawing.Size(68, 13)
        Me.LabelListConInv.TabIndex = 39
        Me.LabelListConInv.Text = "Investigador:"
        '
        'LabelAsisInv
        '
        Me.LabelAsisInv.AutoSize = True
        Me.LabelAsisInv.Location = New System.Drawing.Point(641, 70)
        Me.LabelAsisInv.Name = "LabelAsisInv"
        Me.LabelAsisInv.Size = New System.Drawing.Size(84, 39)
        Me.LabelAsisInv.TabIndex = 38
        Me.LabelAsisInv.Text = "Investigador/es" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que asisten a la " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "conferencia:"
        '
        'LabelConInv
        '
        Me.LabelConInv.AutoSize = True
        Me.LabelConInv.Location = New System.Drawing.Point(641, 36)
        Me.LabelConInv.Name = "LabelConInv"
        Me.LabelConInv.Size = New System.Drawing.Size(67, 13)
        Me.LabelConInv.TabIndex = 37
        Me.LabelConInv.Text = "Conferencia:"
        '
        'ButtonElAsInv
        '
        Me.ButtonElAsInv.Location = New System.Drawing.Point(451, 338)
        Me.ButtonElAsInv.Name = "ButtonElAsInv"
        Me.ButtonElAsInv.Size = New System.Drawing.Size(180, 54)
        Me.ButtonElAsInv.TabIndex = 36
        Me.ButtonElAsInv.Text = "Eliminar asistencia del investigador en la conferencia"
        Me.ButtonElAsInv.UseVisualStyleBackColor = True
        '
        'ButtonModifConfInv
        '
        Me.ButtonModifConfInv.Location = New System.Drawing.Point(225, 338)
        Me.ButtonModifConfInv.Name = "ButtonModifConfInv"
        Me.ButtonModifConfInv.Size = New System.Drawing.Size(202, 54)
        Me.ButtonModifConfInv.TabIndex = 35
        Me.ButtonModifConfInv.Text = "Modificar la asistencia del investigador en la conferecia"
        Me.ButtonModifConfInv.UseVisualStyleBackColor = True
        '
        'GroupBoxAsisConf
        '
        Me.GroupBoxAsisConf.Controls.Add(Me.ListBoxAsisConf)
        Me.GroupBoxAsisConf.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxAsisConf.Location = New System.Drawing.Point(219, 17)
        Me.GroupBoxAsisConf.Name = "GroupBoxAsisConf"
        Me.GroupBoxAsisConf.Size = New System.Drawing.Size(198, 283)
        Me.GroupBoxAsisConf.TabIndex = 34
        Me.GroupBoxAsisConf.TabStop = False
        Me.GroupBoxAsisConf.Text = "Lista de investigadores que asisten a la conferencia"
        '
        'ListBoxAsisConf
        '
        Me.ListBoxAsisConf.FormattingEnabled = True
        Me.ListBoxAsisConf.Location = New System.Drawing.Point(6, 32)
        Me.ListBoxAsisConf.Name = "ListBoxAsisConf"
        Me.ListBoxAsisConf.Size = New System.Drawing.Size(165, 238)
        Me.ListBoxAsisConf.TabIndex = 6
        '
        'ButtonAsistirConfInv
        '
        Me.ButtonAsistirConfInv.Location = New System.Drawing.Point(21, 338)
        Me.ButtonAsistirConfInv.Name = "ButtonAsistirConfInv"
        Me.ButtonAsistirConfInv.Size = New System.Drawing.Size(180, 54)
        Me.ButtonAsistirConfInv.TabIndex = 33
        Me.ButtonAsistirConfInv.Text = "Asistir investigador a conferencia"
        Me.ButtonAsistirConfInv.UseVisualStyleBackColor = True
        '
        'GroupBoxListaConfInv
        '
        Me.GroupBoxListaConfInv.Controls.Add(Me.ListBoxConfInv)
        Me.GroupBoxListaConfInv.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxListaConfInv.Location = New System.Drawing.Point(451, 17)
        Me.GroupBoxListaConfInv.Name = "GroupBoxListaConfInv"
        Me.GroupBoxListaConfInv.Size = New System.Drawing.Size(181, 283)
        Me.GroupBoxListaConfInv.TabIndex = 32
        Me.GroupBoxListaConfInv.TabStop = False
        Me.GroupBoxListaConfInv.Text = "Lista de investigadores"
        '
        'ListBoxConfInv
        '
        Me.ListBoxConfInv.FormattingEnabled = True
        Me.ListBoxConfInv.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxConfInv.Name = "ListBoxConfInv"
        Me.ListBoxConfInv.Size = New System.Drawing.Size(161, 251)
        Me.ListBoxConfInv.TabIndex = 6
        '
        'GroupBoxListConf
        '
        Me.GroupBoxListConf.Controls.Add(Me.ListBoxListConf)
        Me.GroupBoxListConf.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxListConf.Location = New System.Drawing.Point(21, 17)
        Me.GroupBoxListConf.Name = "GroupBoxListConf"
        Me.GroupBoxListConf.Size = New System.Drawing.Size(170, 283)
        Me.GroupBoxListConf.TabIndex = 31
        Me.GroupBoxListConf.TabStop = False
        Me.GroupBoxListConf.Text = "Lista de conferencias"
        '
        'ListBoxListConf
        '
        Me.ListBoxListConf.FormattingEnabled = True
        Me.ListBoxListConf.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxListConf.Name = "ListBoxListConf"
        Me.ListBoxListConf.Size = New System.Drawing.Size(151, 251)
        Me.ListBoxListConf.TabIndex = 7
        '
        'SeleccionConferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 421)
        Me.Controls.Add(Me.TextBoxConInvesti)
        Me.Controls.Add(Me.TextBoxAsisInvesti)
        Me.Controls.Add(Me.TextBoxConferenInve)
        Me.Controls.Add(Me.LabelListConInv)
        Me.Controls.Add(Me.LabelAsisInv)
        Me.Controls.Add(Me.LabelConInv)
        Me.Controls.Add(Me.ButtonElAsInv)
        Me.Controls.Add(Me.ButtonModifConfInv)
        Me.Controls.Add(Me.GroupBoxAsisConf)
        Me.Controls.Add(Me.ButtonAsistirConfInv)
        Me.Controls.Add(Me.GroupBoxListaConfInv)
        Me.Controls.Add(Me.GroupBoxListConf)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Name = "SeleccionConferencia"
        Me.Text = "Selección de conferencias"
        Me.GroupBoxAsisConf.ResumeLayout(False)
        Me.GroupBoxListaConfInv.ResumeLayout(False)
        Me.GroupBoxListConf.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
    Friend WithEvents TextBoxConInvesti As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxAsisInvesti As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxConferenInve As System.Windows.Forms.TextBox
    Friend WithEvents LabelListConInv As System.Windows.Forms.Label
    Friend WithEvents LabelAsisInv As System.Windows.Forms.Label
    Friend WithEvents LabelConInv As System.Windows.Forms.Label
    Friend WithEvents ButtonElAsInv As System.Windows.Forms.Button
    Friend WithEvents ButtonModifConfInv As System.Windows.Forms.Button
    Friend WithEvents GroupBoxAsisConf As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxAsisConf As System.Windows.Forms.ListBox
    Friend WithEvents ButtonAsistirConfInv As System.Windows.Forms.Button
    Friend WithEvents GroupBoxListaConfInv As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxConfInv As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxListConf As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxListConf As System.Windows.Forms.ListBox
End Class
