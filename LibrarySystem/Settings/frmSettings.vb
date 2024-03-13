Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class frmSettings
    Dim rpt As New ReportDocument
    Dim ds1, ds2 As New DataSet

    Private Sub frmSettings_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.PatronTableAdapter.Fill(Me.LibraryDB.patron)
         End Sub


    Private Sub btnAddPatron_Click(sender As Object, e As EventArgs) Handles btnAddPatron.Click
        If txtPPass.Text = txtPPass2.Text Then
            Try
                Conn.Open()
                Dim comm As New MySqlCommand("INSERT INTO PATRON VALUES ('" & txtPName.Text & "',MD5('" & txtPPass.Text & "'),'" & cmbType.SelectedValue & "');", Conn)
                comm.ExecuteNonQuery()
                MsgBox("Patron added successfully")
                LibraryDB.patron.Clear()
                PatronTableAdapter.Fill(LibraryDB.patron)
                btnCancel_Click(sender, e)
            Catch ex As Exception

            End Try
            Conn.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtPName.Clear()
        txtPPass.Clear()
        txtPPass2.Clear()
        cmbType.Text = ""
    End Sub


    Private Sub txtPPass2_TextChanged(sender As Object, e As EventArgs) Handles txtPPass2.TextChanged
        If Not txtPPass.Text = txtPPass2.Text Then
            lblPWerror.Show()
        Else
            lblPWerror.Hide()
        End If
    End Sub

    Private Sub btnRemovePatron_Click(sender As Object, e As EventArgs) Handles btnRemovePatron.Click
        If LibraryDB.patron.Rows.Count > 1 Then
            If cmbPatronList.SelectedValue.ToString <> patron Then
                Try
                    Conn.Open()
                    Dim comm As New MySqlCommand("DELETE FROM `patron` WHERE `patron`.`User_Name` = '" & cmbPatronList.SelectedValue.ToString & "';", Conn)
                    comm.ExecuteNonQuery()
                    LibraryDB.patron.Clear()
                    PatronTableAdapter.Fill(LibraryDB.patron)
                    MsgBox("Patron deletion , Successfull")
                Catch ex As Exception

                End Try
                Conn.Close()
            Else
                MsgBox("You can't remove yourself.")
            End If

        Else
            MsgBox("You can't remove all the admins/patrons")
        End If

    End Sub

    'Private Sub btnBackup_Click(sender As Object, e As EventArgs) Handles btnBackup.Click
    '    Dim comm As New MySqlCommand("", Conn)
    '    Dim mb As New MySqlBackup
    '    Try
    '      Conn.Open()
    '        mb.ExportToFile(txtBckpPath.Text & Now.ToString("\yyyy-MM-dd-HH-mm.sql"))
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    '    Conn.Close()

    'End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click, btnSave.Click
        Dim file As String
        Dim sfd As New SaveFileDialog

        sfd.Filter = "SQL Backup (*.sql)|*.sql|All files (*.*)|*.*"
        sfd.FileName = "LIBRARY DATABASE " + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".sql"
        If sfd.ShowDialog = DialogResult.OK Then
            file = sfd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u " & userId & " --password=" & password & "	-h " & server & " " & database & " > """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Backup Created Successfully!", MsgBoxStyle.Information, "Backup")
        End If
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        Dim file As String
        Dim opd As New OpenFileDialog

        opd.Filter = "SQL Backup  (*.sql)|*.sql|All files (*.*)|*.*"
        If opd.ShowDialog = DialogResult.OK Then
            file = opd.FileName
            Dim myProcess As New Process()
            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.WorkingDirectory = "C:\Program Files\MySQL\MySQL Server 5.7\bin\"
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.Start()
            Dim myStreamWriter As StreamWriter = myProcess.StandardInput
            Dim mystreamreader As StreamReader = myProcess.StandardOutput
            myStreamWriter.WriteLine("mysql -u " & userId & " --password=" & password & "	-h " & server & " " & database & " < """ + file + """ ")
            myStreamWriter.Close()
            myProcess.WaitForExit()
            myProcess.Close()
            MsgBox("Database Restored Successfully!", MsgBoxStyle.Information, "Restore")
        End If

    End Sub

End Class