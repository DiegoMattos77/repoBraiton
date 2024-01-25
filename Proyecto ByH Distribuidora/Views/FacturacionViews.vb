
Imports Guna.UI2.WinForms
Public Class facturacionviews

    Private facturaRepository As New FacturaRepository
    Private listaDetalleProducto As New List(Of Producto)


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' crea y muestra el nuevo formulario
        Dim nuevoform As New VentaViews
        nuevoform.TopLevel = False
        nuevoform.FormBorderStyle = FormBorderStyle.None
        nuevoform.Dock = DockStyle.Fill

        ' accede al formulario principal (form padre) para usar el método openchildform
        Dim formprincipal As Main = DirectCast(Me.ParentForm, Main)
        formprincipal.AbrirForm(nuevoform)
    End Sub

    Private Sub facturacionviews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridFacturas.DataSource = facturaRepository.GetAllFacturas
    End Sub

    Private Sub DataGridFacturas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridFacturas.CellClick
        If DataGridFacturas.SelectedRows.Count > 0 Then

            Dim facturaid = DataGridFacturas.CurrentRow.Cells(0).Value

            DataGridProductos.DataSource = facturaRepository.GetAllProductoByFacturaId(facturaid)
        End If
    End Sub


    'Private facturaservices As New FacturaServices
    'Private facturarepository As New FacturaRepository
    'Private clienteservices As New ClienteServices
    'Private clienterepository As New ClienteRepository

    'Public Sub cargardetalles(facturaid As Integer)

    '    Dim factura As Factura = facturaservices.GetFacturaByID(facturaid)

    '    Dim clienteid As Integer = clienteservices.GetClienteByName(dataGridFactura.CurrentRow.Cells(1).Value)
    '    Dim cliente As Cliente = clienterepository.getClienteByID(clienteid)

    '    lblNameCliente.Text = cliente.Name
    '    lblTelefono.Text = cliente.Telefono
    '    lblDireccion.Text = cliente.Direccion

    '    lblVendedor.Text = ActiveUser.Name

    '    lblTotal.Text = factura.Total
    '    lblFecha.Text = factura.Fecha
    '    lblPedidoID.Text = factura.Factura_Id

    'End Sub

    'Public Function getfactura(facturaid As Integer)
    '    Dim factura As Factura = facturaservices.GetFacturaByID(facturaid)

    '    Return factura
    'End Function

    'Public Function getcliente()
    '    Dim clienteid As Integer = clienteservices.GetClienteByName(dataGridFactura.CurrentRow.Cells(1).Value)
    '    Dim cliente As Cliente = clienterepository.getClienteByID(clienteid)

    '    Return cliente
    'End Function

    'Public Sub cargarfacturas()

    '    dataGridFactura.DataSource = facturaservices.GetAllFactura

    'End Sub

    'Public Sub cargargridproductos(facturaid As Integer)


    '    DataGridProductos.DataSource = facturaservices.GetAllProductoByFactura(facturaid)


    'End Sub

    'Private Sub guna2button1_click(sender As Object, e As EventArgs)

    '    ' crea un nuevo botón
    '    Dim nuevoboton As New Guna2Button()

    '    ' configura el nuevo botón según tus necesidades
    '    nuevoboton.Text = "nuevo botón"
    '    nuevoboton.Size = New Size(100, 30) ' establece el tamaño del botón
    '    ' configura otras propiedades del botón según tus necesidades

    '    ' agrega el nuevo botón al formulario
    '    Me.Controls.Add(nuevoboton)
    'End Sub

    'Private Sub guna2button1_click_1(sender As Object, e As EventArgs)
    '    ' crea y muestra el nuevo formulario
    '    Dim nuevoform As New FormularioFacturaViews
    '    nuevoform.TopLevel = False
    '    nuevoform.FormBorderStyle = FormBorderStyle.None
    '    nuevoform.Dock = DockStyle.Fill

    '    ' accede al formulario principal (form padre) para usar el método openchildform
    '    Dim formprincipal As Main = DirectCast(Me.ParentForm, Main)
    '    formprincipal.AbrirForm(nuevoform)
    'End Sub

    'Private Sub facturacionviews_load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    cargarfacturas()
    'End Sub

    'Private Sub datagridfactura_cellcontentclick(sender As Object, e As DataGridViewCellEventArgs)

    '    If dataGridFactura.SelectedRows.Count > 0 Then

    '        Dim facturaid = dataGridFactura.CurrentRow.Cells(2).Value
    '        cargargridproductos(facturaid)
    '        cargardetalles(facturaid)
    '    End If
    'End Sub

    'Private Sub btnusuarios_click(sender As Object, e As EventArgs)

    '    If dataGridFactura.SelectedRows.Count > 0 Then
    '        Dim facturaid = dataGridFactura.CurrentRow.Cells(2).Value
    '        Dim factura As Factura = getfactura(facturaid)

    '        Dim cliente As Cliente = getcliente()

    '        Dim listaproducto As List(Of ProductoFacturaDto) = facturaservices.GetAllProductoByFactura(dataGridFactura.CurrentRow.Cells(2).Value)

    '        Dim fechafactura As String = DateTime.Now.ToString("dd/mm/yyyy")

    '        CommonFunctions.GenerateFacturaPdf(cliente, factura, listaproducto)

    '    End If


    'End Sub

    'Private Sub Guna2Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel2.Paint

    'End Sub
End Class