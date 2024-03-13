Imports MySql.Data.MySqlClient

Public Class frmBooks
    Dim column As String
    Dim DataAdpt As New MySqlDataAdapter("Select * from Book;", Conn)
    Dim ds As New DataSet
    Dim lastID, section, shelf, availble As String
    Dim copies As Integer

    Private Sub frmBooks_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub

    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ShelfTableAdapter.Fill(Me.LibraryDB1.shelf)
        Conn.Open()
        DataAdpt.Fill(Me.LibraryDB1.book)
        Conn.Close()
        gridBooks_Click(sender, e)
    End Sub

    'Search by wildcard 

    Private Sub cmbDataField_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDataField.SelectedIndexChanged
        If cmbDataField.Text = "Accession ID" Then
            column = "Accession ID"
        ElseIf cmbDataField.Text = "ISBN" Then
            column = "ISBN"
        ElseIf cmbDataField.Text = "Title" Then
            column = "TITLE"
        ElseIf cmbDataField.Text = "Author" Then
            column = "AUTHOR"
        Else
            column = "TITLE"
        End If

        If Not txtBookSearch.Text Is Nothing Then
            LibraryDB1.book.Clear()
            Conn.Open()
            Dim adp As New MySqlDataAdapter("Select * from Book WHERE " & column & " LIKE '%" & txtBookSearch.Text & "%';", Conn)
            adp.Fill(Me.LibraryDB1.book)

        End If
        Conn.Close()
        Me.Refresh()
    End Sub

    Private Sub txtBookSearch_TextChanged(sender As Object, e As EventArgs) Handles txtBookSearch.TextChanged
        If Not txtBookSearch.Text Is "Search Here" Then
            cmbDataField_SelectedIndexChanged(sender, e)
        End If
    End Sub

    Private Sub txtBookSearch_MouseClick(sender As Object, e As MouseEventArgs) Handles txtBookSearch.MouseClick
        txtBookSearch.Clear()
    End Sub


    'Update Book Details

    Private Sub btnUpdateMem_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If btnUpdate.Text = "Save" Then
            gridBooks.Enabled = True
            pnlDetails2.Enabled = False
            btnUpdate.Text = "Update Details"
            btnNewBook.Text = "Add New Book"
            section = cmbSection.Text
            shelf = cmbShelf.SelectedValue
            If chkAvailable.Checked Then
                availble = "1"
            Else
                availble = "0"
            End If
            If copies < Val(txtCopies.Text) Then
                setAccessionID(Val(txtCopies.Text) - copies)
            End If
            If copies <= Val(txtCopies.Text) Then
                Try
                    Conn.Open()
                    Dim comm As New MySqlCommand("UPDATE `BOOK`  SET `Title`='" & txtTitle.Text & "',`Copies`='" & txtCopies.Text & _
                                                   "',`Price`='" & txtPrice.Text & "',`Section`='" & section & _
                                                   "',`Author`='" & txtAuthor.Text & "',`Edition`='" & txtEdition.Text & _
                                                   "',`Shelf_ID`='" & shelf & "',`Available`='" & availble & "' " & _
                                                   " WHERE `ISBN`= '" & txtISBN.Text & "';", Conn)
                    comm.ExecuteNonQuery()
                    DataAdpt.Update(Me.LibraryDB1.book)
                    Me.LibraryDB1.book_ascn.Clear()
                    DataAdpt.Fill(Me.LibraryDB1.book)

                    MsgBox("Data Updated")

                    gridBooks.Enabled = True
                    pnlDetails2.Enabled = False
                    btnUpdate.Text = "Update Details"

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
                Refresh()
            Else
                MsgBox("You have already inserted " & copies & " copies of this book")

            End If


        ElseIf btnUpdate.Text = "Cancel" Then
            Conn.Close()
            LibraryDB1.book.Clear()
            DataAdpt.Fill(LibraryDB1.book)
            gridBooks.Enabled = True
            gridAscnID.Enabled = True
            pnlDetails2.Enabled = False
            btnNewBook.Text = "Add New Book"
            btnUpdate.Text = "Update Details"
            Me.Refresh()
        Else
            gridBooks.Enabled = False
            pnlDetails2.Enabled = True
            btnUpdate.Text = "Save"
            btnNewBook.Text = "Cancel"

        End If
        Conn.Close()
        Me.Refresh()
    End Sub


    'Get the Accession ID to calculate accession ID and add all the copies one by one with a unique AccessionID

    Private Sub setAccessionID(j As Integer)

        Dim i As Integer
        If j > 0 Then
            i = j
        Else
            i = Val(txtCopies.Text)
        End If
        Try
            Conn.Open()
            Dim comm As New MySqlCommand("SELECT COUNT(*) FROM book_ascn;", Conn)
            Dim sqlReader As MySqlDataReader = comm.ExecuteReader()
            While sqlReader.Read()
                lastID = Val(sqlReader(0).ToString) + 10000
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()

        For x As Integer = 0 To i - 1 Step +1
            lastID = lastID + 1

            Try
                Conn.Open()
                Dim comm As New MySqlCommand("INSERT INTO BOOK_ASCN VALUES('BK" & lastID & "','" & txtISBN.Text & "','0');", Conn)
                comm.ExecuteNonQuery()
                Conn.Close()
            Catch ex As Exception

            End Try
        Next

    End Sub

    'Insert A New Book

    Private Sub btnNewBook_Click(sender As Object, e As EventArgs) Handles btnNewBook.Click
        Conn.Close()
        If btnNewBook.Text = "Add New Book" Then
            pnlDetails2.Enabled = True
            gridBooks.Enabled = False
            gridAscnID.Enabled = False
            txtTitle.Focus()
            btnNewBook.Text = "Save"
            btnUpdate.Text = "Cancel"
            For Each txt In {txtCopies, txtAuthor, txtEdition, txtISBN, txtPrice, txtTitle}
                txt.Clear()
                txt.Enabled = True
            Next


        ElseIf btnNewBook.Text = "Cancel" Then
            Conn.Close()
            DataAdpt.Update(LibraryDB1.book)
            gridBooks.Enabled = True
            pnlDetails2.Enabled = False
            gridAscnID.Enabled = True
            btnNewBook.Text = "Add New Book"
            btnUpdate.Text = "Update Details"

        Else
            Try
                Conn.Open()
                section = cmbSection.Text
                shelf = cmbShelf.SelectedValue
                Dim comm As New MySqlCommand("INSERT INTO `book`(`Copies`, `Title`, `ISBN`, `Price`, `Section`, `Author`, `Edition`, `Shelf_ID`, `Available`)" & _
                                              " VALUES ('" & txtCopies.Text & "','" & txtTitle.Text & "','" & txtISBN.Text & "','" & txtPrice.Text & _
                                              "','" & cmbSection.Text & "','" & txtAuthor.Text & "','" & txtEdition.Text & "','" & _
                                              shelf & "','1');", Conn)
                comm.ExecuteNonQuery()
                Conn.Close()

                setAccessionID(0)
                Me.LibraryDB1.book.Clear()
                DataAdpt.Fill(Me.LibraryDB1.book)
                btnNewBook.Text = "Add New Book"
                pnlDetails2.Enabled = False
                gridBooks.Enabled = True
                gridAscnID.Enabled = True
                btnUpdate.Text = "Update Details"
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
        Me.Refresh()
    End Sub

    Private Sub chkAvailable_CheckedChanged(sender As Object, e As EventArgs) Handles chkAvailable.CheckedChanged
        If chkAvailable.Checked Then
            pbxAvailable.Image = My.Resources.activeBook
        Else
            pbxAvailable.Image = My.Resources.inactiveBook
        End If
    End Sub

   
    Private Sub cmbSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSection.SelectedIndexChanged
        section = cmbSection.ValueMember
    End Sub

    Private Sub cmbShelf_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbShelf.SelectedIndexChanged
        shelf = cmbShelf.ValueMember
    End Sub
    Private Sub gridBooks_Click(sender As Object, e As EventArgs) Handles gridBooks.Click
        If Not txtISBN.Text = Nothing Then
            Dim da As New MySqlDataAdapter("Select * from book_ascn where isbn= '" & txtISBN.Text & "'", Conn)
            Dim da2 As New MySqlDataAdapter("Select notes from book where isbn= '" & txtISBN.Text & "';", Conn)
            Conn.Open()
            Try
                ds.Clear()
                da2.Fill(ds, 0)
                If ds.Tables(0).Rows.Count > 0 Then
                    txtNotes.Text = ds.Tables(0).Rows(0).Item(0)
                Else
                    txtNotes.Text = "Add a note......"
                End If

            Catch ex As Exception
                MsgBox("notes" & ex.Message)
            End Try

            Me.LibraryDB1.book_ascn.Clear()
            da.Fill(LibraryDB1.book_ascn)
            copies = LibraryDB1.book_ascn.Rows.Count
            Conn.Close()
        Else
            Me.LibraryDB1.book_ascn.Clear()
        End If

    End Sub

    Private Sub btnAddNote_Click(sender As Object, e As EventArgs) Handles btnAddNote.Click
        Dim comm As New MySqlCommand("UPDATE `BOOK`  SET `Notes`='" & txtNotes.Text & vbNewLine & _
                                     Now.ToString("- yyyy/MM/dd") & "' where isbn = '" & txtISBN.Text & "';", Conn)
        Try
            Conn.Open()
            comm.ExecuteNonQuery()
            MsgBox("Note Added.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Private Sub txtNotes_TextChanged(sender As Object, e As EventArgs) Handles txtNotes.TextChanged
        If txtNotes.Text = "Add a note......" Then
            txtNotes.Clear()
        Else
            txtNotes.Focus()
        End If
    End Sub

End Class