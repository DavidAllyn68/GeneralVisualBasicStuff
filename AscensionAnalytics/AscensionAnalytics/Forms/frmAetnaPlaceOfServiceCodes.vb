Public Class frmAetnaPlaceOfServiceCodes
    Private mDataContext As New AetnaDataDataContext()

    Private Sub frmAetnaPlaceOfServiceCodes_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAetnaPlaceOfServiceCodes.DataSource = mDataContext.Aetna_PlaceOfServiceCodes

    End Sub

    Private Sub grexAetnaPlaceOfServiceCodes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaPlaceOfServiceCodes.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAetnaPlaceOfServiceCodes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaPlaceOfServiceCodes.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAetnaPlaceOfServiceCodes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaPlaceOfServiceCodes.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAetnaPlaceOfServiceCodes.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAetnaPlaceOfServiceCodes
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
            .Title = "Export Place Of Service Codes"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Aetna Place Of Service Codes (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class