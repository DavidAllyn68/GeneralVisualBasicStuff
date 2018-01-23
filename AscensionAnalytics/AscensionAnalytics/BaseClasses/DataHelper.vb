Imports System.Data
Imports System.Xml
Imports System.Data.SqlClient
Imports ADODB

Public Class DataHelper
    Implements IDisposable

    Private mSqlConnection As SqlConnection

    Public Property SqlConnection() As SqlConnection
        Get
            Return mSqlConnection
        End Get
        Set(ByVal value As SqlConnection)
            mSqlConnection = value
        End Set
    End Property

    Private mSqlCommand As SqlCommand
    Public Property SqlCommand() As SqlCommand
        Get
            Return mSqlCommand
        End Get
        Set(ByVal value As SqlCommand)
            mSqlCommand = value
        End Set
    End Property

    Private mSqlCommandType As CommandType
    Public Property SqlCommandType() As CommandType
        Get
            Return mSqlCommandType
        End Get
        Set(ByVal value As CommandType)
            mSqlCommandType = value
        End Set
    End Property

    Private mSqlCommandText As String
    Public Property SqlCommandText() As String
        Get
            Return mSqlCommandText
        End Get
        Set(ByVal value As String)
            mSqlCommandText = value
        End Set
    End Property

    Private mSqlConnectionString As String = My.Settings.DavidConnectionString
    Public Property SqlConnectionString() As String
        Get
            Return mSqlConnectionString
        End Get
        Set(ByVal value As String)
            mSqlConnectionString = value
        End Set
    End Property

    Private mADODBConnection As ADODB.Connection
    Public Property ADODBConnection() As ADODB.Connection
        Get
            Return mADODBConnection
        End Get
        Set(ByVal value As ADODB.Connection)
            mADODBConnection = value
        End Set
    End Property

    Private mFieldCount As Integer
    Public Property FieldCount() As Integer
        Get
            Return mFieldCount
        End Get
        Set(ByVal value As Integer)
            mFieldCount = value
        End Set
    End Property


    Private mDataTable As New DataTable()
    Private ReadOnly Property DataTable() As DataTable
        Get
            Return mDataTable
        End Get
    End Property

    Private ReadOnly Property DataTableHasColumns()
        Get
            If DataTable.Columns.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property



    Public Sub New()
        MyBase.New()

        SqlConnection = New SqlConnection(SqlConnectionString)
        SqlCommand = mSqlConnection.CreateCommand()

        ADODBConnection = New ADODB.Connection
        ADODBConnection.CursorLocation = CursorLocationEnum.adUseClient
        ADODBConnection.ConnectionString = My.Settings.DavidConnectionString
    End Sub

    Public Sub AddSqlParameter(ByVal _SqlParameter As SqlParameter)
        SqlCommand.Parameters.Add(_SqlParameter)
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType)
        SqlCommand.Parameters.Add(_ParameterName, _ParameterType)
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType, ByVal _ParameterDirection As ParameterDirection)
        Try
            SqlCommand.Parameters.Add(_ParameterName, _ParameterType)
            SqlCommand.Parameters(_ParameterName).Direction = _ParameterDirection
        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameter Add Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameter Add Error:")
        End Try
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType, ByVal _ParameterValue As Object)
        Try
            SqlCommand.Parameters.Add(_ParameterName, _ParameterType)
            SqlCommand.Parameters(_ParameterName).Value = _ParameterValue

        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameter Add Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameter Add Error:")
        End Try
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType, ByVal _ParameterValue As Object, ByVal _ParameterDirection As ParameterDirection)
        Try
            SqlCommand.Parameters.Add(_ParameterName, _ParameterType)
            SqlCommand.Parameters(_ParameterName).Value = _ParameterValue
            SqlCommand.Parameters(_ParameterName).Direction = _ParameterDirection
        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameter Add Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameter Add Error:")
        End Try
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType, ByVal _ParameterSize As Integer, ByVal _ParameterValue As Object)
        Try
            SqlCommand.Parameters.Add(_ParameterName, _ParameterType, _ParameterSize)
            SqlCommand.Parameters(_ParameterName).Value = _ParameterValue

        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameter Add Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameter Add Error:")
        End Try
    End Sub

    Public Sub AddSqlParameter(ByVal _ParameterName As String, ByVal _ParameterType As SqlDbType, ByVal _ParameterSize As Integer, ByVal _ParameterValue As Object, ByVal _ParameterDirection As ParameterDirection)
        Try
            SqlCommand.Parameters.Add(_ParameterName, _ParameterType, _ParameterSize)
            SqlCommand.Parameters(_ParameterName).Value = _ParameterValue
            SqlCommand.Parameters(_ParameterName).Direction = _ParameterDirection
        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameter Add Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameter Add Error:")
        End Try
    End Sub

    Public Function SqlParameterValue(ByVal _ParameterName As String) As Object
        Dim _returnValue As Object = Nothing

        Try
            _returnValue = SqlCommand.Parameters(_ParameterName).Value
        Catch ex As Exception
            Throw New DataHelperException("DataHelper SqlParameterValue Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper SqlParameterValue Error:")

        End Try

        Return _returnValue
    End Function
    Public Function ExecuteReader() As SqlDataReader
        Return ExecuteReader(SqlCommandText)
    End Function

    Public Function ExecuteReader(ByVal _CommandText As String) As SqlDataReader
        SqlCommandType = CommandType.Text
        Return ExecuteReader(_CommandText, SqlCommandType)
    End Function

    Public Function ExecuteReader(ByVal _CommandText As String, ByVal _CommandType As CommandType) As SqlDataReader
        Dim _return As SqlDataReader = Nothing

        SqlCommandText = _CommandText
        SqlCommandType = _CommandType

        SqlCommand.CommandText = SqlCommandText
        SqlCommand.CommandType = SqlCommandType

        Try
            SqlConnection.Open()
            _return = SqlCommand.ExecuteReader()

        Catch ex As Exception
            Throw New DataHelperException("DataHelper ExecuteReader Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper ExecuteReader Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        Return _return
    End Function

    Public Function ExecuteReaderFromProcedure(ByVal _ProcedureName As String, ByVal ParamArray SqlParameterArray() As SqlParameter) As SqlDataReader
        'add parameters
        For Each _i As SqlParameter In SqlParameterArray
            SqlCommand.Parameters.Add(_i)
        Next

        Return ExecuteReaderFromProcedure(_ProcedureName)
    End Function

    Public Function ExecuteReaderFromProcedure(ByVal _ProcedureName As String) As SqlDataReader
        Dim _return As SqlDataReader = Nothing

        SqlCommandText = _ProcedureName
        SqlCommandType = CommandType.StoredProcedure

        SqlCommand.CommandText = SqlCommandText
        SqlCommand.CommandType = SqlCommandType

        Try
            SqlConnection.Open()
            _return = SqlCommand.ExecuteReader()


        Catch ex As Exception
            Throw New DataHelperException("DataHelper ExecuteReaderFromProcedure Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper ExecuteReaderFromProcedure Error:", MessageBoxButtons.OK)

        End Try

        Return _return
    End Function

    Public Function ExecuteNonReaderFromProcedure(ByVal _ProcedureName As String, ByVal ParamArray SqlParameterArray() As SqlParameter) As Integer
        'add parameters
        For Each _i As SqlParameter In SqlParameterArray
            SqlCommand.Parameters.Add(_i)
        Next

        Return ExecuteNonReaderFromProcedure(_ProcedureName)
    End Function

    Public Function ExecuteNonReaderFromProcedure(ByVal _ProcedureName As String) As Integer
        Dim _return As Integer = 0

        SqlCommandText = _ProcedureName
        SqlCommandType = CommandType.StoredProcedure

        SqlCommand.CommandText = SqlCommandText
        SqlCommand.CommandType = SqlCommandType

        Try
            SqlConnection.Open()
            _return = SqlCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DataHelperException("DataHelper ExecuteNonReaderFromProcedure Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper ExecuteNonReaderFromProcedure Error:", MessageBoxButtons.OK)
        End Try

        Return _return
    End Function

    Public Function ExecuteXmlReader(ByVal _CommandText As String) As XmlReader
        Dim _return As XmlReader = Nothing

        SqlCommandText = _CommandText
        SqlCommandType = CommandType.Text

        SqlCommand.CommandText = SqlCommandText
        SqlCommand.CommandType = SqlCommandType

        Try
            SqlConnection.Open()
            _return = SqlCommand.ExecuteXmlReader()
        Catch ex As Exception
            Throw New DataHelperException("DataHelper ExecuteXmlReader Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper ExecuteXmlReader Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        Return _return
    End Function

    Public Function ExecuteNonQuery(ByVal _CommandText As String) As Integer
        Return ExecuteNonQuery(_CommandText, CommandType.Text)
    End Function

    Public Function ExecuteNonQuery(ByVal _CommandText As String, ByVal _CommandType As CommandType) As Integer
        Dim _return As Integer = 0
        SqlCommandText = _CommandText
        SqlCommandType = _CommandType

        SqlCommand.CommandText = SqlCommandText
        SqlCommand.CommandType = SqlCommandType

        Try
            SqlConnection.Open()
            _return = SqlCommand.ExecuteNonQuery()

        Catch ex As Exception
            Throw New DataHelperException("DataHelper ExecuteNonQuery Error:", ex)
            'MessageBox.Show(ex.Message, "DataHelper ExecuteNonQuery Error:", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        Return _return
    End Function

    Public Function ExecuteRecordset(ByVal _CommandText As String) As ADODB.Recordset
        Dim _rst As New ADODB.Recordset
        SqlCommandText = _CommandText


        'Dim _conn As New ADODB.Connection
        '_conn.ConnectionString = My.Settings.ConnectionString


        Try
            ADODBConnection.Open()

            With _rst
                .ActiveConnection = ADODBConnection
                .CursorLocation = CursorLocationEnum.adUseClient
                .CursorType = CursorTypeEnum.adOpenForwardOnly
                .LockType = LockTypeEnum.adLockReadOnly
                .Open(_CommandText, , , , 1)
                .ActiveConnection = Nothing
            End With

            ADODBConnection.Close()
            ADODBConnection = Nothing

        Catch ex As Exception
            Throw New DataHelperException(ex.Message, ex)
            'MessageBox.Show(ex.Message)
            _rst = Nothing

        End Try

        Return _rst
    End Function

    Public Sub Close()
        Try
            SqlCommandText = ""

            If SqlConnection.State = ConnectionState.Open Then
                SqlConnection.Close()
            End If

            If ADODBConnection.State = 1 Then
                ADODBConnection.Close()
            End If
        Catch ex As Exception

            Throw New DataHelperException("DataHelper Close Error", ex)
        End Try
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
        Close()

    End Sub

    Private disposedValue As Boolean = False        ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(ByVal disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                SqlCommand.Dispose()
                SqlConnection.Dispose()
                ' TODO: free other state (managed objects).
            End If

            ADODBConnection = Nothing
            ' TODO: free your own state (unmanaged objects).
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

#Region " IDisposable Support "
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class

Public Class DataHelperException
    Inherits System.Exception

    Public Sub New(ByVal errorMessage As String)
        MyBase.New(errorMessage)
    End Sub

    Public Sub New(ByVal errorMessage As String, ByVal innerException As Exception)
        MyBase.New(errorMessage, innerException)
    End Sub
End Class