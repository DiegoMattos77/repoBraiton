Public Class ComprasViews

    Private productoRepository As New ProductoRepository
    Private provedorServices As New ProvedorServices
    Private listaProvedores As New List(Of ProvedorDto)


    Public Sub GuardarDatosProducto()

        'Creo un nuevo producto
        Dim producto As New Producto

        producto.Codigo = txtCodigo.Text
        producto.Precio_Compra = txtPrecio_Compra.Text
        producto.Precio_Venta = txtPrecio_Venta.Text
        producto.Name = txtNombre.Text
        producto.Stock_Minimo = txtStock_Minimo.Text
        producto.Codigo = txtCodigo.Text
        producto.Codigo = txtCodigo.Text

        'Creo un nuevo Provedor
        Dim provedor As New Provedor
        provedor.Provedor_Id = txtID_Provedor.Text


        Dim facturaCompra As New Compra
        facturaCompra.Cantidad = txtCantidad.Text
        facturaCompra.Provedor = provedor
        facturaCompra.Producto = producto
        facturaCompra.Fecha_Ingreso = txtFecha.Value


        productoRepository.GuardarProductoStock(producto, facturaCompra)
        CargarProductos()

    End Sub

    Public Sub ActualizarDatos()
        'Creo un nuevo producto
        Dim producto As New Producto

        producto.Codigo = txtCodigo.Text
        producto.Precio_Compra = txtPrecio_Compra.Text
        producto.Precio_Venta = txtPrecio_Venta.Text
        producto.Name = txtNombre.Text
        producto.Stock_Minimo = txtStock_Minimo.Text
        producto.Codigo = txtCodigo.Text
        producto.Codigo = txtCodigo.Text

        'Creo un nuevo Provedor
        Dim provedor As New Provedor
        provedor.Provedor_Id = txtID_Provedor.Text


        Dim facturaCompra As New Compra
        facturaCompra.Cantidad = txtCantidad.Text
        facturaCompra.Provedor = provedor
        facturaCompra.Producto = producto
        facturaCompra.Fecha_Ingreso = txtFecha.Value

        producto.Producto_Id = txtIDProducto.Text
        productoRepository.UpdateStockByCompra(producto, facturaCompra)
        CargarProductos()
    End Sub

    Public Sub CargarNombreProvedor()

        listaProvedores = provedorServices.GetAllProvedores

        ' Extraer solo los nombres usando LINQ
        Dim nombresProvedores As List(Of String) = listaProvedores.Select(Function(provedor) provedor.Name).ToList()

        txtProvedor.DataSource = nombresProvedores
    End Sub

    Public Sub CargarProductos()

        Dim listaProducto As List(Of Producto) = productoRepository.GetAllProducto
        DataGridProductos.DataSource = listaProducto

    End Sub

    Public Function ValidarCampos()

        Return txtCodigo.Text <> "" And txtPrecio_Compra.Text <> "" And txtPrecio_Venta.Text <> ""

    End Function

    Public Sub LimpiarTxt()
        txtIDProducto.Text = ""
        txtCodigo.Text = ""
        txtPrecio_Compra.Text = ""
        txtPrecio_Venta.Text = ""
        txtNombre.Text = ""
        txtStockActual.Text = ""
        txtStock_Minimo.Text = ""
        txtCantidad.Text = ""
    End Sub

    Private Sub FiltrarProducto()
        ' Obtener todos los productos
        Dim listaProducto As List(Of Producto) = productoRepository.GetAllProducto

        ' Filtrar la lista basado en el texto ingresado en el TextBox
        Dim productosFiltrados = listaProducto.Where(Function(p) p.Name.Contains(txtBuscador.Text)).ToList()

        ' Actualizar el DataSource del DataGridView
        DataGridProductos.DataSource = productosFiltrados
    End Sub


    Private Sub btnRegistarCompra_Click(sender As Object, e As EventArgs) Handles btnRegistarCompra.Click

        If ValidarCampos() Then
            GuardarDatosProducto()
            LimpiarTxt()
        Else
            MsgBox("Todos los campos son obligatorios")
        End If

    End Sub

    Private Sub ComprasViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarNombreProvedor()
        CargarProductos()
        btnActualizar.Hide()
    End Sub

    Private Sub txtProvedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtProvedor.SelectedIndexChanged
        ' Obtener el nombre seleccionado
        Dim nombreSeleccionado As String = txtProvedor.SelectedItem.ToString()

        ' Buscar el objeto ProvedorDto relacionado con el nombre seleccionado
        Dim provedorSeleccionado As ProvedorDto = listaProvedores.FirstOrDefault(Function(p) p.Name = nombreSeleccionado)

        ' Si encontramos un proveedor, llenamos los campos de texto con sus datos
        If provedorSeleccionado IsNot Nothing Then
            txtTelefono.Text = provedorSeleccionado.Telefono
            txtCuit.Text = provedorSeleccionado.Cuit
            txtDirreccion.Text = provedorSeleccionado.Direccion
            txtID_Provedor.Text = provedorSeleccionado.Provedor_Id
        End If
    End Sub



    Private Sub DataGridProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductos.CellClick


        ' Verifica si la fila es válida
        If e.RowIndex >= 0 Then
            ' Obtiene el objeto Producto de la fila seleccionada
            Dim producto As Producto = CType(DataGridProductos.Rows(e.RowIndex).DataBoundItem, Producto)

            ' Aquí puedes hacer lo que necesites con el objeto producto
            txtIDProducto.Text = producto.Producto_Id
            txtCodigo.Text = producto.Codigo
            txtPrecio_Compra.Text = producto.Precio_Compra
            txtPrecio_Venta.Text = producto.Precio_Venta
            txtNombre.Text = producto.Name
            txtStockActual.Text = producto.Stock
            txtStock_Minimo.Text = producto.Stock_Minimo

            btnActualizar.Show()
            btnRegistarCompra.Hide()
        End If



    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        If txtIDProducto.Text <> "" And txtCantidad.Text <> "" Then
            ActualizarDatos()
            LimpiarTxt()
            btnRegistarCompra.Show()
            btnActualizar.Hide()
        Else
            MsgBox("rellene los campos")
        End If
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        FiltrarProducto()
    End Sub

    Private Sub txtPrecio_Compra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio_Compra.KeyPress
        ' Permite solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignora el caracter
        End If
    End Sub

    Private Sub txtPrecio_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio_Venta.KeyPress
        ' Permite solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignora el caracter
        End If
    End Sub

    Private Sub txtStock_Minimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStock_Minimo.KeyPress
        ' Permite solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignora el caracter
        End If
    End Sub


    Private Sub txtCodigo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigo.KeyPress
        ' Permite solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignora el caracter
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        ' Permite solo números y la tecla de retroceso
        If Not Char.IsDigit(e.KeyChar) AndAlso Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True ' Ignora el caracter
        End If
    End Sub

    Private Sub txtPrecio_Compra_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio_Compra.TextChanged
        ' Validar que el texto sea un número válido y mayor a 0
        Dim valor As Decimal

        If Decimal.TryParse(txtPrecio_Compra.Text, valor) Then
            If valor <= 0 Then
                txtPrecio_Compra.Text = ""
            End If
        Else
            If txtPrecio_Compra.Text <> "" Then
                ' Maneja el caso en el que no es un número
                txtPrecio_Compra.Text = ""
                ' MessageBox.Show("Ingrese solo valores numéricos")
            End If
        End If
    End Sub

    Private Sub txtPrecio_Venta_TextChanged(sender As Object, e As EventArgs) Handles txtPrecio_Venta.TextChanged
        ' Validar que el texto sea un número válido y mayor a 0
        Dim valor As Decimal

        If Decimal.TryParse(txtPrecio_Venta.Text, valor) Then
            If valor <= 0 Then
                txtPrecio_Venta.Text = ""
            End If
        Else
            If txtPrecio_Venta.Text <> "" Then
                ' Maneja el caso en el que no es un número
                txtPrecio_Venta.Text = ""
                ' MessageBox.Show("Ingrese solo valores numéricos")
            End If
        End If
    End Sub

    Private Sub txtStock_Minimo_TextChanged(sender As Object, e As EventArgs) Handles txtStock_Minimo.TextChanged
        ' Validar que el texto sea un número válido y mayor a 0
        Dim valor As Decimal

        If Decimal.TryParse(txtStock_Minimo.Text, valor) Then
            If valor <= 0 Then
                txtStock_Minimo.Text = ""
            End If
        Else
            If txtStock_Minimo.Text <> "" Then
                ' Maneja el caso en el que no es un número
                txtStock_Minimo.Text = ""
                ' MessageBox.Show("Ingrese solo valores numéricos")
            End If
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        ' Validar que el texto sea un número válido y mayor a 0
        Dim valor As Decimal

        If Decimal.TryParse(txtCantidad.Text, valor) Then
            If valor <= 0 Then
                txtCantidad.Text = ""
            End If
        Else
            If txtCantidad.Text <> "" Then
                ' Maneja el caso en el que no es un número
                txtCantidad.Text = ""
                ' MessageBox.Show("Ingrese solo valores numéricos")
            End If
        End If
    End Sub
End Class