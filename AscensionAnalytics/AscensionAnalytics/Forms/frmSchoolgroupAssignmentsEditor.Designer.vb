<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolgroupAssignmentsEditor
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
        Dim gridExSchoolgroupAssignments_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolgroupAssignmentsEditor))
        Me.vsmSchoolgroupAssignments = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.gridExSchoolgroupAssignments = New Janus.Windows.GridEX.GridEX
        Me.bsSchoolgroupAssignment = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdMgrSchoolgroupAssignments = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.cmdASSIGNMENT1 = New Janus.Windows.UI.CommandBars.UICommand("cmdASSIGNMENT")
        Me.cmdASSIGNMENT = New Janus.Windows.UI.CommandBars.UICommand("cmdASSIGNMENT")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdClose1 = New Janus.Windows.UI.CommandBars.UICommand("cmdClose")
        Me.cmdClose = New Janus.Windows.UI.CommandBars.UICommand("cmdClose")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.cmdClose2 = New Janus.Windows.UI.CommandBars.UICommand("cmdClose")
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAssignmentPeople = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAssignmentTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gridExSchoolgroupAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupAssignment, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdMgrSchoolgroupAssignments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssignmentPeople, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssignmentTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmSchoolgroupAssignments
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmSchoolgroupAssignments.ColorSchemes.Add(JanusColorScheme1)
        '
        'gridExSchoolgroupAssignments
        '
        Me.gridExSchoolgroupAssignments.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExSchoolgroupAssignments.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExSchoolgroupAssignments.DataSource = Me.bsSchoolgroupAssignment
        gridExSchoolgroupAssignments_DesignTimeLayout.LayoutString = resources.GetString("gridExSchoolgroupAssignments_DesignTimeLayout.LayoutString")
        Me.gridExSchoolgroupAssignments.DesignTimeLayout = gridExSchoolgroupAssignments_DesignTimeLayout
        Me.gridExSchoolgroupAssignments.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExSchoolgroupAssignments.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExSchoolgroupAssignments.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExSchoolgroupAssignments.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExSchoolgroupAssignments.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExSchoolgroupAssignments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.gridExSchoolgroupAssignments.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.gridExSchoolgroupAssignments.Location = New System.Drawing.Point(0, 26)
        Me.gridExSchoolgroupAssignments.Name = "gridExSchoolgroupAssignments"
        Me.gridExSchoolgroupAssignments.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExSchoolgroupAssignments.RecordNavigator = True
        Me.gridExSchoolgroupAssignments.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExSchoolgroupAssignments.Size = New System.Drawing.Size(906, 405)
        Me.gridExSchoolgroupAssignments.TabIndex = 0
        Me.gridExSchoolgroupAssignments.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExSchoolgroupAssignments.VisualStyleManager = Me.vsmSchoolgroupAssignments
        '
        'bsSchoolgroupAssignment
        '
        Me.bsSchoolgroupAssignment.DataSource = GetType(AscensionAnalytics.SchoolgroupAssignment)
        Me.bsSchoolgroupAssignment.Sort = "schoolgroup_cd"
        '
        'cmdMgrSchoolgroupAssignments
        '
        Me.cmdMgrSchoolgroupAssignments.BottomRebar = Me.BottomRebar1
        Me.cmdMgrSchoolgroupAssignments.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.cmdMgrSchoolgroupAssignments.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdASSIGNMENT, Me.cmdClose})
        Me.cmdMgrSchoolgroupAssignments.ContainerControl = Me
        '
        '
        '
        Me.cmdMgrSchoolgroupAssignments.EditContextMenu.Key = ""
        Me.cmdMgrSchoolgroupAssignments.Id = New System.Guid("97ad0adf-af31-4403-900b-bb0e380220f4")
        Me.cmdMgrSchoolgroupAssignments.LeftRebar = Me.LeftRebar1
        Me.cmdMgrSchoolgroupAssignments.RightRebar = Me.RightRebar1
        Me.cmdMgrSchoolgroupAssignments.TopRebar = Me.TopRebar1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.cmdMgrSchoolgroupAssignments
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 431)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(906, 0)
        '
        'UiCommandBar1
        '
        Me.UiCommandBar1.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu
        Me.UiCommandBar1.CommandManager = Me.cmdMgrSchoolgroupAssignments
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdASSIGNMENT1})
        Me.UiCommandBar1.Key = "mainMenu"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(906, 26)
        Me.UiCommandBar1.Text = "CommandBar1"
        '
        'cmdASSIGNMENT1
        '
        Me.cmdASSIGNMENT1.Key = "cmdASSIGNMENT"
        Me.cmdASSIGNMENT1.Name = "cmdASSIGNMENT1"
        '
        'cmdASSIGNMENT
        '
        Me.cmdASSIGNMENT.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.Separator1, Me.cmdClose1})
        Me.cmdASSIGNMENT.Key = "cmdASSIGNMENT"
        Me.cmdASSIGNMENT.Name = "cmdASSIGNMENT"
        Me.cmdASSIGNMENT.Text = "Assignments"
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'cmdClose1
        '
        Me.cmdClose1.Key = "cmdClose"
        Me.cmdClose1.Name = "cmdClose1"
        '
        'cmdClose
        '
        Me.cmdClose.Key = "cmdClose"
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Text = "Close Assignments"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.cmdMgrSchoolgroupAssignments
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 26)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 405)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.cmdMgrSchoolgroupAssignments
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(906, 26)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 405)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.TopRebar1.CommandManager = Me.cmdMgrSchoolgroupAssignments
        Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(906, 26)
        '
        'cmdClose2
        '
        Me.cmdClose2.Key = "cmdClose"
        Me.cmdClose2.Name = "cmdClose2"
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.SchoolgroupAssignmentSchoolgroup)
        Me.bsSchoolgroups.Sort = "schoolgroup_cd"
        '
        'bsAssignmentPeople
        '
        Me.bsAssignmentPeople.DataSource = GetType(AscensionAnalytics.AnalysisPeople)
        Me.bsAssignmentPeople.Sort = "Name"
        '
        'bsAssignmentTypes
        '
        Me.bsAssignmentTypes.DataSource = GetType(AscensionAnalytics.SchoolgroupAssignmentType)
        Me.bsAssignmentTypes.Sort = "SchoolgroupAssignmentType"
        '
        'frmSchoolgroupAssignmentsEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(906, 431)
        Me.Controls.Add(Me.gridExSchoolgroupAssignments)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmSchoolgroupAssignmentsEditor"
        Me.Text = "Schoolgroup Assignments"
        CType(Me.gridExSchoolgroupAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupAssignment, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdMgrSchoolgroupAssignments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssignmentPeople, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssignmentTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmSchoolgroupAssignments As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents gridExSchoolgroupAssignments As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsSchoolgroupAssignment As System.Windows.Forms.BindingSource
    Friend WithEvents bsAssignmentPeople As System.Windows.Forms.BindingSource
    Friend WithEvents bsAssignmentTypes As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
    Friend WithEvents cmdMgrSchoolgroupAssignments As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
    Friend WithEvents cmdASSIGNMENT As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdASSIGNMENT1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdClose1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdClose As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdClose2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
End Class
