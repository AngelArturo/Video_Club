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
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.BarraTop.SuspendLayout()
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
        Me.BarraTop.Size = New System.Drawing.Size(530, 25)
        Me.BarraTop.TabIndex = 16
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
        Me.Cerrar.Location = New System.Drawing.Point(493, 0)
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
        Me.Minimizar1.Location = New System.Drawing.Point(459, -1)
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
        Me.Lbl_NombreDistribuior.Location = New System.Drawing.Point(50, 70)
        Me.Lbl_NombreDistribuior.Name = "Lbl_NombreDistribuior"
        Me.Lbl_NombreDistribuior.Size = New System.Drawing.Size(194, 21)
        Me.Lbl_NombreDistribuior.TabIndex = 40
        Me.Lbl_NombreDistribuior.Text = "Nombre del distribuidor:"
        '
        'Txt_NombreDistribuidor
        '
        Me.Txt_NombreDistribuidor.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreDistribuidor.Location = New System.Drawing.Point(250, 70)
        Me.Txt_NombreDistribuidor.Name = "Txt_NombreDistribuidor"
        Me.Txt_NombreDistribuidor.Size = New System.Drawing.Size(200, 24)
        Me.Txt_NombreDistribuidor.TabIndex = 51
        '
        'Lbl_Encargado
        '
        Me.Lbl_Encargado.AutoSize = True
        Me.Lbl_Encargado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Encargado.Location = New System.Drawing.Point(142, 100)
        Me.Lbl_Encargado.Name = "Lbl_Encargado"
        Me.Lbl_Encargado.Size = New System.Drawing.Size(102, 21)
        Me.Lbl_Encargado.TabIndex = 52
        Me.Lbl_Encargado.Text = "Encargado:"
        '
        'Lbl_Correo
        '
        Me.Lbl_Correo.AutoSize = True
        Me.Lbl_Correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Correo.Location = New System.Drawing.Point(177, 280)
        Me.Lbl_Correo.Name = "Lbl_Correo"
        Me.Lbl_Correo.Size = New System.Drawing.Size(67, 21)
        Me.Lbl_Correo.TabIndex = 54
        Me.Lbl_Correo.Text = "Correo:"
        '
        'Lbl_Celular
        '
        Me.Lbl_Celular.AutoSize = True
        Me.Lbl_Celular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Celular.Location = New System.Drawing.Point(175, 250)
        Me.Lbl_Celular.Name = "Lbl_Celular"
        Me.Lbl_Celular.Size = New System.Drawing.Size(69, 21)
        Me.Lbl_Celular.TabIndex = 55
        Me.Lbl_Celular.Text = "Celular:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefono.Location = New System.Drawing.Point(164, 220)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(80, 21)
        Me.Lbl_Telefono.TabIndex = 56
        Me.Lbl_Telefono.Text = "Teléfono:"
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.AutoSize = True
        Me.Lbl_Direccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Direccion.Location = New System.Drawing.Point(157, 130)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(87, 21)
        Me.Lbl_Direccion.TabIndex = 57
        Me.Lbl_Direccion.Text = "Dirección:"
        '
        'Txt_Encargado
        '
        Me.Txt_Encargado.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Encargado.Location = New System.Drawing.Point(250, 100)
        Me.Txt_Encargado.Name = "Txt_Encargado"
        Me.Txt_Encargado.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Encargado.TabIndex = 58
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(250, 130)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(200, 85)
        Me.RichTextBox1.TabIndex = 60
        Me.RichTextBox1.Text = "Calle, #Exterior, #Interior, Colonia, C.P"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(250, 220)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(200, 24)
        Me.TextBox1.TabIndex = 61
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(250, 250)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 24)
        Me.TextBox2.TabIndex = 62
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(250, 280)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(200, 24)
        Me.TextBox3.TabIndex = 63
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
        Me.Btn_Guardar.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(350, 345)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 64
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'FrmAddDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(530, 430)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RichTextBox1)
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
        Me.Text = "FrmAddDistribuidor"
        Me.BarraTop.ResumeLayout(False)
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
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Btn_Guardar As Button
End Class
