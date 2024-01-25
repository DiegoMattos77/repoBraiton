Public Class Factura

    Public Property Factura_Id As Integer
    Public Property Fecha As Date
    Public Property Total As Decimal
    Public Property Cliente_Id As Integer
    Public Property ListaProducto As HashSet(Of ProductoVenta)

End Class
