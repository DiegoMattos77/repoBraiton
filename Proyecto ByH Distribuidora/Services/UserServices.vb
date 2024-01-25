Public Class UserServices

    Private userRepository As New UserRepository

    Public Sub CreateUser(user As User)

        userRepository.AddUser(user)

    End Sub

    Public Function GetAllUsers()

        Dim listOfUsuarios = userRepository.GetAll
        Dim listOfUsersDto As New List(Of UserDto)

        For Each user As User In listOfUsuarios

            listOfUsersDto.Add(New UserDto With {
            .ProfileImage = CommonFunctions.ToImg(user.ProfileImage.ImageData),
            .UserId = user.User_id,
            .Email = user.Email,
            .Name = user.Name,
            .Last_name = user.Last_name,
            .Password = user.Password,
            .Rol = user.Rol,
            .ProfileImageId = user.ProfileImage.Id
            })

        Next

        Return listOfUsersDto

    End Function

    Public Sub DeleteUser(id As Integer)

        userRepository.Remove(id)

    End Sub

    Public Sub UpdateUser(userDto As User)

        Dim userToUpdate As New User With {
           .User_id = userDto.User_id,
           .Email = userDto.Email,
           .Name = userDto.Name,
           .Last_name = userDto.Last_name,
           .Password = userDto.Password,
           .Rol = userDto.Rol,
           .ProfileImage = userDto.ProfileImage
        }

        userRepository.Edit(userToUpdate)

    End Sub

    Public Function ValidarUsuario(email As String, passaword As String)


        Return userRepository.ValidacionUser(email, passaword)

    End Function

End Class
