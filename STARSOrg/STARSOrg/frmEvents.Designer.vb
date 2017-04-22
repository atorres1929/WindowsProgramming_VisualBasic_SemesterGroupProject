<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEvents
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpNewEv = New System.Windows.Forms.GroupBox()
        Me.chkNewEv = New System.Windows.Forms.CheckBox()
        Me.grpEditEv = New System.Windows.Forms.GroupBox()
        Me.txtEventID = New System.Windows.Forms.TextBox()
        Me.cboEventTypeID = New System.Windows.Forms.ComboBox()
        Me.cboSemesterID = New System.Windows.Forms.ComboBox()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.mskEndDate = New System.Windows.Forms.MaskedTextBox()
        Me.mskStartDate = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtEventDesc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.grpEvents = New System.Windows.Forms.GroupBox()
        Me.lstEvents = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sslStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.grpNewEv.SuspendLayout()
        Me.grpEditEv.SuspendLayout()
        Me.grpEvents.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.White
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator7, Me.tsbHome, Me.ToolStripSeparator6, Me.tsbMember, Me.ToolStripSeparator4, Me.tsbRole, Me.ToolStripSeparator5, Me.tsbEvent, Me.ToolStripSeparator3, Me.tsbRSVP, Me.ToolStripSeparator2, Me.tsbCourse, Me.ToolStripSeparator1, Me.tsbSemester, Me.ToolStripSeparator10, Me.tsbTutor, Me.ToolStripSeparator12, Me.tsbLogOut, Me.ToolStripSeparator8, Me.tsbHelp, Me.ToolStripSeparator9, Me.ToolStripSeparator11})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1390, 96)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSOrg.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSOrg.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSOrg.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLES"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSOrg.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENTS"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSOrg.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSOrg.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSOrg.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSOrg.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator12.AutoSize = False
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSOrg.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOG OUT"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSOrg.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(40, 115)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1324, 65)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EVENTS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpNewEv
        '
        Me.grpNewEv.Controls.Add(Me.chkNewEv)
        Me.grpNewEv.Location = New System.Drawing.Point(40, 223)
        Me.grpNewEv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpNewEv.Name = "grpNewEv"
        Me.grpNewEv.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpNewEv.Size = New System.Drawing.Size(584, 115)
        Me.grpNewEv.TabIndex = 4
        Me.grpNewEv.TabStop = False
        Me.grpNewEv.Text = "New Event"
        '
        'chkNewEv
        '
        Me.chkNewEv.AutoSize = True
        Me.chkNewEv.Location = New System.Drawing.Point(44, 46)
        Me.chkNewEv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.chkNewEv.Name = "chkNewEv"
        Me.chkNewEv.Size = New System.Drawing.Size(209, 29)
        Me.chkNewEv.TabIndex = 0
        Me.chkNewEv.Text = "Add a New Event"
        Me.chkNewEv.UseVisualStyleBackColor = True
        '
        'grpEditEv
        '
        Me.grpEditEv.Controls.Add(Me.txtEventID)
        Me.grpEditEv.Controls.Add(Me.cboEventTypeID)
        Me.grpEditEv.Controls.Add(Me.cboSemesterID)
        Me.grpEditEv.Controls.Add(Me.txtLocation)
        Me.grpEditEv.Controls.Add(Me.mskEndDate)
        Me.grpEditEv.Controls.Add(Me.mskStartDate)
        Me.grpEditEv.Controls.Add(Me.Label8)
        Me.grpEditEv.Controls.Add(Me.Label7)
        Me.grpEditEv.Controls.Add(Me.Label6)
        Me.grpEditEv.Controls.Add(Me.Label5)
        Me.grpEditEv.Controls.Add(Me.Label4)
        Me.grpEditEv.Controls.Add(Me.btnCancel)
        Me.grpEditEv.Controls.Add(Me.btnSave)
        Me.grpEditEv.Controls.Add(Me.txtEventDesc)
        Me.grpEditEv.Controls.Add(Me.Label3)
        Me.grpEditEv.Controls.Add(Me.Label2)
        Me.grpEditEv.Location = New System.Drawing.Point(692, 223)
        Me.grpEditEv.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpEditEv.Name = "grpEditEv"
        Me.grpEditEv.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpEditEv.Size = New System.Drawing.Size(672, 767)
        Me.grpEditEv.TabIndex = 6
        Me.grpEditEv.TabStop = False
        Me.grpEditEv.Text = "Edit Event"
        '
        'txtEventID
        '
        Me.txtEventID.Location = New System.Drawing.Point(206, 42)
        Me.txtEventID.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtEventID.MaxLength = 15
        Me.txtEventID.Name = "txtEventID"
        Me.txtEventID.Size = New System.Drawing.Size(392, 31)
        Me.txtEventID.TabIndex = 24
        '
        'cboEventTypeID
        '
        Me.cboEventTypeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEventTypeID.FormattingEnabled = True
        Me.cboEventTypeID.Location = New System.Drawing.Point(206, 385)
        Me.cboEventTypeID.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboEventTypeID.Name = "cboEventTypeID"
        Me.cboEventTypeID.Size = New System.Drawing.Size(392, 33)
        Me.cboEventTypeID.TabIndex = 23
        '
        'cboSemesterID
        '
        Me.cboSemesterID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSemesterID.FormattingEnabled = True
        Me.cboSemesterID.Location = New System.Drawing.Point(206, 446)
        Me.cboSemesterID.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.cboSemesterID.Name = "cboSemesterID"
        Me.cboSemesterID.Size = New System.Drawing.Size(392, 33)
        Me.cboSemesterID.TabIndex = 22
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(206, 635)
        Me.txtLocation.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtLocation.MaxLength = 15
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(392, 31)
        Me.txtLocation.TabIndex = 16
        '
        'mskEndDate
        '
        Me.mskEndDate.Location = New System.Drawing.Point(206, 571)
        Me.mskEndDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskEndDate.Mask = "00/00/0000"
        Me.mskEndDate.Name = "mskEndDate"
        Me.mskEndDate.Size = New System.Drawing.Size(392, 31)
        Me.mskEndDate.TabIndex = 14
        Me.mskEndDate.ValidatingType = GetType(Date)
        '
        'mskStartDate
        '
        Me.mskStartDate.Location = New System.Drawing.Point(206, 508)
        Me.mskStartDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.mskStartDate.Mask = "99/99/9999"
        Me.mskStartDate.Name = "mskStartDate"
        Me.mskStartDate.Size = New System.Drawing.Size(392, 31)
        Me.mskStartDate.TabIndex = 13
        Me.mskStartDate.ValidatingType = GetType(Date)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 388)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 25)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Event Type ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(38, 513)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Start Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 577)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "End Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 640)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 25)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 448)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Semester ID"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(438, 706)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 40)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(206, 706)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(160, 40)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtEventDesc
        '
        Me.txtEventDesc.Location = New System.Drawing.Point(206, 96)
        Me.txtEventDesc.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.txtEventDesc.MaxLength = 100
        Me.txtEventDesc.Multiline = True
        Me.txtEventDesc.Name = "txtEventDesc"
        Me.txtEventDesc.Size = New System.Drawing.Size(392, 262)
        Me.txtEventDesc.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 96)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Event ID"
        '
        'grpEvents
        '
        Me.grpEvents.Controls.Add(Me.lstEvents)
        Me.grpEvents.Location = New System.Drawing.Point(40, 379)
        Me.grpEvents.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpEvents.Name = "grpEvents"
        Me.grpEvents.Padding = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.grpEvents.Size = New System.Drawing.Size(584, 612)
        Me.grpEvents.TabIndex = 7
        Me.grpEvents.TabStop = False
        Me.grpEvents.Text = "EVENTS"
        '
        'lstEvents
        '
        Me.lstEvents.FormattingEnabled = True
        Me.lstEvents.ItemHeight = 25
        Me.lstEvents.Location = New System.Drawing.Point(30, 42)
        Me.lstEvents.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.lstEvents.Name = "lstEvents"
        Me.lstEvents.Size = New System.Drawing.Size(524, 554)
        Me.lstEvents.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 1039)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1390, 38)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'sslStatus
        '
        Me.sslStatus.AutoSize = False
        Me.sslStatus.Name = "sslStatus"
        Me.sslStatus.Size = New System.Drawing.Size(675, 33)
        Me.sslStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1390, 1077)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.grpEvents)
        Me.Controls.Add(Me.grpEditEv)
        Me.Controls.Add(Me.grpNewEv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEvents"
        Me.Text = "Events"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grpNewEv.ResumeLayout(False)
        Me.grpNewEv.PerformLayout()
        Me.grpEditEv.ResumeLayout(False)
        Me.grpEditEv.PerformLayout()
        Me.grpEvents.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents grpNewEv As GroupBox
    Friend WithEvents chkNewEv As CheckBox
    Friend WithEvents grpEditEv As GroupBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtEventDesc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grpEvents As GroupBox
    Friend WithEvents lstEvents As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mskEndDate As MaskedTextBox
    Friend WithEvents mskStartDate As MaskedTextBox
    Friend WithEvents txtLocation As TextBox
    Friend WithEvents cboEventTypeID As ComboBox
    Friend WithEvents cboSemesterID As ComboBox
    Friend WithEvents txtEventID As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sslStatus As ToolStripStatusLabel
    Friend WithEvents errP As ErrorProvider
End Class
