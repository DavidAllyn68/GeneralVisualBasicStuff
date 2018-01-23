<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverlandParkBTSBenefitMapping
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
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim grexOPBTSBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverlandParkBTSBenefitMapping))
        Me.vsmOPBTSBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexOPBTSBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsOPBTSBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsOPBTSBenefits = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefits = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexOPBTSBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOPBTSBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOPBTSBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmOPBTSBenefitMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "2007AscensionBlue"
        JanusColorScheme2.OfficeColorScheme = Janus.Windows.Common.OfficeColorScheme.Custom
        JanusColorScheme2.OfficeCustomColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(83, Byte), Integer), CType(CType(148, Byte), Integer))
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        JanusColorScheme2.WindowColor = System.Drawing.Color.FromArgb(CType(CType(221, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.vsmOPBTSBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        Me.vsmOPBTSBenefitMapping.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmOPBTSBenefitMapping.DefaultColorScheme = "Scheme0"
        '
        'grexOPBTSBenefitMapping
        '
        Me.grexOPBTSBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOPBTSBenefitMapping.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOPBTSBenefitMapping.DataSource = Me.bsOPBTSBenefitMapping
        grexOPBTSBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexOPBTSBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexOPBTSBenefitMapping.DesignTimeLayout = grexOPBTSBenefitMapping_DesignTimeLayout
        Me.grexOPBTSBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexOPBTSBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexOPBTSBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexOPBTSBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexOPBTSBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexOPBTSBenefitMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grexOPBTSBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexOPBTSBenefitMapping.Name = "grexOPBTSBenefitMapping"
        Me.grexOPBTSBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexOPBTSBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOPBTSBenefitMapping.Size = New System.Drawing.Size(788, 500)
        Me.grexOPBTSBenefitMapping.TabIndex = 0
        Me.grexOPBTSBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexOPBTSBenefitMapping.VisualStyleManager = Me.vsmOPBTSBenefitMapping
        '
        'bsOPBTSBenefitMapping
        '
        Me.bsOPBTSBenefitMapping.DataSource = GetType(AscensionAnalytics.OverlandParkBTS_BenefitMapping)
        Me.bsOPBTSBenefitMapping.Sort = "AscensionBenefitId"
        '
        'bsOPBTSBenefits
        '
        Me.bsOPBTSBenefits.DataSource = GetType(AscensionAnalytics.OverlandParkBTS_BenefitCode)
        '
        'bsAscensionBenefits
        '
        Me.bsAscensionBenefits.DataSource = GetType(AscensionAnalytics.OPBTS_BenefitMapping_AscensionBenefit)
        '
        'frmOverlandParkBTSBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 500)
        Me.Controls.Add(Me.grexOPBTSBenefitMapping)
        Me.Name = "frmOverlandParkBTSBenefitMapping"
        Me.Text = "Overland Park BTS Benefit Mapping"
        CType(Me.grexOPBTSBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOPBTSBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOPBTSBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmOPBTSBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexOPBTSBenefitMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsOPBTSBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsOPBTSBenefits As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefits As System.Windows.Forms.BindingSource
End Class
