Public Class frmHthBenefitMapping
    Dim mDataContext As New HthBenefitMappingDataContext()

    Private Sub frmHthBenefitMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsHthBenefitMapping.DataSource = mDataContext.HTH_BenefitMappings
        grexHthBenefitMapping.MoveFirst()

        'HTH Benefit Code Dropdown
        bsHthBenefitCodes.DataSource = mDataContext.HTH_BENEFITS
        grexHthBenefitMapping.DropDowns("ddHthBenefits").SetDataBinding(bsHthBenefitCodes, String.Empty)

        'HTH Place Of Service Code Dropdown
        bsHthPlaceOfService.DataSource = mDataContext.HTH_POS
        grexHthBenefitMapping.DropDowns("ddHthPlaceOfService").SetDataBinding(bsHthPlaceOfService, String.Empty)

        'Ascension Benefit Codes
        '(due to multiple contexts having the "Benefits" table, they are all named with a prefix)
        bsAscensionBenefits.DataSource = mDataContext.HthMapping_AscensionBenefits
        grexHthBenefitMapping.DropDowns("ddAscensionBenefits").SetDataBinding(bsAscensionBenefits, String.Empty)

    End Sub

    Private Sub grexHthBenefitMapping_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexHthBenefitMapping.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete a HTH Benefit Mapping.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True
    End Sub

    Private Sub GridEX1_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthBenefitMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub GridEX1_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthBenefitMapping.RecordsDeleted
        SaveData()
    End Sub

    Private Sub GridEX1_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthBenefitMapping.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 OrElse mDataContext.GetChangeSet.Inserts.Count > 0 Then
                _changesExist = True
            End If

            bsHthBenefitMapping.EndEdit()
            mDataContext.SubmitChanges()

            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessHTHData", "Process HTH Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmHthBenefitMapping SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexHthBenefitMapping
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
            .Title = "Export HTH Benefit Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "HTH Benefit Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class