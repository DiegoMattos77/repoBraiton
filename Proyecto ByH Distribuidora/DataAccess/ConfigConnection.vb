Imports MySql.Data.MySqlClient

Public MustInherit Class ConfigConnection

    Private ReadOnly connectionString As String

    Public Sub New()
        connectionString = "server=localhost; user=root; password=root; database=hyb_distribuidora;"
    End Sub

    Protected Function GetConnection() As MySqlConnection

        Return New MySqlConnection(connectionString)

    End Function

End Class
