<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormularioFacturaViews
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormularioFacturaViews))
        Me.DataGridProducto = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2Panel4 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtBuscador = New Guna.UI2.WinForms.Guna2TextBox()
        Me.labelNombre = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.FlowPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.Guna2VScrollBar1 = New Guna.UI2.WinForms.Guna2VScrollBar()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCuit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.labelRol = New System.Windows.Forms.Label()
        Me.clienteBox = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnPagar = New Guna.UI2.WinForms.Guna2Button()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioVentaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel4.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridProducto
        '
        Me.DataGridProducto.AllowUserToDeleteRows = False
        Me.DataGridProducto.AllowUserToResizeColumns = False
        Me.DataGridProducto.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridProducto.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridProducto.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridProducto.ColumnHeadersHeight = 30
        Me.DataGridProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PrecioVentaDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn})
        Me.DataGridProducto.DataSource = Me.ProductoBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridProducto.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridProducto.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridProducto.Location = New System.Drawing.Point(27, 64)
        Me.DataGridProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.DataGridProducto.Name = "DataGridProducto"
        Me.DataGridProducto.ReadOnly = True
        Me.DataGridProducto.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProducto.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridProducto.RowTemplate.DividerHeight = 3
        Me.DataGridProducto.RowTemplate.Height = 40
        Me.DataGridProducto.Size = New System.Drawing.Size(367, 442)
        Me.DataGridProducto.TabIndex = 27
        Me.DataGridProducto.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DataGridProducto.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridProducto.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridProducto.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridProducto.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridProducto.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridProducto.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridProducto.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red
        Me.DataGridProducto.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridProducto.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridProducto.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProducto.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DataGridProducto.ThemeStyle.HeaderStyle.Height = 30
        Me.DataGridProducto.ThemeStyle.ReadOnly = True
        Me.DataGridProducto.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DataGridProducto.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridProducto.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.DataGridProducto.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridProducto.ThemeStyle.RowsStyle.Height = 40
        Me.DataGridProducto.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.DataGridProducto.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        '
        'Guna2Panel4
        '
        Me.Guna2Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel4.BorderRadius = 22
        Me.Guna2Panel4.Controls.Add(Me.txtBuscador)
        Me.Guna2Panel4.Controls.Add(Me.labelNombre)
        Me.Guna2Panel4.FillColor = System.Drawing.Color.White
        Me.Guna2Panel4.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel4.Name = "Guna2Panel4"
        Me.Guna2Panel4.Size = New System.Drawing.Size(396, 541)
        Me.Guna2Panel4.TabIndex = 26
        '
        'txtBuscador
        '
        Me.txtBuscador.AutoRoundedCorners = True
        Me.txtBuscador.BackColor = System.Drawing.Color.White
        Me.txtBuscador.BorderRadius = 15
        Me.txtBuscador.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBuscador.DefaultText = ""
        Me.txtBuscador.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBuscador.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBuscador.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscador.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBuscador.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscador.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtBuscador.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBuscador.IconLeft = CType(resources.GetObject("txtBuscador.IconLeft"), System.Drawing.Image)
        Me.txtBuscador.Location = New System.Drawing.Point(179, 12)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBuscador.PlaceholderText = ""
        Me.txtBuscador.SelectedText = ""
        Me.txtBuscador.Size = New System.Drawing.Size(195, 33)
        Me.txtBuscador.TabIndex = 77
        '
        'labelNombre
        '
        Me.labelNombre.AutoSize = True
        Me.labelNombre.BackColor = System.Drawing.Color.White
        Me.labelNombre.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.labelNombre.Location = New System.Drawing.Point(10, 12)
        Me.labelNombre.Name = "labelNombre"
        Me.labelNombre.Size = New System.Drawing.Size(167, 28)
        Me.labelNombre.TabIndex = 76
        Me.labelNombre.Text = "Buscar producto"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.White
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.FlowPanel)
        Me.Guna2Panel1.Controls.Add(Me.Guna2VScrollBar1)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(435, 64)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(433, 235)
        Me.Guna2Panel1.TabIndex = 30
        '
        'FlowPanel
        '
        Me.FlowPanel.BackColor = System.Drawing.Color.White
        Me.FlowPanel.Location = New System.Drawing.Point(18, 22)
        Me.FlowPanel.Name = "FlowPanel"
        Me.FlowPanel.Size = New System.Drawing.Size(397, 196)
        Me.FlowPanel.TabIndex = 0
        '
        'Guna2VScrollBar1
        '
        Me.Guna2VScrollBar1.BackColor = System.Drawing.Color.White
        Me.Guna2VScrollBar1.BorderRadius = 3
        Me.Guna2VScrollBar1.InUpdate = False
        Me.Guna2VScrollBar1.LargeChange = 10
        Me.Guna2VScrollBar1.Location = New System.Drawing.Point(421, 25)
        Me.Guna2VScrollBar1.Name = "Guna2VScrollBar1"
        Me.Guna2VScrollBar1.ScrollbarSize = 10
        Me.Guna2VScrollBar1.Size = New System.Drawing.Size(10, 193)
        Me.Guna2VScrollBar1.TabIndex = 29
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 22
        Me.Guna2Panel2.Controls.Add(Me.Label21)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(435, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(433, 100)
        Me.Guna2Panel2.TabIndex = 27
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(16, 12)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(144, 28)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Nuevo Pedido"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel3.BorderRadius = 10
        Me.Guna2Panel3.Controls.Add(Me.Label6)
        Me.Guna2Panel3.Controls.Add(Me.Label7)
        Me.Guna2Panel3.Controls.Add(Me.Label5)
        Me.Guna2Panel3.Controls.Add(Me.lblTotal)
        Me.Guna2Panel3.Controls.Add(Me.Label4)
        Me.Guna2Panel3.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel3.Controls.Add(Me.txtCuit)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel3.Controls.Add(Me.labelRol)
        Me.Guna2Panel3.Controls.Add(Me.clienteBox)
        Me.Guna2Panel3.Controls.Add(Me.btnPagar)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(435, 322)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(431, 231)
        Me.Guna2Panel3.TabIndex = 32
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(205, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(187, 21)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Cantidad de productos:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(388, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 20)
        Me.Label7.TabIndex = 87
        Me.Label7.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(205, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 21)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Importe a pagar"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(346, 53)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(18, 20)
        Me.lblTotal.TabIndex = 85
        Me.lblTotal.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(335, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 20)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "$"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.Animated = True
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.White
        Me.Guna2TextBox1.BorderRadius = 5
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.Location = New System.Drawing.Point(11, 153)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.Size = New System.Drawing.Size(164, 31)
        Me.Guna2TextBox1.TabIndex = 79
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(11, 130)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(34, 19)
        Me.Guna2HtmlLabel2.TabIndex = 80
        Me.Guna2HtmlLabel2.Text = "Email"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuit
        '
        Me.txtCuit.Animated = True
        Me.txtCuit.BackColor = System.Drawing.Color.White
        Me.txtCuit.BorderRadius = 5
        Me.txtCuit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCuit.DefaultText = ""
        Me.txtCuit.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCuit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCuit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCuit.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCuit.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCuit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCuit.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCuit.Location = New System.Drawing.Point(11, 93)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuit.PlaceholderText = ""
        Me.txtCuit.SelectedText = ""
        Me.txtCuit.Size = New System.Drawing.Size(164, 31)
        Me.txtCuit.TabIndex = 77
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(11, 70)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(25, 19)
        Me.Guna2HtmlLabel1.TabIndex = 78
        Me.Guna2HtmlLabel1.Text = "Cuit"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labelRol
        '
        Me.labelRol.AutoSize = True
        Me.labelRol.BackColor = System.Drawing.Color.White
        Me.labelRol.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelRol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.labelRol.Location = New System.Drawing.Point(8, 10)
        Me.labelRol.Name = "labelRol"
        Me.labelRol.Size = New System.Drawing.Size(44, 15)
        Me.labelRol.TabIndex = 26
        Me.labelRol.Text = "Cliente"
        '
        'clienteBox
        '
        Me.clienteBox.BackColor = System.Drawing.Color.Transparent
        Me.clienteBox.BorderRadius = 10
        Me.clienteBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.clienteBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.clienteBox.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clienteBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.clienteBox.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.clienteBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.clienteBox.ItemHeight = 30
        Me.clienteBox.Location = New System.Drawing.Point(8, 28)
        Me.clienteBox.Name = "clienteBox"
        Me.clienteBox.Size = New System.Drawing.Size(167, 36)
        Me.clienteBox.TabIndex = 25
        '
        'btnPagar
        '
        Me.btnPagar.BackColor = System.Drawing.Color.White
        Me.btnPagar.BorderRadius = 10
        Me.btnPagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPagar.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPagar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnPagar.ForeColor = System.Drawing.Color.White
        Me.btnPagar.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(108, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(211, Byte), Integer))
        Me.btnPagar.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnPagar.Location = New System.Drawing.Point(11, 190)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(400, 38)
        Me.btnPagar.TabIndex = 24
        Me.btnPagar.Text = "Pagar Ahora"
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "Codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioVentaDataGridViewTextBoxColumn
        '
        Me.PrecioVentaDataGridViewTextBoxColumn.DataPropertyName = "Precio_Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.HeaderText = "Precio Venta"
        Me.PrecioVentaDataGridViewTextBoxColumn.Name = "PrecioVentaDataGridViewTextBoxColumn"
        Me.PrecioVentaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.Producto)
        '
        'FormularioFacturaViews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 565)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.DataGridProducto)
        Me.Controls.Add(Me.Guna2Panel4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormularioFacturaViews"
        Me.Text = "FormularioFacturaViews"
        CType(Me.DataGridProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel4.ResumeLayout(False)
        Me.Guna2Panel4.PerformLayout()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridProducto As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Panel4 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents FlowPanel As FlowLayoutPanel
    Friend WithEvents Guna2VScrollBar1 As Guna.UI2.WinForms.Guna2VScrollBar
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnPagar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clienteBox As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents labelRol As Label
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCuit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioVentaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductoBindingSource As BindingSource
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBuscador As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents labelNombre As Label
End Class
