Imports Janus.Windows.GridEX

Public Class frmAmeribenGroupMapping
    Dim mDataContext As New AmeribenDataDataContext()

    Private Sub frmAmeribenGroupMapping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsAmeribenGroupMap.DataSource = mDataContext.Ameriben_GroupMaps

        'create value list for IsAthletic
        'add meaningful description to DataActivityEntry column
        With grexAmeribenGroupMapping.RootTable.Columns("IsAthletic")
            .HasValueList = True
            Dim _valueList As GridEXValueListItemCollection = .ValueList
            _valueList.Add(1, "Athletic")
            _valueList.Add(0, "Non Athletic")

            .CompareTarget = ColumnCompareTarget.Text
            .DefaultGroupInterval = GroupInterval.Text
            .EditType = EditType.Combo
        End With

    End Sub

    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 OrElse mDataContext.GetChangeSet.Inserts.Count > 0 Then
                _changesExist = True
            End If

            bsAmeribenGroupMap.EndEdit()
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
            MessageBox.Show(ex.Message, "frmAmeribenGroupMapping SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAmeribenGroupMapping
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
            .Title = "Export Ameriben Group Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Ameriben Group Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

    Private Sub grexAmeribenGroupMapping_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenGroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAmeribenGroupMapping_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenGroupMapping.RecordsDeleted
        'NO ACTION NOT ALLOWED  
    End Sub

    Private Sub grexAmeribenGroupMapping_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenGroupMapping.RecordUpdated
        SaveData()
    End Sub
End Class