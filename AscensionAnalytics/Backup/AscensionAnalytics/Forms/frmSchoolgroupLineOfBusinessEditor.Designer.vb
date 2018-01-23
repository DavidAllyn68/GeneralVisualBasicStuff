<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSchoolgroupLineOfBusinessEditor
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
        Dim grexSchoolgroupLineOfBusiness_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSchoolgroupLineOfBusinessEditor))
        Dim JanusColorScheme2 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexSchoolgroupLineOfBusiness = New Janus.Windows.GridEX.GridEX
        Me.bsSchoolgroupLineOfBusiness = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmSchoolgroupLineOfBusiness = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsLineOfBusiness = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsSchoolgroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexSchoolgroupLineOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroupLineOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLineOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexSchoolgroupLineOfBusiness
        '
        Me.grexSchoolgroupLineOfBusiness.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupLineOfBusiness.DataSource = Me.bsSchoolgroupLineOfBusiness
        grexSchoolgroupLineOfBusiness_DesignTimeLayout.LayoutString = resources.GetString("grexSchoolgroupLineOfBusiness_DesignTimeLayout.LayoutString")
        Me.grexSchoolgroupLineOfBusiness.DesignTimeLayout = grexSchoolgroupLineOfBusiness_DesignTimeLayout
        Me.grexSchoolgroupLineOfBusiness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexSchoolgroupLineOfBusiness.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexSchoolgroupLineOfBusiness.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexSchoolgroupLineOfBusiness.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexSchoolgroupLineOfBusiness.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexSchoolgroupLineOfBusiness.Location = New System.Drawing.Point(0, 0)
        Me.grexSchoolgroupLineOfBusiness.Name = "grexSchoolgroupLineOfBusiness"
        Me.grexSchoolgroupLineOfBusiness.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexSchoolgroupLineOfBusiness.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexSchoolgroupLineOfBusiness.Size = New System.Drawing.Size(563, 238)
        Me.grexSchoolgroupLineOfBusiness.TabIndex = 0
        Me.grexSchoolgroupLineOfBusiness.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexSchoolgroupLineOfBusiness.VisualStyleManager = Me.vsmSchoolgroupLineOfBusiness
        '
        'bsSchoolgroupLineOfBusiness
        '
        Me.bsSchoolgroupLineOfBusiness.DataSource = GetType(AscensionAnalytics.SchoolgroupLineOfBusiness)
        '
        'vsmSchoolgroupLineOfBusiness
        '
        JanusColorScheme2.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme2.Name = "Scheme0"
        JanusColorScheme2.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme2.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmSchoolgroupLineOfBusiness.ColorSchemes.Add(JanusColorScheme2)
        '
        'bsLineOfBusiness
        '
        Me.bsLineOfBusiness.DataSource = GetType(AscensionAnalytics.LineOfBusiness)
        '
        'bsSchoolgroups
        '
        Me.bsSchoolgroups.DataSource = GetType(AscensionAnalytics.LookupSchoolgroup)
        '
        'frmSchoolgroupLineOfBusinessEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(563, 238)
        Me.Controls.Add(Me.grexSchoolgroupLineOfBusiness)
        Me.Name = "frmSchoolgroupLineOfBusinessEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Schoolgroup Line Of Business"
        CType(Me.grexSchoolgroupLineOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroupLineOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLineOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSchoolgroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexSchoolgroupLineOfBusiness As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmSchoolgroupLineOfBusiness As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsSchoolgroupLineOfBusiness As System.Windows.Forms.BindingSource
    Friend WithEvents bsLineOfBusiness As System.Windows.Forms.BindingSource
    Friend WithEvents bsSchoolgroups As System.Windows.Forms.BindingSource
End Class
