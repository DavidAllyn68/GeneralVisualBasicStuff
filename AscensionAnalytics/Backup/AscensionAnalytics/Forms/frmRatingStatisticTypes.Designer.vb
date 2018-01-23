<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRatingStatisticTypes
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
        Dim grexStatisticTypes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRatingStatisticTypes))
        Me.vsmRatingStatisticTypes = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexStatisticTypes = New Janus.Windows.GridEX.GridEX
        Me.bsStatisticTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexStatisticTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsStatisticTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmRatingStatisticTypes
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmRatingStatisticTypes.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexStatisticTypes
        '
        Me.grexStatisticTypes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexStatisticTypes.DataSource = Me.bsStatisticTypes
        grexStatisticTypes_DesignTimeLayout.LayoutString = resources.GetString("grexStatisticTypes_DesignTimeLayout.LayoutString")
        Me.grexStatisticTypes.DesignTimeLayout = grexStatisticTypes_DesignTimeLayout
        Me.grexStatisticTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexStatisticTypes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexStatisticTypes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexStatisticTypes.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexStatisticTypes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexStatisticTypes.GroupMode = Janus.Windows.GridEX.GroupMode.Collapsed
        Me.grexStatisticTypes.Location = New System.Drawing.Point(0, 0)
        Me.grexStatisticTypes.Name = "grexStatisticTypes"
        Me.grexStatisticTypes.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexStatisticTypes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexStatisticTypes.Size = New System.Drawing.Size(578, 334)
        Me.grexStatisticTypes.TabIndex = 0
        Me.grexStatisticTypes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexStatisticTypes.VisualStyleManager = Me.vsmRatingStatisticTypes
        '
        'bsStatisticTypes
        '
        Me.bsStatisticTypes.DataSource = GetType(AscensionAnalytics.Rating_StatisticType)
        '
        'frmRatingStatisticTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(578, 334)
        Me.Controls.Add(Me.grexStatisticTypes)
        Me.Name = "frmRatingStatisticTypes"
        Me.Text = "frmRatingStatisticTypes"
        CType(Me.grexStatisticTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsStatisticTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmRatingStatisticTypes As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexStatisticTypes As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsStatisticTypes As System.Windows.Forms.BindingSource
End Class
