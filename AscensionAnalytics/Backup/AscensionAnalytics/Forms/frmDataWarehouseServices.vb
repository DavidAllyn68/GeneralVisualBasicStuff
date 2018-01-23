Public Class frmDataWarehouseServices
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseServices_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsServices.DataSource = mDataContext.DataWarehouseServices
        grexDataWarehouseServices.MoveFirst()

        'drop downs
        bsTypeOfService.DataSource = mDataContext.DataWarehouseTypeOfServices
        grexDataWarehouseServices.DropDowns("ddTypeOfService").SetDataBinding(bsTypeOfService, String.Empty)

        bsServiceCodeTypes.DataSource = mDataContext.DataWarehouseServiceCodeTypes
        grexDataWarehouseServices.DropDowns("ddServiceCodeType").SetDataBinding(bsServiceCodeTypes, String.Empty)

    End Sub

    Private Sub grexDataWarehouseServices_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServices.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseServices_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServices.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexDataWarehouseServices_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServices.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsServices.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseServices SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseServices
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
            .Title = "Export Services"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Services (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class