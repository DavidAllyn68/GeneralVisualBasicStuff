Imports System.Data.Linq

Public Class frmDistributionsEditor
    Dim mDataContext As New DistriubtionTiersDataContext()

    Private Sub frmDistributionsEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsDistributions.DataSource = mDataContext.Distributions

    End Sub

    Private Sub gridExDistributions_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributions.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExDistributions_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributions.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExDistributions_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributions.RecordUpdated
        SaveData()
    End Sub

    Private Sub gridExDistributionTiers_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributionTiers.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExDistributionTiers_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributionTiers.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExDistributionTiers_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExDistributionTiers.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try

            bsDistributions.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    'Public Sub ExportGridExToExcel(ByVal _filePath As String)

    '    Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
    '    Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
    '    _gridExExporter.GridEX = grexAetnaPlaceOfServiceCodes
    '    _gridExExporter.ExportMode = Janus.Windows.GridEX.ExportMode.AllRows
    '    _gridExExporter.Export(_ioStream)
    '    _ioStream.Close()
    '    _ioStream.Dispose()
    '    Process.Start(_filePath)

    'End Sub
    Public Sub ExportGridExToExcel()
        MessageBox.Show("Exporting to Excel is not supported here.", "Exporting Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'NOTE: THERE IS NO GRID THAT SHOWS BOTH ASSOCIATIONS AND SCHOOLGROUP INFORMATION
        'Dim _fileName As String = String.Empty
        'Dim _saveFileDialogue As New SaveFileDialog()

        'With _saveFileDialogue
        '    .Title = "Export Place Of Service Codes"
        '    .AddExtension = True
        '    .DefaultExt = ".xls"
        '    .FileName = "Aetna Place Of Service Codes (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
        '    '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        '    .InitialDirectory = My.Settings.AnalysisRequestsDirectory
        '    .OverwritePrompt = True
        '    .ShowDialog()
        '    _fileName = .FileName
        'End With

        'ExportGridExToExcel(_fileName)

    End Sub

End Class