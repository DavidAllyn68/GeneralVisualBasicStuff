Public Class StatisticsQuickCalc_Generic
    Public mStat As New Statistics


    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindingSource1.DataSource = mStat

    End Sub

    Private Sub GridEX1_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs)
        UpdateAggregation()
    End Sub

    Private Sub GridEX1_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs)
        UpdateAggregation()
    End Sub

    Private Sub GridEX1_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs)
        UpdateAggregation()
    End Sub

    Private Sub UpdateAggregation()
        tbCount.Text = mStat.Count
        tbCountWithoutZeros.Text = mStat.NonZeroCount
        tbMean.Text = mStat.Mean.ToString("c")
        tbMeanWithoutZeros.Text = mStat.NonZeroMean.ToString("c")
        tbMin.Text = mStat.Min.ToString("c")
        tbMax.Text = mStat.Max.ToString("c")
        tbSum.Text = mStat.Sum.ToString("c")
        tbStandardDeviationSample.Text = mStat.StandardDeviationSample.ToString("c")
        tbStandardDeviationPopulation.Text = mStat.StandardDeviationPopulation.ToString("c")
    End Sub
End Class
