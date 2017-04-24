Imports System.Data.SqlClient
Public Class frmCourses
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private reportInfo As frmReportCourse

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
        'nothing to do here - already on the Course screen
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
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbHome.MouseEnter, tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbCourse.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbHome.MouseLeave, tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbCourse.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub
#End Region

    Private Sub LoadCourses()
        Dim objReader As SqlDataReader
        lstCourses.Items.Clear()
        Try
            objReader = objCourses.GetAllCourses
            Do While objReader.Read
                lstCourses.Items.Add(objReader.Item("CourseID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'should have CDB throw the exception and handle it here instead
        End Try
        'find the new/updated entry in the list if there is one and select it
        If objCourses.CurrentObject.CourseID <> "" Then
            lstCourses.SelectedIndex = lstCourses.FindStringExact(objCourses.CurrentObject.CourseID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmCourses_Load(sender As Object, e As EventArgs) Handles Me.Load
        objCourses = New CCourses
        reportInfo = New frmReportCourse

    End Sub

    Private Sub frmCourses_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadCourses()
        grpEdit.Enabled = False
    End Sub

    Private Sub lstCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourses.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If lstCourses.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objCourses.GetCourseByID(lstCourses.SelectedItem.ToString)
            With objCourses.CurrentObject
                txtCourseID.Text = .CourseID
                txtDesc.Text = .CourseDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Course values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstCourses.SelectedIndex <> -1 Then 'reload the selected record
            LoadSelectedRecord()
        Else 'disable the edit area because nothing was selected
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objCourses.CurrentObject.IsNewCourse = False
        grpCourses.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        sslStatus.Text = ""
        'first do input validation
        If Not ValidateTextBoxLength(txtCourseID, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtDesc, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        'load the current object with the form's data
        With objCourses.CurrentObject 'our CCourses object
            .CourseID = Trim(txtCourseID.Text)
            .CourseDescription = Trim(txtDesc.Text)
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objCourses.Save
            If intResult = 1 Then
                sslStatus.Text = "Course record Saved"
            End If
            If intResult = -1 Then 'ID is not unique
                MessageBox.Show("Course ID Must be Unique: Unable to Save Course Record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Course ID Must be Unique: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadCourses()
        chkNew.Checked = False
        grpCourses.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            sslStatus.Text = ""
            ClearScreenControls(grpEdit)
            lstCourses.SelectedIndex = -1
            grpCourses.Enabled = False
            grpEdit.Enabled = True
            objCourses.CreateNewCourse()
            txtCourseID.Focus()
        Else
            grpCourses.Enabled = True
            grpEdit.Enabled = False
            objCourses.CurrentObject.IsNewCourse = False
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        reportInfo.lstReport.Items.Clear() 'clear it in case it had previous values
        With reportInfo.lstReport
            For Each course As CCourse In lstCourses.Items
                .Items.Add(course.CourseID & ": " & course.CourseDescription)

            Next
        End With
        reportInfo.ShowDialog()
    End Sub
End Class