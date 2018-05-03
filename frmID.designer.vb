<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmID
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
        Me.btnIDGo = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtIDURL = New System.Windows.Forms.TextBox()
        Me.btnIDExit = New System.Windows.Forms.Button()
        Me.btnIDGet = New System.Windows.Forms.Button()
        Me.panel1 = New System.Windows.Forms.Panel()
        Me.wbID = New System.Windows.Forms.WebBrowser()
        Me.panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIDGo
        '
        Me.btnIDGo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIDGo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDGo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIDGo.Location = New System.Drawing.Point(296, 348)
        Me.btnIDGo.Name = "btnIDGo"
        Me.btnIDGo.Size = New System.Drawing.Size(75, 23)
        Me.btnIDGo.TabIndex = 12
        Me.btnIDGo.Text = "GO!"
        Me.btnIDGo.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(12, 353)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(57, 13)
        Me.label1.TabIndex = 11
        Me.label1.Text = "Enter URL"
        '
        'txtIDURL
        '
        Me.txtIDURL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtIDURL.Location = New System.Drawing.Point(75, 350)
        Me.txtIDURL.Name = "txtIDURL"
        Me.txtIDURL.Size = New System.Drawing.Size(214, 20)
        Me.txtIDURL.TabIndex = 10
        Me.txtIDURL.Text = "http://www.ncc-cla.com"
        '
        'btnIDExit
        '
        Me.btnIDExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIDExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIDExit.Location = New System.Drawing.Point(458, 348)
        Me.btnIDExit.Name = "btnIDExit"
        Me.btnIDExit.Size = New System.Drawing.Size(75, 23)
        Me.btnIDExit.TabIndex = 9
        Me.btnIDExit.Text = "Exit"
        Me.btnIDExit.UseVisualStyleBackColor = False
        '
        'btnIDGet
        '
        Me.btnIDGet.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnIDGet.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnIDGet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnIDGet.Location = New System.Drawing.Point(377, 348)
        Me.btnIDGet.Name = "btnIDGet"
        Me.btnIDGet.Size = New System.Drawing.Size(75, 23)
        Me.btnIDGet.TabIndex = 8
        Me.btnIDGet.Text = "Get"
        Me.btnIDGet.UseVisualStyleBackColor = False
        '
        'panel1
        '
        Me.panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel1.Controls.Add(Me.wbID)
        Me.panel1.Location = New System.Drawing.Point(0, 0)
        Me.panel1.Name = "panel1"
        Me.panel1.Size = New System.Drawing.Size(585, 311)
        Me.panel1.TabIndex = 7
        '
        'wbID
        '
        Me.wbID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wbID.Location = New System.Drawing.Point(0, 0)
        Me.wbID.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wbID.Name = "wbID"
        Me.wbID.Size = New System.Drawing.Size(585, 311)
        Me.wbID.TabIndex = 1
        Me.wbID.Url = New System.Uri("", System.UriKind.Relative)
        '
        'frmID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(587, 382)
        Me.Controls.Add(Me.btnIDGo)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtIDURL)
        Me.Controls.Add(Me.btnIDExit)
        Me.Controls.Add(Me.btnIDGet)
        Me.Controls.Add(Me.panel1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "frmID"
        Me.Text = "Image Downloader VB.NET"
        Me.panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents btnIDGo As System.Windows.Forms.Button
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtIDURL As System.Windows.Forms.TextBox
    Private WithEvents btnIDExit As System.Windows.Forms.Button
    Private WithEvents btnIDGet As System.Windows.Forms.Button
    Private WithEvents panel1 As System.Windows.Forms.Panel
    Private WithEvents wbID As System.Windows.Forms.WebBrowser

End Class
