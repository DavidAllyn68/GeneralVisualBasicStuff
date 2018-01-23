<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestLogListing
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
        Dim grexLogListing_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestLogListing))
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexLogListing = New Janus.Windows.GridEX.GridEX
        Me.bsLogs = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAnalysisRequests = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexLogListing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLogs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexLogListing
        '
        Me.grexLogListing.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grexLogListing.DataSource = Me.bsLogs
        Me.grexLogListing.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        grexLogListing_DesignTimeLayout.LayoutString = resources.GetString("grexLogListing_DesignTimeLayout.LayoutString")
        Me.grexLogListing.DesignTimeLayout = grexLogListing_DesignTimeLayout
        Me.grexLogListing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexLogListing.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexLogListing.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexLogListing.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexLogListing.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexLogListing.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexLogListing.Location = New System.Drawing.Point(0, 0)
        Me.grexLogListing.Name = "grexLogListing"
        Me.grexLogListing.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexLogListing.Size = New System.Drawing.Size(1234, 344)
        Me.grexLogListing.TabIndex = 0
        Me.grexLogListing.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexLogListing.VisualStyleManager = Me.VisualStyleManager1
        '
        'bsLogs
        '
        Me.bsLogs.AllowNew = False
        Me.bsLogs.DataSource = GetType(AscensionAnalytics.AnalysisRequestLog)
        '
        'bsAnalysisRequests
        '
        Me.bsAnalysisRequests.DataSource = GetType(AscensionAnalytics.AnalysisRequest)
        '
        'frmAnalysisRequestLogListing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 344)
        Me.Controls.Add(Me.grexLogListing)
        Me.Name = "frmAnalysisRequestLogListing"
        Me.Text = "Analysis Request Log Listing (Double-click log to open request)"
        CType(Me.grexLogListing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLogs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexLogListing As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsLogs As System.Windows.Forms.BindingSource
    Friend WithEvents bsAnalysisRequests As System.Windows.Forms.BindingSource
End Class
