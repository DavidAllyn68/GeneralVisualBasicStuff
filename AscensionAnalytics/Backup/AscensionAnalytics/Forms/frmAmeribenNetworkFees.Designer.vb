<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmeribenNetworkFees
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
        Dim grexAmeribenNetworkFees_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmeribenNetworkFees))
        Me.VisualStyleManager1 = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexAmeribenNetworkFees = New Janus.Windows.GridEX.GridEX
        Me.bsNetworkFees = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsPolicyYears = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexAmeribenNetworkFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsNetworkFees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPolicyYears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'VisualStyleManager1
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.VisualStyleManager1.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexAmeribenNetworkFees
        '
        Me.grexAmeribenNetworkFees.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenNetworkFees.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenNetworkFees.DataSource = Me.bsNetworkFees
        Me.grexAmeribenNetworkFees.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        grexAmeribenNetworkFees_DesignTimeLayout.LayoutString = resources.GetString("grexAmeribenNetworkFees_DesignTimeLayout.LayoutString")
        Me.grexAmeribenNetworkFees.DesignTimeLayout = grexAmeribenNetworkFees_DesignTimeLayout
        Me.grexAmeribenNetworkFees.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAmeribenNetworkFees.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAmeribenNetworkFees.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAmeribenNetworkFees.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAmeribenNetworkFees.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAmeribenNetworkFees.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexAmeribenNetworkFees.Location = New System.Drawing.Point(0, 0)
        Me.grexAmeribenNetworkFees.Name = "grexAmeribenNetworkFees"
        Me.grexAmeribenNetworkFees.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAmeribenNetworkFees.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenNetworkFees.Size = New System.Drawing.Size(777, 423)
        Me.grexAmeribenNetworkFees.TabIndex = 0
        Me.grexAmeribenNetworkFees.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAmeribenNetworkFees.VisualStyleManager = Me.VisualStyleManager1
        '
        'bsNetworkFees
        '
        Me.bsNetworkFees.DataSource = GetType(AscensionAnalytics.Ameriben_NetworkFee)
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'bsPolicyYears
        '
        Me.bsPolicyYears.DataSource = GetType(AscensionAnalytics.PolicyYear)
        '
        'frmAmeribenNetworkFees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 423)
        Me.Controls.Add(Me.grexAmeribenNetworkFees)
        Me.Name = "frmAmeribenNetworkFees"
        Me.Text = "frmAmeribenNetworkFees"
        CType(Me.grexAmeribenNetworkFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsNetworkFees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPolicyYears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents VisualStyleManager1 As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexAmeribenNetworkFees As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsNetworkFees As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
    Friend WithEvents bsPolicyYears As System.Windows.Forms.BindingSource
End Class
