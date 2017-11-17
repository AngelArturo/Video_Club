<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDevolucionVenta
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
        Me.com_pelicula = New System.Windows.Forms.ComboBox()
        Me.Pelicula = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVdevo = New System.Windows.Forms.DataGridView()
        Me.estado = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idD = New System.Windows.Forms.TextBox()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        CType(Me.DGVdevo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'com_pelicula
        '
        Me.com_pelicula.FormattingEnabled = True
        Me.com_pelicula.Location = New System.Drawing.Point(124, 60)
        Me.com_pelicula.Name = "com_pelicula"
        Me.com_pelicula.Size = New System.Drawing.Size(146, 21)
        Me.com_pelicula.TabIndex = 0
        '
        'Pelicula
        '
        Me.Pelicula.AutoSize = True
        Me.Pelicula.Location = New System.Drawing.Point(31, 60)
        Me.Pelicula.Name = "Pelicula"
        Me.Pelicula.Size = New System.Drawing.Size(44, 13)
        Me.Pelicula.TabIndex = 1
        Me.Pelicula.Text = "Pelicula"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Estado Pelicula"
        '
        'DGVdevo
        '
        Me.DGVdevo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdevo.Location = New System.Drawing.Point(12, 159)
        Me.DGVdevo.Name = "DGVdevo"
        Me.DGVdevo.Size = New System.Drawing.Size(487, 130)
        Me.DGVdevo.TabIndex = 4
        '
        'estado
        '
        Me.estado.FormattingEnabled = True
        Me.estado.Items.AddRange(New Object() {"Dañada"})
        Me.estado.Location = New System.Drawing.Point(124, 105)
        Me.estado.Name = "estado"
        Me.estado.Size = New System.Drawing.Size(146, 21)
        Me.estado.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FolioDevolucion"
        '
        'idD
        '
        Me.idD.Enabled = False
        Me.idD.Location = New System.Drawing.Point(124, 34)
        Me.idD.Name = "idD"
        Me.idD.Size = New System.Drawing.Size(100, 20)
        Me.idD.TabIndex = 8
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Cancelar.Image = Global.Video_Club.My.Resources.Resources.btnCancelar
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Cancelar.Location = New System.Drawing.Point(81, 295)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Cancelar.TabIndex = 69
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Guardar.FlatAppearance.BorderSize = 0
        Me.Btn_Guardar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(286, 295)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 68
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'FrmDevolucionVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 357)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.idD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.estado)
        Me.Controls.Add(Me.DGVdevo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pelicula)
        Me.Controls.Add(Me.com_pelicula)
        Me.Name = "FrmDevolucionVenta"
        Me.Text = "FrmDevolucionVenta"
        CType(Me.DGVdevo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents com_pelicula As ComboBox
    Friend WithEvents Pelicula As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DGVdevo As DataGridView
    Friend WithEvents estado As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idD As TextBox
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Guardar As Button
End Class
