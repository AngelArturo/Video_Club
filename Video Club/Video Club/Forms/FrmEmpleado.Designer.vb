<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmpleado))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tipoU = New System.Windows.Forms.TextBox()
        Me.contrasena = New System.Windows.Forms.TextBox()
        Me.nombreUsuario = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.codigoP = New System.Windows.Forms.TextBox()
        Me.celular = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.colonia = New System.Windows.Forms.TextBox()
        Me.numero = New System.Windows.Forms.TextBox()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.lugarN = New System.Windows.Forms.TextBox()
        Me.genero = New System.Windows.Forms.ComboBox()
        Me.ano = New System.Windows.Forms.TextBox()
        Me.mes = New System.Windows.Forms.ComboBox()
        Me.dia = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.paterno = New System.Windows.Forms.TextBox()
        Me.claveEm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGVempleados = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tipoU)
        Me.GroupBox2.Controls.Add(Me.contrasena)
        Me.GroupBox2.Controls.Add(Me.nombreUsuario)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(570, 50)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 140)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la cuenta"
        '
        'tipoU
        '
        Me.tipoU.Location = New System.Drawing.Point(152, 103)
        Me.tipoU.Name = "tipoU"
        Me.tipoU.Size = New System.Drawing.Size(149, 23)
        Me.tipoU.TabIndex = 6
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(152, 74)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(149, 23)
        Me.contrasena.TabIndex = 5
        '
        'nombreUsuario
        '
        Me.nombreUsuario.Location = New System.Drawing.Point(152, 40)
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(149, 23)
        Me.nombreUsuario.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(25, 100)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(130, 21)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Tipo de usuario:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(48, 70)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 21)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Contraseña:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 40)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(96, 21)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "No.Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.correo)
        Me.GroupBox1.Controls.Add(Me.codigoP)
        Me.GroupBox1.Controls.Add(Me.celular)
        Me.GroupBox1.Controls.Add(Me.telefono)
        Me.GroupBox1.Controls.Add(Me.colonia)
        Me.GroupBox1.Controls.Add(Me.numero)
        Me.GroupBox1.Controls.Add(Me.calle)
        Me.GroupBox1.Controls.Add(Me.lugarN)
        Me.GroupBox1.Controls.Add(Me.genero)
        Me.GroupBox1.Controls.Add(Me.ano)
        Me.GroupBox1.Controls.Add(Me.mes)
        Me.GroupBox1.Controls.Add(Me.dia)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.paterno)
        Me.GroupBox1.Controls.Add(Me.claveEm)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(50, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(500, 500)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(151, 451)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(197, 23)
        Me.correo.TabIndex = 31
        '
        'codigoP
        '
        Me.codigoP.Location = New System.Drawing.Point(153, 420)
        Me.codigoP.Name = "codigoP"
        Me.codigoP.Size = New System.Drawing.Size(197, 23)
        Me.codigoP.TabIndex = 30
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(151, 393)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(197, 23)
        Me.celular.TabIndex = 29
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(151, 364)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(197, 23)
        Me.telefono.TabIndex = 28
        '
        'colonia
        '
        Me.colonia.Location = New System.Drawing.Point(366, 301)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(120, 23)
        Me.colonia.TabIndex = 27
        Me.colonia.Text = "colonia"
        '
        'numero
        '
        Me.numero.Location = New System.Drawing.Point(260, 301)
        Me.numero.Name = "numero"
        Me.numero.Size = New System.Drawing.Size(100, 23)
        Me.numero.TabIndex = 26
        Me.numero.Text = "numero"
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(108, 301)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(146, 23)
        Me.calle.TabIndex = 25
        Me.calle.Text = "calle"
        '
        'lugarN
        '
        Me.lugarN.Location = New System.Drawing.Point(381, 270)
        Me.lugarN.Name = "lugarN"
        Me.lugarN.Size = New System.Drawing.Size(100, 23)
        Me.lugarN.TabIndex = 24
        '
        'genero
        '
        Me.genero.AutoCompleteCustomSource.AddRange(New String() {"F", "M"})
        Me.genero.FormattingEnabled = True
        Me.genero.Items.AddRange(New Object() {"F", "M"})
        Me.genero.Location = New System.Drawing.Point(96, 270)
        Me.genero.Name = "genero"
        Me.genero.Size = New System.Drawing.Size(104, 25)
        Me.genero.TabIndex = 23
        Me.genero.Text = "Seleccione"
        '
        'ano
        '
        Me.ano.Location = New System.Drawing.Point(381, 240)
        Me.ano.Name = "ano"
        Me.ano.Size = New System.Drawing.Size(60, 23)
        Me.ano.TabIndex = 22
        Me.ano.Text = "aaa"
        '
        'mes
        '
        Me.mes.FormattingEnabled = True
        Me.mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.mes.Location = New System.Drawing.Point(274, 239)
        Me.mes.Name = "mes"
        Me.mes.Size = New System.Drawing.Size(100, 25)
        Me.mes.TabIndex = 21
        Me.mes.Text = "Mes"
        '
        'dia
        '
        Me.dia.Location = New System.Drawing.Point(210, 240)
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(57, 23)
        Me.dia.TabIndex = 20
        Me.dia.Text = "dd"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(175, 193)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(173, 23)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(175, 164)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(173, 23)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(175, 137)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(173, 23)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(175, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 23)
        Me.TextBox1.TabIndex = 16
        '
        'paterno
        '
        Me.paterno.Location = New System.Drawing.Point(175, 73)
        Me.paterno.Name = "paterno"
        Me.paterno.Size = New System.Drawing.Size(173, 23)
        Me.paterno.TabIndex = 15
        '
        'claveEm
        '
        Me.claveEm.Enabled = False
        Me.claveEm.Location = New System.Drawing.Point(396, 41)
        Me.claveEm.Name = "claveEm"
        Me.claveEm.Size = New System.Drawing.Size(90, 23)
        Me.claveEm.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(25, 450)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 390)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "No.Celular:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(199, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(176, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Lugar de nacimiento:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(25, 420)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(122, 21)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Código Postal:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(25, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(183, 21)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Fecha de Nacimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No.Teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(25, 300)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Domicilio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Apellido Paterno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(28, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(83, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre(s):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(121, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CURP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(133, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RFC:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 270)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Género:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(339, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'DGVempleados
        '
        Me.DGVempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVempleados.Location = New System.Drawing.Point(556, 205)
        Me.DGVempleados.Name = "DGVempleados"
        Me.DGVempleados.Size = New System.Drawing.Size(341, 341)
        Me.DGVempleados.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(680, 570)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(125, 50)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'BarraTop
        '
        Me.BarraTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BarraTop.Controls.Add(Me.Button1)
        Me.BarraTop.Controls.Add(Me.Button2)
        Me.BarraTop.Controls.Add(Me.X)
        Me.BarraTop.Controls.Add(Me.Minimizar)
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(0, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(950, 25)
        Me.BarraTop.TabIndex = 16
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
        Me.X.Location = New System.Drawing.Point(1063, 1)
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
        Me.Minimizar.Location = New System.Drawing.Point(1029, 1)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(906, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Video_Club.My.Resources.Resources.__
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(872, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(950, 650)
        Me.Controls.Add(Me.BarraTop)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.DGVempleados)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleado"
        Me.Text = "FrmEmpleado"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraTop.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dia As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents paterno As TextBox
    Friend WithEvents claveEm As TextBox
    Friend WithEvents lugarN As TextBox
    Friend WithEvents genero As ComboBox
    Friend WithEvents ano As TextBox
    Friend WithEvents mes As ComboBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents colonia As TextBox
    Friend WithEvents numero As TextBox
    Friend WithEvents calle As TextBox
    Friend WithEvents tipoU As TextBox
    Friend WithEvents contrasena As TextBox
    Friend WithEvents nombreUsuario As TextBox
    Friend WithEvents correo As TextBox
    Friend WithEvents codigoP As TextBox
    Friend WithEvents celular As TextBox
    Friend WithEvents DGVempleados As DataGridView
    Friend WithEvents btnGuardar As Button
    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
