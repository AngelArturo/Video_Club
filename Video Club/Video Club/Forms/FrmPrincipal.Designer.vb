<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.BtnInicio = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SlidePanel = New System.Windows.Forms.Panel()
        Me.BtnCortedeCaja = New System.Windows.Forms.Button()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.BtnPeliculas = New System.Windows.Forms.Button()
        Me.BtnDistribuidor = New System.Windows.Forms.Button()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.CuDistribuidor1 = New Video_Club.CUDistribuidor()
        Me.CuPelicula1 = New Video_Club.CUPelicula()
        Me.CuEmpleado1 = New Video_Club.CUEmpleado()
        Me.CuInicio1 = New Video_Club.CUInicio()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.Transparent
        Me.X.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.X.FlatAppearance.BorderSize = 0
        Me.X.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.X.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.X.Image = CType(resources.GetObject("X.Image"), System.Drawing.Image)
        Me.X.Location = New System.Drawing.Point(1033, 1)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(25, 25)
        Me.X.TabIndex = 1
        Me.X.UseVisualStyleBackColor = False
        '
        'Minimizar
        '
        Me.Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimizar.FlatAppearance.BorderSize = 0
        Me.Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar.Image = Global.Video_Club.My.Resources.Resources.__
        Me.Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.Location = New System.Drawing.Point(999, 0)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'BtnInicio
        '
        Me.BtnInicio.FlatAppearance.BorderSize = 0
        Me.BtnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnInicio.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnInicio.Image = Global.Video_Club.My.Resources.Resources.LogoInicio
        Me.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnInicio.Location = New System.Drawing.Point(10, 200)
        Me.BtnInicio.Name = "BtnInicio"
        Me.BtnInicio.Size = New System.Drawing.Size(265, 60)
        Me.BtnInicio.TabIndex = 11
        Me.BtnInicio.Text = "     Inicio"
        Me.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInicio.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.SlidePanel)
        Me.Panel1.Controls.Add(Me.BtnCortedeCaja)
        Me.Panel1.Controls.Add(Me.BtnEmpleado)
        Me.Panel1.Controls.Add(Me.BtnPeliculas)
        Me.Panel1.Controls.Add(Me.BtnDistribuidor)
        Me.Panel1.Controls.Add(Me.BtnInicio)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 750)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Video_Club.My.Resources.Resources.Logo_VideoClub1
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(275, 200)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'SlidePanel
        '
        Me.SlidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.SlidePanel.Location = New System.Drawing.Point(0, 200)
        Me.SlidePanel.Name = "SlidePanel"
        Me.SlidePanel.Size = New System.Drawing.Size(10, 60)
        Me.SlidePanel.TabIndex = 16
        '
        'BtnCortedeCaja
        '
        Me.BtnCortedeCaja.FlatAppearance.BorderSize = 0
        Me.BtnCortedeCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCortedeCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnCortedeCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCortedeCaja.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCortedeCaja.Image = Global.Video_Club.My.Resources.Resources.LogoCortedecaja
        Me.BtnCortedeCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCortedeCaja.Location = New System.Drawing.Point(10, 440)
        Me.BtnCortedeCaja.Name = "BtnCortedeCaja"
        Me.BtnCortedeCaja.Size = New System.Drawing.Size(265, 60)
        Me.BtnCortedeCaja.TabIndex = 15
        Me.BtnCortedeCaja.Text = "     Corte de Caja"
        Me.BtnCortedeCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCortedeCaja.UseVisualStyleBackColor = True
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.FlatAppearance.BorderSize = 0
        Me.BtnEmpleado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnEmpleado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEmpleado.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEmpleado.Image = Global.Video_Club.My.Resources.Resources.LogoEmpleado
        Me.BtnEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEmpleado.Location = New System.Drawing.Point(10, 260)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(265, 60)
        Me.BtnEmpleado.TabIndex = 14
        Me.BtnEmpleado.Text = "     Empleado"
        Me.BtnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'BtnPeliculas
        '
        Me.BtnPeliculas.FlatAppearance.BorderSize = 0
        Me.BtnPeliculas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnPeliculas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnPeliculas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPeliculas.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPeliculas.Image = Global.Video_Club.My.Resources.Resources.LogoPelicula
        Me.BtnPeliculas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPeliculas.Location = New System.Drawing.Point(12, 320)
        Me.BtnPeliculas.Name = "BtnPeliculas"
        Me.BtnPeliculas.Size = New System.Drawing.Size(265, 60)
        Me.BtnPeliculas.TabIndex = 13
        Me.BtnPeliculas.Text = "     Películas"
        Me.BtnPeliculas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPeliculas.UseVisualStyleBackColor = True
        '
        'BtnDistribuidor
        '
        Me.BtnDistribuidor.FlatAppearance.BorderSize = 0
        Me.BtnDistribuidor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnDistribuidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BtnDistribuidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDistribuidor.Font = New System.Drawing.Font("Century Gothic", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDistribuidor.Image = Global.Video_Club.My.Resources.Resources.LogoDistribuidor
        Me.BtnDistribuidor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDistribuidor.Location = New System.Drawing.Point(12, 380)
        Me.BtnDistribuidor.Name = "BtnDistribuidor"
        Me.BtnDistribuidor.Size = New System.Drawing.Size(265, 60)
        Me.BtnDistribuidor.TabIndex = 12
        Me.BtnDistribuidor.Text = "     Distribuidor"
        Me.BtnDistribuidor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnDistribuidor.UseVisualStyleBackColor = True
        '
        'BarraTop
        '
        Me.BarraTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BarraTop.Controls.Add(Me.X)
        Me.BarraTop.Controls.Add(Me.Minimizar)
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(275, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(1095, 25)
        Me.BarraTop.TabIndex = 15
        '
        'CuDistribuidor1
        '
        Me.CuDistribuidor1.Location = New System.Drawing.Point(275, 25)
        Me.CuDistribuidor1.Name = "CuDistribuidor1"
        Me.CuDistribuidor1.Size = New System.Drawing.Size(1095, 725)
        Me.CuDistribuidor1.TabIndex = 19
        '
        'CuPelicula1
        '
        Me.CuPelicula1.Location = New System.Drawing.Point(275, 25)
        Me.CuPelicula1.Name = "CuPelicula1"
        Me.CuPelicula1.Size = New System.Drawing.Size(1095, 725)
        Me.CuPelicula1.TabIndex = 18
        '
        'CuEmpleado1
        '
        Me.CuEmpleado1.Location = New System.Drawing.Point(275, 25)
        Me.CuEmpleado1.Name = "CuEmpleado1"
        Me.CuEmpleado1.Size = New System.Drawing.Size(1095, 725)
        Me.CuEmpleado1.TabIndex = 17
        '
        'CuInicio1
        '
        Me.CuInicio1.ForeColor = System.Drawing.Color.Black
        Me.CuInicio1.Location = New System.Drawing.Point(275, 25)
        Me.CuInicio1.Name = "CuInicio1"
        Me.CuInicio1.Size = New System.Drawing.Size(1095, 725)
        Me.CuInicio1.TabIndex = 16
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.CuDistribuidor1)
        Me.Controls.Add(Me.CuPelicula1)
        Me.Controls.Add(Me.CuEmpleado1)
        Me.Controls.Add(Me.CuInicio1)
        Me.Controls.Add(Me.BarraTop)
        Me.Controls.Add(Me.Panel1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents BtnInicio As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarraTop As Panel
    Friend WithEvents BtnCortedeCaja As Button
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents BtnPeliculas As Button
    Friend WithEvents BtnDistribuidor As Button
    Friend WithEvents SlidePanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents CuInicio1 As CUInicio
    Friend WithEvents CuEmpleado1 As CUEmpleado
    Friend WithEvents CuPelicula1 As CUPelicula
    Friend WithEvents CuDistribuidor1 As CUDistribuidor
End Class
