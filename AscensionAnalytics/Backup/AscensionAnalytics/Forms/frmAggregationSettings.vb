Imports Janus.Windows.GridEX
Public Class frmAggregationSettings
    Dim mDataContext As New AggregationSettingsDataContext()
    Dim mPeopleContext As New AnalysisRequestTrackerDataContext()
    Dim mLookupContext As New LookupTablesDataContext()

    Dim _CurrentPY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
    Dim _PreviousPY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
    Dim _Previous2PY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
    Dim _Previous3PY As New BindingSource(mLookupContext.PolicyYears, String.Empty)

    Public Sub SaveData()
        Try
            bsAggregationSettings.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAggregationSettings SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAggregationSettings
        _gridExExporter.ExportMode = Janus.Windows.GridEX.ExportMode.AllRows
        _gridExExporter.Export(_ioStream)
        _ioStream.Close()
        _ioStream.Dispose()

        Process.Start(_filePath)

    End Sub
    Public Sub ExportGridExToExcel()
        Dim _fileName As String = String.Empty
        Dim _saveFileDialogue As New SaveFileDialog()

        With _saveFileDialogue
            .Title = "Export DW Aggregation Settings"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Aggregation Settings (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub frmAggregationSettings_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAggregationSettings.DataSource = mDataContext.AggregationSettings

        bsAnalysisPeople.DataSource = mPeopleContext.AnalysisRequestPeoples
        grexAggregationSettings.DropDowns("ddAnalysisPeople").SetDataBinding(bsAnalysisPeople, String.Empty)

        Dim _CurrentPY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
        Dim _PreviousPY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
        Dim _Previous2PY As New BindingSource(mLookupContext.PolicyYears, String.Empty)
        Dim _Previous3PY As New BindingSource(mLookupContext.PolicyYears, String.Empty)

        grexAggregationSettings.DropDowns("ddCurrentPolicyYear").SetDataBinding(_CurrentPY, String.Empty)
        grexAggregationSettings.DropDowns("ddPreviousPolicyYear").SetDataBinding(_PreviousPY, String.Empty)
        grexAggregationSettings.DropDowns("ddPrevious2PolicyYear").SetDataBinding(_Previous2PY, String.Empty)
        grexAggregationSettings.DropDowns("ddPrevious3PolicyYear").SetDataBinding(_Previous3PY, String.Empty)


    End Sub

    Private Sub grexAggregationSettings_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAggregationSettings.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAggregationSettings_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAggregationSettings.RecordsDeleted
        'not allowed
    End Sub

    Private Sub grexAggregationSettings_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAggregationSettings.RecordUpdated
        SaveData()
    End Sub
End Class