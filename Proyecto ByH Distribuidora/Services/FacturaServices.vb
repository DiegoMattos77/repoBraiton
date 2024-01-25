Public Class FacturaServices
    Private facturaRepository As New FacturaRepository
    Private clienteRepository As New ClienteRepository
    'Public Sub CrearFacura(factura As Factura, total As Decimal)
    '    facturaRepository.InsertarFactura(factura, total)
    'End Sub

    'Public Function GetAllFactura()
    '    Dim listaFacturas As List(Of Factura) = facturaRepository.GetAllFacturas
    '    Dim listaFActurasDto As New List(Of FacturaDto)

    '    For Each factura As Factura In listaFacturas

    '        Dim cliente As Cliente = clienteRepository.getClienteByID(factura.ClienteID)

    '        Dim facturaDto As New FacturaDto With {
    '            .ProfileImage = CommonFunctions.ToImg(cliente.ProfileImage.ImageData),
    '            .ClienteName = cliente.Name,
    '            .FacturaId = factura.Factura_Id,
    '            .ProfileImageId = cliente.ProfileImage.Id
    '        }

    '        listaFActurasDto.Add(facturaDto)


    '    Next

    '    Return listaFActurasDto
    'End Function

    'Public Function GetAllFacturaByVendedor()
    '    Dim listaFacturas As List(Of Factura) = facturaRepository.GetAllFacturas
    '    Dim listaFActurasDto As New List(Of FacturaDto)

    '    For Each factura As Factura In listaFacturas

    '        Dim cliente As Cliente = clienteRepository.getClienteByID(factura.ClienteID)

    '        Dim facturaDto As New FacturaDto With {
    '            .ProfileImage = CommonFunctions.ToImg(cliente.ProfileImage.ImageData),
    '            .ClienteName = cliente.Name,
    '            .FacturaId = factura.Factura_Id,
    '            .ProfileImageId = cliente.ProfileImage.Id
    '        }

    '        listaFActurasDto.Add(facturaDto)


    '    Next

    '    Return listaFActurasDto
    'End Function

    'Public Function GetAllProductoByFactura(facturaId As Integer)

    '    Return facturaRepository.GetAllProductoByFacturaId(facturaId)

    'End Function
    'Public Function GetAllProductoByCliente(ClienteId As Integer)

    '    Return facturaRepository.GetAllByCliente(ClienteId)

    'End Function

    'Public Function GetFacturaByID(facturaId As Integer)
    '    Dim facura As Factura = facturaRepository.SelectFacturaByID(facturaId)

    '    Dim newFactura As New Factura With {
    '        .Factura_Id = facura.Factura_Id,
    '        .Fecha = facura.Fecha,
    '        .Total = facura.Total
    '    }

    '    Return newFactura
    'End Function


End Class
