Public Class ProvedoresViews

    Private provedorServices As New ProvedorServices

    Public Sub createProvedor()

        If txtNombre.Text <> "" And txtCuit.Text <> "" And txtTelefono.Text <> "" And txtImg.Text <> "" And txtCuit.Text <> "" Then
            Dim provedor As New Provedor
            Dim provedorImg As New UserProfileImage

            'Img Data
            provedorImg.ImageData = CommonFunctions.ToByte(txtImg.Text)


            'provedor nuevo

            provedor.Name = txtNombre.Text
            provedor.Telefono = txtCuit.Text
            provedor.Direccion = txtTelefono.Text
            provedor.Cuit = txtCuit.Text
            provedor.ProfileImage = provedorImg

            provedorServices.CreateProvedor(provedor)
            cargarDataGrid()
        Else
            MsgBox("Todos los campos son obligatorios")
        End If

    End Sub

    Public Sub actualizarProvedor()

        If txtNombre.Text <> "" And txtCuit.Text <> "" And txtTelefono.Text <> "" And txtImg.Text <> "" And txtCuit.Text <> "" Then
            Dim provedor As New Provedor
            Dim provedorImg As New UserProfileImage

            'Img Data
            provedorImg.ImageData = CommonFunctions.ToByte(txtImg.Text)
            provedorImg.Id = dataGridProvedor.CurrentRow.Cells(6).Value
            'provedor nuevo
            provedor.Name = txtNombre.Text
            provedor.Telefono = txtCuit.Text
            provedor.Direccion = txtTelefono.Text
            provedor.Cuit = txtCuit.Text
            provedor.ProfileImage = provedorImg
            provedor.Provedor_Id = dataGridProvedor.CurrentRow.Cells(1).Value
            provedorServices.UpdateCliente(provedor)
            cargarDataGrid()
        Else
            MsgBox("Todos los campos son obligatorios")
        End If

    End Sub

    Private Sub borrarProvedor()
        If dataGridProvedor.SelectedRows.Count > 0 Then

            Dim provedorId As Integer = dataGridProvedor.CurrentRow.Cells(1).Value

            provedorServices.RemoveProvedor(provedorId)
            cargarDataGrid()
        End If

    End Sub


    Private Sub cargarDataGrid()
        dataGridProvedor.DataSource = provedorServices.GetAllProvedores
    End Sub

    Public Sub cargarTxt()
        If dataGridProvedor.SelectedRows.Count > 0 Then

            txtNombre.Text = dataGridProvedor.CurrentRow.Cells(2).Value
            txtTelefono.Text = dataGridProvedor.CurrentRow.Cells(3).Value
            txtDireccion.Text = dataGridProvedor.CurrentRow.Cells(4).Value
            txtCuit.Text = dataGridProvedor.CurrentRow.Cells(4).Value
        Else
            MsgBox("Seleccione un Provedor")
        End If
    End Sub

    Public Sub limpiartxt()
        txtNombre.Text = ""
        txtDireccion.Text = ""
        txtImg.Text = ""
        txtCuit.Text = ""
        txtTelefono.Text = ""
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        createProvedor()
    End Sub

    Private Sub btnPic_Click(sender As Object, e As EventArgs) Handles btnPic.Click
        OpenFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp"
        OpenFileDialog1.Title = "Selecciona una imagen"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImg.Text = OpenFileDialog1.FileName ' Mostrar la ruta del archivo en el TextBox
            ' Aquí puedes manejar la lógica para cargar o mostrar la imagen seleccionada si es necesario
        End If
    End Sub

    Private Sub ProvedoresViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDataGrid()
        btnActualizar.Hide()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        borrarProvedor()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        cargarTxt()
        btnActualizar.Show()
        btnGuardar.Hide()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        actualizarProvedor()
        limpiartxt()
        btnActualizar.Hide()
        btnGuardar.Show()
    End Sub
End Class