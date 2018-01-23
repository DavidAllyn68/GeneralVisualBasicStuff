Imports System
Public Class sqlStringPrep
    Private pvt_oldString As String
    Private pvt_newString As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal aString As String)
        Me.OldString = aString
    End Sub

    Public Property OldString()
        Get
            Return pvt_oldString
        End Get
        Set(ByVal value)
            pvt_oldString = value
            pvt_newString = ""
        End Set
    End Property
    Public ReadOnly Property NewString()
        Get
            Return pvt_newString
        End Get
    End Property
    Public Function prepSingleQuotes() As String
        Return prepSingleQuotes(pvt_oldString)
    End Function

    Public Function prepSingleQuotes(ByVal aString As String) As String
        Me.OldString = aString
        pvt_newString = aString.Replace("'", "''")
        Return pvt_newString
    End Function
End Class

