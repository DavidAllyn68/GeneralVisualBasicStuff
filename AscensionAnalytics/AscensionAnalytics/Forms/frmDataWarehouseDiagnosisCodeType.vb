Public Class frmDataWarehouseDiagnosisCodeType
    Dim mDataContext As New DataWarehouseDataContext()


    Private Sub frmDataWarehouseDiagnosisCodeType_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDataWarehouseDiagnosisCodeType.DataSource = mDataContext.DataWarehouseDiagnosisCodeTypes

    End Sub

    Private Sub grexDataWarehouseDiagnosisCodeType_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCodeType.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseDiagnosisCodeType_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCodeType.RecordsDeleted
        'no action
    End Sub

    Private Sub grexDataWarehouseDiagnosisCodeType_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnosisCodeType.RecordUpdated
        SaveData()
    End Sub


    Public Function SaveData() As Boolean
        SaveData = False

        Try

            bsDataWarehouseDiagnosisCodeType.EndEdit()
            mDataContext.SubmitChanges()
            SaveData = True

        Catch ex As Exception

            MessageBox.Show(ex.Message, "frmDataWarehouseDiagnosisCodeType SaveData()")

        End Try

    End Function

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseDiagnosisCodeType
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
            .Title = "Export DW Diagnosis Code Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Diagnosis Code Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class