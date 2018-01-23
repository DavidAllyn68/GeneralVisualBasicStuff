Public Class frmAnalysisRequestStatusEditor
    Private mDataContext As New AnalysisRequestTrackerDataContext()

    Private Sub frmAnalysisRequestStatus_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAnalysisRequestStatus.DataSource = mDataContext.AnalysisRequestStatus

    End Sub

    Private Sub gridExAnalysisRequestStatus_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestStatus.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExAnalysisRequestStatus_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestStatus.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExAnalysisRequestStatus_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestStatus.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAnalysisRequestStatus.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAnalysisRequestStatusEditor SaveData")
        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExAnalysisRequestStatus
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
            .Title = "Export Analysis Request Statuses"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis Request Statuses (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class