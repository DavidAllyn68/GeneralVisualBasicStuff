Public Class frmApplicationIntro
    Dim WithEvents mTimer As New Timer()

    Private mMessageDelay As Integer = 1000
    Public Property MessageDelay() As Integer
        Get
            Return mMessageDelay
        End Get
        Set(ByVal value As Integer)
            If value > 0 Then
                mMessageDelay = value
            Else
                mMessageDelay = 0
            End If

        End Set
    End Property

    Public Property Message() As String
        Get
            Return textBoxCustomMessage.Text
        End Get
        Set(ByVal value As String)
            If value <> textBoxCustomMessage.Text Then
                textBoxCustomMessage.Text = value
                PerformLayout()
                Application.DoEvents()
                Threading.Thread.Sleep(MessageDelay)
            End If
        End Set
    End Property
    Public Sub DisplayMessage(ByVal _Message As String)
        DisplayMessage(_Message, MessageDelay, False)
    End Sub
    Public Sub DisplayMessage(ByVal _Message As String, ByVal _DelayMilliseconds As Integer)

        DisplayMessage(_Message, _DelayMilliseconds, False)
    End Sub
    Public Sub DisplayMessage(ByVal _Message As String, ByVal _DisplayWarning As Boolean)
        DisplayMessage(_Message, MessageDelay, _DisplayWarning)
    End Sub
    Public Sub DisplayMessage(ByVal _Message As String, ByVal _DelayMilliseconds As Integer, ByVal _DisplayWarning As Boolean)
        Application.DoEvents()

        If _DisplayWarning Then
            textBoxCustomMessage.ForeColor = Color.Red
        Else
            textBoxCustomMessage.ForeColor = Color.Black
        End If

        MessageDelay = _DelayMilliseconds
        Message = _Message
    End Sub

    Private Sub frmApplicationIntro_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        textBoxVersion.Text = System.String.Format("Version: {0}.{1}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub

End Class