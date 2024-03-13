Imports MySql.Data.MySqlClient
Imports System.Threading
Public Class frmMembers
    Dim table As String
    Friend DataAdpt As New MySqlDataAdapter("Select * from student;", Conn)

    Private Sub frmMembers_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub btnHOME_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub frmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn.Open()
        Me.LibraryDB.Clear()
        DataAdpt.Fill(Me.LibraryDB.student)
        Conn.Close()
    End Sub

    Private Sub btnNewBatch_Click(sender As Object, e As EventArgs) Handles btnNewBatch.Click
        If btnNewBatch.Text = "Cancel" Then
            gridMembership.Enabled = True
            pnlDetails2.Enabled = False
            btnUpdateMem.Text = "Update Details"
            btnNewBatch.Text = "Add New Batch"
        Else
            Dim form As New frmNewBatch
            form.Show()
        End If

    End Sub

    Private Sub btnUpdateMem_Click(sender As Object, e As EventArgs) Handles btnUpdateMem.Click

        Dim boolActive As Integer

        If chkActive.Checked Then
            boolActive = 1
            pbxActive.Image = My.Resources.activeMem
        Else
            boolActive = 0
            pbxActive.Image = My.Resources.inactiveMem
        End If

        If btnUpdateMem.Text = "Save" Then
            Try
                Conn.Open()
                Dim cmdSQL As New MySqlCommand("UPDATE STUDENT SET `First_Name`='" & txtFName.Text & _
                                               "',`Last_Name`='" & txtLName.Text & "',`NIC`='" & txtNIC.Text & _
                                               "',`Address`='" & txtAddress.Text & "',`Department`='" & _
                                               cmbDep.SelectedValue.ToString & "',`Year`='" & txtYear.Text & _
                                               "',`Course_Type`='" & cmbType.Text & "',`AdmissionNo`='" & txtAdmission.Text & _
                                               "',`Gender`='" & txtGender.Text & "',`Telephone`='" & txtTelephone.Text & _
                                               "',`Active`='" & boolActive & "' WHERE STUDENTID = '" & txtStudID.Text & _
                                               "';", Conn)
                cmdSQL.ExecuteNonQuery()

                DataAdpt.Update(LibraryDB.student)
                DataAdpt.Fill(Me.LibraryDB.student)
                MsgBox("Data Updated")
                gridMembership.Enabled = True
                pnlDetails2.Enabled = False
                btnUpdateMem.Text = "Update Details"
                btnNewBatch.Text = "Add New Batch"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Refresh()
        Else
            Conn.Close()
            Conn.Open()
            Me.DepartmentTableAdapter.Fill(LibraryDB.department)
            Conn.Close()

            gridMembership.Enabled = False
            pnlDetails2.Enabled = True
            btnUpdateMem.Text = "Save"
            btnNewBatch.Text = "Cancel"
        End If
        Conn.Close()
    End Sub

    Private Sub txtMemSearch_TextChanged(sender As Object, e As EventArgs) Handles txtMemSearch.TextChanged
        If Not txtMemSearch.Text Is "Search Here" Then
            cmbDataField_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub txtMemSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtMemSearch.MouseClick
        txtMemSearch.Clear()
    End Sub

    Private Sub cmbDataField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDataField.SelectedIndexChanged
        If cmbDataField.SelectedItem.ToString = "Admission No" Then
            table = "AdmissionNo"
        ElseIf cmbDataField.SelectedItem.ToString = "Last Name" Then
            table = "Last_Name"
        ElseIf cmbDataField.SelectedItem.ToString = "NIC" Then
            table = "NIC"
        ElseIf cmbDataField.SelectedItem.ToString = "Student ID" Then
            table = "StudentID"
        ElseIf cmbDataField.SelectedItem.ToString = "Telephone" Then
            table = "Telephone"
        Else
            table = "First_Name"
        End If

        If Not txtMemSearch.Text Is Nothing Then
            LibraryDB.Clear()

            Dim adp As New MySqlDataAdapter("Select * from Student WHERE " & table & _
                                            " LIKE '%" & txtMemSearch.Text & "%';", Conn)
            Dim dataTable As New DataTable

            adp.Fill(LibraryDB.student)
            Conn.Close()
        End If
        Me.Refresh()
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub chkActive_CheckedChanged(sender As Object, e As EventArgs) Handles chkActive.CheckedChanged
        If chkActive.Checked Then
            pbxActive.Image = My.Resources.activeMem
        Else
            pbxActive.Image = My.Resources.inactiveMem
        End If
    End Sub

    Private Sub txtStudID_TextChanged(sender As Object, e As EventArgs) Handles txtStudID.TextChanged
        If Not txtStudID.Text = Nothing Then
            Dim da As New MySqlDataAdapter("Select * from issue_book where studentid = '" & txtStudID.Text & "';", Conn)
            Dim da2 As New MySqlDataAdapter("Select sum(fine) from issue_book where studentid = '" & txtStudID.Text & "';", Conn)
            Dim ds As New DataSet
            Try
                Conn.Open()
                LibraryDB.issue_book.Clear()
                da.Fill(LibraryDB.issue_book)
                da2.Fill(ds, "fine")
                If ds.Tables("fine").Rows.Count > 0 Then
                    txtFine.Text = "Rs: " & ds.Tables("fine").Rows(0).Item(0) & ".00"
                Else
                    txtFine.Text = "Rs: 0.00"
                End If

            Catch ex As Exception

            End Try
        End If

        Conn.Close()
    End Sub

    Private Sub gridMembership_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles gridMembership.CellContentClick
        Label2.Text = "History of Issued Books : " & txtFName.Text & " " & txtLName.Text
        txtStudID_TextChanged(sender, e)
    End Sub
End Class