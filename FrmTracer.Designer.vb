<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTraceTool
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
        Me.FrmTool = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'FrmTool
        '
        Me.FrmTool.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmTool.Location = New System.Drawing.Point(0, 0)
        Me.FrmTool.MinimumSize = New System.Drawing.Size(20, 20)
        Me.FrmTool.Name = "FrmTool"
        Me.FrmTool.ScriptErrorsSuppressed = True
        Me.FrmTool.Size = New System.Drawing.Size(934, 989)
        Me.FrmTool.TabIndex = 0
        Me.FrmTool.Url = New System.Uri("http://www.yougetsignal.com/tools/visual-tracert/", System.UriKind.Absolute)
        '
        'FrmTraceTool
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(934, 989)
        Me.Controls.Add(Me.FrmTool)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmTraceTool"
        Me.Text = "Tracer"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FrmTool As System.Windows.Forms.WebBrowser
End Class
