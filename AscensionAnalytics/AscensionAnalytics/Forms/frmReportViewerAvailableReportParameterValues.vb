Public Class frmReportViewerAvailableReportParameterValues
    Dim mDataContext As New ReportViewerDataContext()

    Private Sub frmReportViewerAvailableReportParameterValues_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAvailableReportParameters.DataSource = mDataContext.ReportViewer_AvailableReportParameterValues

    End Sub

    Public Sub SaveData()
        Try
            bsAvailableReportParameters.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try

    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAvailableReportParameters
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
            .Title = "Export Available Report Parameters"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Available Report Parameters (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub grexAvailableReportParameters_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableReportParameters.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAvailableReportParameters_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableReportParameters.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexAvailableReportParameters_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAvailableReportParameters.RecordUpdated
        SaveData()
    End Sub
End Class