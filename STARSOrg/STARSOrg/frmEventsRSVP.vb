Imports System.Data.SqlClient
Public Class frmEventsRSVP
    Private objEvents As CEvents
    Private objRSVPs As CRSVPs
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
        'current screen
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
            'should have CDB throw the exception and handle it here instead?
        End Try
        If objEvents.CurrentObject.EventID <> "" Then
            lstEvents.SelectedIndex = lstEvents.FindStringExact(objEvents.CurrentObject.EventID)
        End If
        blnReloading = False
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objEvents.GetEventByID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                txtEventID.Text = .EventID
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnRSVP_Click(sender As Object, e As EventArgs) Handles btnRSVP.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        sslStatus.Text = ""
        'input validation
        If Not ValidateTextBoxLength(txtEventID, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtFirst, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtLast, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        'save current object?
        With objRSVPs.CurrentObject
            .EventID = Trim(txtEventID.Text)
            .FName = Trim(txtFirst.Text)
            .LName = Trim(txtLast.Text)
            .Email = Trim(txtEmail.Text)
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRSVPs.Save
            If intResult = 1 Then
                sslStatus.Text = "RSVP Record Saved"
            End If
            If intResult = -1 Then 'couldn't save?
                'TODO: insert error where date has occured???
                MessageBox.Show("RSVP could not be done", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("RSVP Save Error: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadEvents()
    End Sub

    Private Sub frmEventsRSVP_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
        objRSVPs = New CRSVPs
    End Sub

    Private Sub frmEventsRSVP_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadEvents()
    End Sub

    Private Sub lstEvents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEvents.SelectedIndexChanged
        If blnClearing Or lstEvents.SelectedIndex = -1 Then
            Exit Sub
        End If
        LoadSelectedRecord()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        blnClearing = True
        sslStatus.Text = ""
        errP.clear()
        ClearScreenControls(grpRSVP)
        blnClearing = False
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim RoleReport As New frmReportEventsRSVP
        RoleReport.Display(lstEvents.SelectedItem.ToString)
    End Sub
End Class