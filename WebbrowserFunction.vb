Public Class WebbrowserFunction
    Inherits WebBrowser
    Dim FrmWebBrowser As FrmWebBrowser
    Dim FrmHistory As FrmHistory
    Private Sub webBrowserDocComplete() Handles Me.DocumentCompleted
        Dim tabpage As TabPage = Me.Tag
        'set length of tab max
        If Me.DocumentTitle.Length > 25 Then
            tabpage.Text = Me.DocumentTitle.Substring(0, 25)
        Else
            tabpage.Text = Me.DocumentTitle
        End If
        FrmWebBrowser.CmbAddress.Items.Add(Me.Url.ToString)
        If FrmHistory.LBXhistory.Items.Contains(Me.Url.ToString) Then
        Else
            FrmHistory.LBXhistory.Items.Add(Me.Url.ToString)
        End If
        If Not FrmWebBrowser.CmbAddress.Items.Contains(Me.Url.ToString) Then
            FrmWebBrowser.CmbAddress.Items.Add(Me.Url.ToString)
        End If
    End Sub
    Public Sub New()
        Me.ScriptErrorsSuppressed = True
    End Sub
End Class