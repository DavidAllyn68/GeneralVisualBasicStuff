Public Class frmOverlandParkEnrollmentActivity
    Private mDataContext As New OverlandParkEnrollmentActivityDataContext()

    Private Sub frmAnaysisPeoplePersonTypesEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsOverlandParkEnrollmentActivity.DataSource = mDataContext.OverlandPark_EnrollmentActivities
        bsGroups.DataSource = mDataContext.OverlandPark_Enrollment_Groups

        grexOverlandParkEnrollmentActivity.DropDowns("ddGroups").SetDataBinding(bsGroups, String.Empty)
    End Sub

    Private Sub grid_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkEnrollmentActivity.RecordAdded
        SaveData()
    End Sub

    Private Sub grid_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkEnrollmentActivity.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grid_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkEnrollmentActivity.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsOverlandParkEnrollmentActivity.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexOverlandParkEnrollmentActivity
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
            .Title = "Export OP Enrollment Activity"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Overland Park Enrollment Activity (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class