<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestStatusEditor
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
        Dim gridExAnalysisRequestStatus_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestStatusEditor))
        Me.vsmAnalysisRequestStatusEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.gridExAnalysisRequestStatus = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisRequestStatus = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gridExAnalysisRequestStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisRequestStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAnalysisRequestStatusEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnalysisRequestStatusEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'gridExAnalysisRequestStatus
        '
        Me.gridExAnalysisRequestStatus.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisRequestStatus.DataSource = Me.bsAnalysisRequestStatus
        gridExAnalysisRequestStatus_DesignTimeLayout.LayoutString = resources.GetString("gridExAnalysisRequestStatus_DesignTimeLayout.LayoutString")
        Me.gridExAnalysisRequestStatus.DesignTimeLayout = gridExAnalysisRequestStatus_DesignTimeLayout
        Me.gridExAnalysisRequestStatus.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExAnalysisRequestStatus.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExAnalysisRequestStatus.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExAnalysisRequestStatus.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExAnalysisRequestStatus.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExAnalysisRequestStatus.GroupByBoxVisible = False
        Me.gridExAnalysisRequestStatus.Location = New System.Drawing.Point(0, 0)
        Me.gridExAnalysisRequestStatus.Name = "gridExAnalysisRequestStatus"
        Me.gridExAnalysisRequestStatus.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExAnalysisRequestStatus.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisRequestStatus.Size = New System.Drawing.Size(403, 385)
        Me.gridExAnalysisRequestStatus.TabIndex = 0
        Me.gridExAnalysisRequestStatus.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExAnalysisRequestStatus.VisualStyleManager = Me.vsmAnalysisRequestStatusEditor
        '
        'bsAnalysisRequestStatus
        '
        Me.bsAnalysisRequestStatus.DataSource = GetType(AscensionAnalytics.AnalysisRequestStatus)
        '
        'frmAnalysisRequestStatusEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(403, 385)
        Me.Controls.Add(Me.gridExAnalysisRequestStatus)
        Me.Name = "frmAnalysisRequestStatusEditor"
        Me.Text = "Analysis Request Status"
        CType(Me.gridExAnalysisRequestStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisRequestStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAnalysisRequestStatusEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAnalysisRequestStatus As System.Windows.Forms.BindingSource
    Friend WithEvents gridExAnalysisRequestStatus As Janus.Windows.GridEX.GridEX
End Class
