Public Class frmAnalysisPeopleEditor
    Private mDataContext As New AnalysisRequestTrackerDataContext()

    Private Sub frmAnalysisPeopleEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAnalysisPeople.DataSource = mDataContext.AnalysisRequestPeoples
        bsAnalysisPeoplePersonTypes.DataSource = mDataContext.AnalysisPeople_PersonTypes

        gridExAnalysisPeople.DropDowns("ddPersonTypes").SetDataBinding(bsAnalysisPeoplePersonTypes, String.Empty)

    End Sub

    Private Sub gridExAnalysisPeople_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisPeople.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExAnalysisPeople_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisPeople.RecordsDeleted
        'deleting not allowed
        'there are dependencies that can't be broken
    End Sub

    Private Sub gridExAnalysisPeople_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAnalysisPeople.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAnalysisPeople.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExAnalysisPeople
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
            .Title = "Export Analysis People"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis People (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class