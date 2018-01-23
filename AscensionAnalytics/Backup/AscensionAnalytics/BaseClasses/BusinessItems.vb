Imports System.ComponentModel

<Serializable()> _
Public Class BusinessItems(Of T)
    Inherits BindingList(Of T)

    Private mErrorItems As ErrorItems = ErrorItems.Create()

    ''' <summary>
    ''' Gets the error item collection for the schoolgroupGroupItems
    ''' </summary>
    ''' <returns>ErrorItem</returns>
    ''' <remarks></remarks>
    Public ReadOnly Property ErrorItems() As ErrorItems
        Get
            Return mErrorItems
        End Get
    End Property

#Region "List Sorting"
    ' DRA: This code was found on the internet:
    ' http://coolthingoftheday.blogspot.com/2005/11/fun-with-bindinglistof-t-and-bindable.html
    ' posted by: Greg Duncan, Simi Valley, California

    ' This uses the PropertyComparer class found at the same location by the same author.
    ' I've made some minor changes and added a public sub to make sorting easier.

    Private mSorted As Boolean = False
    Private SortDirection As ListSortDirection
    Private SortProperty As PropertyDescriptor
    ''' <summary>
    ''' Property allows list to be sorted by consuming controls such as the GridView
    ''' </summary>
    ''' <value></value>
    ''' <returns>Boolean</returns>
    ''' <remarks>Read Only</remarks>
    Protected Overrides ReadOnly Property SupportsSortingCore() As Boolean
        Get
            Return True
        End Get
    End Property

    Protected Overrides ReadOnly Property IsSortedCore() As Boolean
        Get
            Return mSorted
        End Get
    End Property

    Protected Overrides Sub RemoveSortCore()
        mSorted = False
    End Sub

    Protected Overrides ReadOnly Property SortDirectionCore() As ListSortDirection
        Get
            Return SortDirection
        End Get
    End Property

    Protected Overrides ReadOnly Property SortPropertyCore() As PropertyDescriptor
        Get
            Return SortProperty
        End Get
    End Property

    Protected Overrides Sub ApplySortCore(ByVal prop As PropertyDescriptor, ByVal direction As ListSortDirection)

        ' Get list to sort
        Dim items As List(Of T) = TryCast(Me.Items, List(Of T))

        ' Apply and set the sort, if items to sort
        If items IsNot Nothing Then

            SortDirection = direction
            SortProperty = prop

            Dim pc As PropertyComparer(Of T) = _
              New PropertyComparer(Of T)(prop, direction)

            items.Sort(pc)
            mSorted = True

        Else
            mSorted = False

        End If

        Me.OnListChanged(New ListChangedEventArgs(ListChangedType.Reset, -1))
    End Sub
    ''' <summary>
    ''' Sorts the list based on a single field
    ''' </summary>
    ''' <param name="propertyName">The name of the property (often the database field) to be sorted on</param>
    ''' <param name="direction">System.ComponentModel.ListSortDirection enum value</param>
    ''' <remarks></remarks>
    Public Sub Sort(ByVal propertyName As String, ByVal direction As ListSortDirection)
        Dim prop As PropertyDescriptor
        Dim items As List(Of T) = TryCast(Me.Items, List(Of T))
        Dim item As Object = items(0)
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(item)

        ' Sets an PropertyDescriptor to the specific property.
        prop = properties.Find(propertyName, False)

        ApplySortCore(prop, direction)
    End Sub
#End Region

#Region "List Filtering"
    'TODO: Build List Filtering into the BusinessItems class
#End Region

#Region "Select Distinct"
    'TODO: Create support for returning a bindingList of distinct items
#End Region
End Class
