Imports System.IO
Public Class WebLinksGrabber
    Dim FrmWebbrowser As FrmWebBrowser
    Private Sub ListBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListBox1.MouseDoubleClick
        FrmWebbrowser.GoUrl(ListBox1.SelectedItem.ToString())
    End Sub
    Public Sub UpdateTextFileAs(ByRef Path As String, ByVal FileName As String, ByRef _text As String)
        Dim PathName As String = Path & FileName
        Try
            If File.Exists(PathName) = True Then File.Create(PathName).Dispose()
            Dim alltext As String = _text
            File.AppendAllText(PathName, alltext)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub SaveTextFileAs(ByRef Path As String, ByVal FileName As String, ByRef _text As String)
        Dim PathName As String = Path & FileName
        Try
            If File.Exists(PathName) = True Then File.Create(PathName).Dispose()
            Dim alltext As String = _text
            File.WriteAllText(PathName, alltext)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub UpdateLinks()
        Dim TextLinks As String = ""
        For Each Link As String In ListBox1.SelectedItems
            TextLinks = TextLinks & Link & vbCrLf
        Next
        UpdateTextFileAs(Application.StartupPath, "\Weblinks.txt", TextLinks)
    End Sub
    Private Sub CmdSaveLinks_Click(sender As Object, e As EventArgs) Handles CmdSaveLinks.Click
        Dim TextLinks As String = ""
        For Each Link As String In ListBox1.SelectedItems
            TextLinks = TextLinks & Link & vbCrLf
        Next
        Dim filename As String = InputBox("Enter Filename :", "Save Link List as", "*.TXT")
        Dim path As String = Application.StartupPath & "\" & filename
        Try
            If File.Exists(path) = True Then File.Create(path).Dispose()
            Dim alltext As String = TextLinks
            File.WriteAllText(path, alltext)
        Catch ex As Exception
        End Try
        UpdateLinks()
    End Sub

End Class