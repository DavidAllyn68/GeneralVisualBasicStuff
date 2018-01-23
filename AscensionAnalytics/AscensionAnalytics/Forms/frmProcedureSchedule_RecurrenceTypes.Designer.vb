<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProcedureSchedule_RecurrenceTypes
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
        Dim grexProcedureScheduleRecurrenceTypes_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedureSchedule_RecurrenceTypes))
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Me.grexProcedureScheduleRecurrenceTypes = New Janus.Windows.GridEX.GridEX
        Me.bsRecurrenceTypes = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmProcedureScheduleRecurrenceTypes = New Janus.Windows.Common.VisualStyleManager(Me.components)
        CType(Me.grexProcedureScheduleRecurrenceTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsRecurrenceTypes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grexProcedureScheduleRecurrenceTypes
        '
        Me.grexProcedureScheduleRecurrenceTypes.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureScheduleRecurrenceTypes.DataSource = Me.bsRecurrenceTypes
        grexProcedureScheduleRecurrenceTypes_DesignTimeLayout.LayoutString = resources.GetString("grexProcedureScheduleRecurrenceTypes_DesignTimeLayout.LayoutString")
        Me.grexProcedureScheduleRecurrenceTypes.DesignTimeLayout = grexProcedureScheduleRecurrenceTypes_DesignTimeLayout
        Me.grexProcedureScheduleRecurrenceTypes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grexProcedureScheduleRecurrenceTypes.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.grexProcedureScheduleRecurrenceTypes.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown
        Me.grexProcedureScheduleRecurrenceTypes.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grexProcedureScheduleRecurrenceTypes.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.grexProcedureScheduleRecurrenceTypes.Location = New System.Drawing.Point(0, 0)
        Me.grexProcedureScheduleRecurrenceTypes.Name = "grexProcedureScheduleRecurrenceTypes"
        Me.grexProcedureScheduleRecurrenceTypes.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.grexProcedureScheduleRecurrenceTypes.RowHeaders = Janus.Windows.GridEX.InheritableBoolean.[True]
        Me.grexProcedureScheduleRecurrenceTypes.Size = New System.Drawing.Size(489, 238)
        Me.grexProcedureScheduleRecurrenceTypes.TabIndex = 0
        Me.grexProcedureScheduleRecurrenceTypes.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007
        Me.grexProcedureScheduleRecurrenceTypes.VisualStyleManager = Me.vsmProcedureScheduleRecurrenceTypes
        '
        'bsRecurrenceTypes
        '
        Me.bsRecurrenceTypes.DataSource = GetType(AscensionAnalytics.ProcedureSchedule_RecurrenceType)
        '
        'vsmProcedureScheduleRecurrenceTypes
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmProcedureScheduleRecurrenceTypes.ColorSchemes.Add(JanusColorScheme1)
        '
        'frmProcedureSchedule_RecurrenceTypes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(489, 238)
        Me.Controls.Add(Me.grexProcedureScheduleRecurrenceTypes)
        Me.Name = "frmProcedureSchedule_RecurrenceTypes"
        Me.Text = "Procedure Schedule Recurrence Types"
        CType(Me.grexProcedureScheduleRecurrenceTypes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsRecurrenceTypes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grexProcedureScheduleRecurrenceTypes As Janus.Windows.GridEX.GridEX
    Friend WithEvents vsmProcedureScheduleRecurrenceTypes As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents bsRecurrenceTypes As System.Windows.Forms.BindingSource
End Class
