<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdminConsole
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPantherID = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboSecRoles = New System.Windows.Forms.ComboBox()
        Me.btnAddMember = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lsbMembers = New System.Windows.Forms.ListBox()
        Me.btnChangeMember = New System.Windows.Forms.Button()
        Me.btnDeleteMember = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ssStatus = New System.Windows.Forms.StatusStrip()
        Me.ssl = New System.Windows.Forms.ToolStripStatusLabel()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ssStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Label1.Location = New System.Drawing.Point(253, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Console"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(41, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "PantherID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(63, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "UserID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(45, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(19, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Security Role"
        '
        'txtPantherID
        '
        Me.txtPantherID.Location = New System.Drawing.Point(126, 20)
        Me.txtPantherID.MaxLength = 7
        Me.txtPantherID.Name = "txtPantherID"
        Me.txtPantherID.Size = New System.Drawing.Size(191, 20)
        Me.txtPantherID.TabIndex = 12
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(124, 58)
        Me.txtUserID.MaxLength = 15
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(191, 20)
        Me.txtUserID.TabIndex = 13
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(126, 96)
        Me.txtPassword.MaxLength = 8
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(191, 20)
        Me.txtPassword.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboSecRoles)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.txtPantherID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(355, 43)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(331, 264)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Information"
        '
        'cboSecRoles
        '
        Me.cboSecRoles.FormattingEnabled = True
        Me.cboSecRoles.Location = New System.Drawing.Point(126, 135)
        Me.cboSecRoles.Name = "cboSecRoles"
        Me.cboSecRoles.Size = New System.Drawing.Size(189, 21)
        Me.cboSecRoles.TabIndex = 16
        Me.cboSecRoles.Text = "Select Security Role"
        '
        'btnAddMember
        '
        Me.btnAddMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAddMember.Location = New System.Drawing.Point(12, 328)
        Me.btnAddMember.Name = "btnAddMember"
        Me.btnAddMember.Size = New System.Drawing.Size(149, 34)
        Me.btnAddMember.TabIndex = 25
        Me.btnAddMember.Text = "Add New Member"
        Me.btnAddMember.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(563, 332)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(123, 30)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lsbMembers
        '
        Me.lsbMembers.FormattingEnabled = True
        Me.lsbMembers.Location = New System.Drawing.Point(12, 43)
        Me.lsbMembers.Name = "lsbMembers"
        Me.lsbMembers.Size = New System.Drawing.Size(337, 264)
        Me.lsbMembers.TabIndex = 27
        '
        'btnChangeMember
        '
        Me.btnChangeMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnChangeMember.Location = New System.Drawing.Point(167, 328)
        Me.btnChangeMember.Name = "btnChangeMember"
        Me.btnChangeMember.Size = New System.Drawing.Size(151, 34)
        Me.btnChangeMember.TabIndex = 28
        Me.btnChangeMember.Text = "Change Member"
        Me.btnChangeMember.UseVisualStyleBackColor = True
        '
        'btnDeleteMember
        '
        Me.btnDeleteMember.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnDeleteMember.Location = New System.Drawing.Point(327, 328)
        Me.btnDeleteMember.Name = "btnDeleteMember"
        Me.btnDeleteMember.Size = New System.Drawing.Size(151, 34)
        Me.btnDeleteMember.TabIndex = 29
        Me.btnDeleteMember.Text = "Delete Member"
        Me.btnDeleteMember.UseVisualStyleBackColor = True
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'ssStatus
        '
        Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ssl})
        Me.ssStatus.Location = New System.Drawing.Point(0, 365)
        Me.ssStatus.Name = "ssStatus"
        Me.ssStatus.Size = New System.Drawing.Size(698, 22)
        Me.ssStatus.TabIndex = 30
        Me.ssStatus.Text = "StatusStrip1"
        '
        'ssl
        '
        Me.ssl.Name = "ssl"
        Me.ssl.Size = New System.Drawing.Size(0, 17)
        '
        'frmAdminConsole
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 387)
        Me.Controls.Add(Me.ssStatus)
        Me.Controls.Add(Me.btnDeleteMember)
        Me.Controls.Add(Me.btnChangeMember)
        Me.Controls.Add(Me.lsbMembers)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddMember)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAdminConsole"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmAdminConsole"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ssStatus.ResumeLayout(False)
        Me.ssStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPantherID As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboSecRoles As ComboBox
    Friend WithEvents btnAddMember As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lsbMembers As ListBox
    Friend WithEvents btnChangeMember As Button
    Friend WithEvents btnDeleteMember As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents ssStatus As StatusStrip
    Friend WithEvents ssl As ToolStripStatusLabel
End Class
