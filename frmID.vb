Imports System.IO 'File Functions

Public Class frmID

    Private Sub btnIDGo_Click(sender As Object, e As EventArgs) Handles btnIDGo.Click

        wbID.Navigate(txtIDURL.Text) 'Navigate To URL

    End Sub

    Private Sub btnIDGet_Click(sender As Object, e As EventArgs) Handles btnIDGet.Click

        Dim wcObj As New System.Net.WebClient() 'Create New Web Client Object

        Dim hecImages As HtmlElementCollection = Me.wbID.Document.GetElementsByTagName("img") 'Browse Through HTML Tags

        Dim strWebTitle As String 'Web Page Title
        Dim strPath1 As String 'Folder Path
        Dim strPath2 As String 'Sub Folder Path

        strWebTitle = Me.wbID.DocumentTitle  'Obtain Web Page Title

        strPath1 = "c:\" & strWebTitle 'Create Folder Named Web Page Title
        strPath2 = strPath1 & "\Images" 'Create Images Sub Folder

        Dim diTitle As DirectoryInfo = Directory.CreateDirectory(strPath1)
        Dim diImages As DirectoryInfo = Directory.CreateDirectory(strPath2)

        For i As Integer = 0 To hecImages.Count - 1 'Loop Through All IMG Elements Found

            'Download Image(s) To Specified Path

            wcObj.DownloadFile(hecImages(i).GetAttribute("src"), strPath1 & "\images\" & i.ToString() & ".jpg")
        Next

    End Sub

    Private Sub btnIDExit_Click(sender As Object, e As EventArgs) Handles btnIDExit.Click

        Application.Exit() ' Exit

    End Sub
End Class