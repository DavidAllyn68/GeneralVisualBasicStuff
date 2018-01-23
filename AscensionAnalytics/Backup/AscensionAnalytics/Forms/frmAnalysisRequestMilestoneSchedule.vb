Public Class frmAnalysisRequestMilestoneSchedule
    Dim mDataContext As AnalysisRequestTrackerDataContext


    Private Sub frmAnalysisRequestMilestoneSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not frmAnalysisRequestListing.Visible Then
            mdiMain.OpenForm(frmAnalysisRequestListing)
        End If

        mDataContext = frmAnalysisRequestListing.AnalysisRequestListingDataContext
        bsMilestoneSchedule.DataSource = frmAnalysisRequestListing.bsAnalysisRequestListing
        Me.Focus()

        schMilestoneSchedule.TextMember = "ScheduleItemTitle"
        schMilestoneSchedule.EndTimeMember = "MilestoneEndForScheduleDisplay"
    End Sub

    Private Sub schMilestoneSchedule_AppointmentDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.Schedule.AppointmentEventArgs) Handles schMilestoneSchedule.AppointmentDoubleClick
        frmAnalysisRequestListing.OpenEditingForm(e.Appointment.Owner)
    End Sub

End Class