Public Class AddAssociation
    Private mDB As New ThingsDataContext

    Private Sub AddAssociation_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Top = MousePosition.Y
        Me.Left = MousePosition.X

        ThingBindingSource.DataSource = From thing As Thing In mDB.Things Where thing.ThingId <> TryCast(ThingEditor.ThingBindingSource.Current, Thing).ThingId Select thing

    End Sub


End Class