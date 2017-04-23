Imports System.Data.SqlClient
Public Class frmSemesters
    Private objSemesters As CSemesters
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

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        'nothing to do here - already on the Semester screen
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

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbHome.MouseEnter, tsbSemester.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbSemester.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbHome.MouseLeave, tsbSemester.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbSemester.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'We need to do this only because we put our images in the BackgroundImage property instead of the Image property
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub
#End Region

    Private Sub LoadSemesters()
        Dim objReader As SqlDataReader
        lstSemesters.Items.Clear()
        Try
            objReader = objSemesters.GetAllSemesters
            Do While objReader.Read
                lstSemesters.Items.Add(objReader.Item("SemesterID"))
            Loop
            objReader.Close()
        Catch ex As Exception
            'should have CDB throw the exception and handle it here instead
        End Try
        'find the new/updated entry in the list if there is one and select it
        If objSemesters.CurrentObject.SemesterID <> "" Then
            lstSemesters.SelectedIndex = lstSemesters.FindStringExact(objSemesters.CurrentObject.SemesterID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmSemesters_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSemesters = New CSemesters

    End Sub

    Private Sub frmSemesters_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadSemesters()
        grpEdit.Enabled = False
    End Sub

    Private Sub lstSemesters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemesters.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If

        If lstSemesters.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNew.Checked = False
        LoadSelectedRecord()
        grpEdit.Enabled = True
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objSemesters.GetSemesterByID(lstSemesters.SelectedItem.ToString)
            With objSemesters.CurrentObject
                txtSemesterID.Text = .SemesterID
                txtDesc.Text = .SemesterDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Semester values", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        blnClearing = True
        sslStatus.Text = ""
        chkNew.Checked = False
        errP.Clear()
        If lstSemesters.SelectedIndex <> -1 Then 'reload the selected record
            LoadSelectedRecord()
        Else 'disable the edit area because nothing was selected
            grpEdit.Enabled = False
        End If
        blnClearing = False
        objSemesters.CurrentObject.IsNewSemester = False
        grpSemesters.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnError As Boolean
        sslStatus.Text = ""
        'first do input validation
        If Not ValidateTextBoxLength(txtSemesterID, errP) Then
            blnError = True
        End If
        If Not ValidateTextBoxLength(txtDesc, errP) Then
            blnError = True
        End If
        If blnError Then
            Exit Sub
        End If
        'load the current object with the form's data
        With objSemesters.CurrentObject 'our CSemesters object
            .SemesterID = Trim(txtSemesterID.Text)
            .SemesterDescription = Trim(txtDesc.Text)
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objSemesters.Save
            If intResult = 1 Then
                sslStatus.Text = "Semester record Saved"
            End If
            If intResult = -1 Then 'ID is not unique
                MessageBox.Show("Semester ID Must be Unique: Unable to Save Semester Record", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Semester ID Must be Unique: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadSemesters()
        chkNew.Checked = False
        grpSemesters.Enabled = True 'in case it was disabled for a new record
    End Sub

    Private Sub chkNew_CheckedChanged(sender As Object, e As EventArgs) Handles chkNew.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNew.Checked Then
            sslStatus.Text = ""
            ClearScreenControls(grpEdit)
            lstSemesters.SelectedIndex = -1
            grpSemesters.Enabled = False
            grpEdit.Enabled = True
            objSemesters.CreateNewSemester()
            txtSemesterID.Focus()
        Else
            grpSemesters.Enabled = True
            grpEdit.Enabled = False
            objSemesters.CurrentObject.IsNewSemester = False
        End If
    End Sub
End Class