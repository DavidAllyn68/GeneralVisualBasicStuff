'Created by Arsenio Jakovcich
Public Class ObjectHelper

    Implements System.ComponentModel.IDataErrorInfo

    Private validationErrors As New Dictionary(Of String, String)


    Protected Sub AddError(ByVal columnName As String, ByVal msg As String)
        If Not validationErrors.ContainsKey(columnName) Then
            validationErrors.Add(columnName, msg)
        End If
    End Sub

    Protected Sub RemoveError(ByVal columnName As String)
        If validationErrors.ContainsKey(columnName) Then
            validationErrors.Remove(columnName)
        End If
    End Sub

    Protected Sub ClearAllErrors()
        Me.validationErrors.Clear()
    End Sub

    Public Overridable ReadOnly Property HasErrors() As Boolean
        Get
            Return (validationErrors.Count > 0)
        End Get
    End Property

    Public ReadOnly Property [Error]() As String _
        Implements System.ComponentModel.IDataErrorInfo.Error
        Get
            If validationErrors.Count > 0 Then
                Return String.Format("{0} data is invalid.", TypeName(Me))
            Else
                Return Nothing
            End If
        End Get
    End Property

    Default Public ReadOnly Property Item(ByVal columnName As String) As String _
        Implements System.ComponentModel.IDataErrorInfo.Item
        Get
            If validationErrors.ContainsKey(columnName) Then
                Return validationErrors(columnName).ToString
            Else
                Return Nothing
            End If
        End Get
    End Property
    Public Shadows ReadOnly Property AllValidationErrors() As String
        Get
            Dim sb As New System.Text.StringBuilder
            For Each valStr As String In validationErrors.Values
                sb.AppendLine("- " & valStr)
            Next
            Return sb.ToString
        End Get
    End Property

End Class


'Arsenio Jakovcich
'Vice President, Information Services
'Renaissance Insurance Agency, Inc., now doing business as
'Ascension Benefits and Insurance Solutions ― Student Health
'1437 7th Street, Fourth Floor
'Santa Monica, CA  90401 
'phone: 800.537.1777 | fax: 310.394.0142
'arsenio@renstudent.com


