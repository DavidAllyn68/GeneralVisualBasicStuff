<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmeribenBenefitMapping
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
        Dim grexAmeribenBenefitMapping_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAmeribenBenefitMapping))
        Me.vsmAmeribenBenefitMapping = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.uicmAmeribenBenefitMapping = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.grexAmeribenBenefitMapping = New Janus.Windows.GridEX.GridEX
        Me.bsAmeribenBenefitMapping = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAmeribenTOS = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAmeribenPOS = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsAscensionBenefits = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.uicmAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grexAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAmeribenTOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAmeribenPOS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmAmeribenBenefitMapping
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmAmeribenBenefitMapping.ColorSchemes.Add(JanusColorScheme1)
        '
        'uicmAmeribenBenefitMapping
        '
        Me.uicmAmeribenBenefitMapping.BottomRebar = Me.BottomRebar1
        Me.uicmAmeribenBenefitMapping.ContainerControl = Me
        Me.uicmAmeribenBenefitMapping.Id = New System.Guid("1a7935bd-b3c4-46ec-8a5f-fc63beb4d7d1")
        Me.uicmAmeribenBenefitMapping.LeftRebar = Me.LeftRebar1
        Me.uicmAmeribenBenefitMapping.RightRebar = Me.RightRebar1
        Me.uicmAmeribenBenefitMapping.TopRebar = Me.TopRebar1
        Me.uicmAmeribenBenefitMapping.VisualStyleManager = Me.vsmAmeribenBenefitMapping
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmAmeribenBenefitMapping
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 539)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(1051, 0)
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmAmeribenBenefitMapping
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 539)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmAmeribenBenefitMapping
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(1051, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 539)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.uicmAmeribenBenefitMapping
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(701, 0)
        '
        'grexAmeribenBenefitMapping
        '
        Me.grexAmeribenBenefitMapping.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenBenefitMapping.DataSource = Me.bsAmeribenBenefitMapping
        grexAmeribenBenefitMapping_DesignTimeLayout.LayoutString = resources.GetString("grexAmeribenBenefitMapping_DesignTimeLayout.LayoutString")
        Me.grexAmeribenBenefitMapping.DesignTimeLayout = grexAmeribenBenefitMapping_DesignTimeLayout
        Me.grexAmeribenBenefitMapping.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexAmeribenBenefitMapping.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexAmeribenBenefitMapping.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexAmeribenBenefitMapping.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexAmeribenBenefitMapping.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexAmeribenBenefitMapping.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexAmeribenBenefitMapping.Location = New System.Drawing.Point(0, 0)
        Me.grexAmeribenBenefitMapping.Name = "grexAmeribenBenefitMapping"
        Me.grexAmeribenBenefitMapping.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexAmeribenBenefitMapping.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexAmeribenBenefitMapping.Size = New System.Drawing.Size(701, 539)
        Me.grexAmeribenBenefitMapping.TabIndex = 0
        Me.grexAmeribenBenefitMapping.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexAmeribenBenefitMapping.VisualStyleManager = Me.vsmAmeribenBenefitMapping
        '
        'bsAmeribenBenefitMapping
        '
        Me.bsAmeribenBenefitMapping.DataSource = GetType(AscensionAnalytics.Ameriben_BenefitMapping)
        Me.bsAmeribenBenefitMapping.Sort = "AscensionBenefitId"
        '
        'bsAmeribenTOS
        '
        Me.bsAmeribenTOS.DataSource = GetType(AscensionAnalytics.Ameriben_TOS)
        '
        'bsAmeribenPOS
        '
        Me.bsAmeribenPOS.DataSource = GetType(AscensionAnalytics.Ameriben_POS)
        '
        'bsAscensionBenefits
        '
        Me.bsAscensionBenefits.DataSource = GetType(AscensionAnalytics.AmeribenMapping_AscensionBenefits)
        '
        'frmAmeribenBenefitMapping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 539)
        Me.Controls.Add(Me.grexAmeribenBenefitMapping)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmAmeribenBenefitMapping"
        Me.Text = "Ameriben Benefit Mapping"
        Me.TopMost = True
        CType(Me.uicmAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grexAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAmeribenBenefitMapping, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAmeribenTOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAmeribenPOS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAscensionBenefits, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmAmeribenBenefitMapping As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents uicmAmeribenBenefitMapping As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents grexAmeribenBenefitMapping As Janus.Windows.GridEX.GridEX
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents bsAmeribenBenefitMapping As System.Windows.Forms.BindingSource
    Friend WithEvents bsAmeribenTOS As System.Windows.Forms.BindingSource
    Friend WithEvents bsAmeribenPOS As System.Windows.Forms.BindingSource
    Friend WithEvents bsAscensionBenefits As System.Windows.Forms.BindingSource
End Class
