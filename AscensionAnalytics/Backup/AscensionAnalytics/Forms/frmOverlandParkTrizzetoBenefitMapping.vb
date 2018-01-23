Public Class frmOverlandParkTrizzetoBenefitMapping
    Dim mDataContext As New OverlandParkTrizzetoBenefitMappingDataContext()

    Private Sub frmHthBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsOverlandParkTrizzetoBenefitMapping.DataSource = mDataContext.OverlandParkTrizzeto_BenefitMappings
        grexOverlandParkTrizzetoBenefitMapping.MoveFirst()

        'Ascension Benefit Codes
        '(due to multiple contexts having the "Benefits" table, they are all named with a prefix)
        bsAscensionBenefits.DataSource = mDataContext.OverlandParkTrizzetoMapping_AscensionBenefits
        grexOverlandParkTrizzetoBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefits, String.Empty)

        bsPlaceOfService.DataSource = mDataContext.OverlandParkTrizzeto_PlaceOfServices
        grexOverlandParkTrizzetoBenefitMapping.DropDowns("ddPlaceOfService").SetDataBinding(bsPlaceOfService, String.Empty)

    End Sub

    Private Sub grexHthBenefitMapping_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexOverlandParkTrizzetoBenefitMapping.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete a HTH Benefit Mapping.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub GridEX1_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkTrizzetoBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub GridEX1_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkTrizzetoBenefitMapping.RecordsDeleted
        SaveData()
    End Sub

    Private Sub GridEX1_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexOverlandParkTrizzetoBenefitMapping.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsOverlandParkTrizzetoBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexOverlandParkTrizzetoBenefitMapping
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
            .Title = "Export OP Trizzeto Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Overland Park Trizzeto Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class