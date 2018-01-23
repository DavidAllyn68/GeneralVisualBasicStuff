Public Class frmProcedureSchedule_RecurrenceTypes

    Private mDataContext As New ProcedureScheduleDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsRecurrenceTypes.DataSource = mDataContext.ProcedureSchedule_RecurrenceTypes

    End Sub

    Private Sub grexProcedureScheduleRecurrenceTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrenceTypes.RecordAdded
        SaveData()
    End Sub

    Private Sub grexProcedureScheduleRecurrenceTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrenceTypes.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexProcedureScheduleRecurrenceTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrenceTypes.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsRecurrenceTypes.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexProcedureScheduleRecurrenceTypes
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
            .Title = "Export Procedure Schedule Recurrence Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Procedure Schedule Recurrence Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class