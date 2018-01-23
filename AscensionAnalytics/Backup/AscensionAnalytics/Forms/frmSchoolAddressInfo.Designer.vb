<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolAddressInfo
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
        Dim grexSchoolAddressInfo_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolAddressInfo))
        Me.vsmSchoolAddressInfo = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexSchoolAddressInfo = New Janus.Windows.GridEX.GridEX
        Me.bsSchoolAddressInfo = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexSchoolAddressInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolAddressInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmSchoolAddressInfo
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmSchoolAddressInfo.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexSchoolAddressInfo
        '
        Me.grexSchoolAddressInfo.DataSource = Me.bsSchoolAddressInfo
        Me.grexSchoolAddressInfo.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        grexSchoolAddressInfo_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolAddressInfo_DesignTimeLayout.LayoutString")
        Me.grexSchoolAddressInfo.DesignTimeLayout = grexSchoolAddressInfo_DesignTimeLayout
        Me.grexSchoolAddressInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolAddressInfo.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolAddressInfo.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolAddressInfo.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexSchoolAddressInfo.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexSchoolAddressInfo.Location = New System.Drawing.Point(0, 0)
        Me.grexSchoolAddressInfo.Name = "grexSchoolAddressInfo"
        Me.grexSchoolAddressInfo.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolAddressInfo.Size = New System.Drawing.Size(737, 262)
        Me.grexSchoolAddressInfo.TabIndex = 0
        Me.grexSchoolAddressInfo.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolAddressInfo.VisualStyleManager = Me.vsmSchoolAddressInfo
        '
        'bsSchoolAddressInfo
        '
        Me.bsSchoolAddressInfo.DataSource = GetType(AscensionAnalytics.SchoolAddressInfo)
        '
        'frmSchoolAddressInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(737, 262)
        Me.Controls.Add(Me.grexSchoolAddressInfo)
        Me.Name = "frmSchoolAddressInfo"
        Me.Text = "School Address Info"
        CType(Me.grexSchoolAddressInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolAddressInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmSchoolAddressInfo As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexSchoolAddressInfo As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsSchoolAddressInfo As System.Windows.Forms.BindingSource
End Class
