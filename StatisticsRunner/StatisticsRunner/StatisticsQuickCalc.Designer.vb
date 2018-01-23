<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatisticsQuickCalc
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StatisticsQuickCalc))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX
        Me.tbSum = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tbMean = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.tbCount = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.tbCountWithoutZeros = New System.Windows.Forms.TextBox
        Me.tbMeanWithoutZeros = New System.Windows.Forms.TextBox
        Me.tbMin = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbMax = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.tbStandardDeviationPopulation = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.tbStandardDeviationSample = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridEX1.DataSource = Me.BindingSource1
        GridEX1_DesignTimeLayout.LayoutString = resources.GetString("GridEX1_DesignTimeLayout.LayoutString")
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridEX1.Location = New System.Drawing.Point(12, 12)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.NewRowEnterKeyBehavior = Janus.Windows.GridEX.NewRowEnterKeyBehavior.AddRowAndMoveToFirstCellInNewRow
        Me.GridEX1.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridEX1.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.GridEX1.Size = New System.Drawing.Size(299, 169)
        Me.GridEX1.TabIndex = 1
        '
        'tbSum
        '
        Me.tbSum.Location = New System.Drawing.Point(65, 190)
        Me.tbSum.Name = "tbSum"
        Me.tbSum.Size = New System.Drawing.Size(90, 20)
        Me.tbSum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sum"
        '
        'tbMean
        '
        Me.tbMean.Location = New System.Drawing.Point(65, 296)
        Me.tbMean.Name = "tbMean"
        Me.tbMean.Size = New System.Drawing.Size(90, 20)
        Me.tbMean.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 299)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mean"
        '
        'tbCount
        '
        Me.tbCount.Location = New System.Drawing.Point(65, 270)
        Me.tbCount.Name = "tbCount"
        Me.tbCount.Size = New System.Drawing.Size(90, 20)
        Me.tbCount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Count"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(186, 245)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Excluding Zero Values"
        '
        'tbCountWithoutZeros
        '
        Me.tbCountWithoutZeros.Location = New System.Drawing.Point(189, 270)
        Me.tbCountWithoutZeros.Name = "tbCountWithoutZeros"
        Me.tbCountWithoutZeros.Size = New System.Drawing.Size(110, 20)
        Me.tbCountWithoutZeros.TabIndex = 2
        '
        'tbMeanWithoutZeros
        '
        Me.tbMeanWithoutZeros.Location = New System.Drawing.Point(189, 296)
        Me.tbMeanWithoutZeros.Name = "tbMeanWithoutZeros"
        Me.tbMeanWithoutZeros.Size = New System.Drawing.Size(110, 20)
        Me.tbMeanWithoutZeros.TabIndex = 2
        '
        'tbMin
        '
        Me.tbMin.Location = New System.Drawing.Point(65, 216)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(90, 20)
        Me.tbMin.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Min"
        '
        'tbMax
        '
        Me.tbMax.Location = New System.Drawing.Point(65, 242)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(90, 20)
        Me.tbMax.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Max"
        '
        'tbStandardDeviationPopulation
        '
        Me.tbStandardDeviationPopulation.Location = New System.Drawing.Point(65, 322)
        Me.tbStandardDeviationPopulation.Name = "tbStandardDeviationPopulation"
        Me.tbStandardDeviationPopulation.Size = New System.Drawing.Size(90, 20)
        Me.tbStandardDeviationPopulation.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 325)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "StDevP"
        '
        'tbStandardDeviationSample
        '
        Me.tbStandardDeviationSample.Location = New System.Drawing.Point(65, 348)
        Me.tbStandardDeviationSample.Name = "tbStandardDeviationSample"
        Me.tbStandardDeviationSample.Size = New System.Drawing.Size(90, 20)
        Me.tbStandardDeviationSample.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 351)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "StDevS"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(StatisticsRunnerApplication.Statistics)
        '
        'StatisticsQuickCalc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(323, 384)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbStandardDeviationSample)
        Me.Controls.Add(Me.tbStandardDeviationPopulation)
        Me.Controls.Add(Me.tbMean)
        Me.Controls.Add(Me.tbMeanWithoutZeros)
        Me.Controls.Add(Me.tbCountWithoutZeros)
        Me.Controls.Add(Me.tbCount)
        Me.Controls.Add(Me.tbMax)
        Me.Controls.Add(Me.tbMin)
        Me.Controls.Add(Me.tbSum)
        Me.Controls.Add(Me.GridEX1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StatisticsQuickCalc"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statistics Calculator"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents tbSum As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbMean As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbCount As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbCountWithoutZeros As System.Windows.Forms.TextBox
    Friend WithEvents tbMeanWithoutZeros As System.Windows.Forms.TextBox
    Friend WithEvents tbMin As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbMax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbStandardDeviationPopulation As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbStandardDeviationSample As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
