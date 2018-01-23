Public Class frmPiaBenefitMapping
    Dim mDataContext As New PiaBenefitMappingDataContext()


    Private Sub frmPiaBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsPiaBenefitMapping.DataSource = mDataContext.PIA_BenefitMappings
        grexPiaBenefitMapping.MoveFirst()

        'fill drop downs
        bsPiaBenefits.DataSource = mDataContext.PIA_Benefits
        grexPiaBenefitMapping.DropDowns("ddPiaBenefits").SetDataBinding(bsPiaBenefits, String.Empty)


        bsAscensionBenefits.DataSource = mDataContext.PiaMapping_AscensionBenefits
        grexPiaBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefits, String.Empty)

    End Sub

    Private Sub grexPiaBenefitMapping_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexPiaBenefitMapping.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete a PIA Benefit Mapping.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True

    End Sub

    Private Sub grexPiaBenefitMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexPiaBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexPiaBenefitMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexPiaBenefitMapping.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexPiaBenefitMapping_RegionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexPiaBenefitMapping.RegionChanged
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsPiaBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmPiaBenefitMapping SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexPiaBenefitMapping
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
            .Title = "Export PIA Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "PIA Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class