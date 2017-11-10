<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddPelicula
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddPelicula))
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Minimizar1 = New System.Windows.Forms.Button()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.nombrePelicula = New System.Windows.Forms.TextBox()
        Me.Lbl_id = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Celular = New System.Windows.Forms.Label()
        Me.Lbl_Correo = New System.Windows.Forms.Label()
        Me.Lbl_Encargado = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Lbl_NombreDistribuior = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idP = New System.Windows.Forms.TextBox()
        Me.gnero = New System.Windows.Forms.ComboBox()
        Me.clasificacion = New System.Windows.Forms.ComboBox()
        Me.fechaAd = New System.Windows.Forms.DateTimePicker()
        Me.comb_distribuidor = New System.Windows.Forms.ComboBox()
        Me.DGVpeliculas = New System.Windows.Forms.DataGridView()
        Me.BarraTop.SuspendLayout()
        CType(Me.DGVpeliculas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar.FlatAppearance.BorderSize = 0
        Me.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
        Me.Cerrar.Location = New System.Drawing.Point(770, 0)
        Me.Cerrar.Name = "Cerrar"
        Me.Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Cerrar.TabIndex = 3
        Me.Cerrar.UseVisualStyleBackColor = False
        '
        'Minimizar1
        '
        Me.Minimizar1.BackColor = System.Drawing.Color.Transparent
        Me.Minimizar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Minimizar1.FlatAppearance.BorderSize = 0
        Me.Minimizar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Minimizar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Minimizar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minimizar1.Image = Global.Video_Club.My.Resources.Resources.__
        Me.Minimizar1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar1.Location = New System.Drawing.Point(737, 1)
        Me.Minimizar1.Name = "Minimizar1"
        Me.Minimizar1.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar1.TabIndex = 4
        Me.Minimizar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar1.UseVisualStyleBackColor = False
        '
        'BarraTop
        '
        Me.BarraTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BarraTop.Controls.Add(Me.Cerrar)
        Me.BarraTop.Controls.Add(Me.Minimizar1)
        Me.BarraTop.Controls.Add(Me.X)
        Me.BarraTop.Controls.Add(Me.Minimizar)
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(0, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(800, 25)
        Me.BarraTop.TabIndex = 17
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
        'nombrePelicula
        '
        Me.nombrePelicula.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombrePelicula.Location = New System.Drawing.Point(250, 100)
        Me.nombrePelicula.Name = "nombrePelicula"
        Me.nombrePelicula.Size = New System.Drawing.Size(490, 24)
        Me.nombrePelicula.TabIndex = 81
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.Location = New System.Drawing.Point(600, 50)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(31, 21)
        Me.Lbl_id.TabIndex = 80
        Me.Lbl_id.Text = "ID:"
        '
        'Btn_Cancelar
        '
        Me.Btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Cancelar.FlatAppearance.BorderSize = 0
        Me.Btn_Cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Cancelar.Image = Global.Video_Club.My.Resources.Resources.btnCancelar
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Cancelar.Location = New System.Drawing.Point(222, 499)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Cancelar.TabIndex = 79
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
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(427, 499)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 78
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefono.Location = New System.Drawing.Point(537, 140)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(112, 21)
        Me.Lbl_Telefono.TabIndex = 73
        Me.Lbl_Telefono.Text = "Clasificación:"
        '
        'Lbl_Celular
        '
        Me.Lbl_Celular.AutoSize = True
        Me.Lbl_Celular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Celular.Location = New System.Drawing.Point(50, 180)
        Me.Lbl_Celular.Name = "Lbl_Celular"
        Me.Lbl_Celular.Size = New System.Drawing.Size(145, 21)
        Me.Lbl_Celular.TabIndex = 72
        Me.Lbl_Celular.Text = "Feha adquisición:"
        '
        'Lbl_Correo
        '
        Me.Lbl_Correo.AutoSize = True
        Me.Lbl_Correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Correo.Location = New System.Drawing.Point(423, 180)
        Me.Lbl_Correo.Name = "Lbl_Correo"
        Me.Lbl_Correo.Size = New System.Drawing.Size(107, 21)
        Me.Lbl_Correo.TabIndex = 71
        Me.Lbl_Correo.Text = "Distrubuidor:"
        '
        'Lbl_Encargado
        '
        Me.Lbl_Encargado.AutoSize = True
        Me.Lbl_Encargado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Encargado.Location = New System.Drawing.Point(50, 140)
        Me.Lbl_Encargado.Name = "Lbl_Encargado"
        Me.Lbl_Encargado.Size = New System.Drawing.Size(73, 21)
        Me.Lbl_Encargado.TabIndex = 70
        Me.Lbl_Encargado.Text = "Género:"
        '
        'cantidad
        '
        Me.cantidad.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidad.Location = New System.Drawing.Point(443, 140)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(53, 24)
        Me.cantidad.TabIndex = 69
        '
        'Lbl_NombreDistribuior
        '
        Me.Lbl_NombreDistribuior.AutoSize = True
        Me.Lbl_NombreDistribuior.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreDistribuior.Location = New System.Drawing.Point(50, 100)
        Me.Lbl_NombreDistribuior.Name = "Lbl_NombreDistribuior"
        Me.Lbl_NombreDistribuior.Size = New System.Drawing.Size(185, 21)
        Me.Lbl_NombreDistribuior.TabIndex = 68
        Me.Lbl_NombreDistribuior.Text = "Nombre de la película:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(346, 140)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 21)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Cantidad:"
        '
        'idP
        '
        Me.idP.Enabled = False
        Me.idP.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idP.Location = New System.Drawing.Point(630, 47)
        Me.idP.Name = "idP"
        Me.idP.Size = New System.Drawing.Size(110, 24)
        Me.idP.TabIndex = 83
        '
        'gnero
        '
        Me.gnero.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gnero.FormattingEnabled = True
        Me.gnero.Items.AddRange(New Object() {"Terror", "Comedia", "Drama"})
        Me.gnero.Location = New System.Drawing.Point(130, 140)
        Me.gnero.Name = "gnero"
        Me.gnero.Size = New System.Drawing.Size(177, 25)
        Me.gnero.TabIndex = 84
        '
        'clasificacion
        '
        Me.clasificacion.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clasificacion.FormattingEnabled = True
        Me.clasificacion.Items.AddRange(New Object() {"A", "B", "C"})
        Me.clasificacion.Location = New System.Drawing.Point(652, 140)
        Me.clasificacion.Name = "clasificacion"
        Me.clasificacion.Size = New System.Drawing.Size(87, 25)
        Me.clasificacion.TabIndex = 85
        '
        'fechaAd
        '
        Me.fechaAd.Location = New System.Drawing.Point(200, 180)
        Me.fechaAd.Name = "fechaAd"
        Me.fechaAd.Size = New System.Drawing.Size(200, 20)
        Me.fechaAd.TabIndex = 86
        '
        'comb_distribuidor
        '
        Me.comb_distribuidor.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comb_distribuidor.FormattingEnabled = True
        Me.comb_distribuidor.Location = New System.Drawing.Point(536, 180)
        Me.comb_distribuidor.Name = "comb_distribuidor"
        Me.comb_distribuidor.Size = New System.Drawing.Size(203, 25)
        Me.comb_distribuidor.TabIndex = 87
        '
        'DGVpeliculas
        '
        Me.DGVpeliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVpeliculas.Location = New System.Drawing.Point(54, 238)
        Me.DGVpeliculas.Name = "DGVpeliculas"
        Me.DGVpeliculas.Size = New System.Drawing.Size(699, 214)
        Me.DGVpeliculas.TabIndex = 88
        '
        'FrmAddPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(800, 591)
        Me.Controls.Add(Me.DGVpeliculas)
        Me.Controls.Add(Me.comb_distribuidor)
        Me.Controls.Add(Me.fechaAd)
        Me.Controls.Add(Me.clasificacion)
        Me.Controls.Add(Me.gnero)
        Me.Controls.Add(Me.idP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nombrePelicula)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Lbl_Telefono)
        Me.Controls.Add(Me.Lbl_Celular)
        Me.Controls.Add(Me.Lbl_Correo)
        Me.Controls.Add(Me.Lbl_Encargado)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.Lbl_NombreDistribuior)
        Me.Controls.Add(Me.BarraTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAddPelicula"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddPelicula"
        Me.BarraTop.ResumeLayout(False)
        CType(Me.DGVpeliculas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cerrar As Button
    Friend WithEvents Minimizar1 As Button
    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents nombrePelicula As TextBox
    Friend WithEvents Lbl_id As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Celular As Label
    Friend WithEvents Lbl_Correo As Label
    Friend WithEvents Lbl_Encargado As Label
    Friend WithEvents cantidad As TextBox
    Friend WithEvents Lbl_NombreDistribuior As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idP As TextBox
    Friend WithEvents gnero As ComboBox
    Friend WithEvents clasificacion As ComboBox
    Friend WithEvents fechaAd As DateTimePicker
    Friend WithEvents comb_distribuidor As ComboBox
    Friend WithEvents DGVpeliculas As DataGridView
End Class
