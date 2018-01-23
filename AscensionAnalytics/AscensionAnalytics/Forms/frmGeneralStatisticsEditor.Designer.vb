<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralStatisticsEditor
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
        Dim grexStatistics_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneralStatisticsEditor))
        Dim grexDevelopedStatistics_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Me.bsDevelopedStatistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStatistics = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmGeneralStatisticsEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.uipmGeneralStatisticsEditor = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.uiPanelStatistics = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel1Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexStatistics = New Janus.Windows.GridEX.GridEX
        Me.uiPanelDevelopment = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel2Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexDevelopedStatistics = New Janus.Windows.GridEX.GridEX
        CType(Me.bsDevelopedStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uipmGeneralStatisticsEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        CType(Me.uiPanelStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanelStatistics.SuspendLayout()
        Me.uiPanel1Container.SuspendLayout()
        CType(Me.grexStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanelDevelopment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanelDevelopment.SuspendLayout()
        Me.uiPanel2Container.SuspendLayout()
        CType(Me.grexDevelopedStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsDevelopedStatistics
        '
        Me.bsDevelopedStatistics.DataMember = "GeneralStatistics_DevelopedStatistics"
        Me.bsDevelopedStatistics.DataSource = Me.bsStatistics
        '
        'bsStatistics
        '
        Me.bsStatistics.DataSource = GetType(AscensionAnalytics.GeneralStatistics_Statistic)
        '
        'vsmGeneralStatisticsEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2010
        Me.vsmGeneralStatisticsEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsCategories
        '
        Me.bsCategories.DataSource = GetType(AscensionAnalytics.GeneralStatistics_Category)
        '
        'uipmGeneralStatisticsEditor
        '
        Me.uipmGeneralStatisticsEditor.ContainerControl = Me
        Me.uipmGeneralStatisticsEditor.VisualStyleManager = Me.vsmGeneralStatisticsEditor
        Me.uiPanel0.Id = New System.Guid("91378846-14d4-4d5a-a0dc-0beaffa24633")
        Me.uiPanel0.StaticGroup = True
        Me.uiPanelStatistics.Id = New System.Guid("991fcbdb-0602-493b-a447-512aa33ecbcd")
        Me.uiPanel0.Panels.Add(Me.uiPanelStatistics)
        Me.uiPanelDevelopment.Id = New System.Guid("2070216b-1ba9-49ed-9197-6d6505107127")
        Me.uiPanel0.Panels.Add(Me.uiPanelDevelopment)
        Me.uipmGeneralStatisticsEditor.Panels.Add(Me.uiPanel0)
        '
        'Design Time Panel Info:
        '
        Me.uipmGeneralStatisticsEditor.BeginPanelInfo()
        Me.uipmGeneralStatisticsEditor.AddDockPanelInfo(New System.Guid("91378846-14d4-4d5a-a0dc-0beaffa24633"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(981, 415), True)
        Me.uipmGeneralStatisticsEditor.AddDockPanelInfo(New System.Guid("991fcbdb-0602-493b-a447-512aa33ecbcd"), New System.Guid("91378846-14d4-4d5a-a0dc-0beaffa24633"), 680, True)
        Me.uipmGeneralStatisticsEditor.AddDockPanelInfo(New System.Guid("2070216b-1ba9-49ed-9197-6d6505107127"), New System.Guid("91378846-14d4-4d5a-a0dc-0beaffa24633"), 297, True)
        Me.uipmGeneralStatisticsEditor.AddFloatingPanelInfo(New System.Guid("91378846-14d4-4d5a-a0dc-0beaffa24633"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmGeneralStatisticsEditor.AddFloatingPanelInfo(New System.Guid("991fcbdb-0602-493b-a447-512aa33ecbcd"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmGeneralStatisticsEditor.AddFloatingPanelInfo(New System.Guid("2070216b-1ba9-49ed-9197-6d6505107127"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmGeneralStatisticsEditor.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.CloseButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles
        Me.uiPanel0.Location = New System.Drawing.Point(3, 3)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(981, 415)
        Me.uiPanel0.TabIndex = 4
        '
        'uiPanelStatistics
        '
        Me.uiPanelStatistics.InnerContainer = Me.uiPanel1Container
        Me.uiPanelStatistics.Location = New System.Drawing.Point(0, 22)
        Me.uiPanelStatistics.Name = "uiPanelStatistics"
        Me.uiPanelStatistics.Size = New System.Drawing.Size(680, 393)
        Me.uiPanelStatistics.TabIndex = 4
        Me.uiPanelStatistics.Text = "Statistics"
        '
        'uiPanel1Container
        '
        Me.uiPanel1Container.Controls.Add(Me.grexStatistics)
        Me.uiPanel1Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel1Container.Name = "uiPanel1Container"
        Me.uiPanel1Container.Size = New System.Drawing.Size(678, 369)
        Me.uiPanel1Container.TabIndex = 0
        '
        'grexStatistics
        '
        Me.grexStatistics.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexStatistics.DataSource = Me.bsStatistics
        grexStatistics_DesignTimeLayout.LayoutString = resources.GetString("grexStatistics_DesignTimeLayout.LayoutString")
        Me.grexStatistics.DesignTimeLayout = grexStatistics_DesignTimeLayout
        Me.grexStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexStatistics.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexStatistics.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexStatistics.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexStatistics.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexStatistics.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexStatistics.Location = New System.Drawing.Point(0, 0)
        Me.grexStatistics.Name = "grexStatistics"
        Me.grexStatistics.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow
        Me.grexStatistics.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexStatistics.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexStatistics.Size = New System.Drawing.Size(678, 369)
        Me.grexStatistics.TabIndex = 0
        Me.grexStatistics.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        Me.grexStatistics.VisualStyleManager = Me.vsmGeneralStatisticsEditor
        '
        'uiPanelDevelopment
        '
        Me.uiPanelDevelopment.InnerContainer = Me.uiPanel2Container
        Me.uiPanelDevelopment.Location = New System.Drawing.Point(684, 22)
        Me.uiPanelDevelopment.Name = "uiPanelDevelopment"
        Me.uiPanelDevelopment.Size = New System.Drawing.Size(297, 393)
        Me.uiPanelDevelopment.TabIndex = 4
        Me.uiPanelDevelopment.Text = "Development"
        '
        'uiPanel2Container
        '
        Me.uiPanel2Container.Controls.Add(Me.grexDevelopedStatistics)
        Me.uiPanel2Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel2Container.Name = "uiPanel2Container"
        Me.uiPanel2Container.Size = New System.Drawing.Size(295, 369)
        Me.uiPanel2Container.TabIndex = 0
        '
        'grexDevelopedStatistics
        '
        Me.grexDevelopedStatistics.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grexDevelopedStatistics.DataSource = Me.bsDevelopedStatistics
        grexDevelopedStatistics_DesignTimeLayout.LayoutString = resources.GetString("grexDevelopedStatistics_DesignTimeLayout.LayoutString")
        Me.grexDevelopedStatistics.DesignTimeLayout = grexDevelopedStatistics_DesignTimeLayout
        Me.grexDevelopedStatistics.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDevelopedStatistics.Location = New System.Drawing.Point(0, 0)
        Me.grexDevelopedStatistics.Name = "grexDevelopedStatistics"
        Me.grexDevelopedStatistics.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDevelopedStatistics.Size = New System.Drawing.Size(295, 369)
        Me.grexDevelopedStatistics.TabIndex = 0
        Me.grexDevelopedStatistics.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        Me.grexDevelopedStatistics.VisualStyleManager = Me.vsmGeneralStatisticsEditor
        '
        'frmGeneralStatisticsEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 421)
        Me.Controls.Add(Me.uiPanel0)
        Me.Name = "frmGeneralStatisticsEditor"
        Me.Text = "General Statistics Editor"
        CType(Me.bsDevelopedStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uipmGeneralStatisticsEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        CType(Me.uiPanelStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanelStatistics.ResumeLayout(False)
        Me.uiPanel1Container.ResumeLayout(False)
        CType(Me.grexStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanelDevelopment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanelDevelopment.ResumeLayout(False)
        Me.uiPanel2Container.ResumeLayout(False)
        CType(Me.grexDevelopedStatistics, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsStatistics As System.Windows.Forms.BindingSource
    Friend WithEvents bsCategories As System.Windows.Forms.BindingSource
    Friend WithEvents bsDevelopedStatistics As System.Windows.Forms.BindingSource
    Friend WithEvents vsmGeneralStatisticsEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents uipmGeneralStatisticsEditor As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents uiPanelStatistics As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel1Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents grexStatistics As Janus.Windows.GridEX.GridEX
    Friend WithEvents uiPanelDevelopment As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel2Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents grexDevelopedStatistics As Janus.Windows.GridEX.GridEX
End Class
