Public Class User
    Public Property User_id As Integer
    Public Property Email As String
    Public Property Name As String
    Public Property Password As String
    Public Property Last_name As String
    Public Property Rol As String
    Public Property ProfileImage As UserProfileImage
    Public Property Clientes As ICollection(Of Cliente)
End Class
