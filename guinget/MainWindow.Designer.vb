﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class aaformMainWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaformMainWindow))
        Me.menustripMainWindow = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerifyManifestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerMainWindow = New System.Windows.Forms.SplitContainer()
        Me.panelPackageListHolder = New System.Windows.Forms.Panel()
        Me.datagridviewPackageList = New System.Windows.Forms.DataGridView()
        Me.PkgAction = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PkgStatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FriendlyName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AvailableVersion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PkgDescription = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Manifest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contextmenustripPackageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoNothingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.labelUpdatingPackageList = New System.Windows.Forms.Label()
        Me.textboxPackageDetails = New System.Windows.Forms.TextBox()
        Me.panelMainPkgArea = New System.Windows.Forms.Panel()
        Me.toolstripMainWindow = New System.Windows.Forms.ToolStrip()
        Me.toolstripbuttonRefreshCache = New System.Windows.Forms.ToolStripButton()
        Me.toolstripbuttonApplyChanges = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstripbuttonProperties = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.toolstriptextboxSearch = New System.Windows.Forms.ToolStripTextBox()
        Me.toolstripsplitbuttonSearch = New System.Windows.Forms.ToolStripSplitButton()
        Me.toolstripmenuitemAdvancedSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.splitcontainerSidebarAndPkgList = New System.Windows.Forms.SplitContainer()
        Me.panelSidebarHolder = New System.Windows.Forms.Panel()
        Me.tabcontrolSidebar = New System.Windows.Forms.TabControl()
        Me.tabpageSearchTerms = New System.Windows.Forms.TabPage()
        Me.listboxSearchTerms = New System.Windows.Forms.ListBox()
        Me.contextmenuSearchTerm = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ClearSelectedSearchTermToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearAllSearchTermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabpageStatus = New System.Windows.Forms.TabPage()
        Me.listboxStatusTab = New System.Windows.Forms.ListBox()
        Me.tabpageCustomFilters = New System.Windows.Forms.TabPage()
        Me.listboxCustomFilters = New System.Windows.Forms.ListBox()
        Me.tabpageSections = New System.Windows.Forms.TabPage()
        Me.listboxSections = New System.Windows.Forms.ListBox()
        Me.tabpageSource = New System.Windows.Forms.TabPage()
        Me.listboxSourceTab = New System.Windows.Forms.ListBox()
        Me.tabpageArchitecture = New System.Windows.Forms.TabPage()
        Me.listboxArchitecture = New System.Windows.Forms.ListBox()
        Me.panelMainForm = New System.Windows.Forms.Panel()
        Me.statusbarMainWindow = New System.Windows.Forms.StatusStrip()
        Me.toolstripstatuslabelPackageCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripstatusSplitter = New System.Windows.Forms.ToolStripStatusLabel()
        Me.toolstripprogressbarLoadingPackages = New System.Windows.Forms.ToolStripProgressBar()
        Me.toolstripstatuslabelLoadingPackageCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.menustripMainWindow.SuspendLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerMainWindow.Panel1.SuspendLayout()
        Me.splitcontainerMainWindow.Panel2.SuspendLayout()
        Me.splitcontainerMainWindow.SuspendLayout()
        Me.panelPackageListHolder.SuspendLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.contextmenustripPackageMenu.SuspendLayout()
        Me.panelMainPkgArea.SuspendLayout()
        Me.toolstripMainWindow.SuspendLayout()
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitcontainerSidebarAndPkgList.Panel1.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.Panel2.SuspendLayout()
        Me.splitcontainerSidebarAndPkgList.SuspendLayout()
        Me.panelSidebarHolder.SuspendLayout()
        Me.tabcontrolSidebar.SuspendLayout()
        Me.tabpageSearchTerms.SuspendLayout()
        Me.contextmenuSearchTerm.SuspendLayout()
        Me.tabpageStatus.SuspendLayout()
        Me.tabpageCustomFilters.SuspendLayout()
        Me.tabpageSections.SuspendLayout()
        Me.tabpageSource.SuspendLayout()
        Me.tabpageArchitecture.SuspendLayout()
        Me.panelMainForm.SuspendLayout()
        Me.statusbarMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'menustripMainWindow
        '
        Me.menustripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.menustripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menustripMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.menustripMainWindow.Name = "menustripMainWindow"
        Me.menustripMainWindow.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.menustripMainWindow.Size = New System.Drawing.Size(794, 24)
        Me.menustripMainWindow.TabIndex = 0
        Me.menustripMainWindow.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(93, 22)
        Me.ExitToolStripMenuItem.Text = "&Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerifyManifestToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.ToolsToolStripMenuItem.Text = "&Tools"
        '
        'VerifyManifestToolStripMenuItem
        '
        Me.VerifyManifestToolStripMenuItem.Name = "VerifyManifestToolStripMenuItem"
        Me.VerifyManifestToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerifyManifestToolStripMenuItem.Text = "&Verify manifest"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'splitcontainerMainWindow
        '
        Me.splitcontainerMainWindow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerMainWindow.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerMainWindow.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.splitcontainerMainWindow.Name = "splitcontainerMainWindow"
        Me.splitcontainerMainWindow.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'splitcontainerMainWindow.Panel1
        '
        Me.splitcontainerMainWindow.Panel1.Controls.Add(Me.panelPackageListHolder)
        '
        'splitcontainerMainWindow.Panel2
        '
        Me.splitcontainerMainWindow.Panel2.Controls.Add(Me.textboxPackageDetails)
        Me.splitcontainerMainWindow.Size = New System.Drawing.Size(554, 428)
        Me.splitcontainerMainWindow.SplitterDistance = 270
        Me.splitcontainerMainWindow.SplitterWidth = 3
        Me.splitcontainerMainWindow.TabIndex = 1
        '
        'panelPackageListHolder
        '
        Me.panelPackageListHolder.Controls.Add(Me.datagridviewPackageList)
        Me.panelPackageListHolder.Controls.Add(Me.labelUpdatingPackageList)
        Me.panelPackageListHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelPackageListHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelPackageListHolder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelPackageListHolder.Name = "panelPackageListHolder"
        Me.panelPackageListHolder.Size = New System.Drawing.Size(554, 270)
        Me.panelPackageListHolder.TabIndex = 2
        '
        'datagridviewPackageList
        '
        Me.datagridviewPackageList.AllowUserToAddRows = False
        Me.datagridviewPackageList.AllowUserToDeleteRows = False
        Me.datagridviewPackageList.AllowUserToOrderColumns = True
        Me.datagridviewPackageList.AllowUserToResizeRows = False
        Me.datagridviewPackageList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridviewPackageList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewPackageList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PkgAction, Me.PkgStatus, Me.PkgName, Me.FriendlyName, Me.AvailableVersion, Me.PkgDescription, Me.Manifest})
        Me.datagridviewPackageList.ContextMenuStrip = Me.contextmenustripPackageMenu
        Me.datagridviewPackageList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridviewPackageList.Location = New System.Drawing.Point(0, 0)
        Me.datagridviewPackageList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.datagridviewPackageList.Name = "datagridviewPackageList"
        Me.datagridviewPackageList.RowHeadersVisible = False
        Me.datagridviewPackageList.RowHeadersWidth = 51
        Me.datagridviewPackageList.RowTemplate.Height = 24
        Me.datagridviewPackageList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridviewPackageList.ShowEditingIcon = False
        Me.datagridviewPackageList.Size = New System.Drawing.Size(554, 270)
        Me.datagridviewPackageList.StandardTab = True
        Me.datagridviewPackageList.TabIndex = 0
        '
        'PkgAction
        '
        Me.PkgAction.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgAction.HeaderText = "Action"
        Me.PkgAction.Items.AddRange(New Object() {"Do nothing", "Install"})
        Me.PkgAction.MinimumWidth = 6
        Me.PkgAction.Name = "PkgAction"
        Me.PkgAction.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.PkgAction.Width = 62
        '
        'PkgStatus
        '
        Me.PkgStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.PkgStatus.HeaderText = "Status"
        Me.PkgStatus.MinimumWidth = 6
        Me.PkgStatus.Name = "PkgStatus"
        Me.PkgStatus.ReadOnly = True
        Me.PkgStatus.Width = 62
        '
        'PkgName
        '
        Me.PkgName.HeaderText = "Package"
        Me.PkgName.MinimumWidth = 6
        Me.PkgName.Name = "PkgName"
        Me.PkgName.ReadOnly = True
        '
        'FriendlyName
        '
        Me.FriendlyName.HeaderText = "Name"
        Me.FriendlyName.MinimumWidth = 6
        Me.FriendlyName.Name = "FriendlyName"
        Me.FriendlyName.ReadOnly = True
        '
        'AvailableVersion
        '
        Me.AvailableVersion.HeaderText = "Version"
        Me.AvailableVersion.MinimumWidth = 6
        Me.AvailableVersion.Name = "AvailableVersion"
        Me.AvailableVersion.ReadOnly = True
        Me.AvailableVersion.ToolTipText = "(will eventually only display latest version and have all older versions in a win" &
    "dow like Synaptic)"
        '
        'PkgDescription
        '
        Me.PkgDescription.HeaderText = "Description"
        Me.PkgDescription.MinimumWidth = 6
        Me.PkgDescription.Name = "PkgDescription"
        Me.PkgDescription.ReadOnly = True
        '
        'Manifest
        '
        Me.Manifest.HeaderText = "Manifest"
        Me.Manifest.MinimumWidth = 6
        Me.Manifest.Name = "Manifest"
        Me.Manifest.ReadOnly = True
        Me.Manifest.Visible = False
        '
        'contextmenustripPackageMenu
        '
        Me.contextmenustripPackageMenu.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenustripPackageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActionToolStripMenuItem})
        Me.contextmenustripPackageMenu.Name = "ContextMenuStrip1"
        Me.contextmenustripPackageMenu.Size = New System.Drawing.Size(110, 26)
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoNothingToolStripMenuItem, Me.InstallToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'DoNothingToolStripMenuItem
        '
        Me.DoNothingToolStripMenuItem.Name = "DoNothingToolStripMenuItem"
        Me.DoNothingToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.DoNothingToolStripMenuItem.Text = "Do nothing"
        '
        'InstallToolStripMenuItem
        '
        Me.InstallToolStripMenuItem.Name = "InstallToolStripMenuItem"
        Me.InstallToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.InstallToolStripMenuItem.Text = "Install"
        '
        'labelUpdatingPackageList
        '
        Me.labelUpdatingPackageList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labelUpdatingPackageList.AutoSize = True
        Me.labelUpdatingPackageList.Location = New System.Drawing.Point(2, 0)
        Me.labelUpdatingPackageList.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelUpdatingPackageList.Name = "labelUpdatingPackageList"
        Me.labelUpdatingPackageList.Size = New System.Drawing.Size(173, 13)
        Me.labelUpdatingPackageList.TabIndex = 1
        Me.labelUpdatingPackageList.Text = "Loading package list, please wait..."
        '
        'textboxPackageDetails
        '
        Me.textboxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textboxPackageDetails.Location = New System.Drawing.Point(0, 0)
        Me.textboxPackageDetails.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.textboxPackageDetails.Multiline = True
        Me.textboxPackageDetails.Name = "textboxPackageDetails"
        Me.textboxPackageDetails.ReadOnly = True
        Me.textboxPackageDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.textboxPackageDetails.Size = New System.Drawing.Size(554, 155)
        Me.textboxPackageDetails.TabIndex = 0
        Me.textboxPackageDetails.Text = resources.GetString("textboxPackageDetails.Text")
        '
        'panelMainPkgArea
        '
        Me.panelMainPkgArea.Controls.Add(Me.splitcontainerMainWindow)
        Me.panelMainPkgArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainPkgArea.Location = New System.Drawing.Point(0, 0)
        Me.panelMainPkgArea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelMainPkgArea.Name = "panelMainPkgArea"
        Me.panelMainPkgArea.Size = New System.Drawing.Size(554, 428)
        Me.panelMainPkgArea.TabIndex = 2
        '
        'toolstripMainWindow
        '
        Me.toolstripMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolstripMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripbuttonRefreshCache, Me.toolstripbuttonApplyChanges, Me.ToolStripSeparator2, Me.toolstripbuttonProperties, Me.ToolStripSeparator1, Me.toolstriptextboxSearch, Me.toolstripsplitbuttonSearch})
        Me.toolstripMainWindow.Location = New System.Drawing.Point(0, 24)
        Me.toolstripMainWindow.Name = "toolstripMainWindow"
        Me.toolstripMainWindow.Size = New System.Drawing.Size(794, 25)
        Me.toolstripMainWindow.TabIndex = 0
        Me.toolstripMainWindow.Text = "ToolStrip1"
        '
        'toolstripbuttonRefreshCache
        '
        Me.toolstripbuttonRefreshCache.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonRefreshCache.Image = CType(resources.GetObject("toolstripbuttonRefreshCache.Image"), System.Drawing.Image)
        Me.toolstripbuttonRefreshCache.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonRefreshCache.Name = "toolstripbuttonRefreshCache"
        Me.toolstripbuttonRefreshCache.Size = New System.Drawing.Size(84, 22)
        Me.toolstripbuttonRefreshCache.Text = "Refresh cache"
        Me.toolstripbuttonRefreshCache.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolstripbuttonApplyChanges
        '
        Me.toolstripbuttonApplyChanges.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonApplyChanges.Image = CType(resources.GetObject("toolstripbuttonApplyChanges.Image"), System.Drawing.Image)
        Me.toolstripbuttonApplyChanges.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonApplyChanges.Name = "toolstripbuttonApplyChanges"
        Me.toolstripbuttonApplyChanges.Size = New System.Drawing.Size(89, 22)
        Me.toolstripbuttonApplyChanges.Text = "Apply changes"
        Me.toolstripbuttonApplyChanges.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'toolstripbuttonProperties
        '
        Me.toolstripbuttonProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripbuttonProperties.Image = CType(resources.GetObject("toolstripbuttonProperties.Image"), System.Drawing.Image)
        Me.toolstripbuttonProperties.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripbuttonProperties.Name = "toolstripbuttonProperties"
        Me.toolstripbuttonProperties.Size = New System.Drawing.Size(64, 22)
        Me.toolstripbuttonProperties.Text = "Properties"
        Me.toolstripbuttonProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'toolstriptextboxSearch
        '
        Me.toolstriptextboxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.toolstriptextboxSearch.Name = "toolstriptextboxSearch"
        Me.toolstriptextboxSearch.Size = New System.Drawing.Size(200, 25)
        '
        'toolstripsplitbuttonSearch
        '
        Me.toolstripsplitbuttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.toolstripsplitbuttonSearch.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripmenuitemAdvancedSearch})
        Me.toolstripsplitbuttonSearch.Image = CType(resources.GetObject("toolstripsplitbuttonSearch.Image"), System.Drawing.Image)
        Me.toolstripsplitbuttonSearch.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.toolstripsplitbuttonSearch.Name = "toolstripsplitbuttonSearch"
        Me.toolstripsplitbuttonSearch.Size = New System.Drawing.Size(58, 22)
        Me.toolstripsplitbuttonSearch.Text = "Search"
        '
        'toolstripmenuitemAdvancedSearch
        '
        Me.toolstripmenuitemAdvancedSearch.Name = "toolstripmenuitemAdvancedSearch"
        Me.toolstripmenuitemAdvancedSearch.Size = New System.Drawing.Size(173, 22)
        Me.toolstripmenuitemAdvancedSearch.Text = "&Advanced search..."
        '
        'splitcontainerSidebarAndPkgList
        '
        Me.splitcontainerSidebarAndPkgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitcontainerSidebarAndPkgList.Location = New System.Drawing.Point(0, 0)
        Me.splitcontainerSidebarAndPkgList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.splitcontainerSidebarAndPkgList.Name = "splitcontainerSidebarAndPkgList"
        '
        'splitcontainerSidebarAndPkgList.Panel1
        '
        Me.splitcontainerSidebarAndPkgList.Panel1.Controls.Add(Me.panelSidebarHolder)
        '
        'splitcontainerSidebarAndPkgList.Panel2
        '
        Me.splitcontainerSidebarAndPkgList.Panel2.Controls.Add(Me.panelMainPkgArea)
        Me.splitcontainerSidebarAndPkgList.Size = New System.Drawing.Size(794, 428)
        Me.splitcontainerSidebarAndPkgList.SplitterDistance = 237
        Me.splitcontainerSidebarAndPkgList.SplitterWidth = 3
        Me.splitcontainerSidebarAndPkgList.TabIndex = 3
        '
        'panelSidebarHolder
        '
        Me.panelSidebarHolder.Controls.Add(Me.tabcontrolSidebar)
        Me.panelSidebarHolder.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelSidebarHolder.Location = New System.Drawing.Point(0, 0)
        Me.panelSidebarHolder.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelSidebarHolder.Name = "panelSidebarHolder"
        Me.panelSidebarHolder.Size = New System.Drawing.Size(237, 428)
        Me.panelSidebarHolder.TabIndex = 0
        '
        'tabcontrolSidebar
        '
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSearchTerms)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageStatus)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageCustomFilters)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSections)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageSource)
        Me.tabcontrolSidebar.Controls.Add(Me.tabpageArchitecture)
        Me.tabcontrolSidebar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabcontrolSidebar.Location = New System.Drawing.Point(0, 0)
        Me.tabcontrolSidebar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabcontrolSidebar.Name = "tabcontrolSidebar"
        Me.tabcontrolSidebar.SelectedIndex = 0
        Me.tabcontrolSidebar.Size = New System.Drawing.Size(237, 428)
        Me.tabcontrolSidebar.TabIndex = 0
        '
        'tabpageSearchTerms
        '
        Me.tabpageSearchTerms.Controls.Add(Me.listboxSearchTerms)
        Me.tabpageSearchTerms.Location = New System.Drawing.Point(4, 22)
        Me.tabpageSearchTerms.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageSearchTerms.Name = "tabpageSearchTerms"
        Me.tabpageSearchTerms.Size = New System.Drawing.Size(229, 402)
        Me.tabpageSearchTerms.TabIndex = 4
        Me.tabpageSearchTerms.Text = "Search terms"
        Me.tabpageSearchTerms.UseVisualStyleBackColor = True
        '
        'listboxSearchTerms
        '
        Me.listboxSearchTerms.ContextMenuStrip = Me.contextmenuSearchTerm
        Me.listboxSearchTerms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSearchTerms.FormattingEnabled = True
        Me.listboxSearchTerms.IntegralHeight = False
        Me.listboxSearchTerms.Items.AddRange(New Object() {"All", "test", "test2", "test3", "test4"})
        Me.listboxSearchTerms.Location = New System.Drawing.Point(0, 0)
        Me.listboxSearchTerms.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxSearchTerms.Name = "listboxSearchTerms"
        Me.listboxSearchTerms.Size = New System.Drawing.Size(229, 402)
        Me.listboxSearchTerms.TabIndex = 0
        '
        'contextmenuSearchTerm
        '
        Me.contextmenuSearchTerm.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.contextmenuSearchTerm.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearSelectedSearchTermToolStripMenuItem, Me.ToolStripSeparator3, Me.ClearAllSearchTermsToolStripMenuItem})
        Me.contextmenuSearchTerm.Name = "contextmenuSearchTerm"
        Me.contextmenuSearchTerm.Size = New System.Drawing.Size(213, 54)
        '
        'ClearSelectedSearchTermToolStripMenuItem
        '
        Me.ClearSelectedSearchTermToolStripMenuItem.Name = "ClearSelectedSearchTermToolStripMenuItem"
        Me.ClearSelectedSearchTermToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClearSelectedSearchTermToolStripMenuItem.Text = "Clear selected search term"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(209, 6)
        '
        'ClearAllSearchTermsToolStripMenuItem
        '
        Me.ClearAllSearchTermsToolStripMenuItem.Name = "ClearAllSearchTermsToolStripMenuItem"
        Me.ClearAllSearchTermsToolStripMenuItem.Size = New System.Drawing.Size(212, 22)
        Me.ClearAllSearchTermsToolStripMenuItem.Text = "Clear all search terms"
        '
        'tabpageStatus
        '
        Me.tabpageStatus.Controls.Add(Me.listboxStatusTab)
        Me.tabpageStatus.Location = New System.Drawing.Point(4, 22)
        Me.tabpageStatus.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageStatus.Name = "tabpageStatus"
        Me.tabpageStatus.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageStatus.Size = New System.Drawing.Size(230, 408)
        Me.tabpageStatus.TabIndex = 1
        Me.tabpageStatus.Text = "Status"
        Me.tabpageStatus.UseVisualStyleBackColor = True
        '
        'listboxStatusTab
        '
        Me.listboxStatusTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxStatusTab.FormattingEnabled = True
        Me.listboxStatusTab.IntegralHeight = False
        Me.listboxStatusTab.Items.AddRange(New Object() {"All"})
        Me.listboxStatusTab.Location = New System.Drawing.Point(2, 2)
        Me.listboxStatusTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxStatusTab.Name = "listboxStatusTab"
        Me.listboxStatusTab.Size = New System.Drawing.Size(226, 404)
        Me.listboxStatusTab.TabIndex = 0
        '
        'tabpageCustomFilters
        '
        Me.tabpageCustomFilters.Controls.Add(Me.listboxCustomFilters)
        Me.tabpageCustomFilters.Location = New System.Drawing.Point(4, 22)
        Me.tabpageCustomFilters.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageCustomFilters.Name = "tabpageCustomFilters"
        Me.tabpageCustomFilters.Size = New System.Drawing.Size(230, 408)
        Me.tabpageCustomFilters.TabIndex = 3
        Me.tabpageCustomFilters.Text = "Custom filters"
        Me.tabpageCustomFilters.UseVisualStyleBackColor = True
        '
        'listboxCustomFilters
        '
        Me.listboxCustomFilters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxCustomFilters.FormattingEnabled = True
        Me.listboxCustomFilters.IntegralHeight = False
        Me.listboxCustomFilters.Items.AddRange(New Object() {"All"})
        Me.listboxCustomFilters.Location = New System.Drawing.Point(0, 0)
        Me.listboxCustomFilters.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxCustomFilters.Name = "listboxCustomFilters"
        Me.listboxCustomFilters.Size = New System.Drawing.Size(230, 408)
        Me.listboxCustomFilters.TabIndex = 1
        '
        'tabpageSections
        '
        Me.tabpageSections.Controls.Add(Me.listboxSections)
        Me.tabpageSections.Location = New System.Drawing.Point(4, 22)
        Me.tabpageSections.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageSections.Name = "tabpageSections"
        Me.tabpageSections.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageSections.Size = New System.Drawing.Size(230, 408)
        Me.tabpageSections.TabIndex = 0
        Me.tabpageSections.Text = "Categories"
        Me.tabpageSections.UseVisualStyleBackColor = True
        '
        'listboxSections
        '
        Me.listboxSections.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSections.FormattingEnabled = True
        Me.listboxSections.IntegralHeight = False
        Me.listboxSections.Items.AddRange(New Object() {"All"})
        Me.listboxSections.Location = New System.Drawing.Point(2, 2)
        Me.listboxSections.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxSections.Name = "listboxSections"
        Me.listboxSections.Size = New System.Drawing.Size(226, 404)
        Me.listboxSections.TabIndex = 1
        '
        'tabpageSource
        '
        Me.tabpageSource.Controls.Add(Me.listboxSourceTab)
        Me.tabpageSource.Location = New System.Drawing.Point(4, 22)
        Me.tabpageSource.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageSource.Name = "tabpageSource"
        Me.tabpageSource.Size = New System.Drawing.Size(230, 408)
        Me.tabpageSource.TabIndex = 2
        Me.tabpageSource.Text = "Source"
        Me.tabpageSource.UseVisualStyleBackColor = True
        '
        'listboxSourceTab
        '
        Me.listboxSourceTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxSourceTab.FormattingEnabled = True
        Me.listboxSourceTab.IntegralHeight = False
        Me.listboxSourceTab.Items.AddRange(New Object() {"All"})
        Me.listboxSourceTab.Location = New System.Drawing.Point(0, 0)
        Me.listboxSourceTab.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxSourceTab.Name = "listboxSourceTab"
        Me.listboxSourceTab.Size = New System.Drawing.Size(230, 408)
        Me.listboxSourceTab.TabIndex = 1
        '
        'tabpageArchitecture
        '
        Me.tabpageArchitecture.Controls.Add(Me.listboxArchitecture)
        Me.tabpageArchitecture.Location = New System.Drawing.Point(4, 22)
        Me.tabpageArchitecture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tabpageArchitecture.Name = "tabpageArchitecture"
        Me.tabpageArchitecture.Size = New System.Drawing.Size(230, 408)
        Me.tabpageArchitecture.TabIndex = 5
        Me.tabpageArchitecture.Text = "Architecture"
        Me.tabpageArchitecture.UseVisualStyleBackColor = True
        '
        'listboxArchitecture
        '
        Me.listboxArchitecture.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxArchitecture.FormattingEnabled = True
        Me.listboxArchitecture.IntegralHeight = False
        Me.listboxArchitecture.Items.AddRange(New Object() {"All"})
        Me.listboxArchitecture.Location = New System.Drawing.Point(0, 0)
        Me.listboxArchitecture.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.listboxArchitecture.Name = "listboxArchitecture"
        Me.listboxArchitecture.Size = New System.Drawing.Size(230, 408)
        Me.listboxArchitecture.TabIndex = 1
        '
        'panelMainForm
        '
        Me.panelMainForm.Controls.Add(Me.splitcontainerSidebarAndPkgList)
        Me.panelMainForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelMainForm.Location = New System.Drawing.Point(0, 49)
        Me.panelMainForm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panelMainForm.Name = "panelMainForm"
        Me.panelMainForm.Size = New System.Drawing.Size(794, 428)
        Me.panelMainForm.TabIndex = 4
        '
        'statusbarMainWindow
        '
        Me.statusbarMainWindow.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.statusbarMainWindow.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolstripstatuslabelPackageCount, Me.toolstripstatusSplitter, Me.toolstripprogressbarLoadingPackages, Me.toolstripstatuslabelLoadingPackageCount})
        Me.statusbarMainWindow.Location = New System.Drawing.Point(0, 477)
        Me.statusbarMainWindow.Name = "statusbarMainWindow"
        Me.statusbarMainWindow.Padding = New System.Windows.Forms.Padding(1, 0, 11, 0)
        Me.statusbarMainWindow.Size = New System.Drawing.Size(794, 22)
        Me.statusbarMainWindow.TabIndex = 5
        Me.statusbarMainWindow.Text = "StatusStrip1"
        '
        'toolstripstatuslabelPackageCount
        '
        Me.toolstripstatuslabelPackageCount.Name = "toolstripstatuslabelPackageCount"
        Me.toolstripstatuslabelPackageCount.Size = New System.Drawing.Size(99, 17)
        Me.toolstripstatuslabelPackageCount.Text = "0 packages listed."
        '
        'toolstripstatusSplitter
        '
        Me.toolstripstatusSplitter.Name = "toolstripstatusSplitter"
        Me.toolstripstatusSplitter.Size = New System.Drawing.Size(10, 17)
        Me.toolstripstatusSplitter.Text = "|"
        Me.toolstripstatusSplitter.Visible = False
        '
        'toolstripprogressbarLoadingPackages
        '
        Me.toolstripprogressbarLoadingPackages.Name = "toolstripprogressbarLoadingPackages"
        Me.toolstripprogressbarLoadingPackages.Size = New System.Drawing.Size(120, 16)
        Me.toolstripprogressbarLoadingPackages.Visible = False
        '
        'toolstripstatuslabelLoadingPackageCount
        '
        Me.toolstripstatuslabelLoadingPackageCount.Name = "toolstripstatuslabelLoadingPackageCount"
        Me.toolstripstatuslabelLoadingPackageCount.Size = New System.Drawing.Size(111, 17)
        Me.toolstripstatuslabelLoadingPackageCount.Text = "Loading packages..."
        Me.toolstripstatuslabelLoadingPackageCount.Visible = False
        '
        'aaformMainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(794, 499)
        Me.Controls.Add(Me.panelMainForm)
        Me.Controls.Add(Me.statusbarMainWindow)
        Me.Controls.Add(Me.toolstripMainWindow)
        Me.Controls.Add(Me.menustripMainWindow)
        Me.MainMenuStrip = Me.menustripMainWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "aaformMainWindow"
        Me.Text = "guinget version 0.1 pre-alpha 1"
        Me.menustripMainWindow.ResumeLayout(False)
        Me.menustripMainWindow.PerformLayout()
        Me.splitcontainerMainWindow.Panel1.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.ResumeLayout(False)
        Me.splitcontainerMainWindow.Panel2.PerformLayout()
        CType(Me.splitcontainerMainWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerMainWindow.ResumeLayout(False)
        Me.panelPackageListHolder.ResumeLayout(False)
        Me.panelPackageListHolder.PerformLayout()
        CType(Me.datagridviewPackageList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.contextmenustripPackageMenu.ResumeLayout(False)
        Me.panelMainPkgArea.ResumeLayout(False)
        Me.toolstripMainWindow.ResumeLayout(False)
        Me.toolstripMainWindow.PerformLayout()
        Me.splitcontainerSidebarAndPkgList.Panel1.ResumeLayout(False)
        Me.splitcontainerSidebarAndPkgList.Panel2.ResumeLayout(False)
        CType(Me.splitcontainerSidebarAndPkgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitcontainerSidebarAndPkgList.ResumeLayout(False)
        Me.panelSidebarHolder.ResumeLayout(False)
        Me.tabcontrolSidebar.ResumeLayout(False)
        Me.tabpageSearchTerms.ResumeLayout(False)
        Me.contextmenuSearchTerm.ResumeLayout(False)
        Me.tabpageStatus.ResumeLayout(False)
        Me.tabpageCustomFilters.ResumeLayout(False)
        Me.tabpageSections.ResumeLayout(False)
        Me.tabpageSource.ResumeLayout(False)
        Me.tabpageArchitecture.ResumeLayout(False)
        Me.panelMainForm.ResumeLayout(False)
        Me.statusbarMainWindow.ResumeLayout(False)
        Me.statusbarMainWindow.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menustripMainWindow As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerifyManifestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents splitcontainerMainWindow As SplitContainer
    Friend WithEvents textboxPackageDetails As TextBox
    Friend WithEvents panelMainPkgArea As Panel
    Friend WithEvents toolstripMainWindow As ToolStrip
    Friend WithEvents toolstriptextboxSearch As ToolStripTextBox
    Friend WithEvents datagridviewPackageList As DataGridView
    Friend WithEvents contextmenustripPackageMenu As ContextMenuStrip
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoNothingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InstallToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents toolstripbuttonRefreshCache As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents toolstripbuttonProperties As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents toolstripbuttonApplyChanges As ToolStripButton
    Friend WithEvents splitcontainerSidebarAndPkgList As SplitContainer
    Friend WithEvents panelMainForm As Panel
    Friend WithEvents panelSidebarHolder As Panel
    Friend WithEvents tabcontrolSidebar As TabControl
    Friend WithEvents tabpageSections As TabPage
    Friend WithEvents tabpageStatus As TabPage
    Friend WithEvents tabpageSource As TabPage
    Friend WithEvents tabpageCustomFilters As TabPage
    Friend WithEvents tabpageSearchTerms As TabPage
    Friend WithEvents listboxSearchTerms As ListBox
    Friend WithEvents listboxStatusTab As ListBox
    Friend WithEvents tabpageArchitecture As TabPage
    Friend WithEvents listboxSections As ListBox
    Friend WithEvents listboxSourceTab As ListBox
    Friend WithEvents listboxCustomFilters As ListBox
    Friend WithEvents listboxArchitecture As ListBox
    Friend WithEvents contextmenuSearchTerm As ContextMenuStrip
    Friend WithEvents ClearSelectedSearchTermToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearAllSearchTermsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents statusbarMainWindow As StatusStrip
    Friend WithEvents toolstripstatuslabelPackageCount As ToolStripStatusLabel
    Friend WithEvents toolstripstatuslabelLoadingPackageCount As ToolStripStatusLabel
    Friend WithEvents toolstripprogressbarLoadingPackages As ToolStripProgressBar
    Friend WithEvents toolstripstatusSplitter As ToolStripStatusLabel
    Friend WithEvents labelUpdatingPackageList As Label
    Friend WithEvents panelPackageListHolder As Panel
    Friend WithEvents toolstripsplitbuttonSearch As ToolStripSplitButton
    Friend WithEvents toolstripmenuitemAdvancedSearch As ToolStripMenuItem
    Friend WithEvents PkgAction As DataGridViewComboBoxColumn
    Friend WithEvents PkgStatus As DataGridViewTextBoxColumn
    Friend WithEvents PkgName As DataGridViewTextBoxColumn
    Friend WithEvents FriendlyName As DataGridViewTextBoxColumn
    Friend WithEvents AvailableVersion As DataGridViewTextBoxColumn
    Friend WithEvents PkgDescription As DataGridViewTextBoxColumn
    Friend WithEvents Manifest As DataGridViewTextBoxColumn
End Class
