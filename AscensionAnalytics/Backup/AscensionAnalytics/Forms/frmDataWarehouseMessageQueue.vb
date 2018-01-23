Public Class frmDataWarehouseMessageQueue
    Dim mDataContext As New DataWarehouseMessageQueueDataContext()
    Private mGridFilterCondition As New Janus.Windows.GridEX.GridEXFilterCondition()

    Private Sub frmDataWarehouseMessageQueue_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsMessageQueue.DataSource = mDataContext.MessageQueues

    End Sub

    Private Sub grexDataWarehouseMessageQueue_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseMessageQueue.SelectionChanged


        Try
            Dim _row As MessageQueue = grexDataWarehouseMessageQueue.GetRow.DataRow

            If _row.MessageSentDate.HasValue Then
                grexDataWarehouseMessageQueue.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False
            Else
                grexDataWarehouseMessageQueue.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.True
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub grexDataWarehouseMessageQueue_DeletingRecord(ByVal sender As Object, ByVal e As Janus.Windows.GridEX.RowActionCancelEventArgs) Handles grexDataWarehouseMessageQueue.DeletingRecord
        Dim _row As MessageQueue = grexDataWarehouseMessageQueue.GetRow.DataRow

        If _row.MessageSentDate.HasValue Then
            MessageBox.Show("This message has been processed and sent.  You can not delete it.", "DELETE NOT ALLOWED")
            e.Cancel = True
        End If
    End Sub

    Private Sub grexDataWarehouseMessageQueue_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseMessageQueue.RecordAdded
        SaveData()
    End Sub

    Private Sub grexDataWarehouseMessageQueue_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseMessageQueue.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexDataWarehouseMessageQueue_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexDataWarehouseMessageQueue.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            bsMessageQueue.EndEdit()
            mDataContext.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "frmDataWarehouseMessageQueue Error")
        End Try
    End Sub

    Public Overrides Sub Refresh()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf Refresh))
        Else
            MyBase.Refresh()
            'AFTER MUCH ADO....
            'I tried several methods, and this is the only one that
            'refreshes the grid with what is in the database while keeping the filtering
            'that the user specified.  Basically we completely "replumb" the data sources

            '1) save filter condition to persist across the refresh 
            mGridFilterCondition = grexDataWarehouseMessageQueue.RootTable.FilterCondition

            '2) refresh the data by creating a fresh data context
            mDataContext = New DataWarehouseMessageQueueDataContext()

            '3) reset the binding source's datasource
            bsMessageQueue.DataSource = mDataContext.MessageQueues

            '4) reset the gridEx  datasource
            grexDataWarehouseMessageQueue.DataSource = bsMessageQueue

            '5) reapply the stored filter
            grexDataWarehouseMessageQueue.RootTable.FilterCondition = mGridFilterCondition

            '6) refetch the rows using that filter
            grexDataWarehouseMessageQueue.Refetch()
        End If



    End Sub
    Public Sub ExportGridExToExcel(ByVal _filePath As String)

        Dim _ioStream As New IO.FileStream(_filePath, IO.FileMode.Create)
        Dim _gridExExporter As New Janus.Windows.GridEX.Export.GridEXExporter()
        _gridExExporter.GridEX = grexDataWarehouseMessageQueue
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
            .Title = "Export DW Message Queue"
            .AddExtension = True
            .DefaultExt = ".xls"
            .FileName = "Data Warehouse Message Queue (as of " & Now().ToString("yyyy-MM-dd") & ").xls"
            '.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            .InitialDirectory = My.Settings.AnalysisRequestsDirectory
            .OverwritePrompt = True
            .ShowDialog()
            _fileName = .FileName
        End With

        ExportGridExToExcel(_fileName)
    End Sub

End Class