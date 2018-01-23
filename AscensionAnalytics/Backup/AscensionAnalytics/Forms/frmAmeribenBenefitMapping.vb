Public Class frmAmeribenBenefitMapping
    Private mDataContext As New AmeribenBenefitMappingDataContext()
    Private mDataNeedsProcessing As Boolean = False

    Private Sub frmAmeribenBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAmeribenBenefitMapping.DataSource = mDataContext.Ameriben_BenefitMappings
        grexAmeribenBenefitMapping.MoveFirst()

        'POS dropdown
        bsAmeribenPOS.DataSource = mDataContext.Ameriben_POS
        Me.grexAmeribenBenefitMapping.DropDowns("ddAmeribenPOS").SetDataBinding(bsAmeribenPOS, String.Empty)

        'TOS dropdown
        bsAmeribenTOS.DataSource = mDataContext.Ameriben_TOS
        Me.grexAmeribenBenefitMapping.DropDowns("ddAmeribenTOS").SetDataBinding(bsAmeribenTOS, String.Empty)

        'Benefit dropdown
        bsAscensionBenefits.DataSource = mDataContext.AmeribenMapping_AscensionBenefits
        Me.grexAmeribenBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefits, String.Empty)

    End Sub

    Private Sub grexAmeribenBenefitMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAmeribenBenefitMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenBenefitMapping.RecordsDeleted
        'do nothing
    End Sub

    Private Sub grexAmeribenBenefitMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenBenefitMapping.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 OrElse mDataContext.GetChangeSet.Inserts.Count > 0 Then
                _changesExist = True
            End If

            bsAmeribenBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()

            'notify the user that Ameriben data needs reprocessing.
            'placed after the update so that the user
            'doesn't process data if there was an error.
            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessAmeribenData", "Process Ameriben Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAmeribenBenefitMapping SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAmeribenBenefitMapping
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
            .Title = "Export Ameriben Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Ameriben Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class