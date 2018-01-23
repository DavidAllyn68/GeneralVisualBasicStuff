<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatasourceMaxPaidDate
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
        Dim gridExDatasourceMaxPaidDate_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDatasourceMaxPaidDate))
        Me.gridExDatasourceMaxPaidDate = New Janus.Windows.GridEX.GridEX
        Me.bsDatasourceMaxPaidDate = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.gridExDatasourceMaxPaidDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDatasourceMaxPaidDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gridExDatasourceMaxPaidDate
        '
        Me.gridExDatasourceMaxPaidDate.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.gridExDatasourceMaxPaidDate.DataSource = Me.bsDatasourceMaxPaidDate
        gridExDatasourceMaxPaidDate_DesignTimeLayout.LayoutString = resources.GetString("gridExDatasourceMaxPaidDate_DesignTimeLayout.LayoutString")
        Me.gridExDatasourceMaxPaidDate.DesignTimeLayout = gridExDatasourceMaxPaidDate_DesignTimeLayout
        Me.gridExDatasourceMaxPaidDate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridExDatasourceMaxPaidDate.GroupByBoxVisible = False
        Me.gridExDatasourceMaxPaidDate.Location = New System.Drawing.Point(0, 0)
        Me.gridExDatasourceMaxPaidDate.Name = "gridExDatasourceMaxPaidDate"
        Me.gridExDatasourceMaxPaidDate.Size = New System.Drawing.Size(344, 149)
        Me.gridExDatasourceMaxPaidDate.TabIndex = 0
        '
        'bsDatasourceMaxPaidDate
        '
        Me.bsDatasourceMaxPaidDate.DataSource = GetType(AscensionAnalytics.DatasourceMaxPaidDate)
        '
        'frmDatasourceMaxPaidDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 149)
        Me.Controls.Add(Me.gridExDatasourceMaxPaidDate)
        Me.Name = "frmDatasourceMaxPaidDate"
        Me.Text = "Datasource Max Paid Date"
        CType(Me.gridExDatasourceMaxPaidDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDatasourceMaxPaidDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gridExDatasourceMaxPaidDate As Janus.Windows.GridEX.GridEX
    Friend WithEvents bsDatasourceMaxPaidDate As System.Windows.Forms.BindingSource
End Class
