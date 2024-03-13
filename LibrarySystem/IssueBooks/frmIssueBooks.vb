Imports MySql.Data.MySqlClient

Public Class frmIssueBooks
    Dim comm, comm2 As MySqlCommand
    Dim flagSTD, flagBook, flagLendingEligible, flagReferenceEligble As Boolean
    Public strBarCode, strBookID, strStudID, strStudName, strBookTitle, strIssueID As String
    Dim strSQL, strBorrowedDate, strDuedate, strReturnedDate, strSection As String
    Dim intFine, intReturned As Integer

    Private Sub frmIssuing_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMain.Show()
    End Sub

    Private Sub frmIssuing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'To adjust the panel according to various resolutions
        pnlDetails2.SetBounds(((Me.Size.Width - pnlDetails2.Size.Width) / 2), ((Me.Size.Height - pnlDetails2.Size.Height) / 2), pnlDetails2.Size.Width, pnlDetails2.Size.Height)
        txtBarCodeInput.Focus()
        pnlMonitor.BringToFront()
        Time.Start()
    End Sub

    Private Sub Time_Tick(sender As Object, e As EventArgs) Handles Time.Tick
        lblDateTime.Text = Now
    End Sub

    'To read barcode and Verify membership details , if book is available the member can borrow
    Private Sub stdVerify()
        Conn.Open()
        comm = New MySqlCommand("SELECT * FROM student WHERE studentID = '" & strStudID & "';", Conn)
        Dim reader As MySqlDataReader = comm.ExecuteReader
        While reader.Read
            lbl1.Text = ":  " & reader(0).ToString
            strStudName = reader(1).ToString & " " & reader(2).ToString
            lbl2.Text = ":  " & strStudName
            lbl3.Text = ":  " & reader(3).ToString
            lbl4.Text = ":  " & reader(4).ToString
            lbl5.Text = ":  " & reader(5).ToString
            lbl6.Text = ":  " & reader(10).ToString

            'Check whether the student has an active membership
            If reader("Active") Then
                pbx.Image = My.Resources.activeMem

                'Check whether the book is issued from Lending Section : If so the member cant borrow a new book from lending section
                If reader("L_Book_Issued") Then
                    flagLendingEligible = False
                Else
                    flagLendingEligible = True
                End If

                'Check whether the book is issued from Reference Section : If so the member cant borrow a new book from Reference section
                If reader("R_Book_Issued") Then
                    flagReferenceEligble = False
                Else
                    flagReferenceEligble = True
                End If
                flagSTD = True
            Else
                pbx.Image = My.Resources.inactiveMem
                flagSTD = False
                flagLendingEligible = False
                flagReferenceEligble = False
            End If
            lblb1.Text = "Mem.ID "
            lblb2.Text = "Name"
            lblb3.Text = "NIC"
            lblb4.Text = "Address"
            lblb5.Text = "Dep."
            lblb6.Text = "Admsn.No"
        End While
        countdownTimer.Start()
        Me.Refresh()
        Conn.Close()
    End Sub

    'To read barcode and Verify book details , if book is available the member can borrow
    Private Sub bkVerify()
        Conn.Open()
        comm = New MySqlCommand("SELECT * FROM book WHERE Accession_ID = '" & strBookID & "';", Conn)
        Dim reader As MySqlDataReader = comm.ExecuteReader
        While reader.Read
            lbl1.Text = ":  " & reader(0).ToString
            strBookTitle = reader(1).ToString
            lbl2.Text = ":  " & strBookTitle
            lbl3.Text = ":  " & reader(2).ToString
            lbl4.Text = ":  " & reader(5).ToString
            lbl5.Text = ":  " & reader(6).ToString
            strSection = reader(4).ToString
            lbl6.Text = ":  " & strSection
            If reader("Available") Then
                pbx.Image = My.Resources.activeBook
                flagBook = True
            Else
                pbx.Image = My.Resources.inactiveBook
                flagBook = False
            End If
            lblb1.Text = "Acc ID "
            lblb2.Text = "Title"
            lblb3.Text = "ISBN"
            lblb4.Text = "Author"
            lblb5.Text = "Edition"
            lblb6.Text = "Section"
        End While
        countdownTimer.Start()
        Me.Refresh()
        Conn.Close()
    End Sub

    Private Sub countdownTimer_Tick(sender As Object, e As EventArgs) Handles countdownTimer.Tick
        If (pgrBar.Value) >= 100 Then
            txtBarCodeInput.Clear()
            lblIssueNo.Text = Nothing
            countdownTimer.Stop()
            If flagBook And flagSTD Then
                BorrowBook()
            Else
                ReturnBook()
            End If
            pgrBar.Value = 0
        Else
            pgrBar.PerformStep()
        End If
    End Sub

    Private Sub clearDetails()
        For Each lbl In {lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lblb1, lblb2, lblb3, lblb4, lblb5, lblb6, lbl11, lbl12, lbl13, lbl14, lbl15}
            lbl.Text = Nothing
        Next
        pbx.Image = Nothing
    End Sub

    Private Sub txtBarCodeInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarCodeInput.KeyDown
        If e.KeyCode = Keys.Return Then
            strBarCode = txtBarCodeInput.Text.ToUpper
            clearDetails()

            If strBarCode.Contains("BK") Then
                strBookID = strBarCode
                bkVerify()
            Else
                strStudID = strBarCode
                stdVerify()
                If Not flagLendingEligible And Not flagReferenceEligble Then
                    MsgBox("You cant borrow any book")

                ElseIf flagLendingEligible And Not flagReferenceEligble Then
                    MsgBox("Only Lendings")
                ElseIf Not flagLendingEligible And flagReferenceEligble Then
                    MsgBox("Only Refence")
                Else
                    MsgBox("Any Book")
                End If
            End If

            Refresh()
        End If
        txtBarCodeInput.Focus()
    End Sub



    'Insert Data 

    'New Book Issued
    Public Sub BorrowBook()
        strBorrowedDate = Now.ToString("yyyy-MM-dd")
        strDuedate = Now.Date.AddDays(14.0).ToString("yyyy-MM-dd")

        intReturned = 0
        intFine = 0
        strIssueID = Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute

        comm = New MySqlCommand("INSERT INTO Issue_Book (Issue_ID,Accession_ID,StudentID,Patron,Borrowed_Date,Due_Date,Returned_Date,Returned, Fine)" & _
                                " VALUES('" & strIssueID & "', '" & strBookID & "', '" & strStudID & "', '" & patron & "', '" & strBorrowedDate & "', '" & _
                                strDuedate & "', NULL, '0', '0');", Conn)
        If strSection = "Reference" Then
            comm2 = New MySqlCommand("UPDATE STUDENT SET L_BOOK_ISSUED= '1'", Conn)
        ElseIf strSection = "Lendings" Then
            comm2 = New MySqlCommand("UPDATE STUDENT SET R_BOOK_ISSUED= '1'", Conn)
        End If

        Try
            'Insert Data into Issue table
            Conn.Open()
            comm.ExecuteNonQuery()
            Conn.Close()

            'Restricts the user to borrow another book from same section
            Conn.Open()
            comm2.ExecuteNonQuery()
            Conn.Close()


            lblIssueNo.Text = strIssueID
            lbl11.Text = lblIssueNo.Text
            lbl12.Text = strStudName
            lbl13.Text = strBookTitle
            lbl14.Text = patron
            lbl15.Text = strDuedate
            lbl00.Text = "Book Issued"
            lbl01.Text = "Issu Number :"
            lbl02.Text = "Student ID:"
            lbl03.Text = "Book ID :"
            lbl04.Text = "Patron :"
            lbl05.Text = "Due date :"
            pnlIssuedReturned.BringToFront()
            countdownTimer2.Start()
            Me.Refresh()
        Catch ex As Exception
            lbl00.Text = "Not allowed"
            pnlIssuedReturned.BringToFront()
            countdownTimer2.Start()
        End Try
        For Each s In {strBarCode, strBookID, strBookTitle, strBorrowedDate, strDuedate, strIssueID, strDuedate}
            s = Nothing
        Next
        intFine = intReturned = 0
        Conn.Close()
    End Sub

    'A borrowed book returned
    Public Sub ReturnBook()
        Dim daysLate As Integer
        Dim Duedate As Date

        Try
            Conn.Open()
            comm = New MySqlCommand("SELECT * FROM Issue_Book WHERE  accession_id= '" & strBookID & "';", Conn)
            Dim reader As MySqlDataReader = comm.ExecuteReader
            While reader.Read
                If reader(0) Is Nothing Then
                    BorrowBook()
                Else
                    lblIssueNo.Text = reader(0)
                    lbl1.Text = ":  " & reader(2).ToString
                    Duedate = reader("Due_date")
                    daysLate = Today.Subtract(Duedate).Days

                    If daysLate <= 0 Then
                        intFine = 0
                    Else
                        intFine = Val(reader(8).ToString) + daysLate * 2
                    End If

                    lbl11.Text = reader(2).ToString
                    lbl12.Text = reader(1).ToString
                    lbl13.Text = reader(5).ToString
                    lbl14.Text = "Rs: " & intFine & ".00"
                    lbl15.Text = ""
                    lbl00.Text = "Thank You for Returning."
                    lbl01.Text = "Student ID :"
                    lbl02.Text = "Accession ID :"
                    lbl03.Text = "Due Date :"
                    lbl04.Text = "Fine :"
                    lbl05.Text = ""

                    pnlIssuedReturned.BringToFront()
                    countdownTimer2.Start()
                End If

            End While

        Catch ex As Exception

        End Try

        Conn.Close()


        strSQL = ("UPDATE Issue_Book SET `Returned_Date`='" & Now.ToString("yyyy-MM-dd") & "',`Returned`='1',`Fine`= '" & intFine & "' WHERE StudentID='" & strStudID & "' OR Accession_ID = '" & strBookID & "'")
        comm = New MySqlCommand(strSQL, Conn)
        Try
            Conn.Open()
            comm.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Conn.Close()

        For Each s In {strBarCode, strBookID, strBookTitle, strBorrowedDate, strDuedate, strIssueID, strDuedate}
            s = Nothing
        Next
        intFine = intReturned = 0
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub countdownTimer2_Tick(sender As Object, e As EventArgs) Handles countdownTimer2.Tick
        If pgrIssueNotice.Value = 100 Then
            clearDetails()
            pnlMonitor.BringToFront()
            countdownTimer2.Stop()
            pgrIssueNotice.Value = 0
        Else
            pgrIssueNotice.PerformStep()
        End If
    End Sub

    Private Sub txtBarCodeInput_TextChanged(sender As Object, e As EventArgs) Handles txtBarCodeInput.TextChanged
        If txtBarCodeInput.Text Is Nothing Then
            lblGainFocus.Show()
        Else
            lblGainFocus.Hide()
        End If
    End Sub
End Class