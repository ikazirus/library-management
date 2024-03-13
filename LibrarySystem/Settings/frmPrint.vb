Imports CrystalDecisions.CrystalReports.Engine
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class frmPrint
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
        Me.Book_ascnTableAdapter.Fill(Me.LibraryDB.book_ascn)
        Me.StudentTableAdapter.Fill(Me.LibraryDB.student)
    End Sub

    Private Sub btnPrintBookID_Click(sender As Object, e As EventArgs) Handles btnPrintBookID.Click
        rpt.Load(Environment.CurrentDirectory & "\Reports\printBCBook.rpt")

        Dim intFrom As Integer = (Val(cmbFrom.SelectedValue.ToString.Substring(2)))
        Dim intTo As Integer = (Val(cmbTo.SelectedValue.ToString.Substring(2)))
        Dim intLength As Integer
        If intFrom <= intTo Then
            intLength = intTo - intFrom
        Else
            intLength = intFrom - intTo
            intFrom = intTo
        End If

        Dim da1 As New MySqlDataAdapter("Select * from book_ascn order by Asseccion_ID asc limit " & intFrom - 10001 & "," & intLength + 1 & ";", Conn)
        Dim da2 As New MySqlDataAdapter("Select * from book", Conn)
        Try
            Conn.Open()
            ds1.Clear()
            da2.Fill(ds1, "book")
            da1.Fill(ds1, "book_ascn")
            Conn.Close()
            If ds1.Tables(0).Rows.Count > 0 Then
                rpt.SetDataSource(ds1)
                crv1.ReportSource = rpt
            Else
                MsgBox("Select books in a valid range.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Private Sub btnPrintMemID_Click(sender As Object, e As EventArgs) Handles btnPrintMemID.Click
        rpt.Load(Environment.CurrentDirectory & "\Reports\printBCMEM.rpt")


        Dim da2 As New MySqlDataAdapter("Select * from student where StudentID between " & cmbFromM.SelectedValue.ToString & " and " & cmbToM.SelectedValue.ToString & ";", Conn)
        Try
            Conn.Open()
            ds2.Clear()
            da2.Fill(ds2, "student")
            Conn.Close()
            If ds2.Tables(0).Rows.Count > 0 Then
                rpt.SetDataSource(ds2)
                crv2.ReportSource = rpt
            Else
                MsgBox("Select Student IDs in a valid range.")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


  
End Class