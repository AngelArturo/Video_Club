<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdeudos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.renta = New System.Windows.Forms.ComboBox()
        Me.claveAdeudo = New System.Windows.Forms.TextBox()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.estatus = New System.Windows.Forms.ComboBox()
        Me.DGVadeudos = New System.Windows.Forms.DataGridView()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        CType(Me.DGVadeudos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ClaveAdeudo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(309, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(89, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Estatus "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(294, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Folio de Renta"
        '
        'renta
        '
        Me.renta.FormattingEnabled = True
        Me.renta.Location = New System.Drawing.Point(366, 81)
        Me.renta.Name = "renta"
        Me.renta.Size = New System.Drawing.Size(122, 21)
        Me.renta.TabIndex = 5
        '
        'claveAdeudo
        '
        Me.claveAdeudo.Enabled = False
        Me.claveAdeudo.Location = New System.Drawing.Point(161, 26)
        Me.claveAdeudo.Name = "claveAdeudo"
        Me.claveAdeudo.Size = New System.Drawing.Size(100, 20)
        Me.claveAdeudo.TabIndex = 6
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(388, 29)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(100, 20)
        Me.cantidad.TabIndex = 7
        '
        'estatus
        '
        Me.estatus.FormattingEnabled = True
        Me.estatus.Items.AddRange(New Object() {"Adeudo", "Pagado"})
        Me.estatus.Location = New System.Drawing.Point(161, 81)
        Me.estatus.Name = "estatus"
        Me.estatus.Size = New System.Drawing.Size(121, 21)
        Me.estatus.TabIndex = 9
        '
        'DGVadeudos
        '
        Me.DGVadeudos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVadeudos.Location = New System.Drawing.Point(22, 167)
        Me.DGVadeudos.Name = "DGVadeudos"
        Me.DGVadeudos.Size = New System.Drawing.Size(527, 157)
        Me.DGVadeudos.TabIndex = 10
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(334, 344)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 11
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'FrmAdeudos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(577, 391)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.DGVadeudos)
        Me.Controls.Add(Me.estatus)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.claveAdeudo)
        Me.Controls.Add(Me.renta)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmAdeudos"
        Me.Text = "FrmAdeudos"
        CType(Me.DGVadeudos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents renta As ComboBox
    Friend WithEvents claveAdeudo As TextBox
    Friend WithEvents cantidad As TextBox
    Friend WithEvents estatus As ComboBox
    Friend WithEvents DGVadeudos As DataGridView
    Friend WithEvents BtnGuardar As Button
End Class
