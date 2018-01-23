<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOverlandParkEnrollmentActivity
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
        Dim grexOverlandParkEnrollmentActivity_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOverlandParkEnrollmentActivity))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexOverlandParkEnrollmentActivity = New Janus.Windows.GridEX.GridEX
        Me.vsmOverlandParkEnrollmentActivity = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsOverlandParkEnrollmentActivity = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsGroups = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexOverlandParkEnrollmentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsOverlandParkEnrollmentActivity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsGroups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexOverlandParkEnrollmentActivity
        '
        Me.grexOverlandParkEnrollmentActivity.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkEnrollmentActivity.DataSource = Me.bsOverlandParkEnrollmentActivity
        grexOverlandParkEnrollmentActivity_DesignTimeLayout.LayoutString = resources.GetString("grexOverlandParkEnrollmentActivity_DesignTimeLayout.LayoutString")
        Me.grexOverlandParkEnrollmentActivity.DesignTimeLayout = grexOverlandParkEnrollmentActivity_DesignTimeLayout
        Me.grexOverlandParkEnrollmentActivity.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexOverlandParkEnrollmentActivity.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexOverlandParkEnrollmentActivity.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexOverlandParkEnrollmentActivity.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexOverlandParkEnrollmentActivity.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexOverlandParkEnrollmentActivity.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexOverlandParkEnrollmentActivity.Location = New System.Drawing.Point(0, 0)
        Me.grexOverlandParkEnrollmentActivity.Name = "grexOverlandParkEnrollmentActivity"
        Me.grexOverlandParkEnrollmentActivity.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexOverlandParkEnrollmentActivity.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexOverlandParkEnrollmentActivity.Size = New System.Drawing.Size(1241, 238)
        Me.grexOverlandParkEnrollmentActivity.TabIndex = 0
        Me.grexOverlandParkEnrollmentActivity.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexOverlandParkEnrollmentActivity.VisualStyleManager = Me.vsmOverlandParkEnrollmentActivity
        '
        'vsmOverlandParkEnrollmentActivity
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmOverlandParkEnrollmentActivity.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsOverlandParkEnrollmentActivity
        '
        Me.bsOverlandParkEnrollmentActivity.DataSource = GetType(AscensionAnalytics.OverlandPark_EnrollmentActivity)
        '
        'bsGroups
        '
        Me.bsGroups.DataSource = GetType(AscensionAnalytics.OverlandPark_Enrollment_Group)
        '
        'frmOverlandParkEnrollmentActivity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1241, 238)
        Me.Controls.Add(Me.grexOverlandParkEnrollmentActivity)
        Me.Name = "frmOverlandParkEnrollmentActivity"
        Me.Text = "Overland Park Enrollment Activity"
        CType(Me.grexOverlandParkEnrollmentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsOverlandParkEnrollmentActivity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsGroups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexOverlandParkEnrollmentActivity As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmOverlandParkEnrollmentActivity As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsOverlandParkEnrollmentActivity As System.Windows.Forms.BindingSource
    Friend WithEvents bsGroups As System.Windows.Forms.BindingSource
End Class
