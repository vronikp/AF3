<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CtlCaracteristicas
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlDimesion = New System.Windows.Forms.Panel()
        Me.txtDimesion = New Infoware.Controles.Base.TextBoxStd()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pnlMaterial = New System.Windows.Forms.Panel()
        Me.txtMaterial = New Infoware.Controles.Base.TextBoxStd()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pnlColor = New System.Windows.Forms.Panel()
        Me.txtColor = New Infoware.Controles.Base.TextBoxStd()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pnlActCar1 = New System.Windows.Forms.Panel()
        Me.txtActCar1 = New Infoware.Controles.Base.TextBoxStd()
        Me.lblActCar1 = New System.Windows.Forms.Label()
        Me.pnlActCar2 = New System.Windows.Forms.Panel()
        Me.txtActCar2 = New Infoware.Controles.Base.TextBoxStd()
        Me.lblActCar2 = New System.Windows.Forms.Label()
        Me.pnlActCar3 = New System.Windows.Forms.Panel()
        Me.txtActCar3 = New Infoware.Controles.Base.TextBoxStd()
        Me.lblActCar3 = New System.Windows.Forms.Label()
        Me.pnlActCar4 = New System.Windows.Forms.Panel()
        Me.txtActCar4 = New Infoware.Controles.Base.TextBoxStd()
        Me.lblActCar4 = New System.Windows.Forms.Label()
        Me.pnlActCar5 = New System.Windows.Forms.Panel()
        Me.txtActCar5 = New Infoware.Controles.Base.TextBoxStd()
        Me.lblActCar5 = New System.Windows.Forms.Label()
        Me.pnlDimesion.SuspendLayout()
        Me.pnlMaterial.SuspendLayout()
        Me.pnlColor.SuspendLayout()
        Me.pnlActCar1.SuspendLayout()
        Me.pnlActCar2.SuspendLayout()
        Me.pnlActCar3.SuspendLayout()
        Me.pnlActCar4.SuspendLayout()
        Me.pnlActCar5.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlDimesion
        '
        Me.pnlDimesion.Controls.Add(Me.txtDimesion)
        Me.pnlDimesion.Controls.Add(Me.Label8)
        Me.pnlDimesion.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlDimesion.Location = New System.Drawing.Point(0, 0)
        Me.pnlDimesion.Name = "pnlDimesion"
        Me.pnlDimesion.Size = New System.Drawing.Size(332, 23)
        Me.pnlDimesion.TabIndex = 43
        '
        'txtDimesion
        '
        Me.txtDimesion.Location = New System.Drawing.Point(146, 1)
        Me.txtDimesion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDimesion.Mensaje = ""
        Me.txtDimesion.Name = "txtDimesion"
        Me.txtDimesion.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDimesion.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtDimesion.PromptText = ""
        Me.txtDimesion.Size = New System.Drawing.Size(181, 20)
        Me.txtDimesion.TabIndex = 31
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 4)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Dimension:"
        '
        'pnlMaterial
        '
        Me.pnlMaterial.Controls.Add(Me.txtMaterial)
        Me.pnlMaterial.Controls.Add(Me.Label7)
        Me.pnlMaterial.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlMaterial.Location = New System.Drawing.Point(0, 23)
        Me.pnlMaterial.Name = "pnlMaterial"
        Me.pnlMaterial.Size = New System.Drawing.Size(332, 23)
        Me.pnlMaterial.TabIndex = 44
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(146, 1)
        Me.txtMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMaterial.Mensaje = ""
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtMaterial.PromptText = ""
        Me.txtMaterial.Size = New System.Drawing.Size(181, 20)
        Me.txtMaterial.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 4)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Material:"
        '
        'pnlColor
        '
        Me.pnlColor.Controls.Add(Me.txtColor)
        Me.pnlColor.Controls.Add(Me.Label6)
        Me.pnlColor.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlColor.Location = New System.Drawing.Point(0, 46)
        Me.pnlColor.Name = "pnlColor"
        Me.pnlColor.Size = New System.Drawing.Size(332, 23)
        Me.pnlColor.TabIndex = 45
        '
        'txtColor
        '
        Me.txtColor.Location = New System.Drawing.Point(146, 1)
        Me.txtColor.Margin = New System.Windows.Forms.Padding(2)
        Me.txtColor.Mensaje = ""
        Me.txtColor.Name = "txtColor"
        Me.txtColor.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColor.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtColor.PromptText = ""
        Me.txtColor.Size = New System.Drawing.Size(181, 20)
        Me.txtColor.TabIndex = 31
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Color:"
        '
        'pnlActCar1
        '
        Me.pnlActCar1.Controls.Add(Me.txtActCar1)
        Me.pnlActCar1.Controls.Add(Me.lblActCar1)
        Me.pnlActCar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActCar1.Location = New System.Drawing.Point(0, 69)
        Me.pnlActCar1.Name = "pnlActCar1"
        Me.pnlActCar1.Size = New System.Drawing.Size(332, 23)
        Me.pnlActCar1.TabIndex = 46
        '
        'txtActCar1
        '
        Me.txtActCar1.Location = New System.Drawing.Point(146, 1)
        Me.txtActCar1.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActCar1.Mensaje = ""
        Me.txtActCar1.Name = "txtActCar1"
        Me.txtActCar1.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActCar1.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtActCar1.PromptText = ""
        Me.txtActCar1.Size = New System.Drawing.Size(181, 20)
        Me.txtActCar1.TabIndex = 31
        '
        'lblActCar1
        '
        Me.lblActCar1.AutoSize = True
        Me.lblActCar1.Location = New System.Drawing.Point(3, 4)
        Me.lblActCar1.Name = "lblActCar1"
        Me.lblActCar1.Size = New System.Drawing.Size(48, 13)
        Me.lblActCar1.TabIndex = 30
        Me.lblActCar1.Text = "ActCar1:"
        '
        'pnlActCar2
        '
        Me.pnlActCar2.Controls.Add(Me.txtActCar2)
        Me.pnlActCar2.Controls.Add(Me.lblActCar2)
        Me.pnlActCar2.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActCar2.Location = New System.Drawing.Point(0, 92)
        Me.pnlActCar2.Name = "pnlActCar2"
        Me.pnlActCar2.Size = New System.Drawing.Size(332, 23)
        Me.pnlActCar2.TabIndex = 47
        '
        'txtActCar2
        '
        Me.txtActCar2.Location = New System.Drawing.Point(146, 1)
        Me.txtActCar2.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActCar2.Mensaje = ""
        Me.txtActCar2.Name = "txtActCar2"
        Me.txtActCar2.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActCar2.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtActCar2.PromptText = ""
        Me.txtActCar2.Size = New System.Drawing.Size(181, 20)
        Me.txtActCar2.TabIndex = 31
        '
        'lblActCar2
        '
        Me.lblActCar2.AutoSize = True
        Me.lblActCar2.Location = New System.Drawing.Point(3, 4)
        Me.lblActCar2.Name = "lblActCar2"
        Me.lblActCar2.Size = New System.Drawing.Size(48, 13)
        Me.lblActCar2.TabIndex = 30
        Me.lblActCar2.Text = "ActCar2:"
        '
        'pnlActCar3
        '
        Me.pnlActCar3.Controls.Add(Me.txtActCar3)
        Me.pnlActCar3.Controls.Add(Me.lblActCar3)
        Me.pnlActCar3.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActCar3.Location = New System.Drawing.Point(0, 115)
        Me.pnlActCar3.Name = "pnlActCar3"
        Me.pnlActCar3.Size = New System.Drawing.Size(332, 23)
        Me.pnlActCar3.TabIndex = 48
        '
        'txtActCar3
        '
        Me.txtActCar3.Location = New System.Drawing.Point(146, 1)
        Me.txtActCar3.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActCar3.Mensaje = ""
        Me.txtActCar3.Name = "txtActCar3"
        Me.txtActCar3.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActCar3.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtActCar3.PromptText = ""
        Me.txtActCar3.Size = New System.Drawing.Size(181, 20)
        Me.txtActCar3.TabIndex = 31
        '
        'lblActCar3
        '
        Me.lblActCar3.AutoSize = True
        Me.lblActCar3.Location = New System.Drawing.Point(3, 4)
        Me.lblActCar3.Name = "lblActCar3"
        Me.lblActCar3.Size = New System.Drawing.Size(48, 13)
        Me.lblActCar3.TabIndex = 30
        Me.lblActCar3.Text = "ActCar3:"
        '
        'pnlActCar4
        '
        Me.pnlActCar4.Controls.Add(Me.txtActCar4)
        Me.pnlActCar4.Controls.Add(Me.lblActCar4)
        Me.pnlActCar4.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActCar4.Location = New System.Drawing.Point(0, 138)
        Me.pnlActCar4.Name = "pnlActCar4"
        Me.pnlActCar4.Size = New System.Drawing.Size(332, 23)
        Me.pnlActCar4.TabIndex = 49
        '
        'txtActCar4
        '
        Me.txtActCar4.Location = New System.Drawing.Point(146, 1)
        Me.txtActCar4.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActCar4.Mensaje = ""
        Me.txtActCar4.Name = "txtActCar4"
        Me.txtActCar4.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActCar4.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtActCar4.PromptText = ""
        Me.txtActCar4.Size = New System.Drawing.Size(181, 20)
        Me.txtActCar4.TabIndex = 31
        '
        'lblActCar4
        '
        Me.lblActCar4.AutoSize = True
        Me.lblActCar4.Location = New System.Drawing.Point(3, 4)
        Me.lblActCar4.Name = "lblActCar4"
        Me.lblActCar4.Size = New System.Drawing.Size(48, 13)
        Me.lblActCar4.TabIndex = 30
        Me.lblActCar4.Text = "ActCar4:"
        '
        'pnlActCar5
        '
        Me.pnlActCar5.Controls.Add(Me.txtActCar5)
        Me.pnlActCar5.Controls.Add(Me.lblActCar5)
        Me.pnlActCar5.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlActCar5.Location = New System.Drawing.Point(0, 161)
        Me.pnlActCar5.Name = "pnlActCar5"
        Me.pnlActCar5.Size = New System.Drawing.Size(332, 23)
        Me.pnlActCar5.TabIndex = 50
        '
        'txtActCar5
        '
        Me.txtActCar5.Location = New System.Drawing.Point(146, 1)
        Me.txtActCar5.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActCar5.Mensaje = ""
        Me.txtActCar5.Name = "txtActCar5"
        Me.txtActCar5.PromptFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActCar5.PromptForeColor = System.Drawing.SystemColors.GrayText
        Me.txtActCar5.PromptText = ""
        Me.txtActCar5.Size = New System.Drawing.Size(181, 20)
        Me.txtActCar5.TabIndex = 31
        '
        'lblActCar5
        '
        Me.lblActCar5.AutoSize = True
        Me.lblActCar5.Location = New System.Drawing.Point(3, 4)
        Me.lblActCar5.Name = "lblActCar5"
        Me.lblActCar5.Size = New System.Drawing.Size(48, 13)
        Me.lblActCar5.TabIndex = 30
        Me.lblActCar5.Text = "ActCar5:"
        '
        'CtlCaracteristicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pnlActCar5)
        Me.Controls.Add(Me.pnlActCar4)
        Me.Controls.Add(Me.pnlActCar3)
        Me.Controls.Add(Me.pnlActCar2)
        Me.Controls.Add(Me.pnlActCar1)
        Me.Controls.Add(Me.pnlColor)
        Me.Controls.Add(Me.pnlMaterial)
        Me.Controls.Add(Me.pnlDimesion)
        Me.Name = "CtlCaracteristicas"
        Me.Size = New System.Drawing.Size(332, 184)
        Me.pnlDimesion.ResumeLayout(False)
        Me.pnlDimesion.PerformLayout()
        Me.pnlMaterial.ResumeLayout(False)
        Me.pnlMaterial.PerformLayout()
        Me.pnlColor.ResumeLayout(False)
        Me.pnlColor.PerformLayout()
        Me.pnlActCar1.ResumeLayout(False)
        Me.pnlActCar1.PerformLayout()
        Me.pnlActCar2.ResumeLayout(False)
        Me.pnlActCar2.PerformLayout()
        Me.pnlActCar3.ResumeLayout(False)
        Me.pnlActCar3.PerformLayout()
        Me.pnlActCar4.ResumeLayout(False)
        Me.pnlActCar4.PerformLayout()
        Me.pnlActCar5.ResumeLayout(False)
        Me.pnlActCar5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlDimesion As System.Windows.Forms.Panel
    Friend WithEvents txtDimesion As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents pnlMaterial As System.Windows.Forms.Panel
    Friend WithEvents txtMaterial As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents pnlColor As System.Windows.Forms.Panel
    Friend WithEvents txtColor As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents pnlActCar1 As System.Windows.Forms.Panel
    Friend WithEvents txtActCar1 As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblActCar1 As System.Windows.Forms.Label
    Friend WithEvents pnlActCar2 As System.Windows.Forms.Panel
    Friend WithEvents txtActCar2 As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblActCar2 As System.Windows.Forms.Label
    Friend WithEvents pnlActCar3 As System.Windows.Forms.Panel
    Friend WithEvents txtActCar3 As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblActCar3 As System.Windows.Forms.Label
    Friend WithEvents pnlActCar4 As System.Windows.Forms.Panel
    Friend WithEvents txtActCar4 As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblActCar4 As System.Windows.Forms.Label
    Friend WithEvents pnlActCar5 As System.Windows.Forms.Panel
    Friend WithEvents txtActCar5 As Infoware.Controles.Base.TextBoxStd
    Friend WithEvents lblActCar5 As System.Windows.Forms.Label

End Class
