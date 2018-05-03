<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPropertys
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPropertys))
        Me.TabSecurity = New System.Windows.Forms.TabPage()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ButDeleteHistory = New System.Windows.Forms.Button()
        Me.cbRememberHistory = New System.Windows.Forms.CheckBox()
        Me.grpPasswords = New System.Windows.Forms.GroupBox()
        Me.ButShowPasswords = New System.Windows.Forms.Button()
        Me.CBRememberPasswords = New System.Windows.Forms.CheckBox()
        Me.TabGeneral = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtHomepage = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbStartUp = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButSaveFilesto = New System.Windows.Forms.Button()
        Me.txt_SaveLocation = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Rb_DownloadFiles = New System.Windows.Forms.RadioButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabSecurity.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grpPasswords.SuspendLayout()
        Me.TabGeneral.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabSecurity
        '
        Me.TabSecurity.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.TabSecurity.Controls.Add(Me.GroupBox6)
        Me.TabSecurity.Controls.Add(Me.grpPasswords)
        Me.TabSecurity.Location = New System.Drawing.Point(4, 22)
        Me.TabSecurity.Name = "TabSecurity"
        Me.TabSecurity.Size = New System.Drawing.Size(379, 252)
        Me.TabSecurity.TabIndex = 3
        Me.TabSecurity.Text = "Security"
        Me.TabSecurity.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox6.Controls.Add(Me.ButDeleteHistory)
        Me.GroupBox6.Controls.Add(Me.cbRememberHistory)
        Me.GroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox6.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(363, 91)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "History"
        '
        'ButDeleteHistory
        '
        Me.ButDeleteHistory.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButDeleteHistory.Location = New System.Drawing.Point(16, 50)
        Me.ButDeleteHistory.Name = "ButDeleteHistory"
        Me.ButDeleteHistory.Size = New System.Drawing.Size(112, 23)
        Me.ButDeleteHistory.TabIndex = 2
        Me.ButDeleteHistory.Text = "Delete History"
        Me.ButDeleteHistory.UseVisualStyleBackColor = False
        '
        'cbRememberHistory
        '
        Me.cbRememberHistory.AutoSize = True
        Me.cbRememberHistory.BackColor = System.Drawing.SystemColors.Desktop
        Me.cbRememberHistory.Checked = Global.WebBrowser_App.My.MySettings.Default.History
        Me.cbRememberHistory.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbRememberHistory.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WebBrowser_App.My.MySettings.Default, "History", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbRememberHistory.Location = New System.Drawing.Point(16, 19)
        Me.cbRememberHistory.Name = "cbRememberHistory"
        Me.cbRememberHistory.Size = New System.Drawing.Size(145, 19)
        Me.cbRememberHistory.TabIndex = 1
        Me.cbRememberHistory.Text = "Remember History"
        Me.cbRememberHistory.UseVisualStyleBackColor = False
        '
        'grpPasswords
        '
        Me.grpPasswords.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.grpPasswords.Controls.Add(Me.ButShowPasswords)
        Me.grpPasswords.Controls.Add(Me.CBRememberPasswords)
        Me.grpPasswords.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpPasswords.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.grpPasswords.Location = New System.Drawing.Point(8, 109)
        Me.grpPasswords.Name = "grpPasswords"
        Me.grpPasswords.Size = New System.Drawing.Size(363, 135)
        Me.grpPasswords.TabIndex = 0
        Me.grpPasswords.TabStop = False
        Me.grpPasswords.Text = "Passwords"
        '
        'ButShowPasswords
        '
        Me.ButShowPasswords.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButShowPasswords.Location = New System.Drawing.Point(16, 56)
        Me.ButShowPasswords.Name = "ButShowPasswords"
        Me.ButShowPasswords.Size = New System.Drawing.Size(131, 23)
        Me.ButShowPasswords.TabIndex = 1
        Me.ButShowPasswords.Text = "Show saved passwords"
        Me.ButShowPasswords.UseVisualStyleBackColor = False
        '
        'CBRememberPasswords
        '
        Me.CBRememberPasswords.AutoSize = True
        Me.CBRememberPasswords.BackColor = System.Drawing.SystemColors.Desktop
        Me.CBRememberPasswords.Location = New System.Drawing.Point(16, 20)
        Me.CBRememberPasswords.Name = "CBRememberPasswords"
        Me.CBRememberPasswords.Size = New System.Drawing.Size(170, 19)
        Me.CBRememberPasswords.TabIndex = 0
        Me.CBRememberPasswords.Text = "Remember Passwords"
        Me.CBRememberPasswords.UseVisualStyleBackColor = False
        '
        'TabGeneral
        '
        Me.TabGeneral.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TabGeneral.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.TabGeneral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TabGeneral.Controls.Add(Me.GroupBox2)
        Me.TabGeneral.Controls.Add(Me.GroupBox1)
        Me.TabGeneral.Location = New System.Drawing.Point(4, 22)
        Me.TabGeneral.Name = "TabGeneral"
        Me.TabGeneral.Size = New System.Drawing.Size(379, 252)
        Me.TabGeneral.TabIndex = 0
        Me.TabGeneral.Text = "General"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtHomepage)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.CmbStartUp)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(363, 118)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Start Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(31, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Home Page"
        '
        'txtHomepage
        '
        Me.txtHomepage.BackColor = System.Drawing.SystemColors.Info
        Me.txtHomepage.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WebBrowser_App.My.MySettings.Default, "HomePage", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.txtHomepage.Location = New System.Drawing.Point(132, 58)
        Me.txtHomepage.Name = "txtHomepage"
        Me.txtHomepage.Size = New System.Drawing.Size(225, 20)
        Me.txtHomepage.TabIndex = 2
        Me.txtHomepage.Text = Global.WebBrowser_App.My.MySettings.Default.HomePage
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "On Browser Start"
        '
        'CmbStartUp
        '
        Me.CmbStartUp.BackColor = System.Drawing.SystemColors.Info
        Me.CmbStartUp.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.WebBrowser_App.My.MySettings.Default, "Startup", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CmbStartUp.FormattingEnabled = True
        Me.CmbStartUp.Items.AddRange(New Object() {"Go to Home Page", "Open a Blank Tab", "Open System Home Page"})
        Me.CmbStartUp.Location = New System.Drawing.Point(132, 19)
        Me.CmbStartUp.Name = "CmbStartUp"
        Me.CmbStartUp.Size = New System.Drawing.Size(225, 21)
        Me.CmbStartUp.TabIndex = 0
        Me.CmbStartUp.Text = Global.WebBrowser_App.My.MySettings.Default.Startup
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.ButSaveFilesto)
        Me.GroupBox1.Controls.Add(Me.txt_SaveLocation)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Rb_DownloadFiles)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(363, 105)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Downloads"
        '
        'ButSaveFilesto
        '
        Me.ButSaveFilesto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButSaveFilesto.Location = New System.Drawing.Point(101, 20)
        Me.ButSaveFilesto.Name = "ButSaveFilesto"
        Me.ButSaveFilesto.Size = New System.Drawing.Size(25, 20)
        Me.ButSaveFilesto.TabIndex = 2
        Me.ButSaveFilesto.Text = "..."
        Me.ButSaveFilesto.UseVisualStyleBackColor = False
        '
        'txt_SaveLocation
        '
        Me.txt_SaveLocation.BackColor = System.Drawing.SystemColors.Info
        Me.txt_SaveLocation.Location = New System.Drawing.Point(132, 20)
        Me.txt_SaveLocation.Name = "txt_SaveLocation"
        Me.txt_SaveLocation.Size = New System.Drawing.Size(225, 20)
        Me.txt_SaveLocation.TabIndex = 1
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.Color.White
        Me.RadioButton2.Location = New System.Drawing.Point(11, 46)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(199, 17)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Always ask where to save files"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'Rb_DownloadFiles
        '
        Me.Rb_DownloadFiles.AutoSize = True
        Me.Rb_DownloadFiles.BackColor = System.Drawing.Color.Transparent
        Me.Rb_DownloadFiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rb_DownloadFiles.ForeColor = System.Drawing.Color.White
        Me.Rb_DownloadFiles.Location = New System.Drawing.Point(11, 20)
        Me.Rb_DownloadFiles.Name = "Rb_DownloadFiles"
        Me.Rb_DownloadFiles.Size = New System.Drawing.Size(96, 17)
        Me.Rb_DownloadFiles.TabIndex = 0
        Me.Rb_DownloadFiles.TabStop = True
        Me.Rb_DownloadFiles.Text = "Save files to"
        Me.Rb_DownloadFiles.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabGeneral)
        Me.TabControl1.Controls.Add(Me.TabSecurity)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(387, 278)
        Me.TabControl1.TabIndex = 0
        '
        'FrmPropertys
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.ClientSize = New System.Drawing.Size(387, 278)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmPropertys"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Propertys"
        Me.TabSecurity.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.grpPasswords.ResumeLayout(False)
        Me.grpPasswords.PerformLayout()
        Me.TabGeneral.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabSecurity As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ButDeleteHistory As System.Windows.Forms.Button
    Friend WithEvents cbRememberHistory As System.Windows.Forms.CheckBox
    Friend WithEvents grpPasswords As System.Windows.Forms.GroupBox
    Friend WithEvents ButShowPasswords As System.Windows.Forms.Button
    Friend WithEvents CBRememberPasswords As System.Windows.Forms.CheckBox
    Friend WithEvents TabGeneral As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtHomepage As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbStartUp As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButSaveFilesto As System.Windows.Forms.Button
    Friend WithEvents txt_SaveLocation As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Rb_DownloadFiles As System.Windows.Forms.RadioButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
End Class
