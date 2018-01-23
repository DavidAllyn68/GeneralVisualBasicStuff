Public Class Conversion
    ''' <summary>
    ''' Converts a number of minutes to a HH:MM display string
    ''' </summary>
    ''' <param name="TotalMinutes">A number of minutes</param>
    ''' <returns>Converted to HH:MM</returns>
    ''' <remarks>1440 Minutes (i.e. 24 hours) will return 00:00</remarks>
    Public Function DisplayMinutesAsHours(ByVal TotalMinutes As Object) As String
        Dim Hours As Integer = 0
        Dim Minutes As Integer = 0

        Try
            TotalMinutes = CType(TotalMinutes, Integer)

            'TotalMinutes = TotalMinutes Mod 1440 '24 Hours

            Hours = TotalMinutes \ 60
            Minutes = TotalMinutes Mod 60

            Return Hours.ToString("00") & ":" & Minutes.ToString("00")

        Catch ex As Exception
            Return String.Empty
        End Try
    End Function
End Class

