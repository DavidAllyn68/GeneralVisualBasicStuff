<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMooBenefitMapping
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
        Dim grexMooBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMooBenefitMapping))
        Me.vsmMooBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexMooBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsMooBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsMooBenefit = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefit = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexMooBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMooBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMooBenefit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmMooBenefitMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMooBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexMooBenefitMapping
        '
        Me.grexMooBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexMooBenefitMapping.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexMooBenefitMapping.DataSource = Me.bsMooBenefitMapping
        grexMooBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexMooBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexMooBenefitMapping.DesignTimeLayout = grexMooBenefitMapping_DesignTimeLayout
        Me.grexMooBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexMooBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexMooBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexMooBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexMooBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexMooBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexMooBenefitMapping.Name = "grexMooBenefitMapping"
        Me.grexMooBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexMooBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexMooBenefitMapping.Size = New System.Drawing.Size(803, 509)
        Me.grexMooBenefitMapping.TabIndex = 0
        Me.grexMooBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexMooBenefitMapping.VisualStyleManager = Me.vsmMooBenefitMapping
        '
        'bsMooBenefitMapping
        '
        Me.bsMooBenefitMapping.DataSource = GetType(AscensionAnalytics.MOO_BenefitMapping)
        Me.bsMooBenefitMapping.Sort = "AscensionBenefitId"
        '
        'bsMooBenefit
        '
        Me.bsMooBenefit.DataSource = GetType(AscensionAnalytics.MOO_Benefit)
        '
        'bsAscensionBenefit
        '
        Me.bsAscensionBenefit.DataSource = GetType(AscensionAnalytics.MooMapping_AscensionBenefits)
        '
        'frmMooBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(803, 509)
        Me.Controls.Add(Me.grexMooBenefitMapping)
        Me.Name = "frmMooBenefitMapping"
        Me.Text = "MOO Benefit Mapping"
        CType(Me.grexMooBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMooBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMooBenefit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsMooBenefit As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefit As System.Windows.Forms.BindingSource
    Friend WithEvents bsMooBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents vsmMooBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexMooBenefitMapping As Janus.Windows.GridEX.GridEX
End Class
