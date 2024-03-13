Public Class frmSuccessfull

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Dispose()
    End Sub

    Private Sub frmSuccessfull_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmIssueBooks.txtBarCodeInput.Focus()
        frmIssueBooks.Show()
    End Sub

    Private Sub frmSuccessfull_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl1.Text = frmIssueBooks.issueID
        lbl2.Text = frmIssueBooks.stdName
        lbl3.Text = frmIssueBooks.bkTitle
        lbl4.Text = Now.Year & "-" & Now.Month & "-" & (Val(Now.Day.ToString) + 14)
        Me.Refresh()
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MetroProgressBar1.PerformStep()
        If MetroProgressBar1.Value = 100 Then
            Me.Dispose()
        End If
    End Sub
End Class