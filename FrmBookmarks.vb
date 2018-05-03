
Imports System.IO

Public Class FrmBookmarks
    Private Sub FrmBookmarks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        File.Delete(Application.StartupPath & "\FavoritesName.txt")
        File.Delete(Application.StartupPath & "\FavoritesUrl.txt")
        For Each favoritename As String In Me.ListName.Items
            File.AppendAllText(Application.StartupPath & "\FavoritesName.txt", favoritename & vbCrLf)
        Next

        For Each favoriteURL As String In Me.ListURL.Items
            File.AppendAllText(Application.StartupPath & "\FavoritesUrl.txt", favoriteURL & vbCrLf)
        Next
        Me.ListName.Items.Clear()
        Me.ListURL.Items.Clear()
        Me.ListBox3.Items.Clear()

    End Sub
    Private Sub FrmBookmarks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            For Each FavUrl As String In File.ReadAllLines(Application.StartupPath & "\FavoritesUrl.txt")
                Me.ListURL.Items.Add(FavUrl)
            Next
        Catch ex As Exception
        End Try
        Try
            For Each FavName As String In File.ReadAllLines(Application.StartupPath & "\FavoritesName.txt")
                Me.ListName.Items.Add(FavName)
            Next
        Catch ex As Exception
        End Try

    End Sub
    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        File.Delete(Application.StartupPath & "\FavoritesName.txt")
        File.Delete(Application.StartupPath & "\FavoritesUrl.txt")
        Me.ListName.Items.Clear()
        Me.ListURL.Items.Clear()
        Me.ListBox3.Items.Clear()
    End Sub
    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        Me.ListName.Items.Clear()
        Me.ListURL.Items.Clear()
        Me.ListBox3.Items.Clear()
    End Sub
    Private Sub ButRemove_Click(sender As Object, e As EventArgs) Handles ButRemove.Click
        Dim index As Integer = ListURL.SelectedIndex
        ListName.SelectedIndex = index
        ListBox3.SelectedIndex = index
        Me.ListName.Items.RemoveAt(index)
        Me.ListURL.Items.RemoveAt(index)
        Me.ListBox3.Items.RemoveAt(index)
    End Sub
    Private Sub ListURL_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListURL.SelectedIndexChanged
        Dim index As Integer = ListURL.SelectedIndex
        Me.ListName.SelectedIndex = index
        'Me.ListURL.SelectedIndex = index
        Me.ListBox3.SelectedIndex = index
    End Sub
    Private Sub ListName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListName.SelectedIndexChanged
        Dim index As Integer = ListName.SelectedIndex
        'Me.ListName.SelectedIndex = index
        Me.ListURL.SelectedIndex = index
        Me.ListBox3.SelectedIndex = index
    End Sub
    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Dim index As Integer = ListBox3.SelectedIndex
        Me.ListName.SelectedIndex = index
        Me.ListURL.SelectedIndex = index
        'Me.ListBox3.SelectedIndex = index
    End Sub
End Class