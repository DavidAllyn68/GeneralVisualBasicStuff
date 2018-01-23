<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAetnaGroupMapping
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
        Dim grexTemplate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAetnaGroupMapping))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexAetnaGroupMapping = New Janus.Windows.GridEX.GridEX
        Me.vsmAetnaGroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAetnaGroupMapping = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAetnaGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAetnaGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexTemplate
        '
        Me.grexAetnaGroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaGroupMapping.DataSource = Me.bsAetnaGroupMapping
        grexTemplate_DesignTimeLayout.LayoutString = resources.GetString("grexTemplate_DesignTimeLayout.LayoutString")
        Me.grexAetnaGroupMapping.DesignTimeLayout = grexTemplate_DesignTimeLayout
        Me.grexAetnaGroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAetnaGroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAetnaGroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAetnaGroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAetnaGroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAetnaGroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexAetnaGroupMapping.Name = "grexTemplate"
        Me.grexAetnaGroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAetnaGroupMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAetnaGroupMapping.Size = New System.Drawing.Size(848, 238)
        Me.grexAetnaGroupMapping.TabIndex = 0
        Me.grexAetnaGroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAetnaGroupMapping.VisualStyleManager = Me.vsmAetnaGroupMapping
        '
        'vsmAetnaGroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAetnaGroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'bsAetnaGroupMapping
        '
        Me.bsAetnaGroupMapping.DataSource = GetType(AscensionAnalytics.Aetna_GroupMapping)
        '
        'frmAetnaGroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 238)
        Me.Controls.Add(Me.grexAetnaGroupMapping)
        Me.Name = "frmAetnaGroupMapping"
        Me.Text = "Aetna Group Mapping Editor"
        CType(Me.grexAetnaGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAetnaGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexAetnaGroupMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmAetnaGroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAetnaGroupMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
End Class
