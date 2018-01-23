<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseTypeOfServiceSubCategory
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
        Dim grexDataWarehouseTypeOfServiceSubCategory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseTypeOfServiceSubCategory))
        Me.vsmDataWarehouseTypeOfServiceSubCategory = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseTypeOfServiceSubCategory = New Janus.Windows.GridEX.GridEX
        Me.bsTypeOfServiceSubCategory = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseTypeOfServiceSubCategory
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseTypeOfServiceSubCategory.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseTypeOfServiceSubCategory
        '
        Me.grexDataWarehouseTypeOfServiceSubCategory.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfServiceSubCategory.DataSource = Me.bsTypeOfServiceSubCategory
        grexDataWarehouseTypeOfServiceSubCategory_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseTypeOfServiceSubCategory_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseTypeOfServiceSubCategory.DesignTimeLayout = grexDataWarehouseTypeOfServiceSubCategory_DesignTimeLayout
        Me.grexDataWarehouseTypeOfServiceSubCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseTypeOfServiceSubCategory.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseTypeOfServiceSubCategory.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseTypeOfServiceSubCategory.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseTypeOfServiceSubCategory.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseTypeOfServiceSubCategory.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseTypeOfServiceSubCategory.Name = "grexDataWarehouseTypeOfServiceSubCategory"
        Me.grexDataWarehouseTypeOfServiceSubCategory.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseTypeOfServiceSubCategory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfServiceSubCategory.Size = New System.Drawing.Size(687, 262)
        Me.grexDataWarehouseTypeOfServiceSubCategory.TabIndex = 0
        Me.grexDataWarehouseTypeOfServiceSubCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseTypeOfServiceSubCategory.VisualStyleManager = Me.vsmDataWarehouseTypeOfServiceSubCategory
        '
        'bsTypeOfServiceSubCategory
        '
        Me.bsTypeOfServiceSubCategory.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfServiceSubCategory)
        '
        'frmDataWarehouseTypeOfServiceSubCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 262)
        Me.Controls.Add(Me.grexDataWarehouseTypeOfServiceSubCategory)
        Me.Name = "frmDataWarehouseTypeOfServiceSubCategory"
        Me.Text = "Type Of Service Sub-Category"
        CType(Me.grexDataWarehouseTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfServiceSubCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bsTypeOfServiceSubCategory As System.Windows.Forms.BindingSource
    Friend WithEvents vsmDataWarehouseTypeOfServiceSubCategory As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseTypeOfServiceSubCategory As Janus.Windows.GridEX.GridEX
End Class
