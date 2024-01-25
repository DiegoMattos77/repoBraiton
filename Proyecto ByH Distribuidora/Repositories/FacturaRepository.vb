Imports MySql.Data.MySqlClient

Public Class FacturaRepository
    Inherits MasterRepository

    Private productoRepository As New ProductoRepository

    Private selectAll As String
    Private insertFactura As String
    Private insertProductoToFactura As String
    Private updateTotal As String
    Private delete As String
    Private selectAllByFactura As String
    Private GetFacturaByID As String
    Private SelectAllByClienteID As String
    Private selectAllByCliente As String
    Private updateStock As String
    Private selectTotalPedidos As String

    Public Sub New()
        selectAll = "SELECT f.Factura_Id, c.Nombre, f.Total, f.Fecha
                    FROM facturas f
                    join cliente c on f.Cliente_Id = c.Cliente_Id
                    where f.SoftDelete = false"

        selectAllByCliente = "SELECT * FROM facturas WHERE Cliente_Id = @Cliente_Id"

        GetFacturaByID = "SELECT * FROM facturas WHERE Factura_Id= (SELECT LAST_INSERT_ID())"

        selectAllByFactura = "select * 
                              from productos
                              join factura_producto on productos.Producto_Id = factura_producto.Producto_Id
                              where factura_producto.Factura_Id = @Factura_Id"

        insertFactura = "INSERT INTO facturas (Fecha, Total, Cliente_Id,SoftDelete) VALUES (@Fecha,@Total,@Cliente_Id,false);"

        insertProductoToFactura = "INSERT INTO factura_producto (Factura_Id, Producto_Id, Cantidad) VALUES (last_insert_id(), @Producto_Id,@Cantidad);"

        updateStock = "UPDATE productos SET Stock= Stock - @Cantidad WHERE Producto_Id=@Producto_Id"

        updateTotal = "UPDATE facturas SET Total = @Total WHERE Factura_Id = (SELECT LAST_INSERT_ID())"


        delete = "START transaction;
                      DELETE cliente, userprofileimages
                      FROM cliente
                      JOIN userprofileimages on cliente.UserProfileImageId = userprofileimages.Id
                      WHERE cliente.User_id = @userId;
                      DELETE users, userprofileimages
                      FROM users
                      JOIN userprofileimages on users.UserProfileImageId = userprofileimages.Id
                      WHERE users.User_id = @userId;
                  commit;"

        SelectAllByClienteID = "select  f.Factura_Id, f.Fecha, f.Total
                                from facturas f
                                join cliente c on f.Cliente_Id = c.Cliente_Id
                                where c.Cliente_Id = @Cliente_Id"


        selectTotalPedidos = "SELECT COUNT(*) AS totalPedidos
                                FROM facturas
                                WHERE facturas.SoftDelete = false"
    End Sub

    Public Function Insertar(factura As Factura)

        Try
            parameters = New List(Of MySqlParameter) From {
               New MySqlParameter("@Cliente_Id", factura.Cliente_Id),
               New MySqlParameter("@Fecha", factura.Fecha),
               New MySqlParameter("@Total", factura.Total)
           }

            ExecuteNonQuery(insertFactura)

            If factura.ListaProducto.Count > 0 Then

                For Each producto As ProductoVenta In factura.ListaProducto
                    parameters.Add(New MySqlParameter("@Producto_Id", producto.Producto_Id))
                    parameters.Add(New MySqlParameter("@Cantidad", producto.Cantidad))

                    ExecuteNonQuery(insertProductoToFactura)
                    productoRepository.ActualizarStock(producto.Cantidad, producto.Producto_Id)
                Next

                MsgBox("Venta Registrada")

            End If

            Dim resultTable = ExecuteRender(GetFacturaByID)
            Dim facturaId As Integer

            For Each item As DataRow In resultTable.Rows
                facturaId = item(0)
            Next
            Return facturaId
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try

    End Function

    Public Function GetAllProductoByFacturaId(facturaId As Integer)

        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Factura_Id", facturaId)
        }


        Dim resultTable = ExecuteRender(selectAllByFactura)
        Dim listProductoDto = New List(Of ProductoFacturaDto)

        For Each item As DataRow In resultTable.Rows

            Dim productoDto As New ProductoFacturaDto With {
                .Producto_Id = item(0),
                .Codigo = item(1),
                .Nombre = item(2),
                .Precio = item(4),
                .Cantidad = item(10)
            }

            listProductoDto.Add(productoDto)
        Next

        Return listProductoDto
    End Function


    Public Function GetTotal()
        Dim resultTable = ExecuteRender(selectTotalPedidos)
        Dim total As Integer
        For Each item As DataRow In resultTable.Rows

            total = item(0)
        Next

        Return total
    End Function


    Public Function GetAllFacturas()
        Dim resultTable = ExecuteRender(selectAll)
        Dim listFacturas = New List(Of FacturaDto)

        For Each item As DataRow In resultTable.Rows

            Dim factura As New FacturaDto With {
                .Factura_Id = item(0),
                .Nombre_Cliente = item(1),
                .Total = item(2),
                .Fecha = item(3)
            }

            listFacturas.Add(factura)
        Next

        Return listFacturas
    End Function

    ''Public Function GetAllFacturasByVendedor()
    ''    Dim resultTable = ExecuteRender(selectAll)
    ''    Dim listFacturas = New List(Of Factura)

    ''    For Each item As DataRow In resultTable.Rows

    ''        Dim factura As New Factura With {
    ''            .Factura_Id = item(0),
    ''            .Fecha = item(1),
    ''            .Total = item(2),
    ''            .ClienteID = item(3)
    ''        }

    ''        listFacturas.Add(factura)
    ''    Next

    ''    Return listFacturas
    ''End Function


    Public Function SelectByClienteId(Cliente_Id As Integer)
        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Cliente_Id", Cliente_Id)
        }

        Dim resultTable = ExecuteRender(selectAllByCliente)
        Dim listaOfProducto As New List(Of ProductoFacturaDto)

        For Each item As DataRow In resultTable.Rows

            listaOfProducto.Add(New ProductoFacturaDto With {
                .Producto_Id = item(0),
                .Codigo = item(1),
                .Nombre = item(2),
                .Precio = item(3),
                .Cantidad = item(4)
            })
        Next

        Return listaOfProducto
    End Function


    Public Function SelectAllFacturaByCliente(clienteID As Integer)

        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Cliente_Id", clienteID)
        }

        Dim resultTable = ExecuteRender(selectAllByCliente)
        Dim listaFactura As New List(Of Factura)
        For Each item As DataRow In resultTable.Rows

            listaFactura.Add(New Factura With {
                 .Factura_Id = item(0),
                 .Fecha = item(1),
                 .Total = item(2)
            })
        Next

        Return listaFactura
    End Function






End Class
