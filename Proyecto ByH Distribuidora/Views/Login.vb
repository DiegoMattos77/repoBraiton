Public Class Login

    Private userServices As New UserServices

    Public Function ValidarCredenciales()
        Dim result As Boolean
        If txtEmail.Text <> "" And txtPwd.Text <> "" Then
            result = userServices.ValidarUsuario(txtEmail.Text, txtPwd.Text)
        End If

        Return result
    End Function

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Main.Show()

        'Me.Hide()
        If ValidarCredenciales() Then
            Main.Show()

            Me.Hide()
            labelError1.Visible = False
            labelError2.Visible = False
            txtEmail.Text = ""
            txtPwd.Text = ""

        Else
            labelError1.Visible = True
            labelError2.Visible = True
        End If


    End Sub



    Private Sub txtEmail_Click(sender As Object, e As EventArgs) Handles txtEmail.Click
        txtEmail.Text = ""
    End Sub

    Private Sub txtPwd_Click(sender As Object, e As EventArgs) Handles txtPwd.Click
        txtPwd.Text = ""
    End Sub
End Class