Public Class frmSchoolgroupAssignmentTypeEditor
    Dim mDataContext As New SchoolgroupAssignmentsDataContext()

    Private Sub frmSchoolgroupAssignmentTypeEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupAssignmentTypes.DataSource = mDataContext.SchoolgroupAssignmentTypes

    End Sub

    Private Sub bsSchoolgroupAssignmentTypes_ListChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles bsSchoolgroupAssignmentTypes.ListChanged
        Select Case e.ListChangedType

            Case System.ComponentModel.ListChangedType.ItemChanged
                Try
                    bsSchoolgroupAssignmentTypes.EndEdit()
                    mDataContext.SubmitChanges()
                    bsSchoolgroupAssignmentTypes.DataSource = mDataContext.SchoolgroupAssignmentTypes

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            Case Else
                'nothing

        End Select
    End Sub

    Private Sub gridExSchoolgroupAssignmentTypes_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles gridExSchoolgroupAssignmentTypes.DeletingRecord
        MessageBox.Show("You can not delete Assignment Types.", "Deleting Not Allowed")
        e.Cancel = True
    End Sub

    Private Sub gridExSchoolgroupAssignmentTypes_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignmentTypes.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExSchoolgroupAssignmentTypes_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignmentTypes.RecordsDeleted
        'do nothing
    End Sub

    Private Sub gridExSchoolgroupAssignmentTypes_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupAssignmentTypes.RecordUpdated
        SaveData()
    End Sub


    Public Sub SaveData()
        Try
            bsSchoolgroupAssignmentTypes.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = gridExSchoolgroupAssignmentTypes
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
            .Title = "Export Schoolgroup Assignments Types"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Schoolgroup Assignment Types (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
End Class