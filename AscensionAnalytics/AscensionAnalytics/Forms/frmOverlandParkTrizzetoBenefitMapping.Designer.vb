<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverlandParkTrizzetoBenefitMapping
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
        Dim grexOverlandParkTrizzetoBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverlandParkTrizzetoBenefitMapping))
        Me.vsmHthBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexOverlandParkTrizzetoBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsOverlandParkTrizzetoBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefits = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPlaceOfService = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexOverlandParkTrizzetoBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOverlandParkTrizzetoBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPlaceOfService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmHthBenefitMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmHthBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexOverlandParkTrizzetoBenefitMapping
        '
        Me.grexOverlandParkTrizzetoBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkTrizzetoBenefitMapping.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkTrizzetoBenefitMapping.DataSource = Me.bsOverlandParkTrizzetoBenefitMapping
        grexOverlandParkTrizzetoBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexOverlandParkTrizzetoBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexOverlandParkTrizzetoBenefitMapping.DesignTimeLayout = grexOverlandParkTrizzetoBenefitMapping_DesignTimeLayout
        Me.grexOverlandParkTrizzetoBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexOverlandParkTrizzetoBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexOverlandParkTrizzetoBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexOverlandParkTrizzetoBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexOverlandParkTrizzetoBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexOverlandParkTrizzetoBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexOverlandParkTrizzetoBenefitMapping.Name = "grexOverlandParkTrizzetoBenefitMapping"
        Me.grexOverlandParkTrizzetoBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexOverlandParkTrizzetoBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkTrizzetoBenefitMapping.Size = New System.Drawing.Size(1057, 482)
        Me.grexOverlandParkTrizzetoBenefitMapping.TabIndex = 0
        Me.grexOverlandParkTrizzetoBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexOverlandParkTrizzetoBenefitMapping.VisualStyleManager = Me.vsmHthBenefitMapping
        '
        'bsOverlandParkTrizzetoBenefitMapping
        '
        Me.bsOverlandParkTrizzetoBenefitMapping.DataSource = GetType(AscensionAnalytics.OverlandParkTrizzeto_BenefitMapping)
        Me.bsOverlandParkTrizzetoBenefitMapping.Sort = "AscensionBenefitId"
        '
        'bsAscensionBenefits
        '
        Me.bsAscensionBenefits.DataSource = GetType(AscensionAnalytics.OverlandParkTrizzetoMapping_AscensionBenefit)
        '
        'bsPlaceOfService
        '
        Me.bsPlaceOfService.DataSource = GetType(AscensionAnalytics.OverlandParkTrizzeto_PlaceOfService)
        '
        'frmOverlandParkTrizzetoBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 482)
        Me.Controls.Add(Me.grexOverlandParkTrizzetoBenefitMapping)
        Me.Name = "frmOverlandParkTrizzetoBenefitMapping"
        Me.Text = "Overland Park Trizzeto Benefit Mapping"
        CType(Me.grexOverlandParkTrizzetoBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOverlandParkTrizzetoBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPlaceOfService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmHthBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexOverlandParkTrizzetoBenefitMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsOverlandParkTrizzetoBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefits As System.Windows.Forms.BindingSource
    Friend WithEvents bsPlaceOfService As System.Windows.Forms.BindingSource
End Class
