<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestDetail
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
        Dim CloseDateLabel As System.Windows.Forms.Label
        Dim labelRequestStatus As System.Windows.Forms.Label
        Dim ModifiedByUserLabel As System.Windows.Forms.Label
        Dim labelMilestone As System.Windows.Forms.Label
        Dim DirectoryFullPathLabel As System.Windows.Forms.Label
        Dim labelIsActive As System.Windows.Forms.Label
        Dim labelRequestType As System.Windows.Forms.Label
        Dim labelOpenDate As System.Windows.Forms.Label
        Dim labelRequestor As System.Windows.Forms.Label
        Dim LabelDescription As System.Windows.Forms.Label
        Dim EffortMinutesLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grexRequestLog_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestDetail))
        Me.uipmAnalysisRequestEditor = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.vsmAnalysisRequestEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.pnlMainHoriz = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlRequestDetail = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.uibuttonNow = New Janus.Windows.EditControls.UIButton
        Me.comboAssignee = New Janus.Windows.EditControls.UIComboBox
        Me.bsAnalysisRequest = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAssignees = New System.Windows.Forms.BindingSource(Me.components)
        Me.editBoxTotalEffortDisplay = New Janus.Windows.GridEX.EditControls.EditBox
        Me.buttonOpenRequestDirectory = New Janus.Windows.EditControls.UIButton
        Me.calComboCloseDate = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.comboRequestStatus = New Janus.Windows.EditControls.UIComboBox
        Me.bsStatuses = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModifiedTimeCalendarCombo = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.ModifiedByUserEditBox = New Janus.Windows.GridEX.EditControls.EditBox
        Me.calComboMilestoneDate = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.editBoxMilestone = New Janus.Windows.GridEX.EditControls.EditBox
        Me.editBoxDirectoryFullPath = New Janus.Windows.GridEX.EditControls.EditBox
        Me.checkBoxIsActive = New Janus.Windows.EditControls.UICheckBox
        Me.comboRequestType = New Janus.Windows.EditControls.UIComboBox
        Me.bsTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.calCmboOpenDate = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.comboRequestor = New Janus.Windows.EditControls.UIComboBox
        Me.bsRequestors = New System.Windows.Forms.BindingSource(Me.components)
        Me.editBoxDescription = New Janus.Windows.GridEX.EditControls.EditBox
        Me.editBoxAnalysisId = New Janus.Windows.GridEX.EditControls.EditBox
        Me.EditBoxName = New Janus.Windows.GridEX.EditControls.EditBox
        Me.pnlLowerVert = New Janus.Windows.UI.Dock.UIPanelGroup
        Me.pnlLogListing = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel1Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.grexRequestLog = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisRequestLogs = New System.Windows.Forms.BindingSource(Me.components)
        Me.pnlLogDetail = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel3Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.buttonTimerReset = New System.Windows.Forms.Button
        Me.buttonTimerPause = New System.Windows.Forms.Button
        Me.editBoxTimer = New Janus.Windows.GridEX.EditControls.EditBox
        Me.editBoxLogEntryText = New Janus.Windows.GridEX.EditControls.EditBox
        Me.EntryUserEditBox = New Janus.Windows.GridEX.EditControls.EditBox
        Me.editBoxEffortMinutes = New Janus.Windows.GridEX.EditControls.EditBox
        Me.EntryTimeCalendarCombo = New Janus.Windows.CalendarCombo.CalendarCombo
        Me.errorProviderAnalysisRequestEditor = New System.Windows.Forms.ErrorProvider(Me.components)
        CloseDateLabel = New System.Windows.Forms.Label
        labelRequestStatus = New System.Windows.Forms.Label
        ModifiedByUserLabel = New System.Windows.Forms.Label
        labelMilestone = New System.Windows.Forms.Label
        DirectoryFullPathLabel = New System.Windows.Forms.Label
        labelIsActive = New System.Windows.Forms.Label
        labelRequestType = New System.Windows.Forms.Label
        labelOpenDate = New System.Windows.Forms.Label
        labelRequestor = New System.Windows.Forms.Label
        LabelDescription = New System.Windows.Forms.Label
        EffortMinutesLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.uipmAnalysisRequestEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlMainHoriz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMainHoriz.SuspendLayout()
        CType(Me.pnlRequestDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlRequestDetail.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        CType(Me.bsAnalysisRequest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssignees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRequestors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLowerVert, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLowerVert.SuspendLayout()
        CType(Me.pnlLogListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogListing.SuspendLayout()
        Me.uiPanel1Container.SuspendLayout()
        CType(Me.grexRequestLog, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisRequestLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlLogDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlLogDetail.SuspendLayout()
        Me.uiPanel3Container.SuspendLayout()
        CType(Me.errorProviderAnalysisRequestEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CloseDateLabel
        '
        CloseDateLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        CloseDateLabel.AutoSize = True
        CloseDateLabel.Enabled = False
        CloseDateLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CloseDateLabel.Location = New System.Drawing.Point(365, 366)
        CloseDateLabel.Name = "CloseDateLabel"
        CloseDateLabel.Size = New System.Drawing.Size(58, 13)
        CloseDateLabel.TabIndex = 22
        CloseDateLabel.Text = "Close Date:"
        '
        'labelRequestStatus
        '
        labelRequestStatus.AutoSize = True
        labelRequestStatus.Location = New System.Drawing.Point(603, 142)
        labelRequestStatus.Name = "labelRequestStatus"
        labelRequestStatus.Size = New System.Drawing.Size(52, 13)
        labelRequestStatus.TabIndex = 9
        labelRequestStatus.Text = "Status Id:"
        '
        'ModifiedByUserLabel
        '
        ModifiedByUserLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ModifiedByUserLabel.AutoSize = True
        ModifiedByUserLabel.Enabled = False
        ModifiedByUserLabel.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ModifiedByUserLabel.Location = New System.Drawing.Point(757, 366)
        ModifiedByUserLabel.Name = "ModifiedByUserLabel"
        ModifiedByUserLabel.Size = New System.Drawing.Size(110, 13)
        ModifiedByUserLabel.TabIndex = 26
        ModifiedByUserLabel.Text = "Request Last Modified:"
        '
        'labelMilestone
        '
        labelMilestone.AutoSize = True
        labelMilestone.Location = New System.Drawing.Point(13, 195)
        labelMilestone.Name = "labelMilestone"
        labelMilestone.Size = New System.Drawing.Size(55, 13)
        labelMilestone.TabIndex = 13
        labelMilestone.Text = "Milestone:"
        '
        'DirectoryFullPathLabel
        '
        DirectoryFullPathLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DirectoryFullPathLabel.AutoSize = True
        DirectoryFullPathLabel.Location = New System.Drawing.Point(13, 302)
        DirectoryFullPathLabel.Name = "DirectoryFullPathLabel"
        DirectoryFullPathLabel.Size = New System.Drawing.Size(96, 13)
        DirectoryFullPathLabel.TabIndex = 16
        DirectoryFullPathLabel.Text = "Directory Full Path:"
        '
        'labelIsActive
        '
        labelIsActive.AutoSize = True
        labelIsActive.Location = New System.Drawing.Point(776, 142)
        labelIsActive.Name = "labelIsActive"
        labelIsActive.Size = New System.Drawing.Size(51, 13)
        labelIsActive.TabIndex = 11
        labelIsActive.Text = "Is Active:"
        '
        'labelRequestType
        '
        labelRequestType.AutoSize = True
        labelRequestType.Location = New System.Drawing.Point(363, 142)
        labelRequestType.Name = "labelRequestType"
        labelRequestType.Size = New System.Drawing.Size(77, 13)
        labelRequestType.TabIndex = 7
        labelRequestType.Text = "Request Type:"
        '
        'labelOpenDate
        '
        labelOpenDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        labelOpenDate.AutoSize = True
        labelOpenDate.Enabled = False
        labelOpenDate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        labelOpenDate.Location = New System.Drawing.Point(197, 366)
        labelOpenDate.Name = "labelOpenDate"
        labelOpenDate.Size = New System.Drawing.Size(58, 13)
        labelOpenDate.TabIndex = 20
        labelOpenDate.Text = "Open Date:"
        '
        'labelRequestor
        '
        labelRequestor.AutoSize = True
        labelRequestor.Location = New System.Drawing.Point(13, 142)
        labelRequestor.Name = "labelRequestor"
        labelRequestor.Size = New System.Drawing.Size(59, 13)
        labelRequestor.TabIndex = 3
        labelRequestor.Text = "Requestor:"
        '
        'LabelDescription
        '
        LabelDescription.AutoSize = True
        LabelDescription.Location = New System.Drawing.Point(13, 43)
        LabelDescription.Name = "LabelDescription"
        LabelDescription.Size = New System.Drawing.Size(63, 13)
        LabelDescription.TabIndex = 1
        LabelDescription.Text = "Description:"
        '
        'EffortMinutesLabel
        '
        EffortMinutesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        EffortMinutesLabel.AutoSize = True
        EffortMinutesLabel.Location = New System.Drawing.Point(0, 304)
        EffortMinutesLabel.Name = "EffortMinutesLabel"
        EffortMinutesLabel.Size = New System.Drawing.Size(75, 13)
        EffortMinutesLabel.TabIndex = 30
        EffortMinutesLabel.Text = "Effort Minutes:"
        '
        'Label1
        '
        Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Label1.AutoSize = True
        Label1.Enabled = False
        Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(546, 366)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(60, 13)
        Label1.TabIndex = 24
        Label1.Text = "Total Effort:"
        '
        'Label2
        '
        Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label2.AutoSize = True
        Label2.Enabled = False
        Label2.Location = New System.Drawing.Point(106, 304)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(36, 13)
        Label2.TabIndex = 32
        Label2.Text = "Timer:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(182, 142)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(53, 13)
        Label3.TabIndex = 5
        Label3.Text = "Assignee:"
        '
        'uipmAnalysisRequestEditor
        '
        Me.uipmAnalysisRequestEditor.AllowPanelDrag = False
        Me.uipmAnalysisRequestEditor.AllowPanelDrop = False
        Me.uipmAnalysisRequestEditor.ContainerControl = Me
        Me.uipmAnalysisRequestEditor.DefaultPanelSettings.CloseButtonVisible = False
        Me.uipmAnalysisRequestEditor.SplitterSize = 6
        Me.uipmAnalysisRequestEditor.VisualStyleManager = Me.vsmAnalysisRequestEditor
        Me.pnlMainHoriz.Id = New System.Guid("9511bd0b-d6fe-462e-b2af-1a05a0cb042c")
        Me.pnlMainHoriz.StaticGroup = True
        Me.pnlRequestDetail.Id = New System.Guid("0115cd5b-4b1e-452d-9701-90bfb34a27bc")
        Me.pnlMainHoriz.Panels.Add(Me.pnlRequestDetail)
        Me.pnlLowerVert.Id = New System.Guid("7124ce07-d18e-4bd5-84da-c4c6e74be7a6")
        Me.pnlLowerVert.StaticGroup = True
        Me.pnlLogListing.Id = New System.Guid("861c0617-bdde-482c-be16-e519fbfbd950")
        Me.pnlLowerVert.Panels.Add(Me.pnlLogListing)
        Me.pnlLogDetail.Id = New System.Guid("07f4de13-3757-4230-b26c-ba28dc1025be")
        Me.pnlLowerVert.Panels.Add(Me.pnlLogDetail)
        Me.pnlMainHoriz.Panels.Add(Me.pnlLowerVert)
        Me.uipmAnalysisRequestEditor.Panels.Add(Me.pnlMainHoriz)
        '
        'Design Time Panel Info:
        '
        Me.uipmAnalysisRequestEditor.BeginPanelInfo()
        Me.uipmAnalysisRequestEditor.AddDockPanelInfo(New System.Guid("9511bd0b-d6fe-462e-b2af-1a05a0cb042c"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, Janus.Windows.UI.Dock.PanelDockStyle.Fill, True, New System.Drawing.Size(1174, 834), True)
        Me.uipmAnalysisRequestEditor.AddDockPanelInfo(New System.Guid("0115cd5b-4b1e-452d-9701-90bfb34a27bc"), New System.Guid("9511bd0b-d6fe-462e-b2af-1a05a0cb042c"), 412, True)
        Me.uipmAnalysisRequestEditor.AddDockPanelInfo(New System.Guid("7124ce07-d18e-4bd5-84da-c4c6e74be7a6"), New System.Guid("9511bd0b-d6fe-462e-b2af-1a05a0cb042c"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, 394, True)
        Me.uipmAnalysisRequestEditor.AddDockPanelInfo(New System.Guid("861c0617-bdde-482c-be16-e519fbfbd950"), New System.Guid("7124ce07-d18e-4bd5-84da-c4c6e74be7a6"), 616, True)
        Me.uipmAnalysisRequestEditor.AddDockPanelInfo(New System.Guid("07f4de13-3757-4230-b26c-ba28dc1025be"), New System.Guid("7124ce07-d18e-4bd5-84da-c4c6e74be7a6"), 424, True)
        Me.uipmAnalysisRequestEditor.AddFloatingPanelInfo(New System.Guid("9511bd0b-d6fe-462e-b2af-1a05a0cb042c"), Janus.Windows.UI.Dock.PanelGroupStyle.HorizontalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisRequestEditor.AddFloatingPanelInfo(New System.Guid("0115cd5b-4b1e-452d-9701-90bfb34a27bc"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisRequestEditor.AddFloatingPanelInfo(New System.Guid("7124ce07-d18e-4bd5-84da-c4c6e74be7a6"), Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles, True, New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisRequestEditor.AddFloatingPanelInfo(New System.Guid("861c0617-bdde-482c-be16-e519fbfbd950"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisRequestEditor.AddFloatingPanelInfo(New System.Guid("07f4de13-3757-4230-b26c-ba28dc1025be"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.uipmAnalysisRequestEditor.EndPanelInfo()
        '
        'vsmAnalysisRequestEditor
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme0"
        JanusColorScheme2.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnalysisRequestEditor.ColorSchemes.Add(JanusColorScheme2)
        '
        'pnlMainHoriz
        '
        Me.pnlMainHoriz.Location = New System.Drawing.Point(3, 3)
        Me.pnlMainHoriz.Name = "pnlMainHoriz"
        Me.pnlMainHoriz.Size = New System.Drawing.Size(1174, 834)
        Me.pnlMainHoriz.TabIndex = 4
        Me.pnlMainHoriz.Text = "Analysis Request"
        '
        'pnlRequestDetail
        '
        Me.pnlRequestDetail.InnerContainer = Me.uiPanel0Container
        Me.pnlRequestDetail.Location = New System.Drawing.Point(0, 22)
        Me.pnlRequestDetail.Name = "pnlRequestDetail"
        Me.pnlRequestDetail.Size = New System.Drawing.Size(1174, 412)
        Me.pnlRequestDetail.TabIndex = 4
        Me.pnlRequestDetail.Text = "Detail"
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.uibuttonNow)
        Me.uiPanel0Container.Controls.Add(Label3)
        Me.uiPanel0Container.Controls.Add(Me.comboAssignee)
        Me.uiPanel0Container.Controls.Add(Label1)
        Me.uiPanel0Container.Controls.Add(Me.editBoxTotalEffortDisplay)
        Me.uiPanel0Container.Controls.Add(Me.buttonOpenRequestDirectory)
        Me.uiPanel0Container.Controls.Add(CloseDateLabel)
        Me.uiPanel0Container.Controls.Add(Me.calComboCloseDate)
        Me.uiPanel0Container.Controls.Add(labelRequestStatus)
        Me.uiPanel0Container.Controls.Add(Me.comboRequestStatus)
        Me.uiPanel0Container.Controls.Add(Me.ModifiedTimeCalendarCombo)
        Me.uiPanel0Container.Controls.Add(ModifiedByUserLabel)
        Me.uiPanel0Container.Controls.Add(Me.ModifiedByUserEditBox)
        Me.uiPanel0Container.Controls.Add(Me.calComboMilestoneDate)
        Me.uiPanel0Container.Controls.Add(labelMilestone)
        Me.uiPanel0Container.Controls.Add(Me.editBoxMilestone)
        Me.uiPanel0Container.Controls.Add(DirectoryFullPathLabel)
        Me.uiPanel0Container.Controls.Add(Me.editBoxDirectoryFullPath)
        Me.uiPanel0Container.Controls.Add(labelIsActive)
        Me.uiPanel0Container.Controls.Add(Me.checkBoxIsActive)
        Me.uiPanel0Container.Controls.Add(labelRequestType)
        Me.uiPanel0Container.Controls.Add(Me.comboRequestType)
        Me.uiPanel0Container.Controls.Add(labelOpenDate)
        Me.uiPanel0Container.Controls.Add(Me.calCmboOpenDate)
        Me.uiPanel0Container.Controls.Add(labelRequestor)
        Me.uiPanel0Container.Controls.Add(Me.comboRequestor)
        Me.uiPanel0Container.Controls.Add(LabelDescription)
        Me.uiPanel0Container.Controls.Add(Me.editBoxDescription)
        Me.uiPanel0Container.Controls.Add(Me.editBoxAnalysisId)
        Me.uiPanel0Container.Controls.Add(Me.EditBoxName)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(1172, 388)
        Me.uiPanel0Container.TabIndex = 0
        '
        'uibuttonNow
        '
        Me.uibuttonNow.Location = New System.Drawing.Point(235, 191)
        Me.uibuttonNow.Name = "uibuttonNow"
        Me.uibuttonNow.Size = New System.Drawing.Size(30, 20)
        Me.uibuttonNow.TabIndex = 41
        Me.uibuttonNow.Text = "Now"
        Me.uibuttonNow.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'comboAssignee
        '
        Me.comboAssignee.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalysisRequest, "AssigneeId", True))
        Me.comboAssignee.DataSource = Me.bsAssignees
        Me.comboAssignee.DisplayMember = "Name"
        Me.comboAssignee.Location = New System.Drawing.Point(185, 158)
        Me.comboAssignee.Name = "comboAssignee"
        Me.comboAssignee.Size = New System.Drawing.Size(154, 20)
        Me.comboAssignee.TabIndex = 6
        Me.comboAssignee.ValueMember = "PersonId"
        Me.comboAssignee.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'bsAnalysisRequest
        '
        Me.bsAnalysisRequest.DataSource = GetType(AscensionAnalytics.AnalysisRequest)
        '
        'bsAssignees
        '
        Me.bsAssignees.DataSource = GetType(AscensionAnalytics.AnalysisRequestPeople)
        '
        'editBoxTotalEffortDisplay
        '
        Me.editBoxTotalEffortDisplay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBoxTotalEffortDisplay.Enabled = False
        Me.editBoxTotalEffortDisplay.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBoxTotalEffortDisplay.Location = New System.Drawing.Point(612, 360)
        Me.editBoxTotalEffortDisplay.Name = "editBoxTotalEffortDisplay"
        Me.editBoxTotalEffortDisplay.Size = New System.Drawing.Size(117, 21)
        Me.editBoxTotalEffortDisplay.TabIndex = 25
        Me.editBoxTotalEffortDisplay.TabStop = False
        Me.editBoxTotalEffortDisplay.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'buttonOpenRequestDirectory
        '
        Me.buttonOpenRequestDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonOpenRequestDirectory.Location = New System.Drawing.Point(16, 344)
        Me.buttonOpenRequestDirectory.Name = "buttonOpenRequestDirectory"
        Me.buttonOpenRequestDirectory.Size = New System.Drawing.Size(133, 20)
        Me.buttonOpenRequestDirectory.TabIndex = 19
        Me.buttonOpenRequestDirectory.Text = "Open Request Directory"
        Me.buttonOpenRequestDirectory.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'calComboCloseDate
        '
        Me.calComboCloseDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calComboCloseDate.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.bsAnalysisRequest, "CloseDate", True))
        '
        '
        '
        Me.calComboCloseDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calComboCloseDate.Enabled = False
        Me.calComboCloseDate.Location = New System.Drawing.Point(433, 361)
        Me.calComboCloseDate.Name = "calComboCloseDate"
        Me.calComboCloseDate.ReadOnly = True
        Me.calComboCloseDate.Size = New System.Drawing.Size(98, 20)
        Me.calComboCloseDate.TabIndex = 23
        Me.calComboCloseDate.TabStop = False
        Me.calComboCloseDate.Value = New Date(2012, 8, 30, 0, 0, 0, 0)
        Me.calComboCloseDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calComboCloseDate.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'comboRequestStatus
        '
        Me.comboRequestStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalysisRequest, "StatusId", True))
        Me.comboRequestStatus.DataSource = Me.bsStatuses
        Me.comboRequestStatus.DisplayMember = "Status"
        Me.comboRequestStatus.Location = New System.Drawing.Point(606, 158)
        Me.comboRequestStatus.Name = "comboRequestStatus"
        Me.comboRequestStatus.Size = New System.Drawing.Size(152, 20)
        Me.comboRequestStatus.TabIndex = 10
        Me.comboRequestStatus.ValueMember = "StatusId"
        Me.comboRequestStatus.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'bsStatuses
        '
        Me.bsStatuses.DataSource = GetType(AscensionAnalytics.AnalysisRequestStatus)
        '
        'ModifiedTimeCalendarCombo
        '
        Me.ModifiedTimeCalendarCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifiedTimeCalendarCombo.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.bsAnalysisRequest, "ModifiedTime", True))
        Me.ModifiedTimeCalendarCombo.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.ModifiedTimeCalendarCombo.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.ModifiedTimeCalendarCombo.Enabled = False
        Me.ModifiedTimeCalendarCombo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifiedTimeCalendarCombo.Location = New System.Drawing.Point(996, 360)
        Me.ModifiedTimeCalendarCombo.Name = "ModifiedTimeCalendarCombo"
        Me.ModifiedTimeCalendarCombo.ReadOnly = True
        Me.ModifiedTimeCalendarCombo.Size = New System.Drawing.Size(153, 21)
        Me.ModifiedTimeCalendarCombo.TabIndex = 28
        Me.ModifiedTimeCalendarCombo.TabStop = False
        Me.ModifiedTimeCalendarCombo.Value = New Date(2012, 8, 30, 0, 0, 0, 0)
        Me.ModifiedTimeCalendarCombo.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.ModifiedTimeCalendarCombo.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'ModifiedByUserEditBox
        '
        Me.ModifiedByUserEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ModifiedByUserEditBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "ModifiedByUser", True))
        Me.ModifiedByUserEditBox.Enabled = False
        Me.ModifiedByUserEditBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModifiedByUserEditBox.Location = New System.Drawing.Point(873, 360)
        Me.ModifiedByUserEditBox.Name = "ModifiedByUserEditBox"
        Me.ModifiedByUserEditBox.Size = New System.Drawing.Size(117, 21)
        Me.ModifiedByUserEditBox.TabIndex = 27
        Me.ModifiedByUserEditBox.TabStop = False
        Me.ModifiedByUserEditBox.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'calComboMilestoneDate
        '
        Me.calComboMilestoneDate.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.bsAnalysisRequest, "MilestoneDate", True))
        Me.calComboMilestoneDate.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.calComboMilestoneDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calComboMilestoneDate.Location = New System.Drawing.Point(74, 191)
        Me.calComboMilestoneDate.Name = "calComboMilestoneDate"
        Me.calComboMilestoneDate.Size = New System.Drawing.Size(155, 20)
        Me.calComboMilestoneDate.TabIndex = 14
        Me.calComboMilestoneDate.Value = New Date(2012, 8, 30, 0, 0, 0, 0)
        Me.calComboMilestoneDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calComboMilestoneDate.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'editBoxMilestone
        '
        Me.editBoxMilestone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBoxMilestone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "Milestone", True))
        Me.editBoxMilestone.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBoxMilestone.Location = New System.Drawing.Point(16, 217)
        Me.editBoxMilestone.Multiline = True
        Me.editBoxMilestone.Name = "editBoxMilestone"
        Me.editBoxMilestone.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.editBoxMilestone.Size = New System.Drawing.Size(1133, 79)
        Me.editBoxMilestone.TabIndex = 15
        Me.editBoxMilestone.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'editBoxDirectoryFullPath
        '
        Me.editBoxDirectoryFullPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBoxDirectoryFullPath.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "DirectoryFullPath", True))
        Me.editBoxDirectoryFullPath.Location = New System.Drawing.Point(16, 318)
        Me.editBoxDirectoryFullPath.Name = "editBoxDirectoryFullPath"
        Me.editBoxDirectoryFullPath.Size = New System.Drawing.Size(1133, 20)
        Me.editBoxDirectoryFullPath.TabIndex = 17
        Me.editBoxDirectoryFullPath.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'checkBoxIsActive
        '
        Me.checkBoxIsActive.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsAnalysisRequest, "IsActive", True))
        Me.checkBoxIsActive.Location = New System.Drawing.Point(779, 155)
        Me.checkBoxIsActive.Name = "checkBoxIsActive"
        Me.checkBoxIsActive.Size = New System.Drawing.Size(36, 23)
        Me.checkBoxIsActive.TabIndex = 12
        Me.checkBoxIsActive.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'comboRequestType
        '
        Me.comboRequestType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalysisRequest, "RequestTypeId", True))
        Me.comboRequestType.DataSource = Me.bsTypes
        Me.comboRequestType.DisplayMember = "RequestType"
        Me.comboRequestType.Location = New System.Drawing.Point(366, 158)
        Me.comboRequestType.Name = "comboRequestType"
        Me.comboRequestType.Size = New System.Drawing.Size(219, 20)
        Me.comboRequestType.TabIndex = 8
        Me.comboRequestType.ValueMember = "RequestTypeId"
        Me.comboRequestType.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'bsTypes
        '
        Me.bsTypes.DataSource = GetType(AscensionAnalytics.AnalysisRequestType)
        '
        'calCmboOpenDate
        '
        Me.calCmboOpenDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.calCmboOpenDate.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.bsAnalysisRequest, "OpenDate", True))
        '
        '
        '
        Me.calCmboOpenDate.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calCmboOpenDate.Enabled = False
        Me.calCmboOpenDate.Location = New System.Drawing.Point(261, 361)
        Me.calCmboOpenDate.Name = "calCmboOpenDate"
        Me.calCmboOpenDate.ReadOnly = True
        Me.calCmboOpenDate.Size = New System.Drawing.Size(98, 20)
        Me.calCmboOpenDate.TabIndex = 21
        Me.calCmboOpenDate.TabStop = False
        Me.calCmboOpenDate.Value = New Date(2012, 8, 30, 0, 0, 0, 0)
        Me.calCmboOpenDate.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.calCmboOpenDate.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'comboRequestor
        '
        Me.comboRequestor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsAnalysisRequest, "RequestorId", True))
        Me.comboRequestor.DataSource = Me.bsRequestors
        Me.comboRequestor.DisplayMember = "Name"
        Me.comboRequestor.Location = New System.Drawing.Point(16, 158)
        Me.comboRequestor.Name = "comboRequestor"
        Me.comboRequestor.Size = New System.Drawing.Size(154, 20)
        Me.comboRequestor.TabIndex = 4
        Me.comboRequestor.ValueMember = "PersonId"
        Me.comboRequestor.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'bsRequestors
        '
        Me.bsRequestors.DataSource = GetType(AscensionAnalytics.AnalysisRequestPeople)
        '
        'editBoxDescription
        '
        Me.editBoxDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBoxDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "Description", True))
        Me.editBoxDescription.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBoxDescription.Location = New System.Drawing.Point(16, 59)
        Me.editBoxDescription.Multiline = True
        Me.editBoxDescription.Name = "editBoxDescription"
        Me.editBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.editBoxDescription.Size = New System.Drawing.Size(1133, 71)
        Me.editBoxDescription.TabIndex = 2
        Me.editBoxDescription.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'editBoxAnalysisId
        '
        Me.editBoxAnalysisId.BorderStyle = Janus.Windows.GridEX.BorderStyle.None
        Me.editBoxAnalysisId.ControlStyle.ButtonAppearance = Janus.Windows.GridEX.ButtonAppearance.FlatBorderless
        Me.editBoxAnalysisId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "AnalysisId", True))
        Me.editBoxAnalysisId.Enabled = False
        Me.editBoxAnalysisId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBoxAnalysisId.Location = New System.Drawing.Point(16, 7)
        Me.editBoxAnalysisId.Name = "editBoxAnalysisId"
        Me.editBoxAnalysisId.ReadOnly = True
        Me.editBoxAnalysisId.Size = New System.Drawing.Size(52, 25)
        Me.editBoxAnalysisId.TabIndex = 40
        Me.editBoxAnalysisId.TabStop = False
        Me.editBoxAnalysisId.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'EditBoxName
        '
        Me.EditBoxName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EditBoxName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequest, "Name", True))
        Me.EditBoxName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditBoxName.Location = New System.Drawing.Point(74, 7)
        Me.EditBoxName.Name = "EditBoxName"
        Me.EditBoxName.Size = New System.Drawing.Size(1075, 27)
        Me.EditBoxName.TabIndex = 0
        Me.EditBoxName.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'pnlLowerVert
        '
        Me.pnlLowerVert.GroupStyle = Janus.Windows.UI.Dock.PanelGroupStyle.VerticalTiles
        Me.pnlLowerVert.Location = New System.Drawing.Point(0, 440)
        Me.pnlLowerVert.Name = "pnlLowerVert"
        Me.pnlLowerVert.Size = New System.Drawing.Size(1174, 394)
        Me.pnlLowerVert.TabIndex = 4
        Me.pnlLowerVert.Text = "Log Entries"
        '
        'pnlLogListing
        '
        Me.pnlLogListing.InnerContainer = Me.uiPanel1Container
        Me.pnlLogListing.Location = New System.Drawing.Point(0, 22)
        Me.pnlLogListing.Name = "pnlLogListing"
        Me.pnlLogListing.Size = New System.Drawing.Size(692, 372)
        Me.pnlLogListing.TabIndex = 4
        Me.pnlLogListing.Text = "Logs"
        '
        'uiPanel1Container
        '
        Me.uiPanel1Container.Controls.Add(Me.grexRequestLog)
        Me.uiPanel1Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel1Container.Name = "uiPanel1Container"
        Me.uiPanel1Container.Size = New System.Drawing.Size(690, 348)
        Me.uiPanel1Container.TabIndex = 0
        '
        'grexRequestLog
        '
        Me.grexRequestLog.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexRequestLog.DataSource = Me.bsAnalysisRequestLogs
        grexRequestLog_DesignTimeLayout.LayoutString = resources.GetString("grexRequestLog_DesignTimeLayout.LayoutString")
        Me.grexRequestLog.DesignTimeLayout = grexRequestLog_DesignTimeLayout
        Me.grexRequestLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexRequestLog.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexRequestLog.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexRequestLog.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexRequestLog.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexRequestLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexRequestLog.Location = New System.Drawing.Point(0, 0)
        Me.grexRequestLog.Name = "grexRequestLog"
        Me.grexRequestLog.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexRequestLog.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexRequestLog.ScrollBars = Janus.Windows.GridEX.ScrollBars.Vertical
        Me.grexRequestLog.Size = New System.Drawing.Size(690, 348)
        Me.grexRequestLog.TabIndex = 27
        Me.grexRequestLog.TabStop = False
        Me.grexRequestLog.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexRequestLog.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'bsAnalysisRequestLogs
        '
        Me.bsAnalysisRequestLogs.DataMember = "AnalysisRequestLogs"
        Me.bsAnalysisRequestLogs.DataSource = Me.bsAnalysisRequest
        '
        'pnlLogDetail
        '
        Me.pnlLogDetail.InnerContainer = Me.uiPanel3Container
        Me.pnlLogDetail.Location = New System.Drawing.Point(698, 22)
        Me.pnlLogDetail.Name = "pnlLogDetail"
        Me.pnlLogDetail.Size = New System.Drawing.Size(476, 372)
        Me.pnlLogDetail.TabIndex = 4
        Me.pnlLogDetail.Text = "Details"
        '
        'uiPanel3Container
        '
        Me.uiPanel3Container.Controls.Add(Me.buttonTimerReset)
        Me.uiPanel3Container.Controls.Add(Me.buttonTimerPause)
        Me.uiPanel3Container.Controls.Add(Label2)
        Me.uiPanel3Container.Controls.Add(Me.editBoxTimer)
        Me.uiPanel3Container.Controls.Add(Me.editBoxLogEntryText)
        Me.uiPanel3Container.Controls.Add(Me.EntryUserEditBox)
        Me.uiPanel3Container.Controls.Add(EffortMinutesLabel)
        Me.uiPanel3Container.Controls.Add(Me.editBoxEffortMinutes)
        Me.uiPanel3Container.Controls.Add(Me.EntryTimeCalendarCombo)
        Me.uiPanel3Container.Location = New System.Drawing.Point(1, 23)
        Me.uiPanel3Container.Name = "uiPanel3Container"
        Me.uiPanel3Container.Size = New System.Drawing.Size(474, 348)
        Me.uiPanel3Container.TabIndex = 0
        '
        'buttonTimerReset
        '
        Me.buttonTimerReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonTimerReset.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.buttonTimerReset.FlatAppearance.BorderSize = 0
        Me.buttonTimerReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonTimerReset.Location = New System.Drawing.Point(110, 321)
        Me.buttonTimerReset.Name = "buttonTimerReset"
        Me.buttonTimerReset.Size = New System.Drawing.Size(7, 7)
        Me.buttonTimerReset.TabIndex = 34
        Me.buttonTimerReset.TabStop = False
        Me.buttonTimerReset.UseVisualStyleBackColor = False
        '
        'buttonTimerPause
        '
        Me.buttonTimerPause.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttonTimerPause.BackColor = System.Drawing.Color.GreenYellow
        Me.buttonTimerPause.FlatAppearance.BorderSize = 0
        Me.buttonTimerPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonTimerPause.Location = New System.Drawing.Point(110, 333)
        Me.buttonTimerPause.Name = "buttonTimerPause"
        Me.buttonTimerPause.Size = New System.Drawing.Size(7, 7)
        Me.buttonTimerPause.TabIndex = 35
        Me.buttonTimerPause.TabStop = False
        Me.buttonTimerPause.UseVisualStyleBackColor = False
        '
        'editBoxTimer
        '
        Me.editBoxTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.editBoxTimer.Enabled = False
        Me.editBoxTimer.Location = New System.Drawing.Point(109, 320)
        Me.editBoxTimer.Name = "editBoxTimer"
        Me.editBoxTimer.ReadOnly = True
        Me.editBoxTimer.Size = New System.Drawing.Size(40, 20)
        Me.editBoxTimer.TabIndex = 33
        Me.editBoxTimer.TabStop = False
        Me.editBoxTimer.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far
        Me.editBoxTimer.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'editBoxLogEntryText
        '
        Me.editBoxLogEntryText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.editBoxLogEntryText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequestLogs, "EntryText", True))
        Me.editBoxLogEntryText.DataBindings.Add(New System.Windows.Forms.Binding("ReadOnly", Me.bsAnalysisRequestLogs, "DataActivityEntry", True))
        Me.editBoxLogEntryText.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBoxLogEntryText.Location = New System.Drawing.Point(3, 3)
        Me.editBoxLogEntryText.Multiline = True
        Me.editBoxLogEntryText.Name = "editBoxLogEntryText"
        Me.editBoxLogEntryText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.editBoxLogEntryText.Size = New System.Drawing.Size(468, 294)
        Me.editBoxLogEntryText.TabIndex = 29
        Me.editBoxLogEntryText.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'EntryUserEditBox
        '
        Me.EntryUserEditBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryUserEditBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequestLogs, "EntryUser", True))
        Me.EntryUserEditBox.Enabled = False
        Me.EntryUserEditBox.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryUserEditBox.Location = New System.Drawing.Point(188, 318)
        Me.EntryUserEditBox.Name = "EntryUserEditBox"
        Me.EntryUserEditBox.Size = New System.Drawing.Size(117, 21)
        Me.EntryUserEditBox.TabIndex = 36
        Me.EntryUserEditBox.TabStop = False
        Me.EntryUserEditBox.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'editBoxEffortMinutes
        '
        Me.editBoxEffortMinutes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.editBoxEffortMinutes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsAnalysisRequestLogs, "EffortMinutes", True))
        Me.editBoxEffortMinutes.Location = New System.Drawing.Point(3, 320)
        Me.editBoxEffortMinutes.Name = "editBoxEffortMinutes"
        Me.editBoxEffortMinutes.Size = New System.Drawing.Size(100, 20)
        Me.editBoxEffortMinutes.TabIndex = 31
        Me.editBoxEffortMinutes.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'EntryTimeCalendarCombo
        '
        Me.EntryTimeCalendarCombo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EntryTimeCalendarCombo.DataBindings.Add(New System.Windows.Forms.Binding("BindableValue", Me.bsAnalysisRequestLogs, "EntryTime", True))
        Me.EntryTimeCalendarCombo.DateFormat = Janus.Windows.CalendarCombo.DateFormat.DateTime
        '
        '
        '
        Me.EntryTimeCalendarCombo.DropDownCalendar.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.EntryTimeCalendarCombo.Enabled = False
        Me.EntryTimeCalendarCombo.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EntryTimeCalendarCombo.Location = New System.Drawing.Point(311, 318)
        Me.EntryTimeCalendarCombo.Name = "EntryTimeCalendarCombo"
        Me.EntryTimeCalendarCombo.ReadOnly = True
        Me.EntryTimeCalendarCombo.Size = New System.Drawing.Size(155, 21)
        Me.EntryTimeCalendarCombo.TabIndex = 37
        Me.EntryTimeCalendarCombo.TabStop = False
        Me.EntryTimeCalendarCombo.Value = New Date(2012, 8, 30, 0, 0, 0, 0)
        Me.EntryTimeCalendarCombo.VisualStyle = Janus.Windows.CalendarCombo.VisualStyle.Office2007
        Me.EntryTimeCalendarCombo.VisualStyleManager = Me.vsmAnalysisRequestEditor
        '
        'errorProviderAnalysisRequestEditor
        '
        Me.errorProviderAnalysisRequestEditor.ContainerControl = Me
        Me.errorProviderAnalysisRequestEditor.DataSource = Me.bsAnalysisRequest
        '
        'frmAnalysisRequestDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 840)
        Me.Controls.Add(Me.pnlMainHoriz)
        Me.Name = "frmAnalysisRequestDetail"
        Me.Text = "Analysis Request Editor"
        CType(Me.uipmAnalysisRequestEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlMainHoriz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMainHoriz.ResumeLayout(False)
        CType(Me.pnlRequestDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlRequestDetail.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        Me.uiPanel0Container.PerformLayout()
        CType(Me.bsAnalysisRequest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssignees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRequestors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLowerVert, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLowerVert.ResumeLayout(False)
        CType(Me.pnlLogListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogListing.ResumeLayout(False)
        Me.uiPanel1Container.ResumeLayout(False)
        CType(Me.grexRequestLog, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisRequestLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlLogDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlLogDetail.ResumeLayout(False)
        Me.uiPanel3Container.ResumeLayout(False)
        Me.uiPanel3Container.PerformLayout()
        CType(Me.errorProviderAnalysisRequestEditor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uipmAnalysisRequestEditor As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents pnlMainHoriz As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlRequestDetail As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents pnlLowerVert As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents pnlLogListing As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel1Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents pnlLogDetail As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel3Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents buttonOpenRequestDirectory As Janus.Windows.EditControls.UIButton
    Friend WithEvents calComboCloseDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents comboRequestStatus As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents ModifiedTimeCalendarCombo As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents ModifiedByUserEditBox As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents calComboMilestoneDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents editBoxMilestone As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents editBoxDirectoryFullPath As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents checkBoxIsActive As Janus.Windows.EditControls.UICheckBox
    Friend WithEvents comboRequestType As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents calCmboOpenDate As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents comboRequestor As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents editBoxDescription As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents editBoxAnalysisId As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents EditBoxName As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents grexRequestLog As Janus.Windows.GridEX.GridEX
    Friend WithEvents editBoxLogEntryText As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents EntryUserEditBox As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents editBoxEffortMinutes As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents EntryTimeCalendarCombo As Janus.Windows.CalendarCombo.CalendarCombo
    Friend WithEvents vsmAnalysisRequestEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAnalysisRequest As System.Windows.Forms.BindingSource
    Friend WithEvents bsStatuses As System.Windows.Forms.BindingSource
    Friend WithEvents bsTypes As System.Windows.Forms.BindingSource
    Friend WithEvents bsRequestors As System.Windows.Forms.BindingSource
    Friend WithEvents bsAnalysisRequestLogs As System.Windows.Forms.BindingSource
    Friend WithEvents errorProviderAnalysisRequestEditor As System.Windows.Forms.ErrorProvider
    Friend WithEvents editBoxTotalEffortDisplay As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents editBoxTimer As Janus.Windows.GridEX.EditControls.EditBox
    Friend WithEvents buttonTimerPause As System.Windows.Forms.Button
    Friend WithEvents buttonTimerReset As System.Windows.Forms.Button
    Friend WithEvents comboAssignee As Janus.Windows.EditControls.UIComboBox
    Friend WithEvents bsAssignees As System.Windows.Forms.BindingSource
    Friend WithEvents uibuttonNow As Janus.Windows.EditControls.UIButton

End Class
