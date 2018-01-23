Public Class frmSchoolAddressInfo
    Private mDataContext As New SchoolAddressInfoDataContext()

    Private Sub frmSchoolAddressInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolAddressInfo.DataSource = mDataContext.SchoolAddressInfos

    End Sub

    Public Sub SaveData()
        Try
            bsSchoolAddressInfo.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexSchoolAddressInfo
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
            .Title = "Export School Address Info"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "School Address Info (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub


    Private Sub grexSchoolAddressInfo_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolAddressInfo.RecordAdded
        'No Action -- records are added by the database via procedure David.dbo.UpdateSchoolAddressInfoWithNewSchools
    End Sub

    Private Sub grexSchoolAddressInfo_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolAddressInfo.RecordsDeleted
        'No Action
    End Sub

    Private Sub grexSchoolAddressInfo_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolAddressInfo.RecordUpdated
        SaveData()
    End Sub
End Class