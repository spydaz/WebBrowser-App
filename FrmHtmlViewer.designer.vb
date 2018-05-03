<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHtmlViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHtmlViewer))
        Me.GrpHtmlEditor = New System.Windows.Forms.GroupBox()
        Me.ButCloses = New System.Windows.Forms.Button()
        Me.ButSubmit = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.ButHide = New System.Windows.Forms.Button()
        Me.GrpHtmlEditor.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpHtmlEditor
        '
        Me.GrpHtmlEditor.BackColor = System.Drawing.Color.Black
        Me.GrpHtmlEditor.Controls.Add(Me.ButHide)
        Me.GrpHtmlEditor.Controls.Add(Me.ButCloses)
        Me.GrpHtmlEditor.Controls.Add(Me.ButSubmit)
        Me.GrpHtmlEditor.Controls.Add(Me.RichTextBox1)
        Me.GrpHtmlEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpHtmlEditor.ForeColor = System.Drawing.Color.Lime
        Me.GrpHtmlEditor.Location = New System.Drawing.Point(0, 0)
        Me.GrpHtmlEditor.Name = "GrpHtmlEditor"
        Me.GrpHtmlEditor.Size = New System.Drawing.Size(783, 469)
        Me.GrpHtmlEditor.TabIndex = 0
        Me.GrpHtmlEditor.TabStop = False
        Me.GrpHtmlEditor.Text = "HTML Editor"
        '
        'ButCloses
        '
        Me.ButCloses.BackColor = System.Drawing.Color.Black
        Me.ButCloses.Location = New System.Drawing.Point(6, 440)
        Me.ButCloses.Name = "ButCloses"
        Me.ButCloses.Size = New System.Drawing.Size(75, 23)
        Me.ButCloses.TabIndex = 3
        Me.ButCloses.Text = "Close"
        Me.ButCloses.UseVisualStyleBackColor = False
        '
        'ButSubmit
        '
        Me.ButSubmit.BackColor = System.Drawing.Color.Black
        Me.ButSubmit.Location = New System.Drawing.Point(6, 383)
        Me.ButSubmit.Name = "ButSubmit"
        Me.ButSubmit.Size = New System.Drawing.Size(75, 23)
        Me.ButSubmit.TabIndex = 1
        Me.ButSubmit.Text = "Submit Code"
        Me.ButSubmit.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.AcceptsTab = True
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.RichTextBox1.EnableAutoDragDrop = True
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 16)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RichTextBox1.Size = New System.Drawing.Size(777, 361)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'ButHide
        '
        Me.ButHide.BackColor = System.Drawing.Color.Black
        Me.ButHide.Location = New System.Drawing.Point(7, 412)
        Me.ButHide.Name = "ButHide"
        Me.ButHide.Size = New System.Drawing.Size(74, 22)
        Me.ButHide.TabIndex = 4
        Me.ButHide.Text = "Hide"
        Me.ButHide.UseVisualStyleBackColor = False
        '
        'FrmHtmlViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(783, 469)
        Me.Controls.Add(Me.GrpHtmlEditor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHtmlViewer"
        Me.Text = "HtmlViewer"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GrpHtmlEditor.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrpHtmlEditor As System.Windows.Forms.GroupBox
    Friend WithEvents ButSubmit As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents ButCloses As System.Windows.Forms.Button
    Friend WithEvents ButHide As System.Windows.Forms.Button
End Class
