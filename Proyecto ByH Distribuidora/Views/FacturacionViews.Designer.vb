<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class facturacionviews
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(facturacionviews))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridFacturas = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.DataGridProductos = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Separator2 = New Guna.UI2.WinForms.Guna2Separator()
        Me.Guna2CircleButton4 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton5 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton6 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoFacturaDtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaDtoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreClienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel4.SuspendLayout()
        CType(Me.DataGridProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoFacturaDtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaDtoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2Panel2.Location = New System.Drawing.Point(12, 48)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(500, 505)
        Me.Guna2Panel2.TabIndex = 40
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.BackColor = System.Drawing.Color.White
        Me.labelNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.labelNombre.Location = New System.Drawing.Point(260, 17)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(176, 21)
        Me.labelNombre.TabIndex = 32
        Me.labelNombre.Text = "Registrar nueva venta"
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
        Me.Guna2Button1.Location = New System.Drawing.Point(221, 9)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(33, 33)
        Me.Guna2Button1.TabIndex = 28
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.BackColor = System.Drawing.Color.White
        Me.Guna2Separator1.Location = New System.Drawing.Point(3, 48)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(572, 10)
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
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(444, 9)
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
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 33)
        Me.Guna2TextBox1.TabIndex = 24
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.White
        Me.Guna2Panel3.BorderRadius = 22
        Me.Guna2Panel3.Controls.Add(Me.DataGridFacturas)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 64)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(473, 428)
        Me.Guna2Panel3.TabIndex = 23
        '
        'DataGridFacturas
        '
        Me.DataGridFacturas.AllowUserToDeleteRows = False
        Me.DataGridFacturas.AllowUserToResizeColumns = False
        Me.DataGridFacturas.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridFacturas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridFacturas.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridFacturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridFacturas.ColumnHeadersHeight = 30
        Me.DataGridFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridFacturas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FacturaIdDataGridViewTextBoxColumn, Me.NombreClienteDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.DataGridFacturas.DataSource = Me.FacturaDtoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridFacturas.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridFacturas.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridFacturas.Location = New System.Drawing.Point(10, 11)
        Me.DataGridFacturas.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridFacturas.Name = "DataGridFacturas"
        Me.DataGridFacturas.ReadOnly = True
        Me.DataGridFacturas.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridFacturas.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridFacturas.RowTemplate.DividerHeight = 3
        Me.DataGridFacturas.RowTemplate.Height = 40
        Me.DataGridFacturas.Size = New System.Drawing.Size(455, 404)
        Me.DataGridFacturas.TabIndex = 25
        Me.DataGridFacturas.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridFacturas.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridFacturas.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridFacturas.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridFacturas.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridFacturas.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridFacturas.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridFacturas.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridFacturas.ThemeStyle.ReadOnly = True
        Me.DataGridFacturas.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridFacturas.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridFacturas.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridFacturas.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridFacturas.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridFacturas.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridFacturas.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(12, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 28)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "Lista de ventas"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 22
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel4)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Separator2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton5)
        Me.Guna2Panel1.Controls.Add(Me.Guna2CircleButton6)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(539, 48)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(382, 513)
        Me.Guna2Panel1.TabIndex = 42
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.White
        Me.Guna2Panel4.BorderRadius = 22
        Me.Guna2Panel4.Controls.Add(Me.DataGridProductos)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(14, 64)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(350, 428)
        Me.Guna2Panel4.TabIndex = 26
        '
        'DataGridProductos
        '
        Me.DataGridProductos.AllowUserToDeleteRows = False
        Me.DataGridProductos.AllowUserToResizeColumns = False
        Me.DataGridProductos.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DataGridProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridProductos.AutoGenerateColumns = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridProductos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridProductos.ColumnHeadersHeight = 30
        Me.DataGridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn})
        Me.DataGridProductos.DataSource = Me.ProductoFacturaDtoBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridProductos.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridProductos.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridProductos.Location = New System.Drawing.Point(8, 11)
        Me.DataGridProductos.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridProductos.Name = "DataGridProductos"
        Me.DataGridProductos.ReadOnly = True
        Me.DataGridProductos.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProductos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridProductos.RowTemplate.DividerHeight = 3
        Me.DataGridProductos.RowTemplate.Height = 40
        Me.DataGridProductos.Size = New System.Drawing.Size(333, 404)
        Me.DataGridProductos.TabIndex = 25
        Me.DataGridProductos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridProductos.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridProductos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridProductos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridProductos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridProductos.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridProductos.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridProductos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red
        Me.DataGridProductos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridProductos.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridProductos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProductos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridProductos.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridProductos.ThemeStyle.ReadOnly = True
        Me.DataGridProductos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridProductos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridProductos.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridProductos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProductos.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridProductos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridProductos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 28)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Detalle de venta"
        '
        'Guna2Separator2
        '
        Me.Guna2Separator2.BackColor = System.Drawing.Color.White
        Me.Guna2Separator2.Location = New System.Drawing.Point(6, 51)
        Me.Guna2Separator2.Name = "Guna2Separator2"
        Me.Guna2Separator2.Size = New System.Drawing.Size(363, 10)
        Me.Guna2Separator2.TabIndex = 28
        '
        'Guna2CircleButton4
        '
        Me.Guna2CircleButton4.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton4.Image = CType(resources.GetObject("Guna2CircleButton4.Image"), System.Drawing.Image)
        Me.Guna2CircleButton4.Location = New System.Drawing.Point(769, 6)
        Me.Guna2CircleButton4.Name = "Guna2CircleButton4"
        Me.Guna2CircleButton4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton4.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton4.TabIndex = 27
        '
        'Guna2CircleButton5
        '
        Me.Guna2CircleButton5.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton5.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton5.Image = CType(resources.GetObject("Guna2CircleButton5.Image"), System.Drawing.Image)
        Me.Guna2CircleButton5.Location = New System.Drawing.Point(808, 6)
        Me.Guna2CircleButton5.Name = "Guna2CircleButton5"
        Me.Guna2CircleButton5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton5.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton5.TabIndex = 26
        '
        'Guna2CircleButton6
        '
        Me.Guna2CircleButton6.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton6.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton6.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton6.Image = CType(resources.GetObject("Guna2CircleButton6.Image"), System.Drawing.Image)
        Me.Guna2CircleButton6.Location = New System.Drawing.Point(847, 6)
        Me.Guna2CircleButton6.Name = "Guna2CircleButton6"
        Me.Guna2CircleButton6.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton6.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton6.TabIndex = 25
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoFacturaDtoBindingSource
        '
        Me.ProductoFacturaDtoBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.ProductoFacturaDto)
        '
        'FacturaDtoBindingSource
        '
        Me.FacturaDtoBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.FacturaDto)
        '
        'FacturaIdDataGridViewTextBoxColumn
        '
        Me.FacturaIdDataGridViewTextBoxColumn.DataPropertyName = "Factura_Id"
        Me.FacturaIdDataGridViewTextBoxColumn.HeaderText = "Factura ID"
        Me.FacturaIdDataGridViewTextBoxColumn.Name = "FacturaIdDataGridViewTextBoxColumn"
        Me.FacturaIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreClienteDataGridViewTextBoxColumn
        '
        Me.NombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre_Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre Cliente"
        Me.NombreClienteDataGridViewTextBoxColumn.Name = "NombreClienteDataGridViewTextBoxColumn"
        Me.NombreClienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "Total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'facturacionviews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 565)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "facturacionviews"
        Me.Text = "Users"
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.DataGridFacturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel4.ResumeLayout(False)
        CType(Me.DataGridProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoFacturaDtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaDtoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoPerfilDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents labelNombre As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridFacturas As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label21 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DataGridProductos As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Separator2 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents Guna2CircleButton4 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton5 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton6 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents FacturaDtoBindingSource As BindingSource
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoFacturaDtoBindingSource As BindingSource
    Friend WithEvents FacturaIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreClienteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
