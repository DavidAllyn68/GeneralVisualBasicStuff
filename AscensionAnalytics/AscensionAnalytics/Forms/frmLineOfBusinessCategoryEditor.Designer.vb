<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineOfBusinessCategoryEditor
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
        Dim grexLineOfBusinessCategories_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineOfBusinessCategoryEditor))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexLineOfBusinessCategories = New Janus.Windows.GridEX.GridEX
        Me.bsLineOfBusinessCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmLineOfBusinessCategoriesEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexLineOfBusinessCategories
        '
        Me.grexLineOfBusinessCategories.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexLineOfBusinessCategories.DataSource = Me.bsLineOfBusinessCategories
        grexLineOfBusinessCategories_DesignTimeLayout.LayoutString = resources.GetString("grexLineOfBusinessCategories_DesignTimeLayout.LayoutString")
        Me.grexLineOfBusinessCategories.DesignTimeLayout = grexLineOfBusinessCategories_DesignTimeLayout
        Me.grexLineOfBusinessCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexLineOfBusinessCategories.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexLineOfBusinessCategories.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexLineOfBusinessCategories.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexLineOfBusinessCategories.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexLineOfBusinessCategories.Location = New System.Drawing.Point(0, 0)
        Me.grexLineOfBusinessCategories.Name = "grexLineOfBusinessCategories"
        Me.grexLineOfBusinessCategories.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexLineOfBusinessCategories.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexLineOfBusinessCategories.Size = New System.Drawing.Size(489, 238)
        Me.grexLineOfBusinessCategories.TabIndex = 0
        Me.grexLineOfBusinessCategories.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexLineOfBusinessCategories.VisualStyleManager = Me.vsmLineOfBusinessCategoriesEditor
        '
        'bsLineOfBusinessCategories
        '
        Me.bsLineOfBusinessCategories.DataSource = GetType(AscensionAnalytics.LineOfBusinessCategory)
        '
        'vsmLineOfBusinessCategoriesEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmLineOfBusinessCategoriesEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmLineOfBusinessCategoryEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexLineOfBusinessCategories)
        Me.Name = "frmLineOfBusinessCategoryEditor"
        Me.Text = "Line Of Business Categories Editor"
        CType(Me.grexLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexLineOfBusinessCategories As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmLineOfBusinessCategoriesEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsLineOfBusinessCategories As System.Windows.Forms.BindingSource
End Class
