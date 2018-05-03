<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHistory))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ButRemove = New System.Windows.Forms.Button()
        Me.ButDelete = New System.Windows.Forms.Button()
        Me.ButExit = New System.Windows.Forms.Button()
        Me.ButClear = New System.Windows.Forms.Button()
        Me.LBXhistory = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.GroupBox1.Controls.Add(Me.ButRemove)
        Me.GroupBox1.Controls.Add(Me.ButDelete)
        Me.GroupBox1.Controls.Add(Me.ButExit)
        Me.GroupBox1.Controls.Add(Me.ButClear)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(389, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(88, 289)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'ButRemove
        '
        Me.ButRemove.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButRemove.ForeColor = System.Drawing.Color.White
        Me.ButRemove.Location = New System.Drawing.Point(7, 107)
        Me.ButRemove.Name = "ButRemove"
        Me.ButRemove.Size = New System.Drawing.Size(75, 23)
        Me.ButRemove.TabIndex = 2
        Me.ButRemove.Text = "Remove"
        Me.ButRemove.UseVisualStyleBackColor = False
        '
        'ButDelete
        '
        Me.ButDelete.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButDelete.ForeColor = System.Drawing.Color.White
        Me.ButDelete.Location = New System.Drawing.Point(7, 78)
        Me.ButDelete.Name = "ButDelete"
        Me.ButDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButDelete.TabIndex = 1
        Me.ButDelete.Text = "Delete"
        Me.ButDelete.UseVisualStyleBackColor = False
        '
        'ButExit
        '
        Me.ButExit.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButExit.ForeColor = System.Drawing.Color.White
        Me.ButExit.Location = New System.Drawing.Point(7, 48)
        Me.ButExit.Name = "ButExit"
        Me.ButExit.Size = New System.Drawing.Size(75, 23)
        Me.ButExit.TabIndex = 0
        Me.ButExit.Text = "Exit"
        Me.ButExit.UseVisualStyleBackColor = False
        '
        'ButClear
        '
        Me.ButClear.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ButClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButClear.ForeColor = System.Drawing.Color.White
        Me.ButClear.Location = New System.Drawing.Point(6, 19)
        Me.ButClear.Name = "ButClear"
        Me.ButClear.Size = New System.Drawing.Size(75, 23)
        Me.ButClear.TabIndex = 0
        Me.ButClear.Text = "Clear"
        Me.ButClear.UseVisualStyleBackColor = False
        '
        'LBXhistory
        '
        Me.LBXhistory.BackColor = System.Drawing.SystemColors.Info
        Me.LBXhistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBXhistory.FormattingEnabled = True
        Me.LBXhistory.Location = New System.Drawing.Point(0, 0)
        Me.LBXhistory.Name = "LBXhistory"
        Me.LBXhistory.Size = New System.Drawing.Size(389, 289)
        Me.LBXhistory.TabIndex = 1
        '
        'FrmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 289)
        Me.Controls.Add(Me.LBXhistory)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHistory"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "FrmHistory"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ButExit As System.Windows.Forms.Button
    Friend WithEvents ButClear As System.Windows.Forms.Button
    Friend WithEvents LBXhistory As System.Windows.Forms.ListBox
    Friend WithEvents ButDelete As System.Windows.Forms.Button
    Friend WithEvents ButRemove As System.Windows.Forms.Button
End Class
