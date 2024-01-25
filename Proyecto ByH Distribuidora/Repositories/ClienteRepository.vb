Imports MySql.Data.MySqlClient
Public Class ClienteRepository
    Inherits MasterRepository

    Private selectAll As String
    Private insertCliente As String
    Private update As String
    Private delete As String
    Private selectAllClienteOfUser As String
    Private selectClienteByName As String
    Private selectClienteByID As String
    Private selectTotalCliente As String

    Public Sub New()

        selectAll = "SELECT *
                     FROM cliente
                     WHERE SoftDelete = FALSE"

        insertCliente = "INSERT INTO UserProfileImages (ImageData) VALUES (@ImgData);
                        INSERT INTO
                        cliente (Nombre, Cuit, Email, Ciudad, Telefono, Direccion, Vendedor_Id, UserProfileImageId, SoftDelete) 
                        VALUES (@Name,@Cuit,@Email,@Ciudad,@Telefono,@Direccion,@Vendedor_Id, LAST_INSERT_ID(),false);"

        update = "UPDATE cliente SET Nombre = @Name, Cuit = @Cuit, Email = @Email, Ciudad = @Ciudad, Telefono = @Telefono, Direccion = @Direccion  WHERE Cliente_Id = @Cliente_Id;"


        delete = "UPDATE cliente SET SoftDelete = True WHERE Cliente_Id = @cliente_id"


        selectAllClienteOfUser = "SELECT *
                                  FROM cliente c
                                  JOIN userprofileimages p on c.UserProfileImageId = p.Id
                                  where c.User_id = @User_id AND c.SoftDelete = false"

        selectClienteByName = "select Cliente_Id from cliente where name = @Name"

        selectClienteByID = "SELECT *
                             FROM cliente c
                             JOIN userprofileimages p on c.UserProfileImageId = p.Id
                             WHERE c.Cliente_Id = @id"

        selectTotalCliente = "SELECT COUNT(*) AS TotalClientes
                                FROM cliente
                                WHERE cliente.SoftDelete = false
                                "

    End Sub

    Public Function AddCliente(cliente As Cliente)
        Dim messages As String

        Try

            parameters = New List(Of MySqlParameter) From {
                    New MySqlParameter("@Name", cliente.Name),
                    New MySqlParameter("@Cuit", cliente.Cuit),
                    New MySqlParameter("@Email", cliente.Email),
                    New MySqlParameter("@Ciudad", cliente.Ciudad),
                    New MySqlParameter("@Telefono", cliente.Telefono),
                    New MySqlParameter("@Direccion", cliente.Direccion),
                    New MySqlParameter("@Vendedor_Id", cliente.Vendedor_Id),
                    New MySqlParameter("@ImgData", cliente.ProfileImage.ImageData)
            }

            ExecuteNonQuery(insertCliente)
            messages = "Cliente Agregado"
        Catch ex As MySqlException

            messages = ex.Message

        End Try

        Return messages

    End Function

    Public Function GetAll()
        Dim resultTable = ExecuteRender(selectAll)
        Dim listCliente = New List(Of Cliente)


        For Each item As DataRow In resultTable.Rows

            listCliente.Add(New Cliente With {
            .Cliente_Id = item(0),
            .Name = item(1),
            .Cuit = item(2),
            .Email = item(3),
            .Ciudad = item(4),
            .Telefono = item(5),
            .Direccion = item(6),
            .Vendedor_Id = item(7)
            })

        Next

        Return listCliente
    End Function

    Public Function GetTotal()
        Dim resultTable = ExecuteRender(selectTotalCliente)
        Dim total As Integer
        For Each item As DataRow In resultTable.Rows

            total = item(0)
        Next

        Return total
    End Function

    Public Function DeleteCliente(id As Integer)
        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@cliente_id", id)
        }

        Return ExecuteNonQuery(delete)

    End Function

    Public Sub UpdateCliente(cliente As Cliente)
        'parametros para cliente
        'parametros para Img

        Try
            parameters = New List(Of MySqlParameter) From {
                    New MySqlParameter("@Name", cliente.Name),
                    New MySqlParameter("@Cuit", cliente.Cuit),
                    New MySqlParameter("@Email", cliente.Email),
                    New MySqlParameter("@Ciudad", cliente.Ciudad),
                    New MySqlParameter("@Telefono", cliente.Telefono),
                    New MySqlParameter("@Direccion", cliente.Direccion),
                    New MySqlParameter("@Cliente_Id", cliente.Cliente_Id)
            }

            ExecuteNonQuery(update)
            MsgBox("cliente actualizado")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Function GetAllClienteByUser(id As Integer)

        parameters = New List(Of MySqlParameter) From {
            New MySqlParameter("@User_id", id)
        }
        Dim resultTable = ExecuteRender(selectAllClienteOfUser)
        Dim listCliente = New List(Of Cliente)


        For Each item As DataRow In resultTable.Rows
            Dim userProfileImg As New UserProfileImage
            userProfileImg.Id = item(7)
            userProfileImg.ImageData = item(8)

            listCliente.Add(New Cliente With {
            .Cliente_Id = item(0),
            .Name = item(1),
            .Telefono = item(2),
            .Direccion = item(3),
            .Vendedor_Id = item(4),
            .ProfileImage = userProfileImg
            })

        Next

        Return listCliente
    End Function

    Public Function getClienteByName(name As String)
        parameters = New List(Of MySqlParameter) From {
              New MySqlParameter("@Name", name)
        }

        Dim resultTable = ExecuteRender(selectClienteByName)
        Dim ID_Cliente As Integer
        For Each item In resultTable.Rows
            ID_Cliente = item(0)
        Next

        Return ID_Cliente
    End Function

    Public Function getClienteByID(id As Integer)
        parameters = New List(Of MySqlParameter) From {
              New MySqlParameter("@id", id)
        }

        Dim resultTable = ExecuteRender(selectClienteByID)
        Dim cliente As New Cliente
        For Each item In resultTable.Rows
            Dim userProfileImg As New UserProfileImage
            userProfileImg.Id = item(10)
            userProfileImg.ImageData = item(11)

            cliente.Cliente_Id = item(0)
            cliente.Name = item(1)
            cliente.Cuit = item(2)
            cliente.Ciudad = item(3)
            cliente.Email = item(4)
            cliente.Telefono = item(5)
            cliente.Direccion = item(6)
            cliente.Vendedor_Id = item(7)
            cliente.ProfileImage = userProfileImg

        Next

        Return cliente
    End Function


End Class
