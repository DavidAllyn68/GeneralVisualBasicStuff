<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseServiceCodeType
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
        Dim grexDataWarehouseServiceCodeTypes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseServiceCodeType))
        Me.vsmDataWarehouseServiceCodeType = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseServiceCodeTypes = New Janus.Windows.GridEX.GridEX
        Me.bsServiceCodeType = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseServiceCodeTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsServiceCodeType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseServiceCodeType
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseServiceCodeType.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseServiceCodeTypes
        '
        Me.grexDataWarehouseServiceCodeTypes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseServiceCodeTypes.DataSource = Me.bsServiceCodeType
        grexDataWarehouseServiceCodeTypes_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseServiceCodeTypes_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseServiceCodeTypes.DesignTimeLayout = grexDataWarehouseServiceCodeTypes_DesignTimeLayout
        Me.grexDataWarehouseServiceCodeTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseServiceCodeTypes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseServiceCodeTypes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseServiceCodeTypes.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseServiceCodeTypes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseServiceCodeTypes.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseServiceCodeTypes.Name = "grexDataWarehouseServiceCodeTypes"
        Me.grexDataWarehouseServiceCodeTypes.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseServiceCodeTypes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseServiceCodeTypes.Size = New System.Drawing.Size(896, 262)
        Me.grexDataWarehouseServiceCodeTypes.TabIndex = 0
        Me.grexDataWarehouseServiceCodeTypes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseServiceCodeTypes.VisualStyleManager = Me.vsmDataWarehouseServiceCodeType
        '
        'bsServiceCodeType
        '
        Me.bsServiceCodeType.DataSource = GetType(AscensionAnalytics.DataWarehouseServiceCodeType)
        '
        'frmDataWarehouseServiceCodeType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 262)
        Me.Controls.Add(Me.grexDataWarehouseServiceCodeTypes)
        Me.Name = "frmDataWarehouseServiceCodeType"
        Me.Text = "Service Code Type"
        CType(Me.grexDataWarehouseServiceCodeTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsServiceCodeType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsServiceCodeType As System.Windows.Forms.BindingSource
    Friend WithEvents vsmDataWarehouseServiceCodeType As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseServiceCodeTypes As Janus.Windows.GridEX.GridEX
End Class
