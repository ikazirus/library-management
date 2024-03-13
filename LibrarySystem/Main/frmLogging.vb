Imports MySql.Data.MySqlClient
Imports MySql.Data

Public Class frmLogging

    Dim comm As MySqlCommand
    Dim strUser As String
    Dim strPass As String
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Conn.Open()
            comm = New MySqlCommand("SELECT * FROM patron WHERE User_Name='" & txtUserName.Text & _
                                    "' AND Password=MD5('" & txtPassword.Text & "');", Conn)
            Dim sqlReader As MySqlDataReader = comm.ExecuteReader()

            If Not sqlReader.HasRows Or txtPassword.Text = Nothing Or txtUserName.Text = Nothing Then
                lblStat.Text = ("User name or Password is incorrect.Try again.")
                txtPassword.Clear()
                txtUserName.Clear()
                txtUserName.Focus()
            Else
                While sqlReader.Read()
                    If sqlReader.HasRows And sqlReader("Type") = "admin" Then
                        If cbxRememberMe.Checked Then
                            My.Settings.LoggedIN = True
                        End If
                        lblStat.Text = ("You logged in as an Admin.")
                        frmMain.btnLogout.Text = "Log Out"
                        frmMain.lblPatronName.Show()
                        frmMain.lblPatronName.Text = txtUserName.Text.ToUpper
                        patron = txtUserName.Text
                        frmMain.btnBooks.Enabled = True
                        frmMain.btnMembers.Enabled = True
                        frmMain.btnSettings.Enabled = True
                        frmMain.btnReports.Enabled = True
                        frmMain.btnPrint.Enabled = True
                        frmMain.btnIssue.Enabled = True
                        frmMain.btnIssue.Focus()
                        Dim frmB As New frmBusy With {.duration = 1}
                        frmB.Show()
                        Me.Dispose()
                    ElseIf sqlReader.HasRows And sqlReader("Type") <> "admin" Then
                        If cbxRememberMe.Checked Then
                            My.Settings.LoggedIN = True
                        End If
                        lblStat.Text = ("You logged in as a Patron.")
                        frmMain.lblPatronName.Show()
                        frmMain.btnLogout.Text = "Log Out"
                        frmMain.lblPatronName.Text = txtUserName.Text.ToUpper
                        patron = txtUserName.Text
                        frmMain.btnBooks.Enabled = True
                        frmMain.btnMembers.Enabled = True
                        frmMain.btnSettings.Enabled = False
                        frmMain.btnReports.Enabled = True
                        frmMain.btnPrint.Enabled = True
                        frmMain.btnIssue.Enabled = True
                        frmMain.btnIssue.Focus()
                        Dim frmB As New frmBusy With {.duration = 1}
                        frmB.Show()
                        Me.Dispose()

                    Else
                        txtPassword.Clear()
                        txtUserName.Clear()
                    End If
                End While
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Private Sub chkShow_CheckedChanged(sender As Object, e As EventArgs) Handles chkShow.CheckedChanged
        If chkShow.Checked Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub cbxRememberMe_CheckedChanged(sender As Object, e As EventArgs) Handles cbxRememberMe.CheckedChanged
        If cbxRememberMe.Checked Then
            LibrarySystem.My.Settings.UserName = txtUserName.Text
            LibrarySystem.My.Settings.Password = txtPassword.Text
        Else
            LibrarySystem.My.Settings.UserName = Nothing
            LibrarySystem.My.Settings.Password = Nothing
            My.Settings.LoggedIN = False
        End If
    End Sub

    Private Sub frmLogging_Load(sender As Object, e As EventArgs) Handles Me.Shown
        If Not My.Settings.LoggedIN Then
            txtUserName.Text = LibrarySystem.My.Settings.UserName
            txtPassword.Text = LibrarySystem.My.Settings.Password
            btnLogin.Focus()
        End If
        txtUserName.Focus()
    End Sub
End Class