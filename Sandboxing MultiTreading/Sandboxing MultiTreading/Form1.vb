Public Class Form1

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        AddMessageButton("10 Seconds")
    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked
        Select Case TryCast(e.ClickedItem, ModifiedToolStripButton).Key
            Case "Save"

            Case Else
                AddMessageButton("10 Seconds")
        End Select
    End Sub

    Private Sub AddMessageButton(ButtonText As String)
        If StatusStrip1.InvokeRequired Then
            StatusStrip1.Invoke(New Action(Of String)(AddressOf AddMessageButton), ButtonText)
        Else

            Dim _button As New ModifiedToolStripButton(Now.Ticks, 10)
            _button.Text = ButtonText
            StatusStrip1.Items.Add(_button)

        End If
    End Sub

    Private Sub StatusStrip1_ItemRemoved(sender As Object, e As ToolStripItemEventArgs) Handles StatusStrip1.ItemRemoved
        If StatusStrip1.Items.Count = 0 Then Me.Close()
    End Sub
End Class
