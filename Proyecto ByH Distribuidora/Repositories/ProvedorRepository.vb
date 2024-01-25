Imports MySql.Data.MySqlClient

Public Class ProvedorRepository
    Inherits MasterRepository

    Private selectAll As String
    Private insertProvedor As String
    Private update As String
    Private delete As String
    Private selectAllClienteOfUser As String
    Private selectClienteByName As String
    Private selectClienteByID As String

    Public Sub New()

        selectAll = "SELECT *
                    FROM provedores p
                    JOIN userprofileimages f on p.UserProfileImageId = f.Id
                    WHERE SoftDelete = FALSE"

        insertProvedor = "INSERT INTO UserProfileImages (ImageData) VALUES (@ImgData);
                         INSERT INTO provedores (Name, Telefono, Direccion,Cuit,SoftDelete, UserProfileImageId) 
                         VALUES (@Name,@Telefono,@Direccion,@Cuit,FALSE,LAST_INSERT_ID());"


        update = "UPDATE provedores SET Name = @Name, Telefono = @Telefono, Direccion = @Direccion, Cuit = @Cuit WHERE Provedor_Id = @Provedor_Id;
                  UPDATE userprofileimages SET ImageData=@ImageData WHERE Id = @fotoId"


        delete = "UPDATE provedores SET SoftDelete = True WHERE Provedor_Id = @Provedor_Id"


        selectAllClienteOfUser = "SELECT *
                                  FROM cliente c
                                  JOIN userprofileimages p on c.UserProfileImageId = p.Id
                                  where c.User_id = @User_id AND c.SoftDelete = false"

        selectClienteByName = "select Cliente_Id from cliente where name = @Name"

        selectClienteByID = "SELECT *
                             FROM cliente c
                             JOIN userprofileimages p on c.UserProfileImageId = p.Id
                             WHERE c.Cliente_Id = @id"

    End Sub


    Public Function AddProvedor(provedor As Provedor)
        Dim messages As String

        Try

            parameters = New List(Of MySqlParameter) From {
                    New MySqlParameter("@Name", provedor.Name),
                    New MySqlParameter("@Telefono", provedor.Telefono),
                    New MySqlParameter("@Direccion", provedor.Direccion),
                    New MySqlParameter("@Cuit", provedor.Cuit),
                    New MySqlParameter("@ImgData", provedor.ProfileImage.ImageData)
            }

            ExecuteNonQuery(insertProvedor)
            messages = "Provedor Agregado"
        Catch ex As MySqlException

            messages = ex.Message

        End Try

        Return messages

    End Function

    Public Function GetAll()
        Dim resultTable = ExecuteRender(selectAll)
        Dim listprovedor = New List(Of Provedor)


        For Each item As DataRow In resultTable.Rows
            Dim userProfileImg As New UserProfileImage
            userProfileImg.Id = item(7)
            userProfileImg.ImageData = item(8)

            listprovedor.Add(New Provedor With {
            .Provedor_Id = item(0),
            .Name = item(1),
            .Telefono = item(2),
            .Direccion = item(3),
            .Cuit = item(4),
            .ProfileImage = userProfileImg
            })

        Next

        Return listprovedor
    End Function

    Public Function DeleteProvedor(id As Integer)
        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@Provedor_Id", id)
        }

        Return ExecuteNonQuery(delete)

    End Function

    Public Sub UpdateProvedor(provedor As Provedor)
        Try
            parameters = New List(Of MySqlParameter) From {
                New MySqlParameter("@Name", provedor.Name),
                New MySqlParameter("@Telefono", provedor.Telefono),
                New MySqlParameter("@Direccion", provedor.Direccion),
                New MySqlParameter("@Cuit", provedor.Cuit),
                New MySqlParameter("@Provedor_Id", provedor.Provedor_Id),
                New MySqlParameter("@ImageData", provedor.ProfileImage.ImageData),
                New MySqlParameter("@fotoId", provedor.ProfileImage.Id)
            }

            ExecuteNonQuery(update)
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

End Class
