Public Class UsersViews



    Private userServices As New UserServices

    Public Sub createUser()
        Dim userToInsert As New User
        Dim userImgData As New UserProfileImage

        If txtEmail.Text <> "" And txrNombre.Text <> "" And txtPassword.Text <> "" And txtApellido.Text <> "" And txtRol.Text <> "" And txtImg.Text <> "" Then

            'Img Data
            userImgData.ImageData = CommonFunctions.toByte(txtImg.Text)

            'usuario nuevo
            userToInsert.Email = txtEmail.Text
            userToInsert.Name = txrNombre.Text
            userToInsert.Password = txtPassword.Text
            userToInsert.Last_name = txtApellido.Text
            userToInsert.Rol = txtRol.Text
            userToInsert.ProfileImage = userImgData

            userServices.CreateUser(userToInsert)


        Else
            MsgBox("Los campos son obligatorios")
        End If


    End Sub

    Public Sub EditarUsuario()

        Dim userToInsert As New User
        Dim userImgData As New UserProfileImage



        If txtEmail.Text <> "" And txrNombre.Text <> "" And txtPassword.Text <> "" And txtApellido.Text <> "" And txtRol.Text <> "" And txtImg.Text <> "" Then

            'Img Data
            userImgData.ImageData = CommonFunctions.ToByte(txtImg.Text)
            userImgData.Id = DataGridUsuarios.CurrentRow.Cells(7).Value
            'usuario nuevo
            userToInsert.User_id = DataGridUsuarios.CurrentRow.Cells(1).Value
            userToInsert.Email = txtEmail.Text
            userToInsert.Name = txrNombre.Text
            userToInsert.Password = txtPassword.Text
            userToInsert.Last_name = txtApellido.Text
            userToInsert.Rol = txtRol.Text
            userToInsert.ProfileImage = userImgData

            userServices.UpdateUser(userToInsert)

            cargarDataGrid()

        Else
            MsgBox("Los campos son obligatorios")
        End If






    End Sub

    Public Sub cargarTxt()

        If DataGridUsuarios.SelectedRows.Count > 0 Then

            txtEmail.Text = DataGridUsuarios.CurrentRow.Cells(2).Value
            txrNombre.Text = DataGridUsuarios.CurrentRow.Cells(3).Value
            txtPassword.Text = DataGridUsuarios.CurrentRow.Cells(4).Value
            txtApellido.Text = DataGridUsuarios.CurrentRow.Cells(5).Value


        Else
            MsgBox("Seleccione un usuario")
        End If
    End Sub

    Public Sub EliminarUsuario()

        If DataGridUsuarios.SelectedRows.Count > 0 Then

            Dim userId As Integer = DataGridUsuarios.CurrentRow.Cells(1).Value

            userServices.DeleteUser(userId)
            cargarDataGrid()
        End If

    End Sub

    Private Sub cargarDataGrid()

        DataGridUsuarios.DataSource = userServices.GetAllUsers

    End Sub

    Public Sub limpiarTxt()

        txtEmail.Text = ""
        txrNombre.Text = ""
        txtApellido.Text = ""
        txtEmail.Text = ""
        txtPassword.Text = ""
        txtImg.Text = ""


    End Sub

    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarDataGrid()
        btnActualizar.Hide()
    End Sub

    Private Sub btnPic_Click(sender As Object, e As EventArgs) Handles btnPic.Click
        OpenFileDialog1.Filter = "Archivos de imagen|*.png;*.jpg;*.jpeg;*.gif;*.bmp"
        OpenFileDialog1.Title = "Selecciona una imagen"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtImg.Text = OpenFileDialog1.FileName ' Mostrar la ruta del archivo en el TextBox
            ' Aquí puedes manejar la lógica para cargar o mostrar la imagen seleccionada si es necesario
        End If
    End Sub




    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        EliminarUsuario()
    End Sub

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        cargarTxt()
        btnActualizar.Show()
        btnGuardar.Hide()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        createUser()
        cargarDataGrid()
        limpiarTxt()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        EditarUsuario()
        limpiarTxt()
        btnGuardar.Show()
        btnActualizar.Hide()
    End Sub


End Class