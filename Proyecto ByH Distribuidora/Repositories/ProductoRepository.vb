Imports MySql.Data.MySqlClient

Public Class ProductoRepository

    Inherits MasterRepository

    Private selectAll As String
    Private Insert As String
    Private update As String
    Private delete As String
    Private updateStock As String
    Private updateStockCompra As String

    Public Sub New()

        selectAll = "SELECT * FROM productos WHERE SoftDelete = FALSE"

        Insert = "start transaction;
                    insert into  
                    productos (Codigo, Nombre, Precio_Compra, Precio_Venta, Stock, Stock_Minimo, SoftDelete)
                    values (@Codigo,@Nombre,@Precio_Compra,@Precio_Venta,0,@Stock_Minimo,false);

                    update productos
                    set Stock = Stock + @Cantidad where Producto_Id = (select last_insert_id());

                    insert into 
                    compras(Cantidad,Precio_Compra, Provedor_Id, Fecha_Ingreso, Producto_Id, softDelete)
                    values(@Cantidad,@Precio_Compra, @Provedor_Id, @Fecha_Ingreso, last_insert_id(), false);
                    commit;
                    "


        update = "UPDATE productos 
                  SET Stock= @Stock, Codigo = @Codigo, Nombre = @Nombre, Precio_Compra = @Precio_Compra, Precio_Venta= @Precio_Venta, Stock_Minimo = @Stock_Minimo
                  WHERE Producto_Id=@Producto_Id"

        updateStock = "UPDATE productos SET Stock= Stock - @Cantidad WHERE Producto_Id=@Producto_Id"

        updateStockCompra = "UPDATE productos 
                             SET Stock= Stock + @Cantidad, Codigo = @Codigo, Nombre = @Nombre, Precio_Compra = @Precio_Compra, Precio_Venta= @Precio_Venta, Stock_Minimo = @Stock_Minimo
                             WHERE Producto_Id=@Producto_Id;

                            insert into 
                            compras(Cantidad,Precio_Compra, Provedor_Id, Fecha_Ingreso, Producto_Id, softDelete)
                            values(@Cantidad,@Precio_Compra, @Provedor_Id, @Fecha_Ingreso, @Producto_Id, false);"

        delete = "UPDATE productos SET SoftDelete = True WHERE Producto_Id=@Producto_Id"

    End Sub



    Public Function GuardarProductoStock(producto As Producto, factura_Compra As Compra)
        Dim message As String
        Try
            parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Codigo", producto.Codigo),
            New MySqlParameter("@Nombre", producto.Name),
            New MySqlParameter("@Precio_Compra", producto.Precio_Compra),
            New MySqlParameter("@Precio_Venta", producto.Precio_Venta),
            New MySqlParameter("@Stock_Minimo", producto.Stock_Minimo),
            New MySqlParameter("@Fecha_Ingreso", factura_Compra.Fecha_Ingreso),
            New MySqlParameter("@Cantidad", factura_Compra.Cantidad),
            New MySqlParameter("@Provedor_Id", factura_Compra.Provedor.Provedor_Id)
            }


            ExecuteNonQuery(Insert)
            message = "Producto Registrado"
        Catch ex As MySqlException
            MsgBox(ex.Message)
            message = ex.Message
        End Try

        Return message
    End Function

    Public Function GetAllProducto()

        Dim resulTable = ExecuteRender(selectAll)
        Dim listProducto As New List(Of Producto)

        For Each item As DataRow In resulTable.Rows

            listProducto.Add(New Producto With {
                .Producto_Id = item(0),
                .Codigo = item(1),
                .Name = item(2),
                .Precio_Compra = item(3),
                .Precio_Venta = item(4),
                .Stock = item(5),
                .Stock_Minimo = item(6)
            })

        Next

        Return listProducto
    End Function

    Public Function UpdateStockByCompra(producto As Producto, factura_Compra As Compra)
        Dim message As String
        Try
            parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Producto_Id", producto.Producto_Id),
            New MySqlParameter("@Codigo", producto.Codigo),
            New MySqlParameter("@Nombre", producto.Name),
            New MySqlParameter("@Precio_Compra", producto.Precio_Compra),
            New MySqlParameter("@Precio_Venta", producto.Precio_Venta),
            New MySqlParameter("@Stock_Minimo", producto.Stock_Minimo),
            New MySqlParameter("@Fecha_Ingreso", factura_Compra.Fecha_Ingreso),
            New MySqlParameter("@Cantidad", factura_Compra.Cantidad),
            New MySqlParameter("@Provedor_Id", factura_Compra.Provedor.Provedor_Id)
            }


            ExecuteNonQuery(updateStockCompra)
            message = "Producto Registrado"
        Catch ex As Exception
            MsgBox(ex.Message)
            message = ex.Message
        End Try

        Return message


    End Function

    Public Function UpdateProducto(produto As Producto)
        Dim message As String
        Try
            parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Producto_Id", produto.Producto_Id),
            New MySqlParameter("@Codigo", produto.Codigo),
            New MySqlParameter("@Nombre", produto.Name),
            New MySqlParameter("@Precio_Compra", produto.Precio_Compra),
            New MySqlParameter("@Precio_Venta", produto.Precio_Venta),
            New MySqlParameter("@Stock_Minimo", produto.Stock_Minimo),
            New MySqlParameter("@Stock", produto.Stock)
            }



            ExecuteNonQuery(update)
            message = "Producto Actualizado"
        Catch ex As MySqlException
            message = ex.Message
            MsgBox(message)
        End Try

        Return message
    End Function

    Public Function DeleteProduto(id As Integer)

        Dim messages As String

        Try
            parameters = New List(Of MySqlParameter) From {
                New MySqlParameter("@Producto_Id", id)
            }

            ExecuteNonQuery(delete)
            messages = "Producto Eliminado"

        Catch ex As Exception
            messages = ex.Message
        End Try

        Return messages
    End Function



    Public Sub ActualizarStock(cantidad As Integer, productoId As Integer)

        Try
            parameters = New List(Of MySqlParameter) From {
                New MySqlParameter("@Cantidad", cantidad),
                New MySqlParameter("@Producto_Id", productoId)
            }

            ExecuteNonQuery(updateStock)

        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Sub

End Class
