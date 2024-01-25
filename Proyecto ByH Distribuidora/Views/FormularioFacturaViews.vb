Imports Guna.UI2.WinForms.Helpers
Imports Guna.UI2.WinForms
Public Class FormularioFacturaViews


    'Nuevo
    Private productoRepository As New ProductoRepository
    Public carritoProducto As New HashSet(Of ProductoVenta)



    Private clienteServices As New ClienteServices
    Private facturaServices As New FacturaServices

    Private scrollHelper As PanelScrollHelper
    Private productoServices As New ProductoServices
    Public listaProducto As New HashSet(Of Producto)
    Public listaDeTotal As New HashSet(Of ArticuloDto)


    'Public Sub CargarClientes()

    '    Dim listaClientes As List(Of ClienteDto) = clienteServices.GetAllClientesByVendedor
    '    Dim listaNombreCliente As New List(Of String)

    '    For Each cliente As ClienteDto In listaClientes

    '        listaNombreCliente.Add(cliente.Name)

    '    Next

    '    clienteBox.DataSource = listaNombreCliente
    'End Sub


    'Public Sub ArmarFacturacion()
    '    Dim factura As New Factura
    '    Dim total As Decimal = lblTotal.Text



    '    If listaProducto.Count > 0 Then
    '        factura.Fecha = Now
    '        factura.Total = lblTotal.Text
    '        factura.ClienteID = clienteServices.GetClienteByName(clienteBox.Text)
    '        factura.ListaProducto = listaProducto

    '        facturaServices.CrearFacura(factura, total)
    '    End If

    'End Sub

    'Public Sub ActualizarStocks()

    '    For Each producto As Producto In listaProducto


    '        productoServices.UpdateStock(producto.Cantidad, producto.Producto_Id)

    '    Next

    'End Sub

    Public Sub cargarDataProductos()
        Dim listProducto As List(Of Producto) = productoRepository.GetAllProducto
        DataGridProducto.DataSource = listProducto
    End Sub

    Private Sub FormularioFacturaViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scrollHelper = New PanelScrollHelper(FlowPanel, Guna2VScrollBar1, True)
        cargarDataProductos()
        'CargarClientes()
    End Sub

    Private Sub Guna2VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles Guna2VScrollBar1.Scroll
        scrollHelper.UpdateScrollBar()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProducto.CellContentClick

        If DataGridProducto.SelectedRows.Count > 0 Then

            'Crea un objeto producto apartir de los datos del datagrid
            Dim producto As Producto = CType(DataGridProducto.Rows(e.RowIndex).DataBoundItem, Producto)

            Dim itemProduto As New DetalleProducto
            FlowPanel.Controls.Add(itemProduto)
            FlowPanel.Refresh()

            'Dim itemProduto As New AgragacionProducto

            'itemProduto.txtNombre.Text = producto.Descripcion
            'itemProduto.txtPrecio.Text = producto.Precio

            'If producto.Stock > 0 Then

            '    If listaProducto.Contains(producto) Then
            '        MsgBox("No se puede repetir el mismo producto, agrega mas cantidad si deseas")
            '    Else
            '        listaProducto.Add(producto)
            '        FlowPanel.Controls.Add(itemProduto)
            '        FlowPanel.Refresh()
            '    End If

            'Else
            '    MsgBox("No hay Stock")
            'End If


        End If
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

    End Sub

    'Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click
    '    If lblTotal.Text > 0 Then

    '        ActualizarStocks()


    '        ArmarFacturacion()
    '        ' Crea y muestra el nuevo formulario
    '        Dim nuevoForm As New facturacionviews
    '        nuevoForm.TopLevel = False
    '        nuevoForm.FormBorderStyle = FormBorderStyle.None
    '        nuevoForm.Dock = DockStyle.Fill

    '        ' Accede al formulario principal (form padre) para usar el método OpenChildForm
    '        Dim formPrincipal As Main = DirectCast(Me.ParentForm, Main)
    '        formPrincipal.AbrirForm(nuevoForm)
    '    End If

    'End Sub



End Class