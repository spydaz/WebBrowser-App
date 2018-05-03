Imports System.IO
Public Class FrmPropertys

    Private Sub UpdatePropertys()
        My.Settings.HomePage = txtHomepage.Text
        ' My.Settings.Startup = CmbStartUp.Text

        My.Settings.Save()
        My.Settings.Reload()
    End Sub

    Private Sub FrmPropertys_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        UpdatePropertys()
    End Sub

    Private Sub RbRememberHistory_CheckedChanged(sender As Object, e As EventArgs)
        My.Settings.History = cbRememberHistory.Checked
    End Sub

    Private Sub ButDeleteHistory_Click(sender As Object, e As EventArgs) Handles ButDeleteHistory.Click
        File.Delete(Application.StartupPath & "\history.txt")
    End Sub

End Class