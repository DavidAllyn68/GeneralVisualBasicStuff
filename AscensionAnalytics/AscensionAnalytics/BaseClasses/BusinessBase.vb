Imports System.ComponentModel
Imports System.Xml.Serialization
''' <summary>
''' The Business Base is a simple base object
''' </summary>
''' <remarks></remarks>
<Serializable()> _
Public Class BusinessBase
    Implements INotifyPropertyChanged

    ''' <summary>
    ''' Business Base Class event implementing the INotifyPropertyChanged.PropertyChanged event
    ''' </summary>
    ''' <param name="propertyName"></param>
    ''' <remarks></remarks>
    Public Sub Changed(ByVal propertyName As String)
        Dim _ChangedEventArgs As New System.ComponentModel.PropertyChangedEventArgs(propertyName)

        RaiseEvent PropertyChanged(Me, _ChangedEventArgs)

        Me.SaveAction = SaveActions.Update
        Me.IsDirty = True
    End Sub

    Public Event PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged


    Private mIsDirty As Boolean = False

    ''' <summary>
    ''' Gets or Sets if the thing is dirty (changed in the collection by not the database).  True if changed.
    ''' Since the thing is now dirty, SaveSuccessfull property is set to false.
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public Property IsDirty() As Boolean
        Get
            Return mIsDirty
        End Get
        Set(ByVal value As Boolean)
            If mIsDirty <> value Then
                If value = True Then SaveSuccessfull = False
                mIsDirty = value
            End If
        End Set
    End Property

    Private mSaveSuccessfull As Boolean

    ''' <summary>
    ''' Gets or Sets if the save action was successfull
    ''' If the save is successfull, IsDirty is set to false
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public Property SaveSuccessfull() As Boolean
        Get
            Return mSaveSuccessfull
        End Get
        Set(ByVal value As Boolean)
            If mSaveSuccessfull <> value Then
                If value = True Then
                    IsDirty = False
                    SaveAction = SaveActions.NoAction
                End If

                mSaveSuccessfull = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The various save actions available against the database.
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum SaveActions
        NoAction = 0
        Insert = 2
        Update = 3
        Delete = 4
    End Enum

    Private mSaveAction As SaveActions

    ''' <summary>
    ''' Gets or Sets the save action of the thing against the database
    ''' </summary>
    ''' <value>thingSaveAction</value>
    ''' <returns>thingSaveAction</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public Property SaveAction() As SaveActions
        Get
            Return mSaveAction
        End Get
        Set(ByVal value As SaveActions)
            If mSaveAction <> value Then
                mSaveAction = value

                'intentionally commented out "Changed("SaveAction")" 
                'except when deleting -- because this is the only
                'property that changed during that operation.
                If value = SaveActions.Delete Then
                    Changed("SaveAction")
                End If
            End If
        End Set
    End Property

    Private mReadyToSave As Boolean

    ''' <summary>
    ''' Gets or Sets if the item is ready to save
    ''' </summary>
    ''' <value>Boolean</value>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public Property ReadyToSave() As Boolean
        Get
            Return mReadyToSave
        End Get
        Set(ByVal value As Boolean)
            If mReadyToSave <> value Then
                'force to false if item has errors
                If HasErrors Then
                    mReadyToSave = False
                Else
                    mReadyToSave = value
                End If
            End If
        End Set
    End Property



    Private mErrorItems As ErrorItems = ErrorItems.Create()

    ''' <summary>
    ''' Gets the collection of item errors.
    ''' </summary>
    ''' <returns>ErrorItems</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public ReadOnly Property ErrorItems() As ErrorItems
        Get
            Return mErrorItems
        End Get
    End Property

    ''' <summary>
    ''' Gets whether the item has errors
    ''' </summary>
    ''' <returns>Boolean</returns>
    ''' <remarks></remarks>
    <XmlIgnore()> _
    Public ReadOnly Property HasErrors() As Boolean
        Get
            Return Me.ErrorItems.HasErrors
        End Get
    End Property
End Class