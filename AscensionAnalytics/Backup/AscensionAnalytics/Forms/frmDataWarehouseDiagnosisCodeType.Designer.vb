<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseDiagnosisCodeType
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
        Dim grexDataWarehouseDiagnosisCodeType_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseDiagnosisCodeType))
        Me.vsmDataWarehouseDiagnosisCodeType = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseDiagnosisCodeType = New Janus.Windows.GridEX.GridEX
        Me.bsDataWarehouseDiagnosisCodeType = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseDiagnosisCodeType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDataWarehouseDiagnosisCodeType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseDiagnosisCodeType
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseDiagnosisCodeType.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseDiagnosisCodeType
        '
        Me.grexDataWarehouseDiagnosisCodeType.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnosisCodeType.DataSource = Me.bsDataWarehouseDiagnosisCodeType
        grexDataWarehouseDiagnosisCodeType_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseDiagnosisCodeType_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseDiagnosisCodeType.DesignTimeLayout = grexDataWarehouseDiagnosisCodeType_DesignTimeLayout
        Me.grexDataWarehouseDiagnosisCodeType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseDiagnosisCodeType.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseDiagnosisCodeType.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseDiagnosisCodeType.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseDiagnosisCodeType.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseDiagnosisCodeType.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseDiagnosisCodeType.Name = "grexDataWarehouseDiagnosisCodeType"
        Me.grexDataWarehouseDiagnosisCodeType.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseDiagnosisCodeType.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnosisCodeType.Size = New System.Drawing.Size(491, 262)
        Me.grexDataWarehouseDiagnosisCodeType.TabIndex = 0
        Me.grexDataWarehouseDiagnosisCodeType.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseDiagnosisCodeType.VisualStyleManager = Me.vsmDataWarehouseDiagnosisCodeType
        '
        'bsDataWarehouseDiagnosisCodeType
        '
        Me.bsDataWarehouseDiagnosisCodeType.DataSource = GetType(AscensionAnalytics.DataWarehouseDiagnosisCodeType)
        '
        'frmDataWarehouseDiagnosisCodeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 262)
        Me.Controls.Add(Me.grexDataWarehouseDiagnosisCodeType)
        Me.Name = "frmDataWarehouseDiagnosisCodeType"
        Me.Text = "Diagnosis Code Type"
        CType(Me.grexDataWarehouseDiagnosisCodeType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDataWarehouseDiagnosisCodeType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseDiagnosisCodeType As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseDiagnosisCodeType As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDataWarehouseDiagnosisCodeType As System.Windows.Forms.BindingSource
End Class
