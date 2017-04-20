Imports System.Data.SqlClient

Public Class frmAdminConsole

    Private Security As CSecurity
    Private arrMembers As ArrayList
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAdminConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrMembers = New ArrayList
        cboSecRoles.Items.Add("ADMIN")
        cboSecRoles.Items.Add("OFFICER")
        cboSecRoles.Items.Add("MEMBER")
        cboSecRoles.Items.Add("GUEST")
        LoadMemberSecurity()
        FillListBox()
    End Sub

    Private Sub LoadMemberSecurity()
        arrMembers.Clear()
        Dim reader = myDB.GetDataReaderBySP("sp_GetAllSecuritys", Nothing)
        While reader.Read()
            Security = New CSecurity
            With Security
                .PantherID = reader.Item("PID") & ""
                .UserID = reader.Item("UserID") & ""
                .Password = reader.Item("Password") & ""
                .SecRole = reader.Item("SecRole") & ""
            End With
            arrMembers.Add(Security)
        End While
        reader.Close()
    End Sub

    Private Sub FillListBox()
        lsbMembers.Items.Clear()

        For Each item As CSecurity In arrMembers
            lsbMembers.Items.Add(item)
        Next
    End Sub

    Private Sub lsbMembers_Click(sender As Object, e As EventArgs) Handles lsbMembers.Click
        Security = lsbMembers.SelectedItem
        txtPantherID.Text = Security.PantherID
        txtPassword.Text = Security.Password
        txtUserID.Text = Security.UserID
        cboSecRoles.SelectedItem = Security.SecRole
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        Security.PantherID = txtPantherID.Text
        Security.UserID = txtUserID.Text
        Security.Password = txtPassword.Text
        Security.SecRole = cboSecRoles.SelectedItem
        If myDB.ExecSP("sp_AddNewSecurity", Security.GetNewMemberParameters()) = 1 Then
            LoadMemberSecurity()
            FillListBox()
            lsbMembers.SelectedItem = Security
        End If
    End Sub
End Class