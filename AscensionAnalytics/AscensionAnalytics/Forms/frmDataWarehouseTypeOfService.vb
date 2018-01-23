Public Class frmDataWarehouseTypeOfService
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseTypeOfService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsTypeOfService.DataSource = mDataContext.DataWarehouseTypeOfServices
        grexDataWarehouseTypeOfService.MoveFirst()

        'drop downs
        bsTypeOfServiceCategory.DataSource = mDataContext.DataWarehouseTypeOfServiceCategories
        grexDataWarehouseTypeOfService.DropDowns("ddTypeOfServiceCategories").SetDataBinding(bsTypeOfServiceCategory, String.Empty)

        bsTypeOfServiceSubCategory.DataSource = mDataContext.DataWarehouseTypeOfServiceSubCategories
        grexDataWarehouseTypeOfService.DropDowns("ddTypeOfServiceSubCategories").SetDataBinding(bsTypeOfServiceSubCategory, String.Empty)

    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfService.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfService.RecordsDeleted
        'no action
    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseTypeOfService.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsTypeOfService.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseTypeOfService SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseTypeOfService
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
            .Title = "Export DW Type Of Service"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Type Of Service (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class