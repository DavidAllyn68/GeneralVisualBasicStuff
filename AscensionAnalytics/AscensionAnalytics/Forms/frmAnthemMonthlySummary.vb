Public Class frmAnthemMonthlySummary
    Dim mDataContext As New AnthemDataDataContext()

    Private Sub frmAnthemMonthlySummary_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        BindingSourceAnthemMonthlySummary.DataSource = mDataContext.anthem_claims_summaries

        BindingSourceSchoolgroups.DataSource = mDataContext.AnthemSchoolGroups
        GridEXAnthemMonthlySummary.DropDowns("ddSchoolgroups").SetDataBinding(BindingSourceSchoolgroups, "")

        With GridEXAnthemMonthlySummary.RootTable.Columns("rx_benefit")
            .HasValueList = True
            Dim _vl As Janus.Windows.GridEX.GridEXValueListItemCollection = .ValueList
            _vl.Add(1, "Rx")
            _vl.Add(0, "Medical")

            .CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            .DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
            .EditType = Janus.Windows.GridEX.EditType.Combo
            .FilterEditType = Janus.Windows.GridEX.FilterEditType.Combo
        End With

    End Sub


    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = GridEXAnthemMonthlySummary
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
            .Title = "Export Anthem Monthly Summary"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Anthem Monthly Summary (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub GridEXAnthemMonthlySummary_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles GridEXAnthemMonthlySummary.DeletingRecord
        Dim _DialogueResult As DialogResult = MessageBox.Show("You are about to delete a monthly claims record.  This is a permanent (no undo) action. Are you sure?", "CONFIRM DELETION", MessageBoxButtons.YesNo)

        If _DialogueResult <> Windows.Forms.DialogResult.Yes Then
            e.Cancel = True
        End If

    End Sub

    Private Sub GridEXAnthemMonthlySummary_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEXAnthemMonthlySummary.RecordAdded
        SaveData()
    End Sub

    Private Sub GridEXAnthemMonthlySummary_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEXAnthemMonthlySummary.RecordsDeleted
        SaveData()
    End Sub

    Private Sub GridEXAnthemMonthlySummary_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridEXAnthemMonthlySummary.RecordUpdated
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


            BindingSourceAnthemMonthlySummary.EndEdit()
            mDataContext.SubmitChanges()

            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessAnthemData", "Process Anthem Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")


        End Try
    End Sub

End Class