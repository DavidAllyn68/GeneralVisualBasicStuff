Public Class frmSchoolgroupLineOfBusinessEditor
    Private mDataContext As New LineOfBusinessDataContext()
    Private mLookupContext As New LookupTablesDataContext()

    Private Sub frmSchoolgroupLineOfBusiness_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupLineOfBusiness.DataSource = mDataContext.SchoolgroupLineOfBusinesses
        bsLineOfBusiness.DataSource = mDataContext.LineOfBusinesses
        bsSchoolgroups.DataSource = mLookupContext.LookupSchoolgroups

        grexSchoolgroupLineOfBusiness.DropDowns("ddLineOfBusiness").SetDataBinding(bsLineOfBusiness, String.Empty)
        grexSchoolgroupLineOfBusiness.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)

    End Sub

    Private Sub grexSchoolgroupLineOfBusiness_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupLineOfBusiness.RecordAdded
        SaveData()
    End Sub

    Private Sub grexSchoolgroupLineOfBusiness_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupLineOfBusiness.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexSchoolgroupLineOfBusiness_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupLineOfBusiness.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsSchoolgroupLineOfBusiness.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexSchoolgroupLineOfBusiness
        _gridExExporter.ExportMode = Janus.Windows.GridEX.ExportMode.AllRows
        _gridExExporter.Export(_ioStream)
        _ioStream.Close()
        _ioStream.Dispose()


    End Sub
    Public Sub ExportGridExToExcel()
        Dim _fileName As String = String.Empty
        Dim _saveFileDialogue As New SaveFileDialog()

        With _saveFileDialogue
            .Title = "Export Schoolgroup Line Of Business"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Schoolgroup Line Of Business (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class