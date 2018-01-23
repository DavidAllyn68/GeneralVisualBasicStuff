Public Class mdiMain
    '#### A NOTE ABOUT MULTI THREAD CALLS ###############################
    'This form uses many delegate methods to carry out cross-thread tasks
    'Here's a little primer on why they exist and how they work:

    'First, when you start a thread, you must think of it as spawning a
    'different country.  Each thread, the "original thread" or "new thread" 
    'are seperated by a very defined border.

    'Just as in real life where one country can not tell another country 
    'what to do, one thread can not tell another thread what to do.  If that
    'were allowed, we could very quickly have collisions on what any given
    'thread should do "next".

    'So how do you tell a different thread to do something? You ask politely.  

    'Rather than attempt to do something directly from another thread, you set
    'up a helper method for the same action.  Think of this method as a 
    '"thread embassy".  Instead of setting a form variable directly, you would
    'call the helper method to do it for you.  

    'E.G. Instead of directly setting a variable like MyForm.FormVariable = 5,
    'you would call the helper method like MyForm.SetFormVariable(5)

    'This "embassy" method's job is to check to see if it's running in the original
    'thread or the new thread.  If it's in the new thread (InvokeRequired = True), 
    'it invokes itself on the original thread (InvokeRequired = False) where the
    'task is actually completed.  This assures that all actions are taking place on
    'the original thread as that thread wants it to happen.

    'Of course, when the helper method is run from the original thread
    '(i.e. we haven't created a new thread), it would complete the action without a
    'round-trip needed.

    'A seperate helper method is required for any task or set of tasks that may
    'be required for another thread to do.


    'This application uses a two step process to handle data processing
    'First, create a "process delegate" method to do the work
    'Second, you call that method in a new thread from a menu command
    'or a status bar panel button.

    'If you've decided to use a status bar button to ask the user if they
    'want to process some data, then add the command to the status bar at
    'the bottom of the form by calling: mdiMain.StatusRibbon_AddPanel(uniquekey,commandtext,PanelBehavior.Button)
    'Then, add the key and process method call to the MainStatusBar_CommandClick
    'event handler.
    '#####################################################################


    Private OkToCloseMDI As Boolean = True
    Private AllowedCommandCategories As New List(Of String)

#Region "Form and Form Control Methods"
    Public Sub PreventClosing()

        'check to see if this is the original or new thread
        If Me.InvokeRequired Then

            'from the new thread, invoke the same method 
            'on the original thread
            Me.Invoke(New Action(AddressOf PreventClosing))
        Else

            'from the original thread, complete the action.
            OkToCloseMDI = False
        End If
    End Sub

    Public Sub AllowClosing()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf AllowClosing))
        Else
            'test to make sure all threads have finished
            Dim _maxThreads As Integer = 0
            Dim _availableThreads As Integer = 0
            Dim _threadsOpen As Integer = 0
            Dim _argPlaceHolder As Integer = 0

            'load the variables with counts from the thread pool
            Threading.ThreadPool.GetMaxThreads(_maxThreads, _argPlaceHolder)
            Threading.ThreadPool.GetAvailableThreads(_availableThreads, _argPlaceHolder)

            'the threads that are open are the maxiumum number of threads
            'minus the number of them that are available for use
            _threadsOpen = _maxThreads - _availableThreads

            'only change the OkToCloseMDI variable if it is the last thread
            'in the thread pool (i.e. 1) or if there are no working threads
            If _threadsOpen <= 1 Then
                OkToCloseMDI = True
            End If
        End If

    End Sub

    Private Sub ToggleWaitCursor()
        If Me.InvokeRequired Then
            Me.Invoke(New Action(AddressOf ToggleWaitCursor))
        Else
            If Me.Cursor = Cursors.Default Then
                Me.Cursor = Cursors.WaitCursor
            Else
                Me.Cursor = Cursors.Default
            End If
        End If
    End Sub

    Private Sub mdiMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Font = My.Settings.ApplicationFont


        EnableAllowedMenus()
        StatusRibbon_AddRightSidePanel("UserRoleDisplay", My.Application.UserRoleDisplay)

    End Sub

    Private Sub AddAllowedCommandCategory(ByVal _menuCategory As String)

        If Not AllowedCommandCategories.Contains(_menuCategory) Then AllowedCommandCategories.Add(_menuCategory)

    End Sub
    Private Sub EnableAllowedMenus()
        'Roles are built using the Domain Secuirty Groups "WLA Analytics..." (e.g. "WLA Analytics Admin")
        'Contact the IT department to have a user added to one of the below
        'Security Groups.

        'ENABLE ALL COMMANDS UNTIL ROLE-BASED SECURITY CAN BE INSTALLED AGAIN
        For Each _i As Janus.Windows.UI.CommandBars.UICommand In Me.uicmMain.Commands
            _i.Enabled = Janus.Windows.UI.InheritableBoolean.True
            _i.Visible = Janus.Windows.UI.InheritableBoolean.True
        Next

        '####################################################################
        'ROLE BASED SECURITY HAS BEEN TEMPORARILY REMOVED
        '   (ALSO VISIT THE ApplicationEvents MODULE)
        '
        '   I.T. was not able to make these security groups visible
        '   to .NET applications.  For some reason some users' assignment
        '   to a security group would be visible, while others' would not be
        '
        '   Unfortunately, due to my limited ability to research and fix
        '   this issue, I need to remove it.
        '####################################################################

        'For Each _role In My.Application.UserAssignedRoles
        '    Select Case _role
        '        Case "Admin"
        '            'gets all commands
        '            For Each _s As Janus.Windows.UI.CommandBars.UICommandCategory In uicmMain.Categories
        '                AddAllowedCommandCategory(_s.CategoryName)
        '            Next

        '        Case "Data"
        '            AddAllowedCommandCategory("Application")
        '            AddAllowedCommandCategory("AnalysisManagement")
        '            AddAllowedCommandCategory("DataManagement")
        '            AddAllowedCommandCategory("ReportingManagement")

        '        Case "ETL"
        '            AddAllowedCommandCategory("Application")
        '            AddAllowedCommandCategory("DataManagement")

        '        Case "Consultant"
        '            AddAllowedCommandCategory("Application")
        '            AddAllowedCommandCategory("AnalysisManagement")
        '            AddAllowedCommandCategory("ReportingManagement")

        '        Case Else
        '            'nothing
        '    End Select
        'Next




        ''enable/disable all commands appropriately
        'For Each _i As Janus.Windows.UI.CommandBars.UICommand In Me.uicmMain.Commands

        '    'toggle allowed categories
        '    If AllowedCommandCategories.Contains(_i.CategoryName) Then
        '        _i.Enabled = Janus.Windows.UI.InheritableBoolean.True
        '        _i.Visible = Janus.Windows.UI.InheritableBoolean.True
        '    Else
        '        _i.Enabled = Janus.Windows.UI.InheritableBoolean.False
        '        _i.Visible = Janus.Windows.UI.InheritableBoolean.False
        '    End If

        'Next




    End Sub

    Public Sub OpenForm(ByVal _form As Form)
        If Me.InvokeRequired Then
            Me.Invoke(New Action(Of Form)(AddressOf OpenForm), _form)
        Else
            Try
                ToggleWaitCursor()
                _form.MdiParent = Me
                _form.Font = My.Settings.ApplicationFont
                _form.Show()
                _form.Focus()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "mdiMain OpenForm Error")

            Finally
                ToggleWaitCursor()
            End Try
        End If

    End Sub

    Sub CloseForm(ByVal formName As String)
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Name = formName Then ChildForm.Close()
        Next

    End Sub
    Private Sub CloseAll()
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
            ChildForm.Dispose()
        Next

    End Sub

    Private Sub mdiMainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If OkToCloseMDI Then
            CloseAll()
            SaveAllData()
        Else
            MessageBox.Show("Please wait until all processes have finished running.  Please see the bottom status bar for more information.", "Please Wait", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            e.Cancel = True
        End If

    End Sub

    Private Sub SaveAllData()
        For Each _o As Object In MdiChildren
            Try
                'in order to have a form "saveable"
                'add a Public Sub SaveData() to the
                'child form's code

                _o.SaveData()

            Catch ex As Exception
                'do nothing
            End Try
        Next
    End Sub

    Private Sub RefreshAll()
        For Each _o As Object In MdiChildren
            Try
                'in order to use the refresh command,
                'add Public Overrides Sub Refresh()
                'to the child form's code

                _o.Refresh()
            Catch ex As Exception
                'do nothing
            End Try
        Next
    End Sub


#End Region

#Region "StatusBarPanel Helper Methods"
    Public Sub StatusRibbon_AddPanel(ByVal _key As String, ByVal _text As String)
        StatusRibbon_AddPanel(_key, _text, Janus.Windows.Ribbon.PanelBehavior.Label)
    End Sub
    Private Sub StatusRibbon_AddRightSidePanel(ByVal _key As String, ByVal _text As String)
        If MainStatusBar.InvokeRequired Then
            MainStatusBar.Invoke(New Action(Of String, String)(AddressOf StatusRibbon_AddRightSidePanel), _key, _text)
        Else
            Dim _Panel As New Janus.Windows.Ribbon.StatusBarPanel

            _Panel.Key = _key
            _Panel.PanelBehavior = Janus.Windows.Ribbon.PanelBehavior.Label
            _Panel.AutoSize = StatusBarPanelAutoSize.Contents
            _Panel.Text = _text


            For Each _p As Janus.Windows.Ribbon.StatusBarPanel In MainStatusBar.LeftPanelCommands
                'don't add an existing key
                If _p.Key = _Panel.Key Then Exit Sub
            Next

            MainStatusBar.RightPanelCommands.Add(_Panel)
        End If
    End Sub
    Public Sub StatusRibbon_AddPanel(ByVal _key As String, ByVal _text As String, ByVal _panelBehavior As Janus.Windows.Ribbon.PanelBehavior)

        If MainStatusBar.InvokeRequired Then
            MainStatusBar.Invoke(New Action(Of String, String, Janus.Windows.Ribbon.PanelBehavior)(AddressOf StatusRibbon_AddPanel), _key, _text, _panelBehavior)
        Else


            Dim _Panel As New Janus.Windows.Ribbon.StatusBarPanel

            _Panel.Key = _key
            _Panel.PanelBehavior = _panelBehavior
            _Panel.AutoSize = StatusBarPanelAutoSize.Contents
            _Panel.Text = _text

            For Each _p As Janus.Windows.Ribbon.StatusBarPanel In MainStatusBar.LeftPanelCommands
                'don't add an existing key
                If _p.Key = _Panel.Key Then Exit Sub
            Next

            MainStatusBar.LeftPanelCommands.Add(_Panel)
        End If

    End Sub

    Public Sub StatusRibbon_UpdatePanel(ByVal _key As String, ByVal _text As String)

        If MainStatusBar.InvokeRequired Then
            MainStatusBar.Invoke(New Action(Of String, String)(AddressOf StatusRibbon_UpdatePanel), _key, _text)
        Else
            Try
                Dim _Panel As New Janus.Windows.Ribbon.StatusBarPanel
                _Panel = MainStatusBar.LeftPanelCommands(_key)
                _Panel.Text = _text

            Catch aoorEx As ArgumentOutOfRangeException
                'if there is no panel that matches this _key
                'create one.
                StatusRibbon_AddPanel(_key, _text)

            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub

    Public Sub StatusRibbon_RemovePanel(ByVal _key As String)
        If MainStatusBar.InvokeRequired Then
            MainStatusBar.Invoke(New Action(Of String)(AddressOf StatusRibbon_RemovePanel), _key)
        Else
            Try
                MainStatusBar.LeftPanelCommands.Remove(MainStatusBar.LeftPanelCommands(_key))
            Catch aoorEx As ArgumentOutOfRangeException
                'panel doesn't exists.  Do nothing.
            Catch ex As Exception
                Throw ex
            End Try
        End If
    End Sub

    Private Sub MainStatusBar_CommandClick(ByVal sender As Object, ByVal e As Janus.Windows.Ribbon.CommandEventArgs) Handles MainStatusBar.CommandClick
        Select Case e.Command.Key
            Case "ProcessAmeribenData"
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessAmeribenClaimsData)
                StatusRibbon_RemovePanel("ProcessAmeribenData")

            Case "ProcessHTHData"
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessHTHClaimsData)
                StatusRibbon_RemovePanel("ProcessHTHData")

            Case "ProcessAnthemData"
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessAnthemClaimsData)
                StatusRibbon_RemovePanel("ProcessAnthemData")

            Case "ProcessMooData"
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessMooClaimsData)
                StatusRibbon_RemovePanel("ProcessMooData")

            Case "ProcessProviderGroups"
                Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessProviderGrouping)
                StatusRibbon_RemovePanel("ProcessProviderGroups")

            Case Else
                'do nothing
        End Select

    End Sub
#End Region

#Region "Data Processing Delegates"
    'These delegates are incharge of running the processes
    'in a new thread.  They are called by passing it to
    'the thread pool queue.  
    'E.g. Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessHTHClaimsData)

    Public Sub ProcessHTHClaimsData()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        'a fresh data context is created
        Dim _HTHDataContext As New HthDataDataContext

        'we create a universally unique key for the status bar
        'by returning the current tick count of Now()
        Dim _key As String = CStr(DateTime.Now().Ticks)

        'we tell the mdi form that it can't close
        PreventClosing()

        'inform the user
        StatusRibbon_AddPanel(_key, "Processing HTH Data...")

        'do the processing
        _HTHDataContext.ProcessData()

        'remove the status bar panel
        StatusRibbon_RemovePanel(_key)

        'tell the form it's ok to close now.
        AllowClosing()

    End Sub

    Public Sub ProcessAmeribenClaimsData()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _AmeribenDataContext As New AmeribenDataDataContext
        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Processing Ameriben Data...")
        _AmeribenDataContext.ProcessData()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()
    End Sub

    Public Sub ProcessAnthemClaimsData()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _AnthemDataContext As New AnthemDataDataContext
        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Processing Anthem Data...")
        _AnthemDataContext.ProcessData()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()
    End Sub
    Public Sub ImportMooClaimsFile()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _MooDataContext As New MooDataDataContext
        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Importing MOO Data...")
        '_MooDataContext.ImportClaimsFile()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()

    End Sub

    Public Sub ProcessMooClaimsData()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _MooDataContext As New MooDataDataContext
        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Processing MOO Data...")
        _MooDataContext.ProcessData()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()

    End Sub

    Public Sub ProcessMessageQueue()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _MessageQueueDataContext As New DataWarehouseMessageQueueDataContext

        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Processing the Message Queue...")
        _MessageQueueDataContext.MessageQueue_ProcessMessages()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()
    End Sub

    Public Sub ProcessGeneralStatistic(ByVal _statisticId As Integer)
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _GeneralStatisticDataContext As New GeneralStatisticsDataContext
        Dim _GeneralStatistic As GeneralStatistics_Statistic = (From _gs As GeneralStatistics_Statistic _
                                                                In _GeneralStatisticDataContext.GeneralStatistics_Statistics _
                                                                Where _gs.GeneralStatisticId = _statisticId).Single

        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()

        StatusRibbon_AddPanel(_key, "Developing Statistic: " & _GeneralStatistic.Name & "...   ")
        _GeneralStatisticDataContext.GeneralStatistics_DevelopStatistic(_statisticId)
        StatusRibbon_RemovePanel(_key)
        AllowClosing()

    End Sub

    Public Sub ProcessProviderGrouping()
        'this method must remain here and seperate
        'so that it's contents will all run inside 
        'a seperate thread called elsewhere

        Dim _ProviderGroupingDataContext As New ProviderGroupingDataContext

        Dim _key As String = CStr(DateTime.Now().Ticks)

        PreventClosing()
        StatusRibbon_AddPanel(_key, "Processing the Provider Groups...")
        _ProviderGroupingDataContext.ProviderGroup_LoadSHSProviderListingFromClaims()
        StatusRibbon_RemovePanel(_key)
        AllowClosing()
    End Sub

#End Region

#Region "Menu Command Event Handlers"
    Private Sub cmdEXIT1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdEXIT1.Click
        Application.Exit()
    End Sub

    Private Sub cmdSAVE1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSAVE1.Click
        SaveAllData()
    End Sub
    Private Sub cmdSCHOOLGROUP_GROUPS1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSCHOOLGROUP_GROUPS.Click
        OpenForm(My.Forms.frmSchoolgroupGroupsEditor)
    End Sub

    Private Sub cmdANALYSISPEOPLE1_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdANALYSISPEOPLE.Click
        OpenForm(My.Forms.frmAnalysisPeopleEditor)
    End Sub

    Private Sub cmdALTERNATEDESCRIPTORS_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdALTERNATEDESCRIPTORS.Click
        OpenForm(My.Forms.frmAlternateDescriptorEditor)
    End Sub

    Private Sub cmdANALYSISREQUESTSTATUS_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdANALYSISREQUESTSTATUS.Click
        OpenForm(My.Forms.frmAnalysisRequestStatusEditor)
    End Sub

    Private Sub cmdANALYSISREQUESTTYPE_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdANALYSISREQUESTTYPE.Click
        OpenForm(My.Forms.frmAnalysisRequestTypeEditor)
    End Sub

    Private Sub cmdANALYSISTRACKER_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdANALYSISTRACKER.Click
        'OpenForm(My.Forms.frmAnalysisRequestListing)

        'Open form using a new thread.
        System.Threading.ThreadPool.QueueUserWorkItem(AddressOf OpenForm, My.Forms.frmAnalysisRequestListing)
    End Sub

    Private Sub cmdDISTRIBUTIONS_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDISTRIBUTIONS.Click
        OpenForm(My.Forms.frmDistributionsEditor)
    End Sub

    Private Sub cmdDatasourceMaxPaidDate_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDatasourceMaxPaidDate.Click
        OpenForm(My.Forms.frmDatasourceMaxPaidDate)
    End Sub

    Private Sub cmdSCHOOLGROUPASSIGNMENTS_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSCHOOLGROUPASSIGNMENTS.Click
        OpenForm(My.Forms.frmSchoolgroupAssignmentsEditor)
    End Sub

    Private Sub cmdSCHOOLGROUPASSIGNMENTTYPES_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSCHOOLGROUPASSIGNMENTTYPES.Click
        OpenForm(My.Forms.frmSchoolgroupAssignmentTypeEditor)
    End Sub


    Private Sub cmdDatasources_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDatasources.Click
        OpenForm(My.Forms.frmDatasourceEditor)
    End Sub


    Private Sub cmdDataWarehouseBenefits_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseBenefits1.Click
        OpenForm(My.Forms.frmDataWarehouseBenefits)
    End Sub

    Private Sub cmdDataWarehouseServices_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseServices1.Click
        OpenForm(My.Forms.frmDataWarehouseServices)
    End Sub

    Private Sub cmdDataWarehouseDiagnoses_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseDiagnoses1.Click
        OpenForm(My.Forms.frmDataWarehouseDiagnoses)
    End Sub

    Private Sub cmdDataWarehouseTypeOfService_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseTypeOfService1.Click
        OpenForm(My.Forms.frmDataWarehouseTypeOfService)
    End Sub

    Private Sub cmdDataWarehouseTypeOfServiceCategory_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseTypeOfServiceCategory1.Click
        OpenForm(My.Forms.frmDataWarehouseTypeOfServiceCategory)
    End Sub

    Private Sub cmdDataWarehouseTypeOfServiceSubCategory_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseTypeOfServiceSubCategory1.Click
        OpenForm(My.Forms.frmDataWarehouseTypeOfServiceSubCategory)
    End Sub

    Private Sub cmdDataWarehouseDiagnosisCategories_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseDiagnosisCategories1.Click
        OpenForm(My.Forms.frmDataWarehouseDiagnosisCategories)
    End Sub

    Private Sub cmdDataWarehouseDiagnosisCodeType_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseDiagnosisCodeType1.Click
        OpenForm(My.Forms.frmDataWarehouseDiagnosisCodeType)
    End Sub

    Private Sub cmdEditMessageQueue_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdEditMessageQueue.Click
        OpenForm(My.Forms.frmDataWarehouseMessageQueue)

    End Sub
    Private Sub cmdProcessMessageQueue_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcessMessageQueue.Click

        Try
            Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessMessageQueue)
            If My.Forms.frmDataWarehouseMessageQueue.Visible Then
                My.Forms.frmDataWarehouseMessageQueue.Refresh()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error in Processing Message Queue")
        End Try
    End Sub



    Private Sub cmdAggregationSettings_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAggregationSettings.Click
        OpenForm(frmAggregationSettings)
    End Sub

    Private Sub cmdMonthlyExperience_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdMonthlyExperience.Click
        OpenForm(frmMonthlyExperience)
    End Sub

    Private Sub cmdReportViewerAvailableReportParameterValues_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdReportViewerAvailableReportParameterValues.Click
        OpenForm(frmReportViewerAvailableReportParameterValues)
    End Sub

    Private Sub cmdReportViewerAvailableGroupingItems_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdReportViewerAvailableGroupingItems.Click
        OpenForm(frmReportViewerAvailableGroupingItems)
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdHelp.Click
        MessageBox.Show("This command menu item is for help.")
    End Sub

    Private Sub cmdReportViewerUsers_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdReportViewerUsers.Click
        OpenForm(frmReportViewerUsers)
    End Sub

    Private Sub cmdReportViewerRecordFilters_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdReportViewerRecordFilters.Click
        OpenForm(frmReportViewerFilters)
    End Sub

    Private Sub cmdProviderGrouping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProviderGrouping.Click
        OpenForm(frmProviderGrouping)
    End Sub

    Private Sub cmdREFRESH_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdREFRESH.Click
        RefreshAll()
    End Sub

    Private Sub cmdANALYSISMILESTONESCHEDULE_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdANALYSISMILESTONESCHEDULE.Click
        OpenForm(frmAnalysisRequestMilestoneSchedule)
    End Sub

    Private Sub cmdEditAnthemMonthlySummaryData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdEditAnthemMonthlySummaryData.Click
        OpenForm(frmAnthemMonthlySummary)
    End Sub

    Private Sub cmdSchoolgroupLogo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSchoolgroupLogo.Click
        OpenForm(frmSchoolgroupLogo)
    End Sub

    Private Sub cmdHthGroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdHthGroupMapping.Click
        OpenForm(frmHthGroupMapping)
    End Sub

    Private Sub cmdAnalysisLogListing_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAnalysisLogListing.Click
        OpenForm(frmAnalysisRequestLogListing)
    End Sub

    Private Sub cmdAmeribenNetworkFees_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAmeribenNetworkFees.Click
        OpenForm(frmAmeribenNetworkFees)
    End Sub

    Private Sub cmdProcessSampleData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcessSampleData.Click
        OpenForm(frmSampleReportingProcessing)
    End Sub

    Private Sub cmdDatawarehouseServiceCodeTypes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDatawarehouseServiceCodeTypes.Click
        OpenForm(frmDataWarehouseServiceCodeType)
    End Sub

    Private Sub cmdEsiGroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdEsiGroupMapping.Click
        OpenForm(frmEsiGroupMapping)
    End Sub

    Private Sub cmdRatingStatisticTypes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdRatingStatisticTypes.Click
        OpenForm(frmRatingStatisticTypes)
    End Sub

    Private Sub cmdDataWarehouseBenefitCategories_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdDataWarehouseBenefitCategories.Click
        OpenForm(frmDataWarehouseBenefitCategories)
    End Sub

    Private Sub cmdOverlandParkTrizzetoBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdOverlandParkTrizzetoBenefitMapping.Click
        OpenForm(frmOverlandParkTrizzetoBenefitMapping)
    End Sub

    Private Sub cmdAmeribenGroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAmeribenGroupMapping.Click
        OpenForm(frmAmeribenGroupMapping)
    End Sub

    Private Sub cmdAmeribenBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAmeribenBenefitMapping.Click
        OpenForm(My.Forms.frmAmeribenBenefitMapping)
    End Sub

    Private Sub cmdHthBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdHthBenefitMapping.Click
        OpenForm(My.Forms.frmHthBenefitMapping)
    End Sub

    Private Sub cmdMooBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdMooBenefitMapping.Click
        OpenForm(My.Forms.frmMooBenefitMapping)
    End Sub

    Private Sub cmdPiaBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdPiaBenefitMapping.Click
        OpenForm(My.Forms.frmPiaBenefitMapping)
    End Sub

    Private Sub cmdSchoolAddressInfo_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSchoolAddressInfo.Click
        OpenForm(My.Forms.frmSchoolAddressInfo)
    End Sub

    Private Sub cmdAnalysisPeoplePersonType_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAnalysisPeoplePersonType.Click
        OpenForm(My.Forms.frmAnalysisPeoplePersonTypeEditor)
    End Sub
    Private Sub cmdClaremontTagMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdClaremontTagMapping.Click
        OpenForm(My.Forms.frmClaremontSchoolgroupMapping)
    End Sub

    Private Sub cmdLineOfBusiness_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdLineOfBusiness.Click
        OpenForm(My.Forms.frmLineOfBusinessEditor)
    End Sub

    Private Sub cmdLineOfBusinessCategories_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdLineOfBusinessCategories.Click
        OpenForm(My.Forms.frmLineOfBusinessCategoryEditor)
    End Sub

    Private Sub cmdSchoolgroupLineOfBusiness_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdSchoolgroupLineOfBusiness.Click
        OpenForm(My.Forms.frmSchoolgroupLineOfBusinessEditor)
    End Sub

    Private Sub cmdMarketingDbSchoolgroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdMarketingDbSchoolgroupMapping.Click
        OpenForm(My.Forms.frmMarketingDb_SchoolgroupMapping)
    End Sub

    Private Sub cmdAetnaGroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAetnaGroupMapping.Click
        OpenForm(My.Forms.frmAetnaGroupMapping)
    End Sub

    Private Sub cmdGeneralStatisticsDevelopment_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdGeneralStatisticsDevelopment.Click
        OpenForm(My.Forms.frmGeneralStatisticsEditor)
    End Sub

    Private Sub cmdGeneralStatisticsCategories_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdGeneralStatisticsCategories.Click
        OpenForm(My.Forms.frmGeneralStatisticsCategoryEditor)
    End Sub

    Private Sub cmdProcedureScheduleEdit_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcedureScheduleEdit.Click
        OpenForm(My.Forms.frmProcedureSchedule)
    End Sub

    Private Sub cmdProcedureScheduleRecurrence_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcedureScheduleRecurrence.Click
        OpenForm(My.Forms.frmProcedureSchedule_Recurrence)
    End Sub

    Private Sub cmdProcedureScheduleRecurrenceTypes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdProcedureScheduleRecurrenceTypes.Click
        OpenForm(My.Forms.frmProcedureSchedule_RecurrenceTypes)
    End Sub

    Private Sub cmdOverlandParkEnrollmentActivity_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdOverlandParkEnrollmentActivity.Click
        OpenForm(My.Forms.frmOverlandParkEnrollmentActivity)
    End Sub

    Private Sub cmdOverlandParkBTSBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdOverlandParkBTSBenefitMapping.Click
        OpenForm(My.Forms.frmOverlandParkBTSBenefitMapping)
    End Sub

    Private Sub cmdOverlandParkGroupMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdOverlandParkGroupMapping.Click
        OpenForm(My.Forms.frmOverlandParkGroupMapping)
    End Sub

    Private Sub cmdOverlandParkGroups_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdOverlandParkGroups.Click
        OpenForm(My.Forms.frmOverlandParkGroups)
    End Sub

    Private Sub cmdAetnaBenefitMapping_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAetnaBenefitMapping.Click
        OpenForm(My.Forms.frmAetnaBenefitMapping)
    End Sub

    Private Sub cmdAetnaBenefitTypes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAetnaBenefitTypes.Click
        OpenForm(My.Forms.frmAetnaBenefitTypes)
    End Sub

    Private Sub cmdAetnaPlaceOfServiceCodes_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAetnaPlaceOfServiceCodes.Click
        OpenForm(My.Forms.frmAetnaPlaceOfServiceCodes)
    End Sub

    Private Sub cmdExportToExcel_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdExportToExcel.Click
        Dim _o As Object = Me.ActiveMdiChild
        Try
            Dim _s As String = _o.Name
            _o.ExportGridExToExcel()
        Catch ex As Exception
            'do nothing
            'assumes there is no method
        End Try
    End Sub

    Private Sub cmdEventLogDetails_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdEventLogDetails.Click
        'OpenForm(My.Forms.frmEventLogDetails)

        'open in new thread because of automatic refreshing that causes UI to "skip"
        Threading.ThreadPool.QueueUserWorkItem(AddressOf OpenForm, My.Forms.frmEventLogDetails)
    End Sub

    Private Sub cmdHTHReprocessData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdHTHReprocessData.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessHTHClaimsData)
    End Sub

    Private Sub cmdAmeribenProcessData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAmeribenProcessData.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessAmeribenClaimsData)
    End Sub
    Private Sub cmdAnthemProcessData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdAnthemProcessData.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessAnthemClaimsData)
    End Sub
    Private Sub cmdMOOProcessData_Click(ByVal sender As Object, ByVal e As Janus.Windows.UI.CommandBars.CommandEventArgs) Handles cmdMOOProcessData.Click
        Threading.ThreadPool.QueueUserWorkItem(AddressOf ProcessMooClaimsData)
    End Sub
#End Region


End Class
