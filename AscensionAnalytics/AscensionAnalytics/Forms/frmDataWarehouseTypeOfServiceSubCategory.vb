Public Class frmDataWarehouseTypeOfServiceSubCategory
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseTypeOfServiceSubCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsTypeOfServiceSubCategory.DataSource = mDataContext.DataWarehouseTypeOfServiceSubCategories
    End Sub

    Private Sub grexDataWarehouseTypeOfServiceSubCategory_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceSubCategory.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseTypeOfServiceSubCategory_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceSubCategory.RecordsDeleted
        'do nothing 
    End Sub

    Private Sub grexDataWarehouseTypeOfServiceSubCategory_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceSubCategory.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsTypeOfServiceSubCategory.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseTypeOfServiceSubCategory SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseTypeOfServiceSubCategory
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
            .Title = "Export DW Type Of Service Sub-Category"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Type Of Service Sub-Category (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class