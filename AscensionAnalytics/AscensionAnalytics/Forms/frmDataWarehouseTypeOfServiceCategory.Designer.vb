<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseTypeOfServiceCategory
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
        Dim grexDataWarehouseTypeOfServiceCategory_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseTypeOfServiceCategory))
        Me.vsmDataWarehouseTypeOfServiceCategory = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseTypeOfServiceCategory = New Janus.Windows.GridEX.GridEX
        Me.bsTypeOfServiceCategory = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseTypeOfServiceCategory
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseTypeOfServiceCategory.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseTypeOfServiceCategory
        '
        Me.grexDataWarehouseTypeOfServiceCategory.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfServiceCategory.DataSource = Me.bsTypeOfServiceCategory
        grexDataWarehouseTypeOfServiceCategory_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseTypeOfServiceCategory_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseTypeOfServiceCategory.DesignTimeLayout = grexDataWarehouseTypeOfServiceCategory_DesignTimeLayout
        Me.grexDataWarehouseTypeOfServiceCategory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseTypeOfServiceCategory.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseTypeOfServiceCategory.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseTypeOfServiceCategory.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseTypeOfServiceCategory.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseTypeOfServiceCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexDataWarehouseTypeOfServiceCategory.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseTypeOfServiceCategory.Name = "grexDataWarehouseTypeOfServiceCategory"
        Me.grexDataWarehouseTypeOfServiceCategory.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseTypeOfServiceCategory.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseTypeOfServiceCategory.Size = New System.Drawing.Size(493, 262)
        Me.grexDataWarehouseTypeOfServiceCategory.TabIndex = 0
        Me.grexDataWarehouseTypeOfServiceCategory.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseTypeOfServiceCategory.VisualStyleManager = Me.vsmDataWarehouseTypeOfServiceCategory
        '
        'bsTypeOfServiceCategory
        '
        Me.bsTypeOfServiceCategory.DataSource = GetType(AscensionAnalytics.DataWarehouseTypeOfServiceCategory)
        '
        'frmDataWarehouseTypeOfServiceCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(493, 262)
        Me.Controls.Add(Me.grexDataWarehouseTypeOfServiceCategory)
        Me.Name = "frmDataWarehouseTypeOfServiceCategory"
        Me.Text = "Type Of Service Category"
        CType(Me.grexDataWarehouseTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsTypeOfServiceCategory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseTypeOfServiceCategory As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseTypeOfServiceCategory As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsTypeOfServiceCategory As System.Windows.Forms.BindingSource
End Class
