Imports Janus.Windows.GridEX

Public Class frmAnalysisRequestLogListing
    Dim mDataContext As AnalysisRequestTrackerDataContext

    Private Sub frmAnalysisRequestLogListing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not frmAnalysisRequestListing.Visible Then
            mdiMain.OpenForm(frmAnalysisRequestListing)
        End If

        mDataContext = frmAnalysisRequestListing.AnalysisRequestListingDataContext

        bsLogs.DataSource = mDataContext.AnalysisRequestLogs
        bsAnalysisRequests.DataSource = mDataContext.AnalysisRequests

        With grexLogListing
            With .RootTable
                With .Columns("DataActivityEntry")
                    .HasValueList = True
                    Dim _valueList As GridEXValueListItemCollection = .ValueList
                    _valueList.Add(1, "Data Log")
                    _valueList.Add(0, "User Log")

                    .CompareTarget = ColumnCompareTarget.Text
                    .DefaultGroupInterval = GroupInterval.Text
                    .EditType = EditType.Combo
                End With

                'there is format condition created in the designer
                'we're updating the value to what will be displayed
                .FormatConditions("DataActivityFormatCondition").Value1 = "Data Log"

            End With
            .MoveFirst()

            .CollapseGroups()
        End With
    End Sub

    Private Sub grexLogListing_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grexLogListing.RowDoubleClick
        frmAnalysisRequestListing.OpenEditingForm(TryCast(bsLogs.Current, AnalysisRequestLog).AnalysisId)
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexLogListing
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
            .Title = "Export Request Log Listing"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis Request Log Listing (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class