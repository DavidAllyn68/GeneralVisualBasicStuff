<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseDiagnosisCategories
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
        Dim grexDataWarehouseDiagnosisCategories_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseDiagnosisCategories))
        Me.vsmDataWarehouseDiagnosisCategories = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseDiagnosisCategories = New Janus.Windows.GridEX.GridEX
        Me.bsDiagnosisCategories = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseDiagnosisCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDiagnosisCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseDiagnosisCategories
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseDiagnosisCategories.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseDiagnosisCategories
        '
        Me.grexDataWarehouseDiagnosisCategories.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnosisCategories.DataSource = Me.bsDiagnosisCategories
        grexDataWarehouseDiagnosisCategories_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseDiagnosisCategories_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseDiagnosisCategories.DesignTimeLayout = grexDataWarehouseDiagnosisCategories_DesignTimeLayout
        Me.grexDataWarehouseDiagnosisCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseDiagnosisCategories.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseDiagnosisCategories.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseDiagnosisCategories.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseDiagnosisCategories.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseDiagnosisCategories.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseDiagnosisCategories.Name = "grexDataWarehouseDiagnosisCategories"
        Me.grexDataWarehouseDiagnosisCategories.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseDiagnosisCategories.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnosisCategories.Size = New System.Drawing.Size(671, 436)
        Me.grexDataWarehouseDiagnosisCategories.TabIndex = 0
        Me.grexDataWarehouseDiagnosisCategories.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseDiagnosisCategories.VisualStyleManager = Me.vsmDataWarehouseDiagnosisCategories
        '
        'bsDiagnosisCategories
        '
        Me.bsDiagnosisCategories.DataSource = GetType(AscensionAnalytics.DataWarehouseDiagnosisCategories)
        '
        'frmDataWarehouseDiagnosisCategories
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 436)
        Me.Controls.Add(Me.grexDataWarehouseDiagnosisCategories)
        Me.Name = "frmDataWarehouseDiagnosisCategories"
        Me.Text = "Diagnosis Categories"
        CType(Me.grexDataWarehouseDiagnosisCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDiagnosisCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseDiagnosisCategories As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseDiagnosisCategories As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDiagnosisCategories As System.Windows.Forms.BindingSource
End Class
