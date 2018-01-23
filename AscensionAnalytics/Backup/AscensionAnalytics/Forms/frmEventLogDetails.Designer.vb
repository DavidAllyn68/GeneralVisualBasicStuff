<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEventLogDetails
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
        Dim grexEventLogDetails_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEventLogDetails))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexEventLogDetails = New Janus.Windows.GridEX.GridEX
        Me.bsEventLogDetails = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmEventLogDetails = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexEventLogDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsEventLogDetails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexEventLogDetails
        '
        Me.grexEventLogDetails.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.grexEventLogDetails.DataSource = Me.bsEventLogDetails
        grexEventLogDetails_DesignTimeLayout.LayoutString = resources.GetString("grexEventLogDetails_DesignTimeLayout.LayoutString")
        Me.grexEventLogDetails.DesignTimeLayout = grexEventLogDetails_DesignTimeLayout
        Me.grexEventLogDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexEventLogDetails.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexEventLogDetails.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexEventLogDetails.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexEventLogDetails.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexEventLogDetails.Location = New System.Drawing.Point(0, 0)
        Me.grexEventLogDetails.Name = "grexEventLogDetails"
        Me.grexEventLogDetails.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexEventLogDetails.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexEventLogDetails.Size = New System.Drawing.Size(1231, 238)
        Me.grexEventLogDetails.TabIndex = 0
        Me.grexEventLogDetails.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexEventLogDetails.VisualStyleManager = Me.vsmEventLogDetails
        '
        'bsEventLogDetails
        '
        Me.bsEventLogDetails.DataSource = GetType(AscensionAnalytics.David_EventLog_Detail)
        '
        'vsmEventLogDetails
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmEventLogDetails.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmEventLogDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1231, 238)
        Me.Controls.Add(Me.grexEventLogDetails)
        Me.Name = "frmEventLogDetails"
        Me.Text = "Event Log"
        CType(Me.grexEventLogDetails, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsEventLogDetails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexEventLogDetails As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmEventLogDetails As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsEventLogDetails As System.Windows.Forms.BindingSource
End Class
