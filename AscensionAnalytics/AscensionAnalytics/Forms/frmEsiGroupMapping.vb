Public Class frmEsiGroupMapping
    Private mDataContext As New EsiGroupMappingDataContext()
    Private mLookupContext As New LookupTablesDataContext()

    Private Sub frmEsiGroupMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsEsiGroupMap.DataSource = mDataContext.ESI_Group_Maps

        bsSchoolgroupLookup.DataSource = mLookupContext.LookupSchoolgroups
        grexEsiGroupMapping.DropDowns("ddSchoolgroupCode").SetDataBinding(bsSchoolgroupLookup, String.Empty)
    End Sub

    Public Sub SaveData()
        Try
            bsEsiGroupMap.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData() Error")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexEsiGroupMapping
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
            .Title = "Export ESI Group Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "ESI Group Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub


    Private Sub grexEsiGroupMapping_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexEsiGroupMapping.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete an ESI schoolgroup mapping.   This can not be undone.  Would you like to delete it?", "CONFIRM ESI MAPPING DELETION", MessageBoxButtons.YesNo)

        If _DialogueResult <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
        End If
    End Sub

    Private Sub grexEsiGroupMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEsiGroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexEsiGroupMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEsiGroupMapping.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexEsiGroupMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexEsiGroupMapping.RecordUpdated
        SaveData()
    End Sub
End Class