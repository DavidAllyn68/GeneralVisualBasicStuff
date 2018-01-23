<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseTypeOfService
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
        Dim grexDataWarehouseTypeOfService_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseTypeOfService))
        Me.vsmDataWarehouseTypeOfService = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseTypeOfService = New Janus.Windows.GridEX.GridEX
        Me.bsTypeOfService = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTypeOfServiceCategory = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTypeOfServiceSubCategory = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseTypeOfService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseTypeOfService
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseTypeOfService.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseTypeOfService
        '
        Me.grexDataWarehouseTypeOfService.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfService.DataSource = Me.bsTypeOfService
        grexDataWarehouseTypeOfService_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseTypeOfService_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseTypeOfService.DesignTimeLayout = grexDataWarehouseTypeOfService_DesignTimeLayout
        Me.grexDataWarehouseTypeOfService.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseTypeOfService.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseTypeOfService.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseTypeOfService.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseTypeOfService.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseTypeOfService.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseTypeOfService.Name = "grexDataWarehouseTypeOfService"
        Me.grexDataWarehouseTypeOfService.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseTypeOfService.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfService.Size = New System.Drawing.Size(680, 262)
        Me.grexDataWarehouseTypeOfService.TabIndex = 0
        Me.grexDataWarehouseTypeOfService.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseTypeOfService.VisualStyleManager = Me.vsmDataWarehouseTypeOfService
        '
        'bsTypeOfService
        '
        Me.bsTypeOfService.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfService)
        '
        'bsTypeOfServiceCategory
        '
        Me.bsTypeOfServiceCategory.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfServiceCategory)
        '
        'bsTypeOfServiceSubCategory
        '
        Me.bsTypeOfServiceSubCategory.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfServiceSubCategory)
        '
        'frmDataWarehouseTypeOfService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 262)
        Me.Controls.Add(Me.grexDataWarehouseTypeOfService)
        Me.Name = "frmDataWarehouseTypeOfService"
        Me.Text = "Type Of Service"
        CType(Me.grexDataWarehouseTypeOfService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsTypeOfService As System.Windows.Forms.BindingSource
    Friend WithEvents vsmDataWarehouseTypeOfService As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseTypeOfService As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsTypeOfServiceCategory As System.Windows.Forms.BindingSource
    Friend WithEvents bsTypeOfServiceSubCategory As System.Windows.Forms.BindingSource
End Class
