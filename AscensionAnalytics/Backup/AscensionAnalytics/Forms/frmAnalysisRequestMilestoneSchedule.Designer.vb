<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAnalysisRequestMilestoneSchedule
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
        Dim schMilestoneSchedule_DesignTimeLayout As Janus.Windows.Schedule.ScheduleLayout = New Janus.Windows.Schedule.ScheduleLayout
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAnalysisRequestMilestoneSchedule))
        Me.bsMilestoneSchedule = New System.Windows.Forms.BindingSource(Me.components)
        Me.vsmMilestoneSchedule = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.panelCalendar = New Janus.Windows.UI.Dock.UIPanel
        Me.panelCalendarContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.calMilestoneSchedule = New Janus.Windows.Schedule.Calendar
        Me.schMilestoneSchedule = New Janus.Windows.Schedule.Schedule
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        CType(Me.bsMilestoneSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panelCalendar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelCalendar.SuspendLayout()
        CType(Me.calMilestoneSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.schMilestoneSchedule, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'bsMilestoneSchedule
        '
        Me.bsMilestoneSchedule.DataSource = GetType(AscensionAnalytics.AnalysisRequest)
        '
        'vsmMilestoneSchedule
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2007
        Me.vsmMilestoneSchedule.ColorSchemes.Add(JanusColorScheme1)
        Me.vsmMilestoneSchedule.DefaultColorScheme = "Scheme0"
        '
        'panelCalendar
        '
        Me.panelCalendar.InnerContainer = Me.panelCalendarContainer
        Me.panelCalendar.Location = New System.Drawing.Point(0, 0)
        Me.panelCalendar.Name = "panelCalendar"
        Me.panelCalendar.Size = New System.Drawing.Size(235, 479)
        Me.panelCalendar.TabIndex = 4
        Me.panelCalendar.Text = "Calendar"
        '
        'panelCalendarContainer
        '
        Me.panelCalendarContainer.Location = New System.Drawing.Point(0, 0)
        Me.panelCalendarContainer.Name = "panelCalendarContainer"
        Me.panelCalendarContainer.Size = New System.Drawing.Size(235, 479)
        Me.panelCalendarContainer.TabIndex = 0
        '
        'calMilestoneSchedule
        '
        Me.calMilestoneSchedule.AllowDrop = True
        Me.calMilestoneSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.calMilestoneSchedule.Location = New System.Drawing.Point(0, 0)
        Me.calMilestoneSchedule.Name = "calMilestoneSchedule"
        Me.calMilestoneSchedule.Schedule = Me.schMilestoneSchedule
        Me.calMilestoneSchedule.SelectionStyle = Janus.Windows.Schedule.CalendarSelectionStyle.Schedule
        Me.calMilestoneSchedule.Size = New System.Drawing.Size(148, 532)
        Me.calMilestoneSchedule.TabIndex = 0
        Me.calMilestoneSchedule.VisualStyleManager = Me.vsmMilestoneSchedule
        '
        'schMilestoneSchedule
        '
        Me.schMilestoneSchedule.AllowAppointmentDrag = Janus.Windows.Schedule.AllowAppointmentDrag.Move
        Me.schMilestoneSchedule.AllowDelete = False
        Me.schMilestoneSchedule.AllowDragInNonWorkingTime = False
        Me.schMilestoneSchedule.AllowEdit = False
        Me.schMilestoneSchedule.DataSource = Me.bsMilestoneSchedule
        Me.schMilestoneSchedule.DescriptionMember = "Name"
        schMilestoneSchedule_DesignTimeLayout.DataSource = Me.bsMilestoneSchedule
        schMilestoneSchedule_DesignTimeLayout.LayoutString = resources.GetString("schMilestoneSchedule_DesignTimeLayout.LayoutString")
        Me.schMilestoneSchedule.DesignTimeLayout = schMilestoneSchedule_DesignTimeLayout
        Me.schMilestoneSchedule.Dock = System.Windows.Forms.DockStyle.Fill
        Me.schMilestoneSchedule.EndTimeMember = "MilestoneDate"
        Me.schMilestoneSchedule.HourBackgroundStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.schMilestoneSchedule.Location = New System.Drawing.Point(0, 0)
        Me.schMilestoneSchedule.Name = "schMilestoneSchedule"
        Me.schMilestoneSchedule.OwnerMember = "AnalysisId"
        Me.schMilestoneSchedule.ShowTimeHintOnAppointments = Janus.Windows.Schedule.TimeHintOnAppointments.Never
        Me.schMilestoneSchedule.Size = New System.Drawing.Size(709, 606)
        Me.schMilestoneSchedule.StartTimeMember = "MilestoneDate"
        Me.schMilestoneSchedule.TabIndex = 0
        Me.schMilestoneSchedule.TextMember = "Milestone"
        Me.schMilestoneSchedule.VerticalScrollPosition = 16
        Me.schMilestoneSchedule.VisualStyleManager = Me.vsmMilestoneSchedule
        Me.schMilestoneSchedule.WorkingHourBackgroundStyle.BackColor = System.Drawing.Color.White
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.calMilestoneSchedule)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.schMilestoneSchedule)
        Me.SplitContainer1.Size = New System.Drawing.Size(868, 606)
        Me.SplitContainer1.SplitterDistance = 151
        Me.SplitContainer1.SplitterWidth = 8
        Me.SplitContainer1.TabIndex = 1
        '
        'frmAnalysisRequestMilestoneSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 606)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.Name = "frmAnalysisRequestMilestoneSchedule"
        Me.Text = "Milestone Schedule"
        CType(Me.bsMilestoneSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panelCalendar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelCalendar.ResumeLayout(False)
        CType(Me.calMilestoneSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.schMilestoneSchedule, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents vsmMilestoneSchedule As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents UiPanelGroup1 As Janus.Windows.UI.Dock.UIPanelGroup
    Friend WithEvents panelCalendar As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents panelCalendarContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents bsMilestoneSchedule As System.Windows.Forms.BindingSource
    Friend WithEvents calMilestoneSchedule As Janus.Windows.Schedule.Calendar
    Friend WithEvents schMilestoneSchedule As Janus.Windows.Schedule.Schedule
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
