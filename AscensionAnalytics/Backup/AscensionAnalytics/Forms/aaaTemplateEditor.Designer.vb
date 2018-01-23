<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class aaaTemplateEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(aaaTemplateEditor))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexTemplate = New Janus.Windows.GridEX.GridEX
        Me.bsTemplate = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmTemplate = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexTemplate
        '
        Me.grexTemplate.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexTemplate.DataSource = Me.bsTemplate
        grexTemplate_DesignTimeLayout.LayoutString = resources.GetString("grexTemplate_DesignTimeLayout.LayoutString")
        Me.grexTemplate.DesignTimeLayout = grexTemplate_DesignTimeLayout
        Me.grexTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexTemplate.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexTemplate.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexTemplate.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexTemplate.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexTemplate.Location = New System.Drawing.Point(0, 0)
        Me.grexTemplate.Name = "grexTemplate"
        Me.grexTemplate.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexTemplate.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexTemplate.Size = New System.Drawing.Size(489, 238)
        Me.grexTemplate.TabIndex = 0
        Me.grexTemplate.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexTemplate.VisualStyleManager = Me.vsmTemplate
        '
        'bsTemplate
        '
        Me.bsTemplate.DataSource = GetType(AscensionAnalytics.AnalysisPeople_PersonType)
        '
        'vsmTemplate
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmTemplate.ColorSchemes.Add(JanusColorScheme1)
        '
        'aaaTemplateEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexTemplate)
        Me.Name = "aaaTemplateEditor"
        Me.Text = "[TEMPLATE FORM]"
        CType(Me.grexTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexTemplate As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmTemplate As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsTemplate As System.Windows.Forms.BindingSource
End Class
