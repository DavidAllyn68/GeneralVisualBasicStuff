Public Class frmDataWarehouseDiagnosisCategories
    Dim mDataContext As New DataWarehouseDataContext()


    Private Sub frmDataWarehouseDiagnosisCategories_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDiagnosisCategories.DataSource = mDataContext.DataWarehouseDiagnosisCategories

    End Sub

    Private Sub grexDataWarehouseDiagnosisCategories_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCategories.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseDiagnosisCategories_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCategories.RecordsDeleted
        'do nothing
    End Sub

    Private Sub grexDataWarehouseDiagnosisCategories_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCategories.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsDiagnosisCategories.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseDiagnosisCategories SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseDiagnosisCategories
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
            .Title = "Export DW Diagnosis Categories"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Diagnosis Categories (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class