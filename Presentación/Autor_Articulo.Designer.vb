<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Autor_Articulo
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
        Me.ListBoxInvestigadores = New System.Windows.Forms.ListBox()
        Me.ListBoxArticulos = New System.Windows.Forms.ListBox()
        Me.LabelOrden = New System.Windows.Forms.Label()
        Me.TextBoxOrden = New System.Windows.Forms.TextBox()
        Me.ButtonAtraAutor = New System.Windows.Forms.Button()
        Me.GroupBoxArti = New System.Windows.Forms.GroupBox()
        Me.GroupBoxInvesti = New System.Windows.Forms.GroupBox()
        Me.GroupBoxArti.SuspendLayout()
        Me.GroupBoxInvesti.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListBoxInvestigadores
        '
        Me.ListBoxInvestigadores.ForeColor = System.Drawing.Color.Black
        Me.ListBoxInvestigadores.FormattingEnabled = True
        Me.ListBoxInvestigadores.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxInvestigadores.Name = "ListBoxInvestigadores"
        Me.ListBoxInvestigadores.Size = New System.Drawing.Size(162, 238)
        Me.ListBoxInvestigadores.TabIndex = 0
        '
        'ListBoxArticulos
        '
        Me.ListBoxArticulos.ForeColor = System.Drawing.Color.Black
        Me.ListBoxArticulos.FormattingEnabled = True
        Me.ListBoxArticulos.Location = New System.Drawing.Point(6, 19)
        Me.ListBoxArticulos.Name = "ListBoxArticulos"
        Me.ListBoxArticulos.Size = New System.Drawing.Size(170, 238)
        Me.ListBoxArticulos.TabIndex = 1
        '
        'LabelOrden
        '
        Me.LabelOrden.AutoSize = True
        Me.LabelOrden.Location = New System.Drawing.Point(25, 312)
        Me.LabelOrden.Name = "LabelOrden"
        Me.LabelOrden.Size = New System.Drawing.Size(181, 13)
        Me.LabelOrden.TabIndex = 2
        Me.LabelOrden.Text = "Orden del investigador en el artículo:"
        '
        'TextBoxOrden
        '
        Me.TextBoxOrden.Location = New System.Drawing.Point(212, 309)
        Me.TextBoxOrden.Name = "TextBoxOrden"
        Me.TextBoxOrden.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxOrden.TabIndex = 3
        '
        'ButtonAtraAutor
        '
        Me.ButtonAtraAutor.Location = New System.Drawing.Point(391, 298)
        Me.ButtonAtraAutor.Name = "ButtonAtraAutor"
        Me.ButtonAtraAutor.Size = New System.Drawing.Size(78, 41)
        Me.ButtonAtraAutor.TabIndex = 5
        Me.ButtonAtraAutor.Text = "Atrás"
        Me.ButtonAtraAutor.UseVisualStyleBackColor = True
        '
        'GroupBoxArti
        '
        Me.GroupBoxArti.Controls.Add(Me.ListBoxArticulos)
        Me.GroupBoxArti.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxArti.Location = New System.Drawing.Point(21, 12)
        Me.GroupBoxArti.Name = "GroupBoxArti"
        Me.GroupBoxArti.Size = New System.Drawing.Size(185, 270)
        Me.GroupBoxArti.TabIndex = 6
        Me.GroupBoxArti.TabStop = False
        Me.GroupBoxArti.Text = "Lista de artículos"
        '
        'GroupBoxInvesti
        '
        Me.GroupBoxInvesti.Controls.Add(Me.ListBoxInvestigadores)
        Me.GroupBoxInvesti.ForeColor = System.Drawing.Color.Blue
        Me.GroupBoxInvesti.Location = New System.Drawing.Point(295, 12)
        Me.GroupBoxInvesti.Name = "GroupBoxInvesti"
        Me.GroupBoxInvesti.Size = New System.Drawing.Size(183, 270)
        Me.GroupBoxInvesti.TabIndex = 7
        Me.GroupBoxInvesti.TabStop = False
        Me.GroupBoxInvesti.Text = "Autores  del artículo"
        '
        'Autor_Articulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 352)
        Me.Controls.Add(Me.GroupBoxInvesti)
        Me.Controls.Add(Me.GroupBoxArti)
        Me.Controls.Add(Me.ButtonAtraAutor)
        Me.Controls.Add(Me.TextBoxOrden)
        Me.Controls.Add(Me.LabelOrden)
        Me.Name = "Autor_Articulo"
        Me.Text = "Autores de los artículos"
        Me.GroupBoxArti.ResumeLayout(False)
        Me.GroupBoxInvesti.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBoxInvestigadores As System.Windows.Forms.ListBox
    Friend WithEvents ListBoxArticulos As System.Windows.Forms.ListBox
    Friend WithEvents LabelOrden As System.Windows.Forms.Label
    Friend WithEvents TextBoxOrden As System.Windows.Forms.TextBox
    Friend WithEvents ButtonAtraAutor As System.Windows.Forms.Button
    Friend WithEvents GroupBoxArti As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxInvesti As System.Windows.Forms.GroupBox
End Class
