<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLineOfBusinessEditor
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
        Dim grexLineOfBusinessEditor_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLineOfBusinessEditor))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexLineOfBusiness = New Janus.Windows.GridEX.GridEX
        Me.bsLineOfBusiness = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmLineOfBusinessEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsLineOfBusinessCategories = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexLineOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLineOfBusiness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexLineOfBusinessEditor
        '
        Me.grexLineOfBusiness.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexLineOfBusiness.DataSource = Me.bsLineOfBusiness
        grexLineOfBusinessEditor_DesignTimeLayout.LayoutString = resources.GetString("grexLineOfBusinessEditor_DesignTimeLayout.LayoutString")
        Me.grexLineOfBusiness.DesignTimeLayout = grexLineOfBusinessEditor_DesignTimeLayout
        Me.grexLineOfBusiness.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexLineOfBusiness.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexLineOfBusiness.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexLineOfBusiness.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexLineOfBusiness.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexLineOfBusiness.Location = New System.Drawing.Point(0, 0)
        Me.grexLineOfBusiness.Name = "grexLineOfBusinessEditor"
        Me.grexLineOfBusiness.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexLineOfBusiness.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexLineOfBusiness.Size = New System.Drawing.Size(489, 238)
        Me.grexLineOfBusiness.TabIndex = 0
        Me.grexLineOfBusiness.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexLineOfBusiness.VisualStyleManager = Me.vsmLineOfBusinessEditor
        '
        'bsLineOfBusiness
        '
        Me.bsLineOfBusiness.DataSource = GetType(AscensionAnalytics.LineOfBusiness)
        '
        'vsmLineOfBusinessEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmLineOfBusinessEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsLineOfBusinessCategories
        '
        Me.bsLineOfBusinessCategories.DataSource = GetType(AscensionAnalytics.LineOfBusinessCategory)
        '
        'frmLineOfBusinessEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexLineOfBusiness)
        Me.Name = "frmLineOfBusinessEditor"
        Me.Text = "Line Of Business Editor"
        CType(Me.grexLineOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLineOfBusiness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLineOfBusinessCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexLineOfBusiness As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmLineOfBusinessEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsLineOfBusiness As System.Windows.Forms.BindingSource
    Friend WithEvents bsLineOfBusinessCategories As System.Windows.Forms.BindingSource
End Class
