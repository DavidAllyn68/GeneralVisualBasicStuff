Public Class frmMarketingDb_SchoolgroupMapping
    Private mDataContext As New MarketingDbDataInDavidDataContext()
    Private mLookupTables As New LookupTablesDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupMapping.DataSource = mDataContext.MarketingDB_SchoolgroupMappings
        bsPremiumSystemSchoolgroups.DataSource = mLookupTables.LookupSchoolgroups

        grexSchoolgroupMapping.DropDowns("ddSchoolgroups").SetDataBinding(bsPremiumSystemSchoolgroups, String.Empty)
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupMapping.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupMapping.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsSchoolgroupMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexSchoolgroupMapping
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
            .Title = "Export Marketing DB Schoolgroup Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Marketing DB Schoolgroup Mapping(as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class