<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportViewerUsers
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
        Dim grexReportViewerUsers_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReportViewerUsers))
        Me.vsmReportViewerUsers = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexReportViewerUsers = New Janus.Windows.GridEX.GridEX
        Me.bsReportViewerUsers = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexReportViewerUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsReportViewerUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmReportViewerUsers
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmReportViewerUsers.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexReportViewerUsers
        '
        Me.grexReportViewerUsers.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexReportViewerUsers.DataSource = Me.bsReportViewerUsers
        grexReportViewerUsers_DesignTimeLayout.LayoutString = resources.GetString("grexReportViewerUsers_DesignTimeLayout.LayoutString")
        Me.grexReportViewerUsers.DesignTimeLayout = grexReportViewerUsers_DesignTimeLayout
        Me.grexReportViewerUsers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexReportViewerUsers.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexReportViewerUsers.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexReportViewerUsers.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexReportViewerUsers.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexReportViewerUsers.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexReportViewerUsers.Location = New System.Drawing.Point(0, 0)
        Me.grexReportViewerUsers.Name = "grexReportViewerUsers"
        Me.grexReportViewerUsers.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexReportViewerUsers.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexReportViewerUsers.Size = New System.Drawing.Size(675, 262)
        Me.grexReportViewerUsers.TabIndex = 0
        Me.grexReportViewerUsers.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexReportViewerUsers.VisualStyleManager = Me.vsmReportViewerUsers
        '
        'bsReportViewerUsers
        '
        Me.bsReportViewerUsers.DataSource = GetType(AscensionAnalytics.ReportViewer_User)
        '
        'frmReportViewerUsers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 262)
        Me.Controls.Add(Me.grexReportViewerUsers)
        Me.Name = "frmReportViewerUsers"
        Me.Text = "Report Viewer Users (Seperate from Analysis People)"
        CType(Me.grexReportViewerUsers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsReportViewerUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmReportViewerUsers As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexReportViewerUsers As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsReportViewerUsers As System.Windows.Forms.BindingSource
End Class
