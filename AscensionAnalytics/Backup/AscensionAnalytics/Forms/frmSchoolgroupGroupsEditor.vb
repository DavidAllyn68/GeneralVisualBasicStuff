Public Class frmSchoolgroupGroupsEditor
    Dim mDataContext As New SchoolgroupGroupsDataContext()

    Public Sub SaveData()
        Try
            bsAssociatedSchoolgroups.EndEdit()
            bsSchoolgroupGroups.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub

    Private Sub frmSchoolgroupGroupsEditor_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupGroups.DataSource = mDataContext.schoolgroup_groups

        bsSchoolgroups.DataSource = mDataContext.schoolgroup_group_schoolgroups
        grexSchoolgroups.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)

        With gridExSchoolgroupGroups.RootTable.Columns("is_active")
            .HasValueList = True
            Dim _vl As Janus.Windows.GridEX.GridEXValueListItemCollection = .ValueList
            _vl.Add(1, "Active")
            _vl.Add(0, "Not Active")

            .CompareTarget = Janus.Windows.GridEX.ColumnCompareTarget.Text
            .DefaultGroupInterval = Janus.Windows.GridEX.GroupInterval.Text
            .EditType = Janus.Windows.GridEX.EditType.Combo
            .FilterEditType = Janus.Windows.GridEX.FilterEditType.Combo
        End With
    End Sub

    Public Sub ExportGridExToExcel()
        MessageBox.Show("Exporting to Excel is not supported here.", "Exporting Not Supported", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'NOTE: THERE IS NO GRID THAT SHOWS BOTH ASSOCIATIONS AND SCHOOLGROUP INFORMATION

    End Sub

    Private Sub grexSchoolgroups_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordAdded
        SaveData()
    End Sub

    Private Sub grexSchoolgroups_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexSchoolgroups_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordUpdated
        SaveData()
    End Sub


    Private Sub gridExSchoolgroupGroups_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupGroups.RecordAdded
        SaveData()
    End Sub

    Private Sub gridExSchoolgroupGroups_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupGroups.RecordsDeleted
        'not allowed
    End Sub

    Private Sub gridExSchoolgroupGroups_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles gridExSchoolgroupGroups.RecordUpdated
        SaveData()
    End Sub
End Class