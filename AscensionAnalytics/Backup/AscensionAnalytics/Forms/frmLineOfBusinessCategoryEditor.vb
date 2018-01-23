Public Class frmLineOfBusinessCategoryEditor

    Private mDataContext As New LineOfBusinessDataContext()

    Private Sub frmLineOfBusinessCategoryEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsLineOfBusinessCategories.DataSource = mDataContext.LineOfBusinessCategories

    End Sub

    Private Sub grexLineOfBusinessCategories_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusinessCategories.RecordAdded
        SaveData()
    End Sub

    Private Sub grexLineOfBusinessCategories_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusinessCategories.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexLineOfBusinessCategories_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexLineOfBusinessCategories.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsLineOfBusinessCategories.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexLineOfBusinessCategories
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
            .Title = "Export LOB Categories"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Line Of Business Categories (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class