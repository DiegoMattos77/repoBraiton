Public Class ClienteServices

    Public clienteRepository As New ClienteRepository


    Public Sub CreateCliente(newCliente As Cliente)

        Dim result = clienteRepository.AddCliente(newCliente)
        MsgBox(result)
    End Sub

    Public Sub UpdateCliente(cliente As Cliente)
        clienteRepository.UpdateCliente(cliente)
    End Sub

    Public Function GetAllClientes()

        Dim listOfCliente As List(Of Cliente) = clienteRepository.GetAll
        Dim listOfClienteDto As New List(Of ClienteDto)

        If listOfCliente.Count > 0 Then

            For Each cliente As Cliente In listOfCliente

                listOfClienteDto.Add(New ClienteDto With {
                .ProfileImage = CommonFunctions.ToImg(cliente.ProfileImage.ImageData),
                .Cliente_Id = cliente.Cliente_Id,
                .Name = cliente.Name,
                .Telefono = cliente.Telefono,
                .Direccion = cliente.Direccion,
                .ProfileImageId = cliente.ProfileImage.Id,
                .Vendedor_Id = ActiveUser.User_Id
                })

            Next

        End If


        Return listOfClienteDto

    End Function

    Public Function GetAllClientesByVendedor()

        Dim listOfCliente = clienteRepository.GetAllClienteByUser(ActiveUser.User_Id)
        Dim listOfClienteDto As New List(Of ClienteDto)

        For Each cliente As Cliente In listOfCliente

            listOfClienteDto.Add(New ClienteDto With {
            .ProfileImage = CommonFunctions.ToImg(cliente.ProfileImage.ImageData),
            .Cliente_Id = cliente.Cliente_Id,
            .Name = cliente.Name,
            .Telefono = cliente.Telefono,
            .Direccion = cliente.Direccion,
            .ProfileImageId = cliente.ProfileImage.Id,
            .Vendedor_Id = ActiveUser.User_Id
            })

        Next

        Return listOfClienteDto

    End Function

    Public Sub RemoveCliente(id As Integer)
        clienteRepository.DeleteCliente(id)
    End Sub

    Public Function GetClienteByName(name As String)

        Return clienteRepository.getClienteByName(name)

    End Function


End Class
