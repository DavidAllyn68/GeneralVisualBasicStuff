<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim UiCommandCategory1 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim UiCommandCategory2 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim UiCommandCategory3 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim UiCommandCategory4 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim UiCommandCategory5 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim UiCommandCategory6 As Janus.Windows.UI.CommandBars.UICommandCategory = New Janus.Windows.UI.CommandBars.UICommandCategory
        Dim JanusColorScheme1 As Janus.Windows.Common.JanusColorScheme = New Janus.Windows.Common.JanusColorScheme
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiMain))
        Me.uicmMain = New Janus.Windows.UI.CommandBars.UICommandManager(Me.components)
        Me.BottomRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.uicmdbarMain = New Janus.Windows.UI.CommandBars.UICommandBar
        Me.cmdAPPLICATION1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAPPLICATION")
        Me.cmdDataWarehouse1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouse")
        Me.cmdAnalysisManagement1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisManagement")
        Me.ReportingManagement1 = New Janus.Windows.UI.CommandBars.UICommand("ReportingManagement")
        Me.cmdGeneralStatistics1 = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatistics")
        Me.cmdHelp1 = New Janus.Windows.UI.CommandBars.UICommand("cmdHelp")
        Me.cmdAPPLICATION = New Janus.Windows.UI.CommandBars.UICommand("cmdAPPLICATION")
        Me.cmdREFRESH1 = New Janus.Windows.UI.CommandBars.UICommand("cmdREFRESH")
        Me.cmdSAVE1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSAVE")
        Me.cmdExportToExcel1 = New Janus.Windows.UI.CommandBars.UICommand("cmdExportToExcel")
        Me.Separator1 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdEXIT1 = New Janus.Windows.UI.CommandBars.UICommand("cmdEXIT")
        Me.cmdSAVE = New Janus.Windows.UI.CommandBars.UICommand("cmdSAVE")
        Me.cmdPRINT = New Janus.Windows.UI.CommandBars.UICommand("cmdPRINT")
        Me.cmdEXIT = New Janus.Windows.UI.CommandBars.UICommand("cmdEXIT")
        Me.cmdLOOKUPTABLES = New Janus.Windows.UI.CommandBars.UICommand("cmdLOOKUPTABLES")
        Me.cmdSCHOOLGROUP_GROUPS = New Janus.Windows.UI.CommandBars.UICommand("cmdSCHOOLGROUP_GROUPS")
        Me.cmdTOOLS = New Janus.Windows.UI.CommandBars.UICommand("cmdTOOLS")
        Me.cmdANALYSISTRACKER = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISTRACKER")
        Me.cmdANALYSISPEOPLE = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISPEOPLE")
        Me.cmdANALYSISREQUESTSTATUS = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISREQUESTSTATUS")
        Me.cmdANALYSISREQUESTTYPE = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISREQUESTTYPE")
        Me.cmdALTERNATEDESCRIPTORS = New Janus.Windows.UI.CommandBars.UICommand("cmdALTERNATEDESCRIPTORS")
        Me.cmdDISTRIBUTIONS = New Janus.Windows.UI.CommandBars.UICommand("cmdDISTRIBUTIONS")
        Me.cmdDatasourceMaxPaidDate = New Janus.Windows.UI.CommandBars.UICommand("cmdDatasourceMaxPaidDate")
        Me.cmdSCHOOLGROUPASSIGNMENTS = New Janus.Windows.UI.CommandBars.UICommand("cmdSCHOOLGROUPASSIGNMENTS")
        Me.cmdSCHOOLGROUPASSIGNMENTTYPES = New Janus.Windows.UI.CommandBars.UICommand("cmdSCHOOLGROUPASSIGNMENTTYPES")
        Me.cmdPROCEDURESCHEDULE = New Janus.Windows.UI.CommandBars.UICommand("cmdPROCEDURESCHEDULE")
        Me.cmdProcedureScheduleEdit1 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleEdit")
        Me.cmdProcedureScheduleRecurrence1 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleRecurrence")
        Me.cmdProcedureScheduleRecurrenceTypes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleRecurrenceTypes")
        Me.cmdDatasources = New Janus.Windows.UI.CommandBars.UICommand("cmdDatasources")
        Me.cmdBENEFITMAPPING = New Janus.Windows.UI.CommandBars.UICommand("cmdBENEFITMAPPING")
        Me.cmdAmeribenBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenBenefitMapping")
        Me.cmdHthBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdHthBenefitMapping")
        Me.cmdMooBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMooBenefitMapping")
        Me.cmdPiaBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdPiaBenefitMapping")
        Me.cmdOverlandParkTrizzetoBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkTrizzetoBenefitMapping")
        Me.cmdAmeribenBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenBenefitMapping")
        Me.cmdHthBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdHthBenefitMapping")
        Me.cmdMooBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdMooBenefitMapping")
        Me.cmdPiaBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdPiaBenefitMapping")
        Me.cmdDataWarehouse = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouse")
        Me.cmdPROCEDURESCHEDULE1 = New Janus.Windows.UI.CommandBars.UICommand("cmdPROCEDURESCHEDULE")
        Me.cmdEventLogDetails1 = New Janus.Windows.UI.CommandBars.UICommand("cmdEventLogDetails")
        Me.cmdAggregationSettings1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAggregationSettings")
        Me.cmdMessageQueue1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMessageQueue")
        Me.Separator13 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdDatasources2 = New Janus.Windows.UI.CommandBars.UICommand("cmdDatasources")
        Me.cmdDatasourceMaxPaidDate1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDatasourceMaxPaidDate")
        Me.cmdUnderwriters1 = New Janus.Windows.UI.CommandBars.UICommand("cmdUnderwriters")
        Me.Separator10 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdDataWarehouseDiagnoses1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnoses")
        Me.cmdDataWarehouseDiagnosisCategories1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnosisCategories")
        Me.cmdDataWarehouseDiagnosisCodeType1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnosisCodeType")
        Me.Separator7 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdDataWarehouseServices1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseServices")
        Me.cmdServiceCodeTypes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDatawarehouseServiceCodeTypes")
        Me.cmdDataWarehouseTypeOfService1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfService")
        Me.cmdDataWarehouseTypeOfServiceCategory1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfServiceCategory")
        Me.cmdDataWarehouseTypeOfServiceSubCategory1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfServiceSubCategory")
        Me.Separator6 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdDataWarehouseBenefits1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseBenefits")
        Me.cmdBenefitCategoriesEditor1 = New Janus.Windows.UI.CommandBars.UICommand("cmdBenefitCategoriesEditor")
        Me.Separator14 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdLineOfBusiness1 = New Janus.Windows.UI.CommandBars.UICommand("cmdLineOfBusiness")
        Me.cmdLineOfBusinessCategories1 = New Janus.Windows.UI.CommandBars.UICommand("cmdLineOfBusinessCategories")
        Me.cmdSchoolgroupLineOfBusiness1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolgroupLineOfBusiness")
        Me.Separator11 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdABISOverlandPark1 = New Janus.Windows.UI.CommandBars.UICommand("cmdABISOverlandPark")
        Me.cmdAetna1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAetna")
        Me.cmdAmeriben1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeriben")
        Me.cmdANTHEM1 = New Janus.Windows.UI.CommandBars.UICommand("cmdANTHEM")
        Me.cmdHTH1 = New Janus.Windows.UI.CommandBars.UICommand("cmdHTH")
        Me.cmdMutualOfOmaha1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMutualOfOmaha")
        Me.cmdPersonalInsuranceAdministrators1 = New Janus.Windows.UI.CommandBars.UICommand("cmdPersonalInsuranceAdministrators")
        Me.cmdExpressScripts1 = New Janus.Windows.UI.CommandBars.UICommand("cmdExpressScripts")
        Me.cmdMarketingDb1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMarketingDb")
        Me.Separator9 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdALTERNATEDESCRIPTORS1 = New Janus.Windows.UI.CommandBars.UICommand("cmdALTERNATEDESCRIPTORS")
        Me.cmdProcessSampleData2 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessSampleData")
        Me.cmdClaremontTagMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdClaremontTagMapping")
        Me.cmdDataWarehouseBenefits = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseBenefits")
        Me.cmdDataWarehouseDiagnoses = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnoses")
        Me.cmdDataWarehouseServices = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseServices")
        Me.cmdDataWarehouseTypeOfService = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfService")
        Me.cmdDataWarehouseTypeOfServiceCategory = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfServiceCategory")
        Me.cmdDataWarehouseTypeOfServiceSubCategory = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseTypeOfServiceSubCategory")
        Me.cmdDataWarehouseDiagnosisCategories = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnosisCategories")
        Me.cmdDataWarehouseDiagnosisCodeType = New Janus.Windows.UI.CommandBars.UICommand("cmdDataWarehouseDiagnosisCodeType")
        Me.cmdAnalysisManagement = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisManagement")
        Me.cmdANALYSISTRACKER2 = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISTRACKER")
        Me.cmdAnalysisLogListing1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisLogListing")
        Me.cmdANALYSISMILESTONESCHEDULE1 = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISMILESTONESCHEDULE")
        Me.cmdANALYSISREQUESTSTATUS2 = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISREQUESTSTATUS")
        Me.cmdANALYSISREQUESTTYPE2 = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISREQUESTTYPE")
        Me.Separator5 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdANALYSISPEOPLE2 = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISPEOPLE")
        Me.cmdAnalysisPeoplePersonType1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisPeoplePersonType")
        Me.cmdMessageQueue = New Janus.Windows.UI.CommandBars.UICommand("cmdMessageQueue")
        Me.cmdEditMessageQueue1 = New Janus.Windows.UI.CommandBars.UICommand("cmdEditMessageQueue")
        Me.cmdProcessMessageQueue1 = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessMessageQueue")
        Me.cmdProcessMessageQueue = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessMessageQueue")
        Me.cmdEditMessageQueue = New Janus.Windows.UI.CommandBars.UICommand("cmdEditMessageQueue")
        Me.cmdAmeriben = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeriben")
        Me.cmdAmeribenBenefitMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenBenefitMapping")
        Me.cmdAmeribenGroupMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenGroupMapping")
        Me.cmdAmeribenNetworkFees1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenNetworkFees")
        Me.Separator8 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdAmeribenProcessData1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenProcessData")
        Me.cmdAmeribenGroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenGroupMapping")
        Me.cmdAggregationSettings = New Janus.Windows.UI.CommandBars.UICommand("cmdAggregationSettings")
        Me.cmdRatingAndAnalysis = New Janus.Windows.UI.CommandBars.UICommand("cmdRatingAndAnalysis")
        Me.cmdMonthlyExperience1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMonthlyExperience")
        Me.Separator4 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdRatingStatisticTypes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdRatingStatisticTypes")
        Me.cmdMonthlyExperience = New Janus.Windows.UI.CommandBars.UICommand("cmdMonthlyExperience")
        Me.cmdReportViewer = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewer")
        Me.cmdReportViewerAvailableGroupingItems1 = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerAvailableGroupingItems")
        Me.cmdReportViewerAvailableReportParameterValues1 = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerAvailableReportParameterValues")
        Me.cmdReportViewerUsers1 = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerUsers")
        Me.cmdReportViewerRecordFilters1 = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerRecordFilters")
        Me.cmdReportViewerAvailableReportParameterValues = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerAvailableReportParameterValues")
        Me.cmdReportViewerAvailableGroupingItems = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerAvailableGroupingItems")
        Me.cmdHelp = New Janus.Windows.UI.CommandBars.UICommand("cmdHelp")
        Me.cmdReportViewerUsers = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerUsers")
        Me.cmdReportViewerRecordFilters = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewerRecordFilters")
        Me.cmdProviderGrouping = New Janus.Windows.UI.CommandBars.UICommand("cmdProviderGrouping")
        Me.cmdREFRESH = New Janus.Windows.UI.CommandBars.UICommand("cmdREFRESH")
        Me.cmdANALYSISMILESTONESCHEDULE = New Janus.Windows.UI.CommandBars.UICommand("cmdANALYSISMILESTONESCHEDULE")
        Me.cmdANTHEM = New Janus.Windows.UI.CommandBars.UICommand("cmdANTHEM")
        Me.cmdEditMonthlySummaryData1 = New Janus.Windows.UI.CommandBars.UICommand("cmdEditAnthemMonthlySummaryData")
        Me.Separator12 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdAnthemProcessData1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAnthemProcessData")
        Me.cmdEditAnthemMonthlySummaryData = New Janus.Windows.UI.CommandBars.UICommand("cmdEditAnthemMonthlySummaryData")
        Me.cmdSchoolgroupLogo = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolgroupLogo")
        Me.cmdHTH = New Janus.Windows.UI.CommandBars.UICommand("cmdHTH")
        Me.cmdHthBenefitMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdHthBenefitMapping")
        Me.cmdHthGroupMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdHthGroupMapping")
        Me.Separator3 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdHTHReprocessData1 = New Janus.Windows.UI.CommandBars.UICommand("cmdHTHReprocessData")
        Me.cmdHthGroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdHthGroupMapping")
        Me.cmdOverlandParkTrizzetoBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkTrizzetoBenefitMapping")
        Me.cmdAnalysisLogListing = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisLogListing")
        Me.cmdAmeribenNetworkFees = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenNetworkFees")
        Me.cmdProcessSampleData = New Janus.Windows.UI.CommandBars.UICommand("cmdProcessSampleData")
        Me.cmdDatawarehouseServiceCodeTypes = New Janus.Windows.UI.CommandBars.UICommand("cmdDatawarehouseServiceCodeTypes")
        Me.cmdEsiGroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdEsiGroupMapping")
        Me.cmdRatingStatisticTypes = New Janus.Windows.UI.CommandBars.UICommand("cmdRatingStatisticTypes")
        Me.cmdDataWarehouseBenefitCategories = New Janus.Windows.UI.CommandBars.UICommand("cmdBenefitCategoriesEditor")
        Me.cmdPersonalInsuranceAdministrators = New Janus.Windows.UI.CommandBars.UICommand("cmdPersonalInsuranceAdministrators")
        Me.cmdPiaBenefitMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdPiaBenefitMapping")
        Me.cmdABISOverlandPark = New Janus.Windows.UI.CommandBars.UICommand("cmdABISOverlandPark")
        Me.cmdOverlandParkGroups1 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkGroups")
        Me.cmdOverlandParkGroupMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkGroupMapping")
        Me.cmdOverlandParkEnrollmentActivity1 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkEnrollmentActivity")
        Me.cmdOverlandParkTrizzetoBenefitMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkTrizzetoBenefitMapping")
        Me.cmdOverlandParkBTSBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkBTSBenefitMapping")
        Me.cmdMutualOfOmaha = New Janus.Windows.UI.CommandBars.UICommand("cmdMutualOfOmaha")
        Me.cmdMooBenefitMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdMooBenefitMapping")
        Me.Separator15 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdMOOProcessData2 = New Janus.Windows.UI.CommandBars.UICommand("cmdMOOProcessData")
        Me.cmdSchoolAddressInfo = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolAddressInfo")
        Me.cmdUnderwriters = New Janus.Windows.UI.CommandBars.UICommand("cmdUnderwriters")
        Me.cmdAnalysisPeoplePersonType = New Janus.Windows.UI.CommandBars.UICommand("cmdAnalysisPeoplePersonType")
        Me.cmdExpressScripts = New Janus.Windows.UI.CommandBars.UICommand("cmdExpressScripts")
        Me.cmdEsiGroupMapping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdEsiGroupMapping")
        Me.cmdClaremontTagMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdClaremontTagMapping")
        Me.cmdLineOfBusiness = New Janus.Windows.UI.CommandBars.UICommand("cmdLineOfBusiness")
        Me.cmdLineOfBusinessCategories = New Janus.Windows.UI.CommandBars.UICommand("cmdLineOfBusinessCategories")
        Me.cmdSchoolgroupLineOfBusiness = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolgroupLineOfBusiness")
        Me.cmdMarketingDb = New Janus.Windows.UI.CommandBars.UICommand("cmdMarketingDb")
        Me.cmdMarketingDbSchoolgroupMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdMarketingDbSchoolgroupMapping")
        Me.cmdMarketingDbSchoolgroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdMarketingDbSchoolgroupMapping")
        Me.cmdAetna = New Janus.Windows.UI.CommandBars.UICommand("cmdAetna")
        Me.cmdAetnaBenefitTypes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaBenefitTypes")
        Me.cmdAetnaPlaceOfServiceCodes1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaPlaceOfServiceCodes")
        Me.cmdAetnaGroupMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaGroupMapping")
        Me.cmdAetnaBenefitMapping1 = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaBenefitMapping")
        Me.cmdAetnaGroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaGroupMapping")
        Me.cmdGeneralStatistics = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatistics")
        Me.cmdGeneralStatisticsDevelopment1 = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatisticsDevelopment")
        Me.cmdGeneralStatisticsCategories1 = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatisticsCategories")
        Me.cmdGeneralStatisticsDevelopment = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatisticsDevelopment")
        Me.cmdGeneralStatisticsCategories = New Janus.Windows.UI.CommandBars.UICommand("cmdGeneralStatisticsCategories")
        Me.cmdProcedureScheduleEdit = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleEdit")
        Me.cmdProcedureScheduleRecurrence = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleRecurrence")
        Me.cmdProcedureScheduleRecurrenceTypes = New Janus.Windows.UI.CommandBars.UICommand("cmdProcedureScheduleRecurrenceTypes")
        Me.cmdOverlandParkEnrollmentActivity = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkEnrollmentActivity")
        Me.cmdOverlandParkGroups = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkGroups")
        Me.cmdOverlandParkGroupMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkGroupMapping")
        Me.cmdOverlandParkBTSBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdOverlandParkBTSBenefitMapping")
        Me.ReportingManagement = New Janus.Windows.UI.CommandBars.UICommand("ReportingManagement")
        Me.cmdReportViewer1 = New Janus.Windows.UI.CommandBars.UICommand("cmdReportViewer")
        Me.Separator2 = New Janus.Windows.UI.CommandBars.UICommand("Separator")
        Me.cmdSCHOOLGROUP_GROUPS1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSCHOOLGROUP_GROUPS")
        Me.cmdDISTRIBUTIONS1 = New Janus.Windows.UI.CommandBars.UICommand("cmdDISTRIBUTIONS")
        Me.cmdProviderGrouping2 = New Janus.Windows.UI.CommandBars.UICommand("cmdProviderGrouping")
        Me.cmdSchoolAddressInfo1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolAddressInfo")
        Me.cmdSchoolgroupLogo1 = New Janus.Windows.UI.CommandBars.UICommand("cmdSchoolgroupLogo")
        Me.cmdAetnaBenefitMapping = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaBenefitMapping")
        Me.cmdAetnaBenefitTypes = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaBenefitTypes")
        Me.cmdAetnaPlaceOfServiceCodes = New Janus.Windows.UI.CommandBars.UICommand("cmdAetnaPlaceOfServiceCodes")
        Me.cmdExportToExcel = New Janus.Windows.UI.CommandBars.UICommand("cmdExportToExcel")
        Me.cmdEventLogDetails = New Janus.Windows.UI.CommandBars.UICommand("cmdEventLogDetails")
        Me.cmdHTHReprocessData = New Janus.Windows.UI.CommandBars.UICommand("cmdHTHReprocessData")
        Me.cmdAmeribenProcessData = New Janus.Windows.UI.CommandBars.UICommand("cmdAmeribenProcessData")
        Me.cmdAnthemProcessData = New Janus.Windows.UI.CommandBars.UICommand("cmdAnthemProcessData")
        Me.cmdMOOProcessData = New Janus.Windows.UI.CommandBars.UICommand("cmdMOOProcessData")
        Me.cmdMOOImportFile = New Janus.Windows.UI.CommandBars.UICommand("cmdMOOImportFile")
        Me.LeftRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.RightRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.TopRebar1 = New Janus.Windows.UI.CommandBars.UIRebar
        Me.vsmMain = New Janus.Windows.Common.VisualStyleManager(Me.components)
        Me.MainStatusBar = New Janus.Windows.Ribbon.RibbonStatusBar
        Me.uipmMain = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        CType(Me.uicmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uicmdbarMain, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TopRebar1.SuspendLayout()
        CType(Me.uipmMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'uicmMain
        '
        Me.uicmMain.BottomRebar = Me.BottomRebar1
        UiCommandCategory1.CategoryName = "Application"
        UiCommandCategory2.CategoryName = "DataManagement"
        UiCommandCategory3.CategoryName = "AnalysisManagement"
        UiCommandCategory4.CategoryName = "ReportingManagement"
        UiCommandCategory5.CategoryName = "RatingAndStatistics"
        UiCommandCategory6.CategoryName = "AnalystManagement"
        Me.uicmMain.Categories.AddRange(New Janus.Windows.UI.CommandBars.UICommandCategory() {UiCommandCategory1, UiCommandCategory2, UiCommandCategory3, UiCommandCategory4, UiCommandCategory5, UiCommandCategory6})
        Me.uicmMain.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.uicmdbarMain})
        Me.uicmMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAPPLICATION, Me.cmdSAVE, Me.cmdPRINT, Me.cmdEXIT, Me.cmdLOOKUPTABLES, Me.cmdSCHOOLGROUP_GROUPS, Me.cmdTOOLS, Me.cmdANALYSISTRACKER, Me.cmdANALYSISPEOPLE, Me.cmdANALYSISREQUESTSTATUS, Me.cmdANALYSISREQUESTTYPE, Me.cmdALTERNATEDESCRIPTORS, Me.cmdDISTRIBUTIONS, Me.cmdDatasourceMaxPaidDate, Me.cmdSCHOOLGROUPASSIGNMENTS, Me.cmdSCHOOLGROUPASSIGNMENTTYPES, Me.cmdPROCEDURESCHEDULE, Me.cmdDatasources, Me.cmdBENEFITMAPPING, Me.cmdAmeribenBenefitMapping, Me.cmdHthBenefitMapping, Me.cmdMooBenefitMapping, Me.cmdPiaBenefitMapping, Me.cmdDataWarehouse, Me.cmdDataWarehouseBenefits, Me.cmdDataWarehouseDiagnoses, Me.cmdDataWarehouseServices, Me.cmdDataWarehouseTypeOfService, Me.cmdDataWarehouseTypeOfServiceCategory, Me.cmdDataWarehouseTypeOfServiceSubCategory, Me.cmdDataWarehouseDiagnosisCategories, Me.cmdDataWarehouseDiagnosisCodeType, Me.cmdAnalysisManagement, Me.cmdMessageQueue, Me.cmdProcessMessageQueue, Me.cmdEditMessageQueue, Me.cmdAmeriben, Me.cmdAmeribenGroupMapping, Me.cmdAggregationSettings, Me.cmdRatingAndAnalysis, Me.cmdMonthlyExperience, Me.cmdReportViewer, Me.cmdReportViewerAvailableReportParameterValues, Me.cmdReportViewerAvailableGroupingItems, Me.cmdHelp, Me.cmdReportViewerUsers, Me.cmdReportViewerRecordFilters, Me.cmdProviderGrouping, Me.cmdREFRESH, Me.cmdANALYSISMILESTONESCHEDULE, Me.cmdANTHEM, Me.cmdEditAnthemMonthlySummaryData, Me.cmdSchoolgroupLogo, Me.cmdHTH, Me.cmdHthGroupMapping, Me.cmdOverlandParkTrizzetoBenefitMapping, Me.cmdAnalysisLogListing, Me.cmdAmeribenNetworkFees, Me.cmdProcessSampleData, Me.cmdDatawarehouseServiceCodeTypes, Me.cmdEsiGroupMapping, Me.cmdRatingStatisticTypes, Me.cmdDataWarehouseBenefitCategories, Me.cmdPersonalInsuranceAdministrators, Me.cmdABISOverlandPark, Me.cmdMutualOfOmaha, Me.cmdSchoolAddressInfo, Me.cmdUnderwriters, Me.cmdAnalysisPeoplePersonType, Me.cmdExpressScripts, Me.cmdClaremontTagMapping, Me.cmdLineOfBusiness, Me.cmdLineOfBusinessCategories, Me.cmdSchoolgroupLineOfBusiness, Me.cmdMarketingDb, Me.cmdMarketingDbSchoolgroupMapping, Me.cmdAetna, Me.cmdAetnaGroupMapping, Me.cmdGeneralStatistics, Me.cmdGeneralStatisticsDevelopment, Me.cmdGeneralStatisticsCategories, Me.cmdProcedureScheduleEdit, Me.cmdProcedureScheduleRecurrence, Me.cmdProcedureScheduleRecurrenceTypes, Me.cmdOverlandParkEnrollmentActivity, Me.cmdOverlandParkGroups, Me.cmdOverlandParkGroupMapping, Me.cmdOverlandParkBTSBenefitMapping, Me.ReportingManagement, Me.cmdAetnaBenefitMapping, Me.cmdAetnaBenefitTypes, Me.cmdAetnaPlaceOfServiceCodes, Me.cmdExportToExcel, Me.cmdEventLogDetails, Me.cmdHTHReprocessData, Me.cmdAmeribenProcessData, Me.cmdAnthemProcessData, Me.cmdMOOProcessData, Me.cmdMOOImportFile})
        Me.uicmMain.ContainerControl = Me
        Me.uicmMain.Id = New System.Guid("461688e0-318c-4020-83c8-ad948dec15eb")
        Me.uicmMain.LayoutStream = CType(resources.GetObject("uicmMain.LayoutStream"), System.IO.Stream)
        Me.uicmMain.LeftRebar = Me.LeftRebar1
        Me.uicmMain.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.uicmMain.RightRebar = Me.RightRebar1
        Me.uicmMain.TopRebar = Me.TopRebar1
        Me.uicmMain.VisualStyleManager = Me.vsmMain
        '
        'BottomRebar1
        '
        Me.BottomRebar1.CommandManager = Me.uicmMain
        Me.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomRebar1.Location = New System.Drawing.Point(0, 586)
        Me.BottomRebar1.Name = "BottomRebar1"
        Me.BottomRebar1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BottomRebar1.Size = New System.Drawing.Size(754, 0)
        '
        'uicmdbarMain
        '
        Me.uicmdbarMain.AllowClose = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uicmdbarMain.AllowCustomize = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uicmdbarMain.CommandBarType = Janus.Windows.UI.CommandBars.CommandBarType.Menu
        Me.uicmdbarMain.CommandManager = Me.uicmMain
        Me.uicmdbarMain.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAPPLICATION1, Me.cmdDataWarehouse1, Me.cmdAnalysisManagement1, Me.ReportingManagement1, Me.cmdGeneralStatistics1, Me.cmdHelp1})
        Me.uicmdbarMain.Key = "cmdbarMain"
        Me.uicmdbarMain.Location = New System.Drawing.Point(0, 0)
        Me.uicmdbarMain.LockCommandBar = Janus.Windows.UI.InheritableBoolean.[True]
        Me.uicmdbarMain.Name = "uicmdbarMain"
        Me.uicmdbarMain.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.uicmdbarMain.RowIndex = 0
        Me.uicmdbarMain.Size = New System.Drawing.Size(1358, 22)
        Me.uicmdbarMain.Text = "Main Menu"
        '
        'cmdAPPLICATION1
        '
        Me.cmdAPPLICATION1.Key = "cmdAPPLICATION"
        Me.cmdAPPLICATION1.Name = "cmdAPPLICATION1"
        '
        'cmdDataWarehouse1
        '
        Me.cmdDataWarehouse1.Key = "cmdDataWarehouse"
        Me.cmdDataWarehouse1.Name = "cmdDataWarehouse1"
        Me.cmdDataWarehouse1.Text = "Data Managment"
        '
        'cmdAnalysisManagement1
        '
        Me.cmdAnalysisManagement1.Key = "cmdAnalysisManagement"
        Me.cmdAnalysisManagement1.Name = "cmdAnalysisManagement1"
        '
        'ReportingManagement1
        '
        Me.ReportingManagement1.Key = "ReportingManagement"
        Me.ReportingManagement1.Name = "ReportingManagement1"
        '
        'cmdGeneralStatistics1
        '
        Me.cmdGeneralStatistics1.Key = "cmdGeneralStatistics"
        Me.cmdGeneralStatistics1.Name = "cmdGeneralStatistics1"
        '
        'cmdHelp1
        '
        Me.cmdHelp1.Key = "cmdHelp"
        Me.cmdHelp1.Name = "cmdHelp1"
        Me.cmdHelp1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'cmdAPPLICATION
        '
        Me.cmdAPPLICATION.CategoryName = "Application"
        Me.cmdAPPLICATION.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdREFRESH1, Me.cmdSAVE1, Me.cmdExportToExcel1, Me.Separator1, Me.cmdEXIT1})
        Me.cmdAPPLICATION.Key = "cmdAPPLICATION"
        Me.cmdAPPLICATION.Name = "cmdAPPLICATION"
        Me.cmdAPPLICATION.Text = "Application"
        '
        'cmdREFRESH1
        '
        Me.cmdREFRESH1.Key = "cmdREFRESH"
        Me.cmdREFRESH1.Name = "cmdREFRESH1"
        '
        'cmdSAVE1
        '
        Me.cmdSAVE1.Key = "cmdSAVE"
        Me.cmdSAVE1.Name = "cmdSAVE1"
        '
        'cmdExportToExcel1
        '
        Me.cmdExportToExcel1.Key = "cmdExportToExcel"
        Me.cmdExportToExcel1.Name = "cmdExportToExcel1"
        Me.cmdExportToExcel1.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        '
        'Separator1
        '
        Me.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator1.Key = "Separator"
        Me.Separator1.Name = "Separator1"
        '
        'cmdEXIT1
        '
        Me.cmdEXIT1.Key = "cmdEXIT"
        Me.cmdEXIT1.Name = "cmdEXIT1"
        '
        'cmdSAVE
        '
        Me.cmdSAVE.CategoryName = "Application"
        Me.cmdSAVE.Key = "cmdSAVE"
        Me.cmdSAVE.Name = "cmdSAVE"
        Me.cmdSAVE.Shortcut = System.Windows.Forms.Shortcut.CtrlS
        Me.cmdSAVE.Text = "Save"
        '
        'cmdPRINT
        '
        Me.cmdPRINT.CategoryName = "Application"
        Me.cmdPRINT.Key = "cmdPRINT"
        Me.cmdPRINT.Name = "cmdPRINT"
        Me.cmdPRINT.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.cmdPRINT.Text = "Print"
        '
        'cmdEXIT
        '
        Me.cmdEXIT.Key = "cmdEXIT"
        Me.cmdEXIT.Name = "cmdEXIT"
        Me.cmdEXIT.Shortcut = System.Windows.Forms.Shortcut.AltF4
        Me.cmdEXIT.Text = "Exit"
        '
        'cmdLOOKUPTABLES
        '
        Me.cmdLOOKUPTABLES.CategoryName = "DataManagement"
        Me.cmdLOOKUPTABLES.Key = "cmdLOOKUPTABLES"
        Me.cmdLOOKUPTABLES.Name = "cmdLOOKUPTABLES"
        Me.cmdLOOKUPTABLES.Text = "Lookup Tables"
        '
        'cmdSCHOOLGROUP_GROUPS
        '
        Me.cmdSCHOOLGROUP_GROUPS.CategoryName = "ReportingManagement"
        Me.cmdSCHOOLGROUP_GROUPS.Key = "cmdSCHOOLGROUP_GROUPS"
        Me.cmdSCHOOLGROUP_GROUPS.Name = "cmdSCHOOLGROUP_GROUPS"
        Me.cmdSCHOOLGROUP_GROUPS.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftS
        Me.cmdSCHOOLGROUP_GROUPS.Text = "Schoolgroup Groups"
        '
        'cmdTOOLS
        '
        Me.cmdTOOLS.CategoryName = "Application"
        Me.cmdTOOLS.Key = "cmdTOOLS"
        Me.cmdTOOLS.Name = "cmdTOOLS"
        Me.cmdTOOLS.Text = "Tools"
        '
        'cmdANALYSISTRACKER
        '
        Me.cmdANALYSISTRACKER.CategoryName = "AnalysisManagement"
        Me.cmdANALYSISTRACKER.Key = "cmdANALYSISTRACKER"
        Me.cmdANALYSISTRACKER.Name = "cmdANALYSISTRACKER"
        Me.cmdANALYSISTRACKER.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftT
        Me.cmdANALYSISTRACKER.Text = "Analysis Tracker"
        '
        'cmdANALYSISPEOPLE
        '
        Me.cmdANALYSISPEOPLE.CategoryName = "DataManagement"
        Me.cmdANALYSISPEOPLE.Key = "cmdANALYSISPEOPLE"
        Me.cmdANALYSISPEOPLE.Name = "cmdANALYSISPEOPLE"
        Me.cmdANALYSISPEOPLE.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftP
        Me.cmdANALYSISPEOPLE.Text = "Analysis People"
        '
        'cmdANALYSISREQUESTSTATUS
        '
        Me.cmdANALYSISREQUESTSTATUS.CategoryName = "DataManagement"
        Me.cmdANALYSISREQUESTSTATUS.Key = "cmdANALYSISREQUESTSTATUS"
        Me.cmdANALYSISREQUESTSTATUS.Name = "cmdANALYSISREQUESTSTATUS"
        Me.cmdANALYSISREQUESTSTATUS.Text = "Analysis Request Status"
        '
        'cmdANALYSISREQUESTTYPE
        '
        Me.cmdANALYSISREQUESTTYPE.CategoryName = "DataManagement"
        Me.cmdANALYSISREQUESTTYPE.Key = "cmdANALYSISREQUESTTYPE"
        Me.cmdANALYSISREQUESTTYPE.Name = "cmdANALYSISREQUESTTYPE"
        Me.cmdANALYSISREQUESTTYPE.Text = "Analysis Request Types"
        '
        'cmdALTERNATEDESCRIPTORS
        '
        Me.cmdALTERNATEDESCRIPTORS.CategoryName = "DataManagement"
        Me.cmdALTERNATEDESCRIPTORS.Key = "cmdALTERNATEDESCRIPTORS"
        Me.cmdALTERNATEDESCRIPTORS.Name = "cmdALTERNATEDESCRIPTORS"
        Me.cmdALTERNATEDESCRIPTORS.Text = "Alternate Descriptors"
        '
        'cmdDISTRIBUTIONS
        '
        Me.cmdDISTRIBUTIONS.CategoryName = "DataManagement"
        Me.cmdDISTRIBUTIONS.Key = "cmdDISTRIBUTIONS"
        Me.cmdDISTRIBUTIONS.Name = "cmdDISTRIBUTIONS"
        Me.cmdDISTRIBUTIONS.Text = "Custom Distributions"
        '
        'cmdDatasourceMaxPaidDate
        '
        Me.cmdDatasourceMaxPaidDate.CategoryName = "DataManagement"
        Me.cmdDatasourceMaxPaidDate.Key = "cmdDatasourceMaxPaidDate"
        Me.cmdDatasourceMaxPaidDate.Name = "cmdDatasourceMaxPaidDate"
        Me.cmdDatasourceMaxPaidDate.Text = "Data Source Max Paid Date"
        '
        'cmdSCHOOLGROUPASSIGNMENTS
        '
        Me.cmdSCHOOLGROUPASSIGNMENTS.CategoryName = "DataManagement"
        Me.cmdSCHOOLGROUPASSIGNMENTS.Key = "cmdSCHOOLGROUPASSIGNMENTS"
        Me.cmdSCHOOLGROUPASSIGNMENTS.Name = "cmdSCHOOLGROUPASSIGNMENTS"
        Me.cmdSCHOOLGROUPASSIGNMENTS.Text = "Schoolgroup Assignments"
        '
        'cmdSCHOOLGROUPASSIGNMENTTYPES
        '
        Me.cmdSCHOOLGROUPASSIGNMENTTYPES.CategoryName = "DataManagement"
        Me.cmdSCHOOLGROUPASSIGNMENTTYPES.Key = "cmdSCHOOLGROUPASSIGNMENTTYPES"
        Me.cmdSCHOOLGROUPASSIGNMENTTYPES.Name = "cmdSCHOOLGROUPASSIGNMENTTYPES"
        Me.cmdSCHOOLGROUPASSIGNMENTTYPES.Text = "Schoolgroup Assignment Types"
        '
        'cmdPROCEDURESCHEDULE
        '
        Me.cmdPROCEDURESCHEDULE.CategoryName = "DataManagement"
        Me.cmdPROCEDURESCHEDULE.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdProcedureScheduleEdit1, Me.cmdProcedureScheduleRecurrence1, Me.cmdProcedureScheduleRecurrenceTypes1})
        Me.cmdPROCEDURESCHEDULE.Key = "cmdPROCEDURESCHEDULE"
        Me.cmdPROCEDURESCHEDULE.Name = "cmdPROCEDURESCHEDULE"
        Me.cmdPROCEDURESCHEDULE.Text = "Procedure Schedule"
        '
        'cmdProcedureScheduleEdit1
        '
        Me.cmdProcedureScheduleEdit1.Key = "cmdProcedureScheduleEdit"
        Me.cmdProcedureScheduleEdit1.Name = "cmdProcedureScheduleEdit1"
        '
        'cmdProcedureScheduleRecurrence1
        '
        Me.cmdProcedureScheduleRecurrence1.Key = "cmdProcedureScheduleRecurrence"
        Me.cmdProcedureScheduleRecurrence1.Name = "cmdProcedureScheduleRecurrence1"
        '
        'cmdProcedureScheduleRecurrenceTypes1
        '
        Me.cmdProcedureScheduleRecurrenceTypes1.Key = "cmdProcedureScheduleRecurrenceTypes"
        Me.cmdProcedureScheduleRecurrenceTypes1.Name = "cmdProcedureScheduleRecurrenceTypes1"
        '
        'cmdDatasources
        '
        Me.cmdDatasources.CategoryName = "DataManagement"
        Me.cmdDatasources.Key = "cmdDatasources"
        Me.cmdDatasources.Name = "cmdDatasources"
        Me.cmdDatasources.Text = "Datasources"
        '
        'cmdBENEFITMAPPING
        '
        Me.cmdBENEFITMAPPING.CategoryName = "DataManagement"
        Me.cmdBENEFITMAPPING.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAmeribenBenefitMapping1, Me.cmdHthBenefitMapping1, Me.cmdMooBenefitMapping1, Me.cmdPiaBenefitMapping1, Me.cmdOverlandParkTrizzetoBenefitMapping1})
        Me.cmdBENEFITMAPPING.Key = "cmdBENEFITMAPPING"
        Me.cmdBENEFITMAPPING.Name = "cmdBENEFITMAPPING"
        Me.cmdBENEFITMAPPING.Text = "Benefit Mapping"
        '
        'cmdAmeribenBenefitMapping1
        '
        Me.cmdAmeribenBenefitMapping1.Key = "cmdAmeribenBenefitMapping"
        Me.cmdAmeribenBenefitMapping1.Name = "cmdAmeribenBenefitMapping1"
        '
        'cmdHthBenefitMapping1
        '
        Me.cmdHthBenefitMapping1.Key = "cmdHthBenefitMapping"
        Me.cmdHthBenefitMapping1.Name = "cmdHthBenefitMapping1"
        '
        'cmdMooBenefitMapping1
        '
        Me.cmdMooBenefitMapping1.Key = "cmdMooBenefitMapping"
        Me.cmdMooBenefitMapping1.Name = "cmdMooBenefitMapping1"
        '
        'cmdPiaBenefitMapping1
        '
        Me.cmdPiaBenefitMapping1.Key = "cmdPiaBenefitMapping"
        Me.cmdPiaBenefitMapping1.Name = "cmdPiaBenefitMapping1"
        '
        'cmdOverlandParkTrizzetoBenefitMapping1
        '
        Me.cmdOverlandParkTrizzetoBenefitMapping1.Key = "cmdOverlandParkTrizzetoBenefitMapping"
        Me.cmdOverlandParkTrizzetoBenefitMapping1.Name = "cmdOverlandParkTrizzetoBenefitMapping1"
        '
        'cmdAmeribenBenefitMapping
        '
        Me.cmdAmeribenBenefitMapping.CategoryName = "DataManagement"
        Me.cmdAmeribenBenefitMapping.Key = "cmdAmeribenBenefitMapping"
        Me.cmdAmeribenBenefitMapping.Name = "cmdAmeribenBenefitMapping"
        Me.cmdAmeribenBenefitMapping.Text = "Ameriben Benefit Mapping"
        '
        'cmdHthBenefitMapping
        '
        Me.cmdHthBenefitMapping.CategoryName = "DataManagement"
        Me.cmdHthBenefitMapping.Key = "cmdHthBenefitMapping"
        Me.cmdHthBenefitMapping.Name = "cmdHthBenefitMapping"
        Me.cmdHthBenefitMapping.Text = "HTH Benefit Mapping"
        '
        'cmdMooBenefitMapping
        '
        Me.cmdMooBenefitMapping.CategoryName = "DataManagement"
        Me.cmdMooBenefitMapping.Key = "cmdMooBenefitMapping"
        Me.cmdMooBenefitMapping.Name = "cmdMooBenefitMapping"
        Me.cmdMooBenefitMapping.Text = "MOO Benefit Mapping"
        '
        'cmdPiaBenefitMapping
        '
        Me.cmdPiaBenefitMapping.CategoryName = "DataManagement"
        Me.cmdPiaBenefitMapping.Key = "cmdPiaBenefitMapping"
        Me.cmdPiaBenefitMapping.Name = "cmdPiaBenefitMapping"
        Me.cmdPiaBenefitMapping.Text = "PIA Benefit Mapping"
        '
        'cmdDataWarehouse
        '
        Me.cmdDataWarehouse.CategoryName = "DataManagement"
        Me.cmdDataWarehouse.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdPROCEDURESCHEDULE1, Me.cmdEventLogDetails1, Me.cmdAggregationSettings1, Me.cmdMessageQueue1, Me.Separator13, Me.cmdDatasources2, Me.cmdDatasourceMaxPaidDate1, Me.cmdUnderwriters1, Me.Separator10, Me.cmdDataWarehouseDiagnoses1, Me.cmdDataWarehouseDiagnosisCategories1, Me.cmdDataWarehouseDiagnosisCodeType1, Me.Separator7, Me.cmdDataWarehouseServices1, Me.cmdServiceCodeTypes1, Me.cmdDataWarehouseTypeOfService1, Me.cmdDataWarehouseTypeOfServiceCategory1, Me.cmdDataWarehouseTypeOfServiceSubCategory1, Me.Separator6, Me.cmdDataWarehouseBenefits1, Me.cmdBenefitCategoriesEditor1, Me.Separator14, Me.cmdLineOfBusiness1, Me.cmdLineOfBusinessCategories1, Me.cmdSchoolgroupLineOfBusiness1, Me.Separator11, Me.cmdABISOverlandPark1, Me.cmdAetna1, Me.cmdAmeriben1, Me.cmdANTHEM1, Me.cmdHTH1, Me.cmdMutualOfOmaha1, Me.cmdPersonalInsuranceAdministrators1, Me.cmdExpressScripts1, Me.cmdMarketingDb1, Me.Separator9, Me.cmdALTERNATEDESCRIPTORS1, Me.cmdProcessSampleData2, Me.cmdClaremontTagMapping1})
        Me.cmdDataWarehouse.Key = "cmdDataWarehouse"
        Me.cmdDataWarehouse.Name = "cmdDataWarehouse"
        Me.cmdDataWarehouse.Text = "Data Warehouse"
        '
        'cmdPROCEDURESCHEDULE1
        '
        Me.cmdPROCEDURESCHEDULE1.Key = "cmdPROCEDURESCHEDULE"
        Me.cmdPROCEDURESCHEDULE1.Name = "cmdPROCEDURESCHEDULE1"
        '
        'cmdEventLogDetails1
        '
        Me.cmdEventLogDetails1.Key = "cmdEventLogDetails"
        Me.cmdEventLogDetails1.Name = "cmdEventLogDetails1"
        '
        'cmdAggregationSettings1
        '
        Me.cmdAggregationSettings1.Key = "cmdAggregationSettings"
        Me.cmdAggregationSettings1.Name = "cmdAggregationSettings1"
        '
        'cmdMessageQueue1
        '
        Me.cmdMessageQueue1.Key = "cmdMessageQueue"
        Me.cmdMessageQueue1.Name = "cmdMessageQueue1"
        '
        'Separator13
        '
        Me.Separator13.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator13.Key = "Separator"
        Me.Separator13.Name = "Separator13"
        '
        'cmdDatasources2
        '
        Me.cmdDatasources2.Key = "cmdDatasources"
        Me.cmdDatasources2.Name = "cmdDatasources2"
        '
        'cmdDatasourceMaxPaidDate1
        '
        Me.cmdDatasourceMaxPaidDate1.Key = "cmdDatasourceMaxPaidDate"
        Me.cmdDatasourceMaxPaidDate1.Name = "cmdDatasourceMaxPaidDate1"
        '
        'cmdUnderwriters1
        '
        Me.cmdUnderwriters1.Key = "cmdUnderwriters"
        Me.cmdUnderwriters1.Name = "cmdUnderwriters1"
        Me.cmdUnderwriters1.Visible = Janus.Windows.UI.InheritableBoolean.[False]
        '
        'Separator10
        '
        Me.Separator10.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator10.Key = "Separator"
        Me.Separator10.Name = "Separator10"
        '
        'cmdDataWarehouseDiagnoses1
        '
        Me.cmdDataWarehouseDiagnoses1.Key = "cmdDataWarehouseDiagnoses"
        Me.cmdDataWarehouseDiagnoses1.Name = "cmdDataWarehouseDiagnoses1"
        '
        'cmdDataWarehouseDiagnosisCategories1
        '
        Me.cmdDataWarehouseDiagnosisCategories1.Key = "cmdDataWarehouseDiagnosisCategories"
        Me.cmdDataWarehouseDiagnosisCategories1.Name = "cmdDataWarehouseDiagnosisCategories1"
        Me.cmdDataWarehouseDiagnosisCategories1.Text = "Diagnosis Categories Editor"
        '
        'cmdDataWarehouseDiagnosisCodeType1
        '
        Me.cmdDataWarehouseDiagnosisCodeType1.Key = "cmdDataWarehouseDiagnosisCodeType"
        Me.cmdDataWarehouseDiagnosisCodeType1.Name = "cmdDataWarehouseDiagnosisCodeType1"
        '
        'Separator7
        '
        Me.Separator7.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator7.Key = "Separator"
        Me.Separator7.Name = "Separator7"
        '
        'cmdDataWarehouseServices1
        '
        Me.cmdDataWarehouseServices1.Key = "cmdDataWarehouseServices"
        Me.cmdDataWarehouseServices1.Name = "cmdDataWarehouseServices1"
        '
        'cmdServiceCodeTypes1
        '
        Me.cmdServiceCodeTypes1.Key = "cmdDatawarehouseServiceCodeTypes"
        Me.cmdServiceCodeTypes1.Name = "cmdServiceCodeTypes1"
        '
        'cmdDataWarehouseTypeOfService1
        '
        Me.cmdDataWarehouseTypeOfService1.Key = "cmdDataWarehouseTypeOfService"
        Me.cmdDataWarehouseTypeOfService1.Name = "cmdDataWarehouseTypeOfService1"
        '
        'cmdDataWarehouseTypeOfServiceCategory1
        '
        Me.cmdDataWarehouseTypeOfServiceCategory1.Key = "cmdDataWarehouseTypeOfServiceCategory"
        Me.cmdDataWarehouseTypeOfServiceCategory1.Name = "cmdDataWarehouseTypeOfServiceCategory1"
        '
        'cmdDataWarehouseTypeOfServiceSubCategory1
        '
        Me.cmdDataWarehouseTypeOfServiceSubCategory1.Key = "cmdDataWarehouseTypeOfServiceSubCategory"
        Me.cmdDataWarehouseTypeOfServiceSubCategory1.Name = "cmdDataWarehouseTypeOfServiceSubCategory1"
        '
        'Separator6
        '
        Me.Separator6.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator6.Key = "Separator"
        Me.Separator6.Name = "Separator6"
        '
        'cmdDataWarehouseBenefits1
        '
        Me.cmdDataWarehouseBenefits1.Key = "cmdDataWarehouseBenefits"
        Me.cmdDataWarehouseBenefits1.Name = "cmdDataWarehouseBenefits1"
        '
        'cmdBenefitCategoriesEditor1
        '
        Me.cmdBenefitCategoriesEditor1.Key = "cmdBenefitCategoriesEditor"
        Me.cmdBenefitCategoriesEditor1.Name = "cmdBenefitCategoriesEditor1"
        '
        'Separator14
        '
        Me.Separator14.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator14.Key = "Separator"
        Me.Separator14.Name = "Separator14"
        '
        'cmdLineOfBusiness1
        '
        Me.cmdLineOfBusiness1.Key = "cmdLineOfBusiness"
        Me.cmdLineOfBusiness1.Name = "cmdLineOfBusiness1"
        '
        'cmdLineOfBusinessCategories1
        '
        Me.cmdLineOfBusinessCategories1.Key = "cmdLineOfBusinessCategories"
        Me.cmdLineOfBusinessCategories1.Name = "cmdLineOfBusinessCategories1"
        '
        'cmdSchoolgroupLineOfBusiness1
        '
        Me.cmdSchoolgroupLineOfBusiness1.Key = "cmdSchoolgroupLineOfBusiness"
        Me.cmdSchoolgroupLineOfBusiness1.Name = "cmdSchoolgroupLineOfBusiness1"
        '
        'Separator11
        '
        Me.Separator11.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator11.Key = "Separator"
        Me.Separator11.Name = "Separator11"
        '
        'cmdABISOverlandPark1
        '
        Me.cmdABISOverlandPark1.Key = "cmdABISOverlandPark"
        Me.cmdABISOverlandPark1.Name = "cmdABISOverlandPark1"
        '
        'cmdAetna1
        '
        Me.cmdAetna1.Key = "cmdAetna"
        Me.cmdAetna1.Name = "cmdAetna1"
        '
        'cmdAmeriben1
        '
        Me.cmdAmeriben1.Key = "cmdAmeriben"
        Me.cmdAmeriben1.Name = "cmdAmeriben1"
        '
        'cmdANTHEM1
        '
        Me.cmdANTHEM1.Key = "cmdANTHEM"
        Me.cmdANTHEM1.Name = "cmdANTHEM1"
        '
        'cmdHTH1
        '
        Me.cmdHTH1.Key = "cmdHTH"
        Me.cmdHTH1.Name = "cmdHTH1"
        '
        'cmdMutualOfOmaha1
        '
        Me.cmdMutualOfOmaha1.Key = "cmdMutualOfOmaha"
        Me.cmdMutualOfOmaha1.Name = "cmdMutualOfOmaha1"
        '
        'cmdPersonalInsuranceAdministrators1
        '
        Me.cmdPersonalInsuranceAdministrators1.Key = "cmdPersonalInsuranceAdministrators"
        Me.cmdPersonalInsuranceAdministrators1.Name = "cmdPersonalInsuranceAdministrators1"
        '
        'cmdExpressScripts1
        '
        Me.cmdExpressScripts1.Key = "cmdExpressScripts"
        Me.cmdExpressScripts1.Name = "cmdExpressScripts1"
        '
        'cmdMarketingDb1
        '
        Me.cmdMarketingDb1.Key = "cmdMarketingDb"
        Me.cmdMarketingDb1.Name = "cmdMarketingDb1"
        '
        'Separator9
        '
        Me.Separator9.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator9.Key = "Separator"
        Me.Separator9.Name = "Separator9"
        '
        'cmdALTERNATEDESCRIPTORS1
        '
        Me.cmdALTERNATEDESCRIPTORS1.Key = "cmdALTERNATEDESCRIPTORS"
        Me.cmdALTERNATEDESCRIPTORS1.Name = "cmdALTERNATEDESCRIPTORS1"
        '
        'cmdProcessSampleData2
        '
        Me.cmdProcessSampleData2.Key = "cmdProcessSampleData"
        Me.cmdProcessSampleData2.Name = "cmdProcessSampleData2"
        '
        'cmdClaremontTagMapping1
        '
        Me.cmdClaremontTagMapping1.Key = "cmdClaremontTagMapping"
        Me.cmdClaremontTagMapping1.Name = "cmdClaremontTagMapping1"
        '
        'cmdDataWarehouseBenefits
        '
        Me.cmdDataWarehouseBenefits.CategoryName = "DataManagement"
        Me.cmdDataWarehouseBenefits.Key = "cmdDataWarehouseBenefits"
        Me.cmdDataWarehouseBenefits.Name = "cmdDataWarehouseBenefits"
        Me.cmdDataWarehouseBenefits.Text = "Benefit Editor"
        '
        'cmdDataWarehouseDiagnoses
        '
        Me.cmdDataWarehouseDiagnoses.CategoryName = "DataManagement"
        Me.cmdDataWarehouseDiagnoses.Key = "cmdDataWarehouseDiagnoses"
        Me.cmdDataWarehouseDiagnoses.Name = "cmdDataWarehouseDiagnoses"
        Me.cmdDataWarehouseDiagnoses.Text = "Diagnoses Editor"
        '
        'cmdDataWarehouseServices
        '
        Me.cmdDataWarehouseServices.CategoryName = "DataManagement"
        Me.cmdDataWarehouseServices.Key = "cmdDataWarehouseServices"
        Me.cmdDataWarehouseServices.Name = "cmdDataWarehouseServices"
        Me.cmdDataWarehouseServices.Text = "Services Editor"
        '
        'cmdDataWarehouseTypeOfService
        '
        Me.cmdDataWarehouseTypeOfService.CategoryName = "DataManagement"
        Me.cmdDataWarehouseTypeOfService.Key = "cmdDataWarehouseTypeOfService"
        Me.cmdDataWarehouseTypeOfService.Name = "cmdDataWarehouseTypeOfService"
        Me.cmdDataWarehouseTypeOfService.Text = "Type Of Service"
        '
        'cmdDataWarehouseTypeOfServiceCategory
        '
        Me.cmdDataWarehouseTypeOfServiceCategory.CategoryName = "DataManagement"
        Me.cmdDataWarehouseTypeOfServiceCategory.Key = "cmdDataWarehouseTypeOfServiceCategory"
        Me.cmdDataWarehouseTypeOfServiceCategory.Name = "cmdDataWarehouseTypeOfServiceCategory"
        Me.cmdDataWarehouseTypeOfServiceCategory.Text = "Type Of Service Category"
        '
        'cmdDataWarehouseTypeOfServiceSubCategory
        '
        Me.cmdDataWarehouseTypeOfServiceSubCategory.CategoryName = "DataManagement"
        Me.cmdDataWarehouseTypeOfServiceSubCategory.Key = "cmdDataWarehouseTypeOfServiceSubCategory"
        Me.cmdDataWarehouseTypeOfServiceSubCategory.Name = "cmdDataWarehouseTypeOfServiceSubCategory"
        Me.cmdDataWarehouseTypeOfServiceSubCategory.Text = "Type Of Service Sub Category"
        '
        'cmdDataWarehouseDiagnosisCategories
        '
        Me.cmdDataWarehouseDiagnosisCategories.CategoryName = "DataManagement"
        Me.cmdDataWarehouseDiagnosisCategories.Key = "cmdDataWarehouseDiagnosisCategories"
        Me.cmdDataWarehouseDiagnosisCategories.Name = "cmdDataWarehouseDiagnosisCategories"
        Me.cmdDataWarehouseDiagnosisCategories.Text = "Diagnosis Categories"
        '
        'cmdDataWarehouseDiagnosisCodeType
        '
        Me.cmdDataWarehouseDiagnosisCodeType.CategoryName = "DataManagement"
        Me.cmdDataWarehouseDiagnosisCodeType.Key = "cmdDataWarehouseDiagnosisCodeType"
        Me.cmdDataWarehouseDiagnosisCodeType.Name = "cmdDataWarehouseDiagnosisCodeType"
        Me.cmdDataWarehouseDiagnosisCodeType.Text = "Diagnosis Code Types"
        '
        'cmdAnalysisManagement
        '
        Me.cmdAnalysisManagement.CategoryName = "AnalysisManagement"
        Me.cmdAnalysisManagement.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdANALYSISTRACKER2, Me.cmdAnalysisLogListing1, Me.cmdANALYSISMILESTONESCHEDULE1, Me.cmdANALYSISREQUESTSTATUS2, Me.cmdANALYSISREQUESTTYPE2, Me.Separator5, Me.cmdANALYSISPEOPLE2, Me.cmdAnalysisPeoplePersonType1})
        Me.cmdAnalysisManagement.Key = "cmdAnalysisManagement"
        Me.cmdAnalysisManagement.Name = "cmdAnalysisManagement"
        Me.cmdAnalysisManagement.Text = "Analysis Management"
        '
        'cmdANALYSISTRACKER2
        '
        Me.cmdANALYSISTRACKER2.Key = "cmdANALYSISTRACKER"
        Me.cmdANALYSISTRACKER2.Name = "cmdANALYSISTRACKER2"
        Me.cmdANALYSISTRACKER2.Text = "Analysis Tracking"
        '
        'cmdAnalysisLogListing1
        '
        Me.cmdAnalysisLogListing1.Key = "cmdAnalysisLogListing"
        Me.cmdAnalysisLogListing1.Name = "cmdAnalysisLogListing1"
        '
        'cmdANALYSISMILESTONESCHEDULE1
        '
        Me.cmdANALYSISMILESTONESCHEDULE1.Key = "cmdANALYSISMILESTONESCHEDULE"
        Me.cmdANALYSISMILESTONESCHEDULE1.Name = "cmdANALYSISMILESTONESCHEDULE1"
        '
        'cmdANALYSISREQUESTSTATUS2
        '
        Me.cmdANALYSISREQUESTSTATUS2.Key = "cmdANALYSISREQUESTSTATUS"
        Me.cmdANALYSISREQUESTSTATUS2.Name = "cmdANALYSISREQUESTSTATUS2"
        '
        'cmdANALYSISREQUESTTYPE2
        '
        Me.cmdANALYSISREQUESTTYPE2.Key = "cmdANALYSISREQUESTTYPE"
        Me.cmdANALYSISREQUESTTYPE2.Name = "cmdANALYSISREQUESTTYPE2"
        '
        'Separator5
        '
        Me.Separator5.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator5.Key = "Separator"
        Me.Separator5.Name = "Separator5"
        '
        'cmdANALYSISPEOPLE2
        '
        Me.cmdANALYSISPEOPLE2.Key = "cmdANALYSISPEOPLE"
        Me.cmdANALYSISPEOPLE2.Name = "cmdANALYSISPEOPLE2"
        '
        'cmdAnalysisPeoplePersonType1
        '
        Me.cmdAnalysisPeoplePersonType1.Key = "cmdAnalysisPeoplePersonType"
        Me.cmdAnalysisPeoplePersonType1.Name = "cmdAnalysisPeoplePersonType1"
        '
        'cmdMessageQueue
        '
        Me.cmdMessageQueue.CategoryName = "DataManagement"
        Me.cmdMessageQueue.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdEditMessageQueue1, Me.cmdProcessMessageQueue1})
        Me.cmdMessageQueue.Key = "cmdMessageQueue"
        Me.cmdMessageQueue.Name = "cmdMessageQueue"
        Me.cmdMessageQueue.Text = "Message Queue"
        '
        'cmdEditMessageQueue1
        '
        Me.cmdEditMessageQueue1.Key = "cmdEditMessageQueue"
        Me.cmdEditMessageQueue1.Name = "cmdEditMessageQueue1"
        '
        'cmdProcessMessageQueue1
        '
        Me.cmdProcessMessageQueue1.Key = "cmdProcessMessageQueue"
        Me.cmdProcessMessageQueue1.Name = "cmdProcessMessageQueue1"
        '
        'cmdProcessMessageQueue
        '
        Me.cmdProcessMessageQueue.CategoryName = "DataManagement"
        Me.cmdProcessMessageQueue.Key = "cmdProcessMessageQueue"
        Me.cmdProcessMessageQueue.Name = "cmdProcessMessageQueue"
        Me.cmdProcessMessageQueue.Text = "Process Queue"
        '
        'cmdEditMessageQueue
        '
        Me.cmdEditMessageQueue.CategoryName = "DataManagement"
        Me.cmdEditMessageQueue.Key = "cmdEditMessageQueue"
        Me.cmdEditMessageQueue.Name = "cmdEditMessageQueue"
        Me.cmdEditMessageQueue.Text = "Edit Message Queue"
        '
        'cmdAmeriben
        '
        Me.cmdAmeriben.CategoryName = "DataManagement"
        Me.cmdAmeriben.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAmeribenBenefitMapping2, Me.cmdAmeribenGroupMapping1, Me.cmdAmeribenNetworkFees1, Me.Separator8, Me.cmdAmeribenProcessData1})
        Me.cmdAmeriben.Key = "cmdAmeriben"
        Me.cmdAmeriben.Name = "cmdAmeriben"
        Me.cmdAmeriben.Text = "Ameriben"
        '
        'cmdAmeribenBenefitMapping2
        '
        Me.cmdAmeribenBenefitMapping2.Key = "cmdAmeribenBenefitMapping"
        Me.cmdAmeribenBenefitMapping2.Name = "cmdAmeribenBenefitMapping2"
        Me.cmdAmeribenBenefitMapping2.Text = "Benefit Mapping"
        '
        'cmdAmeribenGroupMapping1
        '
        Me.cmdAmeribenGroupMapping1.Key = "cmdAmeribenGroupMapping"
        Me.cmdAmeribenGroupMapping1.Name = "cmdAmeribenGroupMapping1"
        '
        'cmdAmeribenNetworkFees1
        '
        Me.cmdAmeribenNetworkFees1.Key = "cmdAmeribenNetworkFees"
        Me.cmdAmeribenNetworkFees1.Name = "cmdAmeribenNetworkFees1"
        '
        'Separator8
        '
        Me.Separator8.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator8.Key = "Separator"
        Me.Separator8.Name = "Separator8"
        '
        'cmdAmeribenProcessData1
        '
        Me.cmdAmeribenProcessData1.Key = "cmdAmeribenProcessData"
        Me.cmdAmeribenProcessData1.Name = "cmdAmeribenProcessData1"
        '
        'cmdAmeribenGroupMapping
        '
        Me.cmdAmeribenGroupMapping.CategoryName = "DataManagement"
        Me.cmdAmeribenGroupMapping.Key = "cmdAmeribenGroupMapping"
        Me.cmdAmeribenGroupMapping.Name = "cmdAmeribenGroupMapping"
        Me.cmdAmeribenGroupMapping.Text = "Group Mapping"
        '
        'cmdAggregationSettings
        '
        Me.cmdAggregationSettings.CategoryName = "DataManagement"
        Me.cmdAggregationSettings.Key = "cmdAggregationSettings"
        Me.cmdAggregationSettings.Name = "cmdAggregationSettings"
        Me.cmdAggregationSettings.Text = "Aggregation Settings"
        '
        'cmdRatingAndAnalysis
        '
        Me.cmdRatingAndAnalysis.CategoryName = "AnalysisManagement"
        Me.cmdRatingAndAnalysis.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdMonthlyExperience1, Me.Separator4, Me.cmdRatingStatisticTypes1})
        Me.cmdRatingAndAnalysis.Key = "cmdRatingAndAnalysis"
        Me.cmdRatingAndAnalysis.Name = "cmdRatingAndAnalysis"
        Me.cmdRatingAndAnalysis.Text = "Rating And Analysis"
        '
        'cmdMonthlyExperience1
        '
        Me.cmdMonthlyExperience1.Key = "cmdMonthlyExperience"
        Me.cmdMonthlyExperience1.Name = "cmdMonthlyExperience1"
        '
        'Separator4
        '
        Me.Separator4.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator4.Key = "Separator"
        Me.Separator4.Name = "Separator4"
        '
        'cmdRatingStatisticTypes1
        '
        Me.cmdRatingStatisticTypes1.Key = "cmdRatingStatisticTypes"
        Me.cmdRatingStatisticTypes1.Name = "cmdRatingStatisticTypes1"
        '
        'cmdMonthlyExperience
        '
        Me.cmdMonthlyExperience.CategoryName = "DataManagement"
        Me.cmdMonthlyExperience.Key = "cmdMonthlyExperience"
        Me.cmdMonthlyExperience.Name = "cmdMonthlyExperience"
        Me.cmdMonthlyExperience.Text = "Monthly Experience"
        '
        'cmdReportViewer
        '
        Me.cmdReportViewer.CategoryName = "ReportingManagement"
        Me.cmdReportViewer.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdReportViewerAvailableGroupingItems1, Me.cmdReportViewerAvailableReportParameterValues1, Me.cmdReportViewerUsers1, Me.cmdReportViewerRecordFilters1})
        Me.cmdReportViewer.Key = "cmdReportViewer"
        Me.cmdReportViewer.Name = "cmdReportViewer"
        Me.cmdReportViewer.Text = "Report Viewer"
        '
        'cmdReportViewerAvailableGroupingItems1
        '
        Me.cmdReportViewerAvailableGroupingItems1.Key = "cmdReportViewerAvailableGroupingItems"
        Me.cmdReportViewerAvailableGroupingItems1.Name = "cmdReportViewerAvailableGroupingItems1"
        '
        'cmdReportViewerAvailableReportParameterValues1
        '
        Me.cmdReportViewerAvailableReportParameterValues1.Key = "cmdReportViewerAvailableReportParameterValues"
        Me.cmdReportViewerAvailableReportParameterValues1.Name = "cmdReportViewerAvailableReportParameterValues1"
        '
        'cmdReportViewerUsers1
        '
        Me.cmdReportViewerUsers1.Key = "cmdReportViewerUsers"
        Me.cmdReportViewerUsers1.Name = "cmdReportViewerUsers1"
        '
        'cmdReportViewerRecordFilters1
        '
        Me.cmdReportViewerRecordFilters1.Key = "cmdReportViewerRecordFilters"
        Me.cmdReportViewerRecordFilters1.Name = "cmdReportViewerRecordFilters1"
        '
        'cmdReportViewerAvailableReportParameterValues
        '
        Me.cmdReportViewerAvailableReportParameterValues.CategoryName = "ReportingManagement"
        Me.cmdReportViewerAvailableReportParameterValues.Key = "cmdReportViewerAvailableReportParameterValues"
        Me.cmdReportViewerAvailableReportParameterValues.Name = "cmdReportViewerAvailableReportParameterValues"
        Me.cmdReportViewerAvailableReportParameterValues.Text = "Available Report Parameter Values"
        '
        'cmdReportViewerAvailableGroupingItems
        '
        Me.cmdReportViewerAvailableGroupingItems.CategoryName = "ReportingManagement"
        Me.cmdReportViewerAvailableGroupingItems.Key = "cmdReportViewerAvailableGroupingItems"
        Me.cmdReportViewerAvailableGroupingItems.Name = "cmdReportViewerAvailableGroupingItems"
        Me.cmdReportViewerAvailableGroupingItems.Text = "Available Grouping Items"
        '
        'cmdHelp
        '
        Me.cmdHelp.CategoryName = "Application"
        Me.cmdHelp.Key = "cmdHelp"
        Me.cmdHelp.Name = "cmdHelp"
        Me.cmdHelp.Text = "Help"
        '
        'cmdReportViewerUsers
        '
        Me.cmdReportViewerUsers.CategoryName = "ReportingManagement"
        Me.cmdReportViewerUsers.Key = "cmdReportViewerUsers"
        Me.cmdReportViewerUsers.Name = "cmdReportViewerUsers"
        Me.cmdReportViewerUsers.Text = "Users"
        '
        'cmdReportViewerRecordFilters
        '
        Me.cmdReportViewerRecordFilters.CategoryName = "ReportingManagement"
        Me.cmdReportViewerRecordFilters.Key = "cmdReportViewerRecordFilters"
        Me.cmdReportViewerRecordFilters.Name = "cmdReportViewerRecordFilters"
        Me.cmdReportViewerRecordFilters.Text = "Record Filters"
        '
        'cmdProviderGrouping
        '
        Me.cmdProviderGrouping.CategoryName = "ReportingManagement"
        Me.cmdProviderGrouping.Key = "cmdProviderGrouping"
        Me.cmdProviderGrouping.Name = "cmdProviderGrouping"
        Me.cmdProviderGrouping.Text = "Provider Grouping"
        '
        'cmdREFRESH
        '
        Me.cmdREFRESH.CategoryName = "Application"
        Me.cmdREFRESH.Key = "cmdREFRESH"
        Me.cmdREFRESH.Name = "cmdREFRESH"
        Me.cmdREFRESH.Shortcut = System.Windows.Forms.Shortcut.F5
        Me.cmdREFRESH.Text = "Refresh"
        '
        'cmdANALYSISMILESTONESCHEDULE
        '
        Me.cmdANALYSISMILESTONESCHEDULE.CategoryName = "AnalysisManagement"
        Me.cmdANALYSISMILESTONESCHEDULE.Key = "cmdANALYSISMILESTONESCHEDULE"
        Me.cmdANALYSISMILESTONESCHEDULE.Name = "cmdANALYSISMILESTONESCHEDULE"
        Me.cmdANALYSISMILESTONESCHEDULE.Text = "Analysis Milestone Schedule"
        '
        'cmdANTHEM
        '
        Me.cmdANTHEM.CategoryName = "DataManagement"
        Me.cmdANTHEM.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdEditMonthlySummaryData1, Me.Separator12, Me.cmdAnthemProcessData1})
        Me.cmdANTHEM.Key = "cmdANTHEM"
        Me.cmdANTHEM.Name = "cmdANTHEM"
        Me.cmdANTHEM.Text = "Anthem"
        '
        'cmdEditMonthlySummaryData1
        '
        Me.cmdEditMonthlySummaryData1.Key = "cmdEditAnthemMonthlySummaryData"
        Me.cmdEditMonthlySummaryData1.Name = "cmdEditMonthlySummaryData1"
        '
        'Separator12
        '
        Me.Separator12.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator12.Key = "Separator"
        Me.Separator12.Name = "Separator12"
        '
        'cmdAnthemProcessData1
        '
        Me.cmdAnthemProcessData1.Key = "cmdAnthemProcessData"
        Me.cmdAnthemProcessData1.Name = "cmdAnthemProcessData1"
        '
        'cmdEditAnthemMonthlySummaryData
        '
        Me.cmdEditAnthemMonthlySummaryData.CategoryName = "DataManagement"
        Me.cmdEditAnthemMonthlySummaryData.Key = "cmdEditAnthemMonthlySummaryData"
        Me.cmdEditAnthemMonthlySummaryData.Name = "cmdEditAnthemMonthlySummaryData"
        Me.cmdEditAnthemMonthlySummaryData.Text = "Edit Monthly Summary Data"
        '
        'cmdSchoolgroupLogo
        '
        Me.cmdSchoolgroupLogo.CategoryName = "ReportingManagement"
        Me.cmdSchoolgroupLogo.Key = "cmdSchoolgroupLogo"
        Me.cmdSchoolgroupLogo.Name = "cmdSchoolgroupLogo"
        Me.cmdSchoolgroupLogo.Text = "Schoolgroup Logo"
        '
        'cmdHTH
        '
        Me.cmdHTH.CategoryName = "DataManagement"
        Me.cmdHTH.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdHthBenefitMapping2, Me.cmdHthGroupMapping1, Me.Separator3, Me.cmdHTHReprocessData1})
        Me.cmdHTH.Key = "cmdHTH"
        Me.cmdHTH.Name = "cmdHTH"
        Me.cmdHTH.Text = "HTH"
        '
        'cmdHthBenefitMapping2
        '
        Me.cmdHthBenefitMapping2.Key = "cmdHthBenefitMapping"
        Me.cmdHthBenefitMapping2.Name = "cmdHthBenefitMapping2"
        Me.cmdHthBenefitMapping2.Text = "Benefit Mapping"
        '
        'cmdHthGroupMapping1
        '
        Me.cmdHthGroupMapping1.Key = "cmdHthGroupMapping"
        Me.cmdHthGroupMapping1.Name = "cmdHthGroupMapping1"
        Me.cmdHthGroupMapping1.Text = "Group Mapping"
        '
        'Separator3
        '
        Me.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator3.Key = "Separator"
        Me.Separator3.Name = "Separator3"
        '
        'cmdHTHReprocessData1
        '
        Me.cmdHTHReprocessData1.Key = "cmdHTHReprocessData"
        Me.cmdHTHReprocessData1.Name = "cmdHTHReprocessData1"
        '
        'cmdHthGroupMapping
        '
        Me.cmdHthGroupMapping.CategoryName = "DataManagement"
        Me.cmdHthGroupMapping.Key = "cmdHthGroupMapping"
        Me.cmdHthGroupMapping.Name = "cmdHthGroupMapping"
        Me.cmdHthGroupMapping.Text = "Group Mapping"
        '
        'cmdOverlandParkTrizzetoBenefitMapping
        '
        Me.cmdOverlandParkTrizzetoBenefitMapping.CategoryName = "DataManagement"
        Me.cmdOverlandParkTrizzetoBenefitMapping.Key = "cmdOverlandParkTrizzetoBenefitMapping"
        Me.cmdOverlandParkTrizzetoBenefitMapping.Name = "cmdOverlandParkTrizzetoBenefitMapping"
        Me.cmdOverlandParkTrizzetoBenefitMapping.Text = "OP Trizzeto Mapping"
        '
        'cmdAnalysisLogListing
        '
        Me.cmdAnalysisLogListing.CategoryName = "AnalysisManagement"
        Me.cmdAnalysisLogListing.Key = "cmdAnalysisLogListing"
        Me.cmdAnalysisLogListing.Name = "cmdAnalysisLogListing"
        Me.cmdAnalysisLogListing.Shortcut = System.Windows.Forms.Shortcut.CtrlShiftL
        Me.cmdAnalysisLogListing.Text = "Analysis Log Listing"
        '
        'cmdAmeribenNetworkFees
        '
        Me.cmdAmeribenNetworkFees.CategoryName = "DataManagement"
        Me.cmdAmeribenNetworkFees.Key = "cmdAmeribenNetworkFees"
        Me.cmdAmeribenNetworkFees.Name = "cmdAmeribenNetworkFees"
        Me.cmdAmeribenNetworkFees.Text = "Network Fees"
        '
        'cmdProcessSampleData
        '
        Me.cmdProcessSampleData.CategoryName = "ReportingManagement"
        Me.cmdProcessSampleData.Key = "cmdProcessSampleData"
        Me.cmdProcessSampleData.Name = "cmdProcessSampleData"
        Me.cmdProcessSampleData.Text = "Process Sample Data"
        '
        'cmdDatawarehouseServiceCodeTypes
        '
        Me.cmdDatawarehouseServiceCodeTypes.CategoryName = "DataManagement"
        Me.cmdDatawarehouseServiceCodeTypes.Key = "cmdDatawarehouseServiceCodeTypes"
        Me.cmdDatawarehouseServiceCodeTypes.Name = "cmdDatawarehouseServiceCodeTypes"
        Me.cmdDatawarehouseServiceCodeTypes.Text = "Service Code Types"
        '
        'cmdEsiGroupMapping
        '
        Me.cmdEsiGroupMapping.CategoryName = "DataManagement"
        Me.cmdEsiGroupMapping.Key = "cmdEsiGroupMapping"
        Me.cmdEsiGroupMapping.Name = "cmdEsiGroupMapping"
        Me.cmdEsiGroupMapping.Text = "ESI Group Mapping"
        '
        'cmdRatingStatisticTypes
        '
        Me.cmdRatingStatisticTypes.CategoryName = "AnalysisManagement"
        Me.cmdRatingStatisticTypes.Key = "cmdRatingStatisticTypes"
        Me.cmdRatingStatisticTypes.Name = "cmdRatingStatisticTypes"
        Me.cmdRatingStatisticTypes.Text = "Statistic Types"
        '
        'cmdDataWarehouseBenefitCategories
        '
        Me.cmdDataWarehouseBenefitCategories.CategoryName = "DataManagement"
        Me.cmdDataWarehouseBenefitCategories.Key = "cmdBenefitCategoriesEditor"
        Me.cmdDataWarehouseBenefitCategories.Name = "cmdDataWarehouseBenefitCategories"
        Me.cmdDataWarehouseBenefitCategories.Text = "Benefit Categories Editor"
        '
        'cmdPersonalInsuranceAdministrators
        '
        Me.cmdPersonalInsuranceAdministrators.CategoryName = "DataManagement"
        Me.cmdPersonalInsuranceAdministrators.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdPiaBenefitMapping2})
        Me.cmdPersonalInsuranceAdministrators.Key = "cmdPersonalInsuranceAdministrators"
        Me.cmdPersonalInsuranceAdministrators.Name = "cmdPersonalInsuranceAdministrators"
        Me.cmdPersonalInsuranceAdministrators.Text = "PIA"
        '
        'cmdPiaBenefitMapping2
        '
        Me.cmdPiaBenefitMapping2.Key = "cmdPiaBenefitMapping"
        Me.cmdPiaBenefitMapping2.Name = "cmdPiaBenefitMapping2"
        Me.cmdPiaBenefitMapping2.Text = "Benefit Mapping"
        '
        'cmdABISOverlandPark
        '
        Me.cmdABISOverlandPark.CategoryName = "DataManagement"
        Me.cmdABISOverlandPark.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdOverlandParkGroups1, Me.cmdOverlandParkGroupMapping1, Me.cmdOverlandParkEnrollmentActivity1, Me.cmdOverlandParkTrizzetoBenefitMapping2, Me.cmdOverlandParkBTSBenefitMapping1})
        Me.cmdABISOverlandPark.Key = "cmdABISOverlandPark"
        Me.cmdABISOverlandPark.Name = "cmdABISOverlandPark"
        Me.cmdABISOverlandPark.Text = "ABIS Overland Park"
        '
        'cmdOverlandParkGroups1
        '
        Me.cmdOverlandParkGroups1.Key = "cmdOverlandParkGroups"
        Me.cmdOverlandParkGroups1.Name = "cmdOverlandParkGroups1"
        '
        'cmdOverlandParkGroupMapping1
        '
        Me.cmdOverlandParkGroupMapping1.Key = "cmdOverlandParkGroupMapping"
        Me.cmdOverlandParkGroupMapping1.Name = "cmdOverlandParkGroupMapping1"
        '
        'cmdOverlandParkEnrollmentActivity1
        '
        Me.cmdOverlandParkEnrollmentActivity1.Key = "cmdOverlandParkEnrollmentActivity"
        Me.cmdOverlandParkEnrollmentActivity1.Name = "cmdOverlandParkEnrollmentActivity1"
        '
        'cmdOverlandParkTrizzetoBenefitMapping2
        '
        Me.cmdOverlandParkTrizzetoBenefitMapping2.Key = "cmdOverlandParkTrizzetoBenefitMapping"
        Me.cmdOverlandParkTrizzetoBenefitMapping2.Name = "cmdOverlandParkTrizzetoBenefitMapping2"
        Me.cmdOverlandParkTrizzetoBenefitMapping2.Text = "Trizzeto Benefit Mapping"
        '
        'cmdOverlandParkBTSBenefitMapping1
        '
        Me.cmdOverlandParkBTSBenefitMapping1.Key = "cmdOverlandParkBTSBenefitMapping"
        Me.cmdOverlandParkBTSBenefitMapping1.Name = "cmdOverlandParkBTSBenefitMapping1"
        '
        'cmdMutualOfOmaha
        '
        Me.cmdMutualOfOmaha.CategoryName = "DataManagement"
        Me.cmdMutualOfOmaha.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdMooBenefitMapping2, Me.Separator15, Me.cmdMOOProcessData2})
        Me.cmdMutualOfOmaha.Key = "cmdMutualOfOmaha"
        Me.cmdMutualOfOmaha.Name = "cmdMutualOfOmaha"
        Me.cmdMutualOfOmaha.Text = "Mutual Of Omaha"
        '
        'cmdMooBenefitMapping2
        '
        Me.cmdMooBenefitMapping2.Key = "cmdMooBenefitMapping"
        Me.cmdMooBenefitMapping2.Name = "cmdMooBenefitMapping2"
        Me.cmdMooBenefitMapping2.Text = "Benefit Mapping"
        '
        'Separator15
        '
        Me.Separator15.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator15.Key = "Separator"
        Me.Separator15.Name = "Separator15"
        '
        'cmdMOOProcessData2
        '
        Me.cmdMOOProcessData2.Key = "cmdMOOProcessData"
        Me.cmdMOOProcessData2.Name = "cmdMOOProcessData2"
        '
        'cmdSchoolAddressInfo
        '
        Me.cmdSchoolAddressInfo.CategoryName = "DataManagement"
        Me.cmdSchoolAddressInfo.Key = "cmdSchoolAddressInfo"
        Me.cmdSchoolAddressInfo.Name = "cmdSchoolAddressInfo"
        Me.cmdSchoolAddressInfo.Text = "School Address Editor"
        '
        'cmdUnderwriters
        '
        Me.cmdUnderwriters.CategoryName = "DataManagement"
        Me.cmdUnderwriters.Key = "cmdUnderwriters"
        Me.cmdUnderwriters.Name = "cmdUnderwriters"
        Me.cmdUnderwriters.Text = "Underwriters"
        '
        'cmdAnalysisPeoplePersonType
        '
        Me.cmdAnalysisPeoplePersonType.CategoryName = "DataManagement"
        Me.cmdAnalysisPeoplePersonType.Key = "cmdAnalysisPeoplePersonType"
        Me.cmdAnalysisPeoplePersonType.Name = "cmdAnalysisPeoplePersonType"
        Me.cmdAnalysisPeoplePersonType.Text = "Analysis Person Type"
        '
        'cmdExpressScripts
        '
        Me.cmdExpressScripts.CategoryName = "DataManagement"
        Me.cmdExpressScripts.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdEsiGroupMapping2})
        Me.cmdExpressScripts.Key = "cmdExpressScripts"
        Me.cmdExpressScripts.Name = "cmdExpressScripts"
        Me.cmdExpressScripts.Text = "Express Scripts"
        '
        'cmdEsiGroupMapping2
        '
        Me.cmdEsiGroupMapping2.Key = "cmdEsiGroupMapping"
        Me.cmdEsiGroupMapping2.Name = "cmdEsiGroupMapping2"
        '
        'cmdClaremontTagMapping
        '
        Me.cmdClaremontTagMapping.CategoryName = "DataManagement"
        Me.cmdClaremontTagMapping.Key = "cmdClaremontTagMapping"
        Me.cmdClaremontTagMapping.Name = "cmdClaremontTagMapping"
        Me.cmdClaremontTagMapping.Text = "Claremont Tag Mapping"
        '
        'cmdLineOfBusiness
        '
        Me.cmdLineOfBusiness.CategoryName = "DataManagement"
        Me.cmdLineOfBusiness.Key = "cmdLineOfBusiness"
        Me.cmdLineOfBusiness.Name = "cmdLineOfBusiness"
        Me.cmdLineOfBusiness.Text = "Line Of Business"
        '
        'cmdLineOfBusinessCategories
        '
        Me.cmdLineOfBusinessCategories.CategoryName = "DataManagement"
        Me.cmdLineOfBusinessCategories.Key = "cmdLineOfBusinessCategories"
        Me.cmdLineOfBusinessCategories.Name = "cmdLineOfBusinessCategories"
        Me.cmdLineOfBusinessCategories.Text = "Line Of Business Categories"
        '
        'cmdSchoolgroupLineOfBusiness
        '
        Me.cmdSchoolgroupLineOfBusiness.CategoryName = "DataManagement"
        Me.cmdSchoolgroupLineOfBusiness.Key = "cmdSchoolgroupLineOfBusiness"
        Me.cmdSchoolgroupLineOfBusiness.Name = "cmdSchoolgroupLineOfBusiness"
        Me.cmdSchoolgroupLineOfBusiness.Text = "Schoolgroup Line Of Business Editor"
        '
        'cmdMarketingDb
        '
        Me.cmdMarketingDb.CategoryName = "DataManagement"
        Me.cmdMarketingDb.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdMarketingDbSchoolgroupMapping1})
        Me.cmdMarketingDb.Key = "cmdMarketingDb"
        Me.cmdMarketingDb.Name = "cmdMarketingDb"
        Me.cmdMarketingDb.Text = "Marketing Db"
        '
        'cmdMarketingDbSchoolgroupMapping1
        '
        Me.cmdMarketingDbSchoolgroupMapping1.Key = "cmdMarketingDbSchoolgroupMapping"
        Me.cmdMarketingDbSchoolgroupMapping1.Name = "cmdMarketingDbSchoolgroupMapping1"
        '
        'cmdMarketingDbSchoolgroupMapping
        '
        Me.cmdMarketingDbSchoolgroupMapping.CategoryName = "DataManagement"
        Me.cmdMarketingDbSchoolgroupMapping.Key = "cmdMarketingDbSchoolgroupMapping"
        Me.cmdMarketingDbSchoolgroupMapping.Name = "cmdMarketingDbSchoolgroupMapping"
        Me.cmdMarketingDbSchoolgroupMapping.Text = "Schoolgroup Mapping"
        '
        'cmdAetna
        '
        Me.cmdAetna.CategoryName = "DataManagement"
        Me.cmdAetna.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdAetnaBenefitTypes1, Me.cmdAetnaPlaceOfServiceCodes1, Me.cmdAetnaGroupMapping1, Me.cmdAetnaBenefitMapping1})
        Me.cmdAetna.Key = "cmdAetna"
        Me.cmdAetna.Name = "cmdAetna"
        Me.cmdAetna.Text = "Aetna"
        '
        'cmdAetnaBenefitTypes1
        '
        Me.cmdAetnaBenefitTypes1.Key = "cmdAetnaBenefitTypes"
        Me.cmdAetnaBenefitTypes1.Name = "cmdAetnaBenefitTypes1"
        '
        'cmdAetnaPlaceOfServiceCodes1
        '
        Me.cmdAetnaPlaceOfServiceCodes1.Key = "cmdAetnaPlaceOfServiceCodes"
        Me.cmdAetnaPlaceOfServiceCodes1.Name = "cmdAetnaPlaceOfServiceCodes1"
        '
        'cmdAetnaGroupMapping1
        '
        Me.cmdAetnaGroupMapping1.Key = "cmdAetnaGroupMapping"
        Me.cmdAetnaGroupMapping1.Name = "cmdAetnaGroupMapping1"
        Me.cmdAetnaGroupMapping1.Text = "Group Mapping"
        '
        'cmdAetnaBenefitMapping1
        '
        Me.cmdAetnaBenefitMapping1.Key = "cmdAetnaBenefitMapping"
        Me.cmdAetnaBenefitMapping1.Name = "cmdAetnaBenefitMapping1"
        '
        'cmdAetnaGroupMapping
        '
        Me.cmdAetnaGroupMapping.CategoryName = "DataManagement"
        Me.cmdAetnaGroupMapping.Key = "cmdAetnaGroupMapping"
        Me.cmdAetnaGroupMapping.Name = "cmdAetnaGroupMapping"
        Me.cmdAetnaGroupMapping.Text = "Aetna Group Mapping"
        '
        'cmdGeneralStatistics
        '
        Me.cmdGeneralStatistics.CategoryName = "RatingAndStatistics"
        Me.cmdGeneralStatistics.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdGeneralStatisticsDevelopment1, Me.cmdGeneralStatisticsCategories1})
        Me.cmdGeneralStatistics.Key = "cmdGeneralStatistics"
        Me.cmdGeneralStatistics.Name = "cmdGeneralStatistics"
        Me.cmdGeneralStatistics.Text = "General Statistics"
        '
        'cmdGeneralStatisticsDevelopment1
        '
        Me.cmdGeneralStatisticsDevelopment1.Key = "cmdGeneralStatisticsDevelopment"
        Me.cmdGeneralStatisticsDevelopment1.Name = "cmdGeneralStatisticsDevelopment1"
        '
        'cmdGeneralStatisticsCategories1
        '
        Me.cmdGeneralStatisticsCategories1.Key = "cmdGeneralStatisticsCategories"
        Me.cmdGeneralStatisticsCategories1.Name = "cmdGeneralStatisticsCategories1"
        '
        'cmdGeneralStatisticsDevelopment
        '
        Me.cmdGeneralStatisticsDevelopment.CategoryName = "RatingAndStatistics"
        Me.cmdGeneralStatisticsDevelopment.Key = "cmdGeneralStatisticsDevelopment"
        Me.cmdGeneralStatisticsDevelopment.Name = "cmdGeneralStatisticsDevelopment"
        Me.cmdGeneralStatisticsDevelopment.Text = "Statistics"
        '
        'cmdGeneralStatisticsCategories
        '
        Me.cmdGeneralStatisticsCategories.CategoryName = "RatingAndStatistics"
        Me.cmdGeneralStatisticsCategories.Key = "cmdGeneralStatisticsCategories"
        Me.cmdGeneralStatisticsCategories.Name = "cmdGeneralStatisticsCategories"
        Me.cmdGeneralStatisticsCategories.Text = "Statistic Categories"
        '
        'cmdProcedureScheduleEdit
        '
        Me.cmdProcedureScheduleEdit.CategoryName = "DataManagement"
        Me.cmdProcedureScheduleEdit.Key = "cmdProcedureScheduleEdit"
        Me.cmdProcedureScheduleEdit.Name = "cmdProcedureScheduleEdit"
        Me.cmdProcedureScheduleEdit.Text = "Edit Procedure Schedule"
        '
        'cmdProcedureScheduleRecurrence
        '
        Me.cmdProcedureScheduleRecurrence.CategoryName = "DataManagement"
        Me.cmdProcedureScheduleRecurrence.Key = "cmdProcedureScheduleRecurrence"
        Me.cmdProcedureScheduleRecurrence.Name = "cmdProcedureScheduleRecurrence"
        Me.cmdProcedureScheduleRecurrence.Text = "Edit Recurrence"
        '
        'cmdProcedureScheduleRecurrenceTypes
        '
        Me.cmdProcedureScheduleRecurrenceTypes.CategoryName = "DataManagement"
        Me.cmdProcedureScheduleRecurrenceTypes.Key = "cmdProcedureScheduleRecurrenceTypes"
        Me.cmdProcedureScheduleRecurrenceTypes.Name = "cmdProcedureScheduleRecurrenceTypes"
        Me.cmdProcedureScheduleRecurrenceTypes.Text = "Edit Recurrence Types"
        '
        'cmdOverlandParkEnrollmentActivity
        '
        Me.cmdOverlandParkEnrollmentActivity.CategoryName = "DataManagement"
        Me.cmdOverlandParkEnrollmentActivity.Key = "cmdOverlandParkEnrollmentActivity"
        Me.cmdOverlandParkEnrollmentActivity.Name = "cmdOverlandParkEnrollmentActivity"
        Me.cmdOverlandParkEnrollmentActivity.Text = "Enrollment Activity"
        '
        'cmdOverlandParkGroups
        '
        Me.cmdOverlandParkGroups.CategoryName = "DataManagement"
        Me.cmdOverlandParkGroups.Key = "cmdOverlandParkGroups"
        Me.cmdOverlandParkGroups.Name = "cmdOverlandParkGroups"
        Me.cmdOverlandParkGroups.Text = "Groups"
        '
        'cmdOverlandParkGroupMapping
        '
        Me.cmdOverlandParkGroupMapping.CategoryName = "DataManagement"
        Me.cmdOverlandParkGroupMapping.Key = "cmdOverlandParkGroupMapping"
        Me.cmdOverlandParkGroupMapping.Name = "cmdOverlandParkGroupMapping"
        Me.cmdOverlandParkGroupMapping.Text = "Group Mapping"
        '
        'cmdOverlandParkBTSBenefitMapping
        '
        Me.cmdOverlandParkBTSBenefitMapping.CategoryName = "DataManagement"
        Me.cmdOverlandParkBTSBenefitMapping.Key = "cmdOverlandParkBTSBenefitMapping"
        Me.cmdOverlandParkBTSBenefitMapping.Name = "cmdOverlandParkBTSBenefitMapping"
        Me.cmdOverlandParkBTSBenefitMapping.Text = "BTS Benefit Mapping"
        '
        'ReportingManagement
        '
        Me.ReportingManagement.CategoryName = "ReportingManagement"
        Me.ReportingManagement.Commands.AddRange(New Janus.Windows.UI.CommandBars.UICommand() {Me.cmdReportViewer1, Me.Separator2, Me.cmdSCHOOLGROUP_GROUPS1, Me.cmdDISTRIBUTIONS1, Me.cmdProviderGrouping2, Me.cmdSchoolAddressInfo1, Me.cmdSchoolgroupLogo1})
        Me.ReportingManagement.Key = "ReportingManagement"
        Me.ReportingManagement.Name = "ReportingManagement"
        Me.ReportingManagement.Text = "Reporting Management"
        '
        'cmdReportViewer1
        '
        Me.cmdReportViewer1.Key = "cmdReportViewer"
        Me.cmdReportViewer1.Name = "cmdReportViewer1"
        '
        'Separator2
        '
        Me.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator
        Me.Separator2.Key = "Separator"
        Me.Separator2.Name = "Separator2"
        '
        'cmdSCHOOLGROUP_GROUPS1
        '
        Me.cmdSCHOOLGROUP_GROUPS1.Key = "cmdSCHOOLGROUP_GROUPS"
        Me.cmdSCHOOLGROUP_GROUPS1.Name = "cmdSCHOOLGROUP_GROUPS1"
        '
        'cmdDISTRIBUTIONS1
        '
        Me.cmdDISTRIBUTIONS1.Key = "cmdDISTRIBUTIONS"
        Me.cmdDISTRIBUTIONS1.Name = "cmdDISTRIBUTIONS1"
        '
        'cmdProviderGrouping2
        '
        Me.cmdProviderGrouping2.Key = "cmdProviderGrouping"
        Me.cmdProviderGrouping2.Name = "cmdProviderGrouping2"
        '
        'cmdSchoolAddressInfo1
        '
        Me.cmdSchoolAddressInfo1.Key = "cmdSchoolAddressInfo"
        Me.cmdSchoolAddressInfo1.Name = "cmdSchoolAddressInfo1"
        '
        'cmdSchoolgroupLogo1
        '
        Me.cmdSchoolgroupLogo1.Key = "cmdSchoolgroupLogo"
        Me.cmdSchoolgroupLogo1.Name = "cmdSchoolgroupLogo1"
        '
        'cmdAetnaBenefitMapping
        '
        Me.cmdAetnaBenefitMapping.CategoryName = "DataManagement"
        Me.cmdAetnaBenefitMapping.Key = "cmdAetnaBenefitMapping"
        Me.cmdAetnaBenefitMapping.Name = "cmdAetnaBenefitMapping"
        Me.cmdAetnaBenefitMapping.Text = "Benefit Mapping"
        '
        'cmdAetnaBenefitTypes
        '
        Me.cmdAetnaBenefitTypes.CategoryName = "DataManagement"
        Me.cmdAetnaBenefitTypes.Key = "cmdAetnaBenefitTypes"
        Me.cmdAetnaBenefitTypes.Name = "cmdAetnaBenefitTypes"
        Me.cmdAetnaBenefitTypes.Text = "Benefit Types"
        '
        'cmdAetnaPlaceOfServiceCodes
        '
        Me.cmdAetnaPlaceOfServiceCodes.CategoryName = "DataManagement"
        Me.cmdAetnaPlaceOfServiceCodes.Key = "cmdAetnaPlaceOfServiceCodes"
        Me.cmdAetnaPlaceOfServiceCodes.Name = "cmdAetnaPlaceOfServiceCodes"
        Me.cmdAetnaPlaceOfServiceCodes.Text = "Place Of Service Codes"
        '
        'cmdExportToExcel
        '
        Me.cmdExportToExcel.CategoryName = "Application"
        Me.cmdExportToExcel.Key = "cmdExportToExcel"
        Me.cmdExportToExcel.Name = "cmdExportToExcel"
        Me.cmdExportToExcel.Text = "Export To Excel..."
        '
        'cmdEventLogDetails
        '
        Me.cmdEventLogDetails.CategoryName = "DataManagement"
        Me.cmdEventLogDetails.Key = "cmdEventLogDetails"
        Me.cmdEventLogDetails.Name = "cmdEventLogDetails"
        Me.cmdEventLogDetails.Text = "Event Log"
        '
        'cmdHTHReprocessData
        '
        Me.cmdHTHReprocessData.CategoryName = "DataManagement"
        Me.cmdHTHReprocessData.Key = "cmdHTHReprocessData"
        Me.cmdHTHReprocessData.Name = "cmdHTHReprocessData"
        Me.cmdHTHReprocessData.Text = "Reprocess Data"
        '
        'cmdAmeribenProcessData
        '
        Me.cmdAmeribenProcessData.CategoryName = "DataManagement"
        Me.cmdAmeribenProcessData.Key = "cmdAmeribenProcessData"
        Me.cmdAmeribenProcessData.Name = "cmdAmeribenProcessData"
        Me.cmdAmeribenProcessData.Text = "Process Data"
        '
        'cmdAnthemProcessData
        '
        Me.cmdAnthemProcessData.CategoryName = "DataManagement"
        Me.cmdAnthemProcessData.Key = "cmdAnthemProcessData"
        Me.cmdAnthemProcessData.Name = "cmdAnthemProcessData"
        Me.cmdAnthemProcessData.Text = "Process Data"
        '
        'cmdMOOProcessData
        '
        Me.cmdMOOProcessData.CategoryName = "DataManagement"
        Me.cmdMOOProcessData.Key = "cmdMOOProcessData"
        Me.cmdMOOProcessData.Name = "cmdMOOProcessData"
        Me.cmdMOOProcessData.Text = "Process Data"
        '
        'cmdMOOImportFile
        '
        Me.cmdMOOImportFile.CategoryName = "DataManagement"
        Me.cmdMOOImportFile.Key = "cmdMOOImportFile"
        Me.cmdMOOImportFile.Name = "cmdMOOImportFile"
        Me.cmdMOOImportFile.Text = "Import Data File"
        '
        'LeftRebar1
        '
        Me.LeftRebar1.CommandManager = Me.uicmMain
        Me.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftRebar1.Location = New System.Drawing.Point(0, 26)
        Me.LeftRebar1.Name = "LeftRebar1"
        Me.LeftRebar1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.LeftRebar1.Size = New System.Drawing.Size(0, 560)
        '
        'RightRebar1
        '
        Me.RightRebar1.CommandManager = Me.uicmMain
        Me.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightRebar1.Location = New System.Drawing.Point(754, 26)
        Me.RightRebar1.Name = "RightRebar1"
        Me.RightRebar1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.RightRebar1.Size = New System.Drawing.Size(0, 560)
        '
        'TopRebar1
        '
        Me.TopRebar1.CommandBars.AddRange(New Janus.Windows.UI.CommandBars.UICommandBar() {Me.uicmdbarMain})
        Me.TopRebar1.CommandManager = Me.uicmMain
        Me.TopRebar1.Controls.Add(Me.uicmdbarMain)
        Me.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopRebar1.Location = New System.Drawing.Point(0, 0)
        Me.TopRebar1.Name = "TopRebar1"
        Me.TopRebar1.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.TopRebar1.Size = New System.Drawing.Size(1358, 22)
        '
        'vsmMain
        '
        JanusColorScheme1.HighlightTextColor = System.Drawing.SystemColors.HighlightText
        JanusColorScheme1.Name = "Scheme0"
        JanusColorScheme1.OfficeColorScheme = Janus.Windows.Common.OfficeColorScheme.Blue
        JanusColorScheme1.OfficeCustomColor = System.Drawing.Color.Empty
        JanusColorScheme1.VisualStyle = Janus.Windows.Common.VisualStyle.Office2010
        Me.vsmMain.ColorSchemes.Add(JanusColorScheme1)
        '
        'MainStatusBar
        '
        Me.MainStatusBar.Location = New System.Drawing.Point(0, 885)
        Me.MainStatusBar.Name = "MainStatusBar"
        Me.MainStatusBar.Size = New System.Drawing.Size(1358, 23)
        '
        '
        '
        Me.MainStatusBar.SuperTipComponent.AutoPopDelay = 2000
        Me.MainStatusBar.SuperTipComponent.ImageList = Nothing
        Me.MainStatusBar.TabIndex = 5
        Me.MainStatusBar.Text = "RibbonStatusBar1"
        Me.MainStatusBar.UseCompatibleTextRendering = False
        '
        'uipmMain
        '
        Me.uipmMain.ContainerControl = Me
        Me.uipmMain.TabbedMdi = True
        '
        'mdiMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1358, 908)
        Me.Controls.Add(Me.MainStatusBar)
        Me.Controls.Add(Me.TopRebar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mdiMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ascension  Analytics Application"
        CType(Me.uicmMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BottomRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uicmdbarMain, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TopRebar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TopRebar1.ResumeLayout(False)
        CType(Me.uipmMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents uicmMain As Janus.Windows.UI.CommandBars.UICommandManager
    Friend WithEvents BottomRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents LeftRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents RightRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents TopRebar1 As Janus.Windows.UI.CommandBars.UIRebar
    Friend WithEvents MainStatusBar As Janus.Windows.Ribbon.RibbonStatusBar
    Friend WithEvents vsmMain As Janus.Windows.Common.VisualStyleManager
    Friend WithEvents uicmdbarMain As Janus.Windows.UI.CommandBars.UICommandBar
    Friend WithEvents cmdAPPLICATION As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSAVE1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEXIT1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSAVE As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPRINT As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEXIT As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdLOOKUPTABLES As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSCHOOLGROUP_GROUPS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdTOOLS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISTRACKER As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents uipmMain As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents cmdANALYSISPEOPLE As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISREQUESTSTATUS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISREQUESTTYPE As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdALTERNATEDESCRIPTORS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDISTRIBUTIONS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDatasourceMaxPaidDate As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSCHOOLGROUPASSIGNMENTS As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSCHOOLGROUPASSIGNMENTTYPES As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPROCEDURESCHEDULE As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDatasources As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdBENEFITMAPPING As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHthBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHthBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMooBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMooBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPiaBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPiaBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouse As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAPPLICATION1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouse1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseBenefits1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator6 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseBenefits As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnoses1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseServices1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnoses As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseServices As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator7 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfService1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfServiceCategory1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfServiceSubCategory1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfService As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfServiceCategory As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseTypeOfServiceSubCategory As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnosisCategories1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnosisCategories As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnosisCodeType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseDiagnosisCodeType As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisManagement1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisManagement As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISPEOPLE2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISTRACKER2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPROCEDURESCHEDULE1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator10 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator11 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDatasources2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISREQUESTSTATUS2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISREQUESTTYPE2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMessageQueue1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMessageQueue As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEditMessageQueue1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcessMessageQueue1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcessMessageQueue As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEditMessageQueue As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeriben1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeriben As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenGroupMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenGroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAggregationSettings1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAggregationSettings As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRatingAndAnalysis As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMonthlyExperience1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMonthlyExperience As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewer As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerAvailableReportParameterValues1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerAvailableReportParameterValues As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerAvailableGroupingItems1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerAvailableGroupingItems As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHelp1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHelp As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerUsers1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerUsers As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerRecordFilters1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewerRecordFilters As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProviderGrouping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdREFRESH1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdREFRESH As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISMILESTONESCHEDULE1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANALYSISMILESTONESCHEDULE As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANTHEM As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdANTHEM1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEditMonthlySummaryData1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEditAnthemMonthlySummaryData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolgroupLogo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHTH1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHTH As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHthGroupMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHthGroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkTrizzetoBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkTrizzetoBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisLogListing1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisLogListing As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenNetworkFees1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenNetworkFees As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcessSampleData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdServiceCodeTypes1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDatawarehouseServiceCodeTypes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEsiGroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator4 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRatingStatisticTypes1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdRatingStatisticTypes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDataWarehouseBenefitCategories As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdBenefitCategoriesEditor1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenBenefitMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHthBenefitMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdABISOverlandPark1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMutualOfOmaha1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPersonalInsuranceAdministrators1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPersonalInsuranceAdministrators As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdPiaBenefitMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdABISOverlandPark As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkTrizzetoBenefitMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMutualOfOmaha As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMooBenefitMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolAddressInfo As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator5 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator13 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdUnderwriters1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdUnderwriters As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisPeoplePersonType1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnalysisPeoplePersonType As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdExpressScripts1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdExpressScripts As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEsiGroupMapping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdClaremontTagMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator14 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdLineOfBusiness1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdLineOfBusinessCategories1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolgroupLineOfBusiness1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdLineOfBusiness As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdLineOfBusinessCategories As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolgroupLineOfBusiness As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMarketingDb1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMarketingDb As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMarketingDbSchoolgroupMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMarketingDbSchoolgroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetna1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetna As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaGroupMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaGroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatistics1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatistics As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatisticsDevelopment1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatisticsCategories1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatisticsDevelopment As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdGeneralStatisticsCategories As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleEdit1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleRecurrence1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleRecurrenceTypes1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleEdit As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleRecurrence As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcedureScheduleRecurrenceTypes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkEnrollmentActivity1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkEnrollmentActivity As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkGroups1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkGroupMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkBTSBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkGroups As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkGroupMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdOverlandParkBTSBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ReportingManagement1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents ReportingManagement As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdReportViewer1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSCHOOLGROUP_GROUPS1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDISTRIBUTIONS1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolgroupLogo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator9 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdALTERNATEDESCRIPTORS1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProcessSampleData2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdSchoolAddressInfo1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdClaremontTagMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaBenefitMapping1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaBenefitMapping As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaBenefitTypes1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaBenefitTypes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaPlaceOfServiceCodes1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAetnaPlaceOfServiceCodes As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdExportToExcel1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdExportToExcel As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdProviderGrouping2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdDatasourceMaxPaidDate1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEventLogDetails1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdEventLogDetails As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator3 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHTHReprocessData1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdHTHReprocessData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator8 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenProcessData1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAmeribenProcessData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator12 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnthemProcessData1 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdAnthemProcessData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMOOProcessData As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents Separator15 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMOOProcessData2 As Janus.Windows.UI.CommandBars.UICommand
    Friend WithEvents cmdMOOImportFile As Janus.Windows.UI.CommandBars.UICommand

End Class
