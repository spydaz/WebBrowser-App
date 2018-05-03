Imports System.Net.Mail
Imports System.IO
Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmEmail
    'Methods for form positioning
    Private x, y As Integer
    Private newpoint As New Point
    Dim attachment As System.Net.Mail.Attachment
    Dim message As New MailMessage
    Dim AttachmentFiles As New ArrayList
    'SMTP SETTINGS
    Dim SMTPHotmail As String = "smtp.live.com"
    Dim SMTPGoogle As String = "smtp.Gmail.com"
    Dim SMTPIcloud As String = "smtp.mail.me.com"
    Dim SMTPYahoo As String = "smtp.mail.yahoo.com"

    Private Sub GroupBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles GrpEmail.KeyDown
        Try
            ' Form movement set integers
            x = Control.MousePosition.X - Me.Location.X
            y = Control.MousePosition.Y - Me.Location.Y
        Catch ex As Exception
            'just in case
        End Try
    End Sub
    Private Sub GroupBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles GrpEmail.MouseMove
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
    Private Sub BtnSend_Click(sender As Object, e As EventArgs) Handles BtnSend.Click
        'message settings
        message.From = New MailAddress(TxtEmailFrom.Text)
        message.To.Add(TxtEmailTo.Text)
        message.Subject = TxtSubject.Text
        message.Body = TxtMessage.Text
        AddAttachments()
        'smtpServer settings
        Dim smtp As New SmtpClient(TxtSMTP.SelectedText)
        smtp.EnableSsl = ChkSSL.CheckState
        smtp.Credentials = New System.Net.NetworkCredential(TxtEmailFrom.Text, TxtPassword.Text)
        smtp.Send(message)
        MessageBox.Show("sent")
        TxtMessage.Text = ""
        TxtEmailTo.Text = ""
        TxtSubject.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButClose.Click
        Me.Close()
    End Sub
    Public Sub AddAttachments()
        'Multiple
        Dim iCnt As Integer
        If AttachmentFiles IsNot Nothing Then
            iCnt = AttachmentFiles.Count - 1
            For i = 0 To iCnt
                If FileExists(AttachmentFiles(i)) Then _
                 message.Attachments.Add(AttachmentFiles(i))
            Next
        End If
    End Sub
    Public Sub AddAttachment()
        'single
        attachment = New System.Net.Mail.Attachment("filePath")
        message.Attachments.Add(attachment)
    End Sub
    Private Function FileExists(ByVal FileFullPath As String) As Boolean
        If Trim(FileFullPath) = "" Then Return False
        Dim f As New IO.FileInfo(FileFullPath)
        Return f.Exists
    End Function
    Private Sub AddAttachmentToList()
        Dim Afile As New OpenFileDialog
        Afile.InitialDirectory = "c:\"
        Afile.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        Afile.FilterIndex = 2
        Afile.RestoreDirectory = True
        Afile.ShowDialog()
        Dim FilePath As String = Afile.FileName
        AttachmentFiles.Add(FilePath)
        CMBAttachments.Items.Add(FilePath)
    End Sub

    Private Sub ButAddAttachment_Click(sender As Object, e As EventArgs) Handles ButAddAttachment.Click
        AddAttachmentToList()
    End Sub

    Private Sub GrpSMTP_Click(sender As Object, e As EventArgs) Handles GrpSMTP.Click
        If GrpSMTP.Height < 120 Then
            GrpSMTP.Height = 120
        Else
            GrpSMTP.Height = 16
        End If

    End Sub

    Private Sub FrmEmail_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        message.Dispose()
        Me.Dispose()
    End Sub
End Class