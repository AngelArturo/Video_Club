<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtContraseña = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblContraseña = New System.Windows.Forms.Label()
        Me.BtnIngresar = New System.Windows.Forms.Button()
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
        Me.X.Location = New System.Drawing.Point(670, 0)
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(25, 25)
        Me.X.TabIndex = 0
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
        Me.Minimizar.Location = New System.Drawing.Point(640, 3)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar.TabIndex = 1
        Me.Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'TxtNombre
        '
        Me.TxtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.TxtNombre.Font = New System.Drawing.Font("Utsaah", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNombre.Location = New System.Drawing.Point(240, 285)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(230, 25)
        Me.TxtNombre.TabIndex = 2
        '
        'TxtContraseña
        '
        Me.TxtContraseña.BackColor = System.Drawing.SystemColors.Window
        Me.TxtContraseña.Font = New System.Drawing.Font("Utsaah", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtContraseña.Location = New System.Drawing.Point(240, 345)
        Me.TxtContraseña.Name = "TxtContraseña"
        Me.TxtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtContraseña.Size = New System.Drawing.Size(230, 25)
        Me.TxtContraseña.TabIndex = 3
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.BackColor = System.Drawing.Color.Transparent
        Me.LblNombre.Font = New System.Drawing.Font("Utsaah", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(240, 260)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(79, 25)
        Me.LblNombre.TabIndex = 4
        Me.LblNombre.Text = "Nombre:"
        '
        'LblContraseña
        '
        Me.LblContraseña.AutoSize = True
        Me.LblContraseña.BackColor = System.Drawing.Color.Transparent
        Me.LblContraseña.Font = New System.Drawing.Font("Utsaah", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContraseña.Location = New System.Drawing.Point(240, 320)
        Me.LblContraseña.Name = "LblContraseña"
        Me.LblContraseña.Size = New System.Drawing.Size(106, 25)
        Me.LblContraseña.TabIndex = 5
        Me.LblContraseña.Text = "Contraseña:"
        '
        'BtnIngresar
        '
        Me.BtnIngresar.BackColor = System.Drawing.Color.Transparent
        Me.BtnIngresar.FlatAppearance.BorderSize = 0
        Me.BtnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnIngresar.Font = New System.Drawing.Font("Utsaah", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnIngresar.Image = Global.Video_Club.My.Resources.Resources.Ingresar
        Me.BtnIngresar.Location = New System.Drawing.Point(310, 390)
        Me.BtnIngresar.Name = "BtnIngresar"
        Me.BtnIngresar.Size = New System.Drawing.Size(100, 38)
        Me.BtnIngresar.TabIndex = 6
        Me.BtnIngresar.Text = "Ingresar"
        Me.BtnIngresar.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.Fondo_Login
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(700, 525)
        Me.Controls.Add(Me.BtnIngresar)
        Me.Controls.Add(Me.LblContraseña)
        Me.Controls.Add(Me.LblNombre)
        Me.Controls.Add(Me.TxtContraseña)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Minimizar)
        Me.Controls.Add(Me.X)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmLogin"
        Me.Text = "FrmLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtContraseña As TextBox
    Friend WithEvents LblNombre As Label
    Friend WithEvents LblContraseña As Label
    Friend WithEvents BtnIngresar As Button
End Class
