Partial Class MooDataDataContext
    Public Sub LoadData()

        Try
            'prompt the user to pick the file
            Dim _openFileDialogue As New OpenFileDialog()
            _openFileDialogue.InitialDirectory = "O:\RenAnalysis\aaa.DataProviders\MOO Data"
            _openFileDialogue.Multiselect = False
            _openFileDialogue.ShowDialog()
            Dim _fileName As String = _openFileDialogue.FileName


            Dim _connectionString As String = My.Settings.DavidConnectionString
            Dim _Delimiter As String = vbTab
            Dim _TableName As String = "MOO_ImportFile_Staging"


            If IO.File.Exists(_fileName) Then
                Dim fileLoader As New FileToSqlLoader(_fileName, _Delimiter, True, _connectionString, _TableName)
                fileLoader.TruncateDestinationTable()


                If fileLoader.RowCountInDestinationTable = 0 Then
                    fileLoader.ProcessFile()

                End If
            Else
                MessageBox.Show("File doesn't exist")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally

        End Try
    End Sub

    Public Sub ProcessData()
        Dim _r As DialogResult = MessageBox.Show("You are about to reprocess Mutual of Omaha data in the data warehouse, which could take up to 90 minutes to complete." & vbCrLf & vbCrLf _
                                         & "During the processing you can continue to work, however, you will not be allowed to close the Ascension Analytics application until it completes." & vbCrLf & vbCrLf _
                                         & "Would you like to continue?", "Process MOO Data: PLEASE CONFIRM", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2)

        If _r = DialogResult.Yes Then
            Try
                Dim _originalCommandTimeout As Integer = Me.CommandTimeout

                Me.CommandTimeout = 0

                Me.MOOFileImport_ProcessDataTranslators()
                Me.MOOFileImport_LoadDenormForNightlyCompile()
                Me.MOOFileImport_FinishAndCleanUp()

                Me.CommandTimeout = _originalCommandTimeout
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class
