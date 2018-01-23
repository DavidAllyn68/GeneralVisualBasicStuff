Public Class frmDataWarehouseBenefits
    Dim mDataContext As New DataWarehouseDataContext()

    Private Sub frmDataWarehouseBenefits_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDataWarehouseBenefits.DataSource = mDataContext.DataWarehouseBenefits
        grexDataWarehouseBenefits.MoveFirst()

        bsDataWarehouseBenefitCategories.DataSource = mDataContext.DataWarehouseBenefitCategories
        grexDataWarehouseBenefits.DropDowns("ddBenefitCategories").SetDataBinding(bsDataWarehouseBenefitCategories, String.Empty)

    End Sub

    Private Sub grexDataWarehouseBenefits_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseBenefits.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseBenefits_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseBenefits.RecordsDeleted
        'no action
    End Sub

    Private Sub grexDataWarehouseBenefits_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseBenefits.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsDataWarehouseBenefits.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseBenefits SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseBenefits
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
            .Title = "Export DW Benefits"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Benefits (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class