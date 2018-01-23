Public Class frmAetnaBenefitMapping
    Private mDataContext As New AetnaDataDataContext()

    Private Sub frmAetnaBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAetnaBenefitMapping.DataSource = mDataContext.Aetna_BenefitMappings

        bsBenefitTypes.DataSource = mDataContext.Aetna_BenefitTypes
        grexAetnaBenefitMapping.DropDowns("ddBenefitTypes").SetDataBinding(bsBenefitTypes, String.Empty)

        bsPlaceOfServiceCodes.DataSource = mDataContext.Aetna_PlaceOfServiceCodes
        grexAetnaBenefitMapping.DropDowns("ddPlaceOfServiceCodes").SetDataBinding(bsPlaceOfServiceCodes, String.Empty)

        bsAscensionBenefits.DataSource = mDataContext.Aetna_AscensionBenefits
        grexAetnaBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefits, String.Empty)

    End Sub

    Private Sub grexAetnaBenefitMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAetnaBenefitMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaBenefitMapping.RecordsDeleted
        'do nothing
        'deleting not allowed
    End Sub

    Private Sub grexAetnaBenefitMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAetnaBenefitMapping.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsAetnaBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAetnaBenefitMapping
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
            .Title = "Export Aetna Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Aetna Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class