Imports MySql.Data.MySqlClient

Public MustInherit Class MasterRepository

    Inherits ConfigConnection

    'Es una lista donde se almacenan los parametros de las consultas
    Protected parameters As List(Of MySqlParameter)

    'ExecuteNonQuery Son consultas que modifican datos
    Protected Function ExecuteNonQuery(transactSql As String) As Integer

        Using connection = GetConnection()

            connection.Open()

            'Preparo la consulta
            Using command = New MySqlCommand

                'Le digo a que servidor hacer la consulta
                command.Connection = connection

                'Le paso la consulta
                command.CommandText = transactSql

                command.CommandType = CommandType.Text

                'Agrega los valores de los parametros a la consulta
                For Each item As MySqlParameter In parameters

                    command.Parameters.Add(item)

                Next

                Dim result = command.ExecuteNonQuery()

                parameters.Clear()


                Return result

            End Using


        End Using

    End Function

    Protected Function ExecuteRender(transactSql As String) As DataTable

        Using connection = GetConnection()

            connection.Open()

            Using command = New MySqlCommand

                'Le digo a que servidor hacer la consulta
                command.Connection = connection

                'Le paso la consulta
                command.CommandText = transactSql

                command.CommandType = CommandType.Text

                If parameters IsNot Nothing Then

                    If parameters.Count > 0 Then


                        'Agrega los valores de los parametros a la consulta
                        For Each item As MySqlParameter In parameters

                            command.Parameters.Add(item)

                        Next

                    End If

                End If

                'Guardo el resultado de la consulta
                Dim reader = command.ExecuteReader

                Using table = New DataTable

                    'Cargo el resultado de la consulta en una tabla
                    table.Load(reader)
                    reader.Dispose()

                    Return table

                End Using






            End Using

        End Using


    End Function


End Class
