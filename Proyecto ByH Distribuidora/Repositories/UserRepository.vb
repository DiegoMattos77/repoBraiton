Imports MySql.Data.MySqlClient

Public Class UserRepository

    Inherits MasterRepository
    Implements iUserRepository

    Private selectAll As String
    Private selectUserById As String
    Private insertUser As String
    Private update As String
    Private delete As String
    Private validateUser As String


    Public Sub New()

        selectAll = "SELECT *
                     FROM users u
                     JOIN userprofileimages p on u.UserProfileImageId = p.Id
                      WHERE softDelete = FALSE "

        insertUser = "INSERT INTO UserProfileImages (ImageData) VALUES (@ImgData);
                      INSERT INTO users (Email, Name, Last_name, Password, Rol, UserProfileImageId,softDelete)
                      VALUES (@Email,@Name,@Last_name,@Password,@Rol,LAST_INSERT_ID(),FALSE )"

        update = "UPDATE users SET Email = @Email, Name = @Name, Last_name = @Last_name, Password = @Password WHERE User_Id = @User_Id;
                  UPDATE userprofileimages SET ImageData=@ImageData WHERE Id = @fotoId"

        delete = "UPDATE users SET softDelete = TRUE WHERE User_id = @userId"

        validateUser = "SELECT *
                        FROM users u
                        JOIN userprofileimages p on u.UserProfileImageId = p.Id
                        WHERE Email=@Email AND Password=@Password AND softDelete=FALSE"

        selectUserById = "SELECT *
                          FROM users
                          WHERE User_Id=@User_Id"

    End Sub

    Public Function AddUser(user As User)

        Dim messages As String

        Try
            'parametros para usuario
            'parametros para Img
            parameters = New List(Of MySqlParameter) From {
                New MySqlParameter("@email", user.Email),
                New MySqlParameter("@Name", user.Name),
                New MySqlParameter("@Password", user.Password),
                New MySqlParameter("@Last_name", user.Last_name),
                New MySqlParameter("@Rol", user.Rol),
                New MySqlParameter("@ImgData", user.ProfileImage.ImageData)
            }

            ExecuteNonQuery(insertUser)
            messages = "Usuario Agregado"

        Catch ex As MySqlException
            MsgBox("Registro Duplicado")
            messages = ex.Message
        End Try

        Return messages
    End Function

    Public Function GetAll() As IEnumerable(Of User) Implements iGenericRepository(Of User).GetAll
        Dim resultTable = ExecuteRender(selectAll)
        Dim listUser = New List(Of User)


        For Each item As DataRow In resultTable.Rows
            Dim userProfileImg As New UserProfileImage
            userProfileImg.Id = item(8)
            userProfileImg.ImageData = item(9)

            listUser.Add(New User With {
            .User_id = item(0),
            .Email = item(1),
            .Name = item(2),
            .Last_name = item(3),
            .Password = item(4),
            .Rol = item(5),
            .ProfileImage = userProfileImg
            })

        Next

        Return listUser
    End Function

    'Public Function GetUserById(id As Integer) As User

    '    Dim user As New User
    '    parameters = New List(Of MySqlParameter) From {
    '        New MySqlParameter("@userId", id)
    '    }

    '    Dim resultList = ExecuteRender(selectUserById)

    '    For Each item As DataRow In resultList.Rows

    '        user.User_id = item(0)
    '        user.Email = item(1)
    '        user.Name = item(2)
    '        user.Last_name = item(3)
    '        user.Password = item(4)
    '    Next

    'End Function

    Public Function Remove(id As Integer) As Integer Implements iGenericRepository(Of User).Remove

        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@userId", id)
        }

        Return ExecuteNonQuery(delete)

    End Function

    Public Function Add(entity As User) As Integer Implements iGenericRepository(Of User).Add
        Throw New NotImplementedException()
    End Function

    Public Function Edit(user As User) As Integer Implements iGenericRepository(Of User).Edit

        'parametros para usuario
        'parametros para Img
        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@email", user.Email),
            New MySqlParameter("@Name", user.Name),
            New MySqlParameter("@Password", user.Password),
            New MySqlParameter("@Last_name", user.Last_name),
            New MySqlParameter("@Rol", user.Rol),
            New MySqlParameter("@ImageData", user.ProfileImage.ImageData),
            New MySqlParameter("@fotoId", user.ProfileImage.Id),
            New MySqlParameter("@User_Id", user.User_id)
        }

        Return ExecuteNonQuery(update)
    End Function

    Public Function ValidacionUser(email As String, password As String)

        Dim validate = False

        parameters = New List(Of MySqlParameter) From {
        New MySqlParameter("@Email", email),
        New MySqlParameter("@Password", password)
        }

        Dim resultTable = ExecuteRender(validateUser)

        If resultTable.Rows.Count > 0 Then
            For Each item As DataRow In resultTable.Rows


                ActiveUser.User_Id = item(0)
                ActiveUser.Email = item(1)
                ActiveUser.Name = item(2)
                ActiveUser.Last_Name = item(3)
                ActiveUser.Rol = item(5)
                ActiveUser.ImgData = item(9)
            Next
            validate = True
        End If


        Return validate
    End Function



End Class
