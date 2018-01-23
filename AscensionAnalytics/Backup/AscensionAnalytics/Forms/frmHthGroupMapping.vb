Public Class frmHthGroupMapping
    Dim mDataContext As New HthDataDataContext()

    Private Sub frmHthGroupMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsGroupMapping.DataSource = mDataContext.HTH_GROUPS_MAPs

        bsSchoolgroups.DataSource = mDataContext.HthDataSchoolgroups
        grexHthGroupMapping.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)

    End Sub

    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 OrElse mDataContext.GetChangeSet.Inserts.Count > 0 Then
                _changesExist = True
            End If

            bsGroupMapping.EndEdit()
            mDataContext.SubmitChanges()

            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessHTHData", "Process HTH Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData() Error")
        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexHthGroupMapping
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
            .Title = "Export HTH Group Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "HTH Group Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub grexHthGroupMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthGroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexHthGroupMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthGroupMapping.RecordsDeleted
        'nothing - no deletions allowed
    End Sub

    Private Sub grexHthGroupMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexHthGroupMapping.RecordUpdated
        SaveData()
    End Sub

End Class