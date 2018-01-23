<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataWarehouseMessageQueue
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
        Dim grexDataWarehouseMessageQueue_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDataWarehouseMessageQueue))
        Me.vsmDataWarehouseMessageQueue = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.grexDataWarehouseMessageQueue = New Janus.Windows.GridEX.GridEX
        Me.bsMessageQueue = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexDataWarehouseMessageQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMessageQueue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vsmDataWarehouseMessageQueue
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmDataWarehouseMessageQueue.ColorSchemes.Add(JanusColorScheme1)
        '
        'grexDataWarehouseMessageQueue
        '
        Me.grexDataWarehouseMessageQueue.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseMessageQueue.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseMessageQueue.DataSource = Me.bsMessageQueue
        grexDataWarehouseMessageQueue_DesignTimeLayout.LayoutString = resources.GetString("grexDataWarehouseMessageQueue_DesignTimeLayout.LayoutString")
        Me.grexDataWarehouseMessageQueue.DesignTimeLayout = grexDataWarehouseMessageQueue_DesignTimeLayout
        Me.grexDataWarehouseMessageQueue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexDataWarehouseMessageQueue.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexDataWarehouseMessageQueue.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexDataWarehouseMessageQueue.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexDataWarehouseMessageQueue.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexDataWarehouseMessageQueue.Location = New System.Drawing.Point(0, 0)
        Me.grexDataWarehouseMessageQueue.Name = "grexDataWarehouseMessageQueue"
        Me.grexDataWarehouseMessageQueue.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexDataWarehouseMessageQueue.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexDataWarehouseMessageQueue.Size = New System.Drawing.Size(1049, 262)
        Me.grexDataWarehouseMessageQueue.TabIndex = 0
        Me.grexDataWarehouseMessageQueue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexDataWarehouseMessageQueue.VisualStyleManager = Me.vsmDataWarehouseMessageQueue
        '
        'bsMessageQueue
        '
        Me.bsMessageQueue.DataSource = GetType(AscensionAnalytics.MessageQueue)
        '
        'frmDataWarehouseMessageQueue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1049, 262)
        Me.Controls.Add(Me.grexDataWarehouseMessageQueue)
        Me.Name = "frmDataWarehouseMessageQueue"
        Me.Text = "Data Warehouse Message Queue"
        CType(Me.grexDataWarehouseMessageQueue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMessageQueue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmDataWarehouseMessageQueue As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents grexDataWarehouseMessageQueue As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsMessageQueue As System.Windows.Forms.BindingSource
End Class
