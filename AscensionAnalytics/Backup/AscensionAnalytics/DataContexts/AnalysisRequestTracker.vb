Imports System.Data.Linq

Partial Class AnalysisRequestTrackerDataContext
  
End Class

'####################################################
'ANALYSIS REQUEST LOGS
'####################################################
Partial Class AnalysisRequestLog
    Inherits ObjectHelper

    <System.ComponentModel.Bindable(True)> _
      Public ReadOnly Property EntryTextIsEditable() As Boolean
        Get
            If DataActivityEntry = 0 Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property AnalysisName() As String
        Get
            Return Me.AnalysisRequest.Name
        End Get
    End Property
    Private mSuppressValidation As Boolean
    'Fires when the item is created and ready to set defaults
    Private Sub OnCreated()
        OnInitializeDefaults()
    End Sub

    Public Sub OnInitializeDefaults()
        mSuppressValidation = True

        Try
            AnalysisId = 0
            EntryText = "New Log"
            EntryTime = Now()
            EntryUser = My.User.Name
            DataActivityEntry = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AnalysisRequestTrackerExtendedContext AnalysisRequestLog OnInitializeDefaults")
        End Try


        mSuppressValidation = False
    End Sub
    Public Sub ValidateObject()
        If mSuppressValidation = True Then Exit Sub
        Me.ClearAllErrors()

        'validation to run every time row is updated
        Dim AnalysisIdPrefix As String = "Request #" & AnalysisId & ": "

        Try
            If EntryText = String.Empty Then AddError(AnalysisIdPrefix & "EntryText", "Please enter a value for the entry")
            If EntryText.Length > 8000 Then AddError(AnalysisIdPrefix & "EntryText", "Your log entry is too long. Please shorten it before proceeding.")

            If EntryTime = Nothing Then AddError(AnalysisIdPrefix & "EntryTime", "Please specify a time for this log entry")
            If EntryUser = String.Empty Then AddError(AnalysisIdPrefix & "EntryUser", "Please specify the user that created or modified this request")
            If DataActivityEntry < 0 Or DataActivityEntry > 1 Then AddError(AnalysisIdPrefix & "DataActivityEntry", "Data Activity Entry can only be 1 or 0")

            ''For Debugging
            'If Me.HasErrors Then
            '    Stop
            'End If
        Catch ex As Exception

            MessageBox.Show(ex.Message, "AnalysisRequestTrackerExtendedContext AnalysisRequestLog ValidateObject")

        End Try

    End Sub
    'Fires when the row is updated
    Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        ValidateObject()

        'validation to run right before actual database is changed
        EntryTime = Now()
        EntryUser = My.User.Name

        'specific to the linq action
        Select Case action
            Case Data.Linq.ChangeAction.Update
                'update validations

            Case Data.Linq.ChangeAction.Insert
                'insert validations

            Case Data.Linq.ChangeAction.Delete
                'delete validations

            Case Else

        End Select

        If Me.HasErrors Then
            Throw New Exception(Me.AllValidationErrors)

        End If
    End Sub
End Class

'####################################################
'ANALYSIS REQUEST
'####################################################
Partial Class AnalysisRequest
    Inherits ObjectHelper

    Private mSuppressValidation As Boolean

    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property TotalEffortMinutes() As Integer
        Get
            Return (From _logs In Me.AnalysisRequestLogs Select _logs.EffortMinutes).Sum
        End Get
    End Property

    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property ScheduleItemTitle() As String
        Get
            Return Name & ": " & Milestone
        End Get
    End Property

    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property MilestoneEndForScheduleDisplay() As Date
        Get
            Return DateAdd(DateInterval.Minute, 30, MilestoneDate)
        End Get
    End Property

    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property CurrentUserIsAssignee() As Boolean
        Get
            Return My.Application.CurrentAnalysisPerson.PersonId = AssigneeId
        End Get
    End Property

    <System.ComponentModel.Bindable(True)> _
    Public ReadOnly Property NameForDisplay() As String
        Get
            If CurrentUserIsAssignee Then
                Return Name
            Else
                Return "(Read Only) " & Name
            End If
        End Get
    End Property
    Private Sub OnCreated()
        OnInitializeDefaults()
    End Sub

    'Fires when the item is created and ready to set defaults
    Public Sub OnInitializeDefaults()
        mSuppressValidation = True
        Try
            'Default values
            Name = "New Request"
            Description = "New Request: Fill in a description"
            Milestone = "Fill in request details"
            MilestoneDate = Now().Date.AddHours(7) 'Today at 7am
            RequestorId = 0 'Unspecified
            AssigneeId = 0 'Unspecified
            DirectoryFullPath = My.Settings.AnalysisRequestsDirectory
            StatusId = 1 'Open
            RequestTypeId = 1 'Unspecified
            OpenDate = Now
            StartDate = Now()
            EndDate = #12/31/2049 6:00:00 PM#
            CloseDate = #12/31/2049 6:00:00 PM#
            IsActive = 1
            ModifiedByUser = My.User.Name
            ModifiedTime = Now()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "AnalysisRequestTrackerExtendedContext AnalysisRequest OnInitializeDefaults")

        End Try

        mSuppressValidation = False
    End Sub



    Public Sub ValidateObject()
        If mSuppressValidation = True Then Exit Sub
        Me.ClearAllErrors()

        'validation to run every time row is updated.

        Dim AnalysisIdPrefix As String = "Request #" & AnalysisId & ": "

        Try
            If Name = String.Empty Then AddError(AnalysisIdPrefix & "Name", "Please enter a name for this request.")
            If Name.Length > 200 Then AddError(AnalysisIdPrefix & "Name", "Please shorten the name of this request.")

            If Description = String.Empty Then AddError(AnalysisIdPrefix & "Description", "Please enter a description for this request.")
            If Description.Length > 2000 Then AddError(AnalysisIdPrefix & "Description", "Please shorten your description for this request.")

            If Milestone = String.Empty Then AddError(AnalysisIdPrefix & "Milestone", "Please give this request a milestone.")
            If Milestone.Length > 2000 Then AddError(AnalysisIdPrefix & "Milestone", "Please shorten your milestone for this request.")

            If MilestoneDate = Nothing Then AddError(AnalysisIdPrefix & "MilestoneDate", "Please supply a date for this request's current milestone to occur.")

            'If RequestorId = Nothing Then AddError("RequestorId", "Please choose a requestor of this request.")
            'If AssigneeId = Nothing Then AddError("AssigneeId", "Please choose an assignee for this request.")

            If DirectoryFullPath = String.Empty Then AddError(AnalysisIdPrefix & "DirectoryFullPath", "Please supply a directory.")
            If DirectoryFullPath.Length > 500 Then AddError(AnalysisIdPrefix & "DirectoryFullPath", "The path for this directly is too long.")

            'Double Check that request directory is valid
            If Not My.Computer.FileSystem.DirectoryExists(DirectoryFullPath) AndAlso Not My.Computer.FileSystem.FileExists(DirectoryFullPath) Then
                AddError(AnalysisIdPrefix & "DirectoryFullPath", "File or Folder does not exist.")
            End If

            If StatusId = Nothing Then AddError(AnalysisIdPrefix & "StatusId", "Please specify a status.")
            If RequestTypeId = Nothing Then AddError(AnalysisIdPrefix & "RequestTypeId", "Please specify the request's type")


            If OpenDate = Nothing Then AddError(AnalysisIdPrefix & "OpenDate", "Please enter a date with this request was opened.")
            If StartDate = Nothing Then AddError(AnalysisIdPrefix & "StartDate", "Please enter a date when the request was started or should be started.")
            If EndDate = Nothing Then AddError(AnalysisIdPrefix & "EndDate", "Please entere a date when the request ended or should end.")
            If CloseDate = Nothing Then AddError(AnalysisIdPrefix & "CloseDate", "Please enter a date when the request closed or should close.")

            If OpenDate > CloseDate Then AddError(AnalysisIdPrefix & "OpenDate", "Open Date can not be greater than Closed Date.")
            If CloseDate < OpenDate Then AddError(AnalysisIdPrefix & "CloseDate", "Close Date can not be less than Open Date.")


            If IsActive < 0 Or IsActive > 1 Then AddError(AnalysisIdPrefix & "IsActive", "Please specify whether the request is active or not.")
            If ModifiedByUser = String.Empty Then AddError(AnalysisIdPrefix & "ModifiedByUser", "Please specify what user last changed this request.")
            If ModifiedTime = Nothing Then AddError(AnalysisIdPrefix & "ModifiedTime", "Please specify the date and time when the request last changed.")


        Catch ex As Exception
            MessageBox.Show(ex.Message, "AnalysisRequestTrackerExtendedContext AnalysisRequest ValidateObject")
        End Try



    End Sub

    'Fires when a specific field is changed
    Private Sub OnDirectoryFullPathChanged()
        ValidateObject()

    End Sub

    'Fires when the row is updated
    Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
        ValidateObject()

        'validation to run right before actual database is changed
        ModifiedByUser = My.User.Name
        ModifiedTime = Now()

        'specific to the linq action
        Select Case action
            Case Data.Linq.ChangeAction.Update
                'update validations

            Case Data.Linq.ChangeAction.Insert
                'insert validations

            Case Data.Linq.ChangeAction.Delete
                'delete validations

            Case Else

        End Select

        If Me.HasErrors Then
            Throw New Exception(Me.AllValidationErrors)

        End If
    End Sub

    Private Sub DataActivityLog(ByVal _LogEntry As String)
        If mSuppressValidation Then Exit Sub

        Dim _log As New AnalysisRequestLog
        _log.AnalysisRequest = Me
        _log.EntryText = _LogEntry
        _log.DataActivityEntry = 1
        _log.EntryTime = Now
        _log.EntryUser = My.User.Name

        AnalysisRequestLogs.Add(_log)

    End Sub

    Private Sub OnCloseDateChanged()
        DataActivityLog("Closed Date changed to: " & CloseDate.ToString())
    End Sub

    Private Sub OnIsActiveChanged()
        If IsActive Then
            DataActivityLog("Request was made Active")
        Else
            DataActivityLog("Request was made Inactive")
        End If
    End Sub

    Private Sub OnMilestoneChanged()
        DataActivityLog("Milstone changed to: " & Milestone)
    End Sub

    Private Sub OnMilestoneDateChanged()
        DataActivityLog("Milestone Date changed to: " & MilestoneDate.ToString("G"))
    End Sub

    Private Sub OnNameChanged()
        DataActivityLog("Name was changed to: " & Name)
    End Sub

    Private Sub OnRequestorIdChanged()
        Dim _DataContext As New AnalysisRequestTrackerDataContext
        Dim _Requestor As String = (From _requestors In _DataContext.AnalysisRequestPeoples Where _requestors.PersonId = RequestorId Select _requestors.Name).Max
        DataActivityLog("Requestor was changed to: " & _Requestor)
    End Sub

    Private Sub OnAssigneeIdChanged()
        Dim _DataContext As New AnalysisRequestTrackerDataContext
        Dim _Assignee As String = (From _assignees In _DataContext.AnalysisRequestPeoples Where _assignees.PersonId = AssigneeId Select _assignees.Name).Max
        DataActivityLog("Assignee was changed to: " & _Assignee)
    End Sub

    Private Sub OnRequestTypeIdChanged()
        Dim _DataContext As New AnalysisRequestTrackerDataContext
        Dim _Type As String = (From _types In _DataContext.AnalysisRequestTypes Where _types.RequestTypeId = RequestTypeId Select _types.RequestType).Max
        DataActivityLog("Request Type changed to: " & _Type)
    End Sub

    Private Sub OnStatusIdChanged()
        Dim _DataContext As New AnalysisRequestTrackerDataContext
        Dim _Status As String = (From _statuses In _DataContext.AnalysisRequestStatus Where _statuses.StatusId = StatusId Select _statuses.Status).Max
        DataActivityLog("Request Status changed to: " & _Status)

        'if the request has been changed to closed or cancelled then set the closed date to now()
        'else set the close date to live.
        If StatusId = 5 Or StatusId = 6 Then
            CloseDate = Now()
        Else
            CloseDate = #12/31/2049 6:00:00 PM#
        End If

    End Sub
End Class

Partial Public Class AnalysisRequestTrackerDataContext
    Inherits System.Data.Linq.DataContext



End Class


