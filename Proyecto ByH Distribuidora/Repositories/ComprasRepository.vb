Imports MySql.Data.MySqlClient

Public Class ComprasRepository
    Inherits MasterRepository

    Private selectAll As String
    Private Insert As String
    Private update As String
    Private delete As String
    Private updateStock As String
    Private updateStockCompra As String

    Public Sub New()

        selectAll = "SELECT * FROM compras WHERE SoftDelete = FALSE"

        delete = "UPDATE compras SET softDelete = True WHERE Compras_Id=@Compras_Id "

    End Sub


    Public Function GetAllCompras()

        Dim resulTable = ExecuteRender(selectAll)
        Dim listCompra As New List(Of Compra)

        For Each item As DataRow In resulTable.Rows

            Dim provedorId As New Provedor With {
                .Provedor_Id = item(3)
            }

            Dim productoId As New Producto With {
                .Producto_Id = item(4)
            }

            listCompra.Add(New Compra With {
                .Compras_Id = item(0),
                .Cantidad = item(1),
                .Precio_Compra = item(2),
                .Provedor = provedorId,
                .Producto = productoId,
                .Fecha_Ingreso = item(6)
            })

        Next

        Return listCompra
    End Function

    Public Function DeleteCompras(id As Integer)

        Dim messages As String

        Try
            parameters = New List(Of MySqlParameter) From {
                New MySqlParameter("@Compras_Id", id)
            }

            ExecuteNonQuery(delete)
            messages = "Compra Eliminado"

        Catch ex As Exception
            messages = ex.Message
        End Try

        Return messages
    End Function


End Class
