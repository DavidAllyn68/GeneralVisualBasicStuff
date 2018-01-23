Public Class frmProcedureSchedule

    Private mDataContext As New ProcedureScheduleDataContext()

    Private Sub frmProcedureSchedule_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsProcedureSchedule.DataSource = mDataContext.ProcedureSchedules


    End Sub

    Private Sub grexProcedureSchedule_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureSchedule.RecordAdded
        SaveData()
    End Sub

    Private Sub grexProcedureSchedule_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureSchedule.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexProcedureSchedule_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProcedureSchedule.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsProcedureSchedule.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmProcedureSchedule SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexProcedureSchedule
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
            .Title = "Export Procedure Schedule"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Procedure Schedule (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class