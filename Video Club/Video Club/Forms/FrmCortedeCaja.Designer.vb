<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCortedeCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCortedeCaja))
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.Btn_Minimizar = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Lbl_CierreTurno = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_DineroEsperdado = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Lbl_Diferencia = New System.Windows.Forms.Label()
        Me.Btn_Cancelar = New System.Windows.Forms.Button()
        Me.Btn_Guardar = New System.Windows.Forms.Button()
        Me.Txt_EfectivoEsperado = New System.Windows.Forms.TextBox()
        Me.Txt_Efectivo = New System.Windows.Forms.TextBox()
        Me.Txt_Diferencia = New System.Windows.Forms.TextBox()
        Me.Btn_Bien = New System.Windows.Forms.Button()
        Me.Btn_Mal = New System.Windows.Forms.Button()
        Me.BarraTop.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
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
        'BarraTop
        '
        Me.BarraTop.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.BarraTop.Controls.Add(Me.Btn_Cerrar)
        Me.BarraTop.Controls.Add(Me.Btn_Minimizar)
        Me.BarraTop.Controls.Add(Me.X)
        Me.BarraTop.Controls.Add(Me.Minimizar)
        Me.BarraTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarraTop.Location = New System.Drawing.Point(0, 0)
        Me.BarraTop.Name = "BarraTop"
        Me.BarraTop.Size = New System.Drawing.Size(500, 25)
        Me.BarraTop.TabIndex = 16
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Cerrar.FlatAppearance.BorderSize = 0
        Me.Btn_Cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Cerrar.Image = CType(resources.GetObject("Btn_Cerrar.Image"), System.Drawing.Image)
        Me.Btn_Cerrar.Location = New System.Drawing.Point(470, 0)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Cerrar.TabIndex = 3
        Me.Btn_Cerrar.UseVisualStyleBackColor = False
        '
        'Btn_Minimizar
        '
        Me.Btn_Minimizar.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Minimizar.FlatAppearance.BorderSize = 0
        Me.Btn_Minimizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Minimizar.Image = Global.Video_Club.My.Resources.Resources.__
        Me.Btn_Minimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Minimizar.Location = New System.Drawing.Point(436, 0)
        Me.Btn_Minimizar.Name = "Btn_Minimizar"
        Me.Btn_Minimizar.Size = New System.Drawing.Size(25, 25)
        Me.Btn_Minimizar.TabIndex = 4
        Me.Btn_Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_Minimizar.UseVisualStyleBackColor = False
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
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackgroundImage = Global.Video_Club.My.Resources.Resources.Fondo_CierreTurno
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Controls.Add(Me.Lbl_CierreTurno)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(500, 50)
        Me.FlowLayoutPanel1.TabIndex = 18
        '
        'Lbl_CierreTurno
        '
        Me.Lbl_CierreTurno.AutoSize = True
        Me.Lbl_CierreTurno.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_CierreTurno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Lbl_CierreTurno.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_CierreTurno.ForeColor = System.Drawing.Color.Black
        Me.Lbl_CierreTurno.Location = New System.Drawing.Point(3, 0)
        Me.Lbl_CierreTurno.Name = "Lbl_CierreTurno"
        Me.Lbl_CierreTurno.Size = New System.Drawing.Size(210, 28)
        Me.Lbl_CierreTurno.TabIndex = 18
        Me.Lbl_CierreTurno.Text = "   Cierre de Turno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Cuenta el dinero en caja e ingresalo"
        '
        'Lbl_DineroEsperdado
        '
        Me.Lbl_DineroEsperdado.AutoSize = True
        Me.Lbl_DineroEsperdado.Location = New System.Drawing.Point(85, 130)
        Me.Lbl_DineroEsperdado.Name = "Lbl_DineroEsperdado"
        Me.Lbl_DineroEsperdado.Size = New System.Drawing.Size(219, 21)
        Me.Lbl_DineroEsperdado.TabIndex = 20
        Me.Lbl_DineroEsperdado.Text = "Efectivo esperado en caja:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(254, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "¿Cuánto efectivo hay en caja?"
        '
        'Lbl_Diferencia
        '
        Me.Lbl_Diferencia.AutoSize = True
        Me.Lbl_Diferencia.Location = New System.Drawing.Point(211, 210)
        Me.Lbl_Diferencia.Name = "Lbl_Diferencia"
        Me.Lbl_Diferencia.Size = New System.Drawing.Size(93, 21)
        Me.Lbl_Diferencia.TabIndex = 22
        Me.Lbl_Diferencia.Text = "Diferencia:"
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
        Me.Btn_Cancelar.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Cancelar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Cancelar.Image = Global.Video_Club.My.Resources.Resources.btnCancelar
        Me.Btn_Cancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Cancelar.Location = New System.Drawing.Point(85, 300)
        Me.Btn_Cancelar.Name = "Btn_Cancelar"
        Me.Btn_Cancelar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Cancelar.TabIndex = 67
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
        Me.Btn_Guardar.Font = New System.Drawing.Font("Fineliner Script", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Guardar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Guardar.Image = Global.Video_Club.My.Resources.Resources.BtnGuardar
        Me.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Guardar.Location = New System.Drawing.Point(290, 300)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(125, 50)
        Me.Btn_Guardar.TabIndex = 66
        Me.Btn_Guardar.Text = "Cerrar Sesión"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Guardar.UseVisualStyleBackColor = False
        '
        'Txt_EfectivoEsperado
        '
        Me.Txt_EfectivoEsperado.Location = New System.Drawing.Point(310, 125)
        Me.Txt_EfectivoEsperado.Name = "Txt_EfectivoEsperado"
        Me.Txt_EfectivoEsperado.Size = New System.Drawing.Size(150, 27)
        Me.Txt_EfectivoEsperado.TabIndex = 69
        '
        'Txt_Efectivo
        '
        Me.Txt_Efectivo.Location = New System.Drawing.Point(310, 165)
        Me.Txt_Efectivo.Name = "Txt_Efectivo"
        Me.Txt_Efectivo.Size = New System.Drawing.Size(150, 27)
        Me.Txt_Efectivo.TabIndex = 70
        '
        'Txt_Diferencia
        '
        Me.Txt_Diferencia.Location = New System.Drawing.Point(310, 205)
        Me.Txt_Diferencia.Name = "Txt_Diferencia"
        Me.Txt_Diferencia.Size = New System.Drawing.Size(150, 27)
        Me.Txt_Diferencia.TabIndex = 71
        '
        'Btn_Bien
        '
        Me.Btn_Bien.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Bien.Image = Global.Video_Club.My.Resources.Resources.BtnBien
        Me.Btn_Bien.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Bien.Location = New System.Drawing.Point(0, 250)
        Me.Btn_Bien.Name = "Btn_Bien"
        Me.Btn_Bien.Size = New System.Drawing.Size(500, 50)
        Me.Btn_Bien.TabIndex = 72
        Me.Btn_Bien.Text = "¡Excelente! Todo en orden"
        Me.Btn_Bien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Bien.UseVisualStyleBackColor = True
        Me.Btn_Bien.Visible = False
        '
        'Btn_Mal
        '
        Me.Btn_Mal.Font = New System.Drawing.Font("Century Gothic", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Mal.Image = Global.Video_Club.My.Resources.Resources.BtnMal
        Me.Btn_Mal.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mal.Location = New System.Drawing.Point(0, 250)
        Me.Btn_Mal.Name = "Btn_Mal"
        Me.Btn_Mal.Size = New System.Drawing.Size(500, 50)
        Me.Btn_Mal.TabIndex = 73
        Me.Btn_Mal.Text = "¡Lo sieto! Te falta efectivo"
        Me.Btn_Mal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mal.UseVisualStyleBackColor = True
        Me.Btn_Mal.Visible = False
        '
        'FrmCortedeCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(500, 400)
        Me.Controls.Add(Me.Btn_Mal)
        Me.Controls.Add(Me.Btn_Bien)
        Me.Controls.Add(Me.Txt_Diferencia)
        Me.Controls.Add(Me.Txt_Efectivo)
        Me.Controls.Add(Me.Txt_EfectivoEsperado)
        Me.Controls.Add(Me.Btn_Cancelar)
        Me.Controls.Add(Me.Btn_Guardar)
        Me.Controls.Add(Me.Lbl_Diferencia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_DineroEsperdado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarraTop)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmCortedeCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCortedeCaja"
        Me.BarraTop.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Minimizar As Button
    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents Btn_Minimizar As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Lbl_CierreTurno As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Lbl_DineroEsperdado As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Lbl_Diferencia As Label
    Friend WithEvents Btn_Cancelar As Button
    Friend WithEvents Btn_Guardar As Button
    Friend WithEvents Txt_EfectivoEsperado As TextBox
    Friend WithEvents Txt_Efectivo As TextBox
    Friend WithEvents Txt_Diferencia As TextBox
    Friend WithEvents Btn_Bien As Button
    Friend WithEvents Btn_Mal As Button
End Class
