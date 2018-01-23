Public Class frmAetnaGroupMapping
    Private mDataContext As New AetnaDataDataContext()
    Private mLookups As New LookupTablesDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAetnaGroupMapping.DataSource = mDataContext.Aetna_GroupMappings
        bsSchoolgroups.DataSource = mLookups.LookupSchoolgroups

        grexAetnaGroupMapping.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)

    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaGroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaGroupMapping.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAnaysisPeoplePersonTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaGroupMapping.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAetnaGroupMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAetnaGroupMapping
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
            .Title = "Export Aetna Group Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Aetna Group Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class