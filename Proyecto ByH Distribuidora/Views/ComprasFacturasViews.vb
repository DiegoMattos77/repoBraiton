Public Class ComprasFacturasViews

    Private comprasRepository As New ComprasRepository

    Public Sub CargarCompras()
        Dim listaComprasDto As New List(Of ComprasDto)
        For Each compras As Compra In comprasRepository.GetAllCompras

            listaComprasDto.Add(New ComprasDto With {
                .Compras_Id = compras.Compras_Id,
                .Cantidad = compras.Cantidad,
                .Precio_Compra = compras.Precio_Compra,
                .Provedor = compras.Provedor.Provedor_Id,
                .Producto = compras.Producto.Producto_Id,
                .Fecha_Ingreso = compras.Fecha_Ingreso
            })

        Next

        DataGridCompras.DataSource = listaComprasDto

    End Sub

    Public Sub BorrarCompra()
        If DataGridCompras.SelectedRows.Count > 0 Then

            Dim compraID As Integer = DataGridCompras.CurrentRow.Cells(0).Value

            comprasRepository.DeleteCompras(compraID)
            CargarCompras()
        End If

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        ' crea y muestra el nuevo formulario
        Dim nuevoform As New ComprasViews
        nuevoform.TopLevel = False
        nuevoform.FormBorderStyle = FormBorderStyle.None
        nuevoform.Dock = DockStyle.Fill

        ' accede al formulario principal (form padre) para usar el método openchildform
        Dim formprincipal As Main = DirectCast(Me.ParentForm, Main)
        formprincipal.AbrirForm(nuevoform)
    End Sub

    Private Sub ComprasFacturasViews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCompras()
    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        BorrarCompra()
    End Sub
End Class