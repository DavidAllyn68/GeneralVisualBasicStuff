<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPiaBenefitMapping
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
        Dim grexPiaBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiaBenefitMapping))
        Me.vsmPiaBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexPiaBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsPiaBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPiaBenefits = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefits = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexPiaBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPiaBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPiaBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmPiaBenefitMapping
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
        Me.vsmPiaBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        Me.vsmPiaBenefitMapping.ColorSchemes.Add(JanusColorScheme2)
        Me.vsmPiaBenefitMapping.DefaultColorScheme = "Scheme0"
        '
        'grexPiaBenefitMapping
        '
        Me.grexPiaBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexPiaBenefitMapping.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexPiaBenefitMapping.DataSource = Me.bsPiaBenefitMapping
        grexPiaBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexPiaBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexPiaBenefitMapping.DesignTimeLayout = grexPiaBenefitMapping_DesignTimeLayout
        Me.grexPiaBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexPiaBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexPiaBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexPiaBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexPiaBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexPiaBenefitMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexPiaBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexPiaBenefitMapping.Name = "grexPiaBenefitMapping"
        Me.grexPiaBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexPiaBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexPiaBenefitMapping.Size = New System.Drawing.Size(788, 500)
        Me.grexPiaBenefitMapping.TabIndex = 0
        Me.grexPiaBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexPiaBenefitMapping.VisualStyleManager = Me.vsmPiaBenefitMapping
        '
        'bsPiaBenefitMapping
        '
        Me.bsPiaBenefitMapping.DataSource = GetType(AscensionAnalytics.PIA_BenefitMapping)
        Me.bsPiaBenefitMapping.Sort = "AscensionBenefitId"
        '
        'bsPiaBenefits
        '
        Me.bsPiaBenefits.DataSource = GetType(AscensionAnalytics.PIA_Benefits)
        '
        'bsAscensionBenefits
        '
        Me.bsAscensionBenefits.DataSource = GetType(AscensionAnalytics.PiaMapping_AscensionBenefits)
        '
        'frmPiaBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(788, 500)
        Me.Controls.Add(Me.grexPiaBenefitMapping)
        Me.Name = "frmPiaBenefitMapping"
        Me.Text = "PIA Benefit Mapping"
        CType(Me.grexPiaBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPiaBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPiaBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmPiaBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexPiaBenefitMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsPiaBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsPiaBenefits As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefits As System.Windows.Forms.BindingSource
End Class
