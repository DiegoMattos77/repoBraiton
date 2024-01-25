Public Class VentaViews

    Private productoRepository As New ProductoRepository
    Private clienteRepository As New ClienteRepository
    Private facturaRepository As New FacturaRepository

    Private listaOfCarrito As New HashSet(Of ProductoVenta)
    Private listaClientes As New List(Of Cliente)
    Private FacturaId As Integer


    Public Sub CargarProductos()

        Dim listaProducto As List(Of Producto) = productoRepository.GetAllProducto
        DataGridProductos.DataSource = listaProducto

    End Sub

    Private Sub FiltrarProducto()
        ' Obtener todos los productos
        Dim listaProducto As List(Of Producto) = productoRepository.GetAllProducto

        ' Texto del filtro en minúsculas
        Dim textoFiltro As String = txtBuscador.Text.ToLower()

        ' Filtrar la lista basado en el texto ingresado en el TextBox, ignorando mayúsculas/minúsculas
        Dim productosFiltrados = listaProducto.Where(Function(p) p.Name.ToLower().Contains(textoFiltro)).ToList()

        ' Actualizar el DataSource del DataGridView
        DataGridProductos.DataSource = productosFiltrados
    End Sub

    Public Sub AgregarProductoCarrito()
        If txtNombre.Text <> "" And contador.Value > 0 Then
            Dim producto As New ProductoVenta With {
            .Codigo = txtCodigo.Text,
            .Nombre = txtNombre.Text,
            .Precio = Convert.ToDecimal(txtPrecio.Text),
            .Cantidad = contador.Value,
            .Producto_Id = txtIDProducto.Text
        }

            ' Comprobar si el HashSet ya contiene un producto con el mismo código
            Dim productoExistente As ProductoVenta = listaOfCarrito.FirstOrDefault(Function(p) p.Codigo = producto.Codigo)

            If productoExistente Is Nothing Then
                If txtStock.Text >= producto.Cantidad Then
                    ' Si no existe, lo agregamos.
                    listaOfCarrito.Add(producto)
                    lblTotal.Text = CalcularTotalCarrito()
                    lblCantidad.Text = listaOfCarrito.Count
                Else
                    MsgBox("no hay stock")
                End If

            Else

                MsgBox("El producto ya esta en el carrito de compra")

            End If
        End If

        ' Actualizar el DataSource
        DataCarrito.DataSource = Nothing
        DataCarrito.DataSource = listaOfCarrito.ToList()
        DataCarrito.Refresh()
    End Sub

    Public Function CalcularTotalCarrito() As Decimal
        ' Usamos LINQ para sumar el producto del precio y la cantidad de cada producto en el carrito
        Dim totalCarrito As Decimal = listaOfCarrito.Sum(Function(producto) producto.Precio * producto.Cantidad)
        Return totalCarrito
    End Function

    Public Sub BorrarProductoCarrito()
        If DataCarrito.SelectedRows.Count > 0 Then

            Dim productoCodigo As Integer = DataCarrito.CurrentRow.Cells(0).Value

            ' Encontrar el producto en el HashSet
            Dim productoAEliminar As ProductoVenta = listaOfCarrito.FirstOrDefault(Function(p) p.Codigo = productoCodigo.ToString())

            ' Si encontramos el producto, lo eliminamos del HashSet
            If productoAEliminar IsNot Nothing Then
                listaOfCarrito.Remove(productoAEliminar)
                lblCantidad.Text = listaOfCarrito.Count
                ' Actualizar el DataSource
                DataCarrito.DataSource = Nothing
                DataCarrito.DataSource = listaOfCarrito.ToList()
                DataCarrito.Refresh()
                lblTotal.Text = CalcularTotalCarrito()
            Else
                ' Manejo de la situación donde el producto no se encuentra (opcional)
                MessageBox.Show("Producto no encontrado en el carrito.")
            End If
        Else
            ' Manejo de la situación donde no hay ninguna fila seleccionada (opcional)
            MessageBox.Show("Por favor, seleccione un producto para eliminar.")
        End If



    End Sub

    Public Sub CargarNombreClientes()

        listaClientes = clienteRepository.GetAll

        Dim nombresClientes As List(Of String) = listaClientes.Select(Function(cliente) cliente.Name).ToList()

        comboCliente.DataSource = nombresClientes
    End Sub

    Public Sub GuardarDatosFacturas()

        Dim factura As New Factura With {
            .Cliente_Id = txtClienteId.Text,
            .Total = lblTotal.Text,
            .Fecha = Now(),
            .ListaProducto = listaOfCarrito
        }
        FacturaId = facturaRepository.Insertar(factura)

    End Sub


    Private Sub btnAgregarCarrito_Click(sender As Object, e As EventArgs) Handles btnAgregarCarrito.Click
        AgregarProductoCarrito()
    End Sub

    Private Sub VentaViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarProductos()
        CargarNombreClientes()
    End Sub

    Private Sub txtBuscador_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        FiltrarProducto()
    End Sub

    Private Sub DataGridProductos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProductos.CellClick
        ' Verifica si la fila es válida
        If e.RowIndex >= 0 Then
            ' Obtiene el objeto Producto de la fila seleccionada
            Dim producto As Producto = CType(DataGridProductos.Rows(e.RowIndex).DataBoundItem, Producto)
            txtStock.Text = producto.Stock
            If txtStock.Text <> 0 Then
                txtCodigo.Text = producto.Codigo
                txtNombre.Text = producto.Name
                txtPrecio.Text = producto.Precio_Venta

                txtIDProducto.Text = producto.Producto_Id
            Else
                MsgBox("Producto Sin Stock")
            End If


        End If

        contador.Maximum = txtStock.Text
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        BorrarProductoCarrito()
    End Sub

    Private Sub comboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboCliente.SelectedIndexChanged
        ' Obtener el nombre seleccionado
        Dim nombreSeleccionado As String = comboCliente.SelectedItem.ToString()

        ' Buscar el objeto ProvedorDto relacionado con el nombre seleccionado
        Dim ClienteSeleccionado As Cliente = listaClientes.FirstOrDefault(Function(cliente) cliente.Name = nombreSeleccionado)

        ' Si encontramos un proveedor, llenamos los campos de texto con sus datos
        If ClienteSeleccionado IsNot Nothing Then
            txtCuit.Text = ClienteSeleccionado.Telefono
            txtClienteId.Text = ClienteSeleccionado.Cliente_Id
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If listaOfCarrito.Count > 0 Then
            GuardarDatosFacturas()
            CargarProductos()

            Dim cliente As Cliente = clienteRepository.getClienteByID(txtClienteId.Text)

            'CommonFunctions.GenerateFacturaPdf(cliente, FacturaId, listaOfCarrito)

            ' Actualizar el DataSource
            listaOfCarrito.Clear()
            DataCarrito.DataSource = Nothing
            DataCarrito.DataSource = listaOfCarrito.ToList()
            DataCarrito.Refresh()
        End If
    End Sub


End Class