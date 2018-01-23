Partial Class ProcedureScheduleDataContext


End Class

Partial Class ProcedureSchedule
    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property ExecutionResult() As String
        Get

            If ExecutionNotes = Nothing Then
                Return "Yet to Execute"
            ElseIf ExecutionNotes = "Execution Successfull" Then
                Return "Completed Successfully"
            Else
                Return "Executed with Errors"
            End If

        End Get
    End Property
End Class

