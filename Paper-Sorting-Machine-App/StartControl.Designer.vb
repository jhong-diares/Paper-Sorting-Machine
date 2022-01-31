Namespace PaperSortingMachine
    Partial Public Class StartControl
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

#Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.labelX1 = New DevComponents.DotNetBar.LabelX()
            Me.itemPanel1 = New DevComponents.DotNetBar.ItemPanel()
            Me.itemContainer1 = New DevComponents.DotNetBar.ItemContainer()
            Me.newWorkingPermit = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.newOthers = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.newBusinessPermit = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.newTricyclePermit = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.newTotal = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.newLicensing = New DevComponents.DotNetBar.Metro.MetroTileItem()
            Me.Button1 = New System.Windows.Forms.Button()
            Me.Button2 = New System.Windows.Forms.Button()
            Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
            Me.Button3 = New System.Windows.Forms.Button()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.Label2 = New System.Windows.Forms.Label()
            Me.SuspendLayout()
            '
            'labelX1
            '
            '
            '
            '
            Me.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.labelX1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.labelX1.Location = New System.Drawing.Point(25, 14)
            Me.labelX1.Name = "labelX1"
            Me.labelX1.Size = New System.Drawing.Size(243, 82)
            Me.labelX1.TabIndex = 2
            Me.labelX1.Text = "PAPER <strong>SORTING MACHINE</strong>"
            '
            'itemPanel1
            '
            Me.itemPanel1.AutoScroll = True
            '
            '
            '
            Me.itemPanel1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemPanel1.ContainerControlProcessDialogKey = True
            Me.itemPanel1.DragDropSupport = True
            Me.itemPanel1.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.itemContainer1})
            Me.itemPanel1.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F"
            Me.itemPanel1.Location = New System.Drawing.Point(25, 153)
            Me.itemPanel1.Name = "itemPanel1"
            Me.itemPanel1.ReserveLeftSpace = False
            Me.itemPanel1.Size = New System.Drawing.Size(572, 297)
            Me.itemPanel1.TabIndex = 3
            Me.itemPanel1.Text = "itemPanel1"
            '
            'itemContainer1
            '
            '
            '
            '
            Me.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.itemContainer1.ItemSpacing = 6
            Me.itemContainer1.MinimumSize = New System.Drawing.Size(560, 290)
            Me.itemContainer1.MultiLine = True
            Me.itemContainer1.Name = "itemContainer1"
            Me.itemContainer1.ResizeItemsToFit = False
            Me.itemContainer1.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.newWorkingPermit, Me.newOthers, Me.newBusinessPermit, Me.newTricyclePermit, Me.newTotal, Me.newLicensing})
            '
            '
            '
            Me.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            '
            '
            Me.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            '
            'newWorkingPermit
            '
            Me.newWorkingPermit.Image = Global.My.Resources.Resources.Invoice
            Me.newWorkingPermit.Name = "newWorkingPermit"
            Me.newWorkingPermit.SymbolColor = System.Drawing.Color.Empty
            Me.newWorkingPermit.Text = "<font size=""+24"">0</font>"
            Me.newWorkingPermit.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blue
            '
            '
            '
            Me.newWorkingPermit.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newWorkingPermit.TitleText = "Working Permit"
            '
            'newOthers
            '
            Me.newOthers.Image = Global.My.Resources.Resources.Invoice
            Me.newOthers.Name = "newOthers"
            Me.newOthers.SymbolColor = System.Drawing.Color.Empty
            Me.newOthers.Text = "<font size=""+24"">0</font>"
            Me.newOthers.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Blueish
            '
            '
            '
            Me.newOthers.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newOthers.TitleText = "Others"
            '
            'newBusinessPermit
            '
            Me.newBusinessPermit.Image = Global.My.Resources.Resources.Invoice
            Me.newBusinessPermit.Name = "newBusinessPermit"
            Me.newBusinessPermit.SymbolColor = System.Drawing.Color.Empty
            Me.newBusinessPermit.Text = "<font size=""+24"">0</font>"
            Me.newBusinessPermit.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Yellow
            '
            '
            '
            Me.newBusinessPermit.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newBusinessPermit.TitleText = "Business Permit"
            '
            'newTricyclePermit
            '
            Me.newTricyclePermit.Image = Global.My.Resources.Resources.Invoice
            Me.newTricyclePermit.Name = "newTricyclePermit"
            Me.newTricyclePermit.SymbolColor = System.Drawing.Color.Empty
            Me.newTricyclePermit.Text = "<font size=""+24"">0</font>"
            Me.newTricyclePermit.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Green
            '
            '
            '
            Me.newTricyclePermit.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newTricyclePermit.TitleText = "Tricycle Permit"
            '
            'newTotal
            '
            Me.newTotal.Image = Global.My.Resources.Resources.TableReportt1
            Me.newTotal.Name = "newTotal"
            Me.newTotal.SymbolColor = System.Drawing.Color.Empty
            Me.newTotal.Text = "<u><font size=""+24"">0</font></u>"
            Me.newTotal.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.RedOrange
            '
            '
            '
            Me.newTotal.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newTotal.TitleText = "Total"
            '
            'newLicensing
            '
            Me.newLicensing.Image = Global.My.Resources.Resources.Invoice
            Me.newLicensing.Name = "newLicensing"
            Me.newLicensing.SymbolColor = System.Drawing.Color.Empty
            Me.newLicensing.Text = "<font size=""+24"">0</font>"
            Me.newLicensing.TileColor = DevComponents.DotNetBar.Metro.eMetroTileColor.Orange
            '
            '
            '
            Me.newLicensing.TileStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.newLicensing.TitleText = "Licensing"
            '
            'Button1
            '
            Me.Button1.Location = New System.Drawing.Point(313, 364)
            Me.Button1.Name = "Button1"
            Me.Button1.Size = New System.Drawing.Size(75, 23)
            Me.Button1.TabIndex = 4
            Me.Button1.Text = "START"
            Me.Button1.UseVisualStyleBackColor = True
            '
            'Button2
            '
            Me.Button2.Location = New System.Drawing.Point(394, 364)
            Me.Button2.Name = "Button2"
            Me.Button2.Size = New System.Drawing.Size(75, 23)
            Me.Button2.TabIndex = 5
            Me.Button2.Text = "PAUSE"
            Me.Button2.UseVisualStyleBackColor = True
            '
            'LabelX2
            '
            '
            '
            '
            Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
            Me.LabelX2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
            Me.LabelX2.Location = New System.Drawing.Point(642, 38)
            Me.LabelX2.Name = "LabelX2"
            Me.LabelX2.Size = New System.Drawing.Size(10, 33)
            Me.LabelX2.TabIndex = 7
            Me.LabelX2.TextAlignment = System.Drawing.StringAlignment.Far
            Me.LabelX2.TextLineAlignment = System.Drawing.StringAlignment.Far
            Me.LabelX2.Visible = False
            '
            'Button3
            '
            Me.Button3.Location = New System.Drawing.Point(477, 364)
            Me.Button3.Name = "Button3"
            Me.Button3.Size = New System.Drawing.Size(75, 23)
            Me.Button3.TabIndex = 8
            Me.Button3.Text = "END"
            Me.Button3.UseVisualStyleBackColor = True
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!)
            Me.Label1.Location = New System.Drawing.Point(432, 120)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(132, 30)
            Me.Label1.TabIndex = 9
            Me.Label1.Text = "DATE TODAY"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomRight
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(601, 83)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(0, 13)
            Me.Label2.TabIndex = 10
            Me.Label2.Visible = False
            '
            'StartControl
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.Button3)
            Me.Controls.Add(Me.LabelX2)
            Me.Controls.Add(Me.Button2)
            Me.Controls.Add(Me.Button1)
            Me.Controls.Add(Me.labelX1)
            Me.Controls.Add(Me.itemPanel1)
            Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "StartControl"
            Me.Size = New System.Drawing.Size(667, 453)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private labelX1 As DevComponents.DotNetBar.LabelX
        Private itemPanel1 As DevComponents.DotNetBar.ItemPanel
        Private itemContainer1 As DevComponents.DotNetBar.ItemContainer
        Friend WithEvents newBusinessPermit As DevComponents.DotNetBar.Metro.MetroTileItem
        Friend WithEvents newTotal As DevComponents.DotNetBar.Metro.MetroTileItem
        Friend WithEvents newOthers As DevComponents.DotNetBar.Metro.MetroTileItem
        Friend WithEvents Button1 As System.Windows.Forms.Button
        Friend WithEvents Button2 As System.Windows.Forms.Button
        Private WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
        Friend WithEvents Button3 As System.Windows.Forms.Button
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents newTricyclePermit As DevComponents.DotNetBar.Metro.MetroTileItem
        Friend WithEvents newLicensing As DevComponents.DotNetBar.Metro.MetroTileItem
        Friend WithEvents newWorkingPermit As DevComponents.DotNetBar.Metro.MetroTileItem
    End Class
End Namespace
