Public Class frmAnalysisRequestTypeEditor
    Private mDataContext As New AnalysisRequestTrackerDataContext()

    Private Sub frmAnalysisRequestTypeEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAnalysisRequestType.DataSource = mDataContext.AnalysisRequestTypes

    End Sub

    Private Sub gridExAnalysisRequestType_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestType.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExAnalysisRequestType_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestType.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExAnalysisRequestType_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisRequestType.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAnalysisRequestType.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAnalysisRequestStatusEditor SaveData")
        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExAnalysisRequestType
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
            .Title = "Export Analysis Request Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis Request Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class