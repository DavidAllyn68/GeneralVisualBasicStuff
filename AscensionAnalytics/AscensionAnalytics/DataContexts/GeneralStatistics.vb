Partial Class GeneralStatisticsDataContext

End Class

Partial Class GeneralStatistics_DevelopedStatistic
    Inherits ObjectHelper

    Private mSuppressValidation As Boolean


    'Fires when the item is created and ready to set defaults
    Public Sub OnInitializeDefaults()
        mSuppressValidation = True
        Try
            'Default values
            Result = ""
            DevelopmentTime = Now()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "GeneralStatisticsExtendedContext DevelopedStatistics OnInitializeDefaults")

        End Try

        mSuppressValidation = False
    End Sub
End Class

