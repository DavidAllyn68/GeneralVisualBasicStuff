Public Class frmAmeribenNetworkFees
    Private mDataContext As New AmeribenNetworkFeesDataContext()
    Private mLookupsContext As New LookupTablesDataContext()

    Private Sub frmAmeribenNetworkFees_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsNetworkFees.DataSource = mDataContext.Ameriben_NetworkFees
        bsSchoolgroups.DataSource = mLookupsContext.LookupSchoolgroups
        bsPolicyYears.DataSource = mLookupsContext.PolicyYears

        grexAmeribenNetworkFees.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)
        grexAmeribenNetworkFees.DropDowns("ddPolicyYears").SetDataBinding(bsPolicyYears, String.Empty)

    End Sub

    Public Sub SaveData()
        Try
            Dim _changesExist As Boolean = False

            If mDataContext.GetChangeSet.Updates.Count > 0 OrElse mDataContext.GetChangeSet.Inserts.Count > 0 Then
                _changesExist = True
            End If

            bsNetworkFees.EndEdit()
            mDataContext.SubmitChanges()

            If _changesExist Then
                Try
                    mdiMain.StatusRibbon_AddPanel("ProcessAmeribenData", "Process Ameriben Data?", Janus.Windows.Ribbon.PanelBehavior.Button)
                Catch ex As Exception
                    'if the button is already there, it will cause an error that we just bypass
                End Try
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexAmeribenNetworkFees
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
            .Title = "Export Ameriben Network Fees"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Ameriben Network Fees (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub
    Private Sub grexAmeribenNetworkFees_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexAmeribenNetworkFees.DeletingRecord
        Dim mDialogueResult As DialogResult = MessageBox.Show("You are about to delete a network fee from claims data.  THIS DELETION WILL BE PERMANENT AND CAN'T BE UNDONE." & vbCrLf & vbCrLf & "Are you sure you want to delete this row?", "CONFIRM DELETION OF NETWORK FEE", MessageBoxButtons.YesNo, MessageBoxIcon.Stop)

        If mDialogueResult <> Windows.Forms.DialogResult.Yes Then e.Cancel = True
    End Sub

    Private Sub grexAmeribenNetworkFees_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenNetworkFees.RecordAdded
        SaveData()
    End Sub

    Private Sub grexAmeribenNetworkFees_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenNetworkFees.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexAmeribenNetworkFees_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexAmeribenNetworkFees.RecordUpdated
        SaveData()
    End Sub
End Class