Imports System.Threading

Public Class frmSampleReportingProcessing
    Private mDataContext As New SampleReportingDataContext()
    Private mLookupContext As New LookupTablesDataContext()

    Private Sub frmSampleReportingProcessing_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupsToProcess.DataSource = mDataContext.SampleReporting_SchoolgroupsToProcesses
        bsLookupSchoolgroups.DataSource = mLookupContext.LookupSchoolgroups
        bsLookupPolicyYears.DataSource = mLookupContext.PolicyYears

        grexSchoolgroupsToProcess.DropDowns("ddSchoolgroups").SetDataBinding(bsLookupSchoolgroups, String.Empty)
        grexSchoolgroupsToProcess.DropDowns("ddMinPolicyYears").SetDataBinding(bsLookupPolicyYears, String.Empty)
        grexSchoolgroupsToProcess.DropDowns("ddMaxPolicyYears").SetDataBinding(bsLookupPolicyYears, String.Empty)

        mDataContext.CommandTimeout = 3600 'one hour
    End Sub

    Private Sub cmdProcessSampleData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcessSampleData.Click

        Dim _dialogueResult As DialogResult = MessageBox.Show("Sample data will process according to your specifications.  Depending on the size of the schoolgroups and utilization within that timeframe, this processing could take several minutes." & vbCrLf & vbCrLf & "Would you like to proceed?", "CONFIRM SAMPLE DATA PROCESSING", MessageBoxButtons.YesNo)

        If _dialogueResult = Windows.Forms.DialogResult.Yes Then
            ProcessSampleData()
        End If


    End Sub

    Private Sub ProcessSampleData()
        EnableUserInterface(False)
        Try
            mDataContext.SampleReporting_LoadSampleReporting()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " ProcessSampleData Error")

        End Try
        EnableUserInterface(True)
        MessageBox.Show("Sample Reporting Data has been processed successfully.", "SAMPLE REPORTING DATA PROCESSED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub

    Private Sub EnableUserInterface(ByVal _UIenabled As Boolean)
        If _UIenabled Then
            Me.Enabled = True
            Cursor = Cursors.Default
            Me.Text = "Sample Reporting Data Processing"
        Else
            Me.Enabled = False
            Cursor = Cursors.WaitCursor
            Me.Text = "Busy Processing Sample Data ..."
        End If

        Application.DoEvents()
    End Sub

    Private Sub grexSchoolgroupsToProcess_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexSchoolgroupsToProcess.DeletingRecord
        Dim mDialogueResult As DialogResult = MessageBox.Show("You are about to delete a network fee from claims data.  THIS DELETION WILL BE PERMANENT AND CAN'T BE UNDONE." & vbCrLf & vbCrLf & "Are you sure you want to delete this row?", "CONFIRM DELETION OF NETWORK FEE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If mDialogueResult <> Windows.Forms.DialogResult.Yes Then e.Cancel = True
    End Sub

    Private Sub grexSchoolgroupsToProcess_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupsToProcess.RecordAdded
        SaveData()
    End Sub

    Private Sub grexSchoolgroupsToProcess_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupsToProcess.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexSchoolgroupsToProcess_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroupsToProcess.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsSchoolgroupsToProcess.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData() Error")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexSchoolgroupsToProcess
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
            .Title = "Export Sample Schoolgroups"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Sample Schoolgroups (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class