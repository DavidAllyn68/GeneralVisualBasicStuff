Public Class frmProviderGrouping
    Dim mDataContext As New ProviderGroupingDataContext()


    Private Sub frmProviderGrouping_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsGroups.DataSource = mDataContext.ProviderGroups
        bsTypes.DataSource = mDataContext.ProviderGroupTypes

        grexProviderGroups.DropDowns("ddTypes").SetDataBinding(bsTypes, String.Empty)
    End Sub

    Private Sub grexProviderGroups_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroups.RecordAdded
        SaveData()
    End Sub

    Private Sub grexProviderGroups_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroups.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexProviderGroups_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroups.RecordUpdated
        SaveData()
    End Sub

    Private Sub grexProviderGroupProviders_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroupProviders.RecordAdded
        SaveData()
    End Sub

    Private Sub grexProviderGroupProviders_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroupProviders.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexProviderGroupProviders_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexProviderGroupProviders.RecordUpdated
        SaveData()
    End Sub

    Public Sub SaveData()
        Try
            Dim _needsProcessing As Boolean = False

            If mDataContext.GetChangeSet().Deletes.Count _
               + mDataContext.GetChangeSet().Inserts.Count _
               + mDataContext.GetChangeSet().Updates.Count > 0 Then _needsProcessing = True

            bsGroups.EndEdit()
            mDataContext.SubmitChanges()

            If _needsProcessing Then mdiMain.StatusRibbon_AddPanel("ProcessProviderGroups", "Process Provider Groups Now?", Janus.Windows.Ribbon.PanelBehavior.Button)

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Public Sub ExportGridExToExcel()
        MessageBox.Show("Exporting to Excel is not supported here.", "Exporting Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'NOTE: THERE IS NO GRID THAT SHOWS BOTH ASSOCIATIONS AND SCHOOLGROUP INFORMATION
    End Sub

End Class