Public Class frmSchoolgroupAssignmentsEditor
    Dim mDataContext As New SchoolgroupAssignmentsDataContext()

    Private Sub frmSchoolgroupAssignmentsEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupAssignment.DataSource = mDataContext.SchoolgroupAssignments

        'AnalysisPeople DropDown
        bsAssignmentPeople.DataSource = mDataContext.AnalysisPeoples
        Me.gridExSchoolgroupAssignments.DropDowns("ddAssignmentPeople").SetDataBinding(bsAssignmentPeople, String.Empty)

        'AssignmentTypes DropDown
        bsAssignmentTypes.DataSource = mDataContext.SchoolgroupAssignmentTypes
        Me.gridExSchoolgroupAssignments.DropDowns("ddAssignmentType").SetDataBinding(bsAssignmentTypes, String.Empty)

        'Schoolgroups DropDown
        bsSchoolgroups.DataSource = mDataContext.SchoolgroupAssignmentSchoolgroups
        Me.gridExSchoolgroupAssignments.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)


    End Sub

    Private Sub gridExSchoolgroupAssignments_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles gridExSchoolgroupAssignments.DeletingRecord
        Dim _DialogueResult = MessageBox.Show("You are about to delete an assignment.  This can not be undone." & vbCrLf & vbCrLf & "Are you sure?", "CONFIRM DELETE", MessageBoxButtons.YesNo)

        If _DialogueResult = Windows.Forms.DialogResult.No Then e.Cancel = True

    End Sub

    Private Sub gridExSchoolgroupAssignments_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignments.RecordAdded
        SaveData()
        gridExSchoolgroupAssignments.MoveToNewRecord()
    End Sub

    Private Sub gridExSchoolgroupAssignments_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignments.RecordsDeleted
        SaveData()
    End Sub

    Private Sub gridExSchoolgroupAssignments_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignments.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsSchoolgroupAssignment.EndEdit()
            mDataContext.SubmitChanges()
            bsSchoolgroupAssignment.Sort = "Schoolgroup_cd"
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmSchoolgroupAssignmentEditor SaveData")
        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExSchoolgroupAssignments
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
            .Title = "Export Schoolgroup Assignments"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Schoolgroup Assignments (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class