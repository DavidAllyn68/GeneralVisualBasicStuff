Public Class frmDataWarehouseTypeOfServiceCategory
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseTypeOfServiceCategory_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsTypeOfServiceCategory.DataSource = mDataContext.DataWarehouseTypeOfServiceCategories
        grexDataWarehouseTypeOfServiceCategory.MoveFirst()

    End Sub

    Private Sub grexDataWarehouseTypeOfServiceCategory_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceCategory.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseTypeOfServiceCategory_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceCategory.RecordsDeleted
        'do nothing
    End Sub

    Private Sub grexDataWarehouseTypeOfServiceCategory_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfServiceCategory.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsTypeOfServiceCategory.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseTypeOfServiceCategory SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseTypeOfServiceCategory
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
            .Title = "Export DW Type Of Service Category"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Type Of Service Category (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class