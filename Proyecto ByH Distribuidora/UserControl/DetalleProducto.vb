Public Class DetalleProducto
    Private Sub DetalleProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    'Public listOfTotal As New List(Of Decimal)
    'Dim newArticulo As New ArticuloDto

    'Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

    '    Dim panelPadre As FlowLayoutPanel = CType(Me.Parent, FlowLayoutPanel)
    '    Dim indice As Integer = panelPadre.Controls.IndexOf(Me)

    '    If indice >= 0 Then
    '        ' Obtiene el UserControl en el índice específico
    '        Dim userControlToDelete As AgragacionProducto = CType(panelPadre.Controls(indice), AgragacionProducto)
    '        Dim produtName As String = userControlToDelete.txtNombre.Text

    '        Dim form = DirectCast(Me.ParentForm, FormularioFacturaViews)



    '        ' Utiliza LINQ para encontrar el objeto Producto con el nombre específico
    '        Dim articuloAEliminar As ArticuloDto = form.listaDeTotal.First(Function(a) a.name = produtName)
    '        Dim productoAEliminar As Producto = form.listaProducto.FirstOrDefault(Function(p) p.Descripcion = produtName)


    '        If productoAEliminar IsNot Nothing Then
    '            form.listaProducto.Remove(productoAEliminar)
    '            form.listaDeTotal.Remove(articuloAEliminar)
    '            Dim total As Decimal = form.listaDeTotal.Sum(Function(articulo) articulo.Total)
    '            form.lblTotal.Text = total
    '            panelPadre.Controls.Remove(Me)
    '            Me.Dispose()
    '        End If


    '    End If



    'End Sub

    'Public Sub Total()
    '    Dim panelPadre As FlowLayoutPanel = CType(Me.Parent, FlowLayoutPanel)
    '    Dim indice As Integer = panelPadre.Controls.IndexOf(Me)

    '    If indice >= 0 Then
    '        ' Obtiene el UserControl en el índice específico
    '        Dim userControl As AgragacionProducto = CType(panelPadre.Controls(indice), AgragacionProducto)
    '        Dim produtName As String = userControl.txtNombre.Text

    '        Dim form = DirectCast(Me.ParentForm, FormularioFacturaViews)

    '        ' Utiliza LINQ para encontrar el objeto Producto con el nombre específico
    '        Dim productoASumar As Producto = form.listaProducto.FirstOrDefault(Function(p) p.Descripcion = produtName)

    '        If productoASumar.Stock > 0 Then

    '            contador.Maximum = productoASumar.Stock

    '            productoASumar.Cantidad = contador.Value

    '            Dim Total As Decimal = productoASumar.Precio * contador.Value

    '            Dim newArticulo As New ArticuloDto With {
    '                .name = productoASumar.Descripcion,
    '                .Total = Total
    '            }
    '            ' Verifica si hay un artículo en la lista con el mismo nombre que newArticulo.name
    '            Dim existeArticulo As Boolean = form.listaDeTotal.Any(Function(articulo) articulo.name = newArticulo.name)

    '            If existeArticulo Then
    '                ' Encuentra el artículo con el mismo nombre en la lista y elimínalo
    '                Dim articuloAEliminar As ArticuloDto = form.listaDeTotal.First(Function(a) a.name = newArticulo.name)
    '                form.listaDeTotal.Remove(articuloAEliminar)
    '            End If

    '            form.listaDeTotal.Add(newArticulo)

    '            form.lblTotal.Text = form.listaDeTotal.Sum(Function(articulo) articulo.Total)

    '        End If
    '    End If
    'End Sub



    'Private Sub contador_ValueChanged(sender As Object, e As EventArgs) Handles contador.ValueChanged
    '    Total()
    'End Sub

    'Private Sub AgragacionProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    Dim produtName As String = txtNombre.Text

    '    Dim form = DirectCast(Me.ParentForm, FormularioFacturaViews)

    '    ' Utiliza LINQ para encontrar el objeto Producto con el nombre específico
    '    Dim productoASumar As Producto = form.listaProducto.FirstOrDefault(Function(p) p.Descripcion = produtName)
    '    Dim total As Decimal = productoASumar.Precio * contador.Value
    '    newArticulo.name = productoASumar.Descripcion
    '    newArticulo.Total = total

    '    form.listaDeTotal.Add(newArticulo)


    'End Sub

    'Private Sub Guna2Separator1_Click(sender As Object, e As EventArgs) Handles Guna2Separator1.Click

    'End Sub
End Class
