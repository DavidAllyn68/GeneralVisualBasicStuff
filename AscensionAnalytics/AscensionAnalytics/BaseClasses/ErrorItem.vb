Imports System.ComponentModel

<Serializable()> _
Public Class ErrorItem
    Implements INotifyPropertyChanged

    Private mCode As String
    ''' <summary>
    ''' Gets or Sets a custom error code
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property Code() As String
        Get
            Return mCode
        End Get
        Set(ByVal value As String)
            If mCode <> value Then
                mCode = value
            End If
        End Set
    End Property


    Private mContext As String

    ''' <summary>
    ''' Gets or Sets the error context - an extra description for the specific item there is an error with.
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property Context() As String
        Get
            Return mContext
        End Get
        Set(ByVal value As String)
            If mContext <> value Then
                mContext = value
            End If
        End Set
    End Property


    Private mPropertyName As String

    ''' <summary>
    ''' Gets or Sets the property name that has an error
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property PropertyName() As String
        Get
            Return mPropertyName
        End Get
        Set(ByVal value As String)
            If mPropertyName <> value Then
                mPropertyName = value
            End If
        End Set
    End Property

    Private mDescription As String

    ''' <summary>
    ''' Gets or Sets the error description
    ''' </summary>
    ''' <value>String</value>
    ''' <returns>String</returns>
    ''' <remarks></remarks>
    Public Property Description() As String
        Get
            Return mDescription
        End Get
        Set(ByVal value As String)
            If mDescription <> value Then
                mDescription = value
            End If
        End Set
    End Property

    Public ReadOnly Property FullDisplay() As String
        Get
            Dim _code As String = String.Empty
            If Code <> String.Empty Then
                _code = "(" & Code & ") "
            End If

            Dim _context As String = String.Empty
            If Context <> String.Empty Then
                _context = Context & ": "
            End If

            Dim _propertyName As String = String.Empty
            If PropertyName <> String.Empty Then
                _propertyName = PropertyName & ": "
            End If

            Return _code & _context & _propertyName & Description
        End Get
    End Property

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Creates a new error item for a given Code, Context, PropertyName, and Description.
    ''' </summary>
    ''' <param name="_code">String</param>
    ''' <param name="_context">String</param>
    ''' <param name="_propertyName">String</param>
    ''' <param name="_description">String</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal _code As String, ByVal _context As String, ByVal _propertyName As String, ByVal _description As String)
        Me.Code = _code
        Me.Context = _context
        Me.PropertyName = _propertyName
        Me.Description = _description
    End Sub

    ''' <summary>
    ''' Creates a new error item for a given Context, PropertyName, and Description.
    ''' </summary>
    ''' <param name="_context">String</param>
    ''' <param name="_propertyName">String</param>
    ''' <param name="_description">String</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal _context As String, ByVal _propertyName As String, ByVal _description As String)
        Me.New(String.Empty, _context, _propertyName, _description)
    End Sub

    ''' <summary>
    ''' Creates a new error item for a given Context and Description.
    ''' </summary>
    ''' <param name="_context">String</param>
    ''' <param name="_description">String</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal _context As String, ByVal _description As String)
        Me.New(_context, String.Empty, _description)
    End Sub

    ''' <summary>
    ''' Creates a new error item for a given Description.
    ''' </summary>
    ''' <param name="_description">String</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal _description As String)
        Me.New(String.Empty, String.Empty, _description)
    End Sub
End Class
