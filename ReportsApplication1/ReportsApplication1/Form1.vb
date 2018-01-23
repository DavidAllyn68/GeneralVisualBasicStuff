Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DPRDataSet.DPR' table. You can move, or remove it, as needed.
        Me.DPRTableAdapter.Fill(Me.DPRDataSet.DPR)
        Me.ReportViewer1.RefreshReport()
    End Sub

End Class
