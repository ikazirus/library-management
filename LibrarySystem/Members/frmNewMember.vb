Imports MySql.Data.MySqlClient

Public Class frmNewMember
    Dim comm As MySqlCommand
    Dim lastID, MembershipID, count As Integer
    Dim gender As String

    Private Sub getMemberID()

        Try
            Conn.Open()
            comm = New MySqlCommand("SELECT COUNT(*) FROM `student`;", Conn)
            Dim sqlReader As MySqlDataReader = comm.ExecuteReader()
            While sqlReader.Read()
                lastID = Val(sqlReader(0).ToString) + 10000
            End While
            MembershipID = lastID + 1
            Conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub InsertAMember()
        If rbnMale.Checked Then
            gender = "M"
        ElseIf rbnFemale.Checked Then
            gender = "F"
        End If
        'Insert New member
        Try
            Conn.Open()
            comm = New MySqlCommand("INSERT INTO `student` (`StudentID`, `First_Name`, `Last_Name`, `NIC`, `Address`," & _
                                    " `Department`, `Year`, `Course_Type`, `AdmissionNo`, `Gender`, `Telephone`, active ," & _
                                    "l_book_issued, r_book_issued) VALUES ('" & _
                                    MembershipID & "', '" & txtFName.Text & "', '" & txtLName.Text & _
                                    "', '" & txtNIC.Text & "', '" & txtAddress.Text & "', '" & depID & _
                                    "', '" & Year & "', '" & CourseType & "', '" & txtAdmNo.Text & _
                                    "', '" & gender & "', '" & txtTP.Text & "','1','0','0');", Conn)
            comm.ExecuteNonQuery()
            count = count + 1
            For Each txt In {txtAddress, txtAdmNo, txtFName, txtLName, txtNIC, txtTP}
                txt.Clear()
            Next
            MembershipID = MembershipID + 1
            frmMembers.LibraryDB.Clear()
            frmMembers.DataAdpt.Fill(frmMembers.LibraryDB.student)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Private Sub btnAddMem_Click(sender As Object, e As EventArgs) Handles btnAddMem.Click
        txtFName.Focus()
        If pb1.Value >= 100 Then
            InsertAMember()
            MsgBox("Successfully inserted " & count - 1 & " new students.")
            frmMembers.Show()
            Me.Dispose()

        Else
            If count = numberOfStudents - 1 Then
                btnAddMem.Text = "Finish"
                Refresh()
            End If
            InsertAMember()
            pb1.Value = count * (100 / numberOfStudents)
            Me.Text = "MEMBER :-" & count & "/" & numberOfStudents
            lblMemID.Text = MembershipID
            rbnMale.Checked = True
            Me.Refresh()
            
        End If

    End Sub


    Private Sub btnClearMember_Click(sender As Object, e As EventArgs) Handles btnClearMember.Click
        For Each txt In {txtAddress, txtAdmNo, txtFName, txtLName, txtNIC, txtTP}
            txt.Clear()
        Next
        rbnMale.Checked = True
    End Sub

    Private Sub frmNewMember_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMembers.LibraryDB.student.Clear()
        frmMembers.DataAdpt.Fill(frmMembers.LibraryDB.student)
        frmMembers.Refresh()
    End Sub

    Private Sub frmNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getMemberID()
        Me.Text = "MEMBER :-" & "1" & "/" & numberOfStudents
        pb1.Value = 1 * (100 / numberOfStudents)
        lblMemID.Text = MembershipID
        count = 1
    End Sub

    Private Sub txtNIC_TextChanged(sender As Object, e As EventArgs) Handles txtNIC.TextChanged
        If txtNIC.TextLength >= 9 Then
            txtTP.Focus()
            txtNIC.ForeColor = Color.Black
        Else
            txtNIC.ForeColor = Color.Red
        End If
    End Sub

    Private Sub txtTP_TextChanged(sender As Object, e As EventArgs) Handles txtTP.TextChanged
        If txtTP.TextLength >= 10 Then
            txtAdmNo.Focus()
            txtTP.ForeColor = Color.Black
        Else
            txtTP.ForeColor = Color.Red
        End If
    End Sub
End Class