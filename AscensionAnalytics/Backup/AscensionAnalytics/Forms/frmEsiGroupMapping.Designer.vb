<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEsiGroupMapping
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
        Dim grexEsiGroupMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEsiGroupMapping))
        Me.vsmEsiGroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexEsiGroupMapping = New Janus.Windows.GridEX.GridEX
        Me.bsEsiGroupMap = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSchoolgroupLookup = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexEsiGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEsiGroupMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupLookup, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmEsiGroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmEsiGroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexEsiGroupMapping
        '
        Me.grexEsiGroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexEsiGroupMapping.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexEsiGroupMapping.DataSource = Me.bsEsiGroupMap
        grexEsiGroupMapping_DesignTimeLayout.LayoutString = resources.GetString("grexEsiGroupMapping_DesignTimeLayout.LayoutString")
        Me.grexEsiGroupMapping.DesignTimeLayout = grexEsiGroupMapping_DesignTimeLayout
        Me.grexEsiGroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexEsiGroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexEsiGroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexEsiGroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexEsiGroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexEsiGroupMapping.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexEsiGroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexEsiGroupMapping.Name = "grexEsiGroupMapping"
        Me.grexEsiGroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexEsiGroupMapping.Size = New System.Drawing.Size(437, 262)
        Me.grexEsiGroupMapping.TabIndex = 0
        Me.grexEsiGroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexEsiGroupMapping.VisualStyleManager = Me.vsmEsiGroupMapping
        '
        'bsEsiGroupMap
        '
        Me.bsEsiGroupMap.DataSource = GetType(AscensionAnalytics.ESI_Group_Map)
        '
        'bsSchoolgroupLookup
        '
        Me.bsSchoolgroupLookup.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'frmEsiGroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 262)
        Me.Controls.Add(Me.grexEsiGroupMapping)
        Me.Name = "frmEsiGroupMapping"
        Me.Text = "ESI Group Mapping"
        CType(Me.grexEsiGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEsiGroupMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupLookup, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmEsiGroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexEsiGroupMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsEsiGroupMap As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroupLookup As System.Windows.Forms.BindingSource
End Class
