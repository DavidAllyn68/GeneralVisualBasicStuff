<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProviderGrouping
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
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grexProviderGroups_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProviderGrouping))
        Dim grexProviderGroupProviders_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.vsmProviderGrouping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiPanelManagerProviderGrouping = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.pnlMain = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlGroups = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlGroupsContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexProviderGroups = New Janus.Windows.GridEX.GridEX
        Me.bsGroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlProviderRanges = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlProviderRangesContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexProviderGroupProviders = New Janus.Windows.GridEX.GridEX
        Me.bsProviderRanges = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.UiPanelManagerProviderGrouping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMain.SuspendLayout()
        CType(Me.pnlGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGroups.SuspendLayout()
        Me.pnlGroupsContainer.SuspendLayout()
        CType(Me.grexProviderGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlProviderRanges, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlProviderRanges.SuspendLayout()
        Me.pnlProviderRangesContainer.SuspendLayout()
        CType(Me.grexProviderGroupProviders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProviderRanges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmProviderGrouping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmProviderGrouping.ColorSchemes.Add(JanusColorScheme1)
        '
        'UiPanelManagerProviderGrouping
        '
        Me.UiPanelManagerProviderGrouping.AllowPanelDrag = False
        Me.UiPanelManagerProviderGrouping.AllowPanelDrop = False
        Me.UiPanelManagerProviderGrouping.ContainerControl = Me
        Me.UiPanelManagerProviderGrouping.DefaultPanelSettings.CloseButtonVisible = False
        Me.UiPanelManagerProviderGrouping.VisualStyleManager = Me.vsmProviderGrouping
        Me.pnlMain.Id = New System.Guid("bcce8e2d-a1e8-42b6-b92f-a74a9fd159a6")
        Me.pnlMain.StaticGroup = True
        Me.pnlGroups.Id = New System.Guid("001af880-d9b0-4260-876a-366f503a0fd9")
        Me.pnlMain.Panels.Add(Me.pnlGroups)
        Me.pnlProviderRanges.Id = New System.Guid("b79b8240-1247-4c6b-b850-e0f9d74473f1")
        Me.pnlMain.Panels.Add(Me.pnlProviderRanges)
        Me.UiPanelManagerProviderGrouping.Panels.Add(Me.pnlMain)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManagerProviderGrouping.BeginPanelInfo()
        Me.UiPanelManagerProviderGrouping.AddDockPanelInfo(New System.Guid("bcce8e2d-a1e8-42b6-b92f-a74a9fd159a6"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(1039, 510), True)
        Me.UiPanelManagerProviderGrouping.AddDockPanelInfo(New System.Guid("001af880-d9b0-4260-876a-366f503a0fd9"), New System.Guid("bcce8e2d-a1e8-42b6-b92f-a74a9fd159a6"), 488, True)
        Me.UiPanelManagerProviderGrouping.AddDockPanelInfo(New System.Guid("b79b8240-1247-4c6b-b850-e0f9d74473f1"), New System.Guid("bcce8e2d-a1e8-42b6-b92f-a74a9fd159a6"), 488, True)
        Me.UiPanelManagerProviderGrouping.AddFloatingPanelInfo(New System.Guid("bcce8e2d-a1e8-42b6-b92f-a74a9fd159a6"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManagerProviderGrouping.AddFloatingPanelInfo(New System.Guid("001af880-d9b0-4260-876a-366f503a0fd9"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManagerProviderGrouping.AddFloatingPanelInfo(New System.Guid("b79b8240-1247-4c6b-b850-e0f9d74473f1"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManagerProviderGrouping.EndPanelInfo()
        '
        'pnlMain
        '
        Me.pnlMain.Location = New System.Drawing.Point(3, 3)
        Me.pnlMain.Name = "pnlMain"
        Me.pnlMain.Size = New System.Drawing.Size(1039, 510)
        Me.pnlMain.TabIndex = 4
        Me.pnlMain.Text = "Provider Grouping"
        '
        'pnlGroups
        '
        Me.pnlGroups.InnerContainer = Me.pnlGroupsContainer
        Me.pnlGroups.Location = New System.Drawing.Point(0, 22)
        Me.pnlGroups.Name = "pnlGroups"
        Me.pnlGroups.Size = New System.Drawing.Size(1039, 242)
        Me.pnlGroups.TabIndex = 4
        Me.pnlGroups.Text = "Groups"
        '
        'pnlGroupsContainer
        '
        Me.pnlGroupsContainer.Controls.Add(Me.grexProviderGroups)
        Me.pnlGroupsContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlGroupsContainer.Name = "pnlGroupsContainer"
        Me.pnlGroupsContainer.Size = New System.Drawing.Size(1037, 218)
        Me.pnlGroupsContainer.TabIndex = 0
        '
        'grexProviderGroups
        '
        Me.grexProviderGroups.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProviderGroups.DataSource = Me.bsGroups
        grexProviderGroups_DesignTimeLayout.LayoutString = resources.GetString("grexProviderGroups_DesignTimeLayout.LayoutString")
        Me.grexProviderGroups.DesignTimeLayout = grexProviderGroups_DesignTimeLayout
        Me.grexProviderGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexProviderGroups.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexProviderGroups.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexProviderGroups.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexProviderGroups.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexProviderGroups.GroupByBoxVisible = False
        Me.grexProviderGroups.Location = New System.Drawing.Point(0, 0)
        Me.grexProviderGroups.Name = "grexProviderGroups"
        Me.grexProviderGroups.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexProviderGroups.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProviderGroups.Size = New System.Drawing.Size(1037, 218)
        Me.grexProviderGroups.TabIndex = 0
        Me.grexProviderGroups.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexProviderGroups.VisualStyleManager = Me.vsmProviderGrouping
        '
        'bsGroups
        '
        Me.bsGroups.DataSource = GetType(AscensionAnalytics.ProviderGroup)
        '
        'pnlProviderRanges
        '
        Me.pnlProviderRanges.InnerContainer = Me.pnlProviderRangesContainer
        Me.pnlProviderRanges.Location = New System.Drawing.Point(0, 268)
        Me.pnlProviderRanges.Name = "pnlProviderRanges"
        Me.pnlProviderRanges.Size = New System.Drawing.Size(1039, 242)
        Me.pnlProviderRanges.TabIndex = 4
        Me.pnlProviderRanges.Text = "Providers"
        '
        'pnlProviderRangesContainer
        '
        Me.pnlProviderRangesContainer.Controls.Add(Me.grexProviderGroupProviders)
        Me.pnlProviderRangesContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlProviderRangesContainer.Name = "pnlProviderRangesContainer"
        Me.pnlProviderRangesContainer.Size = New System.Drawing.Size(1037, 218)
        Me.pnlProviderRangesContainer.TabIndex = 0
        '
        'grexProviderGroupProviders
        '
        Me.grexProviderGroupProviders.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProviderGroupProviders.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProviderGroupProviders.DataSource = Me.bsProviderRanges
        grexProviderGroupProviders_DesignTimeLayout.LayoutString = resources.GetString("grexProviderGroupProviders_DesignTimeLayout.LayoutString")
        Me.grexProviderGroupProviders.DesignTimeLayout = grexProviderGroupProviders_DesignTimeLayout
        Me.grexProviderGroupProviders.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexProviderGroupProviders.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexProviderGroupProviders.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexProviderGroupProviders.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexProviderGroupProviders.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexProviderGroupProviders.GroupByBoxVisible = False
        Me.grexProviderGroupProviders.Location = New System.Drawing.Point(0, 0)
        Me.grexProviderGroupProviders.Name = "grexProviderGroupProviders"
        Me.grexProviderGroupProviders.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexProviderGroupProviders.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProviderGroupProviders.Size = New System.Drawing.Size(1037, 218)
        Me.grexProviderGroupProviders.TabIndex = 0
        Me.grexProviderGroupProviders.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexProviderGroupProviders.VisualStyleManager = Me.vsmProviderGrouping
        '
        'bsProviderRanges
        '
        Me.bsProviderRanges.DataMember = "ProviderGroupProviders"
        Me.bsProviderRanges.DataSource = Me.bsGroups
        '
        'bsTypes
        '
        Me.bsTypes.DataSource = GetType(AscensionAnalytics.ProviderGroupType)
        '
        'frmProviderGrouping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 516)
        Me.Controls.Add(Me.pnlMain)
        Me.Name = "frmProviderGrouping"
        Me.Text = "Provider Grouping"
        CType(Me.UiPanelManagerProviderGrouping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMain.ResumeLayout(False)
        CType(Me.pnlGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGroups.ResumeLayout(False)
        Me.pnlGroupsContainer.ResumeLayout(False)
        CType(Me.grexProviderGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlProviderRanges, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlProviderRanges.ResumeLayout(False)
        Me.pnlProviderRangesContainer.ResumeLayout(False)
        CType(Me.grexProviderGroupProviders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProviderRanges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmProviderGrouping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiPanelManagerProviderGrouping As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents pnlMain As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlGroups As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlGroupsContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents grexProviderGroups As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsGroups As System.Windows.Forms.BindingSource
    Friend WithEvents pnlProviderRanges As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlProviderRangesContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents bsProviderRanges As System.Windows.Forms.BindingSource
    Friend WithEvents grexProviderGroupProviders As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsTypes As System.Windows.Forms.BindingSource
End Class
