<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBookmarks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBookmarks))
        Me.ListURL = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListName = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.ButRemove = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListURL
        '
        Me.ListURL.BackColor = System.Drawing.SystemColors.Info
        Me.ListURL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ListURL.FormattingEnabled = True
        Me.ListURL.Location = New System.Drawing.Point(211, 66)
        Me.ListURL.Name = "ListURL"
        Me.ListURL.Size = New System.Drawing.Size(347, 303)
        Me.ListURL.TabIndex = 14
        '
        'ListBox3
        '
        Me.ListBox3.BackColor = System.Drawing.SystemColors.Info
        Me.ListBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(558, 0)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(191, 369)
        Me.ListBox3.TabIndex = 16
        '
        'ListName
        '
        Me.ListName.BackColor = System.Drawing.SystemColors.Info
        Me.ListName.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListName.FormattingEnabled = True
        Me.ListName.Location = New System.Drawing.Point(0, 0)
        Me.ListName.Name = "ListName"
        Me.ListName.Size = New System.Drawing.Size(211, 369)
        Me.ListName.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.ButDelete)
        Me.GroupBox1.Controls.Add(Me.ButClear)
        Me.GroupBox1.Controls.Add(Me.ButRemove)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(211, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 58)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manage Links"
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButDelete.Location = New System.Drawing.Point(213, 20)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(117, 23)
        Me.ButDelete.TabIndex = 2
        Me.ButDelete.Text = "Delete all Stored links"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'ButClear
        '
        Me.ButClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButClear.Location = New System.Drawing.Point(118, 20)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(89, 23)
        Me.ButClear.TabIndex = 1
        Me.ButClear.Text = "Clear links"
        Me.ButClear.UseVisualStyleBackColor = False
        '
        'ButRemove
        '
        Me.ButRemove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButRemove.Location = New System.Drawing.Point(16, 20)
        Me.ButRemove.Name = "ButRemove"
        Me.ButRemove.Size = New System.Drawing.Size(96, 23)
        Me.ButRemove.TabIndex = 0
        Me.ButRemove.Text = "RemoveLink"
        Me.ButRemove.UseVisualStyleBackColor = False
        '
        'FrmBookmarks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.ClientSize = New System.Drawing.Size(749, 369)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListURL)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmBookmarks"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Manage Bookmarks"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListURL As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents ListName As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButClear As System.Windows.Forms.Button
    Friend WithEvents ButRemove As System.Windows.Forms.Button
End Class
