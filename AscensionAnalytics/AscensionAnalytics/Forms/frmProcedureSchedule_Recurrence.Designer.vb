<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedureSchedule_Recurrence
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
        Dim grexProcedureScheduleRecurrence_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedureSchedule_Recurrence))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexProcedureScheduleRecurrence = New Janus.Windows.GridEX.GridEX
        Me.bsRecurrence = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmProcedureSchedule_Recurrence = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.bsRecurrenceTypes = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.grexProcedureScheduleRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecurrence, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecurrenceTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexProcedureScheduleRecurrence
        '
        Me.grexProcedureScheduleRecurrence.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureScheduleRecurrence.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureScheduleRecurrence.DataSource = Me.bsRecurrence
        grexProcedureScheduleRecurrence_DesignTimeLayout.LayoutString = resources.GetString("grexProcedureScheduleRecurrence_DesignTimeLayout.LayoutString")
        Me.grexProcedureScheduleRecurrence.DesignTimeLayout = grexProcedureScheduleRecurrence_DesignTimeLayout
        Me.grexProcedureScheduleRecurrence.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexProcedureScheduleRecurrence.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexProcedureScheduleRecurrence.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexProcedureScheduleRecurrence.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexProcedureScheduleRecurrence.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexProcedureScheduleRecurrence.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grexProcedureScheduleRecurrence.Location = New System.Drawing.Point(0, 0)
        Me.grexProcedureScheduleRecurrence.Name = "grexProcedureScheduleRecurrence"
        Me.grexProcedureScheduleRecurrence.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexProcedureScheduleRecurrence.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureScheduleRecurrence.Size = New System.Drawing.Size(924, 238)
        Me.grexProcedureScheduleRecurrence.TabIndex = 0
        Me.grexProcedureScheduleRecurrence.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexProcedureScheduleRecurrence.VisualStyleManager = Me.vsmProcedureSchedule_Recurrence
        '
        'bsRecurrence
        '
        Me.bsRecurrence.DataSource = GetType(AscensionAnalytics.ProcedureSchedule_Recurrence)
        '
        'vsmProcedureSchedule_Recurrence
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmProcedureSchedule_Recurrence.ColorSchemes.Add(JanusColorScheme1)
        '
        'bsRecurrenceTypes
        '
        Me.bsRecurrenceTypes.DataSource = GetType(AscensionAnalytics.ProcedureSchedule_RecurrenceType)
        '
        'frmProcedureSchedule_Recurrence
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 238)
        Me.Controls.Add(Me.grexProcedureScheduleRecurrence)
        Me.Name = "frmProcedureSchedule_Recurrence"
        Me.Text = "Procedure Schedule Recurrence"
        CType(Me.grexProcedureScheduleRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecurrence, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecurrenceTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexProcedureScheduleRecurrence As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmProcedureSchedule_Recurrence As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsRecurrence As System.Windows.Forms.BindingSource
    Friend WithEvents bsRecurrenceTypes As System.Windows.Forms.BindingSource
End Class
