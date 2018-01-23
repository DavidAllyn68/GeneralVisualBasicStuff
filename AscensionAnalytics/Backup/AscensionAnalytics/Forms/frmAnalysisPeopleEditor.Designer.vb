<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisPeopleEditor
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
        Dim gridExAnalysisPeople_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisPeopleEditor))
        Me.vsmAnalysisPeopleEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.uipmAnalysisPeopleEditor = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.pnlAnalysisPeople = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlAnalysisPeopleContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.gridExAnalysisPeople = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisPeople = New System.Windows.Forms.BindingSource(Me.components)
        Me.uicmAnalysisPeopleEditor = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.bsAnalysisPeoplePersonTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.uipmAnalysisPeopleEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlAnalysisPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlAnalysisPeople.SuspendLayout()
        Me.pnlAnalysisPeopleContainer.SuspendLayout()
        CType(Me.gridExAnalysisPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uicmAnalysisPeopleEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisPeoplePersonTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAnalysisPeopleEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnalysisPeopleEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'uipmAnalysisPeopleEditor
        '
        Me.uipmAnalysisPeopleEditor.ContainerControl = Me
        Me.uipmAnalysisPeopleEditor.VisualStyleManager = Me.vsmAnalysisPeopleEditor
        Me.pnlAnalysisPeople.Id = New System.Guid("32832e3c-3891-4371-895e-04645f8a348d")
        Me.uipmAnalysisPeopleEditor.Panels.Add(Me.pnlAnalysisPeople)
        '
        'Design Time Panel Info:
        '
        Me.uipmAnalysisPeopleEditor.BeginPanelInfo()
        Me.uipmAnalysisPeopleEditor.AddDockPanelInfo(New System.Guid("32832e3c-3891-4371-895e-04645f8a348d"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, New System.Drawing.Size(1027, 256), True)
        Me.uipmAnalysisPeopleEditor.AddFloatingPanelInfo(New System.Guid("32832e3c-3891-4371-895e-04645f8a348d"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisPeopleEditor.EndPanelInfo()
        '
        'pnlAnalysisPeople
        '
        Me.pnlAnalysisPeople.InnerContainer = Me.pnlAnalysisPeopleContainer
        Me.pnlAnalysisPeople.Location = New System.Drawing.Point(3, 3)
        Me.pnlAnalysisPeople.Name = "pnlAnalysisPeople"
        Me.pnlAnalysisPeople.Size = New System.Drawing.Size(1027, 256)
        Me.pnlAnalysisPeople.TabIndex = 4
        Me.pnlAnalysisPeople.Text = "Analysis People"
        '
        'pnlAnalysisPeopleContainer
        '
        Me.pnlAnalysisPeopleContainer.Controls.Add(Me.gridExAnalysisPeople)
        Me.pnlAnalysisPeopleContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlAnalysisPeopleContainer.Name = "pnlAnalysisPeopleContainer"
        Me.pnlAnalysisPeopleContainer.Size = New System.Drawing.Size(1025, 232)
        Me.pnlAnalysisPeopleContainer.TabIndex = 0
        '
        'gridExAnalysisPeople
        '
        Me.gridExAnalysisPeople.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisPeople.CardSpacing = 15
        Me.gridExAnalysisPeople.CardViewGridlines = Janus.Windows.GridEX.CardViewGridlines.FieldsOnly
        Me.gridExAnalysisPeople.DataSource = Me.bsAnalysisPeople
        gridExAnalysisPeople_DesignTimeLayout.LayoutString = resources.GetString("gridExAnalysisPeople_DesignTimeLayout.LayoutString")
        Me.gridExAnalysisPeople.DesignTimeLayout = gridExAnalysisPeople_DesignTimeLayout
        Me.gridExAnalysisPeople.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExAnalysisPeople.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExAnalysisPeople.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExAnalysisPeople.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExAnalysisPeople.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExAnalysisPeople.GroupByBoxVisible = False
        Me.gridExAnalysisPeople.Location = New System.Drawing.Point(0, 0)
        Me.gridExAnalysisPeople.Name = "gridExAnalysisPeople"
        Me.gridExAnalysisPeople.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExAnalysisPeople.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisPeople.Size = New System.Drawing.Size(1025, 232)
        Me.gridExAnalysisPeople.TabIndex = 0
        Me.gridExAnalysisPeople.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExAnalysisPeople.VisualStyleManager = Me.vsmAnalysisPeopleEditor
        '
        'bsAnalysisPeople
        '
        Me.bsAnalysisPeople.DataSource = GetType(AscensionAnalytics.AnalysisRequestPeople)
        '
        'uicmAnalysisPeopleEditor
        '
        Me.uicmAnalysisPeopleEditor.BottomRebar = Me.BottomRebar1
        Me.uicmAnalysisPeopleEditor.ContainerControl = Me
        Me.uicmAnalysisPeopleEditor.Id = New System.Guid("c898313c-5bdb-4a77-8077-c1e21648e437")
        Me.uicmAnalysisPeopleEditor.LeftRebar = Me.LeftRebar1
        Me.uicmAnalysisPeopleEditor.RightRebar = Me.RightRebar1
        Me.uicmAnalysisPeopleEditor.TopRebar = Me.TopRebar1
        Me.uicmAnalysisPeopleEditor.VisualStyleManager = Me.vsmAnalysisPeopleEditor
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmAnalysisPeopleEditor
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 262)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(1033, 0)
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmAnalysisPeopleEditor
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 262)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmAnalysisPeopleEditor
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(1033, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 262)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.uicmAnalysisPeopleEditor
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1033, 0)
        '
        'bsAnalysisPeoplePersonTypes
        '
        Me.bsAnalysisPeoplePersonTypes.DataSource = GetType(AscensionAnalytics.AnalysisPeople_PersonType)
        '
        'frmAnalysisPeopleEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 262)
        Me.Controls.Add(Me.pnlAnalysisPeople)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmAnalysisPeopleEditor"
        Me.Text = "Analysis People"
        CType(Me.uipmAnalysisPeopleEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlAnalysisPeople, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlAnalysisPeople.ResumeLayout(False)
        Me.pnlAnalysisPeopleContainer.ResumeLayout(False)
        CType(Me.gridExAnalysisPeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisPeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uicmAnalysisPeopleEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisPeoplePersonTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAnalysisPeopleEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents uipmAnalysisPeopleEditor As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uicmAnalysisPeopleEditor As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents pnlAnalysisPeople As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlAnalysisPeopleContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents gridExAnalysisPeople As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsAnalysisPeople As System.Windows.Forms.BindingSource
    Friend WithEvents bsAnalysisPeoplePersonTypes As System.Windows.Forms.BindingSource
End Class
