<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curriculum_Vitae
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
        Me.ComboBoxInvest = New System.Windows.Forms.ComboBox()
        Me.ButtonGenera = New System.Windows.Forms.Button()
        Me.RichTextBoxInvest = New System.Windows.Forms.RichTextBox()
        Me.ButtonAtras = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxInvest
        '
        Me.ComboBoxInvest.FormattingEnabled = True
        Me.ComboBoxInvest.Location = New System.Drawing.Point(148, 25)
        Me.ComboBoxInvest.Name = "ComboBoxInvest"
        Me.ComboBoxInvest.Size = New System.Drawing.Size(191, 21)
        Me.ComboBoxInvest.TabIndex = 0
        '
        'ButtonGenera
        '
        Me.ButtonGenera.Location = New System.Drawing.Point(390, 18)
        Me.ButtonGenera.Name = "ButtonGenera"
        Me.ButtonGenera.Size = New System.Drawing.Size(126, 33)
        Me.ButtonGenera.TabIndex = 1
        Me.ButtonGenera.Text = "Generar CV"
        Me.ButtonGenera.UseVisualStyleBackColor = True
        '
        'RichTextBoxInvest
        '
        Me.RichTextBoxInvest.Location = New System.Drawing.Point(33, 81)
        Me.RichTextBoxInvest.Name = "RichTextBoxInvest"
        Me.RichTextBoxInvest.Size = New System.Drawing.Size(633, 333)
        Me.RichTextBoxInvest.TabIndex = 2
        Me.RichTextBoxInvest.Text = ""
        '
        'ButtonAtras
        '
        Me.ButtonAtras.Location = New System.Drawing.Point(580, 446)
        Me.ButtonAtras.Name = "ButtonAtras"
        Me.ButtonAtras.Size = New System.Drawing.Size(86, 37)
        Me.ButtonAtras.TabIndex = 3
        Me.ButtonAtras.Text = "Atrás"
        Me.ButtonAtras.UseVisualStyleBackColor = True
        '
        'Curriculum_Vitae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 495)
        Me.Controls.Add(Me.ButtonAtras)
        Me.Controls.Add(Me.RichTextBoxInvest)
        Me.Controls.Add(Me.ButtonGenera)
        Me.Controls.Add(Me.ComboBoxInvest)
        Me.Name = "Curriculum_Vitae"
        Me.Text = "Curriculum Vitae"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ComboBoxInvest As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonGenera As System.Windows.Forms.Button
    Friend WithEvents RichTextBoxInvest As System.Windows.Forms.RichTextBox
    Friend WithEvents ButtonAtras As System.Windows.Forms.Button
End Class
