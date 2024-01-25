

Public Class Main

    Private currentChildForm As Form
    Private clienteRepository As New ClienteRepository
    Private facturaRepository As New FacturaRepository

    Public Sub AbrirForm(form As Form)

        ' Verificar si hay un formulario abierto en el panelContenedor y cerrarlo
        If currentChildForm IsNot Nothing Then

            currentChildForm.Close()

        End If

        currentChildForm = form

        ' Configurar el formulario que se va a abrir
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill

        ' Agregar el formulario al panelContenedor con una transición
        Me.panelContenedor.Controls.Add(form)
        Me.panelContenedor.Tag = form
        form.BringToFront()
        form.Show()

    End Sub

    Public Sub cargarDatosUsuario()
        FotoPerfil.Image = CommonFunctions.ToImg(ActiveUser.ImgData)

        labelNombre.Text = ActiveUser.Name + " " + ActiveUser.Last_Name
        labelRol.Text = ActiveUser.Rol

    End Sub

    Public Sub cargarTotalClientes()
        Dim total As Integer = clienteRepository.GetTotal
        totalCliente.Text = total
    End Sub

    Public Sub cargarTotalPedidos()
        Dim total As Integer = facturaRepository.GetTotal
        totalPedidos.Text = total
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        cargarDatosUsuario()
        cargarTotalClientes()
        cargarTotalPedidos()

        If ActiveUser.Rol = "VENDEDOR" Then

            btnProductos.Visible = False
            btnUsuarios.Visible = False
            btnCompras.Visible = False
            btnProvedores.Visible = False
            'repositor
        End If

        If ActiveUser.Rol = "REPOSITOR" Then
            btnClientes.Visible = False
            btnFacturacion.Visible = False
            btnUsuarios.Visible = False

        End If
    End Sub


    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        AbrirForm(New ClientesViews)
    End Sub

    Private Sub btnFacturacion_Click(sender As Object, e As EventArgs) Handles btnFacturacion.Click
        AbrirForm(New FacturacionViews)
    End Sub

    Private Sub btnProductos_Click(sender As Object, e As EventArgs) Handles btnProductos.Click
        AbrirForm(New ProductosViews)
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        AbrirForm(New UsersViews)
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles FotoPerfil.Click
        If currentChildForm IsNot Nothing Then
            currentChildForm.Close()
        End If

    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Application.Exit()
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnCompras.Click
        AbrirForm(New ComprasFacturasViews)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnProvedores.Click
        AbrirForm(New ProvedoresViews)
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        CommonFunctions.GenerateFakerProductos()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        CommonFunctions.GenerateCliente()
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles totalCliente.Click

    End Sub
End Class