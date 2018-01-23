<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewerAvailableGroupingItems
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
        Dim grexAvailableGroupingItems_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewerAvailableGroupingItems))
        Me.vsmReportViewerAvailableGroupingItems = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexAvailableGroupingItems = New Janus.Windows.GridEX.GridEX
        Me.bsReportViewerAvailableGroupingItems = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAvailableGroupingItems, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReportViewerAvailableGroupingItems, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmReportViewerAvailableGroupingItems
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmReportViewerAvailableGroupingItems.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexAvailableGroupingItems
        '
        Me.grexAvailableGroupingItems.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableGroupingItems.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableGroupingItems.DataSource = Me.bsReportViewerAvailableGroupingItems
        grexAvailableGroupingItems_DesignTimeLayout.LayoutString = resources.GetString("grexAvailableGroupingItems_DesignTimeLayout.LayoutString")
        Me.grexAvailableGroupingItems.DesignTimeLayout = grexAvailableGroupingItems_DesignTimeLayout
        Me.grexAvailableGroupingItems.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAvailableGroupingItems.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAvailableGroupingItems.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAvailableGroupingItems.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAvailableGroupingItems.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAvailableGroupingItems.Location = New System.Drawing.Point(0, 0)
        Me.grexAvailableGroupingItems.Name = "grexAvailableGroupingItems"
        Me.grexAvailableGroupingItems.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAvailableGroupingItems.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableGroupingItems.Size = New System.Drawing.Size(708, 262)
        Me.grexAvailableGroupingItems.TabIndex = 0
        Me.grexAvailableGroupingItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAvailableGroupingItems.VisualStyleManager = Me.vsmReportViewerAvailableGroupingItems
        '
        'bsReportViewerAvailableGroupingItems
        '
        Me.bsReportViewerAvailableGroupingItems.DataSource = GetType(AscensionAnalytics.ReportViewer_AvailableGroupingItem)
        '
        'frmReportViewerAvailableGroupingItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 262)
        Me.Controls.Add(Me.grexAvailableGroupingItems)
        Me.Name = "frmReportViewerAvailableGroupingItems"
        Me.Text = "ReportViewer Available Grouping Items"
        CType(Me.grexAvailableGroupingItems, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReportViewerAvailableGroupingItems, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmReportViewerAvailableGroupingItems As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexAvailableGroupingItems As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsReportViewerAvailableGroupingItems As System.Windows.Forms.BindingSource
End Class
