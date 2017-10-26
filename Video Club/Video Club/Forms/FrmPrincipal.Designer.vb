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
        Me.BtnSocio = New System.Windows.Forms.Button()
        Me.BtnRenta = New System.Windows.Forms.Button()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.TImporte = New System.Windows.Forms.DataGridView()
        Me.BtnEmpleado = New System.Windows.Forms.Button()
        Me.BtnCorteCaja = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnPeliculas = New System.Windows.Forms.Button()
        Me.BtnDevoluciones = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.TImporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.X.Location = New System.Drawing.Point(1330, 0)
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
        Me.Minimizar.Location = New System.Drawing.Point(1290, 3)
        Me.Minimizar.Name = "Minimizar"
        Me.Minimizar.Size = New System.Drawing.Size(26, 25)
        Me.Minimizar.TabIndex = 2
        Me.Minimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Minimizar.UseVisualStyleBackColor = False
        '
        'BtnSocio
        '
        Me.BtnSocio.Location = New System.Drawing.Point(100, 100)
        Me.BtnSocio.Name = "BtnSocio"
        Me.BtnSocio.Size = New System.Drawing.Size(150, 100)
        Me.BtnSocio.TabIndex = 3
        Me.BtnSocio.Text = "Button1"
        Me.BtnSocio.UseVisualStyleBackColor = True
        '
        'BtnRenta
        '
        Me.BtnRenta.Location = New System.Drawing.Point(350, 100)
        Me.BtnRenta.Name = "BtnRenta"
        Me.BtnRenta.Size = New System.Drawing.Size(150, 100)
        Me.BtnRenta.TabIndex = 4
        Me.BtnRenta.Text = "Button1"
        Me.BtnRenta.UseVisualStyleBackColor = True
        '
        'BtnVenta
        '
        Me.BtnVenta.Location = New System.Drawing.Point(600, 100)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(150, 100)
        Me.BtnVenta.TabIndex = 5
        Me.BtnVenta.Text = "Button1"
        Me.BtnVenta.UseVisualStyleBackColor = True
        '
        'TImporte
        '
        Me.TImporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TImporte.Location = New System.Drawing.Point(850, 100)
        Me.TImporte.Name = "TImporte"
        Me.TImporte.Size = New System.Drawing.Size(420, 350)
        Me.TImporte.TabIndex = 6
        '
        'BtnEmpleado
        '
        Me.BtnEmpleado.Location = New System.Drawing.Point(225, 250)
        Me.BtnEmpleado.Name = "BtnEmpleado"
        Me.BtnEmpleado.Size = New System.Drawing.Size(150, 100)
        Me.BtnEmpleado.TabIndex = 7
        Me.BtnEmpleado.Text = "Button2"
        Me.BtnEmpleado.UseVisualStyleBackColor = True
        '
        'BtnCorteCaja
        '
        Me.BtnCorteCaja.Location = New System.Drawing.Point(100, 500)
        Me.BtnCorteCaja.Name = "BtnCorteCaja"
        Me.BtnCorteCaja.Size = New System.Drawing.Size(200, 50)
        Me.BtnCorteCaja.TabIndex = 8
        Me.BtnCorteCaja.Text = "Button2"
        Me.BtnCorteCaja.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(100, 560)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1170, 150)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'BtnPeliculas
        '
        Me.BtnPeliculas.Location = New System.Drawing.Point(475, 250)
        Me.BtnPeliculas.Name = "BtnPeliculas"
        Me.BtnPeliculas.Size = New System.Drawing.Size(150, 100)
        Me.BtnPeliculas.TabIndex = 10
        Me.BtnPeliculas.Text = "Button1"
        Me.BtnPeliculas.UseVisualStyleBackColor = True
        '
        'BtnDevoluciones
        '
        Me.BtnDevoluciones.Location = New System.Drawing.Point(300, 500)
        Me.BtnDevoluciones.Name = "BtnDevoluciones"
        Me.BtnDevoluciones.Size = New System.Drawing.Size(200, 50)
        Me.BtnDevoluciones.TabIndex = 11
        Me.BtnDevoluciones.Text = "Button1"
        Me.BtnDevoluciones.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(500, 500)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 50)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Video_Club.My.Resources.Resources.Fondo_Pricipal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1370, 750)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnDevoluciones)
        Me.Controls.Add(Me.BtnPeliculas)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCorteCaja)
        Me.Controls.Add(Me.BtnEmpleado)
        Me.Controls.Add(Me.TImporte)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.BtnRenta)
        Me.Controls.Add(Me.BtnSocio)
        Me.Controls.Add(Me.Minimizar)
        Me.Controls.Add(Me.X)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPrincipal"
        Me.Text = "FrmPrincipal"
        CType(Me.TImporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents BtnSocio As Button
    Friend WithEvents BtnRenta As Button
    Friend WithEvents BtnVenta As Button
    Friend WithEvents TImporte As DataGridView
    Friend WithEvents BtnEmpleado As Button
    Friend WithEvents BtnCorteCaja As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnPeliculas As Button
    Friend WithEvents BtnDevoluciones As Button
    Friend WithEvents Button1 As Button
End Class
