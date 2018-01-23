Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.ComponentModel
Imports System.Xml.Serialization

<Serializable()> _
Public Class ComboListItems
    Inherits BusinessItems(Of ComboListItem)

    Private mRenData As New DataHelper

    Public Sub New()
        MyBase.New()

    End Sub

    Public Overloads Sub Add(ByVal _Code As String, ByVal _Description As String)
        Me.Add(New ComboListItem(_Code, _Description))
    End Sub

    Public Sub New(ByVal sqlStr As String)
        LoadItemsFromRenData(sqlStr)
    End Sub

    ''' <summary>
    ''' Loads the ComboListItems collection with a dataset from a database.
    ''' Only the first two fields will be used.  Column 1 is the Code, Column 2 is the Description.
    ''' If there is only 1 field, both the code and description will be the same value.
    ''' </summary>
    ''' <param name="sqlStr">A valid SQL statement to be passed to the database.</param>
    ''' <remarks></remarks>
    Public Sub LoadItemsFromRenData(ByVal sqlStr As String)
        Dim myData As SqlDataReader = mRenData.ExecuteReader(sqlStr)

        Do While myData.Read()
            Select Case myData.FieldCount
                Case 0
                    Exit Sub
                Case 1
                    AddComboItem(myData(0).ToString, myData(0).ToString())
                Case Else
                    AddComboItem(myData(0).ToString, myData(1).ToString())
            End Select
        Loop

        myData.Close()
    End Sub

    Public Sub AddComboItem(ByVal theCode As String, ByVal theDescription As String)
        Me.Add(New ComboListItem(theCode, theDescription))
    End Sub

    Public Sub UpdateComboItem(ByVal theCode As String, ByVal theDescription As String)
        Dim j As ComboListItem

        For Each j In Me
            If j.Code = theCode Then
                j.Description = theDescription
                Exit Sub
            End If
        Next
    End Sub
End Class