<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHthGroupMapping
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
        Dim grexHthGroupMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHthGroupMapping))
        Me.vsmHTHGroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexHthGroupMapping = New Janus.Windows.GridEX.GridEX
        Me.bsGroupMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexHthGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmHTHGroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmHTHGroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexHthGroupMapping
        '
        Me.grexHthGroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexHthGroupMapping.DataSource = Me.bsGroupMapping
        grexHthGroupMapping_DesignTimeLayout.LayoutString = resources.GetString("grexHthGroupMapping_DesignTimeLayout.LayoutString")
        Me.grexHthGroupMapping.DesignTimeLayout = grexHthGroupMapping_DesignTimeLayout
        Me.grexHthGroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexHthGroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexHthGroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexHthGroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexHthGroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenReturnKeyIsPressed
        Me.grexHthGroupMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexHthGroupMapping.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexHthGroupMapping.Hierarchical = True
        Me.grexHthGroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexHthGroupMapping.Name = "grexHthGroupMapping"
        Me.grexHthGroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexHthGroupMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexHthGroupMapping.Size = New System.Drawing.Size(915, 483)
        Me.grexHthGroupMapping.TabIndex = 0
        Me.grexHthGroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexHthGroupMapping.VisualStyleManager = Me.vsmHTHGroupMapping
        '
        'bsGroupMapping
        '
        Me.bsGroupMapping.DataSource = GetType(AscensionAnalytics.HTH_GROUPS_MAP)
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.HthDataSchoolgroups)
        '
        'frmHthGroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 483)
        Me.Controls.Add(Me.grexHthGroupMapping)
        Me.Name = "frmHthGroupMapping"
        Me.Text = "HTHGroupMapping"
        CType(Me.grexHthGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmHTHGroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexHthGroupMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsGroupMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
End Class
