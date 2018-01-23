Partial Class ProviderGroupingDataContext

End Class
Partial Class ProviderGroupProvider
    Inherits ObjectHelper
    Private mSuppressValidation As Boolean = False

    Public Sub OnInitializeDefaults()
        mSuppressValidation = True

        'initialize default values here

        mSuppressValidation = False
    End Sub
    Public Sub ValidateObject()
        If mSuppressValidation Then Exit Sub
        Me.ClearAllErrors()

        Try
            'Add Validation here


        Catch ex As Exception
            MessageBox.Show(ex.Message, "ProviderGroupProvider ValidateObject()")

        End Try

    End Sub

    Private Sub OnCreated()
        OnInitializeDefaults()
    End Sub

    Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        ValidateObject()
    End Sub


End Class

Partial Class ProviderGroup
    Inherits ObjectHelper

    Private mSuppressValidation As Boolean = False


    Public Sub OnInitializeDefaults()
        mSuppressValidation = True

        'initialize default values here

        mSuppressValidation = False
    End Sub
    Public Sub ValidateObject()
        If mSuppressValidation Then Exit Sub
        Me.ClearAllErrors()

        Try
            'Add validation here

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ProviderGroup ValidateObject()")

        End Try

    End Sub

    Private Sub OnCreated()
        OnInitializeDefaults()

    End Sub
End Class
