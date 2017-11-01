<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUPelicula
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
        Me.BtnRenta = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(100, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(880, 500)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnRenta
        '
        Me.BtnRenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BtnRenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnRenta.FlatAppearance.BorderSize = 0
        Me.BtnRenta.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnRenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRenta.Font = New System.Drawing.Font("Fineliner Script", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRenta.ForeColor = System.Drawing.Color.Black
        Me.BtnRenta.Image = Global.Video_Club.My.Resources.Resources.BtnAgregarPelicula
        Me.BtnRenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnRenta.Location = New System.Drawing.Point(750, 50)
        Me.BtnRenta.Name = "BtnRenta"
        Me.BtnRenta.Size = New System.Drawing.Size(200, 60)
        Me.BtnRenta.TabIndex = 13
        Me.BtnRenta.Text = "Agregar Película"
        Me.BtnRenta.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnRenta.UseVisualStyleBackColor = False
        '
        'CUPelicula
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.BtnRenta)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "CUPelicula"
        Me.Size = New System.Drawing.Size(1095, 725)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnRenta As Button
End Class
