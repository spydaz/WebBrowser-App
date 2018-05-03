Imports System.Net
Imports System.IO
Imports System.Text

Public Class FrmWebBrowser
    Dim FrEmail As FrmEmail
    Dim FrTraceTool As New FrmTraceTool
    Dim FrPropertys As New FrmPropertys
    Dim FrBookmarks As New FrmBookmarks
    Dim _imgHitArea As Point = New Point(13, 2)
    Dim _imageLocation As Point = New Point(15, 5)
    Dim FrHistory As New FrmHistory
    Dim SearchTextAol As String = "http://search.aol.co.uk/aol/search?s_chn=hp&enabled_terms=&s_it=aoluk-homePage50&q="
    Dim SearchTextGoogle As String = "https://www.google.co.uk/webhp?sourceid=chrome-instant&ion=1&espv=2&es_th=1&ie=UTF-8#q="
    Dim SearchTextBing As String = "http://www.bing.com/search?q=cat&go=Submit&qs=n&form=QBLH&pq="
    Dim Searchwikipedia As String = "http://en.wikipedia.org/w/index.php?title=Special%3ASearch&profile=default&search="
    Dim SearchYoutube As String = "https://www.youtube.com/results?search_query="
    Dim SearchGoogleMaps As String = "https://www.google.co.uk/maps/place/"
    'vol control
    Private Declare Sub keybd_event Lib "user32" (ByVal voulmeUp As Byte, ByVal v1 As Byte, ByVal v2 As Integer, ByVal v3 As Integer)
    Private Sub ButVolDown_Click(sender As Object, e As EventArgs) Handles ButVolDown.Click
        Call keybd_event(System.Windows.Forms.Keys.VolumeDown, 0, 0, 0)
    End Sub
    Private Sub ButVolUp_Click(sender As Object, e As EventArgs) Handles ButVolUp.Click
        Call keybd_event(System.Windows.Forms.Keys.VolumeUp, 0, 0, 0)
    End Sub
    'AutoComplete
    Private Sub Autocomplete()
        CmbAddress.AutoCompleteCustomSource.Clear()
        For i As Integer = 0 To FrHistory.LBXhistory.Items.Count - 1
            CmbAddress.AutoCompleteCustomSource.Add(FrHistory.LBXhistory.Items(i))
        Next
    End Sub
    'Propertys
    Private Sub GetStartUpPropertys()
        Select Case My.Settings.Startup
            Case "Go to Home Page"
                Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
                SwBrowser.Navigate(My.Settings.HomePage)
            Case "Open a Blank Tab"
            Case "Open System Home Page"
                Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
                SwBrowser.GoHome()
        End Select
    End Sub

    'WebLinksGraber
    Private Sub GrabLinks()
        Dim frmGrabber As New WebLinksGrabber
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        Dim links As HtmlElementCollection = SwBrowser.Document.Links
        ' Dim images As HtmlElementCollection = SwBrowser.Document.Images
        frmGrabber.Show()
        For Each link As HtmlElement In links
            frmGrabber.ListBox1.Items.Add(link.GetAttribute("href"))
            ' frmGrabber.Visible = False
        Next
    End Sub

    'Favorites
    Private Sub AddBookmark()
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        Dim NewBookmark As New ToolStripButton
        NewBookmark.Text = TabWebBrowsers.SelectedTab.Text
        NewBookmark.Tag = SwBrowser.Url
        BookmarksBar.Items.Add(NewBookmark)
        BookmarksBar.Refresh()
        FrBookmarks.ListName.Items.Add(TabWebBrowsers.SelectedTab.Text)
        FrBookmarks.ListURL.Items.Add(SwBrowser.Url.ToString)
        AddHandler NewBookmark.Click, AddressOf BookmarkClick
    End Sub
    Private Sub BookmarkClick(sender As Object, e As EventArgs)
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        If TypeOf sender Is ToolStripButton Then
            CmbAddress.Text = CType(sender, ToolStripButton).Tag.ToString
            SwBrowser.Navigate(CType(sender, ToolStripButton).Tag)
        End If
    End Sub
    Public Sub SaveFavorites()
        For Each favoritename As String In FrBookmarks.ListName.Items
            File.AppendAllText(Application.StartupPath & "\FavoritesName.txt", favoritename & vbCrLf)
        Next
        For Each favoriteURL As String In FrBookmarks.ListURL.Items
            File.AppendAllText(Application.StartupPath & "\FavoritesUrl.txt", favoriteURL & vbCrLf)
        Next
    End Sub
    Public Sub getFavorites()
        Try
            For Each FavUrl As String In File.ReadAllLines(Application.StartupPath & "\FavoritesUrl.txt")
                FrBookmarks.ListBox3.Items.Add(FavUrl)
            Next
        Catch ex As Exception
        End Try
        Try
            FrBookmarks.ListBox3.SelectedIndex = 0
        Catch ex As Exception
        End Try
        'addnames
        Try
            For Each FavName As String In File.ReadAllLines(Application.StartupPath & "\FavoritesName.txt")
                Dim NewBookmark As New ToolStripButton
                NewBookmark.Text = FavName
                NewBookmark.Tag = FrBookmarks.ListBox3.SelectedItem.ToString
                BookmarksBar.Items.Add(NewBookmark)
                FrBookmarks.ListBox3.SelectedIndex += 1
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub CreatedBookClick()
        For Each item As ToolStripButton In BookmarksBar.Items
            AddHandler item.Click, AddressOf BookClick
        Next
    End Sub
    Private Sub BookClick(sender As Object, e As EventArgs)
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        If TypeOf sender Is ToolStripButton Then
            CmbAddress.Text = CType(sender, ToolStripButton).Tag
            SwBrowser.Navigate(CType(sender, ToolStripButton).Tag)
        End If

    End Sub

    'history
    Private Sub SaveHistory()
        If My.Settings.History = True Then
            File.Delete(Application.StartupPath & "\history.txt")
            For Each UrlLink As String In FrHistory.LBXhistory.Items
                File.AppendAllText(Application.StartupPath & "\history.txt", UrlLink & vbCrLf)
            Next
        Else
        End If
    End Sub
    Private Sub Loadhistory()
        Try
            For Each URLLink As String In File.ReadAllLines(Application.StartupPath & "\history.txt")
                FrHistory.LBXhistory.Items.Add(URLLink)
                Me.CmbAddress.Items.Add(URLLink)

            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub GetWebIcons()
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        Dim WClient As New WebClient

        Dim MStream As New MemoryStream(WClient.DownloadData("http://" & New Uri(SwBrowser.Url.ToString).Host & "/favicon.ico"))

        Try
            Dim icon As New Icon(MStream)
            If WebIconsList.Images.Count = -1 Then
                WebIconsList.Images.Add(icon.ToBitmap)
                TabWebBrowsers.SelectedTab.ImageIndex = 0
            Else
                WebIconsList.Images.Clear()
                WebIconsList.Images.Add(icon.ToBitmap)
                TabWebBrowsers.SelectedTab.ImageIndex = 0
            End If
        Catch ex As Exception
            'no icon found
        End Try
    End Sub
    'time
    Private Sub MyClock_Tick(sender As Object, e As EventArgs) Handles MyClock.Tick
        LblDate.Text = Now
    End Sub
    'tabs
    Public Sub AddTab(ByRef tabcontrol As TabControl)
        Dim SwBrowser As New WebbrowserFunction
        Dim tab As New TabPage
        SwBrowser.Tag = tab
        tab.Tag = SwBrowser
        TabWebBrowsers.TabPages.Add(tab)
        tab.Controls.Add(SwBrowser)
        SwBrowser.Dock = DockStyle.Fill
        SwBrowser.GoHome()
        TabWebBrowsers.SelectedTab = tab
    End Sub
    Public Sub Removetab()
        If TabWebBrowsers.TabPages.Count <> 0 Then
            TabWebBrowsers.TabPages.Remove(TabWebBrowsers.SelectedTab)
        End If
    End Sub
    'SourceEdit
    Public Sub OpenSource(ByVal _source As String)
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.DocumentText = _source
    End Sub
    Private Sub EditSource()
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        Dim source As String = SwBrowser.DocumentText
        Dim HtmlEdit As New FrmHtmlViewer
        HtmlEdit.Show()
        HtmlEdit.RichTextBox1.Text = source
    End Sub

    'Form Load/Close/ Exit
    Private Sub FrmWebBrowser_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveHistory()
        SaveFavorites()

        Me.Dispose()
    End Sub
    Private Sub FrmWebBrowser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        SaveHistory()
        SaveFavorites()
    End Sub
    Private Sub FrmWebBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyClock.Start()
        Loadhistory()
        CmbSearchEngine.SelectedIndex = 0
        AddTab(TabWebBrowsers)
        GetStartUpPropertys()
        getFavorites()
        ' GetWebIcons()
    End Sub

    'keypresses
    Private Sub TxtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSearch.KeyPress
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Dim engine As String = CmbSearchEngine.Text
            Select Case engine
                Case "Google"
                    SwBrowser.Navigate(SearchTextGoogle & TxtSearch.Text)
                Case "AOL"
                    SwBrowser.Navigate(SearchTextAol & TxtSearch.Text)
                Case "Bing"
                    SwBrowser.Navigate(SearchTextBing & TxtSearch.Text)
                Case "Wikipedia"
                    SwBrowser.Navigate(Searchwikipedia & TxtSearch.Text & "&fulltext=Search")
                Case "YouTube"
                    SwBrowser.Navigate(SearchYoutube & TxtSearch.Text)
                Case "GoogleMaps"
                    SwBrowser.Navigate(SearchGoogleMaps & TxtSearch.Text)
                Case Else
                    SwBrowser.Navigate(SearchTextGoogle & TxtSearch.Text)
            End Select
        End If
    End Sub
    Private Sub CmbAddress_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CmbAddress.KeyPress
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            SwBrowser.Navigate(CmbAddress.Text)
        End If
    End Sub
    'buttons
    Private Sub ButHome_Click(sender As Object, e As EventArgs) Handles ButHome.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.Navigate(My.Settings.HomePage)
    End Sub
    Private Sub ButBack_Click(sender As Object, e As EventArgs) Handles ButBack.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.GoBack()
    End Sub
    Private Sub ButForward_Click(sender As Object, e As EventArgs) Handles ButForward.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.GoForward()
    End Sub
    Private Sub ButRefresh_Click(sender As Object, e As EventArgs) Handles ButRefresh.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.Refresh()
    End Sub
    Private Sub ButSearch_Click(sender As Object, e As EventArgs) Handles ButSearch.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.GoSearch()
    End Sub
    'menustrips
    'history tab
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        File.Delete(Application.StartupPath & "\history.txt")
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        FrHistory.LBXhistory.Items.Clear()
    End Sub
    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        FrHistory.Show()
    End Sub
    'file tab
    Private Sub NewWindowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewWindowToolStripMenuItem.Click
        Dim SWBrows As New FrmWebBrowser
        SWBrows.Show()

    End Sub
    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        AddTab(TabWebBrowsers)
    End Sub
    Private Sub SavePageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SavePageToolStripMenuItem.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        Dim filename As String = InputBox("Enter Filename :", "Save page", SwBrowser.DocumentTitle & ".TXT")
        Dim path As String = Application.StartupPath & "\" & filename
        Try
            If File.Exists(path) = True Then File.Create(path).Dispose()
            Dim alltext As String = SwBrowser.DocumentText
            File.WriteAllText(path, alltext)
        Catch ex As Exception
        End Try
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
    'source edit
    Private Sub ViewSourceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewSourceToolStripMenuItem.Click
        EditSource()
    End Sub
    'Advanced Options tab
    Private Sub MenuItemCustomize_Click(sender As Object, e As EventArgs) Handles MenuItemCustomize.Click
        FrPropertys.Show()
    End Sub
    'Bookmark Tab
    Private Sub AddFavoriteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddFavoriteToolStripMenuItem.Click
        AddBookmark()
    End Sub
    Private Sub ManageBookmarksMenuItem_Click(sender As Object, e As EventArgs) Handles ManageBookmarksMenuItem.Click
        FrBookmarks.Show()
    End Sub

    Private Sub ButLinkGrabber_Click(sender As Object, e As EventArgs) Handles ButLinkGrabber.Click
        GrabLinks()
    End Sub

    Private Sub WebTracerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebTracerToolStripMenuItem.Click
        FrTraceTool.Show()
    End Sub

    Private Sub ToolStripButEmail_Click(sender As Object, e As EventArgs) Handles ToolStripButEmail.Click
        FrEmail.Show()
    End Sub

    Private Sub ToolStripButFacebook_Click(sender As Object, e As EventArgs) Handles ToolStripButFacebook.Click
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.Navigate("www.facebook.com")
    End Sub
    Public Sub GoUrl(ByRef Url As String)
        Dim SwBrowser As WebbrowserFunction = Me.TabWebBrowsers.SelectedTab.Tag
        SwBrowser.Navigate(Url)
    End Sub

    Public Sub New()
        InitializeComponent()

        'Set the Mode of Drawing as Owner Drawn
        TabWebBrowsers.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed

        'Add the Handler to draw the Image on Tab Pages
        AddHandler TabWebBrowsers.DrawItem, AddressOf TabWebBrowsers_DrawItem
    End Sub

    Private Sub TabWebBrowsers_DrawItem(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawItemEventArgs)
        Try
            'Close Image to draw
            Dim img As Image = New Bitmap(My.Resources.close)
            Dim r As Rectangle = e.Bounds

            r = Me.TabWebBrowsers.GetTabRect(e.Index)
            r.Offset(2, 2)
            Dim TitleBrush As Brush = New SolidBrush(Color.Black)
            Dim f As Font = Me.Font
            Dim title As String = Me.TabWebBrowsers.TabPages(e.Index).Text
            e.Graphics.DrawString(title, f, TitleBrush, New PointF(r.X, r.Y))
            e.Graphics.DrawImage(img, New Point(r.X + (Me.TabWebBrowsers.GetTabRect(e.Index).Width - _imageLocation.X), _imageLocation.Y))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TabWebBrowsers_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TabWebBrowsers.MouseClick
        Dim tc As TabControl = CType(sender, TabControl)
        Dim p As Point = e.Location
        Dim _tabWidth As Integer

        _tabWidth = Me.TabWebBrowsers.GetTabRect(tc.SelectedIndex).Width - (_imgHitArea.X)
        Dim r As Rectangle = Me.TabWebBrowsers.GetTabRect(tc.SelectedIndex)
        r.Offset(_tabWidth, _imgHitArea.Y)
        r.Width = 16
        r.Height = 16
        If r.Contains(p) Then
            Dim TabP As TabPage = DirectCast(tc.TabPages.Item(tc.SelectedIndex), TabPage)
            tc.TabPages.Remove(TabP)
        End If
    End Sub
End Class
Public Class GoogleMaps
    'Dataquery is to be returned to sender for use in a WebBrowser
    Private street As String = ""
    Private City As String = ""
    Private State As String = ""
    Private Zip As String = ""
    Public Query As String
    Private GoogleQuery As New StringBuilder

    Public Sub New(_street As String, _city As String, _State As String, _Zip As String)
        GoogleQuery.Append("Http://maps.google.com/maps?q=")
        Try
            If _street <> "" Then GoogleQuery.Append(_street + "," & "+")
            If _street <> "" Then GoogleQuery.Append(_city + "," & "+")
            If _street <> "" Then GoogleQuery.Append(_State + "," & "+")
            If _street <> "" Then GoogleQuery.Append(_Zip + "," & "+")
            Query = GoogleQuery.ToString
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

End Class