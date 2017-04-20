<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.chkGuest = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnExit.Location = New System.Drawing.Point(316, 242)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(57, 33)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(96, 82)
        Me.txtUserID.MaxLength = 15
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(231, 20)
        Me.txtUserID.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(96, 118)
        Me.txtPassword.MaxLength = 8
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(231, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnLogin.Location = New System.Drawing.Point(157, 169)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(74, 31)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'chkGuest
        '
        Me.chkGuest.AutoSize = True
        Me.chkGuest.Location = New System.Drawing.Point(144, 242)
        Me.chkGuest.Name = "chkGuest"
        Me.chkGuest.Size = New System.Drawing.Size(97, 17)
        Me.chkGuest.TabIndex = 4
        Me.chkGuest.Text = "Login as Guest"
        Me.chkGuest.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(90, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Login Information"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnChangePassword.Location = New System.Drawing.Point(117, 206)
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.Size = New System.Drawing.Size(148, 30)
        Me.btnChangePassword.TabIndex = 6
        Me.btnChangePassword.Text = "Change Password"
        Me.btnChangePassword.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "User ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password:"
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(385, 287)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkGuest)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents chkGuest As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnChangePassword As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents errP As ErrorProvider
End Class
