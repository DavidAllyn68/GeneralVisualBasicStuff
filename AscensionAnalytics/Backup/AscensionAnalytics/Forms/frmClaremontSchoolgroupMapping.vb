Imports Janus.Windows.GridEX

Public Class frmClaremontSchoolgroupMapping

    Dim mDataContext As New ClaremontSchoolgroupMappingDataContext()
    Private Sub frmDatasourceEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsClaremontSchoolgroupMapping.DataSource = mDataContext.ClaremontPlanHistoryData_TagMappings

        With grexClaremontSchoolgroupMapping.RootTable
            With .Columns("TagType")
                .HasValueList = True
                Dim _valueList As GridEXValueListItemCollection = .ValueList
                _valueList.Add("Claims", "Claim Tag")
                _valueList.Add("Premium", "Premium Tag")

                .CompareTarget = ColumnCompareTarget.Text
                .DefaultGroupInterval = GroupInterval.Text
                .EditType = EditType.Combo
            End With
        End With
    End Sub


    Private Sub grexDatasources_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexClaremontSchoolgroupMapping.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDatasources_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexClaremontSchoolgroupMapping.RecordsDeleted
        'do nothing
    End Sub

    Private Sub grexDatasources_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexClaremontSchoolgroupMapping.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsClaremontSchoolgroupMapping.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDatasources SaveData()")
        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexClaremontSchoolgroupMapping
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
            .Title = "Export Claremont Schoolgroup Mapping"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Claremont Colleges Schoolgroup Mapping (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class