Imports System.Data.SqlClient
Public Class frmRoles
    Private objRoles As CRoles
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar"
    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        'nothing to do here - already on the Role screen
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbHome.MouseEnter, tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbHome.MouseLeave, tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub
#End Region
    Private Sub frmRoles_Load(sender As Object, e As EventArgs) Handles Me.Load
        objRoles = New CRoles
    End Sub
    Private Sub frmRoles_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadRoles()
        grpEdit.Enabled = False
    End Sub
    Private Sub LoadRoles()
        Dim objReader As SqlDataReader
        lstRoles.Items.Clear()
        Try
            objReader = objRoles.GetAllRoles
            Do While objReader.Read
                lstRoles.Items.Add(objReader.Item("RoleID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'should have CDB throw the exception and handle it here instead
        End Try
        objReader.Close()
        'find the new/updated entry in the list if there is one and select it
        If objRoles.CurrentObject.RoleID <> "" Then
            lstRoles.SelectedIndex = lstRoles.FindStringExact(objRoles.CurrentObject.RoleID)
        End If
        blnReloading = False
    End Sub
    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstRoles.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If lstRoles.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objRoles.GetRoleByID(lstRoles.SelectedItem.ToString)
            With objRoles.CurrentObject
                txtRoleID.Text = .RoleID
                txtDesc.Text = .RoleDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Role values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstRoles.SelectedIndex <> -1 Then 'reload the selected record
            LoadSelectedRecord()
        Else 'disable the edit area because nothing was selected
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objRoles.CurrentObject.IsNewRole = False
        grpRoles.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        sslStatus.Text = ""
        'first do input validation
        If Not ValidateTextBoxLength(txtRoleID, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtDesc, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        'load the current object with the form's data
        With objRoles.CurrentObject 'our CRoles object
            .RoleID = Trim(txtRoleID.Text)
            .RoleDescription = Trim(txtDesc.Text)
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRoles.Save
            If intResult = 1 Then
                sslStatus.Text = "Role record Saved"
            End If
            If intResult = -1 Then 'ID is not unique
                MessageBox.Show("Role ID Must be Unique: Unable to Save Role Record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Role ID Must be Unique: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadRoles()
        chkNew.Checked = False
        grpRoles.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            sslStatus.Text = ""
            ClearScreenControls(grpEdit)
            lstRoles.SelectedIndex = -1
            grpRoles.Enabled = False
            grpEdit.Enabled = True
            objRoles.CreateNewRole()
            txtRoleID.Focus()
        Else
            grpRoles.Enabled = True
            grpEdit.Enabled = False
            objRoles.CurrentObject.IsNewRole = False
        End If
    End Sub
End Class