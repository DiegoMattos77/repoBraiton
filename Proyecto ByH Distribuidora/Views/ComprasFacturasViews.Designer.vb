<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprasFacturasViews
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComprasFacturasViews))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridCompras = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompraBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComprasIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioCompraDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvedorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 22
        Me.Guna2Panel2.Controls.Add(Me.labelNombre)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 37)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(909, 516)
        Me.Guna2Panel2.TabIndex = 39
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.BackColor = System.Drawing.Color.White
        Me.labelNombre.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.labelNombre.Location = New System.Drawing.Point(224, 14)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(215, 25)
        Me.labelNombre.TabIndex = 32
        Me.labelNombre.Text = "Registrar nueva compra"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.BackColor = System.Drawing.Color.White
        Me.Guna2Button1.BorderRadius = 15
        Me.Guna2Button1.CustomImages.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.Guna2Button1.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.Location = New System.Drawing.Point(185, 9)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(33, 33)
        Me.Guna2Button1.TabIndex = 28
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.White
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 48)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(888, 10)
        Me.Guna2Separator1.TabIndex = 26
        '
        'Guna2CircleButton1
        '
        Me.Guna2CircleButton1.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton1.Image = CType(resources.GetObject("Guna2CircleButton1.Image"), System.Drawing.Image)
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(847, 9)
        Me.Guna2CircleButton1.Name = "Guna2CircleButton1"
        Me.Guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton1.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton1.TabIndex = 25
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.AutoRoundedCorners = True
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.White
        Me.Guna2TextBox1.BorderRadius = 15
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.IconLeft = CType(resources.GetObject("Guna2TextBox1.IconLeft"), System.Drawing.Image)
        Me.Guna2TextBox1.Location = New System.Drawing.Point(15, 9)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(154, 33)
        Me.Guna2TextBox1.TabIndex = 24
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderRadius = 22
        Me.Guna2Panel3.Controls.Add(Me.DataGridCompras)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 64)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(875, 421)
        Me.Guna2Panel3.TabIndex = 23
        '
        'DataGridCompras
        '
        Me.DataGridCompras.AllowUserToDeleteRows = False
        Me.DataGridCompras.AllowUserToResizeColumns = False
        Me.DataGridCompras.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridCompras.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridCompras.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridCompras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridCompras.ColumnHeadersHeight = 30
        Me.DataGridCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ComprasIdDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioCompraDataGridViewTextBoxColumn, Me.FechaIngresoDataGridViewTextBoxColumn, Me.ProvedorDataGridViewTextBoxColumn, Me.ProductoDataGridViewTextBoxColumn})
        Me.DataGridCompras.DataSource = Me.CompraBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridCompras.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridCompras.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridCompras.Location = New System.Drawing.Point(10, 11)
        Me.DataGridCompras.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridCompras.Name = "DataGridCompras"
        Me.DataGridCompras.ReadOnly = True
        Me.DataGridCompras.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridCompras.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridCompras.RowTemplate.DividerHeight = 3
        Me.DataGridCompras.RowTemplate.Height = 40
        Me.DataGridCompras.Size = New System.Drawing.Size(854, 388)
        Me.DataGridCompras.TabIndex = 25
        Me.DataGridCompras.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridCompras.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridCompras.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridCompras.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridCompras.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridCompras.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridCompras.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridCompras.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red
        Me.DataGridCompras.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridCompras.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridCompras.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridCompras.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridCompras.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridCompras.ThemeStyle.ReadOnly = True
        Me.DataGridCompras.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridCompras.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridCompras.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridCompras.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridCompras.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridCompras.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridCompras.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(10, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(154, 25)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Lista de compras"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.Producto)
        '
        'CompraBindingSource
        '
        Me.CompraBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.Compra)
        '
        'ComprasIdDataGridViewTextBoxColumn
        '
        Me.ComprasIdDataGridViewTextBoxColumn.DataPropertyName = "Compras_Id"
        Me.ComprasIdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.ComprasIdDataGridViewTextBoxColumn.Name = "ComprasIdDataGridViewTextBoxColumn"
        Me.ComprasIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioCompraDataGridViewTextBoxColumn
        '
        Me.PrecioCompraDataGridViewTextBoxColumn.DataPropertyName = "Precio_Compra"
        Me.PrecioCompraDataGridViewTextBoxColumn.HeaderText = "Precio Compra"
        Me.PrecioCompraDataGridViewTextBoxColumn.Name = "PrecioCompraDataGridViewTextBoxColumn"
        Me.PrecioCompraDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaIngresoDataGridViewTextBoxColumn
        '
        Me.FechaIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha_Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha Ingreso"
        Me.FechaIngresoDataGridViewTextBoxColumn.Name = "FechaIngresoDataGridViewTextBoxColumn"
        Me.FechaIngresoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProvedorDataGridViewTextBoxColumn
        '
        Me.ProvedorDataGridViewTextBoxColumn.DataPropertyName = "Provedor"
        Me.ProvedorDataGridViewTextBoxColumn.HeaderText = "Provedor ID"
        Me.ProvedorDataGridViewTextBoxColumn.Name = "ProvedorDataGridViewTextBoxColumn"
        Me.ProvedorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoDataGridViewTextBoxColumn
        '
        Me.ProductoDataGridViewTextBoxColumn.DataPropertyName = "Producto"
        Me.ProductoDataGridViewTextBoxColumn.HeaderText = "Producto ID"
        Me.ProductoDataGridViewTextBoxColumn.Name = "ProductoDataGridViewTextBoxColumn"
        Me.ProductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ComprasFacturasViews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 565)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ComprasFacturasViews"
        Me.Text = "ComprasFacturasViews"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.DataGridCompras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompraBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridCompras As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents labelNombre As Label
    Friend WithEvents NumeroFacturaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents ComprasIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioCompraDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaIngresoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProvedorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CompraBindingSource As BindingSource
End Class
