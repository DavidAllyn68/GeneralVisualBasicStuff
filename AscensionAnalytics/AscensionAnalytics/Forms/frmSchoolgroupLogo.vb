Imports System.IO

Public Class frmSchoolgroupLogo
    Dim mDataContext As New SchoolgroupLogoDataContext()
    Dim mLookup As New LookupTablesDataContext()

    Private Sub frmSchoolgroupLogo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        bsSchoolgroupLogo.DataSource = mDataContext.schoolgroup_logos

        bsSchoolgroups.DataSource = mLookup.LookupSchoolgroups
        grexSchoolgroups.DropDowns("ddSchoolgroups").SetDataBinding(bsSchoolgroups, String.Empty)


    End Sub

    Public Sub SaveData()
        Try
            bsSchoolgroupLogo.EndEdit()
            mDataContext.SubmitChanges()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " SaveData()")

        End Try
    End Sub


    Private Sub cmdBtnPickImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBtnPickImage.Click
        Try
            UpdatePictureBoxImageFromFile()
            SaveData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Name & " cmdBtnPickImage_Click")
        End Try

    End Sub

    Private Sub grexSchoolgroups_RecordAdded(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordAdded
        SaveData()
    End Sub

    Private Sub grexSchoolgroups_RecordsDeleted(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordsDeleted
        SaveData()
    End Sub

    Private Sub grexSchoolgroups_RecordUpdated(ByVal sender As Object, ByVal e As System.EventArgs) Handles grexSchoolgroups.RecordUpdated
        'nothing. we are not editing the grid only adding, deleting, and changing the picture
    End Sub

    Private Sub UpdatePictureBoxImageFromFile()
        Try
            Dim _openFileDialogue As New OpenFileDialog()
            With New OpenFileDialog
                .Multiselect = False
                .Title = "Select the logo (only .JPG are allowed)"
                .Filter = "JPEG Files (.jpg)|*.jpg"
                .ShowDialog()
                Dim _filePath As String = .FileName
                If _filePath = String.Empty Then Exit Sub

                Dim _image As Image
                _image = Image.FromFile(.FileName)

                Dim _heightWidthRatio As Decimal = _image.Height / _image.Width


                'Validate image to make sure it will work on reporting
                If _heightWidthRatio <= 0.9 Or _heightWidthRatio >= 1.1 Then
                    Throw New ReportingLogoImageException("This picture's height and width are too different to use.  It will appear very small in reporting.  Please edit the picture to be an optimal 300x300 pixels.")
                End If

                If Image.IsAlphaPixelFormat(_image.PixelFormat) = True Then
                    Throw New ReportingLogoImageException("This image will not show properly on reporting because it has alpha properties.  Please reformat the picture without alpha.")
                End If

                If _image.Height > 900 Or _image.Width > 900 Then
                    Throw New ReportingLogoImageException("This picture is too big to use on reporting.  Please edit the picture to be an optimal 300x300 pixels.")
                End If

                If _image.Height < 100 Or _image.Width < 100 Then
                    Throw New ReportingLogoImageException("This picture is too small to use on reporting (it will appear pixelated).  Please edit the picture to be an optimal 300x300 pixels.")
                End If

                pixLogo.Image = _image
            End With
        Catch ex As Exception
            If TypeOf ex Is ReportingLogoImageException Then
                MessageBox.Show(ex.Message, "Picture Needs Reformatting")
            Else
                MessageBox.Show(ex.Message, Me.Name & " UpdatePictureBoxImageFromFile Error")
            End If



        End Try
    End Sub
End Class


Public Class ReportingLogoImageException
    Inherits Exception

    Public Sub New(ByVal _message As String)
        MyBase.New(_message)
    End Sub
End Class