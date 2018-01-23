Public Class frmDataWarehouseServiceCodeType
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseTypeOfService_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsServiceCodeType.DataSource = mDataContext.DataWarehouseServiceCodeTypes

    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServiceCodeTypes.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServiceCodeTypes.RecordsDeleted
        'no action - deleting not allowed
    End Sub

    Private Sub grexDataWarehouseTypeOfService_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseServiceCodeTypes.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsServiceCodeType.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseServiceCodeTypes
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
            .Title = "Export DW Service Code Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Service Code Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class