Imports System.Data.SqlClient
Public Class frmEvents
    Private objEvents As CEvents
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar"
    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
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
        'current screen
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

    Private Sub LoadEvents()
        Dim objReader As SqlDataReader
        lstEvents.Items.Clear()
        Try
            objReader = objEvents.GetAllEvents
            Do While objReader.Read
                lstEvents.Items.Add(objReader.Item("EventID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Loading Event", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        If objEvents.CurrentObject.EventID <> "" Then
            lstEvents.SelectedIndex = lstEvents.FindStringExact(objEvents.CurrentObject.EventID)
        End If
        blnReloading = False
    End Sub

    Private Sub LoadEventTypeIDs()
        Dim objReader As SqlDataReader
        cboEventTypeID.Items.Clear()
        Try
            objReader = objEvents.GetAllEventTypeIDs
            Do While objReader.Read
                cboEventTypeID.Items.Add(objReader.Item("EventTypeID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Loading Event Type IDs", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSemesterIDs()
        Dim objReader As SqlDataReader
        cboSemesterID.Items.Clear()
        Try
            objReader = objEvents.GetAllSemesterIDs
            Do While objReader.Read
                cboSemesterID.Items.Add(objReader.Item("SemesterID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Loading Semester IDs", "Program Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objEvents.GetEventByID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                txtEventID.Text = .EventID
                txtEventDesc.Text = .EventDescription
                cboEventTypeID.SelectedItem = .EventTypeID
                cboSemesterID.SelectedItem = .SemesterID
                mskStartDate.Text = Format(.StartDate, "MM-dd-yyyy")
                mskEndDate.Text = Format(.EndDate, "MM-dd-yyyy")
                txtLocation.Text = .Location
                If .EndDate < Date.Today Then 'event has occured
                    txtEventID.Enabled = False
                    txtEventDesc.Enabled = False
                    cboSemesterID.Enabled = False
                    mskStartDate.Enabled = False
                    mskEndDate.Enabled = False
                    txtLocation.Enabled = False
                Else
                    txtEventID.Enabled = True
                    txtEventDesc.Enabled = True
                    cboSemesterID.Enabled = True
                    mskStartDate.Enabled = True
                    mskEndDate.Enabled = True
                    txtLocation.Enabled = True
                End If
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
    End Sub

    Private Sub frmEvents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadEvents()
        LoadEventTypeIDs()
        LoadSemesterIDs()
        grpEditEv.Enabled = False
    End Sub

    Private Sub lstEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEvents.SelectedIndexChanged
        If blnClearing Or lstEvents.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNewEv.Checked = False
        LoadSelectedRecord()
        grpEditEv.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNewEv.Checked = False
        errP.Clear()
        ClearScreenControls(grpEditEv)
        lstEvents.SelectedIndex = -1
        grpEditEv.Enabled = False
        blnClearing = False
        objEvents.CurrentObject.isNewEvent = False
        grpEvents.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        sslStatus.Text = ""
        'input validation
        If Not ValidateTextBoxLength(txtEventID, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtEventDesc, errP) Then
            blnError = True
        End If
        If Not ValidateCombo(cboEventTypeID, errP) Then
            blnError = True
        End If
        If Not ValidateCombo(cboSemesterID, errP) Then
            blnError = True
        End If
        If Not ValidateMaskedTextBoxDate(mskStartDate, errP) Then
            blnError = True
        End If
        If Not ValidateMaskedTextBoxDate(mskEndDate, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtLocation, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        'save current object
        With objEvents.CurrentObject
            .EventID = Trim(txtEventID.Text)
            .EventDescription = Trim(txtEventDesc.Text)
            .EventTypeID = cboEventTypeID.SelectedItem.ToString
            .SemesterID = cboSemesterID.SelectedItem.ToString
            .StartDate = CDate(mskStartDate.Text)
            .EndDate = CDate(mskEndDate.Text)
            .Location = Trim(txtLocation.Text)
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objEvents.Save
            If intResult = 1 Then
                sslStatus.Text = "Event Record Saved"
            End If
            If intResult = -1 Then 'ID exists
                MessageBox.Show("Event ID Must be Unique: Unable to Save Event Record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Event ID Must be Unique: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadEvents()
        LoadEventTypeIDs()
        LoadSemesterIDs()
        chkNewEv.Checked = False
        grpEvents.Enabled = True
    End Sub

    Private Sub chkNewEv_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewEv.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewEv.Checked Then 'New Event
            sslStatus.Text = ""
            ClearScreenControls(grpEditEv)
            lstEvents.SelectedIndex = -1
            grpEvents.Enabled = False
            grpEditEv.Enabled = True
            objEvents.CreatNewEvent()
            txtEventID.Focus()
        Else
            grpEvents.Enabled = True
            grpEditEv.Enabled = False
            objEvents.CurrentObject.isNewEvent = False
        End If
    End Sub
End Class