<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDistributionsEditor
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
        Me.components = New System.ComponentModel.Container
        Dim gridExDistributions_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDistributionsEditor))
        Dim gridExDistributionTiers_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.uipmDistributionsEditor = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.pnlDistributionsEditor = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlDistributions = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlDistributionsContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.gridExDistributions = New Janus.Windows.GridEX.GridEX
        Me.bsDistributions = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlDistributionTiers = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlDistributionTiersContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.gridExDistributionTiers = New Janus.Windows.GridEX.GridEX
        Me.bsDistributionTiers = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmDistributionsEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.rsbDistributionsEditor = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.uicmDistributionsEditor = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        CType(Me.uipmDistributionsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDistributionsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDistributionsEditor.SuspendLayout()
        CType(Me.pnlDistributions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDistributions.SuspendLayout()
        Me.pnlDistributionsContainer.SuspendLayout()
        CType(Me.gridExDistributions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDistributions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlDistributionTiers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlDistributionTiers.SuspendLayout()
        Me.pnlDistributionTiersContainer.SuspendLayout()
        CType(Me.gridExDistributionTiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDistributionTiers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uicmDistributionsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uipmDistributionsEditor
        '
        Me.uipmDistributionsEditor.ContainerControl = Me
        Me.uipmDistributionsEditor.VisualStyleManager = Me.vsmDistributionsEditor
        Me.pnlDistributionsEditor.Id = New System.Guid("8dfd488e-c2cf-4622-a841-2b03103a9e1e")
        Me.pnlDistributionsEditor.StaticGroup = True
        Me.pnlDistributions.Id = New System.Guid("5204a0b8-0075-4110-ac03-9ea2f7a78f3e")
        Me.pnlDistributionsEditor.Panels.Add(Me.pnlDistributions)
        Me.pnlDistributionTiers.Id = New System.Guid("05c4803f-2269-4865-a9a0-431080d1c2ad")
        Me.pnlDistributionsEditor.Panels.Add(Me.pnlDistributionTiers)
        Me.uipmDistributionsEditor.Panels.Add(Me.pnlDistributionsEditor)
        '
        'Design Time Panel Info:
        '
        Me.uipmDistributionsEditor.BeginPanelInfo()
        Me.uipmDistributionsEditor.AddDockPanelInfo(New System.Guid("8dfd488e-c2cf-4622-a841-2b03103a9e1e"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(742, 524), True)
        Me.uipmDistributionsEditor.AddDockPanelInfo(New System.Guid("5204a0b8-0075-4110-ac03-9ea2f7a78f3e"), New System.Guid("8dfd488e-c2cf-4622-a841-2b03103a9e1e"), 198, True)
        Me.uipmDistributionsEditor.AddDockPanelInfo(New System.Guid("05c4803f-2269-4865-a9a0-431080d1c2ad"), New System.Guid("8dfd488e-c2cf-4622-a841-2b03103a9e1e"), 300, True)
        Me.uipmDistributionsEditor.AddFloatingPanelInfo(New System.Guid("8dfd488e-c2cf-4622-a841-2b03103a9e1e"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmDistributionsEditor.AddFloatingPanelInfo(New System.Guid("5204a0b8-0075-4110-ac03-9ea2f7a78f3e"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmDistributionsEditor.AddFloatingPanelInfo(New System.Guid("05c4803f-2269-4865-a9a0-431080d1c2ad"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmDistributionsEditor.EndPanelInfo()
        '
        'pnlDistributionsEditor
        '
        Me.pnlDistributionsEditor.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.pnlDistributionsEditor.Location = New System.Drawing.Point(3, 3)
        Me.pnlDistributionsEditor.Name = "pnlDistributionsEditor"
        Me.pnlDistributionsEditor.Size = New System.Drawing.Size(742, 524)
        Me.pnlDistributionsEditor.TabIndex = 4
        Me.pnlDistributionsEditor.Text = "Distributions Editor"
        '
        'pnlDistributions
        '
        Me.pnlDistributions.InnerContainer = Me.pnlDistributionsContainer
        Me.pnlDistributions.Location = New System.Drawing.Point(0, 22)
        Me.pnlDistributions.Name = "pnlDistributions"
        Me.pnlDistributions.Size = New System.Drawing.Size(742, 198)
        Me.pnlDistributions.TabIndex = 4
        Me.pnlDistributions.Text = "Distributions"
        '
        'pnlDistributionsContainer
        '
        Me.pnlDistributionsContainer.Controls.Add(Me.gridExDistributions)
        Me.pnlDistributionsContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlDistributionsContainer.Name = "pnlDistributionsContainer"
        Me.pnlDistributionsContainer.Size = New System.Drawing.Size(740, 174)
        Me.pnlDistributionsContainer.TabIndex = 0
        '
        'gridExDistributions
        '
        Me.gridExDistributions.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExDistributions.DataSource = Me.bsDistributions
        gridExDistributions_DesignTimeLayout.LayoutString = resources.GetString("gridExDistributions_DesignTimeLayout.LayoutString")
        Me.gridExDistributions.DesignTimeLayout = gridExDistributions_DesignTimeLayout
        Me.gridExDistributions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExDistributions.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExDistributions.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExDistributions.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExDistributions.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExDistributions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gridExDistributions.GroupByBoxVisible = False
        Me.gridExDistributions.Location = New System.Drawing.Point(0, 0)
        Me.gridExDistributions.Name = "gridExDistributions"
        Me.gridExDistributions.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExDistributions.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExDistributions.Size = New System.Drawing.Size(740, 174)
        Me.gridExDistributions.TabIndex = 0
        Me.gridExDistributions.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate
        Me.gridExDistributions.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExDistributions.VisualStyleManager = Me.vsmDistributionsEditor
        '
        'bsDistributions
        '
        Me.bsDistributions.DataSource = GetType(AscensionAnalytics.Distribution)
        Me.bsDistributions.Sort = "DistributionName"
        '
        'pnlDistributionTiers
        '
        Me.pnlDistributionTiers.InnerContainer = Me.pnlDistributionTiersContainer
        Me.pnlDistributionTiers.Location = New System.Drawing.Point(0, 224)
        Me.pnlDistributionTiers.Name = "pnlDistributionTiers"
        Me.pnlDistributionTiers.Size = New System.Drawing.Size(742, 300)
        Me.pnlDistributionTiers.TabIndex = 4
        Me.pnlDistributionTiers.Text = "Distriubtion Tiers"
        '
        'pnlDistributionTiersContainer
        '
        Me.pnlDistributionTiersContainer.Controls.Add(Me.gridExDistributionTiers)
        Me.pnlDistributionTiersContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlDistributionTiersContainer.Name = "pnlDistributionTiersContainer"
        Me.pnlDistributionTiersContainer.Size = New System.Drawing.Size(740, 276)
        Me.pnlDistributionTiersContainer.TabIndex = 0
        '
        'gridExDistributionTiers
        '
        Me.gridExDistributionTiers.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExDistributionTiers.DataMember = Nothing
        Me.gridExDistributionTiers.DataSource = Me.bsDistributionTiers
        gridExDistributionTiers_DesignTimeLayout.LayoutString = resources.GetString("gridExDistributionTiers_DesignTimeLayout.LayoutString")
        Me.gridExDistributionTiers.DesignTimeLayout = gridExDistributionTiers_DesignTimeLayout
        Me.gridExDistributionTiers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExDistributionTiers.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExDistributionTiers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExDistributionTiers.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExDistributionTiers.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExDistributionTiers.GroupByBoxVisible = False
        Me.gridExDistributionTiers.Location = New System.Drawing.Point(0, 0)
        Me.gridExDistributionTiers.Name = "gridExDistributionTiers"
        Me.gridExDistributionTiers.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToFirstCellInNewRow
        Me.gridExDistributionTiers.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExDistributionTiers.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExDistributionTiers.Size = New System.Drawing.Size(740, 276)
        Me.gridExDistributionTiers.TabIndex = 0
        Me.gridExDistributionTiers.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExDistributionTiers.VisualStyleManager = Me.vsmDistributionsEditor
        '
        'bsDistributionTiers
        '
        Me.bsDistributionTiers.DataMember = "DistributionTiers"
        Me.bsDistributionTiers.DataSource = Me.bsDistributions
        Me.bsDistributionTiers.Sort = "SortOrder"
        '
        'vsmDistributionsEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDistributionsEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'rsbDistributionsEditor
        '
        Me.rsbDistributionsEditor.ImageSize = New System.Drawing.Size(16, 16)
        Me.rsbDistributionsEditor.Location = New System.Drawing.Point(0, 530)
        Me.rsbDistributionsEditor.Name = "rsbDistributionsEditor"
        Me.rsbDistributionsEditor.OfficeCustomColor = System.Drawing.Color.Empty
        Me.rsbDistributionsEditor.Size = New System.Drawing.Size(748, 23)
        '
        '
        '
        Me.rsbDistributionsEditor.SuperTipComponent.AutoPopDelay = 2000
        Me.rsbDistributionsEditor.SuperTipComponent.ImageList = Nothing
        Me.rsbDistributionsEditor.TabIndex = 4
        Me.rsbDistributionsEditor.Text = "RibbonStatusBar1"
        Me.rsbDistributionsEditor.UseCompatibleTextRendering = False
        '
        'uicmDistributionsEditor
        '
        Me.uicmDistributionsEditor.BottomRebar = Me.BottomRebar1
        Me.uicmDistributionsEditor.ContainerControl = Me
        Me.uicmDistributionsEditor.Id = New System.Guid("451f497d-71f9-44e6-b717-7ea93882fdeb")
        Me.uicmDistributionsEditor.LeftRebar = Me.LeftRebar1
        Me.uicmDistributionsEditor.RightRebar = Me.RightRebar1
        Me.uicmDistributionsEditor.TopRebar = Me.TopRebar1
        Me.uicmDistributionsEditor.VisualStyleManager = Me.vsmDistributionsEditor
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmDistributionsEditor
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 553)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(748, 0)
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmDistributionsEditor
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 553)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmDistributionsEditor
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(748, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 553)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.uicmDistributionsEditor
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(748, 0)
        '
        'frmDistributionsEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 553)
        Me.Controls.Add(Me.pnlDistributionsEditor)
        Me.Controls.Add(Me.rsbDistributionsEditor)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmDistributionsEditor"
        Me.Text = "Distributions Editor"
        CType(Me.uipmDistributionsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDistributionsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDistributionsEditor.ResumeLayout(False)
        CType(Me.pnlDistributions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDistributions.ResumeLayout(False)
        Me.pnlDistributionsContainer.ResumeLayout(False)
        CType(Me.gridExDistributions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDistributions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlDistributionTiers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlDistributionTiers.ResumeLayout(False)
        Me.pnlDistributionTiersContainer.ResumeLayout(False)
        CType(Me.gridExDistributionTiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDistributionTiers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uicmDistributionsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uipmDistributionsEditor As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents vsmDistributionsEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents rsbDistributionsEditor As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents uicmDistributionsEditor As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents pnlDistributionsEditor As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlDistributions As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlDistributionsContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents pnlDistributionTiers As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlDistributionTiersContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents gridExDistributions As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDistributions As System.Windows.Forms.BindingSource
    Friend WithEvents gridExDistributionTiers As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDistributionTiers As System.Windows.Forms.BindingSource
End Class
