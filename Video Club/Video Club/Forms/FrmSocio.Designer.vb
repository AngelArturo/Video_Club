<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSocio))
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.claveSocio = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.materno = New System.Windows.Forms.TextBox()
        Me.paterno = New System.Windows.Forms.TextBox()
        Me.sexo = New System.Windows.Forms.ComboBox()
        Me.calle = New System.Windows.Forms.TextBox()
        Me.numEx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.colonia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.numIn = New System.Windows.Forms.TextBox()
        Me.telefono = New System.Windows.Forms.TextBox()
        Me.celular = New System.Windows.Forms.TextBox()
        Me.Radio = New System.Windows.Forms.RadioButton()
        Me.RadioB = New System.Windows.Forms.RadioButton()
        Me.radioDeselecion = New System.Windows.Forms.RadioButton()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.DGV_socios = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.BarraTop.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGV_socios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BarraTop
        '
        Me.BarraTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BarraTop.Controls.Add(Me.X)
        Me.BarraTop.Controls.Add(Me.Minimizar)
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(0, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(1077, 25)
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
        Me.X.Location = New System.Drawing.Point(1049, 1)
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
        Me.Minimizar.Location = New System.Drawing.Point(1017, 0)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DGV_socios)
        Me.TabPage2.Controls.Add(Me.BtnGuardar)
        Me.TabPage2.Controls.Add(Me.radioDeselecion)
        Me.TabPage2.Controls.Add(Me.RadioB)
        Me.TabPage2.Controls.Add(Me.Radio)
        Me.TabPage2.Controls.Add(Me.celular)
        Me.TabPage2.Controls.Add(Me.telefono)
        Me.TabPage2.Controls.Add(Me.numIn)
        Me.TabPage2.Controls.Add(Me.colonia)
        Me.TabPage2.Controls.Add(Me.numEx)
        Me.TabPage2.Controls.Add(Me.calle)
        Me.TabPage2.Controls.Add(Me.paterno)
        Me.TabPage2.Controls.Add(Me.materno)
        Me.TabPage2.Controls.Add(Me.nombre)
        Me.TabPage2.Controls.Add(Me.claveSocio)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.sexo)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 26)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1010, 375)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nuevo Socio"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(371, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 21)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Clave:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(359, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Género:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(70, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 21)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Nombre(s):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(150, 21)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Apellido Materno:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 21)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "Apellido Paterno:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(11, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 21)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Domicilio:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(11, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 21)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "No.Teléfono:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(11, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(162, 21)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Credencial Vigente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(11, 277)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(95, 21)
        Me.Label13.TabIndex = 46
        Me.Label13.Text = "No.Celular:"
        '
        'claveSocio
        '
        Me.claveSocio.Enabled = False
        Me.claveSocio.Location = New System.Drawing.Point(431, 13)
        Me.claveSocio.Name = "claveSocio"
        Me.claveSocio.Size = New System.Drawing.Size(150, 23)
        Me.claveSocio.TabIndex = 49
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(171, 43)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(175, 23)
        Me.nombre.TabIndex = 50
        '
        'materno
        '
        Me.materno.Location = New System.Drawing.Point(171, 106)
        Me.materno.Name = "materno"
        Me.materno.Size = New System.Drawing.Size(175, 23)
        Me.materno.TabIndex = 51
        '
        'paterno
        '
        Me.paterno.Location = New System.Drawing.Point(171, 76)
        Me.paterno.Name = "paterno"
        Me.paterno.Size = New System.Drawing.Size(175, 23)
        Me.paterno.TabIndex = 52
        '
        'sexo
        '
        Me.sexo.FormattingEnabled = True
        Me.sexo.Items.AddRange(New Object() {"F", "M"})
        Me.sexo.Location = New System.Drawing.Point(446, 143)
        Me.sexo.Name = "sexo"
        Me.sexo.Size = New System.Drawing.Size(135, 25)
        Me.sexo.TabIndex = 53
        Me.sexo.Text = "Seleccione"
        '
        'calle
        '
        Me.calle.Location = New System.Drawing.Point(11, 200)
        Me.calle.Name = "calle"
        Me.calle.Size = New System.Drawing.Size(175, 23)
        Me.calle.TabIndex = 54
        '
        'numEx
        '
        Me.numEx.Location = New System.Drawing.Point(280, 201)
        Me.numEx.Name = "numEx"
        Me.numEx.Size = New System.Drawing.Size(75, 23)
        Me.numEx.TabIndex = 55
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 21)
        Me.Label3.TabIndex = 56
        '
        'colonia
        '
        Me.colonia.Location = New System.Drawing.Point(375, 200)
        Me.colonia.Name = "colonia"
        Me.colonia.Size = New System.Drawing.Size(180, 23)
        Me.colonia.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(370, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 58
        '
        'numIn
        '
        Me.numIn.Location = New System.Drawing.Point(199, 200)
        Me.numIn.Name = "numIn"
        Me.numIn.Size = New System.Drawing.Size(75, 23)
        Me.numIn.TabIndex = 59
        '
        'telefono
        '
        Me.telefono.Location = New System.Drawing.Point(142, 248)
        Me.telefono.Name = "telefono"
        Me.telefono.Size = New System.Drawing.Size(213, 23)
        Me.telefono.TabIndex = 60
        '
        'celular
        '
        Me.celular.Location = New System.Drawing.Point(142, 278)
        Me.celular.Name = "celular"
        Me.celular.Size = New System.Drawing.Size(213, 23)
        Me.celular.TabIndex = 61
        '
        'Radio
        '
        Me.Radio.AutoSize = True
        Me.Radio.Location = New System.Drawing.Point(171, 307)
        Me.Radio.Name = "Radio"
        Me.Radio.Size = New System.Drawing.Size(35, 21)
        Me.Radio.TabIndex = 65
        Me.Radio.Tag = "Radio"
        Me.Radio.Text = "SI"
        Me.Radio.UseVisualStyleBackColor = True
        '
        'RadioB
        '
        Me.RadioB.AutoSize = True
        Me.RadioB.Location = New System.Drawing.Point(212, 307)
        Me.RadioB.Name = "RadioB"
        Me.RadioB.Size = New System.Drawing.Size(47, 21)
        Me.RadioB.TabIndex = 66
        Me.RadioB.Tag = "Radio"
        Me.RadioB.Text = "NO"
        Me.RadioB.UseVisualStyleBackColor = True
        '
        'radioDeselecion
        '
        Me.radioDeselecion.AutoSize = True
        Me.radioDeselecion.Checked = True
        Me.radioDeselecion.Location = New System.Drawing.Point(308, 309)
        Me.radioDeselecion.Name = "radioDeselecion"
        Me.radioDeselecion.Size = New System.Drawing.Size(47, 21)
        Me.radioDeselecion.TabIndex = 67
        Me.radioDeselecion.TabStop = True
        Me.radioDeselecion.Tag = "Radio"
        Me.radioDeselecion.Text = "NO"
        Me.radioDeselecion.UseVisualStyleBackColor = True
        Me.radioDeselecion.Visible = False
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(490, 337)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.BtnGuardar.TabIndex = 65
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'DGV_socios
        '
        Me.DGV_socios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_socios.Location = New System.Drawing.Point(624, 33)
        Me.DGV_socios.Name = "DGV_socios"
        Me.DGV_socios.Size = New System.Drawing.Size(379, 327)
        Me.DGV_socios.TabIndex = 68
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(40, 55)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1018, 405)
        Me.TabControl1.TabIndex = 37
        '
        'FrmSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1077, 523)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BarraTop)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSocio"
        Me.Text = "FrmSocio"
        Me.BarraTop.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGV_socios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DGV_socios As DataGridView
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents radioDeselecion As RadioButton
    Friend WithEvents RadioB As RadioButton
    Friend WithEvents Radio As RadioButton
    Friend WithEvents celular As TextBox
    Friend WithEvents telefono As TextBox
    Friend WithEvents numIn As TextBox
    Friend WithEvents colonia As TextBox
    Friend WithEvents numEx As TextBox
    Friend WithEvents calle As TextBox
    Friend WithEvents paterno As TextBox
    Friend WithEvents materno As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents claveSocio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents sexo As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl1 As TabControl
End Class
