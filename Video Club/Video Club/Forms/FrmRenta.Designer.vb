<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRenta))
        Me.BarraTop = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.X = New System.Windows.Forms.Button()
        Me.Minimizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnVenta = New System.Windows.Forms.Button()
        Me.BarraTop.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.BarraTop.Size = New System.Drawing.Size(700, 25)
        Me.BarraTop.TabIndex = 16
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
        Me.Button1.Location = New System.Drawing.Point(669, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(25, 25)
        Me.Button1.TabIndex = 17
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
        Me.Button2.Location = New System.Drawing.Point(635, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(26, 25)
        Me.Button2.TabIndex = 18
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 21)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Nombre de la película:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(240, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(400, 27)
        Me.TextBox1.TabIndex = 18
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(600, 270)
        Me.DataGridView1.TabIndex = 19
        '
        'BtnVenta
        '
        Me.BtnVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVenta.FlatAppearance.BorderSize = 0
        Me.BtnVenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVenta.Font = New System.Drawing.Font("Fineliner Script", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVenta.Image = Global.Video_Club.My.Resources.Resources.BtnAgregar
        Me.BtnVenta.Location = New System.Drawing.Point(495, 425)
        Me.BtnVenta.Name = "BtnVenta"
        Me.BtnVenta.Size = New System.Drawing.Size(125, 50)
        Me.BtnVenta.TabIndex = 20
        Me.BtnVenta.Text = "Rentar"
        Me.BtnVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnVenta.UseVisualStyleBackColor = False
        '
        'FrmRenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(700, 500)
        Me.Controls.Add(Me.BtnVenta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BarraTop)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmRenta"
        Me.Text = "FrmRenta"
        Me.BarraTop.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BarraTop As Panel
    Friend WithEvents X As Button
    Friend WithEvents Minimizar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnVenta As Button
End Class
