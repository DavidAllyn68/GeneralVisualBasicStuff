<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAetnaBenefitMapping
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
        Dim grexAetnaBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAetnaBenefitMapping))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexAetnaBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsAetnaBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmAetnaBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsPlaceOfServiceCodes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsBenefitTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefits = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAetnaBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAetnaBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPlaceOfServiceCodes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBenefitTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexAetnaBenefitMapping
        '
        Me.grexAetnaBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaBenefitMapping.DataSource = Me.bsAetnaBenefitMapping
        grexAetnaBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexAetnaBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexAetnaBenefitMapping.DesignTimeLayout = grexAetnaBenefitMapping_DesignTimeLayout
        Me.grexAetnaBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAetnaBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAetnaBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAetnaBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAetnaBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAetnaBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexAetnaBenefitMapping.Name = "grexAetnaBenefitMapping"
        Me.grexAetnaBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAetnaBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaBenefitMapping.Size = New System.Drawing.Size(845, 238)
        Me.grexAetnaBenefitMapping.TabIndex = 0
        Me.grexAetnaBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAetnaBenefitMapping.VisualStyleManager = Me.vsmAetnaBenefitMapping
        '
        'bsAetnaBenefitMapping
        '
        Me.bsAetnaBenefitMapping.DataSource = GetType(AscensionAnalytics.Aetna_BenefitMapping)
        '
        'vsmAetnaBenefitMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAetnaBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsPlaceOfServiceCodes
        '
        Me.bsPlaceOfServiceCodes.DataSource = GetType(AscensionAnalytics.Aetna_PlaceOfServiceCode)
        '
        'bsBenefitTypes
        '
        Me.bsBenefitTypes.DataSource = GetType(AscensionAnalytics.Aetna_BenefitType)
        '
        'bsAscensionBenefits
        '
        Me.bsAscensionBenefits.DataSource = GetType(AscensionAnalytics.Aetna_AscensionBenefit)
        '
        'frmAetnaBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(845, 238)
        Me.Controls.Add(Me.grexAetnaBenefitMapping)
        Me.Name = "frmAetnaBenefitMapping"
        Me.Text = "Aetna Benefit Mapping"
        CType(Me.grexAetnaBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAetnaBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPlaceOfServiceCodes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBenefitTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexAetnaBenefitMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmAetnaBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAetnaBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsPlaceOfServiceCodes As System.Windows.Forms.BindingSource
    Friend WithEvents bsBenefitTypes As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefits As System.Windows.Forms.BindingSource
End Class
