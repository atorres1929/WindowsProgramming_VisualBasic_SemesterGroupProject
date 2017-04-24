Public Class frmChangePassword

    Private Security As CSecurity
    Private Sub frmChangePassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Security = New CSecurity
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        errP.Clear()

        If txtUsername.Text = "" Or txtCurrentPassword.Text = "" Or txtNewPassword.Text = "" Then
            errP.SetError(txtUsername, "Username must be supplied")
            errP.SetError(txtCurrentPassword, "Password must be supplied")
            errP.SetError(txtNewPassword, "Password must be supplied")
        ElseIf txtNewPassword.Text <> txtVerifyPassword.Text Then
            errP.SetError(txtNewPassword, "Passwords do not match!")
            errP.SetError(txtVerifyPassword, "Passwords do not match!")
        ElseIf txtUsername.Text.ToLower = "guest" Then
            errP.SetError(txtUsername, "Cannot change guest password!")
        ElseIf txtNewPassword.Text = txtVerifyPassword.Text
            Security.UserID = txtUsername.Text
            Security.Password = txtCurrentPassword.Text
            If Security.CheckUserNameAndPassword = 1 Then
                Security.NewPassword = txtNewPassword.Text
                Security.UpdatePassword()
                Me.Close()
                MessageBox.Show("Password Changed")
            Else
                errP.SetError(txtUsername, "Check correct UserID")
                errP.SetError(txtCurrentPassword, "Check correct password")
            End If
        Else
            errP.SetError(txtUsername, "Check correct UserID")
            errP.SetError(txtCurrentPassword, "Check correct password")
            errP.SetError(txtNewPassword, "Check password matches")
            errP.SetError(txtVerifyPassword, "Check password matches")
        End If

    End Sub
End Class