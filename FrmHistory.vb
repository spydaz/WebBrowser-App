Imports System.IO

Public Class FrmHistory

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        LBXhistory.Items.Clear()
    End Sub

    Private Sub ButExit_Click(sender As Object, e As EventArgs) Handles ButExit.Click
        Me.Hide()
    End Sub

    Private Sub ButDelete_Click(sender As Object, e As EventArgs) Handles ButDelete.Click
        LBXhistory.Items.Clear()
        File.Delete(Application.StartupPath & "\history.txt")
    End Sub

    Private Sub ButRemove_Click(sender As Object, e As EventArgs) Handles ButRemove.Click
        LBXhistory.Items.Remove(LBXhistory.SelectedItem)
    End Sub
End Class