<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmail))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSubject = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtMessage = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtEmailTo = New System.Windows.Forms.TextBox()
        Me.GrpEmail = New System.Windows.Forms.GroupBox()
        Me.ButAddAttachment = New System.Windows.Forms.Button()
        Me.CMBAttachments = New System.Windows.Forms.ComboBox()
        Me.ButClose = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BtnSend = New System.Windows.Forms.Button()
        Me.TxtEmailFrom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.ChkSSL = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpSMTP = New System.Windows.Forms.GroupBox()
        Me.TxtSMTP = New System.Windows.Forms.ComboBox()
        Me.GroupBox3.SuspendLayout()
        Me.GrpEmail.SuspendLayout()
        Me.GrpSMTP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Lime
        Me.Label1.Location = New System.Drawing.Point(16, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Subject"
        '
        'TxtSubject
        '
        Me.TxtSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSubject.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSubject.ForeColor = System.Drawing.Color.Lime
        Me.TxtSubject.Location = New System.Drawing.Point(95, 19)
        Me.TxtSubject.Name = "TxtSubject"
        Me.TxtSubject.Size = New System.Drawing.Size(486, 20)
        Me.TxtSubject.TabIndex = 6
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.BackColor = System.Drawing.Color.Black
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.TxtMessage)
        Me.GroupBox3.Controls.Add(Me.TxtSubject)
        Me.GroupBox3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox3.Location = New System.Drawing.Point(0, 172)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 264)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Message"
        '
        'TxtMessage
        '
        Me.TxtMessage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMessage.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMessage.ForeColor = System.Drawing.Color.Black
        Me.TxtMessage.Location = New System.Drawing.Point(19, 67)
        Me.TxtMessage.Multiline = True
        Me.TxtMessage.Name = "TxtMessage"
        Me.TxtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMessage.Size = New System.Drawing.Size(562, 183)
        Me.TxtMessage.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(96, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 14)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "To:"
        '
        'TxtEmailTo
        '
        Me.TxtEmailTo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmailTo.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailTo.ForeColor = System.Drawing.Color.Black
        Me.TxtEmailTo.Location = New System.Drawing.Point(130, 68)
        Me.TxtEmailTo.Name = "TxtEmailTo"
        Me.TxtEmailTo.Size = New System.Drawing.Size(351, 20)
        Me.TxtEmailTo.TabIndex = 14
        '
        'GrpEmail
        '
        Me.GrpEmail.BackColor = System.Drawing.Color.Black
        Me.GrpEmail.Controls.Add(Me.ButAddAttachment)
        Me.GrpEmail.Controls.Add(Me.CMBAttachments)
        Me.GrpEmail.Controls.Add(Me.ButClose)
        Me.GrpEmail.Controls.Add(Me.Label6)
        Me.GrpEmail.Controls.Add(Me.TxtEmailTo)
        Me.GrpEmail.Controls.Add(Me.BtnSend)
        Me.GrpEmail.Controls.Add(Me.TxtEmailFrom)
        Me.GrpEmail.Controls.Add(Me.Label2)
        Me.GrpEmail.Controls.Add(Me.Label3)
        Me.GrpEmail.Dock = System.Windows.Forms.DockStyle.Top
        Me.GrpEmail.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpEmail.ForeColor = System.Drawing.Color.Lime
        Me.GrpEmail.Location = New System.Drawing.Point(0, 0)
        Me.GrpEmail.Name = "GrpEmail"
        Me.GrpEmail.Size = New System.Drawing.Size(600, 156)
        Me.GrpEmail.TabIndex = 14
        Me.GrpEmail.TabStop = False
        Me.GrpEmail.Text = "Send Email"
        '
        'ButAddAttachment
        '
        Me.ButAddAttachment.BackColor = System.Drawing.Color.Black
        Me.ButAddAttachment.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButAddAttachment.Location = New System.Drawing.Point(506, 110)
        Me.ButAddAttachment.Name = "ButAddAttachment"
        Me.ButAddAttachment.Size = New System.Drawing.Size(75, 21)
        Me.ButAddAttachment.TabIndex = 18
        Me.ButAddAttachment.Text = "Add"
        Me.ButAddAttachment.UseVisualStyleBackColor = False
        '
        'CMBAttachments
        '
        Me.CMBAttachments.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBAttachments.FormattingEnabled = True
        Me.CMBAttachments.Location = New System.Drawing.Point(130, 109)
        Me.CMBAttachments.Name = "CMBAttachments"
        Me.CMBAttachments.Size = New System.Drawing.Size(351, 22)
        Me.CMBAttachments.TabIndex = 17
        '
        'ButClose
        '
        Me.ButClose.BackColor = System.Drawing.Color.Black
        Me.ButClose.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClose.Location = New System.Drawing.Point(506, 68)
        Me.ButClose.Name = "ButClose"
        Me.ButClose.Size = New System.Drawing.Size(75, 23)
        Me.ButClose.TabIndex = 16
        Me.ButClose.Text = "Close"
        Me.ButClose.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Lime
        Me.Label6.Location = New System.Drawing.Point(33, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 14)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Attachments:"
        '
        'BtnSend
        '
        Me.BtnSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSend.BackColor = System.Drawing.Color.Black
        Me.BtnSend.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSend.ForeColor = System.Drawing.Color.Lime
        Me.BtnSend.Location = New System.Drawing.Point(506, 30)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.Size = New System.Drawing.Size(75, 23)
        Me.BtnSend.TabIndex = 13
        Me.BtnSend.Text = "Send"
        Me.BtnSend.UseVisualStyleBackColor = False
        '
        'TxtEmailFrom
        '
        Me.TxtEmailFrom.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtEmailFrom.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmailFrom.ForeColor = System.Drawing.Color.Black
        Me.TxtEmailFrom.Location = New System.Drawing.Point(130, 31)
        Me.TxtEmailFrom.Name = "TxtEmailFrom"
        Me.TxtEmailFrom.Size = New System.Drawing.Size(351, 20)
        Me.TxtEmailFrom.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Lime
        Me.Label3.Location = New System.Drawing.Point(75, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Email:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Lime
        Me.Label4.Location = New System.Drawing.Point(39, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 14)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Email Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.TxtPassword.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.ForeColor = System.Drawing.Color.Black
        Me.TxtPassword.Location = New System.Drawing.Point(150, 65)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtPassword.Size = New System.Drawing.Size(317, 20)
        Me.TxtPassword.TabIndex = 13
        '
        'ChkSSL
        '
        Me.ChkSSL.AutoSize = True
        Me.ChkSSL.Checked = True
        Me.ChkSSL.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSSL.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSSL.ForeColor = System.Drawing.Color.Lime
        Me.ChkSSL.Location = New System.Drawing.Point(473, 25)
        Me.ChkSSL.Name = "ChkSSL"
        Me.ChkSSL.Size = New System.Drawing.Size(110, 18)
        Me.ChkSSL.TabIndex = 2
        Me.ChkSSL.Text = "Requires SSL"
        Me.ChkSSL.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(60, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "SMTP Server"
        '
        'GrpSMTP
        '
        Me.GrpSMTP.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GrpSMTP.BackColor = System.Drawing.Color.Black
        Me.GrpSMTP.Controls.Add(Me.TxtSMTP)
        Me.GrpSMTP.Controls.Add(Me.Label4)
        Me.GrpSMTP.Controls.Add(Me.TxtPassword)
        Me.GrpSMTP.Controls.Add(Me.ChkSSL)
        Me.GrpSMTP.Controls.Add(Me.Label5)
        Me.GrpSMTP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSMTP.ForeColor = System.Drawing.Color.Lime
        Me.GrpSMTP.Location = New System.Drawing.Point(0, 436)
        Me.GrpSMTP.Name = "GrpSMTP"
        Me.GrpSMTP.Size = New System.Drawing.Size(600, 120)
        Me.GrpSMTP.TabIndex = 13
        Me.GrpSMTP.TabStop = False
        Me.GrpSMTP.Text = "Server Settings"
        '
        'TxtSMTP
        '
        Me.TxtSMTP.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSMTP.FormattingEnabled = True
        Me.TxtSMTP.Items.AddRange(New Object() {"smtp.live.com", "smtp.gmail.com", "smtp.mail.me.com", "smtp.mail.yahoo.com"})
        Me.TxtSMTP.Location = New System.Drawing.Point(150, 23)
        Me.TxtSMTP.Name = "TxtSMTP"
        Me.TxtSMTP.Size = New System.Drawing.Size(317, 22)
        Me.TxtSMTP.TabIndex = 15
        '
        'FrmEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(600, 554)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GrpEmail)
        Me.Controls.Add(Me.GrpSMTP)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Email"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GrpEmail.ResumeLayout(False)
        Me.GrpEmail.PerformLayout()
        Me.GrpSMTP.ResumeLayout(False)
        Me.GrpSMTP.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSubject As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtEmailTo As System.Windows.Forms.TextBox
    Friend WithEvents GrpEmail As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSend As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtEmailFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents ChkSSL As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpSMTP As System.Windows.Forms.GroupBox
    Friend WithEvents ButClose As System.Windows.Forms.Button
    Friend WithEvents ButAddAttachment As System.Windows.Forms.Button
    Friend WithEvents CMBAttachments As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSMTP As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
