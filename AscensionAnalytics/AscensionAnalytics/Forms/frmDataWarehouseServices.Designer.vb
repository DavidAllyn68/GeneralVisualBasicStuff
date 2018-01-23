<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseServices
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
        Dim grexDataWarehouseServices_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseServices))
        Me.vsmDataWarehouseServices = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseServices = New Janus.Windows.GridEX.GridEX
        Me.bsServices = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsTypeOfService = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsServiceCodeTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServiceCodeTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseServices
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseServices.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseServices
        '
        Me.grexDataWarehouseServices.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseServices.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseServices.DataSource = Me.bsServices
        grexDataWarehouseServices_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseServices_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseServices.DesignTimeLayout = grexDataWarehouseServices_DesignTimeLayout
        Me.grexDataWarehouseServices.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseServices.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseServices.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseServices.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseServices.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseServices.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseServices.Name = "grexDataWarehouseServices"
        Me.grexDataWarehouseServices.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseServices.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseServices.Size = New System.Drawing.Size(897, 395)
        Me.grexDataWarehouseServices.TabIndex = 0
        Me.grexDataWarehouseServices.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseServices.VisualStyleManager = Me.vsmDataWarehouseServices
        '
        'bsServices
        '
        Me.bsServices.DataSource = GetType(AscensionAnalytics.DataWarehouseService)
        Me.bsServices.Sort = "ServiceCode"
        '
        'bsTypeOfService
        '
        Me.bsTypeOfService.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfService)
        '
        'bsServiceCodeTypes
        '
        Me.bsServiceCodeTypes.DataSource = GetType(AscensionAnalytics.DataWarehouseServiceCodeType)
        '
        'frmDataWarehouseServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 395)
        Me.Controls.Add(Me.grexDataWarehouseServices)
        Me.Name = "frmDataWarehouseServices"
        Me.Text = "Services and Procedures"
        CType(Me.grexDataWarehouseServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServiceCodeTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseServices As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseServices As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsServices As System.Windows.Forms.BindingSource
    Friend WithEvents bsTypeOfService As System.Windows.Forms.BindingSource
    Friend WithEvents bsServiceCodeTypes As System.Windows.Forms.BindingSource
End Class
