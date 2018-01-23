<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatasourceEditor
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
        Dim grexDatasources_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatasourceEditor))
        Me.vsmDatasourcesEditor = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.uicmDatasourcesEditor = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.grexDatasources = New Janus.Windows.GridEX.GridEX
        Me.bsDatasources = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.uicmDatasourcesEditor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grexDatasources, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatasources, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDatasourcesEditor
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDatasourcesEditor.ColorSchemes.Add(JanusColorScheme1)
        '
        'uicmDatasourcesEditor
        '
        Me.uicmDatasourcesEditor.BottomRebar = Me.BottomRebar1
        Me.uicmDatasourcesEditor.ContainerControl = Me
        Me.uicmDatasourcesEditor.Id = New System.Guid("c898313c-5bdb-4a77-8077-c1e21648e437")
        Me.uicmDatasourcesEditor.LeftRebar = Me.LeftRebar1
        Me.uicmDatasourcesEditor.RightRebar = Me.RightRebar1
        Me.uicmDatasourcesEditor.TopRebar = Me.TopRebar1
        Me.uicmDatasourcesEditor.VisualStyleManager = Me.vsmDatasourcesEditor
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmDatasourcesEditor
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 0)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmDatasourcesEditor
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 0)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmDatasourcesEditor
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(0, 0)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.Size = New System.Drawing.Size(0, 0)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandManager = Me.uicmDatasourcesEditor
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.Size = New System.Drawing.Size(1160, 0)
        '
        'grexDatasources
        '
        Me.grexDatasources.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDatasources.DataSource = Me.bsDatasources
        grexDatasources_DesignTimeLayout.LayoutString = resources.GetString("grexDatasources_DesignTimeLayout.LayoutString")
        Me.grexDatasources.DesignTimeLayout = grexDatasources_DesignTimeLayout
        Me.grexDatasources.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDatasources.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDatasources.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDatasources.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDatasources.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDatasources.Location = New System.Drawing.Point(0, 0)
        Me.grexDatasources.Name = "grexDatasources"
        Me.grexDatasources.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDatasources.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDatasources.Size = New System.Drawing.Size(1160, 360)
        Me.grexDatasources.TabIndex = 0
        Me.grexDatasources.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDatasources.VisualStyleManager = Me.vsmDatasourcesEditor
        '
        'bsDatasources
        '
        Me.bsDatasources.DataSource = GetType(AscensionAnalytics.Datasource)
        '
        'frmDatasourceEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1160, 360)
        Me.Controls.Add(Me.grexDatasources)
        Me.Controls.Add(Me.TopRebar1)
        Me.Name = "frmDatasourceEditor"
        Me.Text = "Data Warehouse Data Sources"
        CType(Me.uicmDatasourcesEditor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grexDatasources, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatasources, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents uicmDatasourcesEditor As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents vsmDatasourcesEditor As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDatasources As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDatasources As System.Windows.Forms.BindingSource
End Class
