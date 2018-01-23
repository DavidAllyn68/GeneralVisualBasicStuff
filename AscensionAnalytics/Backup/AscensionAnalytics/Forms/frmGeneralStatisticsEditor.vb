Public Class frmGeneralStatisticsEditor
    Private mDataContext As New GeneralStatisticsDataContext()
    Private mRefreshAllowed As Boolean = False

    Private Sub frmGeneralStatisticsEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsStatistics.DataSource = mDataContext.GeneralStatistics_Statistics
        bsCategories.DataSource = mDataContext.GeneralStatistics_Categories

        grexStatistics.DropDowns("ddCategories").SetDataBinding(bsCategories, String.Empty)

        mRefreshAllowed = True
    End Sub

    Private Sub grexStatistics_EditingCell(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.EditingCellEventArgs) Handles grexStatistics.EditingCell

        Dim _CurrentRow As Janus.Windows.GridEX.GridEXRow = grexStatistics.CurrentRow
        Dim _CurrentColumn As Janus.Windows.GridEX.GridEXColumn = grexStatistics.CurrentColumn

        If _CurrentRow.RowType = Janus.Windows.GridEX.RowType.Record AndAlso _CurrentColumn.Key = "DevelopmentSQL" Then
            Dim _rslt As DialogResult
            _rslt = MessageBox.Show("PROCEED WITH CAUTION:" & vbCrLf & "This SQL Statement should not be edited once it has been developed.  Doing so could lead to prior development of this statistic to be inaccurate." & vbCrLf & vbCrLf & "Are you sure you would like to continue editing?", "CAUTION: EDITING PRIOR DEVELOPED STATISTIC!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

            If _rslt <> Windows.Forms.DialogResult.Yes Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub grexStatistics_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatistics.RecordAdded
        SaveData()
        DevelopStatisticsOnCurrentRow()
    End Sub

    Private Sub grexStatistics_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatistics.RecordsDeleted
        'Not Allowed
    End Sub

    Private Sub grexStatistics_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexStatistics.RecordUpdated
        SaveData()
    End Sub
    Private Sub grexDevelopedStatistics_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDevelopedStatistics.RecordsDeleted
        'Not Allowed
    End Sub
    Private Sub grexStatistics_ColumnButtonClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.ColumnActionEventArgs) Handles grexStatistics.ColumnButtonClick
        If e.Column.Key = "DevelopmentButton" Then
            DevelopStatisticsOnCurrentRow()
        End If
    End Sub
    Public Sub SaveData()
        Try
            bsStatistics.EndEdit()
            bsDevelopedStatistics.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Private Sub SaveDevelopedStatistic()

        Try
            bsDevelopedStatistics.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveDevelopedStatistic()")

        End Try
    End Sub

    Private Sub DevelopStatisticsOnCurrentRow()
        Dim _Statistic As GeneralStatistics_Statistic = TryCast(bsStatistics.Current, GeneralStatistics_Statistic)

        Threading.ThreadPool.QueueUserWorkItem(AddressOf mdiMain.ProcessGeneralStatistic, _Statistic.GeneralStatisticId)

    End Sub

    Public Sub ExportGridExToExcel()
        MessageBox.Show("Exporting to Excel is not supported here.", "Exporting Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Public Overrides Sub Refresh()
        MyBase.Refresh()
        'AFTER MUCH ADO....
        'I tried several methods, and this is the only one that
        'refreshes the grid with what is in the database while keeping the filtering
        'that the user specified.  Basically we completely "replumb" the data sources

        'all other technique "lose" the filter and will display all of the rows upon
        'the next refresh

        Dim _id As Integer = TryCast(bsStatistics.Current, GeneralStatistics_Statistic).GeneralStatisticId

        mDataContext = New GeneralStatisticsDataContext()
        bsStatistics.DataSource = mDataContext.GeneralStatistics_Statistics
        grexStatistics.Refetch()
        grexDevelopedStatistics.Refetch()

        grexStatistics.Find(grexStatistics.RootTable.Columns("GeneralStatisticId"), Janus.Windows.GridEX.ConditionOperator.Equal, _id, 0, 1)


    End Sub

End Class

