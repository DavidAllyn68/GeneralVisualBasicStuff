Public Class ThingEditor
    Private mDB As New ThingsDataContext
    Private WithEvents ParentChooser As New AddAssociation()
    Private WithEvents ChildChooser As New AddAssociation()

    Private Sub ThingEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        ThingBindingSource.DataSource = mDB.Things
        AddHandler ParentChooser.AddButton.Click, AddressOf AssociateParentThing
        AddHandler ChildChooser.AddButton.Click, AddressOf AssociateChildThing
    End Sub

    Private Sub ThingBindingSource_PositionChanged(sender As Object, e As EventArgs) Handles ThingBindingSource.PositionChanged

        SaveData()

        ParentBindingSource.DataSource = From parent As Thing In mDB.Things, assoc As ThingAssociation In mDB.ThingAssociations Where assoc.ChildThingId = TryCast(ThingBindingSource.Current, Thing).ThingId And assoc.ParentThingId = parent.ThingId Select parent
        ChildrenBindingSource.DataSource = From child As Thing In mDB.Things, assoc As ThingAssociation In mDB.ThingAssociations Where assoc.ParentThingId = TryCast(ThingBindingSource.Current, Thing).ThingId And assoc.ChildThingId = child.ThingId Select child
    End Sub

    Private Sub ChildThingsListBox_DoubleClick(sender As Object, e As EventArgs) Handles ChildThingsListBox.DoubleClick

        Dim _thing As Thing = TryCast(ChildThingsListBox.SelectedItem, Thing)

        If Not _thing Is Nothing Then
            ThingBindingSource.Position = ThingBindingSource.IndexOf(_thing)
        End If

    End Sub

    Public Sub SaveData()
        Try
            ThingBindingSource.EndEdit()
            mDB.SubmitChanges()
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    Private Sub AddChildAssociation_Click(sender As Object, e As EventArgs) Handles AddChildAssociation.Click

    End Sub

    Private Sub AssociateChildThing()

    End Sub

    Private Sub AssociateParentThing()

    End Sub

End Class
