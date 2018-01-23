Imports System.Diagnostics.Process 'for opening files in their native application
Imports Janus.Windows.GridEX

'This form binds directly to the frmAnalysisRequestListing binding sources and context
Public Class frmAnalysisRequestDetail

    Public MyAnalysisId As Integer = 0
    Private WithEvents mLogTimer As New Timer()
    Private mLogTimerActive As Boolean = True
    Private mLogMinutes As Integer = 0

    Public Sub SaveData()
        Try

            frmAnalysisRequestListing.SaveData()
            SetDataBindings()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAnalysisRequestEditor SaveRequest Error")

        End Try
    End Sub

    Public Sub ExportGridExToExcel()
        'NOTE: THERE IS NO GRID THAT SHOWS BOTH ASSOCIATIONS AND SCHOOLGROUP INFORMATION
        'SO EXPORTING TO GRID IN THE DETAIL IS PROHIBITIVE

        MessageBox.Show("Exporting to Excel is not supported here.", "Exporting Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
    Private Sub SetDataBindings()
        'Our DataContext is the AnalysisRequestListingDataContext from the request listing form
        bsAnalysisRequest.DataSource = (From _i As AnalysisRequest In frmAnalysisRequestListing.AnalysisRequestListingDataContext.AnalysisRequests Where _i.AnalysisId = MyAnalysisId).SingleOrDefault
        bsAnalysisRequestLogs.DataSource = bsAnalysisRequest
        bsAnalysisRequestLogs.DataMember = "AnalysisRequestLogs"

        bsRequestors.DataSource = frmAnalysisRequestListing.AnalysisRequestListingDataContext.AnalysisRequestPeoples
        bsAssignees.DataSource = frmAnalysisRequestListing.AnalysisRequestListingDataContext.AnalysisRequestPeoples
        bsStatuses.DataSource = frmAnalysisRequestListing.AnalysisRequestListingDataContext.AnalysisRequestStatus
        bsTypes.DataSource = frmAnalysisRequestListing.AnalysisRequestListingDataContext.AnalysisRequestTypes

    End Sub

    Public Overrides Sub Refresh()
        MyBase.Refresh()

        SaveData()
        SetDataBindings()
        grexRequestLog.Refetch()
    End Sub

    Private Sub frmAnalysisRequestEditor_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveData()
    End Sub


    Private Sub frmAnalysisRequestEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        SetDataBindings()

        'add meaningful description to DataActivityEntry column
        With grexRequestLog.RootTable.Columns("DataActivityEntry")
            .HasValueList = True
            Dim _valueList As GridEXValueListItemCollection = .ValueList
            _valueList.Add(1, "Data Log")
            _valueList.Add(0, "User Log")

            .CompareTarget = ColumnCompareTarget.Text
            .DefaultGroupInterval = GroupInterval.Text
            .EditType = EditType.Combo
        End With

        'disable log entry editing if the log is a data activity
        editBoxLogEntryText.DataBindings.Add("Enabled", bsAnalysisRequestLogs, "EntryTextIsEditable")
        editBoxEffortMinutes.DataBindings.Add("Enabled", bsAnalysisRequestLogs, "EntryTextIsEditable")

        'disable form controls based on if the user is an assignee or not
        Me.DataBindings.Add("Text", bsAnalysisRequest, "NameForDisplay")
        editBoxDescription.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        EditBoxName.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        comboRequestor.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        comboRequestType.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        comboRequestStatus.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        checkBoxIsActive.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        calComboMilestoneDate.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        editBoxMilestone.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        editBoxDirectoryFullPath.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")
        uibuttonNow.DataBindings.Add("Enabled", bsAnalysisRequest, "CurrentUserIsAssignee")


        mLogTimer.Interval = 60000 'increment every minute
        ResetTimer()
        UpdateTotalEffortDisplay()

    End Sub

    Private Sub buttonOpenRequestDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonOpenRequestDirectory.Click
        Try
            Dim _FullPath As String = TryCast(bsAnalysisRequest.Current, AnalysisRequest).DirectoryFullPath
            If My.Computer.FileSystem.DirectoryExists(_FullPath) OrElse My.Computer.FileSystem.FileExists(_FullPath) Then
                Start(_FullPath)
            Else
                MessageBox.Show("File or Folder doesn't exist. Please check the path and try again.")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAnalysisRequestEditor buttonOpenRequestDirectory_Click")

        End Try
    End Sub

    Private Sub mLogTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles mLogTimer.Tick
        If mLogTimerActive Then mLogMinutes += 1
        editBoxTimer.Text = mLogMinutes.ToString()

    End Sub
    Private Sub UpdateTotalEffortDisplay()
        Dim _display As String = String.Empty
        Dim _min As Integer = (From p As AnalysisRequestLog In bsAnalysisRequestLogs Where p.AnalysisId = MyAnalysisId Select p.EffortMinutes).Sum
        Dim _hrs As Integer = 0

        While _min > 59
            _hrs += 1
            _min -= 60
        End While

        If _min < 10 Then
            _display = _hrs & "h 0" & _min & "m"
        Else
            _display = _hrs & "h " & _min & "m"
        End If

        editBoxTotalEffortDisplay.Text = _display

    End Sub

    Private Sub ResetTimer()
        mLogTimer.Stop()
        mLogMinutes = 0
        editBoxTimer.Text = 0
        mLogTimer.Start()
        mLogTimerActive = True
    End Sub

    Private Sub buttonTimerPause_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonTimerPause.Click
        mLogTimerActive = Not mLogTimerActive
        If mLogTimerActive Then
            buttonTimerPause.BackColor = Color.GreenYellow
        Else
            buttonTimerPause.BackColor = Color.LightSalmon
        End If
    End Sub
    Private Sub buttonTimerReset_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles buttonTimerReset.Click
        ResetTimer()
        buttonTimerPause.BackColor = Color.GreenYellow
    End Sub

    Private Sub bsAnalysisRequestLogs_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles bsAnalysisRequestLogs.ListChanged
        UpdateTotalEffortDisplay()
    End Sub

    Private Sub uibuttonNow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uibuttonNow.Click
        TryCast(bsAnalysisRequest.Current, AnalysisRequest).MilestoneDate = Now()
    End Sub

End Class