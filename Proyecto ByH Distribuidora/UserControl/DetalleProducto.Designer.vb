<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DetalleProducto
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetalleProducto))
        Me.contador = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.txtNombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.Label()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.contador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'contador
        '
        Me.contador.BackColor = System.Drawing.Color.Transparent
        Me.contador.BorderRadius = 5
        Me.contador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.contador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.contador.Location = New System.Drawing.Point(245, 39)
        Me.contador.Name = "contador"
        Me.contador.Size = New System.Drawing.Size(100, 36)
        Me.contador.TabIndex = 0
        Me.contador.UpDownButtonFillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.contador.UpDownButtonForeColor = System.Drawing.Color.White
        Me.contador.UseTransparentBackground = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(56, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Producto"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 5
        Me.Guna2Button1.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button1.CustomImages.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.White
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(50, 58)
        Me.Guna2Button1.TabIndex = 15
        '
        'txtNombre
        '
        Me.txtNombre.AutoSize = True
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(52, 46)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(119, 19)
        Me.txtNombre.TabIndex = 16
        Me.txtNombre.Text = "Nombre Producto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(177, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 19)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Precio"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(170, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 19)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "$"
        '
        'txtPrecio
        '
        Me.txtPrecio.AutoSize = True
        Me.txtPrecio.BackColor = System.Drawing.Color.White
        Me.txtPrecio.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(183, 46)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(46, 19)
        Me.txtPrecio.TabIndex = 19
        Me.txtPrecio.Text = "Precio"
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(0, 81)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(361, 10)
        Me.Guna2Separator1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(258, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 19)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Cantidad"
        '
        'DetalleProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Separator1)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.contador)
        Me.MaximumSize = New System.Drawing.Size(368, 89)
        Me.MinimumSize = New System.Drawing.Size(368, 89)
        Me.Name = "DetalleProducto"
        Me.Size = New System.Drawing.Size(368, 89)
        CType(Me.contador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents contador As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtNombre As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrecio As Label
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Label1 As Label
End Class
