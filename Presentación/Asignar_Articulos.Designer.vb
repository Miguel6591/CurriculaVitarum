<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asignar_Articulos
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
        Me.TextBoxListInv = New System.Windows.Forms.TextBox()
        Me.TextBoxListAut = New System.Windows.Forms.TextBox()
        Me.TextBoxListArt = New System.Windows.Forms.TextBox()
        Me.ButtonElArt = New System.Windows.Forms.Button()
        Me.ButtonMoArt = New System.Windows.Forms.Button()
        Me.ButtonAñArt = New System.Windows.Forms.Button()
        Me.LabelInvInv = New System.Windows.Forms.Label()
        Me.LabelAutInv = New System.Windows.Forms.Label()
        Me.LabelArtInv = New System.Windows.Forms.Label()
        Me.GroupBoxListaInvInv = New System.Windows.Forms.GroupBox()
        Me.ListBoxInvInv = New System.Windows.Forms.ListBox()
        Me.GroupBoxAutInv = New System.Windows.Forms.GroupBox()
        Me.ListBoxAutInv = New System.Windows.Forms.ListBox()
        Me.GroupBoxArtInv = New System.Windows.Forms.GroupBox()
        Me.ListBoxArtInv = New System.Windows.Forms.ListBox()
        Me.TextBoxOrdenArt = New System.Windows.Forms.TextBox()
        Me.LabelOrden = New System.Windows.Forms.Label()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.GroupBoxListaInvInv.SuspendLayout()
        Me.GroupBoxAutInv.SuspendLayout()
        Me.GroupBoxArtInv.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBoxListInv
        '
        Me.TextBoxListInv.Enabled = False
        Me.TextBoxListInv.Location = New System.Drawing.Point(750, 266)
        Me.TextBoxListInv.Multiline = True
        Me.TextBoxListInv.Name = "TextBoxListInv"
        Me.TextBoxListInv.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxListInv.TabIndex = 36
        '
        'TextBoxListAut
        '
        Me.TextBoxListAut.Location = New System.Drawing.Point(688, 111)
        Me.TextBoxListAut.Multiline = True
        Me.TextBoxListAut.Name = "TextBoxListAut"
        Me.TextBoxListAut.Size = New System.Drawing.Size(162, 87)
        Me.TextBoxListAut.TabIndex = 35
        '
        'TextBoxListArt
        '
        Me.TextBoxListArt.Enabled = False
        Me.TextBoxListArt.Location = New System.Drawing.Point(750, 71)
        Me.TextBoxListArt.Name = "TextBoxListArt"
        Me.TextBoxListArt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxListArt.TabIndex = 34
        '
        'ButtonElArt
        '
        Me.ButtonElArt.Location = New System.Drawing.Point(429, 341)
        Me.ButtonElArt.Name = "ButtonElArt"
        Me.ButtonElArt.Size = New System.Drawing.Size(167, 49)
        Me.ButtonElArt.TabIndex = 33
        Me.ButtonElArt.Text = "Eliminar investigador del artículo"
        Me.ButtonElArt.UseVisualStyleBackColor = True
        '
        'ButtonMoArt
        '
        Me.ButtonMoArt.Location = New System.Drawing.Point(221, 341)
        Me.ButtonMoArt.Name = "ButtonMoArt"
        Me.ButtonMoArt.Size = New System.Drawing.Size(167, 49)
        Me.ButtonMoArt.TabIndex = 32
        Me.ButtonMoArt.Text = "Modificar investigador del artículo"
        Me.ButtonMoArt.UseVisualStyleBackColor = True
        '
        'ButtonAñArt
        '
        Me.ButtonAñArt.Location = New System.Drawing.Point(20, 341)
        Me.ButtonAñArt.Name = "ButtonAñArt"
        Me.ButtonAñArt.Size = New System.Drawing.Size(167, 49)
        Me.ButtonAñArt.TabIndex = 31
        Me.ButtonAñArt.Text = "Añadir investigador al artículo"
        Me.ButtonAñArt.UseVisualStyleBackColor = True
        '
        'LabelInvInv
        '
        Me.LabelInvInv.AutoSize = True
        Me.LabelInvInv.Location = New System.Drawing.Point(616, 260)
        Me.LabelInvInv.Name = "LabelInvInv"
        Me.LabelInvInv.Size = New System.Drawing.Size(84, 26)
        Me.LabelInvInv.TabIndex = 30
        Me.LabelInvInv.Text = "Identificador " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del investigador:"
        '
        'LabelAutInv
        '
        Me.LabelAutInv.AutoSize = True
        Me.LabelAutInv.Location = New System.Drawing.Point(616, 114)
        Me.LabelAutInv.Name = "LabelAutInv"
        Me.LabelAutInv.Size = New System.Drawing.Size(68, 26)
        Me.LabelAutInv.TabIndex = 29
        Me.LabelAutInv.Text = "Autor/es del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "artículo:"
        '
        'LabelArtInv
        '
        Me.LabelArtInv.AutoSize = True
        Me.LabelArtInv.Location = New System.Drawing.Point(616, 65)
        Me.LabelArtInv.Name = "LabelArtInv"
        Me.LabelArtInv.Size = New System.Drawing.Size(68, 26)
        Me.LabelArtInv.TabIndex = 28
        Me.LabelArtInv.Text = "Identificador " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del artículo:"
        '
        'GroupBoxListaInvInv
        '
        Me.GroupBoxListaInvInv.Controls.Add(Me.ListBoxInvInv)
        Me.GroupBoxListaInvInv.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxListaInvInv.Location = New System.Drawing.Point(427, 34)
        Me.GroupBoxListaInvInv.Name = "GroupBoxListaInvInv"
        Me.GroupBoxListaInvInv.Size = New System.Drawing.Size(169, 270)
        Me.GroupBoxListaInvInv.TabIndex = 27
        Me.GroupBoxListaInvInv.TabStop = False
        Me.GroupBoxListaInvInv.Text = "Lista de investigadores"
        '
        'ListBoxInvInv
        '
        Me.ListBoxInvInv.ForeColor = System.Drawing.Color.Black
        Me.ListBoxInvInv.FormattingEnabled = True
        Me.ListBoxInvInv.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxInvInv.Name = "ListBoxInvInv"
        Me.ListBoxInvInv.Size = New System.Drawing.Size(150, 238)
        Me.ListBoxInvInv.TabIndex = 1
        '
        'GroupBoxAutInv
        '
        Me.GroupBoxAutInv.Controls.Add(Me.ListBoxAutInv)
        Me.GroupBoxAutInv.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxAutInv.Location = New System.Drawing.Point(221, 34)
        Me.GroupBoxAutInv.Name = "GroupBoxAutInv"
        Me.GroupBoxAutInv.Size = New System.Drawing.Size(176, 270)
        Me.GroupBoxAutInv.TabIndex = 26
        Me.GroupBoxAutInv.TabStop = False
        Me.GroupBoxAutInv.Text = "Autores  del artículo"
        '
        'ListBoxAutInv
        '
        Me.ListBoxAutInv.ForeColor = System.Drawing.Color.Black
        Me.ListBoxAutInv.FormattingEnabled = True
        Me.ListBoxAutInv.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxAutInv.Name = "ListBoxAutInv"
        Me.ListBoxAutInv.Size = New System.Drawing.Size(161, 238)
        Me.ListBoxAutInv.TabIndex = 0
        '
        'GroupBoxArtInv
        '
        Me.GroupBoxArtInv.Controls.Add(Me.ListBoxArtInv)
        Me.GroupBoxArtInv.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxArtInv.Location = New System.Drawing.Point(20, 34)
        Me.GroupBoxArtInv.Name = "GroupBoxArtInv"
        Me.GroupBoxArtInv.Size = New System.Drawing.Size(166, 270)
        Me.GroupBoxArtInv.TabIndex = 25
        Me.GroupBoxArtInv.TabStop = False
        Me.GroupBoxArtInv.Text = "Lista de artículos"
        '
        'ListBoxArtInv
        '
        Me.ListBoxArtInv.ForeColor = System.Drawing.Color.Black
        Me.ListBoxArtInv.FormattingEnabled = True
        Me.ListBoxArtInv.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxArtInv.Name = "ListBoxArtInv"
        Me.ListBoxArtInv.Size = New System.Drawing.Size(147, 238)
        Me.ListBoxArtInv.TabIndex = 1
        '
        'TextBoxOrdenArt
        '
        Me.TextBoxOrdenArt.Location = New System.Drawing.Point(750, 221)
        Me.TextBoxOrdenArt.Name = "TextBoxOrdenArt"
        Me.TextBoxOrdenArt.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOrdenArt.TabIndex = 24
        '
        'LabelOrden
        '
        Me.LabelOrden.AutoSize = True
        Me.LabelOrden.Location = New System.Drawing.Point(616, 215)
        Me.LabelOrden.Name = "LabelOrden"
        Me.LabelOrden.Size = New System.Drawing.Size(113, 26)
        Me.LabelOrden.TabIndex = 23
        Me.LabelOrden.Text = "Orden del investigador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en el artículo:"
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Location = New System.Drawing.Point(763, 348)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(87, 42)
        Me.ButtonAtras.TabIndex = 37
        Me.ButtonAtras.Text = "Atrás"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'Asignar_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 422)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.TextBoxListInv)
        Me.Controls.Add(Me.TextBoxListAut)
        Me.Controls.Add(Me.TextBoxListArt)
        Me.Controls.Add(Me.ButtonElArt)
        Me.Controls.Add(Me.ButtonMoArt)
        Me.Controls.Add(Me.ButtonAñArt)
        Me.Controls.Add(Me.LabelInvInv)
        Me.Controls.Add(Me.LabelAutInv)
        Me.Controls.Add(Me.LabelArtInv)
        Me.Controls.Add(Me.GroupBoxListaInvInv)
        Me.Controls.Add(Me.GroupBoxAutInv)
        Me.Controls.Add(Me.GroupBoxArtInv)
        Me.Controls.Add(Me.TextBoxOrdenArt)
        Me.Controls.Add(Me.LabelOrden)
        Me.Name = "Asignar_Articulos"
        Me.Text = "ListaArticulos"
        Me.GroupBoxListaInvInv.ResumeLayout(False)
        Me.GroupBoxAutInv.ResumeLayout(False)
        Me.GroupBoxArtInv.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxListInv As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxListAut As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxListArt As System.Windows.Forms.TextBox
    Friend WithEvents ButtonElArt As System.Windows.Forms.Button
    Friend WithEvents ButtonMoArt As System.Windows.Forms.Button
    Friend WithEvents ButtonAñArt As System.Windows.Forms.Button
    Friend WithEvents LabelInvInv As System.Windows.Forms.Label
    Friend WithEvents LabelAutInv As System.Windows.Forms.Label
    Friend WithEvents LabelArtInv As System.Windows.Forms.Label
    Friend WithEvents GroupBoxListaInvInv As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxInvInv As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxAutInv As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxAutInv As System.Windows.Forms.ListBox
    Friend WithEvents GroupBoxArtInv As System.Windows.Forms.GroupBox
    Friend WithEvents ListBoxArtInv As System.Windows.Forms.ListBox
    Friend WithEvents TextBoxOrdenArt As System.Windows.Forms.TextBox
    Friend WithEvents LabelOrden As System.Windows.Forms.Label
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
End Class
