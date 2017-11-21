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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.Lbl_LugarNacimiento = New System.Windows.Forms.Label()
        Me.Lbl_FechaNacimiento = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lbl_Genero = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGVempleados = New System.Windows.Forms.DataGridView()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Btn_Imprimir)
        Me.GroupBox2.Controls.Add(Me.tipoU)
        Me.GroupBox2.Controls.Add(Me.contrasena)
        Me.GroupBox2.Controls.Add(Me.btnGuardar)
        Me.GroupBox2.Controls.Add(Me.nombreUsuario)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(827, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 248)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos de la cuenta"
        '
        'tipoU
        '
        Me.tipoU.Location = New System.Drawing.Point(152, 103)
        Me.tipoU.Name = "tipoU"
        Me.tipoU.Size = New System.Drawing.Size(150, 23)
        Me.tipoU.TabIndex = 6
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(152, 74)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(150, 23)
        Me.contrasena.TabIndex = 5
        '
        'nombreUsuario
        '
        Me.nombreUsuario.Location = New System.Drawing.Point(152, 40)
        Me.nombreUsuario.Name = "nombreUsuario"
        Me.nombreUsuario.Size = New System.Drawing.Size(150, 23)
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
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
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
        Me.GroupBox1.Controls.Add(Me.Lbl_LugarNacimiento)
        Me.GroupBox1.Controls.Add(Me.Lbl_FechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Lbl_Genero)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Lbl)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 380)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1150, 270)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(510, 190)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(190, 23)
        Me.correo.TabIndex = 31
        '
        'codigoP
        '
        Me.codigoP.Location = New System.Drawing.Point(745, 99)
        Me.codigoP.Name = "codigoP"
        Me.codigoP.Size = New System.Drawing.Size(55, 23)
        Me.codigoP.TabIndex = 30
        Me.codigoP.Text = "C.P."
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(510, 160)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(190, 23)
        Me.celular.TabIndex = 29
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(510, 130)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(190, 23)
        Me.telefono.TabIndex = 28
        '
        'colonia
        '
        Me.colonia.Location = New System.Drawing.Point(630, 100)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(110, 23)
        Me.colonia.TabIndex = 27
        Me.colonia.Text = "colonia"
        '
        'numero
        '
        Me.numero.Location = New System.Drawing.Point(575, 100)
        Me.numero.Name = "numero"
        Me.numero.Size = New System.Drawing.Size(50, 23)
        Me.numero.TabIndex = 26
        Me.numero.Text = "####"
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(445, 100)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(125, 23)
        Me.calle.TabIndex = 25
        Me.calle.Text = "Calle"
        '
        'lugarN
        '
        Me.lugarN.Location = New System.Drawing.Point(650, 70)
        Me.lugarN.Name = "lugarN"
        Me.lugarN.Size = New System.Drawing.Size(150, 23)
        Me.lugarN.TabIndex = 24
        '
        'genero
        '
        Me.genero.AutoCompleteCustomSource.AddRange(New String() {"F", "M"})
        Me.genero.FormattingEnabled = True
        Me.genero.Items.AddRange(New Object() {"F", "M"})
        Me.genero.Location = New System.Drawing.Point(435, 70)
        Me.genero.Name = "genero"
        Me.genero.Size = New System.Drawing.Size(35, 25)
        Me.genero.TabIndex = 23
        Me.genero.Text = "M"
        '
        'ano
        '
        Me.ano.Location = New System.Drawing.Point(695, 40)
        Me.ano.Name = "ano"
        Me.ano.Size = New System.Drawing.Size(45, 23)
        Me.ano.TabIndex = 22
        Me.ano.Text = "aaaa"
        '
        'mes
        '
        Me.mes.FormattingEnabled = True
        Me.mes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.mes.Location = New System.Drawing.Point(582, 40)
        Me.mes.Name = "mes"
        Me.mes.Size = New System.Drawing.Size(100, 25)
        Me.mes.TabIndex = 21
        Me.mes.Text = "Mes"
        '
        'dia
        '
        Me.dia.Location = New System.Drawing.Point(545, 40)
        Me.dia.Name = "dia"
        Me.dia.Size = New System.Drawing.Size(25, 23)
        Me.dia.TabIndex = 20
        Me.dia.Text = "dd"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(185, 190)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(150, 23)
        Me.TextBox4.TabIndex = 19
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(185, 160)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(150, 23)
        Me.TextBox3.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(185, 130)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(150, 23)
        Me.TextBox2.TabIndex = 17
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(185, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(150, 23)
        Me.TextBox1.TabIndex = 16
        '
        'paterno
        '
        Me.paterno.Location = New System.Drawing.Point(185, 70)
        Me.paterno.Name = "paterno"
        Me.paterno.Size = New System.Drawing.Size(150, 23)
        Me.paterno.TabIndex = 15
        '
        'claveEm
        '
        Me.claveEm.Enabled = False
        Me.claveEm.Location = New System.Drawing.Point(245, 22)
        Me.claveEm.Name = "claveEm"
        Me.claveEm.Size = New System.Drawing.Size(90, 23)
        Me.claveEm.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(439, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 21)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Correo:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(411, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "No.Celular:"
        '
        'Lbl_LugarNacimiento
        '
        Me.Lbl_LugarNacimiento.AutoSize = True
        Me.Lbl_LugarNacimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_LugarNacimiento.Location = New System.Drawing.Point(475, 70)
        Me.Lbl_LugarNacimiento.Name = "Lbl_LugarNacimiento"
        Me.Lbl_LugarNacimiento.Size = New System.Drawing.Size(176, 21)
        Me.Lbl_LugarNacimiento.TabIndex = 11
        Me.Lbl_LugarNacimiento.Text = "Lugar de nacimiento:"
        '
        'Lbl_FechaNacimiento
        '
        Me.Lbl_FechaNacimiento.AutoSize = True
        Me.Lbl_FechaNacimiento.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_FechaNacimiento.Location = New System.Drawing.Point(360, 40)
        Me.Lbl_FechaNacimiento.Name = "Lbl_FechaNacimiento"
        Me.Lbl_FechaNacimiento.Size = New System.Drawing.Size(183, 21)
        Me.Lbl_FechaNacimiento.TabIndex = 9
        Me.Lbl_FechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(400, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "No.Teléfono:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Domicilio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(36, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Apellido Paterno:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Apellido Materno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(85, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nombre(s):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(123, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CURP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(135, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "RFC:"
        '
        'Lbl_Genero
        '
        Me.Lbl_Genero.AutoSize = True
        Me.Lbl_Genero.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Genero.Location = New System.Drawing.Point(360, 70)
        Me.Lbl_Genero.Name = "Lbl_Genero"
        Me.Lbl_Genero.Size = New System.Drawing.Size(73, 21)
        Me.Lbl_Genero.TabIndex = 1
        Me.Lbl_Genero.Text = "Género:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave:"
        '
        'Lbl
        '
        Me.Lbl.AutoSize = True
        Me.Lbl.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl.Location = New System.Drawing.Point(567, 40)
        Me.Lbl.Name = "Lbl"
        Me.Lbl.Size = New System.Drawing.Size(17, 21)
        Me.Lbl.TabIndex = 32
        Me.Lbl.Text = "/"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(680, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 21)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "/"
        '
        'DGVempleados
        '
        Me.DGVempleados.BackgroundColor = System.Drawing.Color.White
        Me.DGVempleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVempleados.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVempleados.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGVempleados.EnableHeadersVisualStyles = False
        Me.DGVempleados.Location = New System.Drawing.Point(60, 60)
        Me.DGVempleados.Name = "DGVempleados"
        Me.DGVempleados.RowHeadersVisible = False
        Me.DGVempleados.Size = New System.Drawing.Size(1030, 300)
        Me.DGVempleados.TabIndex = 5
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Font = New System.Drawing.Font("Fineliner Script", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnGuardar.Location = New System.Drawing.Point(177, 156)
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
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(0, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(1150, 25)
        Me.BarraTop.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1125, 0)
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
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.Video_Club.My.Resources.Resources.__
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.Location = New System.Drawing.Point(1091, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(25, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Imprimir.FlatAppearance.BorderSize = 0
        Me.Btn_Imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Fineliner Script", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Btn_Imprimir.Image = Global.Video_Club.My.Resources.Resources.BtnImprimir
        Me.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Imprimir.Location = New System.Drawing.Point(29, 157)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Imprimir.TabIndex = 80
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Imprimir.UseVisualStyleBackColor = False
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(1150, 650)
        Me.Controls.Add(Me.BarraTop)
        Me.Controls.Add(Me.DGVempleados)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Lbl_LugarNacimiento As Label
    Friend WithEvents Lbl_FechaNacimiento As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Lbl_Genero As Label
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Btn_Imprimir As Button
End Class
