Imports System.IO
Imports System.Data.SqlClient
''' <summary>
''' This class helps in the loading of data from a delimited text file to a SQL Server Table
''' </summary>
''' <remarks></remarks>
Public Class FileToSqlLoader

#Region "Properties"
    Private mSourceFileName As String
    Public Property SourceFileName() As String
        Get
            Return mSourceFileName
        End Get
        Set(ByVal value As String)
            mSourceFileName = value
            If mSourceFileName = String.Empty Then Throw New FileToSqlLoaderSourceFileNameEmptyException
            If Not File.Exists(mSourceFileName) Then Throw New FileToSqlLoaderSourceFileDoesntExistException
            SourceFileStreamReader = File.OpenText(mSourceFileName)

        End Set
    End Property

    Private mSourceFileStreamReader As StreamReader
    Public Property SourceFileStreamReader() As StreamReader
        Get
            Return mSourceFileStreamReader
        End Get
        Set(ByVal value As StreamReader)
            mSourceFileStreamReader = value

        End Set
    End Property

    Private mSourceFileColumnDelimiter As String
    Public Property SourceFileColumnDelimiter() As String
        Get
            Return mSourceFileColumnDelimiter
        End Get
        Set(ByVal value As String)
            mSourceFileColumnDelimiter = value
        End Set
    End Property


    Private mDestinationConnectionString As String
    Public Property DestinationConnectionString() As String
        Get
            Return mDestinationConnectionString
        End Get
        Set(ByVal value As String)
            mDestinationConnectionString = value

            If mDestinationConnectionString <> String.Empty Then
                DestinationSqlConnection.ConnectionString = DestinationConnectionString
            End If
        End Set
    End Property

    Private mDestinationSqlConnection As New SqlConnection
    Private ReadOnly Property DestinationSqlConnection() As SqlConnection
        Get
            Return mDestinationSqlConnection
        End Get
    End Property

    Private mDestinationTableName As String
    Public Property DestinationTableName() As String
        Get
            Return mDestinationTableName
        End Get
        Set(ByVal value As String)
            mDestinationTableName = value
        End Set
    End Property

    Private mDataTable As New DataTable()
    Private ReadOnly Property DataTable() As DataTable
        Get
            Return mDataTable
        End Get
    End Property

    Private ReadOnly Property DataTableHasColumns() As Boolean
        Get
            If Me.DataTable.Columns.Count > 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property

    Private mSkipFirstRow As Boolean
    Public Property SkipFirstRow() As Boolean
        Get
            Return mSkipFirstRow
        End Get
        Set(ByVal value As Boolean)
            mSkipFirstRow = value
        End Set
    End Property
#End Region

    Public Sub New()
        MyBase.New()

    End Sub

    Public Sub New(ByVal _SourceFileName As String, ByVal _SourceFileColumnDelimiter As String, ByVal _HasColumnHeaders As Boolean, ByVal _DestinationConnectionString As String, ByVal _DestinationTableName As String)
        SourceFileName = _SourceFileName
        SourceFileColumnDelimiter = _SourceFileColumnDelimiter
        SkipFirstRow = _HasColumnHeaders
        DestinationConnectionString = _DestinationConnectionString
        DestinationTableName = _DestinationTableName
    End Sub

    Public Sub ProcessFile()

        ProcessTextFileToDataTable()
        PushDataTableToDestinationTable()
    End Sub

    Public Sub TruncateDestinationTable()
        'validate
        If DestinationSqlConnection.ConnectionString = String.Empty Then Throw New FileToSqlLoaderConnectionStringException
        If DestinationTableName = String.Empty Then Throw New FileToSqlLoaderEmptyDestinationTableNameException

        DestinationSqlConnection.Open()

        Dim _sqlCommandText As String = "TRUNCATE TABLE " & DestinationTableName
        Dim _sqlCommand As New SqlCommand(_sqlCommandText, DestinationSqlConnection)

        _sqlCommand.ExecuteNonQuery()

        DestinationSqlConnection.Close()
    End Sub

    Public Function RowCountInDestinationTable() As Integer
        'validate
        If DestinationSqlConnection.ConnectionString = String.Empty Then Throw New FileToSqlLoaderConnectionStringException
        If DestinationTableName = String.Empty Then Throw New FileToSqlLoaderEmptyDestinationTableNameException

        DestinationSqlConnection.Open()

        Dim _sqlCommandText As String = "select count(*) from " & DestinationTableName
        Dim _sqlCommand As New SqlCommand(_sqlCommandText, DestinationSqlConnection)
        Dim _rowCount As Integer = _sqlCommand.ExecuteScalar

        DestinationSqlConnection.Close()
        Return _rowCount
    End Function

    Private Sub PushDataTableToDestinationTable()
        'validate
        If DestinationSqlConnection.ConnectionString = String.Empty Then Throw New FileToSqlLoaderConnectionStringException
        If DestinationTableName = String.Empty Then Throw New FileToSqlLoaderEmptyDestinationTableNameException

        'process
        DestinationSqlConnection.Open()

        Dim _sqlBulkCopy As New SqlBulkCopy(DestinationSqlConnection)
        _sqlBulkCopy.DestinationTableName = mDestinationTableName
        _sqlBulkCopy.WriteToServer(Me.DataTable)

        DestinationSqlConnection.Close()
    End Sub

    Private Sub SetupDataTableColumns(ByVal _textLine As String)
        'validate
        If SourceFileColumnDelimiter = String.Empty Then Throw New FileToSqlLoaderEmptyColumnDelimiterException
        If _textLine = String.Empty Then Throw New FileToSqlLoaderEmptyTextLineException

        'process
        Dim _splitTextLine() As String = _textLine.Split(SourceFileColumnDelimiter)
        For Each item In _splitTextLine
            Me.DataTable.Columns.Add(New DataColumn())
        Next item

    End Sub

    Private Sub AppendDataRowToDataTable(ByVal _textLine As String)
        'validate
        If SourceFileColumnDelimiter = String.Empty Then Throw New FileToSqlLoaderEmptyColumnDelimiterException
        If _textLine = String.Empty Then Throw New FileToSqlLoaderEmptyTextLineException

        'process
        Dim _splitTextLine() As String = _textLine.Split(SourceFileColumnDelimiter)
        Dim _dataRow As DataRow = Me.DataTable.NewRow()
        _dataRow.ItemArray = _splitTextLine
        Me.DataTable.Rows.Add(_dataRow)

    End Sub

    Private Sub ProcessTextFileToDataTable()
        Dim _textLine As String = Nothing

        If SourceFileStreamReader Is Nothing Then Exit Sub

        Me.DataTable.Clear()

        Do While Not SourceFileStreamReader.EndOfStream
            If SkipFirstRow Then SourceFileStreamReader.ReadLine()
            _textLine = SourceFileStreamReader.ReadLine()

            If _textLine IsNot Nothing Then
                If Not DataTableHasColumns Then SetupDataTableColumns(_textLine)
                AppendDataRowToDataTable(_textLine)
            End If
        Loop

    End Sub
End Class

#Region "Custom Exceptions"
Class FileToSqlLoaderSourceFileDoesntExistException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "The source file doesn't exist."
        End Get
    End Property
End Class

Class FileToSqlLoaderSourceFileNameEmptyException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "The source file name is empty."
        End Get
    End Property
End Class

Class FileToSqlLoaderConnectionStringException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "You must pass a valid connection string to process this file"
        End Get
    End Property
End Class

Class FileToSqlLoaderEmptyDestinationTableNameException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "The destination table name can not be empty."
        End Get
    End Property
End Class

Class FileToSqlLoaderEmptyTextLineException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "The line of text is empty, can not process"
        End Get
    End Property
End Class

Class FileToSqlLoaderEmptyColumnDelimiterException
    Inherits System.Exception

    Public Overrides ReadOnly Property Message() As String
        Get
            Return "The column delimiter can not be empty"
        End Get
    End Property
End Class

#End Region
