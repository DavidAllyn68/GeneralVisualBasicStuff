<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestListing
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
        Dim grexAnalysisRequestListing_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestListing))
        Me.vsmAnalysisRequestListing = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexAnalysisRequestListing = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisRequestListing = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsStatuses = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsRequestors = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAssignees = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAnalysisRequestListing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisRequestListing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatuses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRequestors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAssignees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAnalysisRequestListing
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnalysisRequestListing.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexAnalysisRequestListing
        '
        Me.grexAnalysisRequestListing.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAnalysisRequestListing.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grexAnalysisRequestListing.DataSource = Me.bsAnalysisRequestListing
        Me.grexAnalysisRequestListing.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        grexAnalysisRequestListing_DesignTimeLayout.LayoutString = resources.GetString("grexAnalysisRequestListing_DesignTimeLayout.LayoutString")
        Me.grexAnalysisRequestListing.DesignTimeLayout = grexAnalysisRequestListing_DesignTimeLayout
        Me.grexAnalysisRequestListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAnalysisRequestListing.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAnalysisRequestListing.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAnalysisRequestListing.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAnalysisRequestListing.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAnalysisRequestListing.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexAnalysisRequestListing.GroupRowFormatStyle.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.grexAnalysisRequestListing.Location = New System.Drawing.Point(0, 0)
        Me.grexAnalysisRequestListing.Name = "grexAnalysisRequestListing"
        Me.grexAnalysisRequestListing.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToAddedRow
        Me.grexAnalysisRequestListing.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAnalysisRequestListing.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAnalysisRequestListing.Size = New System.Drawing.Size(1302, 492)
        Me.grexAnalysisRequestListing.TabIndex = 0
        Me.grexAnalysisRequestListing.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAnalysisRequestListing.VisualStyleManager = Me.vsmAnalysisRequestListing
        '
        'bsAnalysisRequestListing
        '
        Me.bsAnalysisRequestListing.DataSource = GetType(AscensionAnalytics.AnalysisRequest)
        '
        'bsTypes
        '
        Me.bsTypes.DataSource = GetType(AscensionAnalytics.AnalysisRequestType)
        '
        'bsStatuses
        '
        Me.bsStatuses.DataSource = GetType(AscensionAnalytics.AnalysisRequestStatus)
        '
        'bsRequestors
        '
        Me.bsRequestors.DataSource = GetType(AscensionAnalytics.AnalysisRequestPeople)
        '
        'bsAssignees
        '
        Me.bsAssignees.DataSource = GetType(AscensionAnalytics.AnalysisRequestPeople)
        '
        'frmAnalysisRequestListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1302, 492)
        Me.Controls.Add(Me.grexAnalysisRequestListing)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "frmAnalysisRequestListing"
        Me.Text = "Analysis Request Listing (Double Click To Open Request)"
        CType(Me.grexAnalysisRequestListing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisRequestListing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatuses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRequestors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAssignees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsAnalysisRequestListing As System.Windows.Forms.BindingSource
    Friend WithEvents vsmAnalysisRequestListing As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexAnalysisRequestListing As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsTypes As System.Windows.Forms.BindingSource
    Friend WithEvents bsStatuses As System.Windows.Forms.BindingSource
    Friend WithEvents bsRequestors As System.Windows.Forms.BindingSource
    Friend WithEvents bsAssignees As System.Windows.Forms.BindingSource
End Class
