Imports System.Data.SqlClient
Public Class frmMembers
    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean

#Region "Toolbar"
    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        'intNextAction = ACTION_MEMBER
        'Me.Hide()

        'nothing here already in the members tab

    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
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

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
    End Sub

    Private Sub frmMembers_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadMembers()



        grpMemberInfo.Enabled = False
    End Sub

    'populate the combo box
    Private Sub LoadRoles()
        cboRole.Items.Add("Admin")
        cboRole.Items.Add("Alumni")
        cboRole.Items.Add("Guest")
        cboRole.Items.Add("Member")
        cboRole.Items.Add("Officer")
        cboRole.Items.Add("Outreach")
        cboRole.Items.Add("Tutor - Paid")
        cboRole.Items.Add("Tutor - Vol")
    End Sub
    'load the members from database
    Private Sub LoadMembers()
        Dim objReader As SqlDataReader
        lstMemberList.Items.Clear()
        Try
            objReader = objMembers.GetAllMembers
            Do While objReader.Read
                lstMemberList.Items.Add(objReader.Item("PID"))

            Loop
        Catch ex As Exception
            Throw
        End Try

        If objMembers.CurrentObject.PantherID <> " " Then
            lstMemberList.SelectedIndex = lstMemberList.FindStringExact(objMembers.CurrentObject.PantherID)
        End If
    End Sub

    Private Sub chkNewMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMember.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        'if turned on
        If chkNewMember.Checked Then
            ClearScreenControls(grpMemberInfo)
            'unselect from llistbox
            lstMemberList.SelectedIndex = -1
            'gray out the listbox
            grpMembers.Enabled = False
            'enable editing of info
            grpMemberInfo.Enabled = True
            objMembers.CreateNewMember()
            txtPanterID.Focus()
            'to avoid endless role addtions
            cboRole.Items.Clear()
            LoadRoles()
        Else
            'if cancled return to prior state
            grpMembers.Enabled = True
            grpMemberInfo.Enabled = False
            objMembers.CurrentObject.IsNewMember = False

        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean

        'if you clicked save

        'input validation for PantherID txtbox
        If Not ValidateTextBoxLength(txtPanterID, errP) Then
            blnError = True
        End If
        'input validation for first name
        If Not ValidateTextBoxLength(txtMemberFirst, errP) Then
            blnError = True
        End If
        'input validation for last name
        If Not ValidateTextBoxLength(txtMemberLast, errP) Then
            blnError = True
        End If
        'input validation for email
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnError = True
        End If
        'input validation for role comobo
        If Not ValidateCombo(cboRole, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        With objMembers.CurrentObject
            .PantherID = Trim(txtPanterID.Text)
            .FirstName = Trim(txtMemberFirst.Text)
            .LastName = Trim(txtMemberLast.Text)
            .Email = Trim(txtEmail.Text)
            .MiddleIn = Trim(txtMiddle.Text)
            .PhoneNumber = txtPhoneNumber.Text
            .RoleID = Text
            .Semester = Text
        End With

        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objMembers.Save
            If intResult = 1 Then
                sslStatus.text = "Member Record Saved"
            End If
            If intResult = -1 Then 'Panther Id is not unique
                MessageBox.Show("Panther ID Must be Unique: Unable to Save Member Record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "ERROR"
            End If
        Catch ex As Exception
            'MessageBox.Show("Role ID Must be Unique: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadMembers()
        chkNewMember.Checked = False
        grpMembers.Enabled = True
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNewMember.Checked = False
        errP.Clear()
        If lstMemberList.SelectedIndex <> -1 Then 'reload the selected record
            LoadSelectedRecord()
        Else
            grpMemberInfo.Enabled = False
        End If
        blnClearing = False
        objMembers.CurrentObject.IsNewMember = False
        ' grpMembers.Enabled = True
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objMembers.GetMemberByPID(lstMemberList.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPanterID.Text = .PantherID
                txtMemberFirst.Text = .FirstName
                txtMemberLast.Text = .LastName
                txtMiddle.Text = .MiddleIn
                txtEmail.Text = .Email
                txtPhoneNumber.Text = .PhoneNumber
                'TODO load picture
                cboRole.Items.Clear()
                LoadRoles()
                'cboRole.Text = .RoleID
                'cboSemester.Text = .Semester
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Member Values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstMemberList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMemberList.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If lstMemberList.SelectedIndex = -1 Then
            Exit Sub
        End If

        chkNewMember.Checked = False
        LoadSelectedMember()
        grpMemberInfo.Enabled = True
    End Sub

    Private Sub LoadSelectedMember()

        Try
            objMembers.GetMemberByPID(lstMemberList.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPanterID.Text = .PantherID
                txtMemberFirst.Text = .FirstName
                txtMemberLast.Text = .LastName
                txtMiddle.Text = .MiddleIn
                txtEmail.Text = .Email
                txtPhoneNumber.Text = .PhoneNumber
                'cboSemester = .Semester
                'cboRole = .RoleID
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading MEMBERS", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'TODO search btn

    'Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
    '    Dim searchRESULT As String = txtSearchMember.Text

    '    If txtSearchMember Then
    'End Sub
End Class