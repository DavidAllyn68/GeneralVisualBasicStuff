Public Class frmMooBenefitMapping
    Dim mDataContext As New MooDataDataContext()


    Private Sub frmMooBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsMooBenefitMapping.DataSource = mDataContext.MOO_BenefitMappings
        grexMooBenefitMapping.MoveFirst()

        'drop downs
        bsMooBenefit.DataSource = mDataContext.MOO_Benefits
        grexMooBenefitMapping.DropDowns("ddMooBenefits").SetDataBinding(bsMooBenefit, String.Empty)

        bsAscensionBenefit.DataSource = mDataContext.MooMapping_AscensionBenefits
        grexMooBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefit, String.Empty)

    End Sub

    Private Sub grexMooBenefitMapping_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexMooBenefitMapping.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete a MOO Benefit Mapping.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub grexMooBenefitMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexMooBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexMooBenefitMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexMooBenefitMapping.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexMooBenefitMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexMooBenefitMapping.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 _
                OrElse mDataContext.GetChangeSet.Inserts.Count > 0 _
                OrElse mDataContext.GetChangeSet.Deletes.Count > 0 Then

                _changesExist = True
            End If

            bsMooBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()

            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessMooData", "Process MOO Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmMooBenefitMapping SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexMooBenefitMapping
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
            .Title = "Export MOO Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Mutual Of Omaha Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class