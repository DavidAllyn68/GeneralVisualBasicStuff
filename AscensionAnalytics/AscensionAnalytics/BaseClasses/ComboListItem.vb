Imports System.Xml.Serialization

<Serializable()> _
Public Class ComboListItem
    Inherits BusinessBase

    Private mCode As String
    Private mDescription As String

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(ByVal _Code As String, ByVal _Description As String)
        mCode = Trim(_Code)
        mDescription = Trim(_Description)
    End Sub

    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            mCode = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            mDescription = value
        End Set
    End Property

End Class
