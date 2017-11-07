<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUInicio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.TImporte = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPeliculas = New System.Windows.Forms.Button()
        Me.BtnDevoluciones = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BtnRenta = New System.Windows.Forms.Button()
        Me.BtnSocio = New System.Windows.Forms.Button()
        CType(Me.TImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TImporte
        '
        Me.TImporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TImporte.Location = New System.Drawing.Point(586, 75)
        Me.TImporte.Name = "TImporte"
        Me.TImporte.Size = New System.Drawing.Size(450, 400)
        Me.TImporte.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.LblNombre)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 545)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1095, 180)
        Me.Panel1.TabIndex = 18
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(530, 50)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(300, 100)
        Me.RichTextBox1.TabIndex = 11
        Me.RichTextBox1.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(530, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 22)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Adeudo(s):"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(280, 110)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(200, 20)
        Me.TextBox4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(178, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Vigente:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(280, 50)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(280, 80)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(94, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Apellido Materno:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido Paterno:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(322, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 22)
        Me.Label1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(280, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 2
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(157, 20)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(110, 22)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre(s):"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = Global.Video_Club.My.Resources.Resources.ImagenSocio
        Me.PictureBox1.Location = New System.Drawing.Point(875, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(160, 160)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnPeliculas
        '
        Me.BtnPeliculas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnPeliculas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnPeliculas.FlatAppearance.BorderSize = 0
        Me.BtnPeliculas.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPeliculas.Image = Global.Video_Club.My.Resources.Resources.BtnPagar
        Me.BtnPeliculas.Location = New System.Drawing.Point(326, 275)
        Me.BtnPeliculas.Name = "BtnPeliculas"
        Me.BtnPeliculas.Size = New System.Drawing.Size(125, 125)
        Me.BtnPeliculas.TabIndex = 17
        Me.BtnPeliculas.UseVisualStyleBackColor = False
        '
        'BtnDevoluciones
        '
        Me.BtnDevoluciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnDevoluciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnDevoluciones.FlatAppearance.BorderSize = 0
        Me.BtnDevoluciones.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnDevoluciones.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDevoluciones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDevoluciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDevoluciones.Image = Global.Video_Club.My.Resources.Resources.BtnDevoluciones
        Me.BtnDevoluciones.Location = New System.Drawing.Point(171, 275)
        Me.BtnDevoluciones.Name = "BtnDevoluciones"
        Me.BtnDevoluciones.Size = New System.Drawing.Size(125, 125)
        Me.BtnDevoluciones.TabIndex = 15
        Me.BtnDevoluciones.UseVisualStyleBackColor = False
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVenta.FlatAppearance.BorderSize = 0
        Me.BtnVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Image = Global.Video_Club.My.Resources.Resources.BtnVenta
        Me.BtnVenta.Location = New System.Drawing.Point(400, 125)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(125, 125)
        Me.BtnVenta.TabIndex = 13
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'BtnRenta
        '
        Me.BtnRenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRenta.FlatAppearance.BorderSize = 0
        Me.BtnRenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRenta.Image = Global.Video_Club.My.Resources.Resources.BtnRenta
        Me.BtnRenta.Location = New System.Drawing.Point(250, 125)
        Me.BtnRenta.Name = "BtnRenta"
        Me.BtnRenta.Size = New System.Drawing.Size(125, 125)
        Me.BtnRenta.TabIndex = 12
        Me.BtnRenta.UseVisualStyleBackColor = False
        '
        'BtnSocio
        '
        Me.BtnSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnSocio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSocio.FlatAppearance.BorderSize = 0
        Me.BtnSocio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSocio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSocio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSocio.Image = Global.Video_Club.My.Resources.Resources.BtnSocio
        Me.BtnSocio.Location = New System.Drawing.Point(100, 125)
        Me.BtnSocio.Name = "BtnSocio"
        Me.BtnSocio.Size = New System.Drawing.Size(125, 125)
        Me.BtnSocio.TabIndex = 11
        Me.BtnSocio.Text = " "
        Me.BtnSocio.UseVisualStyleBackColor = False
        '
        'CUInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnPeliculas)
        Me.Controls.Add(Me.BtnDevoluciones)
        Me.Controls.Add(Me.TImporte)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.BtnRenta)
        Me.Controls.Add(Me.BtnSocio)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "CUInicio"
        Me.Size = New System.Drawing.Size(1095, 725)
        CType(Me.TImporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnPeliculas As Button
    Friend WithEvents BtnDevoluciones As Button
    Friend WithEvents TImporte As DataGridView
    Friend WithEvents BtnVenta As Button
    Friend WithEvents BtnRenta As Button
    Friend WithEvents BtnSocio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
End Class
