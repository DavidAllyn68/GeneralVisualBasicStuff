<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSampleReportingProcessing
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
        Dim grexSchoolgroupsToProcess_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSampleReportingProcessing))
        Me.bsSchoolgroupsToProcess = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLookupSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsLookupPolicyYears = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.UiCommandManager1 = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.UiCommandBar1 = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.cmdProcessSampleData1 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessSampleData")
        Me.cmdProcessSampleData = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessSampleData")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.grexSchoolgroupsToProcess = New Janus.Windows.GridEX.GridEX
        CType(Me.bsSchoolgroupsToProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLookupSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLookupPolicyYears, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        CType(Me.grexSchoolgroupsToProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bsSchoolgroupsToProcess
        '
        Me.bsSchoolgroupsToProcess.DataSource = GetType(AscensionAnalytics.SampleReporting_SchoolgroupsToProcess)
        '
        'bsLookupSchoolgroups
        '
        Me.bsLookupSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'bsLookupPolicyYears
        '
        Me.bsLookupPolicyYears.DataSource = GetType(AscensionAnalytics.PolicyYear)
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        '
        'UiCommandManager1
        '
        Me.UiCommandManager1.BottomRebar = Me.BottomRebar1
        Me.UiCommandManager1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.UiCommandManager1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdProcessSampleData})
        Me.UiCommandManager1.ContainerControl = Me
        '
        '
        '
        Me.UiCommandManager1.EditContextMenu.Key = ""
        Me.UiCommandManager1.Id = New System.Guid("fa64e8ac-d163-4fb9-8eca-93ab5681f96c")
        Me.UiCommandManager1.LeftRebar = Me.LeftRebar1
        Me.UiCommandManager1.RightRebar = Me.RightRebar1
        Me.UiCommandManager1.TopRebar = Me.TopRebar1
        Me.UiCommandManager1.VisualStyleManager = Me.VisualStyleManager1
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.UiCommandManager1
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 477)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(1185, 0)
        '
        'UiCommandBar1
        '
        Me.UiCommandBar1.CommandManager = Me.UiCommandManager1
        Me.UiCommandBar1.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdProcessSampleData1})
        Me.UiCommandBar1.Key = "CommandBar1"
        Me.UiCommandBar1.Location = New System.Drawing.Point(0, 0)
        Me.UiCommandBar1.Name = "UiCommandBar1"
        Me.UiCommandBar1.RowIndex = 0
        Me.UiCommandBar1.Size = New System.Drawing.Size(136, 28)
        Me.UiCommandBar1.Text = "CommandBar1"
        '
        'cmdProcessSampleData1
        '
        Me.cmdProcessSampleData1.Key = "cmdProcessSampleData"
        Me.cmdProcessSampleData1.Name = "cmdProcessSampleData1"
        '
        'cmdProcessSampleData
        '
        Me.cmdProcessSampleData.Key = "cmdProcessSampleData"
        Me.cmdProcessSampleData.Name = "cmdProcessSampleData"
        Me.cmdProcessSampleData.Text = "Process Sample Data"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.UiCommandManager1
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 28)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 449)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.UiCommandManager1
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(1185, 28)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 449)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.UiCommandBar1})
        Me.TopRebar1.CommandManager = Me.UiCommandManager1
        Me.TopRebar1.Controls.Add(Me.UiCommandBar1)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1185, 28)
        '
        'grexSchoolgroupsToProcess
        '
        Me.grexSchoolgroupsToProcess.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupsToProcess.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupsToProcess.DataSource = Me.bsSchoolgroupsToProcess
        Me.grexSchoolgroupsToProcess.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        grexSchoolgroupsToProcess_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolgroupsToProcess_DesignTimeLayout.LayoutString")
        Me.grexSchoolgroupsToProcess.DesignTimeLayout = grexSchoolgroupsToProcess_DesignTimeLayout
        Me.grexSchoolgroupsToProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolgroupsToProcess.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolgroupsToProcess.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolgroupsToProcess.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexSchoolgroupsToProcess.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexSchoolgroupsToProcess.Location = New System.Drawing.Point(0, 28)
        Me.grexSchoolgroupsToProcess.Name = "grexSchoolgroupsToProcess"
        Me.grexSchoolgroupsToProcess.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexSchoolgroupsToProcess.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupsToProcess.Size = New System.Drawing.Size(1185, 449)
        Me.grexSchoolgroupsToProcess.TabIndex = 4
        Me.grexSchoolgroupsToProcess.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolgroupsToProcess.VisualStyleManager = Me.VisualStyleManager1
        '
        'frmSampleReportingProcessing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1185, 477)
        Me.Controls.Add(Me.grexSchoolgroupsToProcess)
        Me.Controls.Add(Me.LeftRebar1)
        Me.Controls.Add(Me.RightRebar1)
        Me.Controls.Add(Me.TopRebar1)
        Me.Controls.Add(Me.BottomRebar1)
        Me.Name = "frmSampleReportingProcessing"
        Me.Text = "Sample Reporting Data Processing"
        CType(Me.bsSchoolgroupsToProcess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLookupSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLookupPolicyYears, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiCommandBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        CType(Me.grexSchoolgroupsToProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsSchoolgroupsToProcess As System.Windows.Forms.BindingSource
    Friend WithEvents bsLookupSchoolgroups As System.Windows.Forms.BindingSource
    Friend WithEvents bsLookupPolicyYears As System.Windows.Forms.BindingSource
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiCommandManager1 As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents grexSchoolgroupsToProcess As Janus.Windows.GridEX.GridEX
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents UiCommandBar1 As Janus.Windows.UI.CommandBars.UICommandBar
    Friend WithEvents cmdProcessSampleData1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcessSampleData As Janus.Windows.UI.CommandBars.UICommand
End Class
