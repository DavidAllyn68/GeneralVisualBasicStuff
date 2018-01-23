Public Class frmDataWarehouseDiagnoses
    Dim mDataContext As New DataWarehouseDataContext()


    Private Sub frmDataWarehouseDiagnoses_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDiagnoses.DataSource = mDataContext.DataWarehouseDiagnoses
        grexDataWarehouseDiagnoses.MoveFirst()

        'drop downs
        bsDatasources.DataSource = mDataContext.DataWarehouseDatasources
        grexDataWarehouseDiagnoses.DropDowns("ddDatasources").SetDataBinding(bsDatasources, String.Empty)

        bsDiagnosisCategories.DataSource = mDataContext.DataWarehouseDiagnosisCategories
        grexDataWarehouseDiagnoses.DropDowns("ddDiagnosisCategories").SetDataBinding(bsDiagnosisCategories, String.Empty)

        bsDiagnosisCodeType.DataSource = mDataContext.DataWarehouseDiagnosisCodeTypes
        grexDataWarehouseDiagnoses.DropDowns("ddDiagnosisCodeTypes").SetDataBinding(bsDiagnosisCodeType, String.Empty)

    End Sub

    Private Sub grexDataWarehouseDiagnoses_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnoses.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseDiagnoses_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnoses.RecordsDeleted
        'do nothing 
    End Sub

    Private Sub grexDataWarehouseDiagnoses_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseDiagnoses.RecordUpdated
        SaveData()
    End Sub

    Public Function SaveData() As Boolean
        SaveData = False

        Try

            bsDiagnoses.EndEdit()
            mDataContext.SubmitChanges()
            SaveData = True

        Catch ex As Exception

            MessageBox.Show(ex.Message, "frmDataWarehouseDiagnoses SaveData()")

        End Try

    End Function

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseDiagnoses
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
            .Title = "Export DW Diagnoses"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Diagnoses (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class