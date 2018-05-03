Public Class FrmTraceTool

    Private Sub FrmTool_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles FrmTool.DocumentCompleted
        Dim Rect As Rectangle = Me.FrmTool.Document.Body.ScrollRectangle
        Dim BodySize As New Size(Rect.Width, Rect.Height)
        Me.FrmTool.Size = BodySize
    End Sub
End Class