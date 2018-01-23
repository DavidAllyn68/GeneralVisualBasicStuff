Imports Janus.Windows.GridEX

Public Class frmAnalysisRequestListing
    Public AnalysisRequestListingDataContext As New AnalysisRequestTrackerDataContext()
    Private mFormIsLoaded As Boolean = False

    Public Sub SaveData()
        Try
            bsAnalysisRequestListing.EndEdit()
            AnalysisRequestListingDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmAnalysisRequestListing SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAnalysisRequestListing
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
            .Title = "Export Analysis Requests"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Analysis Requests (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
    Public Overrides Sub Refresh()
        MyBase.Refresh()
        SaveData()
    End Sub

    Public Sub SetBindings()


    End Sub

    Private Sub frmAnalysisRequestListing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim _AnalysisPersonId = My.Application.CurrentAnalysisPerson.PersonId

        '####################################################################
        'ROLE BASED SECURITY HAS BEEN TEMPORARILY REMOVED
        '   (ALSO VISIT THE ApplicationEvents MODULE)
        '
        '   I.T. was not able to make these security groups visible
        '   to .NET applications.  For some reason some users' assignment
        '   to a security group would be visible, while others' would not be
        '
        '   Unfortunately, due to my limited ability to research and fix
        '   this issue, I need to remove it.
        '####################################################################

        'managing analysts in the WLA Analytics Admin Active Directory Security Group
        'have access to all requests, otherwise only show requests the user owns
        'or is assigned to.
        'If My.Application.UserAssignedRoles.Contains("Admin") Then
        '    bsAnalysisRequestListing.DataSource = AnalysisRequestListingDataContext.AnalysisRequests
        '    Me.Text = Me.Text & " (Showing All Requests)"
        'Else
        '    bsAnalysisRequestListing.DataSource = From _AnalysisRequest In AnalysisRequestListingDataContext.AnalysisRequests _
        '                                          Where _AnalysisRequest.RequestorId = _AnalysisPersonId Or _AnalysisRequest.AssigneeId = _AnalysisPersonId
        'End If

        'Showing all requests for all users
        bsAnalysisRequestListing.DataSource = AnalysisRequestListingDataContext.AnalysisRequests

        bsRequestors.DataSource = AnalysisRequestListingDataContext.AnalysisRequestPeoples
        grexAnalysisRequestListing.DropDowns("ddPeople").SetDataBinding(bsRequestors, String.Empty)

        bsAssignees.DataSource = AnalysisRequestListingDataContext.AnalysisRequestPeoples
        grexAnalysisRequestListing.DropDowns("ddAssignee").SetDataBinding(bsAssignees, String.Empty)

        bsStatuses.DataSource = AnalysisRequestListingDataContext.AnalysisRequestStatus
        grexAnalysisRequestListing.DropDowns("ddStatuses").SetDataBinding(bsStatuses, String.Empty)

        bsTypes.DataSource = AnalysisRequestListingDataContext.AnalysisRequestTypes
        grexAnalysisRequestListing.DropDowns("ddTypes").SetDataBinding(bsTypes, String.Empty)


        With grexAnalysisRequestListing.RootTable.Columns("IsActive")
            .HasValueList = True
            Dim _vl As Janus.Windows.GridEX.GridEXValueListItemCollection = .ValueList
            _vl.Add(1, "Active")
            _vl.Add(0, "Expired")

            .CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            .DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
            .EditType = Janus.Windows.GridEX.EditType.Combo
            .FilterEditType = Janus.Windows.GridEX.FilterEditType.Combo
        End With

        mFormIsLoaded = True

    End Sub

    Private Sub frmAnalysisRequestListing_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        For Each _f As Form In mdiMain.MdiChildren
            If TypeOf (_f) Is frmAnalysisRequestDetail Then
                _f.Close()
            End If
        Next

        SaveData()

    End Sub


    Private Sub grexAnalysisRequestListing_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAnalysisRequestListing.RecordAdded
        'submit the new row so we get a new AnalysisId
        SaveData()

        'Find the largest AnalysisId and open the editing form for it.
        Dim _AnalysisId As Integer = (From q As AnalysisRequest In bsAnalysisRequestListing Select q.AnalysisId).Max
        OpenEditingForm(_AnalysisId)

    End Sub

    Private Sub grexAnalysisRequestListing_RowDoubleClick(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles grexAnalysisRequestListing.RowDoubleClick
        OpenEditingForm(TryCast(bsAnalysisRequestListing.Current, AnalysisRequest).AnalysisId)
    End Sub

    Public Sub OpenEditingForm(ByVal _analysisId As Integer)
        Cursor = Cursors.WaitCursor
        Cursor.Show()
        Try

            Dim frm As frmAnalysisRequestDetail = GetEditingForm(_analysisId)
            frm.Show()
            frm.Focus()

        Catch ex As Exception
            MessageBox.Show("Error in 'OpenForm' " & ex.Message, "Open form", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Cursor = Cursors.Default
        End Try
    End Sub
    Private Function GetEditingForm(ByVal _AnalysisId As Integer) As frmAnalysisRequestDetail

        'if there is an editing form already open for this AnalysisId then return it.  
        'Otherwise create a new editing form for the AnalysisId

        Dim _EditingForm As frmAnalysisRequestDetail = Nothing

        For Each _f As Form In Me.MdiParent.MdiChildren
            If TypeOf (_f) Is frmAnalysisRequestDetail Then
                Dim _i As frmAnalysisRequestDetail = _f
                If _i.MyAnalysisId = _AnalysisId Then
                    _EditingForm = _i
                End If
            End If
        Next

        If IsNothing(_EditingForm) Then
            _EditingForm = New frmAnalysisRequestDetail
            _EditingForm.MyAnalysisId = _AnalysisId
            _EditingForm.MdiParent = mdiMain

        End If

        Return _EditingForm
    End Function
End Class