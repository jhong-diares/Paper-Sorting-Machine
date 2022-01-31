Namespace PaperSortingMachine
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Me.metroStatusBar1 = New DevComponents.DotNetBar.Metro.MetroStatusBar()
            Me.labelItem1 = New DevComponents.DotNetBar.LabelItem()
            Me.metroShell1 = New DevComponents.DotNetBar.Metro.MetroShell()
            Me.metroTabPanel1 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ListView1 = New System.Windows.Forms.ListView()
            Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.metroTabPanel2 = New DevComponents.DotNetBar.Metro.MetroTabPanel()
            Me.ListView2 = New System.Windows.Forms.ListView()
            Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader19 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader20 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader22 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.ColumnHeader23 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
            Me.metroAppButton1 = New DevComponents.DotNetBar.Metro.MetroAppButton()
            Me.superTabControl1 = New DevComponents.DotNetBar.SuperTabControl()
            Me.superTabControlPanel1 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem1 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel3 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem3 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel4 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem4 = New DevComponents.DotNetBar.SuperTabItem()
            Me.superTabControlPanel2 = New DevComponents.DotNetBar.SuperTabControlPanel()
            Me.superTabItem2 = New DevComponents.DotNetBar.SuperTabItem()
            Me.buttonItem2 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem3 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem4 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem5 = New DevComponents.DotNetBar.ButtonItem()
            Me.buttonItem6 = New DevComponents.DotNetBar.ButtonItem()
            Me.metroTabItem1 = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.metroTabItem2 = New DevComponents.DotNetBar.Metro.MetroTabItem()
            Me.colorThemeButton = New DevComponents.DotNetBar.ButtonItem()
            Me.qatCustomizeItem1 = New DevComponents.DotNetBar.QatCustomizeItem()
            Me.styleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.metroShell1.SuspendLayout()
            Me.metroTabPanel1.SuspendLayout()
            Me.metroTabPanel2.SuspendLayout()
            CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.superTabControl1.SuspendLayout()
            Me.SuspendLayout()
            '
            'metroStatusBar1
            '
            Me.metroStatusBar1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.metroStatusBar1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroStatusBar1.ContainerControlProcessDialogKey = True
            Me.metroStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.metroStatusBar1.DragDropSupport = True
            Me.metroStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroStatusBar1.ForeColor = System.Drawing.Color.Black
            Me.metroStatusBar1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.labelItem1})
            Me.metroStatusBar1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.metroStatusBar1.Location = New System.Drawing.Point(1, 518)
            Me.metroStatusBar1.Name = "metroStatusBar1"
            Me.metroStatusBar1.Size = New System.Drawing.Size(851, 22)
            Me.metroStatusBar1.TabIndex = 0
            Me.metroStatusBar1.Text = "metroStatusBar1"
            '
            'labelItem1
            '
            Me.labelItem1.Name = "labelItem1"
            Me.labelItem1.Text = "READY"
            '
            'metroShell1
            '
            Me.metroShell1.BackColor = System.Drawing.Color.White
            '
            '
            '
            Me.metroShell1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroShell1.CaptionVisible = True
            Me.metroShell1.Controls.Add(Me.metroTabPanel2)
            Me.metroShell1.Controls.Add(Me.metroTabPanel1)
            Me.metroShell1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.metroShell1.ForeColor = System.Drawing.Color.Black
            Me.metroShell1.HelpButtonText = Nothing
            Me.metroShell1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.metroAppButton1, Me.metroTabItem1, Me.metroTabItem2})
            Me.metroShell1.KeyTipsFont = New System.Drawing.Font("Tahoma", 7.0!)
            Me.metroShell1.Location = New System.Drawing.Point(1, 1)
            Me.metroShell1.Name = "metroShell1"
            Me.metroShell1.QuickToolbarItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.colorThemeButton, Me.qatCustomizeItem1})
            Me.metroShell1.Size = New System.Drawing.Size(851, 517)
            Me.metroShell1.SystemText.MaximizeRibbonText = "&Maximize the Ribbon"
            Me.metroShell1.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon"
            Me.metroShell1.SystemText.QatAddItemText = "&Add to Quick Access Toolbar"
            Me.metroShell1.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>"
            Me.metroShell1.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar..."
            Me.metroShell1.SystemText.QatDialogAddButton = "&Add >>"
            Me.metroShell1.SystemText.QatDialogCancelButton = "Cancel"
            Me.metroShell1.SystemText.QatDialogCaption = "Customize Quick Access Toolbar"
            Me.metroShell1.SystemText.QatDialogCategoriesLabel = "&Choose commands from:"
            Me.metroShell1.SystemText.QatDialogOkButton = "OK"
            Me.metroShell1.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon"
            Me.metroShell1.SystemText.QatDialogRemoveButton = "&Remove"
            Me.metroShell1.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon"
            Me.metroShell1.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon"
            Me.metroShell1.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar"
            Me.metroShell1.TabIndex = 1
            Me.metroShell1.TabStripFont = New System.Drawing.Font("Segoe UI", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            '
            'metroTabPanel1
            '
            Me.metroTabPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.metroTabPanel1.Controls.Add(Me.ListView1)
            Me.metroTabPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.metroTabPanel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroTabPanel1.Location = New System.Drawing.Point(0, 51)
            Me.metroTabPanel1.Name = "metroTabPanel1"
            Me.metroTabPanel1.Padding = New System.Windows.Forms.Padding(16, 3, 16, 40)
            Me.metroTabPanel1.Size = New System.Drawing.Size(851, 466)
            '
            '
            '
            Me.metroTabPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.metroTabPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.metroTabPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTabPanel1.TabIndex = 1
            Me.metroTabPanel1.Visible = False
            '
            'ListView1
            '
            Me.ListView1.BackColor = System.Drawing.Color.White
            Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8})
            Me.ListView1.ForeColor = System.Drawing.Color.Black
            Me.ListView1.FullRowSelect = True
            Me.ListView1.GridLines = True
            Me.ListView1.Location = New System.Drawing.Point(3, 6)
            Me.ListView1.Name = "ListView1"
            Me.ListView1.Size = New System.Drawing.Size(829, 408)
            Me.ListView1.TabIndex = 3
            Me.ListView1.UseCompatibleStateImageBehavior = False
            Me.ListView1.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "ID"
            Me.ColumnHeader1.Width = 30
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "ctrl_count_number"
            Me.ColumnHeader2.Width = 150
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "color_desc"
            Me.ColumnHeader3.Width = 140
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "color_value"
            Me.ColumnHeader4.Width = 140
            '
            'ColumnHeader5
            '
            Me.ColumnHeader5.Text = "array_index"
            Me.ColumnHeader5.Width = 90
            '
            'ColumnHeader6
            '
            Me.ColumnHeader6.Text = "set_angle"
            Me.ColumnHeader6.Width = 80
            '
            'ColumnHeader7
            '
            Me.ColumnHeader7.Text = "date"
            Me.ColumnHeader7.Width = 120
            '
            'ColumnHeader8
            '
            Me.ColumnHeader8.Text = "total_count"
            Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            Me.ColumnHeader8.Width = 75
            '
            'metroTabPanel2
            '
            Me.metroTabPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
            Me.metroTabPanel2.Controls.Add(Me.ListView2)
            Me.metroTabPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.metroTabPanel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.metroTabPanel2.Location = New System.Drawing.Point(0, 51)
            Me.metroTabPanel2.Name = "metroTabPanel2"
            Me.metroTabPanel2.Padding = New System.Windows.Forms.Padding(16, 3, 16, 40)
            Me.metroTabPanel2.Size = New System.Drawing.Size(851, 466)
            '
            '
            '
            Me.metroTabPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.metroTabPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.metroTabPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.metroTabPanel2.TabIndex = 2
            '
            'ListView2
            '
            Me.ListView2.BackColor = System.Drawing.Color.White
            Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader18, Me.ColumnHeader19, Me.ColumnHeader20, Me.ColumnHeader21, Me.ColumnHeader22, Me.ColumnHeader23})
            Me.ListView2.ForeColor = System.Drawing.Color.Black
            Me.ListView2.FullRowSelect = True
            Me.ListView2.GridLines = True
            Me.ListView2.Location = New System.Drawing.Point(3, 6)
            Me.ListView2.Name = "ListView2"
            Me.ListView2.Size = New System.Drawing.Size(829, 408)
            Me.ListView2.TabIndex = 4
            Me.ListView2.UseCompatibleStateImageBehavior = False
            Me.ListView2.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader17
            '
            Me.ColumnHeader17.Text = "Date"
            '
            'ColumnHeader18
            '
            Me.ColumnHeader18.Text = "ID"
            '
            'ColumnHeader19
            '
            Me.ColumnHeader19.Text = "ctrl_log_number"
            '
            'ColumnHeader20
            '
            Me.ColumnHeader20.Text = "ctrl_count_number"
            '
            'ColumnHeader21
            '
            Me.ColumnHeader21.Text = "start_time"
            '
            'ColumnHeader22
            '
            Me.ColumnHeader22.Text = "pause_time"
            '
            'ColumnHeader23
            '
            Me.ColumnHeader23.Text = "end_time"
            '
            'metroAppButton1
            '
            Me.metroAppButton1.AutoExpandOnClick = True
            Me.metroAppButton1.BackstageTab = Me.superTabControl1
            Me.metroAppButton1.CanCustomize = False
            Me.metroAppButton1.ImageFixedSize = New System.Drawing.Size(16, 16)
            Me.metroAppButton1.ImagePaddingHorizontal = 0
            Me.metroAppButton1.ImagePaddingVertical = 0
            Me.metroAppButton1.Name = "metroAppButton1"
            Me.metroAppButton1.ShowSubItems = False
            Me.metroAppButton1.Text = "&File"
            '
            'superTabControl1
            '
            Me.superTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                        Or System.Windows.Forms.AnchorStyles.Left) _
                        Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.superTabControl1.BackColor = System.Drawing.Color.White
            '
            '
            '
            '
            '
            '
            Me.superTabControl1.ControlBox.CloseBox.Name = ""
            '
            '
            '
            Me.superTabControl1.ControlBox.MenuBox.Name = ""
            Me.superTabControl1.ControlBox.Name = ""
            Me.superTabControl1.ControlBox.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.superTabControl1.ControlBox.MenuBox, Me.superTabControl1.ControlBox.CloseBox})
            Me.superTabControl1.ControlBox.Visible = False
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel1)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel3)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel4)
            Me.superTabControl1.Controls.Add(Me.superTabControlPanel2)
            Me.superTabControl1.ForeColor = System.Drawing.Color.Black
            Me.superTabControl1.ItemPadding.Left = 6
            Me.superTabControl1.ItemPadding.Right = 4
            Me.superTabControl1.ItemPadding.Top = 4
            Me.superTabControl1.Location = New System.Drawing.Point(1, 50)
            Me.superTabControl1.Name = "superTabControl1"
            Me.superTabControl1.ReorderTabsEnabled = False
            Me.superTabControl1.SelectedTabFont = New System.Drawing.Font("Segoe UI", 9.75!)
            Me.superTabControl1.SelectedTabIndex = 3
            Me.superTabControl1.Size = New System.Drawing.Size(852, 490)
            Me.superTabControl1.TabAlignment = DevComponents.DotNetBar.eTabStripAlignment.Left
            Me.superTabControl1.TabFont = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.superTabControl1.TabHorizontalSpacing = 16
            Me.superTabControl1.TabIndex = 2
            Me.superTabControl1.Tabs.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.buttonItem2, Me.buttonItem3, Me.buttonItem4, Me.superTabItem1, Me.superTabItem2, Me.superTabItem3, Me.superTabItem4, Me.buttonItem5, Me.buttonItem6})
            Me.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.Office2010BackstageBlue
            Me.superTabControl1.TabVerticalSpacing = 8
            '
            'superTabControlPanel1
            '
            Me.superTabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel1.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel1.Name = "superTabControlPanel1"
            Me.superTabControlPanel1.Size = New System.Drawing.Size(616, 490)
            Me.superTabControlPanel1.TabIndex = 1
            Me.superTabControlPanel1.TabItem = Me.superTabItem1
            '
            'superTabItem1
            '
            Me.superTabItem1.AttachedControl = Me.superTabControlPanel1
            Me.superTabItem1.GlobalItem = False
            Me.superTabItem1.KeyTips = "R"
            Me.superTabItem1.Name = "superTabItem1"
            Me.superTabItem1.Text = "Recent"
            '
            'superTabControlPanel3
            '
            Me.superTabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel3.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel3.Name = "superTabControlPanel3"
            Me.superTabControlPanel3.Size = New System.Drawing.Size(616, 490)
            Me.superTabControlPanel3.TabIndex = 3
            Me.superTabControlPanel3.TabItem = Me.superTabItem3
            '
            'superTabItem3
            '
            Me.superTabItem3.AttachedControl = Me.superTabControlPanel3
            Me.superTabItem3.GlobalItem = False
            Me.superTabItem3.KeyTips = "P"
            Me.superTabItem3.Name = "superTabItem3"
            Me.superTabItem3.Text = "Print"
            '
            'superTabControlPanel4
            '
            Me.superTabControlPanel4.BackgroundImagePosition = DevComponents.DotNetBar.eStyleBackgroundImage.BottomRight
            Me.superTabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel4.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel4.Name = "superTabControlPanel4"
            Me.superTabControlPanel4.Size = New System.Drawing.Size(616, 490)
            Me.superTabControlPanel4.TabIndex = 4
            Me.superTabControlPanel4.TabItem = Me.superTabItem4
            '
            'superTabItem4
            '
            Me.superTabItem4.AttachedControl = Me.superTabControlPanel4
            Me.superTabItem4.GlobalItem = False
            Me.superTabItem4.KeyTips = "H"
            Me.superTabItem4.Name = "superTabItem4"
            Me.superTabItem4.Text = "Help"
            '
            'superTabControlPanel2
            '
            Me.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.superTabControlPanel2.Location = New System.Drawing.Point(236, 0)
            Me.superTabControlPanel2.Name = "superTabControlPanel2"
            Me.superTabControlPanel2.Size = New System.Drawing.Size(616, 490)
            Me.superTabControlPanel2.TabIndex = 2
            Me.superTabControlPanel2.TabItem = Me.superTabItem2
            '
            'superTabItem2
            '
            Me.superTabItem2.AttachedControl = Me.superTabControlPanel2
            Me.superTabItem2.GlobalItem = False
            Me.superTabItem2.KeyTips = "N"
            Me.superTabItem2.Name = "superTabItem2"
            Me.superTabItem2.Text = "New"
            '
            'buttonItem2
            '
            Me.buttonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem2.Image = CType(resources.GetObject("buttonItem2.Image"), System.Drawing.Image)
            Me.buttonItem2.ImagePaddingHorizontal = 18
            Me.buttonItem2.ImagePaddingVertical = 10
            Me.buttonItem2.KeyTips = "S"
            Me.buttonItem2.Name = "buttonItem2"
            Me.buttonItem2.Stretch = True
            Me.buttonItem2.Text = "Save"
            '
            'buttonItem3
            '
            Me.buttonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem3.Image = CType(resources.GetObject("buttonItem3.Image"), System.Drawing.Image)
            Me.buttonItem3.ImagePaddingHorizontal = 18
            Me.buttonItem3.ImagePaddingVertical = 10
            Me.buttonItem3.KeyTips = "O"
            Me.buttonItem3.Name = "buttonItem3"
            Me.buttonItem3.Stretch = True
            Me.buttonItem3.Text = "Open"
            '
            'buttonItem4
            '
            Me.buttonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem4.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem4.Image = CType(resources.GetObject("buttonItem4.Image"), System.Drawing.Image)
            Me.buttonItem4.ImagePaddingHorizontal = 18
            Me.buttonItem4.ImagePaddingVertical = 10
            Me.buttonItem4.KeyTips = "C"
            Me.buttonItem4.Name = "buttonItem4"
            Me.buttonItem4.Stretch = True
            Me.buttonItem4.Text = "Close"
            '
            'buttonItem5
            '
            Me.buttonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem5.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem5.Image = CType(resources.GetObject("buttonItem5.Image"), System.Drawing.Image)
            Me.buttonItem5.ImagePaddingHorizontal = 18
            Me.buttonItem5.ImagePaddingVertical = 10
            Me.buttonItem5.KeyTips = "T"
            Me.buttonItem5.Name = "buttonItem5"
            Me.buttonItem5.Stretch = True
            Me.buttonItem5.Text = "Options"
            '
            'buttonItem6
            '
            Me.buttonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText
            Me.buttonItem6.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue
            Me.buttonItem6.Image = CType(resources.GetObject("buttonItem6.Image"), System.Drawing.Image)
            Me.buttonItem6.ImagePaddingHorizontal = 18
            Me.buttonItem6.ImagePaddingVertical = 10
            Me.buttonItem6.KeyTips = "X"
            Me.buttonItem6.Name = "buttonItem6"
            Me.buttonItem6.Stretch = True
            Me.buttonItem6.Text = "Exit"
            '
            'metroTabItem1
            '
            Me.metroTabItem1.Name = "metroTabItem1"
            Me.metroTabItem1.Panel = Me.metroTabPanel1
            Me.metroTabItem1.Text = "&ACTUAL COUNT"
            '
            'metroTabItem2
            '
            Me.metroTabItem2.Checked = True
            Me.metroTabItem2.Name = "metroTabItem2"
            Me.metroTabItem2.Panel = Me.metroTabPanel2
            Me.metroTabItem2.Text = "&SORTING LOGS"
            '
            'colorThemeButton
            '
            Me.colorThemeButton.AutoExpandOnClick = True
            Me.colorThemeButton.CanCustomize = False
            Me.colorThemeButton.Image = Global.My.Resources.Resources.ColorScheme
            Me.colorThemeButton.Name = "colorThemeButton"
            Me.colorThemeButton.ShowSubItems = False
            Me.colorThemeButton.Text = "Metro Color Themes"
            Me.colorThemeButton.Tooltip = "Choose Metro Color Theme"
            '
            'qatCustomizeItem1
            '
            Me.qatCustomizeItem1.BeginGroup = True
            Me.qatCustomizeItem1.Name = "qatCustomizeItem1"
            '
            'styleManager1
            '
            Me.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro
            Me.styleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(163, Byte), Integer), CType(CType(26, Byte), Integer)))
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 1000
            '
            'MainForm
            '
            Me.ClientSize = New System.Drawing.Size(853, 541)
            Me.Controls.Add(Me.superTabControl1)
            Me.Controls.Add(Me.metroShell1)
            Me.Controls.Add(Me.metroStatusBar1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(600, 400)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Paper Sorting Machine"
            Me.metroShell1.ResumeLayout(False)
            Me.metroShell1.PerformLayout()
            Me.metroTabPanel1.ResumeLayout(False)
            Me.metroTabPanel2.ResumeLayout(False)
            CType(Me.superTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.superTabControl1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

#End Region

        Private metroStatusBar1 As DevComponents.DotNetBar.Metro.MetroStatusBar
        Private WithEvents metroShell1 As DevComponents.DotNetBar.Metro.MetroShell
        Private metroTabPanel1 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Private metroTabPanel2 As DevComponents.DotNetBar.Metro.MetroTabPanel
        Private WithEvents metroAppButton1 As DevComponents.DotNetBar.Metro.MetroAppButton
        Private metroTabItem1 As DevComponents.DotNetBar.Metro.MetroTabItem
        Private metroTabItem2 As DevComponents.DotNetBar.Metro.MetroTabItem
        Private qatCustomizeItem1 As DevComponents.DotNetBar.QatCustomizeItem
        Private styleManager1 As DevComponents.DotNetBar.StyleManager
        Private superTabControl1 As DevComponents.DotNetBar.SuperTabControl
        Private superTabControlPanel4 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem4 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel3 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem3 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel2 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem2 As DevComponents.DotNetBar.SuperTabItem
        Private superTabControlPanel1 As DevComponents.DotNetBar.SuperTabControlPanel
        Private superTabItem1 As DevComponents.DotNetBar.SuperTabItem
        Private buttonItem2 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem3 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem4 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem5 As DevComponents.DotNetBar.ButtonItem
        Private buttonItem6 As DevComponents.DotNetBar.ButtonItem
        Private colorThemeButton As DevComponents.DotNetBar.ButtonItem
        Private labelItem1 As DevComponents.DotNetBar.LabelItem
        Friend WithEvents ListView1 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ListView2 As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader19 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader20 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader21 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader22 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader23 As System.Windows.Forms.ColumnHeader
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
    End Class
End Namespace