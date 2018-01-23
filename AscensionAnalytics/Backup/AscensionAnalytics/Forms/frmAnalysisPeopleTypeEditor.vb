Public Class frmAnalysisPeoplePersonTypeEditor
    Private mDataContext As New AnalysisRequestTrackerDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAnalysisPeople_PersonType.DataSource = mDataContext.AnalysisPeople_PersonTypes

    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAnaysisPeoplePersonTypes.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAnaysisPeoplePersonTypes.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAnaysisPeoplePersonTypes.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAnalysisPeople_PersonType.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAnaysisPeoplePersonTypes
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
            .Title = "Export Analysis People Person Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis People Person Types(as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class