<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientesViews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientesViews))
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txtId = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtDireccion = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtTelefono = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCiudad = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.btnActualizar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmail = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtCuit = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtNombre = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2CircleButton3 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton2 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2CircleButton1 = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.dataGridCliente = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CuitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnPic = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.txtImg = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.dataGridCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 22
        Me.Guna2Panel1.Controls.Add(Me.btnPic)
        Me.Guna2Panel1.Controls.Add(Me.txtImg)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.txtId)
        Me.Guna2Panel1.Controls.Add(Me.txtDireccion)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel1.Controls.Add(Me.txtTelefono)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.txtCiudad)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.btnActualizar)
        Me.Guna2Panel1.Controls.Add(Me.btnGuardar)
        Me.Guna2Panel1.Controls.Add(Me.txtEmail)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.txtCuit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel1.Controls.Add(Me.txtNombre)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.Label21)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(243, 541)
        Me.Guna2Panel1.TabIndex = 1
        '
        'txtId
        '
        Me.txtId.Animated = True
        Me.txtId.BorderRadius = 5
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DefaultText = ""
        Me.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(183, 40)
        Me.txtId.Name = "txtId"
        Me.txtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtId.PlaceholderText = ""
        Me.txtId.SelectedText = ""
        Me.txtId.Size = New System.Drawing.Size(10, 13)
        Me.txtId.TabIndex = 45
        Me.txtId.Visible = False
        '
        'txtDireccion
        '
        Me.txtDireccion.Animated = True
        Me.txtDireccion.BorderRadius = 5
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.DefaultText = ""
        Me.txtDireccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtDireccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtDireccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtDireccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtDireccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(10, 369)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDireccion.PlaceholderText = ""
        Me.txtDireccion.SelectedText = ""
        Me.txtDireccion.Size = New System.Drawing.Size(223, 30)
        Me.txtDireccion.TabIndex = 43
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(10, 346)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(57, 19)
        Me.Guna2HtmlLabel2.TabIndex = 44
        Me.Guna2HtmlLabel2.Text = "Direccion"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.Animated = True
        Me.txtTelefono.BorderRadius = 5
        Me.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono.DefaultText = ""
        Me.txtTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(10, 310)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTelefono.PlaceholderText = ""
        Me.txtTelefono.SelectedText = ""
        Me.txtTelefono.Size = New System.Drawing.Size(223, 30)
        Me.txtTelefono.TabIndex = 41
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(10, 287)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(54, 19)
        Me.Guna2HtmlLabel4.TabIndex = 42
        Me.Guna2HtmlLabel4.Text = "Telefono"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCiudad
        '
        Me.txtCiudad.Animated = True
        Me.txtCiudad.BorderRadius = 5
        Me.txtCiudad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCiudad.DefaultText = ""
        Me.txtCiudad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCiudad.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCiudad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCiudad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCiudad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCiudad.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCiudad.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCiudad.Location = New System.Drawing.Point(10, 251)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCiudad.PlaceholderText = ""
        Me.txtCiudad.SelectedText = ""
        Me.txtCiudad.Size = New System.Drawing.Size(223, 30)
        Me.txtCiudad.TabIndex = 39
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(10, 228)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(44, 19)
        Me.Guna2HtmlLabel6.TabIndex = 40
        Me.Guna2HtmlLabel6.Text = "Ciudad"
        Me.Guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnActualizar
        '
        Me.btnActualizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnActualizar.BorderRadius = 5
        Me.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnActualizar.FillColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnActualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnActualizar.Location = New System.Drawing.Point(10, 464)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(223, 36)
        Me.btnActualizar.TabIndex = 37
        Me.btnActualizar.Text = "Actualizar"
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnGuardar.BorderRadius = 5
        Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGuardar.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnGuardar.Location = New System.Drawing.Point(10, 506)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(223, 32)
        Me.btnGuardar.TabIndex = 36
        Me.btnGuardar.Text = "Guardar"
        '
        'txtEmail
        '
        Me.txtEmail.Animated = True
        Me.txtEmail.BorderRadius = 5
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.DefaultText = ""
        Me.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(10, 192)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmail.PlaceholderText = ""
        Me.txtEmail.SelectedText = ""
        Me.txtEmail.Size = New System.Drawing.Size(223, 30)
        Me.txtEmail.TabIndex = 27
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(10, 169)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(34, 19)
        Me.Guna2HtmlLabel3.TabIndex = 28
        Me.Guna2HtmlLabel3.Text = "Email"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCuit
        '
        Me.txtCuit.Animated = True
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
        Me.txtCuit.Location = New System.Drawing.Point(10, 133)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCuit.PlaceholderText = ""
        Me.txtCuit.SelectedText = ""
        Me.txtCuit.Size = New System.Drawing.Size(223, 30)
        Me.txtCuit.TabIndex = 25
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(10, 110)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(25, 19)
        Me.Guna2HtmlLabel1.TabIndex = 26
        Me.Guna2HtmlLabel1.Text = "Cuit"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.Animated = True
        Me.txtNombre.BorderRadius = 5
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.DefaultText = ""
        Me.txtNombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtNombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtNombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(10, 74)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNombre.PlaceholderText = ""
        Me.txtNombre.SelectedText = ""
        Me.txtNombre.Size = New System.Drawing.Size(223, 30)
        Me.txtNombre.TabIndex = 23
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(10, 51)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(52, 19)
        Me.Guna2HtmlLabel5.TabIndex = 24
        Me.Guna2HtmlLabel5.Text = "Nombre"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.Label21.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label21.Location = New System.Drawing.Point(31, 9)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(174, 28)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Datos del Cliente"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Guna2Panel2.BorderRadius = 22
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton3)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2CircleButton1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2TextBox1)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.White
        Me.Guna2Panel2.Location = New System.Drawing.Point(282, 12)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(639, 541)
        Me.Guna2Panel2.TabIndex = 38
        '
        'Guna2CircleButton3
        '
        Me.Guna2CircleButton3.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton3.Image = CType(resources.GetObject("Guna2CircleButton3.Image"), System.Drawing.Image)
        Me.Guna2CircleButton3.Location = New System.Drawing.Point(515, 6)
        Me.Guna2CircleButton3.Name = "Guna2CircleButton3"
        Me.Guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton3.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton3.TabIndex = 27
        '
        'Guna2CircleButton2
        '
        Me.Guna2CircleButton2.BackColor = System.Drawing.Color.White
        Me.Guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2CircleButton2.FillColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.Guna2CircleButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2CircleButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2CircleButton2.Image = CType(resources.GetObject("Guna2CircleButton2.Image"), System.Drawing.Image)
        Me.Guna2CircleButton2.Location = New System.Drawing.Point(554, 6)
        Me.Guna2CircleButton2.Name = "Guna2CircleButton2"
        Me.Guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CircleButton2.Size = New System.Drawing.Size(33, 33)
        Me.Guna2CircleButton2.TabIndex = 26
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
        Me.Guna2CircleButton1.Location = New System.Drawing.Point(593, 6)
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
        Me.Guna2TextBox1.Location = New System.Drawing.Point(15, 6)
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
        Me.Guna2Panel3.Controls.Add(Me.Guna2Separator1)
        Me.Guna2Panel3.Controls.Add(Me.dataGridCliente)
        Me.Guna2Panel3.FillColor = System.Drawing.Color.White
        Me.Guna2Panel3.Location = New System.Drawing.Point(16, 40)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.Size = New System.Drawing.Size(610, 489)
        Me.Guna2Panel3.TabIndex = 23
        '
        'Guna2Separator1
        '
        Me.Guna2Separator1.Location = New System.Drawing.Point(-16, -3)
        Me.Guna2Separator1.Name = "Guna2Separator1"
        Me.Guna2Separator1.Size = New System.Drawing.Size(626, 10)
        Me.Guna2Separator1.TabIndex = 26
        '
        'dataGridCliente
        '
        Me.dataGridCliente.AllowUserToDeleteRows = False
        Me.dataGridCliente.AllowUserToResizeColumns = False
        Me.dataGridCliente.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dataGridCliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGridCliente.AutoGenerateColumns = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dataGridCliente.ColumnHeadersHeight = 30
        Me.dataGridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGridCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.CuitDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3, Me.CiudadDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn})
        Me.dataGridCliente.DataSource = Me.ClienteBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGridCliente.DefaultCellStyle = DataGridViewCellStyle3
        Me.dataGridCliente.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridCliente.Location = New System.Drawing.Point(21, 11)
        Me.dataGridCliente.Margin = New System.Windows.Forms.Padding(1)
        Me.dataGridCliente.Name = "dataGridCliente"
        Me.dataGridCliente.ReadOnly = True
        Me.dataGridCliente.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridCliente.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dataGridCliente.RowTemplate.DividerHeight = 3
        Me.dataGridCliente.RowTemplate.Height = 40
        Me.dataGridCliente.Size = New System.Drawing.Size(588, 469)
        Me.dataGridCliente.TabIndex = 25
        Me.dataGridCliente.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dataGridCliente.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dataGridCliente.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dataGridCliente.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dataGridCliente.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dataGridCliente.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dataGridCliente.ThemeStyle.GridColor = System.Drawing.Color.WhiteSmoke
        Me.dataGridCliente.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Red
        Me.dataGridCliente.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dataGridCliente.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dataGridCliente.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridCliente.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dataGridCliente.ThemeStyle.HeaderStyle.Height = 30
        Me.dataGridCliente.ThemeStyle.ReadOnly = True
        Me.dataGridCliente.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.dataGridCliente.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dataGridCliente.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.dataGridCliente.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dataGridCliente.ThemeStyle.RowsStyle.Height = 40
        Me.dataGridCliente.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.dataGridCliente.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.SystemColors.ButtonHighlight
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cliente_Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'CuitDataGridViewTextBoxColumn
        '
        Me.CuitDataGridViewTextBoxColumn.DataPropertyName = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.HeaderText = "Cuit"
        Me.CuitDataGridViewTextBoxColumn.Name = "CuitDataGridViewTextBoxColumn"
        Me.CuitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        Me.CiudadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteBindingSource
        '
        Me.ClienteBindingSource.DataSource = GetType(Proyecto_ByH_Distribuidora.Cliente)
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnPic
        '
        Me.btnPic.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(47, Byte), Integer))
        Me.btnPic.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPic.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPic.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPic.FillColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnPic.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnPic.ForeColor = System.Drawing.Color.White
        Me.btnPic.Image = CType(resources.GetObject("btnPic.Image"), System.Drawing.Image)
        Me.btnPic.Location = New System.Drawing.Point(203, 428)
        Me.btnPic.Name = "btnPic"
        Me.btnPic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.btnPic.Size = New System.Drawing.Size(30, 30)
        Me.btnPic.TabIndex = 48
        '
        'txtImg
        '
        Me.txtImg.Animated = True
        Me.txtImg.BorderRadius = 5
        Me.txtImg.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImg.DefaultText = ""
        Me.txtImg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtImg.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtImg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtImg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtImg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtImg.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtImg.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtImg.Location = New System.Drawing.Point(10, 428)
        Me.txtImg.Name = "txtImg"
        Me.txtImg.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtImg.PlaceholderText = ""
        Me.txtImg.ReadOnly = True
        Me.txtImg.SelectedText = ""
        Me.txtImg.Size = New System.Drawing.Size(187, 30)
        Me.txtImg.TabIndex = 46
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(123, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(10, 405)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(62, 19)
        Me.Guna2HtmlLabel7.TabIndex = 47
        Me.Guna2HtmlLabel7.Text = "Foto Perfil"
        Me.Guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClientesViews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(933, 565)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientesViews"
        Me.Text = "Users"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel3.ResumeLayout(False)
        CType(Me.dataGridCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UseridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RolDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoPerfilDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btnActualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEmail As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCuit As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtNombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Label21 As Label
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2CircleButton3 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton2 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2CircleButton1 As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Friend WithEvents dataGridCliente As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ClienteIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtDireccion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtCiudad As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents CuitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClienteBindingSource As BindingSource
    Friend WithEvents txtId As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnPic As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents txtImg As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
