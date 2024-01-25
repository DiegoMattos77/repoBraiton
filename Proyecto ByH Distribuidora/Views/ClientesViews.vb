Public Class ClientesViews

    Private clienteServices As New ClienteServices
    Private clienteRepository As New ClienteRepository
    Private facturaServices As New FacturaServices
    Private facturaRepository As New FacturaRepository

    Public Sub createCliente()

        If txtEmail.Text <> "" Then

            Dim clienteImg As New UserProfileImage

            'Img Data
            clienteImg.ImageData = CommonFunctions.ToByte(txtImg.Text)

            Dim clienteToInsert As New Cliente

            'usuario nuevo
            clienteToInsert.Name = txtNombre.Text
            clienteToInsert.Cuit = txtCuit.Text
            clienteToInsert.Email = txtEmail.Text
            clienteToInsert.Ciudad = txtCiudad.Text
            clienteToInsert.Telefono = txtCuit.Text
            clienteToInsert.Direccion = txtEmail.Text
            clienteToInsert.Vendedor_Id = ActiveUser.User_Id
            clienteToInsert.ProfileImage = clienteImg
            clienteServices.CreateCliente(clienteToInsert)
            cargarDataGrid()

        End If

    End Sub

    Public Sub ActualizarCliente()

        If txtId.Text <> "" Then
            Dim clienteToInsert As New Cliente
            'usuario nuevo
            clienteToInsert.Name = txtNombre.Text
            clienteToInsert.Cuit = txtCuit.Text
            clienteToInsert.Email = txtEmail.Text
            clienteToInsert.Ciudad = txtCiudad.Text
            clienteToInsert.Telefono = txtTelefono.Text
            clienteToInsert.Direccion = txtDireccion.Text
            clienteToInsert.Vendedor_Id = ActiveUser.User_Id
            clienteToInsert.Cliente_Id = txtId.Text
            clienteRepository.UpdateCliente(clienteToInsert)
            cargarDataGrid()
        Else
            MsgBox("Seleccione un cliente para actualizar")
        End If



    End Sub

    Private Sub cargarDataGrid()

        Dim listaCliente As List(Of Cliente) = clienteRepository.GetAll()
        dataGridCliente.DataSource = listaCliente

        'If ActiveUser.Rol = "ADMINISTRADOR" Then
        '    dataGridCliente.DataSource = clienteServices.GetAllClientes
        '    dataGridCliente.Columns(6).Visible = False
        '    btnActualizar.Hide()
        'End If

        'If ActiveUser.Rol = "VENDEDOR" Then
        '    dataGridCliente.DataSource = clienteServices.GetAllClientesByVendedor
        '    dataGridCliente.Columns(6).Visible = False
        '    btnActualizar.Hide()
        'End If
    End Sub

    Private Sub borrarCliente()
        If dataGridCliente.SelectedRows.Count > 0 Then

            Dim clienteId As Integer = dataGridCliente.CurrentRow.Cells(0).Value

            clienteServices.RemoveCliente(clienteId)
            cargarDataGrid()
        End If

    End Sub

    Public Sub cargarTxt()
        If dataGridCliente.SelectedRows.Count > 0 Then

            txtId.Text = dataGridCliente.CurrentRow.Cells(0).Value
            txtNombre.Text = dataGridCliente.CurrentRow.Cells(1).Value
            txtCuit.Text = dataGridCliente.CurrentRow.Cells(2).Value
            txtEmail.Text = dataGridCliente.CurrentRow.Cells(3).Value
            txtCiudad.Text = dataGridCliente.CurrentRow.Cells(4).Value
            txtCuit.Text = dataGridCliente.CurrentRow.Cells(5).Value
            txtEmail.Text = dataGridCliente.CurrentRow.Cells(6).Value

        Else
            MsgBox("Seleccione un Cliente")
        End If
    End Sub

    Public Sub limpiartxt()
        txtNombre.Text = ""
        txtEmail.Text = ""
        txtCuit.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        createCliente()
        limpiartxt()
    End Sub


    Private Sub ClientesViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDataGrid()
        'btnActualizar.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        borrarCliente()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        cargarTxt()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        ActualizarCliente()

    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        If dataGridCliente.SelectedRows.Count > 0 Then

            Dim ClienteId = dataGridCliente.CurrentRow.Cells(0).Value

            Dim listaFactura As List(Of Factura) = facturaRepository.SelectAllFacturaByCliente(ClienteId)


            Dim cliente As Cliente = clienteRepository.getClienteByID(ClienteId)



            CommonFunctions.GenerateDetalleClientePdf(cliente, listaFactura)

        End If
    End Sub

    Private Sub btnPic_Click(sender As Object, e As EventArgs) Handles btnPic.Click
        OpenFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp"
        OpenFileDialog1.Title = "Selecciona una imagen"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImg.Text = OpenFileDialog1.FileName ' Mostrar la ruta del archivo en el TextBox
            ' Aquí puedes manejar la lógica para cargar o mostrar la imagen seleccionada si es necesario
        End If
    End Sub
End Class