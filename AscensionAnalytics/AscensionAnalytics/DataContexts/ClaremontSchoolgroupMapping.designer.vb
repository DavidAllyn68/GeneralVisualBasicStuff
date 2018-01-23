﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="David")>  _
Partial Public Class ClaremontSchoolgroupMappingDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Extensibility Method Definitions"
  Partial Private Sub OnCreated()
  End Sub
  Partial Private Sub InsertClaremontPlanHistoryData_TagMapping(instance As ClaremontPlanHistoryData_TagMapping)
    End Sub
  Partial Private Sub UpdateClaremontPlanHistoryData_TagMapping(instance As ClaremontPlanHistoryData_TagMapping)
    End Sub
  Partial Private Sub DeleteClaremontPlanHistoryData_TagMapping(instance As ClaremontPlanHistoryData_TagMapping)
    End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.AscensionAnalytics.My.MySettings.Default.DavidConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public ReadOnly Property ClaremontPlanHistoryData_TagMappings() As System.Data.Linq.Table(Of ClaremontPlanHistoryData_TagMapping)
		Get
			Return Me.GetTable(Of ClaremontPlanHistoryData_TagMapping)
		End Get
	End Property
End Class

<Global.System.Data.Linq.Mapping.TableAttribute(Name:="dbo.ClaremontPlanHistoryData_TagMapping")>  _
Partial Public Class ClaremontPlanHistoryData_TagMapping
	Implements System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	
	Private Shared emptyChangingEventArgs As PropertyChangingEventArgs = New PropertyChangingEventArgs(String.Empty)
	
	Private _ClaremontPlanHistoryDataTagMapId As Integer
	
	Private _TagType As String
	
	Private _SchoolgroupCode As String
	
	Private _Tag As String
	
	Private _CollegeDisplay As String
	
    #Region "Extensibility Method Definitions"
    Partial Private Sub OnLoaded()
    End Sub
    Partial Private Sub OnValidate(action As System.Data.Linq.ChangeAction)
    End Sub
    Partial Private Sub OnCreated()
    End Sub
    Partial Private Sub OnClaremontPlanHistoryDataTagMapIdChanging(value As Integer)
    End Sub
    Partial Private Sub OnClaremontPlanHistoryDataTagMapIdChanged()
    End Sub
    Partial Private Sub OnTagTypeChanging(value As String)
    End Sub
    Partial Private Sub OnTagTypeChanged()
    End Sub
    Partial Private Sub OnSchoolgroupCodeChanging(value As String)
    End Sub
    Partial Private Sub OnSchoolgroupCodeChanged()
    End Sub
    Partial Private Sub OnTagChanging(value As String)
    End Sub
    Partial Private Sub OnTagChanged()
    End Sub
    Partial Private Sub OnCollegeDisplayChanging(value As String)
    End Sub
    Partial Private Sub OnCollegeDisplayChanged()
    End Sub
    #End Region
	
	Public Sub New()
		MyBase.New
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_ClaremontPlanHistoryDataTagMapId", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=true, IsDbGenerated:=true)>  _
	Public Property ClaremontPlanHistoryDataTagMapId() As Integer
		Get
			Return Me._ClaremontPlanHistoryDataTagMapId
		End Get
		Set
			If ((Me._ClaremontPlanHistoryDataTagMapId = value)  _
						= false) Then
				Me.OnClaremontPlanHistoryDataTagMapIdChanging(value)
				Me.SendPropertyChanging
				Me._ClaremontPlanHistoryDataTagMapId = value
				Me.SendPropertyChanged("ClaremontPlanHistoryDataTagMapId")
				Me.OnClaremontPlanHistoryDataTagMapIdChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_TagType", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property TagType() As String
		Get
			Return Me._TagType
		End Get
		Set
			If (String.Equals(Me._TagType, value) = false) Then
				Me.OnTagTypeChanging(value)
				Me.SendPropertyChanging
				Me._TagType = value
				Me.SendPropertyChanged("TagType")
				Me.OnTagTypeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_SchoolgroupCode", DbType:="VarChar(25) NOT NULL", CanBeNull:=false)>  _
	Public Property SchoolgroupCode() As String
		Get
			Return Me._SchoolgroupCode
		End Get
		Set
			If (String.Equals(Me._SchoolgroupCode, value) = false) Then
				Me.OnSchoolgroupCodeChanging(value)
				Me.SendPropertyChanging
				Me._SchoolgroupCode = value
				Me.SendPropertyChanged("SchoolgroupCode")
				Me.OnSchoolgroupCodeChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Tag", DbType:="VarChar(50) NULL", CanBeNull:=false)>  _
	Public Property Tag() As String
		Get
			Return Me._Tag
		End Get
		Set
			If (String.Equals(Me._Tag, value) = false) Then
				Me.OnTagChanging(value)
				Me.SendPropertyChanging
				Me._Tag = value
				Me.SendPropertyChanged("Tag")
				Me.OnTagChanged
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_CollegeDisplay", DbType:="VarChar(50) NOT NULL", CanBeNull:=false)>  _
	Public Property CollegeDisplay() As String
		Get
			Return Me._CollegeDisplay
		End Get
		Set
			If (String.Equals(Me._CollegeDisplay, value) = false) Then
				Me.OnCollegeDisplayChanging(value)
				Me.SendPropertyChanging
				Me._CollegeDisplay = value
				Me.SendPropertyChanged("CollegeDisplay")
				Me.OnCollegeDisplayChanged
			End If
		End Set
	End Property
	
	Public Event PropertyChanging As PropertyChangingEventHandler Implements System.ComponentModel.INotifyPropertyChanging.PropertyChanging
	
	Public Event PropertyChanged As PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
	
	Protected Overridable Sub SendPropertyChanging()
		If ((Me.PropertyChangingEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
		End If
	End Sub
	
	Protected Overridable Sub SendPropertyChanged(ByVal propertyName As [String])
		If ((Me.PropertyChangedEvent Is Nothing)  _
					= false) Then
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End If
	End Sub
End Class