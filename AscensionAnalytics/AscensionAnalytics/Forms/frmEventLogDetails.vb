Public Class frmEventLogDetails
    Private mDataContext As New EventLogDataContext()
    Private WithEvents mRefreshTimer As New Timer()
    Private mSuspendRefresh As Integer
    Private mGridFilterCondition As New Janus.Windows.GridEX.GridEXFilterCondition()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsEventLogDetails.DataSource = mDataContext.David_EventLog_Details
        grexEventLogDetails.MoveFirst()
        grexEventLogDetails.CollapseGroups()


        mRefreshTimer.Interval = 1000
        mRefreshTimer.Start()

    End Sub

    Private Sub grexEventLogDetails_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grexEventLogDetails.MouseMove

        'suspend refreshing for 5 timer intervals
        '(see Refresh() and Timer.Interval event handler)
        mSuspendRefresh = 5
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEventLogDetails.RecordAdded
        'do nothing
        'adding not allowed
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEventLogDetails.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEventLogDetails.RecordUpdated
        'do nothing
        'editing not allowed
    End Sub


    Public Overrides Sub Refresh()
        MyBase.Refresh()
        'AFTER MUCH ADO....
        'I tried several methods, and this is the only one that
        'refreshes the grid with what is in the database while keeping the filtering
        'that the user specified.  Basically we completely "replumb" the data sources

        'all other technique "lose" the filter and will display all of the rows upon
        'the next refresh.

        '1) save filter condition to persist across the refresh 
        mGridFilterCondition = grexEventLogDetails.RootTable.FilterCondition

        '2) refresh the data by creating a fresh data context
        mDataContext = New EventLogDataContext()

        '3) reset the binding source's datasource
        bsEventLogDetails.DataSource = mDataContext.David_EventLog_Details

        '4) reset the gridEx  datasource
        grexEventLogDetails.DataSource = bsEventLogDetails

        '5) reapply the stored filter
        grexEventLogDetails.RootTable.FilterCondition = mGridFilterCondition

        '6) refetch the rows using that filter
        grexEventLogDetails.Refetch()

    End Sub

    Public Sub SaveData()
        Try
            bsEventLogDetails.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub


    Private Sub mRefreshTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles mRefreshTimer.Tick

        'If there is no suspending, then refresh
        'else count down
        If mSuspendRefresh = 0 Then
            Refresh()
        Else
            mSuspendRefresh -= 1
        End If
    End Sub


End Class