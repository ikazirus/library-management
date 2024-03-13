Imports MySql.Data.MySqlClient

Public Class frmTransactionMonitor
    Dim dsMem, dsBk, dsIssue As New DataSet
    Dim strIssueID As String = Now.ToString("yyMMddHHmmss")
    Dim flag1, flag2 As Boolean
    Dim strBookID, strMemID As String
    Dim strComm, strBorrowedDate, strDuedate, bookissued As String
    Dim intNoOfDays, intFine As Integer

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Dispose()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub time_Tick(sender As Object, e As EventArgs) Handles time.Tick
        lblTime.Text = Now.ToString("HH:mm:ss")
        If flag1 Then
            lblBook.Show()
            lblMem.Show()
            If lblBook.ForeColor = Color.Black Then
                lblBook.ForeColor = Color.red
            Else
                lblBook.ForeColor = Color.Black
            End If
        End If
        If flag2 Then
            If lblMem.ForeColor = Color.Black Then
                lblMem.ForeColor = Color.red
            Else
                lblMem.ForeColor = Color.Black
            End If
        End If


    End Sub

    Private Sub frmTransactionMonitor_Load(sender As Object, e As EventArgs) Handles Me.Load
        time.Start()
        txtBCinput.Focus()
        flag1 = True
        flag2 = True
    End Sub

    Private Sub getBook(bID As String)
        Dim da As New MySqlDataAdapter("Select * from book where ISBN = (select isbn from book_ascn where asseccion_id = '" & bID & "' );", Conn)
        Dim da2 As New MySqlDataAdapter("Select * from book_ascn where Asseccion_ID='" & bID & "';", Conn)

        dsBk.Clear()
        Conn.Open()
        da.Fill(dsBk, "book")
        da2.Fill(dsBk, "book_ascn")
        Conn.Close()
        If dsBk.Tables("book").Rows.Count > 0 And dsBk.Tables("book_ascn").Rows.Count > 0 Then
            strBookID = bID
            With dsBk.Tables(0).Rows(0)
                lblBook.Text = "# Title :   " & .Item("title") & vbNewLine & "# ISBN  :   " & .Item("ISBN")
                lblBook.TextAlign = ContentAlignment.MiddleLeft
            End With

            If dsBk.Tables("book_ascn").Rows(0).Item("Issued") Then
                pbxBook.BringToFront()
                pbxBook.Image = My.Resources.inactiveBook
                lblBook.ForeColor = Color.red
            Else
                pbxBook.BringToFront()
                pbxBook.Image = My.Resources.activeBook
                lblBook.ForeColor = Color.Black
            End If
            flag1 = False
        End If


    End Sub

    Private Sub getMem(mID As String)
        Dim da As New MySqlDataAdapter("Select * from student where StudentID = '" & mID & "' ;", Conn)

        dsMem.Clear()
        Conn.Open()
        da.Fill(dsMem, "student")
        Conn.Close()
        If dsMem.Tables("student").Rows.Count > 0 Then
            strMemID = mID
            With dsMem.Tables(0).Rows(0)
                lblMem.Text = "# Name  :   " & .Item("First_Name") & " " & .Item("Last_Name") & vbNewLine & "# NIC     :   " & .Item("NIC")
                lblMem.TextAlign = ContentAlignment.MiddleLeft
            End With

            If Not dsMem.Tables("student").Rows(0).Item("Active") Then
                pbxStud.BringToFront()
                pbxStud.Image = My.Resources.inactiveMem
                lblMem.ForeColor = Color.red
            Else
                pbxStud.BringToFront()
                pbxStud.Image = My.Resources.activeMem
                lblMem.ForeColor = Color.Black
            End If
            flag2 = False
        End If

    End Sub

    Private Sub checking()
        If dsMem.Tables("student").Rows.Count > 0 And dsBk.Tables("book").Rows.Count > 0 Then
            pbxBC.SendToBack()
            If dsMem.Tables("student").Rows(0).Item("Active") Then 'Validate the member

                If dsBk.Tables("book").Rows(0).Item("Available") Then 'Validate the Book for lending

                    If dsBk.Tables("book").Rows(0).Item("section") = "Lendings" Then 'Determine the section

                        If Not dsBk.Tables("book_ascn").Rows(0).Item("Issued") And _
                            Not dsMem.Tables("student").Rows(0).Item("L_Book_Issued") Then
                            issueNewBook("L")
                            pbxIssued.Image = My.Resources.success

                        ElseIf dsBk.Tables("book_ascn").Rows(0).Item("Issued") And _
                             dsMem.Tables("student").Rows(0).Item("L_Book_Issued") Then
                            returnBook("L")
                            pbxIssued.Image = My.Resources.success
                        Else
                            lblIssue.Text = ("You can not borrow Lending section books.")
                            pbxIssued.Image = My.Resources.invalid
                        End If


                    ElseIf dsBk.Tables("book").Rows(0).Item("section") = "Reference" Then

                        If Not dsMem.Tables("student").Rows(0).Item("R_Book_Issued") And _
                              Not dsBk.Tables("book_ascn").Rows(0).Item("Issued") Then
                            issueNewBook("R")
                            pbxIssued.Image = My.Resources.success

                        ElseIf dsMem.Tables("student").Rows(0).Item("R_Book_Issued") And _
                           dsBk.Tables("book_ascn").Rows(0).Item("Issued") Then
                            returnBook("R")
                            pbxIssued.Image = My.Resources.success
                        Else
                            lblIssue.Text = ("You can not borrow Reference section books.")
                            pbxIssued.Image = My.Resources.invalid
                        End If

                    End If
                Else
                    lblIssue.Text = ("The book is not available for lending.")
                    pbxIssued.Image = My.Resources.invalid
                End If
            Else
                lblIssue.Text = ("Your Membership is deactivated.")
                pbxIssued.Image = My.Resources.invalid
            End If
        End If
    End Sub

    Private Sub issueNewBook(x As String)

        Select Case x
            Case "L"
                intNoOfDays = 14
                bookissued = "UPDATE `student` SET `L_Book_Issued` = '1' WHERE `student`.`StudentID` ='"
            Case "R"
                intNoOfDays = 1
                bookissued = "UPDATE `student` SET `R_Book_Issued` = '1' WHERE `student`.`StudentID` ='"
        End Select

        strBorrowedDate = Now.ToString("yyyy-MM-dd")
        strDuedate = Now.Date.AddDays(intNoOfDays).ToString("yyyy-MM-dd")


        strComm = ("INSERT INTO `issue_book` (`Issue_ID`, `Accession_ID`, `StudentID`, `Patron`, `Borrowed_Date`, " & _
                       "`Due_Date`, `Returned_Date`, `Returned`, `Fine`) VALUES " & _
                       " ('" & strIssueID & "', '" & strBookID & "', '" & strMemID & "', '" & patron & "', '" & strBorrowedDate & "'," & _
                       " '" & strDuedate & "', NULL, '0', '0');")

        Try
            Conn.Open()
            Dim comm As New MySqlCommand(strComm, Conn)
            comm.ExecuteNonQuery()
            Dim comm2 As New MySqlCommand(bookissued & strMemID & "';", Conn)
            comm2.ExecuteNonQuery()
            Dim comm3 As New MySqlCommand("UPDATE `book_ascn` SET `Issued` = '1' WHERE `book_ascn`.`Asseccion_ID` ='" & strBookID & "';", Conn)
            comm3.ExecuteNonQuery()
            lblIssue.Text = "Book Issued successfully" & vbNewLine & "Due date : " & strDuedate
        Catch ex As Exception
            lblIssue.Text = lblIssue.Text & vbNewLine & ex.Message
        End Try
        Conn.Close()
    End Sub

    Private Sub returnBook(x As String)
        Dim da As New MySqlDataAdapter("Select * from issue_book where accession_id = '" & strBookID & "' and studentid='" & strMemID & "' and returned = '0';", Conn)
        dsIssue.Clear()
        Conn.Open()
        da.Fill(dsIssue, "issue_book")
        Select Case x
            Case "L"
                If Today.Subtract(dsIssue.Tables(0).Rows(0).Item("due_date")).Days >= 0 Then
                    intFine = Today.Subtract(dsIssue.Tables(0).Rows(0).Item("due_date")).Days * 2
                Else
                    intFine = 0
                End If
                bookissued = "UPDATE `student` SET `L_Book_Issued` = '0' WHERE `student`.`StudentID` ='"
            Case "R"
                If Today.Subtract(dsIssue.Tables(0).Rows(0).Item("due_date")).Days >= 0 Then
                    intFine = Today.Subtract(dsIssue.Tables(0).Rows(0).Item("due_date")).Days * 10
                Else
                    intFine = 0
                End If
                bookissued = "UPDATE `student` SET `R_Book_Issued` = '0' WHERE `student`.`StudentID` ='"
        End Select

        strComm = ("UPDATE `issue_book` SET `Returned_Date`='" & Now.ToString("yyyy-MM-dd") & "',`Returned`='1'," & _
                               "`Fine`=" & intFine & " WHERE issue_id= '" & dsIssue.Tables(0).Rows(0).Item("issue_id") & "';")
        Try
            Dim comm As New MySqlCommand(strComm, Conn)
            comm.ExecuteNonQuery()
            Dim comm2 As New MySqlCommand(bookissued & strMemID & "';", Conn)
            comm2.ExecuteNonQuery()
            Dim comm3 As New MySqlCommand("UPDATE `book_ascn` SET `Issued` = '0' WHERE `book_ascn`.`Asseccion_ID` ='" & strBookID & "';", Conn)
            comm3.ExecuteNonQuery()
        Catch ex As Exception
            lblIssue.Text = lblIssue.Text & vbNewLine & ex.Message
        End Try

        Conn.Close()
        lblIssue.Text = ("Thanks for Returning." & vbNewLine & "Fine = Rs. " & intFine & " /=")
    End Sub

    Private Sub txtBCinput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBCinput.KeyDown
        If pbr1.Value = 100 Then
            If e.KeyCode = Keys.Return Then
                If txtBCinput.Text.ToUpper.Contains("BK") Then
                    getBook(txtBCinput.Text)
                    txtBCinput.Clear()
                Else
                    getMem(txtBCinput.Text)
                    txtBCinput.Clear()
                End If
                If Not flag1 And Not flag2 Then
                    checking()
                    countDown.Start()
                End If
            End If
        End If
    End Sub

    Private Sub countDown_Tick(sender As Object, e As EventArgs) Handles countDown.Tick
        If pbr1.Value <> 0 Then
            pbr1.Value = pbr1.Value - 1
        Else
            lblBook.Text = "Please Verify Your " & vbNewLine & "Book ID"
            lblMem.Text = "Please Verify Your " & vbNewLine & "Membership ID"
            pbxBC.BringToFront()
            pbxBook.SendToBack()
            pbxStud.SendToBack()
            flag1 = True
            flag2 = True
            lblBook.TextAlign = ContentAlignment.MiddleCenter
            lblMem.TextAlign = ContentAlignment.MiddleCenter
            pbr1.Value = 100
            dsBk.Clear()
            dsIssue.Clear()
            dsMem.Clear()
            txtBCinput.Focus()
            countDown.Stop()
        End If
    End Sub

    Private Sub txtBCinput_Leave(sender As Object, e As EventArgs) Handles txtBCinput.Leave
        txtBCinput.Focus()
    End Sub
End Class