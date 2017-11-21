<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAddDistribuidor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAddDistribuidor))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.Cerrar = New System.Windows.Forms.Button()
        Me.Minimizar1 = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Lbl_NombreDistribuior = New System.Windows.Forms.Label()
        Me.Txt_NombreDistribuidor = New System.Windows.Forms.TextBox()
        Me.Lbl_Encargado = New System.Windows.Forms.Label()
        Me.Lbl_Correo = New System.Windows.Forms.Label()
        Me.Lbl_Celular = New System.Windows.Forms.Label()
        Me.Lbl_Telefono = New System.Windows.Forms.Label()
        Me.Lbl_Direccion = New System.Windows.Forms.Label()
        Me.Txt_Encargado = New System.Windows.Forms.TextBox()
        Me.RichTxt_Direccion = New System.Windows.Forms.RichTextBox()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Txt_Celular = New System.Windows.Forms.TextBox()
        Me.Txt_Correo = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Imprimir = New System.Windows.Forms.Button()
        Me.Lbl_id = New System.Windows.Forms.Label()
        Me.Txt_ID = New System.Windows.Forms.TextBox()
        Me.DGVdistri = New System.Windows.Forms.DataGridView()
        Me.BarraTop.SuspendLayout()
        CType(Me.DGVdistri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarraTop.Size = New System.Drawing.Size(900, 25)
        Me.BarraTop.TabIndex = 16
        '
        'Cerrar
        '
        Me.Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Cerrar.Dock = System.Windows.Forms.DockStyle.Right
        Me.Cerrar.FlatAppearance.BorderSize = 0
        Me.Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cerrar.Image = CType(resources.GetObject("Cerrar.Image"), System.Drawing.Image)
        Me.Cerrar.Location = New System.Drawing.Point(875, 0)
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
        Me.Minimizar1.Location = New System.Drawing.Point(842, 3)
        Me.Minimizar1.Name = "Minimizar1"
        Me.Minimizar1.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar1.TabIndex = 4
        Me.Minimizar1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar1.UseVisualStyleBackColor = False
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
        'Lbl_NombreDistribuior
        '
        Me.Lbl_NombreDistribuior.AutoSize = True
        Me.Lbl_NombreDistribuior.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NombreDistribuior.Location = New System.Drawing.Point(32, 130)
        Me.Lbl_NombreDistribuior.Name = "Lbl_NombreDistribuior"
        Me.Lbl_NombreDistribuior.Size = New System.Drawing.Size(100, 21)
        Me.Lbl_NombreDistribuior.TabIndex = 40
        Me.Lbl_NombreDistribuior.Text = "Distribuidor:"
        '
        'Txt_NombreDistribuidor
        '
        Me.Txt_NombreDistribuidor.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreDistribuidor.Location = New System.Drawing.Point(135, 130)
        Me.Txt_NombreDistribuidor.Name = "Txt_NombreDistribuidor"
        Me.Txt_NombreDistribuidor.Size = New System.Drawing.Size(200, 24)
        Me.Txt_NombreDistribuidor.TabIndex = 51
        '
        'Lbl_Encargado
        '
        Me.Lbl_Encargado.AutoSize = True
        Me.Lbl_Encargado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Encargado.Location = New System.Drawing.Point(30, 160)
        Me.Lbl_Encargado.Name = "Lbl_Encargado"
        Me.Lbl_Encargado.Size = New System.Drawing.Size(102, 21)
        Me.Lbl_Encargado.TabIndex = 52
        Me.Lbl_Encargado.Text = "Encargado:"
        '
        'Lbl_Correo
        '
        Me.Lbl_Correo.AutoSize = True
        Me.Lbl_Correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Correo.Location = New System.Drawing.Point(65, 340)
        Me.Lbl_Correo.Name = "Lbl_Correo"
        Me.Lbl_Correo.Size = New System.Drawing.Size(67, 21)
        Me.Lbl_Correo.TabIndex = 54
        Me.Lbl_Correo.Text = "Correo:"
        '
        'Lbl_Celular
        '
        Me.Lbl_Celular.AutoSize = True
        Me.Lbl_Celular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Celular.Location = New System.Drawing.Point(63, 310)
        Me.Lbl_Celular.Name = "Lbl_Celular"
        Me.Lbl_Celular.Size = New System.Drawing.Size(69, 21)
        Me.Lbl_Celular.TabIndex = 55
        Me.Lbl_Celular.Text = "Celular:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefono.Location = New System.Drawing.Point(52, 280)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(80, 21)
        Me.Lbl_Telefono.TabIndex = 56
        Me.Lbl_Telefono.Text = "Teléfono:"
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.AutoSize = True
        Me.Lbl_Direccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Direccion.Location = New System.Drawing.Point(45, 190)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(87, 21)
        Me.Lbl_Direccion.TabIndex = 57
        Me.Lbl_Direccion.Text = "Dirección:"
        '
        'Txt_Encargado
        '
        Me.Txt_Encargado.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Encargado.Location = New System.Drawing.Point(135, 160)
        Me.Txt_Encargado.Name = "Txt_Encargado"
        Me.Txt_Encargado.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Encargado.TabIndex = 58
        '
        'RichTxt_Direccion
        '
        Me.RichTxt_Direccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTxt_Direccion.Location = New System.Drawing.Point(135, 190)
        Me.RichTxt_Direccion.Name = "RichTxt_Direccion"
        Me.RichTxt_Direccion.Size = New System.Drawing.Size(200, 85)
        Me.RichTxt_Direccion.TabIndex = 60
        Me.RichTxt_Direccion.Text = "Calle, #Exterior, #Interior, Colonia, C.P"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telefono.Location = New System.Drawing.Point(135, 280)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Telefono.TabIndex = 61
        '
        'Txt_Celular
        '
        Me.Txt_Celular.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Celular.Location = New System.Drawing.Point(135, 310)
        Me.Txt_Celular.MaxLength = 12
        Me.Txt_Celular.Name = "Txt_Celular"
        Me.Txt_Celular.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Celular.TabIndex = 62
        '
        'Txt_Correo
        '
        Me.Txt_Correo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Correo.Location = New System.Drawing.Point(135, 340)
        Me.Txt_Correo.Name = "Txt_Correo"
        Me.Txt_Correo.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Correo.TabIndex = 63
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
        Me.Btn_Guardar.Font = New System.Drawing.Font("Fineliner Script", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(510, 420)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 64
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Imprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Imprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Btn_Imprimir.FlatAppearance.BorderSize = 0
        Me.Btn_Imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Imprimir.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Imprimir.ForeColor = System.Drawing.Color.Black
        Me.Btn_Imprimir.Image = Global.Video_Club.My.Resources.Resources.BtnImprimir
        Me.Btn_Imprimir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Imprimir.Location = New System.Drawing.Point(265, 420)
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Imprimir.TabIndex = 65
        Me.Btn_Imprimir.Text = "Imprimir"
        Me.Btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Imprimir.UseVisualStyleBackColor = False
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.Location = New System.Drawing.Point(101, 100)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(31, 21)
        Me.Lbl_id.TabIndex = 66
        Me.Lbl_id.Text = "ID:"
        '
        'Txt_ID
        '
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(135, 100)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(200, 24)
        Me.Txt_ID.TabIndex = 67
        '
        'DGVdistri
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdistri.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVdistri.BackgroundColor = System.Drawing.Color.White
        Me.DGVdistri.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DGVdistri.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVdistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdistri.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVdistri.EnableHeadersVisualStyles = False
        Me.DGVdistri.GridColor = System.Drawing.Color.Black
        Me.DGVdistri.Location = New System.Drawing.Point(370, 60)
        Me.DGVdistri.Name = "DGVdistri"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdistri.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVdistri.RowHeadersVisible = False
        Me.DGVdistri.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DGVdistri.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White
        Me.DGVdistri.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGVdistri.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.DGVdistri.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DGVdistri.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black
        Me.DGVdistri.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVdistri.Size = New System.Drawing.Size(498, 340)
        Me.DGVdistri.TabIndex = 69
        '
        'FrmAddDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Btn_Imprimir
        Me.ClientSize = New System.Drawing.Size(900, 500)
        Me.Controls.Add(Me.DGVdistri)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.Btn_Imprimir)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Txt_Correo)
        Me.Controls.Add(Me.Txt_Celular)
        Me.Controls.Add(Me.Txt_Telefono)
        Me.Controls.Add(Me.RichTxt_Direccion)
        Me.Controls.Add(Me.Txt_Encargado)
        Me.Controls.Add(Me.Lbl_Direccion)
        Me.Controls.Add(Me.Lbl_Telefono)
        Me.Controls.Add(Me.Lbl_Celular)
        Me.Controls.Add(Me.Lbl_Correo)
        Me.Controls.Add(Me.Lbl_Encargado)
        Me.Controls.Add(Me.Txt_NombreDistribuidor)
        Me.Controls.Add(Me.Lbl_NombreDistribuior)
        Me.Controls.Add(Me.BarraTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmAddDistribuidor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAddDistribuidor"
        Me.BarraTop.ResumeLayout(False)
        CType(Me.DGVdistri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents Cerrar As Button
    Friend WithEvents Minimizar1 As Button
    Friend WithEvents Lbl_NombreDistribuior As Label
    Friend WithEvents Txt_NombreDistribuidor As TextBox
    Friend WithEvents Lbl_Encargado As Label
    Friend WithEvents Lbl_Correo As Label
    Friend WithEvents Lbl_Celular As Label
    Friend WithEvents Lbl_Telefono As Label
    Friend WithEvents Lbl_Direccion As Label
    Friend WithEvents Txt_Encargado As TextBox
    Friend WithEvents RichTxt_Direccion As RichTextBox
    Friend WithEvents Txt_Telefono As TextBox
    Friend WithEvents Txt_Celular As TextBox
    Friend WithEvents Txt_Correo As TextBox
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Btn_Imprimir As Button
    Friend WithEvents Lbl_id As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents DGVdistri As DataGridView
End Class
