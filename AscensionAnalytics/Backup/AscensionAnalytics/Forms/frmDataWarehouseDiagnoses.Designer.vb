<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseDiagnoses
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
        Dim grexDataWarehouseDiagnoses_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseDiagnoses))
        Me.vsmDataWarehouseDiagnoses = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseDiagnoses = New Janus.Windows.GridEX.GridEX
        Me.bsDiagnoses = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDatasources = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDiagnosisCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsDiagnosisCodeType = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseDiagnoses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDiagnoses, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatasources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDiagnosisCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDiagnosisCodeType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseDiagnoses
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseDiagnoses.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseDiagnoses
        '
        Me.grexDataWarehouseDiagnoses.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnoses.DataSource = Me.bsDiagnoses
        grexDataWarehouseDiagnoses_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseDiagnoses_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseDiagnoses.DesignTimeLayout = grexDataWarehouseDiagnoses_DesignTimeLayout
        Me.grexDataWarehouseDiagnoses.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseDiagnoses.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseDiagnoses.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseDiagnoses.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseDiagnoses.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseDiagnoses.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grexDataWarehouseDiagnoses.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseDiagnoses.Name = "grexDataWarehouseDiagnoses"
        Me.grexDataWarehouseDiagnoses.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseDiagnoses.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseDiagnoses.Size = New System.Drawing.Size(1263, 391)
        Me.grexDataWarehouseDiagnoses.TabIndex = 0
        Me.grexDataWarehouseDiagnoses.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseDiagnoses.VisualStyleManager = Me.vsmDataWarehouseDiagnoses
        '
        'bsDiagnoses
        '
        Me.bsDiagnoses.DataSource = GetType(AscensionAnalytics.DataWarehouseDiagnoses)
        Me.bsDiagnoses.Sort = "DiagnosisCode"
        '
        'bsDatasources
        '
        Me.bsDatasources.DataSource = GetType(AscensionAnalytics.DataWarehouseDatasources)
        '
        'bsDiagnosisCategories
        '
        Me.bsDiagnosisCategories.DataSource = GetType(AscensionAnalytics.DataWarehouseDiagnosisCategories)
        '
        'bsDiagnosisCodeType
        '
        Me.bsDiagnosisCodeType.DataSource = GetType(AscensionAnalytics.DataWarehouseDiagnosisCodeType)
        '
        'frmDataWarehouseDiagnoses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1263, 391)
        Me.Controls.Add(Me.grexDataWarehouseDiagnoses)
        Me.Name = "frmDataWarehouseDiagnoses"
        Me.Text = "Diagnoses"
        CType(Me.grexDataWarehouseDiagnoses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDiagnoses, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatasources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDiagnosisCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDiagnosisCodeType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseDiagnoses As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseDiagnoses As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDiagnoses As System.Windows.Forms.BindingSource
    Friend WithEvents bsDatasources As System.Windows.Forms.BindingSource
    Friend WithEvents bsDiagnosisCategories As System.Windows.Forms.BindingSource
    Friend WithEvents bsDiagnosisCodeType As System.Windows.Forms.BindingSource
End Class
