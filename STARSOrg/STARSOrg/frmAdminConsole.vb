Imports System.Data.SqlClient

Public Class frmAdminConsole

    Private Security As CSecurity
    Private arrMembers As ArrayList
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmAdminConsole_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        arrMembers = New ArrayList
        Security = New CSecurity
        cboSecRoles.Items.Add("ADMIN")
        cboSecRoles.Items.Add("OFFICER")
        cboSecRoles.Items.Add("MEMBER")
        cboSecRoles.Items.Add("GUEST")
        LoadMemberSecurity()
        FillListBox()
        lsbMembers.SelectedIndex = -1
    End Sub

    'TODO load panther id from members who have no security role
    Private Sub LoadMemberSecurity()
        arrMembers.Clear()
        Dim reader = myDB.GetDataReaderBySP("sp_GetAllMembersInSecurity", Nothing)
        While reader.Read()
            With Security
                .PantherID = reader.Item("PID") & ""
                Try
                    .UserID = reader.Item("UserID") & ""
                Catch ex As Exception
                    .UserID = ""
                End Try
                Try
                    .Password = reader.Item("Password") & ""
                Catch ex As Exception
                    .Password = ""
                End Try
                Try
                    .SecRole = reader.Item("SecRole") & ""
                Catch ex As Exception
                    .SecRole = ""
                End Try
            End With
            arrMembers.Add(Security)
            Security = New CSecurity
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
        errP.Clear()
        If lsbMembers.SelectedItem Is Nothing Then
            Return
        End If
        Security = lsbMembers.SelectedItem
        lblPantherID.Text = Security.PantherID
        txtPassword.Text = Security.Password
        txtUserID.Text = Security.UserID
        cboSecRoles.SelectedItem = Security.SecRole
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        errP.Clear()
        LoadSecurity()
        For Each item As CSecurity In arrMembers
            If item.PantherID = Security.PantherID Then
                ssl.Text = "You cannot enter a Panther ID that already exists!"
                errP.SetError(lblPantherID, "You cannot enter a Panther ID that already exists!")
                Return
            ElseIf item.UserID = Security.UserID
                ssl.Text = "You cannot enter a UserID that already exists!"
                errP.SetError(txtUserID, "You cannot enter a UserID that already exists!")
                Return
            End If
        Next
        If myDB.ExecSP("sp_AddNewSecurity", Security.GetMemberParameters()) = 1 Then
            LoadMemberSecurity()
            FillListBox()
            lsbMembers.SelectedItem = Security
            ssl.Text = "Add member succeeded"
        Else
            errP.SetError(lblPantherID, "Member may not exist")
            ssl.Text = "Add member failed"
        End If
    End Sub

    Private Sub btnChangeMember_Click(sender As Object, e As EventArgs) Handles btnChangeMember.Click
        errP.Clear()
        LoadSecurity()
        If myDB.ExecSP("sp_UpdateSecurity", Security.GetMemberParameters()) = 1 Then
            LoadMemberSecurity()
            FillListBox()
            lsbMembers.SelectedItem = Security
            ssl.Text = "Update member succeeded"
        Else
            errP.SetError(lblPantherID, "Member may not exist")
            ssl.Text = "Update member failed"
        End If
    End Sub

    Private Sub btnDeleteMember_Click(sender As Object, e As EventArgs)
        errP.Clear()
        LoadSecurity()
        If myDB.ExecSP("sp_DeleteSecurity", Security.GetMemberParameters) = 1 Then
            LoadMemberSecurity()
            FillListBox()
            lsbMembers.SelectedItem = -1
            ssl.Text = "Delete member succeeded"
        Else
            errP.SetError(lblPantherID, "Member may not exist")
            ssl.Text = "Delete member failed"
        End If
    End Sub

    Private Sub LoadSecurity()
        Security.PantherID = lblPantherID.Text
        Security.UserID = txtUserID.Text
        Security.Password = txtPassword.Text
        Security.SecRole = cboSecRoles.SelectedItem
    End Sub
End Class