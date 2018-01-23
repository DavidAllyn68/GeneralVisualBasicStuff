Imports System.Data.SqlClient
Namespace My

    ' The following events are available for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.


    Partial Friend Class MyApplication

        Public ApplicationIntro As New frmApplicationIntro()
        Public CurrentAnalysisPerson As New LookupAnalysisPeople()
        Public UserAssignedRoles As New List(Of String)
        Public UserRoleDisplay As String = String.Empty
        Public OpenConnections As New List(Of AttemptedConnection)


        Private Sub EvaluateUserRoles()

            '####################################################################
            'ROLE BASED SECURITY HAS BEEN TEMPORARILY REMOVED
            '
            '   I.T. was not able to make these security groups visible
            '   to .NET applications.  For some reason some users' assignment
            '   to a security group would be visible, while others' would not be
            '
            '   Unfortunately, due to my limited ability to research and fix
            '   this issue, I need to remove it.
            '####################################################################


            If My.User.IsInRole("WLA Analytics Admin") Then UserAssignedRoles.Add("Admin")
            If My.User.IsInRole("WLA Analytics Consultant") Then UserAssignedRoles.Add("Consultant")
            If My.User.IsInRole("WLA Analytics ETL") Then UserAssignedRoles.Add("ETL")
            If My.User.IsInRole("WLA Analytics Data") Then UserAssignedRoles.Add("Data")

            Dim _roleString As String = String.Empty
            For Each _i As String In UserAssignedRoles
                _roleString = _roleString & ", " & _i
            Next

            If _roleString = String.Empty Then
                _roleString = "NOT AUTHORIZED"
                MessageBox.Show("In order to use the Ascension Analytics application, you must be part of the Analytics team." & vbCrLf & vbCrLf & "Please have your manager submit a help desk ticket to be added to one of the WLA Analytics security groups.", "NOT AUTHORIZED", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            Else
                _roleString = "WLA Analytics " & _roleString.Substring(2, _roleString.Length - 2)
            End If

            UserRoleDisplay = UserRoleDisplay & " - " & My.User.Name & " (" & _roleString & ")"

        End Sub

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup

            'check the connection of the neccessary directories and servers

            OpenConnections.Add(New AttemptedConnection("Applications Server", "\\APPLICATIONS\renapp", AttemptedConnection.TypeOfConnection.DirectoryLogin, "Please log into the folder: \\APPLICATIONS\renapp"))
            OpenConnections.Add(New AttemptedConnection("Data Warehouse", "REN-SQL2.David", AttemptedConnection.TypeOfConnection.DatabaseLogin, "You are not authorized to access REN-SQL2.David Database"))
            OpenConnections.Add(New AttemptedConnection("RenAnalysis Folder", "\\XSERV\Marketing\RenAnalysis", AttemptedConnection.TypeOfConnection.DirectoryLogin, "Please log into the folder: \\XSERV\Marketing\RenAnalysis"))
            OpenConnections.Add(New AttemptedConnection("School Folders", "\\XSERV\Marketing\aaa.Schools", AttemptedConnection.TypeOfConnection.DirectoryLogin, "Please log into the folder: \\XSERV\Marketing\aaa.SCHOOLS"))

            With ApplicationIntro
                .WindowState = FormWindowState.Normal
                .Focus()
                .Show()

                .DisplayMessage("Checking Network Connections...", 2000)

                For Each i As AttemptedConnection In OpenConnections
                    If i.AttemptConnection Then
                        .DisplayMessage("CONNECTION SUCCESSFUL:" & vbCrLf & i.ConnectionName & vbCrLf & "Connection to: " & i.ConnectionLocation & vbCrLf & "Connection Succeeded", 1000)
                    Else
                        .DisplayMessage("CONNECTION FAILED:" & vbCrLf & i.ConnectionName & vbCrLf & "Connection to: " & i.ConnectionLocation & vbCrLf & i.MessageIfFail, 5000, True)
                    End If

                Next

                If (From _i As AttemptedConnection In OpenConnections Where _i.AttemptSuccessful = False).Count > 0 Then

                    .DisplayMessage("Some connections failed. Please check them and try again.", 2000, True)
                    .DisplayMessage("Closing Application...", 1000)
                    e.Cancel = True
                Else
                    .DisplayMessage("Starting Application...", 1000)
                    .Hide()
                End If
            End With

            If e.Cancel = True Then Exit Sub

            'if all connections work, then set the current analyst to the user.
            Dim _LookupDataContext As New LookupTablesDataContext()

            My.Application.CurrentAnalysisPerson = (From _p As LookupAnalysisPeople In _LookupDataContext.LookupAnalysisPeoples _
                        Where (_p.WindowsUserName = My.User.Name)).Single


            'evaluate the WLA Analytics Domain Security Groups this user is in
            'EvaluateUserRoles() 'SEE COMMENTS WITHIN THE METHOD
            My.Application.UserRoleDisplay = My.User.Name
        End Sub
    End Class

    Class AttemptedConnection

        Public ConnectionName As String = String.Empty
        Public ConnectionLocation As String = String.Empty
        Public MessageIfFail As String = String.Empty
        Public ConnectionType As TypeOfConnection = TypeOfConnection.None
        Public AttemptSuccessful As Boolean = False

        Public Enum TypeOfConnection
            None
            DatabaseLogin
            DirectoryLogin
        End Enum

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal ConnectionName As String, ByVal ConnectionLocation As String, ByVal ConnectionType As TypeOfConnection, ByVal MessageIfFail As String)
            MyBase.New()

            Me.ConnectionName = ConnectionName
            Me.ConnectionLocation = ConnectionLocation
            Me.ConnectionType = ConnectionType
            Me.MessageIfFail = MessageIfFail


        End Sub

        Public Function AttemptConnection()
            Try

                If Me.ConnectionType = TypeOfConnection.DatabaseLogin Then
                    Dim _server As String = Me.ConnectionLocation.Substring(0, Me.ConnectionLocation.IndexOf("."))
                    Dim _database As String = ConnectionLocation.Substring(ConnectionLocation.IndexOf(".") + 1, ConnectionLocation.Length - ConnectionLocation.IndexOf(".") - 1)
                    Dim _connectionString As String = "Data Source=" & _server & ";Initial Catalog=" & _database & ";Integrated Security=True"

                    Dim _c As New SqlClient.SqlConnection(_connectionString)
                    _c.Open()
                Else
                    Dim _exists As Boolean = My.Computer.FileSystem.DirectoryExists(Me.ConnectionLocation)

                End If

                AttemptSuccessful = True
                Return True

            Catch ex As Exception
                AttemptConnection = False
                Return False

            End Try

            Return False
        End Function

    End Class

End Namespace

