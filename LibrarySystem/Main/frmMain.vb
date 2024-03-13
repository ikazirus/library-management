Public Class frmMain

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlMenuSub.SetBounds((Me.Size.Width - pnlMenuSub.Size.Width) / 2, ((Me.Size.Height - pnlMenuSub.Size.Height) / 2) + 50, pnlMenuSub.Size.Width, pnlMenuSub.Size.Height)
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        AboutBox.Show()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click, btnSettings.Click, lblSettings.Click, lblPrint.Click
        frmSettings.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click, btnReports.Click, lblReports.Click
        frmReports.Show()
        Me.Hide()
    End Sub

    Private Sub btnIssue_Click(sender As Object, e As EventArgs) Handles btnIssue.Click, btnIssue.Click, lblIssue.Click
        frmTransactionMonitor.Show()
        Me.Hide()
    End Sub

    Private Sub btnMembers_Click(sender As Object, e As EventArgs) Handles btnMembers.Click, btnMembers.Click, lblMembers.Click
        frmMembers.Show()
        Me.Hide()
    End Sub

    Private Sub btnBooks_Click(sender As Object, e As EventArgs) Handles btnBooks.Click, btnBooks.Click, lblBooks.Click
        frmBooks.Show()
        Me.Hide()
    End Sub


    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        frmPrint.Show()
        Me.Hide()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Connect()
        If My.Settings.LoggedIN Then
            patron = My.Settings.UserName
            btnLogout.Text = "Log Out"
            lblPatronName.Text = patron
        Else
            btnLogout.Text = "Log In"

            frmLogging.Show()
            frmLogging.txtUserName.Text = My.Settings.UserName
            frmLogging.txtUserName.Focus()
        End If

        For Each btn In {btnBooks, btnIssue, btnMembers, btnReports, btnSettings, btnPrint}
            If My.Settings.LoggedIN Then
                btn.Enabled = True
            Else
                btn.Enabled = False
            End If
        Next
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        If My.Settings.LoggedIN Then
            For Each btn In {btnBooks, btnIssue, btnMembers, btnReports, btnSettings, btnPrint}
                btn.Enabled = False
            Next
            My.Settings.UserName = Nothing
            My.Settings.Password = Nothing
            My.Settings.LoggedIN = False
            btnLogout.Text = "Log In"
            lblPatronName.Hide()
        Else
            btnLogout.Text = "Log In"
            If btnLogout.Text = "Log In" Then
                frmLogging.Show()
            End If
        End If

    End Sub


    Private Sub lblPatronName_Click(sender As Object, e As EventArgs) Handles lblPatronName.Click
            btnLogout_Click(sender, e)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub hideLbls()
        For Each lbl In {lblBooks, lblIssue, lblMembers, lblReports, lblSettings, lblPrint}
            lbl.Hide()
        Next
    End Sub

    Private Sub pnlMenu_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlMenu.MouseMove, pnlMenuSub.MouseMove
        hideLbls()
    End Sub

    Private Sub btnMenuIssue_MouseMove(sender As Object, e As MouseEventArgs) Handles btnIssue.MouseMove, btnIssue.MouseMove

        lblIssue.Show()
    End Sub

    Private Sub btnPrint_MouseMove(sender As Object, e As MouseEventArgs) Handles btnPrint.MouseMove
        lblPrint.Show()
    End Sub
    Private Sub btnMenuMembers_MouseMove(sender As Object, e As MouseEventArgs) Handles btnMembers.MouseMove, btnMembers.MouseMove

        lblMembers.Show()
    End Sub

    Private Sub btnMenuBooks_MouseMove(sender As Object, e As MouseEventArgs) Handles btnBooks.MouseMove, btnBooks.MouseMove
        lblBooks.Show()
    End Sub

    Private Sub btnMenuReports_MouseMove(sender As Object, e As MouseEventArgs) Handles btnReports.MouseMove, btnReports.MouseMove
        lblReports.Show()
    End Sub

    Private Sub btnMenuSettings_MouseMove(sender As Object, e As MouseEventArgs) Handles btnSettings.MouseMove, btnSettings.MouseMove
        lblSettings.Show()
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Conn.Dispose()
    End Sub

End Class