<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUDistribuidor
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btn_Eliminar = New System.Windows.Forms.Button()
        Me.Btn_Modificar = New System.Windows.Forms.Button()
        Me.Btn_AddDistribuidor = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(100, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(880, 500)
        Me.DataGridView1.TabIndex = 15
        '
        'Btn_Eliminar
        '
        Me.Btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Eliminar.FlatAppearance.BorderSize = 0
        Me.Btn_Eliminar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Eliminar.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Eliminar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Eliminar.Image = Global.Video_Club.My.Resources.Resources.BtnEliminar
        Me.Btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Eliminar.Location = New System.Drawing.Point(890, 50)
        Me.Btn_Eliminar.Name = "Btn_Eliminar"
        Me.Btn_Eliminar.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Eliminar.TabIndex = 17
        Me.Btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Eliminar.UseVisualStyleBackColor = False
        '
        'Btn_Modificar
        '
        Me.Btn_Modificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_Modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_Modificar.FlatAppearance.BorderSize = 0
        Me.Btn_Modificar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Modificar.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Modificar.ForeColor = System.Drawing.Color.Black
        Me.Btn_Modificar.Image = Global.Video_Club.My.Resources.Resources.BtnModificar
        Me.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_Modificar.Location = New System.Drawing.Point(820, 50)
        Me.Btn_Modificar.Name = "Btn_Modificar"
        Me.Btn_Modificar.Size = New System.Drawing.Size(60, 60)
        Me.Btn_Modificar.TabIndex = 16
        Me.Btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_Modificar.UseVisualStyleBackColor = False
        '
        'Btn_AddDistribuidor
        '
        Me.Btn_AddDistribuidor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Btn_AddDistribuidor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Btn_AddDistribuidor.FlatAppearance.BorderSize = 0
        Me.Btn_AddDistribuidor.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.Btn_AddDistribuidor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btn_AddDistribuidor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btn_AddDistribuidor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_AddDistribuidor.Font = New System.Drawing.Font("Fineliner Script", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddDistribuidor.ForeColor = System.Drawing.Color.Black
        Me.Btn_AddDistribuidor.Image = Global.Video_Club.My.Resources.Resources.BtnAgregarDistribuidor
        Me.Btn_AddDistribuidor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Btn_AddDistribuidor.Location = New System.Drawing.Point(610, 50)
        Me.Btn_AddDistribuidor.Name = "Btn_AddDistribuidor"
        Me.Btn_AddDistribuidor.Size = New System.Drawing.Size(200, 60)
        Me.Btn_AddDistribuidor.TabIndex = 14
        Me.Btn_AddDistribuidor.Text = "Agregar Distribuidor"
        Me.Btn_AddDistribuidor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.Btn_AddDistribuidor.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(100, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(450, 23)
        Me.TextBox1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(100, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 21)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombre de la película:"
        '
        'CUDistribuidor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Eliminar)
        Me.Controls.Add(Me.Btn_Modificar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btn_AddDistribuidor)
        Me.Name = "CUDistribuidor"
        Me.Size = New System.Drawing.Size(1095, 725)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_AddDistribuidor As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Btn_Modificar As Button
    Friend WithEvents Btn_Eliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
End Class
