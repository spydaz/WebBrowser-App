<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmWebBrowser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmWebBrowser))
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddFavoriteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarControls = New System.Windows.Forms.ToolStrip()
        Me.ButHome = New System.Windows.Forms.ToolStripButton()
        Me.ButBack = New System.Windows.Forms.ToolStripButton()
        Me.ButForward = New System.Windows.Forms.ToolStripButton()
        Me.CmbAddress = New System.Windows.Forms.ToolStripComboBox()
        Me.ButRefresh = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.CmbSearchEngine = New System.Windows.Forms.ToolStripComboBox()
        Me.TxtSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.ButSearch = New System.Windows.Forms.ToolStripButton()
        Me.ButVolDown = New System.Windows.Forms.ToolStripButton()
        Me.ButVolUp = New System.Windows.Forms.ToolStripButton()
        Me.LblTime = New System.Windows.Forms.ToolStripLabel()
        Me.LblDate = New System.Windows.Forms.ToolStripLabel()
        Me.TabWebBrowsers = New System.Windows.Forms.TabControl()
        Me.WebIconsList = New System.Windows.Forms.ImageList(Me.components)
        Me.MyClock = New System.Windows.Forms.Timer(Me.components)
        Me.BookmarksBar = New System.Windows.Forms.ToolStrip()
        Me.ButLinkGrabber = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButEmail = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButFacebook = New System.Windows.Forms.ToolStripButton()
        Me.BookmarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManageBookmarksMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TheMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintPreviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SavePageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebTracerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItemCustomize = New System.Windows.Forms.ToolStripMenuItem()
        Me.PriVateWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarControls.SuspendLayout()
        Me.BookmarksBar.SuspendLayout()
        Me.TheMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'AddFavoriteToolStripMenuItem
        '
        Me.AddFavoriteToolStripMenuItem.Name = "AddFavoriteToolStripMenuItem"
        Me.AddFavoriteToolStripMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.AddFavoriteToolStripMenuItem.Text = "Add Favorite"
        '
        'ToolBarControls
        '
        Me.ToolBarControls.AutoSize = False
        Me.ToolBarControls.BackColor = System.Drawing.Color.White
        Me.ToolBarControls.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolBarControls.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButHome, Me.ButBack, Me.ButForward, Me.CmbAddress, Me.ButRefresh, Me.ToolStripSeparator5, Me.CmbSearchEngine, Me.TxtSearch, Me.ButSearch, Me.ButVolDown, Me.ButVolUp, Me.LblTime, Me.LblDate})
        Me.ToolBarControls.Location = New System.Drawing.Point(0, 77)
        Me.ToolBarControls.Name = "ToolBarControls"
        Me.ToolBarControls.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolBarControls.Size = New System.Drawing.Size(1026, 39)
        Me.ToolBarControls.TabIndex = 8
        Me.ToolBarControls.Text = "ToolStrip1"
        '
        'ButHome
        '
        Me.ButHome.AutoSize = False
        Me.ButHome.BackColor = System.Drawing.Color.White
        Me.ButHome.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._082302_green_jelly_icon_business_home21
        Me.ButHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButHome.Name = "ButHome"
        Me.ButHome.Size = New System.Drawing.Size(60, 40)
        Me.ButHome.Text = "Home"
        '
        'ButBack
        '
        Me.ButBack.AutoSize = False
        Me.ButBack.BackColor = System.Drawing.Color.White
        Me.ButBack.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources.Alarm_Arrow_Left_icon
        Me.ButBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButBack.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButBack.Name = "ButBack"
        Me.ButBack.Size = New System.Drawing.Size(60, 40)
        Me.ButBack.Text = "Back"
        Me.ButBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ButForward
        '
        Me.ButForward.AutoSize = False
        Me.ButForward.BackColor = System.Drawing.Color.White
        Me.ButForward.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources.Arrow_Right
        Me.ButForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButForward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButForward.Name = "ButForward"
        Me.ButForward.Size = New System.Drawing.Size(60, 40)
        Me.ButForward.Text = "Forward"
        '
        'CmbAddress
        '
        Me.CmbAddress.AutoSize = False
        Me.CmbAddress.BackColor = System.Drawing.SystemColors.Info
        Me.CmbAddress.Name = "CmbAddress"
        Me.CmbAddress.Size = New System.Drawing.Size(300, 23)
        '
        'ButRefresh
        '
        Me.ButRefresh.AutoSize = False
        Me.ButRefresh.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources.refresh
        Me.ButRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButRefresh.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButRefresh.Name = "ButRefresh"
        Me.ButRefresh.Size = New System.Drawing.Size(60, 40)
        Me.ButRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 39)
        '
        'CmbSearchEngine
        '
        Me.CmbSearchEngine.AutoSize = False
        Me.CmbSearchEngine.BackColor = System.Drawing.SystemColors.Info
        Me.CmbSearchEngine.Items.AddRange(New Object() {"Google", "Bing", "Wikipedia", "AOL", "YouTube", "GoogleMaps"})
        Me.CmbSearchEngine.Name = "CmbSearchEngine"
        Me.CmbSearchEngine.Size = New System.Drawing.Size(100, 23)
        '
        'TxtSearch
        '
        Me.TxtSearch.AutoSize = False
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(120, 63)
        '
        'ButSearch
        '
        Me.ButSearch.AutoSize = False
        Me.ButSearch.BackColor = System.Drawing.Color.White
        Me.ButSearch.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._086087_retro_green_floral_icon_business_magnifying_glass_ps
        Me.ButSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButSearch.Name = "ButSearch"
        Me.ButSearch.Size = New System.Drawing.Size(60, 40)
        Me.ButSearch.Text = "Search"
        '
        'ButVolDown
        '
        Me.ButVolDown.AutoSize = False
        Me.ButVolDown.BackColor = System.Drawing.Color.White
        Me.ButVolDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ButVolDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButVolDown.ForeColor = System.Drawing.Color.Black
        Me.ButVolDown.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ButVolDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButVolDown.Name = "ButVolDown"
        Me.ButVolDown.Size = New System.Drawing.Size(43, 36)
        Me.ButVolDown.Text = "Down"
        Me.ButVolDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ButVolUp
        '
        Me.ButVolUp.BackColor = System.Drawing.Color.White
        Me.ButVolUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ButVolUp.ForeColor = System.Drawing.Color.Black
        Me.ButVolUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButVolUp.Name = "ButVolUp"
        Me.ButVolUp.Size = New System.Drawing.Size(26, 36)
        Me.ButVolUp.Text = "Up"
        Me.ButVolUp.ToolTipText = "VolUp"
        '
        'LblTime
        '
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(0, 36)
        Me.LblTime.ToolTipText = "Daste/Time"
        '
        'LblDate
        '
        Me.LblDate.ForeColor = System.Drawing.Color.Black
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(63, 36)
        Me.LblDate.Text = "Date/Time"
        '
        'TabWebBrowsers
        '
        Me.TabWebBrowsers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabWebBrowsers.ImageList = Me.WebIconsList
        Me.TabWebBrowsers.Location = New System.Drawing.Point(0, 141)
        Me.TabWebBrowsers.Name = "TabWebBrowsers"
        Me.TabWebBrowsers.SelectedIndex = 0
        Me.TabWebBrowsers.Size = New System.Drawing.Size(1026, 397)
        Me.TabWebBrowsers.TabIndex = 9
        '
        'WebIconsList
        '
        Me.WebIconsList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.WebIconsList.ImageSize = New System.Drawing.Size(16, 16)
        Me.WebIconsList.TransparentColor = System.Drawing.Color.Transparent
        '
        'MyClock
        '
        '
        'BookmarksBar
        '
        Me.BookmarksBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BookmarksBar.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.BookmarksBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.BookmarksBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ButLinkGrabber, Me.ToolStripButEmail, Me.ToolStripButFacebook})
        Me.BookmarksBar.Location = New System.Drawing.Point(0, 24)
        Me.BookmarksBar.Name = "BookmarksBar"
        Me.BookmarksBar.Size = New System.Drawing.Size(1026, 53)
        Me.BookmarksBar.TabIndex = 10
        Me.BookmarksBar.Text = "ToolStrip1"
        '
        'ButLinkGrabber
        '
        Me.ButLinkGrabber.AutoSize = False
        Me.ButLinkGrabber.BackColor = System.Drawing.Color.Transparent
        Me.ButLinkGrabber.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._086087_retro_green_floral_icon_business_magnifying_glass_ps
        Me.ButLinkGrabber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ButLinkGrabber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ButLinkGrabber.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ButLinkGrabber.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ButLinkGrabber.Name = "ButLinkGrabber"
        Me.ButLinkGrabber.Size = New System.Drawing.Size(50, 50)
        Me.ButLinkGrabber.Text = "ToolStripButton1"
        Me.ButLinkGrabber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButLinkGrabber.ToolTipText = "Grab Links"
        '
        'ToolStripButEmail
        '
        Me.ToolStripButEmail.AutoSize = False
        Me.ToolStripButEmail.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButEmail.BackgroundImage = CType(resources.GetObject("ToolStripButEmail.BackgroundImage"), System.Drawing.Image)
        Me.ToolStripButEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ToolStripButEmail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButEmail.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButEmail.Name = "ToolStripButEmail"
        Me.ToolStripButEmail.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButEmail.Text = "Email"
        '
        'ToolStripButFacebook
        '
        Me.ToolStripButFacebook.AutoSize = False
        Me.ToolStripButFacebook.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButFacebook.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources.facebook
        Me.ToolStripButFacebook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStripButFacebook.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButFacebook.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButFacebook.Name = "ToolStripButFacebook"
        Me.ToolStripButFacebook.Size = New System.Drawing.Size(50, 50)
        Me.ToolStripButFacebook.Text = "ToolStripButton1"
        Me.ToolStripButFacebook.ToolTipText = "Facebook"
        '
        'BookmarksToolStripMenuItem
        '
        Me.BookmarksToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddFavoriteToolStripMenuItem, Me.ManageBookmarksMenuItem})
        Me.BookmarksToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.BookmarksToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BookmarksToolStripMenuItem.Name = "BookmarksToolStripMenuItem"
        Me.BookmarksToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.BookmarksToolStripMenuItem.Text = "Bookmarks"
        '
        'ManageBookmarksMenuItem
        '
        Me.ManageBookmarksMenuItem.Name = "ManageBookmarksMenuItem"
        Me.ManageBookmarksMenuItem.Size = New System.Drawing.Size(204, 22)
        Me.ManageBookmarksMenuItem.Text = "Manage Favorites"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'TheMenu
        '
        Me.TheMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.TheMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem16, Me.HistoryToolStripMenuItem, Me.BookmarksToolStripMenuItem})
        Me.TheMenu.Location = New System.Drawing.Point(0, 0)
        Me.TheMenu.Name = "TheMenu"
        Me.TheMenu.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.TheMenu.Size = New System.Drawing.Size(1026, 24)
        Me.TheMenu.TabIndex = 7
        Me.TheMenu.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.toolStripSeparator, Me.toolStripSeparator1, Me.PrintToolStripMenuItem, Me.PrintPreviewToolStripMenuItem, Me.toolStripSeparator2, Me.ExitToolStripMenuItem, Me.SavePageToolStripMenuItem, Me.ViewSourceToolStripMenuItem, Me.WebTracerToolStripMenuItem})
        Me.FileToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewTabToolStripMenuItem, Me.NewWindowToolStripMenuItem})
        Me.OpenToolStripMenuItem.Image = CType(resources.GetObject("OpenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'NewTabToolStripMenuItem
        '
        Me.NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        Me.NewTabToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewTabToolStripMenuItem.Text = "New &Tab"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.NewWindowToolStripMenuItem.Text = "New &Window"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Image = CType(resources.GetObject("PrintToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintToolStripMenuItem.Text = "&Print"
        '
        'PrintPreviewToolStripMenuItem
        '
        Me.PrintPreviewToolStripMenuItem.Image = CType(resources.GetObject("PrintPreviewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PrintPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintPreviewToolStripMenuItem.Name = "PrintPreviewToolStripMenuItem"
        Me.PrintPreviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.PrintPreviewToolStripMenuItem.Text = "Print Pre&view"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'SavePageToolStripMenuItem
        '
        Me.SavePageToolStripMenuItem.Name = "SavePageToolStripMenuItem"
        Me.SavePageToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SavePageToolStripMenuItem.Text = "Save Page"
        '
        'ViewSourceToolStripMenuItem
        '
        Me.ViewSourceToolStripMenuItem.Name = "ViewSourceToolStripMenuItem"
        Me.ViewSourceToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ViewSourceToolStripMenuItem.Text = "View Source"
        '
        'WebTracerToolStripMenuItem
        '
        Me.WebTracerToolStripMenuItem.Name = "WebTracerToolStripMenuItem"
        Me.WebTracerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WebTracerToolStripMenuItem.Text = "Web Tracer"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemCustomize, Me.PriVateWindowToolStripMenuItem})
        Me.ToolStripMenuItem16.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripMenuItem16.ForeColor = System.Drawing.Color.Black
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(148, 20)
        Me.ToolStripMenuItem16.Text = "&Advanced Options"
        '
        'MenuItemCustomize
        '
        Me.MenuItemCustomize.Name = "MenuItemCustomize"
        Me.MenuItemCustomize.Size = New System.Drawing.Size(268, 22)
        Me.MenuItemCustomize.Text = "&Customize"
        '
        'PriVateWindowToolStripMenuItem
        '
        Me.PriVateWindowToolStripMenuItem.CheckOnClick = True
        Me.PriVateWindowToolStripMenuItem.Name = "PriVateWindowToolStripMenuItem"
        Me.PriVateWindowToolStripMenuItem.Size = New System.Drawing.Size(268, 22)
        Me.PriVateWindowToolStripMenuItem.Text = "Pri&vate Browsing Enabled"
        '
        'HistoryToolStripMenuItem
        '
        Me.HistoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeleteToolStripMenuItem, Me.ClearToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.HistoryToolStripMenuItem.Font = New System.Drawing.Font("Courier New", 10.0!, System.Drawing.FontStyle.Bold)
        Me.HistoryToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HistoryToolStripMenuItem.Name = "HistoryToolStripMenuItem"
        Me.HistoryToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.HistoryToolStripMenuItem.Text = "History"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'FrmWebBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WebBrowser_App.My.Resources.Resources._101403035_620x250
        Me.ClientSize = New System.Drawing.Size(1026, 538)
        Me.Controls.Add(Me.ToolBarControls)
        Me.Controls.Add(Me.TabWebBrowsers)
        Me.Controls.Add(Me.BookmarksBar)
        Me.Controls.Add(Me.TheMenu)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmWebBrowser"
        Me.Text = "Spydaz Web Browser"
        Me.ToolBarControls.ResumeLayout(False)
        Me.ToolBarControls.PerformLayout()
        Me.BookmarksBar.ResumeLayout(False)
        Me.BookmarksBar.PerformLayout()
        Me.TheMenu.ResumeLayout(False)
        Me.TheMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddFavoriteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarControls As System.Windows.Forms.ToolStrip
    Friend WithEvents ButHome As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButBack As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButForward As System.Windows.Forms.ToolStripButton
    Friend WithEvents CmbAddress As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ButRefresh As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CmbSearchEngine As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TxtSearch As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ButSearch As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButVolDown As System.Windows.Forms.ToolStripButton
    Friend WithEvents ButVolUp As System.Windows.Forms.ToolStripButton
    Friend WithEvents LblTime As System.Windows.Forms.ToolStripLabel
    Friend WithEvents LblDate As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabWebBrowsers As System.Windows.Forms.TabControl
    Friend WithEvents WebIconsList As System.Windows.Forms.ImageList
    Friend WithEvents MyClock As System.Windows.Forms.Timer
    Friend WithEvents BookmarksBar As System.Windows.Forms.ToolStrip
    Friend WithEvents BookmarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TheMenu As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintPreviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SavePageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItemCustomize As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PriVateWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ManageBookmarksMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ButLinkGrabber As System.Windows.Forms.ToolStripButton
    Friend WithEvents WebTracerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripButEmail As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButFacebook As System.Windows.Forms.ToolStripButton

End Class
