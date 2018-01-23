Public Class ModifiedToolStripButton
    Inherits ToolStripButton
    Public WithEvents mTimer As New Timer
    Dim mDisplaySeconds As Integer = -1
    Public Property DisplaySeconds As Integer
        Get
            Return mDisplaySeconds
        End Get
        Set(value As Integer)
            mDisplaySeconds = value
        End Set
    End Property

    Dim mKey As String = String.Empty
    Public Property Key As String
        Get
            Return mKey

        End Get
        Private Set(value As String)
            mKey = value
        End Set
    End Property

    Public Sub New(Key As String)
        MyBase.New()
        Me.Key = Key
    End Sub

    Public Sub New(Key As String, DisplaySeconds As Integer)
        MyBase.New()
        Me.Key = Key
        Me.DisplaySeconds = DisplaySeconds
        mTimer.Interval = 1000
        mTimer.Start()
    End Sub


    Private Sub mTimer_Tick(sender As Object, e As EventArgs) Handles mTimer.Tick
        Select DisplaySeconds
            Case Is > 0
                DisplaySeconds -= 1
                Me.Text = DisplaySeconds
            Case 0
                Me.Dispose()
            Case Is < 0
                'do nothing
        End Select

    End Sub
End Class
