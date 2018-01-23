<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarketingDb_SchoolgroupMapping
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
        Dim grexSchoolgroupMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarketingDb_SchoolgroupMapping))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexSchoolgroupMapping = New Janus.Windows.GridEX.GridEX
        Me.vsmMarketingDbSchoolgroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsSchoolgroupMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPremiumSystemSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexSchoolgroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPremiumSystemSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexSchoolgroupMapping
        '
        Me.grexSchoolgroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupMapping.DataSource = Me.bsSchoolgroupMapping
        grexSchoolgroupMapping_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolgroupMapping_DesignTimeLayout.LayoutString")
        Me.grexSchoolgroupMapping.DesignTimeLayout = grexSchoolgroupMapping_DesignTimeLayout
        Me.grexSchoolgroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolgroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolgroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolgroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexSchoolgroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexSchoolgroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexSchoolgroupMapping.Name = "grexSchoolgroupMapping"
        Me.grexSchoolgroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexSchoolgroupMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupMapping.Size = New System.Drawing.Size(799, 334)
        Me.grexSchoolgroupMapping.TabIndex = 0
        Me.grexSchoolgroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolgroupMapping.VisualStyleManager = Me.vsmMarketingDbSchoolgroupMapping
        '
        'vsmMarketingDbSchoolgroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMarketingDbSchoolgroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsSchoolgroupMapping
        '
        Me.bsSchoolgroupMapping.DataSource = GetType(AscensionAnalytics.MarketingDB_SchoolgroupMapping)
        '
        'bsPremiumSystemSchoolgroups
        '
        Me.bsPremiumSystemSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'frmMarketingDb_SchoolgroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 334)
        Me.Controls.Add(Me.grexSchoolgroupMapping)
        Me.Name = "frmMarketingDb_SchoolgroupMapping"
        Me.Text = "Analysis Person Type"
        CType(Me.grexSchoolgroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPremiumSystemSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexSchoolgroupMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmMarketingDbSchoolgroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsSchoolgroupMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsPremiumSystemSchoolgroups As System.Windows.Forms.BindingSource
End Class
