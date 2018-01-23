Imports System.ComponentModel

<Serializable()> _
Public Class ErrorItems
    Inherits BindingList(Of ErrorItem)

    Sub New()
        'don't do anything.
        'this class uses the create() method constructor
    End Sub

    ''' <summary>
    ''' Create a new instance of the object.
    ''' </summary>
    ''' <returns>ErrorItems</returns>
    ''' <remarks></remarks>
    Public Shared Function Create() As ErrorItems
        Return New ErrorItems
    End Function

    ''' <summary>
    ''' (Read Only) Determines if there are errors in the collection.
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property HasErrors() As Boolean
        Get
            If Me.Count > 0 Then Return True Else Return False
        End Get
    End Property

    ''' <summary>
    ''' Returns an ErrorItem out of the ErrorItems collection for a given ErrorItem.
    ''' </summary>
    ''' <param name="_errorItem">ErrorItem</param>
    ''' <returns>ErrorItem</returns>
    ''' <remarks></remarks>
    Private Function getErrorItem(ByVal _errorItem) As ErrorItem
        getErrorItem = Nothing

        For Each _i As ErrorItem In Me
            If _i.Equals(_errorItem) Then
                getErrorItem = _i
                Exit Function
            End If
        Next

    End Function
    ''' <summary>
    ''' Returns an ErrorItem out of the ErrorItems collection for a given error code.
    ''' </summary>
    ''' <param name="_code">String</param>
    ''' <returns>ErrorItem</returns>
    ''' <remarks></remarks>
    Private Function getErrorItem(ByVal _code As String) As ErrorItem
        getErrorItem = Nothing

        For Each _i As ErrorItem In Me
            If _i.Code = _code Then
                getErrorItem = _i
                Exit Function
            End If
        Next
    End Function

    ''' <summary>
    ''' Adds an ErrorItem to the ErrorItems collection.
    ''' </summary>
    ''' <param name="_errorItem">ErrorItem</param>
    ''' <remarks></remarks>
    Public Sub AddError(ByVal _errorItem As ErrorItem)
        If getErrorItem(_errorItem.Code) Is Nothing Then
            Me.Add(_errorItem)
        End If
    End Sub

    ''' <summary>
    ''' Adds an ErrorItem to the ErrorItems collection by setting an ErrorItem's properties
    ''' </summary>
    ''' <param name="_code">String</param>
    ''' <param name="_context">String</param>
    ''' <param name="_propertyName">String</param>
    ''' <param name="_description">String</param>
    ''' <remarks></remarks>
    Public Sub AddError(ByVal _code As String, ByVal _context As String, ByVal _propertyName As String, ByVal _description As String)
        Dim _errorItem As New ErrorItem(_code, _context, _propertyName, _description)
        Me.AddError(_errorItem)
    End Sub

    ''' <summary>
    ''' Removes an ErrorItem from the collection.
    ''' </summary>
    ''' <param name="_errorItem">ErrorItem</param>
    ''' <remarks></remarks>
    Public Sub ClearError(ByVal _errorItem As ErrorItem)
        _errorItem = getErrorItem(_errorItem)
        If Not _errorItem Is Nothing Then
            Me.Remove(_errorItem)
        End If
    End Sub

    ''' <summary>
    ''' Removes an ErrorItem from a collection for a given ErrorItem's code.
    ''' </summary>
    ''' <param name="_code">String</param>
    ''' <remarks></remarks>
    Public Sub ClearError(ByVal _code As String)

        ClearError(getErrorItem(_code))

    End Sub

    ''' <summary>
    ''' Returns a listing of all error items in the collection.
    ''' </summary>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Function CompileErrors() As String
        Dim _returnString As String = String.Empty

        For Each _i As ErrorItem In Me
            _returnString = _returnString & _i.FullDisplay & vbCrLf
        Next
        Return _returnString
    End Function
End Class
