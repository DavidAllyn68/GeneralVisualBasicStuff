Public Class frmReportViewerFilters
    Dim mDataContext As New ReportViewerDataContext()

    Public Sub SaveData()
        Try
            bsReportViewerFilters.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")
        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexReportViewerFilter
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
            .Title = "Export Report Viewer Filters"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Report Viewer Filters (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub ReportViewerFilters_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsReportViewerFilters.DataSource = mDataContext.ReportViewer_RecordFilters

    End Sub

    Private Sub grexReportViewerFilter_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexReportViewerFilter.RecordAdded
        SaveData()
    End Sub

    Private Sub grexReportViewerFilter_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexReportViewerFilter.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexReportViewerFilter_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexReportViewerFilter.RecordUpdated
        SaveData()
    End Sub
End Class