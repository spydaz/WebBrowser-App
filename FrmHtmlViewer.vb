Public Class FrmHtmlViewer
    'Methods for form positioning
    Private x, y As Integer
    Private newpoint As New Point
    Private Sub GroupBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles GrpHtmlEditor.KeyDown
        Try
            ' Form movement set integers
            x = Control.MousePosition.X - Me.Location.X
            y = Control.MousePosition.Y - Me.Location.Y
        Catch ex As Exception
            'just in case
        End Try
    End Sub
    Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles GrpHtmlEditor.MouseMove
        Try
            ' Form movement movement
            If e.Button = Windows.Forms.MouseButtons.Left Then
                newpoint = Control.MousePosition
                newpoint.X -= (x)
                newpoint.Y -= (y)
                Me.Location = newpoint
            End If
        Catch ex As Exception
            'just in case
        End Try
    End Sub
    Private Sub ButSubmit_Click(sender As Object, e As EventArgs) Handles ButSubmit.Click
        Dim newfrm As New FrmWebBrowser
        newfrm.Show()
        'newfrm.openSource(RichTextBox1.Text())
    End Sub
    Private Sub ButCloses_Click(sender As Object, e As EventArgs) Handles ButCloses.Click
        Close()
    End Sub
    Private Sub ButHide_Click(sender As Object, e As EventArgs) Handles ButHide.Click
        Me.Hide()
    End Sub
End Class