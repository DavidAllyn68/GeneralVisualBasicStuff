<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewerAvailableReportParameterValues
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
        Dim grexAvailableReportParameters_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewerAvailableReportParameterValues))
        Me.vsmAvailableReportParameters = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexAvailableReportParameters = New Janus.Windows.GridEX.GridEX
        Me.bsAvailableReportParameters = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAvailableReportParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAvailableReportParameters, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAvailableReportParameters
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAvailableReportParameters.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexAvailableReportParameters
        '
        Me.grexAvailableReportParameters.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableReportParameters.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableReportParameters.DataSource = Me.bsAvailableReportParameters
        grexAvailableReportParameters_DesignTimeLayout.LayoutString = resources.GetString("grexAvailableReportParameters_DesignTimeLayout.LayoutString")
        Me.grexAvailableReportParameters.DesignTimeLayout = grexAvailableReportParameters_DesignTimeLayout
        Me.grexAvailableReportParameters.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAvailableReportParameters.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAvailableReportParameters.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAvailableReportParameters.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAvailableReportParameters.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAvailableReportParameters.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexAvailableReportParameters.Location = New System.Drawing.Point(0, 0)
        Me.grexAvailableReportParameters.Name = "grexAvailableReportParameters"
        Me.grexAvailableReportParameters.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAvailableReportParameters.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAvailableReportParameters.Size = New System.Drawing.Size(991, 262)
        Me.grexAvailableReportParameters.TabIndex = 0
        Me.grexAvailableReportParameters.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAvailableReportParameters.VisualStyleManager = Me.vsmAvailableReportParameters
        '
        'bsAvailableReportParameters
        '
        Me.bsAvailableReportParameters.DataSource = GetType(AscensionAnalytics.ReportViewer_AvailableReportParameterValue)
        '
        'frmReportViewerAvailableReportParameterValues
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(991, 262)
        Me.Controls.Add(Me.grexAvailableReportParameters)
        Me.Name = "frmReportViewerAvailableReportParameterValues"
        Me.Text = "ReportViewer Available Report Parmeter Values"
        CType(Me.grexAvailableReportParameters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAvailableReportParameters, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAvailableReportParameters As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexAvailableReportParameters As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsAvailableReportParameters As System.Windows.Forms.BindingSource
End Class
