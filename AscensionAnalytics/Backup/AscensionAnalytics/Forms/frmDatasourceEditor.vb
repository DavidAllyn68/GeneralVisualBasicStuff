Public Class frmDatasourceEditor

    Dim mDataContext As New DatasourcesDataContext()
    Private Sub frmDatasourceEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDatasources.DataSource = mDataContext.Datasources
    End Sub


    Private Sub grexDatasources_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDatasources.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDatasources_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDatasources.RecordsDeleted
        'do nothing
    End Sub

    Private Sub grexDatasources_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDatasources.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsDatasources.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDatasources SaveData()")
        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDatasources
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
            .Title = "Export DW Data Sources"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Data Sources (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class