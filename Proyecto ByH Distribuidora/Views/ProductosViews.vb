Public Class ProductosViews

    Private productoRepository As New ProductoRepository
    Private datosProducto As New Producto




    Private Sub DataGridProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProducto.CellClick
        ' Verifica si la fila es válida
        If e.RowIndex >= 0 Then
            ' Obtiene el objeto Producto de la fila seleccionada
            datosProducto = CType(DataGridProducto.Rows(e.RowIndex).DataBoundItem, Producto)

            ' Aquí puedes hacer lo que necesites con el objeto producto
            txtID.Text = datosProducto.Producto_Id
            txtCodigo.Text = datosProducto.Codigo
            txtPrecio_Compra.Text = datosProducto.Precio_Compra
            txtPrecio_Venta.Text = datosProducto.Precio_Venta
            txtNombre.Text = datosProducto.Name
            txtStockActual.Text = datosProducto.Stock
            txtStock_Minimo.Text = datosProducto.Stock_Minimo

        End If
    End Sub

    Public Sub ActualizarProducto()

        Dim producto As New Producto

        producto.Producto_Id = txtID.Text
        producto.Codigo = txtCodigo.Text
        producto.Precio_Compra = txtPrecio_Compra.Text
        producto.Precio_Venta = txtPrecio_Venta.Text
        producto.Name = txtNombre.Text
        producto.Stock = txtStockActual.Text
        producto.Stock_Minimo = txtStock_Minimo.Text

        MsgBox(producto.Producto_Id)
        productoRepository.UpdateProducto(producto)

    End Sub

    Private Sub FiltrarProducto()
        ' Obtener todos los productos
        Dim listaProducto As List(Of Producto) = productoRepository.GetAllProducto

        ' Filtrar la lista basado en el texto ingresado en el TextBox
        Dim productosFiltrados = listaProducto.Where(Function(p) p.Name.Contains(txtBuscador.Text)).ToList()

        ' Actualizar el DataSource del DataGridView
        DataGridProducto.DataSource = productosFiltrados
    End Sub

    Public Sub limparTxt()
        txtID.Text = ""
        txtCodigo.Text = ""
        txtPrecio_Compra.Text = ""
        txtPrecio_Venta.Text = ""
        txtNombre.Text = ""
        txtStockActual.Text = ""
        txtStock_Minimo.Text = ""
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click


        ActualizarProducto()
        CargarDatos()
        limparTxt()
    End Sub

    Private Sub borrarProducto()
        If DataGridProducto.SelectedRows.Count > 0 Then

            Dim productoId As Integer = DataGridProducto.CurrentRow.Cells(0).Value
            productoRepository.DeleteProduto(productoId)
            CargarDatos()
        End If
    End Sub

    Public Sub CargarDatos()
        DataGridProducto.DataSource = productoRepository.GetAllProducto()
    End Sub

    Private Sub ProductosViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub DataGridProducto_DataBindingComplete(sender As Object, e As DataGridViewBindingCompleteEventArgs) Handles DataGridProducto.DataBindingComplete
        For Each row As DataGridViewRow In DataGridProducto.Rows

            ' If Not row.IsNewRow Then asegura que el código solo se ejecute en filas que contienen datos y no en la fila de inserción de nuevos registros. 
            If Not row.IsNewRow Then

                Dim stockActualIndex As Integer = 5 ' 
                Dim stockMinimoIndex As Integer = 6

                Dim stockActual As Integer = Convert.ToInt32(row.Cells(stockActualIndex).Value)
                Dim stockMinimo As Integer = Convert.ToInt32(row.Cells(stockMinimoIndex).Value)

                ' Comprueba si el stock actual es menor o igual al stock mínimo.
                If stockActual <= stockMinimo Then
                    ' Cambia el color de fondo de toda la celda.
                    row.Cells(stockActualIndex).Style.BackColor = Color.Red
                    ' Cambia el color de la letra de la celda de stock.
                    row.Cells(stockActualIndex).Style.ForeColor = Color.White
                End If
            End If
        Next
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtBuscador.TextChanged
        FiltrarProducto()
    End Sub

    Private Sub Guna2CircleButton7_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton7.Click
        CommonFunctions.GenerateListadoPdf(productoRepository.GetAllProducto())
    End Sub

    Private Sub Guna2CircleButton9_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton9.Click
        borrarProducto()
    End Sub

    Private Sub DataGridProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProducto.CellContentClick

    End Sub


End Class