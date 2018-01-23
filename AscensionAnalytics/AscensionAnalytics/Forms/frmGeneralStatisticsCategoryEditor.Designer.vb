<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneralStatisticsCategoryEditor
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
        Dim grexGeneralStatisticsCategories_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGeneralStatisticsCategoryEditor))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexGeneralStatisticsCategories = New Janus.Windows.GridEX.GridEX
        Me.bsGeneralStatisticsCategories = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmGeneralStatisticsCategories = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexGeneralStatisticsCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGeneralStatisticsCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexGeneralStatisticsCategories
        '
        Me.grexGeneralStatisticsCategories.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexGeneralStatisticsCategories.DataSource = Me.bsGeneralStatisticsCategories
        grexGeneralStatisticsCategories_DesignTimeLayout.LayoutString = resources.GetString("grexGeneralStatisticsCategories_DesignTimeLayout.LayoutString")
        Me.grexGeneralStatisticsCategories.DesignTimeLayout = grexGeneralStatisticsCategories_DesignTimeLayout
        Me.grexGeneralStatisticsCategories.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexGeneralStatisticsCategories.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexGeneralStatisticsCategories.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexGeneralStatisticsCategories.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexGeneralStatisticsCategories.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexGeneralStatisticsCategories.Location = New System.Drawing.Point(0, 0)
        Me.grexGeneralStatisticsCategories.Name = "grexGeneralStatisticsCategories"
        Me.grexGeneralStatisticsCategories.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexGeneralStatisticsCategories.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexGeneralStatisticsCategories.Size = New System.Drawing.Size(489, 238)
        Me.grexGeneralStatisticsCategories.TabIndex = 0
        Me.grexGeneralStatisticsCategories.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexGeneralStatisticsCategories.VisualStyleManager = Me.vsmGeneralStatisticsCategories
        '
        'bsGeneralStatisticsCategories
        '
        Me.bsGeneralStatisticsCategories.DataSource = GetType(AscensionAnalytics.GeneralStatistics_Category)
        '
        'vsmGeneralStatisticsCategories
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmGeneralStatisticsCategories.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmGeneralStatisticsCategoryEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexGeneralStatisticsCategories)
        Me.Name = "frmGeneralStatisticsCategoryEditor"
        Me.Text = "General Statistics Categories"
        CType(Me.grexGeneralStatisticsCategories, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGeneralStatisticsCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexGeneralStatisticsCategories As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmGeneralStatisticsCategories As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsGeneralStatisticsCategories As System.Windows.Forms.BindingSource
End Class
