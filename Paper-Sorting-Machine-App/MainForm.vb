Imports System.ComponentModel
Imports System.Text
Imports DevComponents.DotNetBar.Metro
Imports DevComponents.DotNetBar
Imports DevComponents.AdvTree
Imports DevComponents.DotNetBar.Metro.ColorTables

Namespace PaperSortingMachine
    Partial Public Class MainForm
        Inherits MetroAppForm
        Private _StartControl As StartControl = Nothing ' Start control displayed on startup
        Private _Commands As PaperSortingMachineCommands = Nothing ' All application commands
        Public Sub New()
            InitializeComponent()

            ' Prepare commands
            _Commands = New PaperSortingMachineCommands()

            _Commands.ToggleStartControl = New Command(components)
            AddHandler _Commands.ToggleStartControl.Executed, AddressOf ToggleStartControlExecuted

            ' Initialize Client related commands

            _Commands.ChangeMetroTheme = New Command(components, New EventHandler(AddressOf ChangeMetroThemeExecuted))

            Me.SuspendLayout()
            _StartControl = New StartControl()
            _StartControl.Commands = _Commands
            Me.Controls.Add(_StartControl)
            _StartControl.BringToFront()
            _StartControl.SlideSide = DevComponents.DotNetBar.Controls.eSlideSide.Right
            AddHandler _StartControl.Click, AddressOf StartControl_Click
            Me.ResumeLayout(False)

            Dim date1 As Date = DateTime.Now
            Dim dateString As String = date1.ToString("yyyy-MM-dd")
            _StartControl.Label2.Text = dateString
            _StartControl.Label1.Text = (Now.ToString("D"))
            ' Add color themes
            Dim metroThemes() As MetroColorGeneratorParameters = MetroColorGeneratorParameters.GetAllPredefinedThemes()
            For Each mt As MetroColorGeneratorParameters In metroThemes
                Dim theme As New ButtonItem(mt.ThemeName, mt.ThemeName)
                theme.Command = _Commands.ChangeMetroTheme
                theme.CommandParameter = mt
                colorThemeButton.SubItems.Add(theme)
            Next mt
        End Sub

#Region "Command Execution"
        Private Sub ChangeMetroThemeExecuted(ByVal sender As Object, ByVal e As EventArgs)
            Dim source As ICommandSource = CType(sender, ICommandSource)
            Dim theme As MetroColorGeneratorParameters = CType(source.CommandParameter, MetroColorGeneratorParameters)
            StyleManager.MetroColorGeneratorParameters = theme
        End Sub
        Private Sub ToggleStartControlExecuted(ByVal sender As Object, ByVal e As EventArgs)
            _StartControl.IsOpen = Not _StartControl.IsOpen
        End Sub
#End Region

#Region "UI Code"
        Private Sub StartControl_Click(ByVal sender As Object, ByVal e As EventArgs)
            _StartControl.IsOpen = False
            'ACTUAL_COUNT()
        End Sub
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            UpdateControlsSizeAndLocation()
            connect_database()
            loop_display()
            MyBase.OnLoad(e)
        End Sub
        Private Function GetStartControlBounds() As Rectangle
            Dim captionHeight As Integer = metroShell1.MetroTabStrip.GetCaptionHeight() + 2
            Dim borderThickness As Thickness = Me.GetBorderThickness()
            Return New Rectangle(CInt(Fix(borderThickness.Left)), captionHeight, Me.Width - CInt(Fix(borderThickness.Horizontal)), Me.Height - captionHeight - 1)
        End Function
        Private Sub UpdateControlsSizeAndLocation()
            If _StartControl IsNot Nothing Then
                If Not _StartControl.IsOpen Then
                    _StartControl.OpenBounds = GetStartControlBounds()
                Else
                    _StartControl.Bounds = GetStartControlBounds()
                End If
                If Not IsModalPanelDisplayed Then
                    _StartControl.BringToFront()
                End If
            End If
        End Sub
        Protected Overrides Sub OnResize(ByVal e As EventArgs)
            UpdateControlsSizeAndLocation()
            MyBase.OnResize(e)
        End Sub
        Private Sub metroAppButton1_ExpandChange(ByVal sender As Object, ByVal e As EventArgs) Handles metroAppButton1.ExpandChange
            If Not _StartControl.Visible Then
                _StartControl.SlideOutButtonVisible = Not metroAppButton1.Expanded
            End If
        End Sub
        Private Sub metroShell1_SettingsButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SettingsButtonClick
            MessageBoxEx.Show(Me, "Settings Button Clicked", "Paper Sorting Machine", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Private Sub metroShell1_HelpButtonClick(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.HelpButtonClick
            MessageBoxEx.Show(Me, "Help Button Clicked", "Paper Sorting Machine", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Sub
        Private Sub metroShell1_SelectedTabChanged(ByVal sender As Object, ByVal e As EventArgs) Handles metroShell1.SelectedTabChanged
            UpdateControlsSizeAndLocation()
        End Sub
#End Region

#Region "TABLE"
        ' Display ACTUAL_COUNT Table
        Sub ACTUAL_COUNT()
            rec = New ADODB.Recordset
            rec.Open("SELECT * FROM `TBL_ACTUAL_COUNT", con, 1, 2)
            ListView1.Items.Clear()
            Do While Not rec.EOF
                Dim lv As ListViewItem
                lv = ListView1.Items.Add(rec.Fields("id").Value)
                lv.SubItems.Add(rec.Fields("ctrl_count_number").Value)
                lv.SubItems.Add(rec.Fields("color_desc").Value)
                lv.SubItems.Add(rec.Fields("color_value").Value)
                lv.SubItems.Add(rec.Fields("array_index").Value)
                lv.SubItems.Add(rec.Fields("set_angle").Value)
                lv.SubItems.Add(rec.Fields("date_started").Value)
                lv.SubItems.Add(rec.Fields("total_count").Value)
                rec.MoveNext()
            Loop
        End Sub

        Sub loop_display()
            Dim f_txt As String
            Dim var_id As Integer
            Dim var_ccn, var_sa, var_ds, global_val As String

            rec = New ADODB.Recordset
            rec.Open("SELECT * FROM `tbl_actual_shit` WHERE date_started = CURDATE() ", con, 1, 2)

            Do While Not rec.EOF
                var_id = (rec.Fields("id").Value)
                var_ccn = (rec.Fields("color_desc").Value)
                var_sa = (rec.Fields("set_angle").Value)
                var_ds = (rec.Fields("count").Value)
                global_val = var_ds

                f_txt = "<font size=" + "'" + "+24" + "'>" + global_val + "</font>"
                If var_ccn = "Orange" Then
                    _StartControl.newLicensing.Text = f_txt
                ElseIf var_ccn = "Red" Then
                    _StartControl.newTotal.Text = f_txt
                End If
                rec.MoveNext()
            Loop

            Dim display_total, var_sum As String
            rec = New ADODB.Recordset
            rec.Open("SELECT SUM(count) FROM `tbl_actual_shit` WHERE date_started = CURDATE() ", con, 1, 2)

            Do While Not rec.EOF
                var_sum = (rec.Fields(0).Value)
                display_total = "<font size=" + "'" + "+24" + "'>" + var_sum + "</font>"
                _StartControl.newTotal.Text = display_total
                rec.MoveNext()
            Loop
            rec.Close()
            '_StartControl.newTricyclePermit.Text = f_txt
            '_StartControl.newWorkingPermit.Text = f_txt
            '_StartControl.newOthers.Text = f_txt
            '_StartControl.newTotal.Text = f_txt
            '_StartControl.newBusinessPermit.Text = f_txt
            '_StartControl.newLicensing.Text = f_txt

        End Sub

        ' Display SORTING_LOGS Table
        Sub SORT_LOG()
            rec = New ADODB.Recordset
            rec.Open("SELECT * FROM `TBL_SORTING_LOGS", con, 1, 2)
            ListView2.Items.Clear()
            Do While Not rec.EOF
                Dim lv As ListViewItem
                lv = ListView2.Items.Add(rec.Fields("ID").Value)
                lv.SubItems.Add(rec.Fields("ctrl_log_number").Value)
                lv.SubItems.Add(rec.Fields("ctrl_count_number").Value)
                lv.SubItems.Add(rec.Fields("start_time").Value)
                lv.SubItems.Add(rec.Fields("pause_time").Value)
                lv.SubItems.Add(rec.Fields("end_time").Value)
                lv.SubItems.Add(rec.Fields("date").Value)
                rec.MoveNext()
            Loop
        End Sub
#End Region


        Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
            'ACTUAL_COUNT()
            loop_display()
        End Sub
    End Class
End Namespace