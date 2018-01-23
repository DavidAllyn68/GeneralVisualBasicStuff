<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAetnaBenefitTypes
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
        Dim grexAetnaBenefitTypes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAetnaBenefitTypes))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexAetnaBenefitTypes = New Janus.Windows.GridEX.GridEX
        Me.bsAetnaBenefitTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmTemplate = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexAetnaBenefitTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAetnaBenefitTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexAetnaBenefitTypes
        '
        Me.grexAetnaBenefitTypes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaBenefitTypes.DataSource = Me.bsAetnaBenefitTypes
        grexAetnaBenefitTypes_DesignTimeLayout.LayoutString = resources.GetString("grexAetnaBenefitTypes_DesignTimeLayout.LayoutString")
        Me.grexAetnaBenefitTypes.DesignTimeLayout = grexAetnaBenefitTypes_DesignTimeLayout
        Me.grexAetnaBenefitTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAetnaBenefitTypes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAetnaBenefitTypes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAetnaBenefitTypes.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAetnaBenefitTypes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAetnaBenefitTypes.Location = New System.Drawing.Point(0, 0)
        Me.grexAetnaBenefitTypes.Name = "grexAetnaBenefitTypes"
        Me.grexAetnaBenefitTypes.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAetnaBenefitTypes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaBenefitTypes.Size = New System.Drawing.Size(489, 238)
        Me.grexAetnaBenefitTypes.TabIndex = 0
        Me.grexAetnaBenefitTypes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAetnaBenefitTypes.VisualStyleManager = Me.vsmTemplate
        '
        'bsAetnaBenefitTypes
        '
        Me.bsAetnaBenefitTypes.DataSource = GetType(AscensionAnalytics.Aetna_BenefitType)
        '
        'vsmTemplate
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmTemplate.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmAetnaBenefitTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexAetnaBenefitTypes)
        Me.Name = "frmAetnaBenefitTypes"
        Me.Text = "Aetna Benefit Types"
        CType(Me.grexAetnaBenefitTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAetnaBenefitTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexAetnaBenefitTypes As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmTemplate As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAetnaBenefitTypes As System.Windows.Forms.BindingSource
End Class
