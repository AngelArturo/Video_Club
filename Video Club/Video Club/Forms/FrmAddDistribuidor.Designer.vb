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
        Me.RichTxt_Direccion = New System.Windows.Forms.RichTextBox()
        Me.Txt_Telefono = New System.Windows.Forms.TextBox()
        Me.Txt_Celular = New System.Windows.Forms.TextBox()
        Me.Txt_Correo = New System.Windows.Forms.TextBox()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
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
        Me.BarraTop.Size = New System.Drawing.Size(876, 25)
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
        Me.Cerrar.Location = New System.Drawing.Point(851, 0)
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
        Me.Minimizar1.Location = New System.Drawing.Point(819, -3)
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
        Me.Lbl_NombreDistribuior.Location = New System.Drawing.Point(50, 100)
        Me.Lbl_NombreDistribuior.Name = "Lbl_NombreDistribuior"
        Me.Lbl_NombreDistribuior.Size = New System.Drawing.Size(194, 21)
        Me.Lbl_NombreDistribuior.TabIndex = 40
        Me.Lbl_NombreDistribuior.Text = "Nombre del distribuidor:"
        '
        'Txt_NombreDistribuidor
        '
        Me.Txt_NombreDistribuidor.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NombreDistribuidor.Location = New System.Drawing.Point(250, 100)
        Me.Txt_NombreDistribuidor.Name = "Txt_NombreDistribuidor"
        Me.Txt_NombreDistribuidor.Size = New System.Drawing.Size(200, 24)
        Me.Txt_NombreDistribuidor.TabIndex = 51
        '
        'Lbl_Encargado
        '
        Me.Lbl_Encargado.AutoSize = True
        Me.Lbl_Encargado.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Encargado.Location = New System.Drawing.Point(142, 130)
        Me.Lbl_Encargado.Name = "Lbl_Encargado"
        Me.Lbl_Encargado.Size = New System.Drawing.Size(102, 21)
        Me.Lbl_Encargado.TabIndex = 52
        Me.Lbl_Encargado.Text = "Encargado:"
        '
        'Lbl_Correo
        '
        Me.Lbl_Correo.AutoSize = True
        Me.Lbl_Correo.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Correo.Location = New System.Drawing.Point(177, 310)
        Me.Lbl_Correo.Name = "Lbl_Correo"
        Me.Lbl_Correo.Size = New System.Drawing.Size(67, 21)
        Me.Lbl_Correo.TabIndex = 54
        Me.Lbl_Correo.Text = "Correo:"
        '
        'Lbl_Celular
        '
        Me.Lbl_Celular.AutoSize = True
        Me.Lbl_Celular.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Celular.Location = New System.Drawing.Point(175, 280)
        Me.Lbl_Celular.Name = "Lbl_Celular"
        Me.Lbl_Celular.Size = New System.Drawing.Size(69, 21)
        Me.Lbl_Celular.TabIndex = 55
        Me.Lbl_Celular.Text = "Celular:"
        '
        'Lbl_Telefono
        '
        Me.Lbl_Telefono.AutoSize = True
        Me.Lbl_Telefono.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Telefono.Location = New System.Drawing.Point(164, 250)
        Me.Lbl_Telefono.Name = "Lbl_Telefono"
        Me.Lbl_Telefono.Size = New System.Drawing.Size(80, 21)
        Me.Lbl_Telefono.TabIndex = 56
        Me.Lbl_Telefono.Text = "Teléfono:"
        '
        'Lbl_Direccion
        '
        Me.Lbl_Direccion.AutoSize = True
        Me.Lbl_Direccion.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Direccion.Location = New System.Drawing.Point(157, 160)
        Me.Lbl_Direccion.Name = "Lbl_Direccion"
        Me.Lbl_Direccion.Size = New System.Drawing.Size(87, 21)
        Me.Lbl_Direccion.TabIndex = 57
        Me.Lbl_Direccion.Text = "Dirección:"
        '
        'Txt_Encargado
        '
        Me.Txt_Encargado.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Encargado.Location = New System.Drawing.Point(250, 130)
        Me.Txt_Encargado.Name = "Txt_Encargado"
        Me.Txt_Encargado.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Encargado.TabIndex = 58
        '
        'RichTxt_Direccion
        '
        Me.RichTxt_Direccion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTxt_Direccion.Location = New System.Drawing.Point(250, 160)
        Me.RichTxt_Direccion.Name = "RichTxt_Direccion"
        Me.RichTxt_Direccion.Size = New System.Drawing.Size(200, 85)
        Me.RichTxt_Direccion.TabIndex = 60
        Me.RichTxt_Direccion.Text = "Calle, #Exterior, #Interior, Colonia, C.P"
        '
        'Txt_Telefono
        '
        Me.Txt_Telefono.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Telefono.Location = New System.Drawing.Point(250, 250)
        Me.Txt_Telefono.Name = "Txt_Telefono"
        Me.Txt_Telefono.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Telefono.TabIndex = 61
        '
        'Txt_Celular
        '
        Me.Txt_Celular.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Celular.Location = New System.Drawing.Point(250, 280)
        Me.Txt_Celular.MaxLength = 12
        Me.Txt_Celular.Name = "Txt_Celular"
        Me.Txt_Celular.Size = New System.Drawing.Size(200, 24)
        Me.Txt_Celular.TabIndex = 62
        '
        'Txt_Correo
        '
        Me.Txt_Correo.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Correo.Location = New System.Drawing.Point(250, 310)
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
        Me.Btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(720, 419)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 64
        Me.Btn_Guardar.Text = "Guardar"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
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
        Me.Btn_Cancelar.Location = New System.Drawing.Point(557, 419)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Cancelar.TabIndex = 65
        Me.Btn_Cancelar.Text = "Cancelar"
        Me.Btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Cancelar.UseVisualStyleBackColor = False
        '
        'Lbl_id
        '
        Me.Lbl_id.AutoSize = True
        Me.Lbl_id.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_id.Location = New System.Drawing.Point(213, 70)
        Me.Lbl_id.Name = "Lbl_id"
        Me.Lbl_id.Size = New System.Drawing.Size(31, 21)
        Me.Lbl_id.TabIndex = 66
        Me.Lbl_id.Text = "ID:"
        '
        'Txt_ID
        '
        Me.Txt_ID.Enabled = False
        Me.Txt_ID.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ID.Location = New System.Drawing.Point(250, 70)
        Me.Txt_ID.Name = "Txt_ID"
        Me.Txt_ID.Size = New System.Drawing.Size(200, 24)
        Me.Txt_ID.TabIndex = 67
        '
        'DGVdistri
        '
        Me.DGVdistri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVdistri.Location = New System.Drawing.Point(493, 70)
        Me.DGVdistri.Name = "DGVdistri"
        Me.DGVdistri.Size = New System.Drawing.Size(352, 283)
        Me.DGVdistri.TabIndex = 69
        '
        'FrmAddDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.CancelButton = Me.Btn_Cancelar
        Me.ClientSize = New System.Drawing.Size(876, 499)
        Me.Controls.Add(Me.DGVdistri)
        Me.Controls.Add(Me.Txt_ID)
        Me.Controls.Add(Me.Lbl_id)
        Me.Controls.Add(Me.Btn_Cancelar)
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
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Lbl_id As Label
    Friend WithEvents Txt_ID As TextBox
    Friend WithEvents DGVdistri As DataGridView
End Class
