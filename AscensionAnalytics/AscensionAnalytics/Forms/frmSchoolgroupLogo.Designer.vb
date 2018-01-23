<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolgroupLogo
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
        Dim grexSchoolgroups_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolgroupLogo))
        Me.vsmSchoolgroupLogo = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.pnlMgrSchoolgroupLogo = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.pnlGrpMain = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlSchoolgroups = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlSchoolgroupsContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexSchoolgroups = New Janus.Windows.GridEX.GridEX
        Me.bsSchoolgroupLogo = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlLogo = New Janus.Windows.UI.Dock.UIPanel
        Me.pnlLogoContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.cmdBtnPickImage = New Janus.Windows.EditControls.UIButton
        Me.pixLogo = New System.Windows.Forms.PictureBox
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.pnlMgrSchoolgroupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlGrpMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlGrpMain.SuspendLayout()
        CType(Me.pnlSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlSchoolgroups.SuspendLayout()
        Me.pnlSchoolgroupsContainer.SuspendLayout()
        CType(Me.grexSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogo.SuspendLayout()
        Me.pnlLogoContainer.SuspendLayout()
        CType(Me.pixLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmSchoolgroupLogo
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmSchoolgroupLogo.ColorSchemes.Add(JanusColorScheme1)
        '
        'pnlMgrSchoolgroupLogo
        '
        Me.pnlMgrSchoolgroupLogo.ContainerControl = Me
        Me.pnlMgrSchoolgroupLogo.VisualStyleManager = Me.vsmSchoolgroupLogo
        Me.pnlGrpMain.Id = New System.Guid("47cb51a0-7ecb-4a61-a61c-b36aefc7c918")
        Me.pnlGrpMain.StaticGroup = True
        Me.pnlSchoolgroups.Id = New System.Guid("54718a2f-ca88-4b6e-b89f-b33ff6691424")
        Me.pnlGrpMain.Panels.Add(Me.pnlSchoolgroups)
        Me.pnlLogo.Id = New System.Guid("5bb6f7e7-9d8b-401f-91dd-1c2b605f86fa")
        Me.pnlGrpMain.Panels.Add(Me.pnlLogo)
        Me.pnlMgrSchoolgroupLogo.Panels.Add(Me.pnlGrpMain)
        '
        'Design Time Panel Info:
        '
        Me.pnlMgrSchoolgroupLogo.BeginPanelInfo()
        Me.pnlMgrSchoolgroupLogo.AddDockPanelInfo(New System.Guid("47cb51a0-7ecb-4a61-a61c-b36aefc7c918"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(788, 501), True)
        Me.pnlMgrSchoolgroupLogo.AddDockPanelInfo(New System.Guid("54718a2f-ca88-4b6e-b89f-b33ff6691424"), New System.Guid("47cb51a0-7ecb-4a61-a61c-b36aefc7c918"), 385, True)
        Me.pnlMgrSchoolgroupLogo.AddDockPanelInfo(New System.Guid("5bb6f7e7-9d8b-401f-91dd-1c2b605f86fa"), New System.Guid("47cb51a0-7ecb-4a61-a61c-b36aefc7c918"), 399, True)
        Me.pnlMgrSchoolgroupLogo.AddFloatingPanelInfo(New System.Guid("47cb51a0-7ecb-4a61-a61c-b36aefc7c918"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.pnlMgrSchoolgroupLogo.AddFloatingPanelInfo(New System.Guid("54718a2f-ca88-4b6e-b89f-b33ff6691424"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.pnlMgrSchoolgroupLogo.AddFloatingPanelInfo(New System.Guid("5bb6f7e7-9d8b-401f-91dd-1c2b605f86fa"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.pnlMgrSchoolgroupLogo.EndPanelInfo()
        '
        'pnlGrpMain
        '
        Me.pnlGrpMain.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles
        Me.pnlGrpMain.Location = New System.Drawing.Point(3, 3)
        Me.pnlGrpMain.Name = "pnlGrpMain"
        Me.pnlGrpMain.Size = New System.Drawing.Size(788, 501)
        Me.pnlGrpMain.TabIndex = 4
        Me.pnlGrpMain.Text = "Schoolgroup Logo"
        '
        'pnlSchoolgroups
        '
        Me.pnlSchoolgroups.InnerContainer = Me.pnlSchoolgroupsContainer
        Me.pnlSchoolgroups.Location = New System.Drawing.Point(0, 22)
        Me.pnlSchoolgroups.Name = "pnlSchoolgroups"
        Me.pnlSchoolgroups.Size = New System.Drawing.Size(385, 479)
        Me.pnlSchoolgroups.TabIndex = 4
        Me.pnlSchoolgroups.Text = "Schoolgroups"
        '
        'pnlSchoolgroupsContainer
        '
        Me.pnlSchoolgroupsContainer.Controls.Add(Me.grexSchoolgroups)
        Me.pnlSchoolgroupsContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlSchoolgroupsContainer.Name = "pnlSchoolgroupsContainer"
        Me.pnlSchoolgroupsContainer.Size = New System.Drawing.Size(383, 455)
        Me.pnlSchoolgroupsContainer.TabIndex = 0
        '
        'grexSchoolgroups
        '
        Me.grexSchoolgroups.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grexSchoolgroups.DataSource = Me.bsSchoolgroupLogo
        grexSchoolgroups_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolgroups_DesignTimeLayout.LayoutString")
        Me.grexSchoolgroups.DesignTimeLayout = grexSchoolgroups_DesignTimeLayout
        Me.grexSchoolgroups.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolgroups.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolgroups.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolgroups.FilterRowFormatStyle.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grexSchoolgroups.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexSchoolgroups.GroupByBoxVisible = False
        Me.grexSchoolgroups.Location = New System.Drawing.Point(0, 0)
        Me.grexSchoolgroups.Name = "grexSchoolgroups"
        Me.grexSchoolgroups.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexSchoolgroups.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroups.Size = New System.Drawing.Size(383, 455)
        Me.grexSchoolgroups.TabIndex = 0
        Me.grexSchoolgroups.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolgroups.VisualStyleManager = Me.vsmSchoolgroupLogo
        '
        'bsSchoolgroupLogo
        '
        Me.bsSchoolgroupLogo.DataSource = GetType(AscensionAnalytics.schoolgroup_logo)
        '
        'pnlLogo
        '
        Me.pnlLogo.InnerContainer = Me.pnlLogoContainer
        Me.pnlLogo.Location = New System.Drawing.Point(389, 22)
        Me.pnlLogo.Name = "pnlLogo"
        Me.pnlLogo.Size = New System.Drawing.Size(399, 479)
        Me.pnlLogo.TabIndex = 4
        Me.pnlLogo.Text = "Logo"
        '
        'pnlLogoContainer
        '
        Me.pnlLogoContainer.Controls.Add(Me.cmdBtnPickImage)
        Me.pnlLogoContainer.Controls.Add(Me.pixLogo)
        Me.pnlLogoContainer.Location = New System.Drawing.Point(1, 23)
        Me.pnlLogoContainer.Name = "pnlLogoContainer"
        Me.pnlLogoContainer.Size = New System.Drawing.Size(397, 455)
        Me.pnlLogoContainer.TabIndex = 0
        '
        'cmdBtnPickImage
        '
        Me.cmdBtnPickImage.Dock = System.Windows.Forms.DockStyle.Top
        Me.cmdBtnPickImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdBtnPickImage.Location = New System.Drawing.Point(0, 0)
        Me.cmdBtnPickImage.Name = "cmdBtnPickImage"
        Me.cmdBtnPickImage.Size = New System.Drawing.Size(397, 23)
        Me.cmdBtnPickImage.TabIndex = 1
        Me.cmdBtnPickImage.Text = "Change Image..."
        Me.cmdBtnPickImage.VisualStyleManager = Me.vsmSchoolgroupLogo
        '
        'pixLogo
        '
        Me.pixLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pixLogo.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.bsSchoolgroupLogo, "logo_image", True))
        Me.pixLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pixLogo.Location = New System.Drawing.Point(0, 0)
        Me.pixLogo.Name = "pixLogo"
        Me.pixLogo.Size = New System.Drawing.Size(397, 455)
        Me.pixLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pixLogo.TabIndex = 0
        Me.pixLogo.TabStop = False
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'frmSchoolgroupLogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 507)
        Me.Controls.Add(Me.pnlGrpMain)
        Me.Name = "frmSchoolgroupLogo"
        Me.Text = "frmSchoolgroupLogo"
        CType(Me.pnlMgrSchoolgroupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlGrpMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlGrpMain.ResumeLayout(False)
        CType(Me.pnlSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlSchoolgroups.ResumeLayout(False)
        Me.pnlSchoolgroupsContainer.ResumeLayout(False)
        CType(Me.grexSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogo.ResumeLayout(False)
        Me.pnlLogoContainer.ResumeLayout(False)
        CType(Me.pixLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmSchoolgroupLogo As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents pnlMgrSchoolgroupLogo As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents bsSchoolgroupLogo As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
    Friend WithEvents pnlGrpMain As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlSchoolgroups As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlSchoolgroupsContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents grexSchoolgroups As Janus.Windows.GridEX.GridEX
    Friend WithEvents pnlLogo As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents pnlLogoContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents cmdBtnPickImage As Janus.Windows.EditControls.UIButton
    Friend WithEvents pixLogo As System.Windows.Forms.PictureBox
End Class
