<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisPeoplePersonTypeEditor
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
        Dim grexAnaysisPeoplePersonTypes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisPeoplePersonTypeEditor))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexAnaysisPeoplePersonTypes = New Janus.Windows.GridEX.GridEX
        Me.bsAnalysisPeople_PersonType = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmAnaysisPeoplePersonTypes = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexAnaysisPeoplePersonTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAnalysisPeople_PersonType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexAnaysisPeoplePersonTypes
        '
        Me.grexAnaysisPeoplePersonTypes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAnaysisPeoplePersonTypes.DataSource = Me.bsAnalysisPeople_PersonType
        grexAnaysisPeoplePersonTypes_DesignTimeLayout.LayoutString = resources.GetString("grexAnaysisPeoplePersonTypes_DesignTimeLayout.LayoutString")
        Me.grexAnaysisPeoplePersonTypes.DesignTimeLayout = grexAnaysisPeoplePersonTypes_DesignTimeLayout
        Me.grexAnaysisPeoplePersonTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAnaysisPeoplePersonTypes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAnaysisPeoplePersonTypes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAnaysisPeoplePersonTypes.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAnaysisPeoplePersonTypes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAnaysisPeoplePersonTypes.Location = New System.Drawing.Point(0, 0)
        Me.grexAnaysisPeoplePersonTypes.Name = "grexAnaysisPeoplePersonTypes"
        Me.grexAnaysisPeoplePersonTypes.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAnaysisPeoplePersonTypes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAnaysisPeoplePersonTypes.Size = New System.Drawing.Size(489, 238)
        Me.grexAnaysisPeoplePersonTypes.TabIndex = 0
        Me.grexAnaysisPeoplePersonTypes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAnaysisPeoplePersonTypes.VisualStyleManager = Me.vsmAnaysisPeoplePersonTypes
        '
        'bsAnalysisPeople_PersonType
        '
        Me.bsAnalysisPeople_PersonType.DataSource = GetType(AscensionAnalytics.AnalysisPeople_PersonType)
        '
        'vsmAnaysisPeoplePersonTypes
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAnaysisPeoplePersonTypes.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmAnalysisPeople_PersonTypeEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexAnaysisPeoplePersonTypes)
        Me.Name = "frmAnalysisPeople_PersonTypeEditor"
        Me.Text = "Analysis Person Type"
        CType(Me.grexAnaysisPeoplePersonTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAnalysisPeople_PersonType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexAnaysisPeoplePersonTypes As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmAnaysisPeoplePersonTypes As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsAnalysisPeople_PersonType As System.Windows.Forms.BindingSource
End Class
