Imports System.ComponentModel

Public Class Statistics
    Inherits BindingList(Of Statistic)

    <Bindable(True)> _
    Public ReadOnly Property NonZeroCount() As Integer
        Get
            Dim _rtn As Integer

            For Each i In Me
                If i.Value <> 0 Then
                    _rtn += 1
                End If
            Next

            Return _rtn
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property Sum() As Decimal
        Get
            Dim _rtn As Decimal

            For Each i In Me
                _rtn += i.Value
            Next

            Return _rtn
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property Mean() As Decimal
        Get
            If Count > 0 Then
                Return Sum / Count
            End If
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property NonZeroMean() As Decimal
        Get
            If NonZeroCount > 0 Then
                Return Sum / NonZeroCount
            End If
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property Max() As Decimal
        Get
            Dim _rtn As Decimal = Me(0).Value

            For Each i In Me
                _rtn = Math.Max(_rtn, i.Value)
            Next

            Return _rtn
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property Min() As Decimal
        Get
            Dim _rtn As Decimal = Me(0).Value

            For Each i In Me
                _rtn = Math.Min(_rtn, i.Value)
            Next



            Return _rtn
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property StandardDeviationSample() As Decimal
        Get
            If Count < 2 Then Return Nothing

            Dim _rtn As Decimal

            'squared total variance
            For Each i In Me
                _rtn += ((i.Value - Mean) ^ 2)
            Next

            'average (count-1 for sample) squared variance
            _rtn = _rtn / (Count - 1)

            'square root of the average squared variance
            _rtn = Math.Sqrt(_rtn)

            Return _rtn
        End Get
    End Property

    <Bindable(True)> _
    Public ReadOnly Property StandardDeviationPopulation() As Decimal
        Get
            Dim _rtn As Decimal


            'squared total variance
            For Each i In Me
                _rtn += (i.Value - Mean) ^ 2
            Next

            'average squared variance
            _rtn = _rtn / Count

            'square root of the average squared variance
            _rtn = Math.Sqrt(_rtn)

            Return _rtn
        End Get
    End Property

End Class

Public Class Statistic

    Private mName As String = String.Empty
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property

    Private mValue As Decimal = Nothing
    Public Property Value() As Decimal
        Get
            Return mValue
        End Get
        Set(ByVal value As Decimal)
            mValue = value
        End Set
    End Property
End Class
