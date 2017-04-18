Public Class frmLogin

    Private ChangePassword As frmChangePassword
    Private Security As CSecurity
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        errP.Clear()
        Security.UserID = txtUserID.Text
        Security.Password = txtPassword.Text
        If txtUserID.Text = "" Or txtPassword.Text = "" Then
            errP.SetError(txtUserID, "Username must be supplied")
            errP.SetError(txtPassword, "Password must be supplied")
        ElseIf Security.Login = 1 Then 'no sql errors when logging in
            Me.Close()
        Else
            errP.SetError(txtUserID, "Username or Password Incorrect!")
            errP.SetError(txtPassword, "Username or Password Incorrect!")
        End If
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangePassword = New frmChangePassword
        Security = New CSecurity
    End Sub

    Private Sub chkGuest_CheckedChanged(sender As Object, e As EventArgs) Handles chkGuest.Click
        If chkGuest.Checked Then
            txtUserID.Enabled = False
            txtPassword.Enabled = False
            txtUserID.Text = "Guest"
            txtPassword.Text = "Guest"
        Else
            txtUserID.Enabled = True
            txtPassword.Enabled = True
            txtUserID.Text = ""
            txtPassword.Text = ""
        End If
    End Sub
End Class