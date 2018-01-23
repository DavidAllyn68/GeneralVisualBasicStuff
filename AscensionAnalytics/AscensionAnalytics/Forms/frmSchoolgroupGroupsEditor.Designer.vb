<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolgroupGroupsEditor
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
        Dim gridExSchoolgroupGroups_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolgroupGroupsEditor))
        Dim grexSchoolgroups_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.vsmSchoolgroupGroupsEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.uicmSchoolgroupGroupsEditor = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.uipmSchoolgroupGroupsEditor = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.pnlSchoolgroupGroups = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlGroups = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlGroupsContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.gridExSchoolgroupGroups = New Janus.Windows.GridEX.GridEX
        Me.bsSchoolgroupGroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlAssociatedSchoolgroups = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlAssociatedSchoolgroupsContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexSchoolgroups = New Janus.Windows.GridEX.GridEX
        Me.bsAssociatedSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.uicmSchoolgroupGroupsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uipmSchoolgroupGroupsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlSchoolgroupGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSchoolgroupGroups.SuspendLayout()
        CType(Me.pnlGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGroups.SuspendLayout()
        Me.pnlGroupsContainer.SuspendLayout()
        CType(Me.gridExSchoolgroupGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlAssociatedSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAssociatedSchoolgroups.SuspendLayout()
        Me.pnlAssociatedSchoolgroupsContainer.SuspendLayout()
        CType(Me.grexSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssociatedSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmSchoolgroupGroupsEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmSchoolgroupGroupsEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'uicmSchoolgroupGroupsEditor
        '
        Me.uicmSchoolgroupGroupsEditor.BottomRebar = Me.BottomRebar1
        Me.uicmSchoolgroupGroupsEditor.ContainerControl = Me
        '
        '
        '
        Me.uicmSchoolgroupGroupsEditor.EditContextMenu.Key = ""
        Me.uicmSchoolgroupGroupsEditor.Id = New System.Guid("cd643554-e9f9-467a-aa34-4a1833c00704")
        Me.uicmSchoolgroupGroupsEditor.LeftRebar = Me.LeftRebar1
        Me.uicmSchoolgroupGroupsEditor.RightRebar = Me.RightRebar1
        Me.uicmSchoolgroupGroupsEditor.TopRebar = Me.TopRebar1
        Me.uicmSchoolgroupGroupsEditor.VisualStyleManager = Me.vsmSchoolgroupGroupsEditor
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmSchoolgroupGroupsEditor
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 539)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(959, 0)
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmSchoolgroupGroupsEditor
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 539)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmSchoolgroupGroupsEditor
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(959, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 539)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.uicmSchoolgroupGroupsEditor
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(959, 0)
        '
        'uipmSchoolgroupGroupsEditor
        '
        Me.uipmSchoolgroupGroupsEditor.ContainerControl = Me
        Me.uipmSchoolgroupGroupsEditor.VisualStyleManager = Me.vsmSchoolgroupGroupsEditor
        Me.pnlSchoolgroupGroups.Id = New System.Guid("ba828b7f-50f7-420f-93be-a152b5094252")
        Me.pnlSchoolgroupGroups.StaticGroup = True
        Me.pnlGroups.Id = New System.Guid("d05c65fb-9326-4b97-8b14-2942d48e9539")
        Me.pnlSchoolgroupGroups.Panels.Add(Me.pnlGroups)
        Me.pnlAssociatedSchoolgroups.Id = New System.Guid("65e22c05-c901-4f53-80b7-6c287e738001")
        Me.pnlSchoolgroupGroups.Panels.Add(Me.pnlAssociatedSchoolgroups)
        Me.uipmSchoolgroupGroupsEditor.Panels.Add(Me.pnlSchoolgroupGroups)
        '
        'Design Time Panel Info:
        '
        Me.uipmSchoolgroupGroupsEditor.BeginPanelInfo()
        Me.uipmSchoolgroupGroupsEditor.AddDockPanelInfo(New System.Guid("ba828b7f-50f7-420f-93be-a152b5094252"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(953, 533), True)
        Me.uipmSchoolgroupGroupsEditor.AddDockPanelInfo(New System.Guid("d05c65fb-9326-4b97-8b14-2942d48e9539"), New System.Guid("ba828b7f-50f7-420f-93be-a152b5094252"), 523, True)
        Me.uipmSchoolgroupGroupsEditor.AddDockPanelInfo(New System.Guid("65e22c05-c901-4f53-80b7-6c287e738001"), New System.Guid("ba828b7f-50f7-420f-93be-a152b5094252"), 426, True)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("ba828b7f-50f7-420f-93be-a152b5094252"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("d05c65fb-9326-4b97-8b14-2942d48e9539"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("09888ef0-b4b7-4923-8ae4-e6d861a3302f"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("776e75c0-3993-4b72-8fab-2fcc67e5be37"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("d966ee7e-fc8e-4f4d-a294-97b80ce361f4"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.AddFloatingPanelInfo(New System.Guid("65e22c05-c901-4f53-80b7-6c287e738001"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmSchoolgroupGroupsEditor.EndPanelInfo()
        '
        'pnlSchoolgroupGroups
        '
        Me.pnlSchoolgroupGroups.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.pnlSchoolgroupGroups.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles
        Me.pnlSchoolgroupGroups.Location = New System.Drawing.Point(3, 3)
        Me.pnlSchoolgroupGroups.Name = "pnlSchoolgroupGroups"
        Me.pnlSchoolgroupGroups.Size = New System.Drawing.Size(953, 533)
        Me.pnlSchoolgroupGroups.TabIndex = 4
        Me.pnlSchoolgroupGroups.Text = "Schoolgroup Groups"
        '
        'pnlGroups
        '
        Me.pnlGroups.InnerContainer = Me.pnlGroupsContainer
        Me.pnlGroups.Location = New System.Drawing.Point(0, 22)
        Me.pnlGroups.Name = "pnlGroups"
        Me.pnlGroups.Size = New System.Drawing.Size(523, 511)
        Me.pnlGroups.TabIndex = 4
        Me.pnlGroups.Text = "Groupings"
        '
        'pnlGroupsContainer
        '
        Me.pnlGroupsContainer.Controls.Add(Me.gridExSchoolgroupGroups)
        Me.pnlGroupsContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlGroupsContainer.Name = "pnlGroupsContainer"
        Me.pnlGroupsContainer.Size = New System.Drawing.Size(521, 487)
        Me.pnlGroupsContainer.TabIndex = 0
        '
        'gridExSchoolgroupGroups
        '
        Me.gridExSchoolgroupGroups.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExSchoolgroupGroups.DataSource = Me.bsSchoolgroupGroups
        gridExSchoolgroupGroups_DesignTimeLayout.LayoutString = resources.GetString("gridExSchoolgroupGroups_DesignTimeLayout.LayoutString")
        Me.gridExSchoolgroupGroups.DesignTimeLayout = gridExSchoolgroupGroups_DesignTimeLayout
        Me.gridExSchoolgroupGroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExSchoolgroupGroups.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExSchoolgroupGroups.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExSchoolgroupGroups.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExSchoolgroupGroups.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExSchoolgroupGroups.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.gridExSchoolgroupGroups.Location = New System.Drawing.Point(0, 0)
        Me.gridExSchoolgroupGroups.Name = "gridExSchoolgroupGroups"
        Me.gridExSchoolgroupGroups.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExSchoolgroupGroups.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExSchoolgroupGroups.Size = New System.Drawing.Size(521, 487)
        Me.gridExSchoolgroupGroups.TabIndex = 0
        Me.gridExSchoolgroupGroups.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExSchoolgroupGroups.VisualStyleManager = Me.vsmSchoolgroupGroupsEditor
        '
        'bsSchoolgroupGroups
        '
        Me.bsSchoolgroupGroups.DataSource = GetType(AscensionAnalytics.schoolgroup_group)
        '
        'pnlAssociatedSchoolgroups
        '
        Me.pnlAssociatedSchoolgroups.InnerContainer = Me.pnlAssociatedSchoolgroupsContainer
        Me.pnlAssociatedSchoolgroups.Location = New System.Drawing.Point(527, 22)
        Me.pnlAssociatedSchoolgroups.Name = "pnlAssociatedSchoolgroups"
        Me.pnlAssociatedSchoolgroups.Size = New System.Drawing.Size(426, 511)
        Me.pnlAssociatedSchoolgroups.TabIndex = 4
        Me.pnlAssociatedSchoolgroups.Text = "Associated Schoolgroups"
        '
        'pnlAssociatedSchoolgroupsContainer
        '
        Me.pnlAssociatedSchoolgroupsContainer.Controls.Add(Me.grexSchoolgroups)
        Me.pnlAssociatedSchoolgroupsContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlAssociatedSchoolgroupsContainer.Name = "pnlAssociatedSchoolgroupsContainer"
        Me.pnlAssociatedSchoolgroupsContainer.Size = New System.Drawing.Size(424, 487)
        Me.pnlAssociatedSchoolgroupsContainer.TabIndex = 0
        '
        'grexSchoolgroups
        '
        Me.grexSchoolgroups.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.DataSource = Me.bsAssociatedSchoolgroups
        grexSchoolgroups_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolgroups_DesignTimeLayout.LayoutString")
        Me.grexSchoolgroups.DesignTimeLayout = grexSchoolgroups_DesignTimeLayout
        Me.grexSchoolgroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolgroups.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolgroups.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolgroups.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grexSchoolgroups.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexSchoolgroups.GroupByBoxVisible = False
        Me.grexSchoolgroups.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexSchoolgroups.Location = New System.Drawing.Point(0, 0)
        Me.grexSchoolgroups.Name = "grexSchoolgroups"
        Me.grexSchoolgroups.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexSchoolgroups.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.Size = New System.Drawing.Size(424, 487)
        Me.grexSchoolgroups.TabIndex = 0
        Me.grexSchoolgroups.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolgroups.VisualStyleManager = Me.vsmSchoolgroupGroupsEditor
        '
        'bsAssociatedSchoolgroups
        '
        Me.bsAssociatedSchoolgroups.DataMember = "schoolgroup_group_x_schoolgroups"
        Me.bsAssociatedSchoolgroups.DataSource = Me.bsSchoolgroupGroups
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.schoolgroup_group_schoolgroups)
        '
        'frmSchoolgroupGroupsEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(959, 539)
        Me.Controls.Add(Me.pnlSchoolgroupGroups)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmSchoolgroupGroupsEditor"
        Me.Text = "Schoolgroup Groups"
        CType(Me.uicmSchoolgroupGroupsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uipmSchoolgroupGroupsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlSchoolgroupGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSchoolgroupGroups.ResumeLayout(False)
        CType(Me.pnlGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGroups.ResumeLayout(False)
        Me.pnlGroupsContainer.ResumeLayout(False)
        CType(Me.gridExSchoolgroupGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupGroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlAssociatedSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAssociatedSchoolgroups.ResumeLayout(False)
        Me.pnlAssociatedSchoolgroupsContainer.ResumeLayout(False)
        CType(Me.grexSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssociatedSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmSchoolgroupGroupsEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents uicmSchoolgroupGroupsEditor As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents uipmSchoolgroupGroupsEditor As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents pnlSchoolgroupGroups As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlGroups As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlGroupsContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents gridExSchoolgroupGroups As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsSchoolgroupGroups As System.Windows.Forms.BindingSource
    Friend WithEvents pnlAssociatedSchoolgroups As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlAssociatedSchoolgroupsContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents grexSchoolgroups As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsAssociatedSchoolgroups As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
End Class
