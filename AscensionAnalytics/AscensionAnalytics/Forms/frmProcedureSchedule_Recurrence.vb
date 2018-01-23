Public Class frmProcedureSchedule_Recurrence

    Private mDataContext As New ProcedureScheduleDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsRecurrence.DataSource = mDataContext.ProcedureSchedule_Recurrences
        bsRecurrenceTypes.DataSource = mDataContext.ProcedureSchedule_RecurrenceTypes

        grexProcedureScheduleRecurrence.DropDowns("ddRecurrenceTypes").SetDataBinding(bsRecurrenceTypes, String.Empty)
    End Sub

    Private Sub grexProcedureScheduleRecurrence_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrence.RecordAdded
        SaveData()
    End Sub

    Private Sub grexProcedureScheduleRecurrence_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrence.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexProcedureScheduleRecurrence_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureScheduleRecurrence.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsRecurrence.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexProcedureScheduleRecurrence
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
            .Title = "Export Procedure Schedule Recurrence"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Procedure Schedule Recurrence (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class