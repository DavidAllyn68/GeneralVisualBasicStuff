<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverlandParkGroupMapping
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
        Dim grexOverlandParkGroupMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverlandParkGroupMapping))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexOverlandParkGroupMapping = New Janus.Windows.GridEX.GridEX
        Me.vsmOverlandParkGroupMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsOverlandParkGroupMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsOverlandParkGroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexOverlandParkGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOverlandParkGroupMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOverlandParkGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexOverlandParkGroupMapping
        '
        Me.grexOverlandParkGroupMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkGroupMapping.DataSource = Me.bsOverlandParkGroupMapping
        grexOverlandParkGroupMapping_DesignTimeLayout.LayoutString = resources.GetString("grexOverlandParkGroupMapping_DesignTimeLayout.LayoutString")
        Me.grexOverlandParkGroupMapping.DesignTimeLayout = grexOverlandParkGroupMapping_DesignTimeLayout
        Me.grexOverlandParkGroupMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexOverlandParkGroupMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexOverlandParkGroupMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexOverlandParkGroupMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexOverlandParkGroupMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexOverlandParkGroupMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexOverlandParkGroupMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexOverlandParkGroupMapping.Name = "grexOverlandParkGroupMapping"
        Me.grexOverlandParkGroupMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexOverlandParkGroupMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkGroupMapping.Size = New System.Drawing.Size(489, 238)
        Me.grexOverlandParkGroupMapping.TabIndex = 0
        Me.grexOverlandParkGroupMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexOverlandParkGroupMapping.VisualStyleManager = Me.vsmOverlandParkGroupMapping
        '
        'vsmOverlandParkGroupMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmOverlandParkGroupMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsOverlandParkGroupMapping
        '
        Me.bsOverlandParkGroupMapping.DataSource = GetType(AscensionAnalytics.OverlandPark_GroupMapping)
        '
        'bsOverlandParkGroups
        '
        Me.bsOverlandParkGroups.DataSource = GetType(AscensionAnalytics.OverlandPark_Group)
        '
        'frmOverlandParkGroupMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexOverlandParkGroupMapping)
        Me.Name = "frmOverlandParkGroupMapping"
        Me.Text = "Overland Park Group Mapping"
        CType(Me.grexOverlandParkGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOverlandParkGroupMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOverlandParkGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexOverlandParkGroupMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmOverlandParkGroupMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsOverlandParkGroupMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsOverlandParkGroups As System.Windows.Forms.BindingSource
End Class
