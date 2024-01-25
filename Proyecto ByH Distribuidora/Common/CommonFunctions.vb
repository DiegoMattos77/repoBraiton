Imports System.IO
Imports System.Text
Imports IronPdf
Imports Bogus

Public Module CommonFunctions

    Private productoRepository As New ProductoRepository
    Private clienteServices As New ClienteServices
    Public Function ToByte(path As String)

        Dim bytesImg As Byte() = File.ReadAllBytes(path)

        Return bytesImg
    End Function

    Public Function ToImg(byteArray As Byte())

        Try
            Dim img As Image = Nothing
            If byteArray IsNot Nothing AndAlso byteArray.Length > 0 Then
                Using ms As New MemoryStream(byteArray)
                    img = Image.FromStream(ms)
                End Using
            End If
            Return img
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        End Try

    End Function

    Public Sub GenerateFacturaPdf(cliente As Cliente, factura As Integer, listaProducto As HashSet(Of ProductoVenta))

        Dim htmlFilePath As String = "C:\Users\Usuario\Desktop\Pdf\Factura.html"

        'Cargar el archivo HTML existente
        Dim htmlContent As String = File.ReadAllText(htmlFilePath)

        ' Reemplazar marcadores de posición con datos reales
        htmlContent = htmlContent.Replace("{{nombre}}", cliente.Name)
        htmlContent = htmlContent.Replace("{{direccion}}", cliente.Direccion)
        htmlContent = htmlContent.Replace("{{telefono}}", cliente.Telefono)
        htmlContent = htmlContent.Replace("{{facturaId}}", factura)

        Dim fecha As Date = Now()

        Dim fechaFactura As String = fecha.ToString("dd/MM/yyyy")
        htmlContent = htmlContent.Replace("{{fechaFactura}}", fechaFactura)


        ' Construir filas de la tabla dinámicamente desde la lista de productos
        Dim rowsHtml As New StringBuilder()
        Dim total As Decimal = 0
        For Each producto As ProductoVenta In listaProducto
            rowsHtml.Append("<tr>")
            rowsHtml.Append("<td>" & producto.Producto_Id & "</td>")
            rowsHtml.Append("<td>" & producto.Nombre & "</td>")
            rowsHtml.Append("<td>$" & producto.Precio.ToString("0.00") & "</td>")
            rowsHtml.Append("<td>" & producto.Cantidad & "</td>")
            rowsHtml.Append("</tr>")

            ' Calcular el total
            total += producto.Precio * producto.Cantidad
        Next

        ' Reemplazar marcador de posición en HTML con filas de productos y total
        htmlContent = htmlContent.Replace("{{filasProductos}}", rowsHtml.ToString())
        htmlContent = htmlContent.Replace("{{total}}", total.ToString("C")) ' Formatear total como moneda si es necesario

        'Renderizar HTML a PDF
        Dim pdf As PdfDocument = New ChromePdfRenderer().RenderHtmlAsPdf(htmlContent)

        ' Generar un nombre de archivo único basado en la fecha y hora actual
        Dim outputFileName As String = "Factura_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf"
        Dim outputFilePath As String = Path.Combine("C:\Users\Usuario\Desktop\Pdf\", outputFileName)

        ' Guardar el archivo PDF generado con el nombre único
        pdf.SaveAs(outputFilePath)

        ' Antes de tu MsgBox que indica que el PDF se generó
        Dim tempFilePath As String = Path.GetTempFileName() + ".pdf"
        pdf.SaveAs(tempFilePath)

        ' Crea una nueva instancia de Form para ser tu visor de PDF
        Dim viewer As New Form
        viewer.Text = "Vista Previa del PDF"
        viewer.WindowState = FormWindowState.Maximized

        ' Añadir un control WebBrowser al Form
        Dim browser As New WebBrowser
        browser.Dock = DockStyle.Fill
        viewer.Controls.Add(browser)

        ' Navegar al archivo PDF temporal
        browser.Navigate(tempFilePath)

        ' Mostrar el Form
        viewer.ShowDialog()

        ' Opcional: Eliminar el archivo temporal si ya no es necesario
        File.Delete(tempFilePath)
        MsgBox("PDF generado correctamente en: " & outputFilePath)

    End Sub

    Public Sub GenerateListadoPdf(listaProducto As List(Of Producto))

        Dim htmlFilePath As String = "C:\Users\Usuario\Desktop\Pdf\ListadoProductos.html"

        'Cargar el archivo HTML existente
        Dim htmlContent As String = File.ReadAllText(htmlFilePath)

        ' Construir filas de la tabla dinámicamente desde la lista de productos
        Dim rowsHtml As New StringBuilder()
        Dim total As Decimal = 0
        For Each producto As Producto In listaProducto
            rowsHtml.Append("<tr>")
            rowsHtml.Append("<td>" & producto.Producto_Id & "</td>")
            rowsHtml.Append("<td>" & producto.Codigo & "</td>")
            rowsHtml.Append("<td>" & producto.Name & "</td>")
            rowsHtml.Append("<td>$" & producto.Precio_Venta.ToString("0.00") & "</td>")
            rowsHtml.Append("<td>$" & producto.Precio_Compra.ToString("0.00") & "</td>")
            rowsHtml.Append("<td>" & producto.Stock & "</td>")
            rowsHtml.Append("<td>" & producto.Stock_Minimo & "</td>")
            rowsHtml.Append("</tr>")

        Next

        ' Reemplazar marcador de posición en HTML con filas de productos y total
        htmlContent = htmlContent.Replace("{{filasProductos}}", rowsHtml.ToString())

        'Renderizar HTML a PDF
        Dim pdf As PdfDocument = New ChromePdfRenderer().RenderHtmlAsPdf(htmlContent)

        ' Generar un nombre de archivo único basado en la fecha y hora actual
        Dim outputFileName As String = "Lista_De_Productos_" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf"
        Dim outputFilePath As String = Path.Combine("C:\Users\Usuario\Desktop\Pdf\", outputFileName)

        ' Guardar el archivo PDF generado con el nombre único
        pdf.SaveAs(outputFilePath)
        MsgBox("PDF generado correctamente en: " & outputFilePath)

    End Sub

    Public Sub GenerateDetalleClientePdf(cliente As Cliente, listaFacturas As List(Of Factura))

        Dim htmlFilePath As String = "C:\Users\Usuario\Desktop\Pdf\PerfilCliente.html"

        'Cargar el archivo HTML existente
        Dim htmlContent As String = File.ReadAllText(htmlFilePath)

        ' transformar img
        Dim base64Img As String = Convert.ToBase64String(cliente.ProfileImage.ImageData)

        ' Reemplazar marcadores de posición con datos reales
        htmlContent = htmlContent.Replace("{{imgData}}", base64Img)
        htmlContent = htmlContent.Replace("{{nombre}}", cliente.Name)
        htmlContent = htmlContent.Replace("{{ClienteId}}", cliente.Cliente_Id)
        htmlContent = htmlContent.Replace("{{direccion}}", cliente.Direccion)
        htmlContent = htmlContent.Replace("{{Telefono}}", cliente.Telefono)

        ' Construir filas de la tabla dinámicamente desde la lista de productos
        Dim rowsHtml As New StringBuilder()
        Dim total As Decimal = 0
        For Each factura As Factura In listaFacturas

            rowsHtml.Append("<tr>")
            rowsHtml.Append("<td>" & factura.Factura_Id & "</td>")
            rowsHtml.Append("<td>" & factura.Fecha.ToString("dd/MM/yyyy") & "</td>")
            rowsHtml.Append("<td>$" & factura.Total.ToString("0.00") & "</td>")
            rowsHtml.Append("</tr>")

            ' Calcular el total
            total += factura.Total
        Next

        ' Reemplazar marcador de posición en HTML con filas de productos y total
        htmlContent = htmlContent.Replace("{{filasFacturas}}", rowsHtml.ToString())
        htmlContent = htmlContent.Replace("{{total}}", total.ToString("C")) ' Formatear total como moneda si es necesario

        'Renderizar HTML a PDF
        Dim pdf As PdfDocument = New ChromePdfRenderer().RenderHtmlAsPdf(htmlContent)

        ' Generar un nombre de archivo único basado en la fecha y hora actual
        Dim outputFileName As String = "Detalle_Cliente" & DateTime.Now.ToString("yyyyMMddHHmmss") & ".pdf"
        Dim outputFilePath As String = Path.Combine("C:\Users\Usuario\Desktop\Pdf\", outputFileName)

        ' Guardar el archivo PDF generado con el nombre único
        pdf.SaveAs(outputFilePath)
        MsgBox("PDF generado correctamente en: " & outputFilePath)

    End Sub

    Public Sub GenerateFakerProductos()

        Dim faker As Faker(Of Producto) = New Faker(Of Producto)("es")

        With faker

            .RuleFor(Function(p) p.Codigo, Function(f) f.Random.Int(1000, 9999).ToString())
            .RuleFor(Function(p) p.Name, Function(f) f.Commerce.ProductName())
            .RuleFor(Function(p) p.Precio_Compra, Function(f) Math.Round(f.Random.Decimal(1000D, 10000D), 2))
            .RuleFor(Function(p) p.Precio_Venta, Function(f) Math.Round(f.Random.Decimal(2000D, 99999D), 2))
            .RuleFor(Function(p) p.Stock, Function(f) f.Random.Int(0, 1000))
            .RuleFor(Function(p) p.Stock_Minimo, Function(f) f.Random.Int(0, 100))
            .RuleFor(Function(p) p.Fecha_Ingreso, Function(f) f.Date.Past(2))

        End With

        ' Generar una lista de productos falsos
        Dim productosFalsos As List(Of Producto) = faker.Generate(5) ' Genera 50 productos

        'Creo un nuevo Provedor
        Dim provedor As New Provedor
        provedor.Provedor_Id = 5

        Dim compraFaker As Faker(Of Compra) = New Faker(Of Compra)("es")

        ' Aquí puedes procesar la lista de productos falsos, como mostrarla o insertarla en una base de datos
        For Each producto As Producto In productosFalsos

            producto.Stock_Minimo = 10
            producto.Precio_Venta = producto.Precio_Compra * 2

            With compraFaker
                .RuleFor(Function(c) c.Cantidad, Function(f) f.Random.Int(1, 100))
                .RuleFor(Function(c) c.Provedor, provedor)
                .RuleFor(Function(c) c.Producto, producto)
                .RuleFor(Function(c) c.Fecha_Ingreso, Function(f) f.Date.Recent())
            End With
            Dim fakeCompra As Compra = compraFaker.Generate()

            productoRepository.GuardarProductoStock(producto, fakeCompra)
        Next

    End Sub

    Public Sub GenerateCliente()
        Dim clienteFaker As Faker(Of Cliente) = New Faker(Of Cliente)("es")

        With clienteFaker
            .RuleFor(Function(c) c.Name, Function(f) f.Name.FullName())
            .RuleFor(Function(c) c.Cuit, Function(f) f.Finance.CreditCardNumber()) ' Solo un ejemplo, ajusta según necesidades
            .RuleFor(Function(c) c.Email, Function(f) f.Internet.Email())
            .RuleFor(Function(c) c.Ciudad, Function(f) f.Address.City())
            .RuleFor(Function(c) c.Telefono, Function(f) f.Phone.PhoneNumber())
            .RuleFor(Function(c) c.Direccion, Function(f) f.Address.StreetAddress())
        End With

        ' Generar una lista de productos falsos
        Dim clienteFalsos As List(Of Cliente) = clienteFaker.Generate(5) ' Genera 50 productos

        For Each cliente As Cliente In clienteFalsos

            Dim clienteImg As New UserProfileImage

            'Img Data
            clienteImg.ImageData = CommonFunctions.ToByte("C:\Users\Usuario\Desktop\Fotos\perfil7.jpg")
            cliente.ProfileImage = clienteImg
            cliente.Vendedor_Id = 3

            clienteServices.CreateCliente(cliente)

        Next

    End Sub

End Module
