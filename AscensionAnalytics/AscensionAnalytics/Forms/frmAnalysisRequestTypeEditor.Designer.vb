<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestTypeEditor
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
        Dim gridExAnalysisRequestType_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestTypeEditor))
        Me.vsmAnalysisRequestTypeEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.gridExAnalysisRequestType = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisRequestType = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gridExAnalysisRequestType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisRequestType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAnalysisRequestTypeEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnalysisRequestTypeEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'gridExAnalysisRequestType
        '
        Me.gridExAnalysisRequestType.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisRequestType.DataSource = Me.bsAnalysisRequestType
        gridExAnalysisRequestType_DesignTimeLayout.LayoutString = resources.GetString("gridExAnalysisRequestType_DesignTimeLayout.LayoutString")
        Me.gridExAnalysisRequestType.DesignTimeLayout = gridExAnalysisRequestType_DesignTimeLayout
        Me.gridExAnalysisRequestType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExAnalysisRequestType.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.gridExAnalysisRequestType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.gridExAnalysisRequestType.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.gridExAnalysisRequestType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.gridExAnalysisRequestType.GroupByBoxVisible = False
        Me.gridExAnalysisRequestType.Location = New System.Drawing.Point(0, 0)
        Me.gridExAnalysisRequestType.Name = "gridExAnalysisRequestType"
        Me.gridExAnalysisRequestType.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.gridExAnalysisRequestType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.gridExAnalysisRequestType.Size = New System.Drawing.Size(423, 262)
        Me.gridExAnalysisRequestType.TabIndex = 0
        Me.gridExAnalysisRequestType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.gridExAnalysisRequestType.VisualStyleManager = Me.vsmAnalysisRequestTypeEditor
        '
        'bsAnalysisRequestType
        '
        Me.bsAnalysisRequestType.DataSource = GetType(AscensionAnalytics.AnalysisRequestType)
        Me.bsAnalysisRequestType.Sort = "RequestType"
        '
        'frmAnalysisRequestTypeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(423, 262)
        Me.Controls.Add(Me.gridExAnalysisRequestType)
        Me.Name = "frmAnalysisRequestTypeEditor"
        Me.Text = "Analysis Request Type Editor"
        CType(Me.gridExAnalysisRequestType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisRequestType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAnalysisRequestTypeEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAnalysisRequestType As System.Windows.Forms.BindingSource
    Friend WithEvents gridExAnalysisRequestType As Janus.Windows.GridEX.GridEX
End Class
