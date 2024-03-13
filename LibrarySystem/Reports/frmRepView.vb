Imports CrystalDecisions.CrystalReports.Engine

Public Class frmRepView
    Dim rpt As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub frmRepView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If frmReports.rbtnAllOverdues.Checked Then
            rpt.Load(Environment.CurrentDirectory & "\Reports\OverDueReport.rpt")
        Else
            rpt.Load(Environment.CurrentDirectory & "\Reports\FullReport.rpt")
        End If

        Try
            rpt.SetDataSource(frmReports.LibrarydbDataSet)
            CrystalReportViewer1.ReportSource = rpt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmReports.Show()
        Me.Dispose()
    End Sub

End Class