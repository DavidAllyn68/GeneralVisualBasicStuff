Public Class frmAlternateDescriptorEditor
    Dim mDataContext As New AlternateDescriptorsDataContext()

    Private Sub frmAlternateDescriptorEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAlternateDescriptors.DataSource = mDataContext.cc_AlternateDescriptors

    End Sub

    Private Sub gridExAlternateDescriptors_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles gridExAlternateDescriptors.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete an Alternate Description for a group.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub gridExAlternateDescriptors_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAlternateDescriptors.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExAlternateDescriptors_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAlternateDescriptors.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExAlternateDescriptors_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExAlternateDescriptors.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAlternateDescriptors.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExAlternateDescriptors
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
            .Title = "Export DW Alternate Descriptors"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Alternate Descriptors(as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class