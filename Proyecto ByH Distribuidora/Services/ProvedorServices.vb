Public Class ProvedorServices

    Private provedorRepository As New ProvedorRepository
    Public Sub CreateProvedor(newProvedor As Provedor)

        Dim result = provedorRepository.AddProvedor(newProvedor)
        MsgBox(result)
    End Sub

    Public Function GetAllProvedores()

        Dim listOfProvedor As List(Of Provedor) = provedorRepository.GetAll
        Dim listOfProvedorDto As New List(Of ProvedorDto)

        If listOfProvedor.Count > 0 Then

            For Each provedor As Provedor In listOfProvedor

                listOfProvedorDto.Add(New ProvedorDto With {
                .ProfileImage = CommonFunctions.ToImg(provedor.ProfileImage.ImageData),
                .Provedor_Id = provedor.Provedor_Id,
                .Name = provedor.Name,
                .Telefono = provedor.Telefono,
                .Direccion = provedor.Direccion,
                .ProfileImageId = provedor.ProfileImage.Id,
                .Cuit = provedor.Cuit
                })

            Next

        End If


        Return listOfProvedorDto

    End Function

    Public Sub RemoveProvedor(id As Integer)
        provedorRepository.DeleteProvedor(id)
    End Sub

    Public Sub UpdateCliente(provedor As Provedor)
        provedorRepository.UpdateProvedor(provedor)
    End Sub

End Class
