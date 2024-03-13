Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine

Public Class frmReports
    Dim adp As MySqlDataAdapter
    Dim commString As String
    Dim comm, comm2 As MySqlCommand

    Private Sub frmReports_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub
    Private Sub frmReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Issue_bookTableAdapter.Fill(Me.LibrarydbDataSet.issue_book)

        Try
            Conn.Open()
            comm = New MySqlCommand("SELECT COUNT(*) FROM issue_book where returned = '1' ;", Conn)
            Dim sqlReader As MySqlDataReader = comm.ExecuteReader()
            While sqlReader.Read()
                lblReturnedBooks.Text = sqlReader(0)
            End While


        Catch ex As Exception

        End Try
        Conn.Close()

        Try
            Conn.Open()
            comm2 = New MySqlCommand("SELECT COUNT(*) FROM issue_book where returned = '0' ;", Conn)
            Dim sqlReader2 As MySqlDataReader = comm2.ExecuteReader()
            While sqlReader2.Read()
                lblOverDues.Text = sqlReader2(0)
            End While
        Catch ex As Exception

        End Try
        Conn.Close()

        Try
            chartLoad()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        lblTotal.Text = Val(lblReturnedBooks.Text) + Val(lblOverDues.Text)
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        frmRepView.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)
        frmMain.Show()
        Me.Close()
    End Sub


    Private Sub rbtnAllOverdues_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAllOverdues.CheckedChanged
        If rbtnAllOverdues.Checked Then
            commString = "Select * from Issue_book WHERE due_date < ' " & Now.ToString("yyyy-MM-dd") & "' AND RETURNED = '0';"
        End If

        Dim adp As New MySqlDataAdapter(commString, Conn)
        Dim dataTable As New DataTable
        Try
            Conn.Open()
            Me.LibrarydbDataSet.Clear()
            adp.Fill(Me.LibrarydbDataSet.issue_book)
        Catch ex As Exception

        End Try
        Conn.Close()
        Me.Refresh()
    End Sub

    Private Sub rbtnDate_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDate.CheckedChanged
        If rbtnDate.Checked Then
            dateByDate.Show()
        Else
            dateByDate.Hide()
        End If
    End Sub

    Private Sub chart_MouseHover(sender As Object, e As EventArgs) Handles chart.MouseHover
        chart.Dock = DockStyle.Fill
    End Sub

    Private Sub chart_MouseLeave(sender As Object, e As EventArgs) Handles chart.MouseLeave
        chart.Dock = DockStyle.None
    End Sub

    Private Sub dateByDate_ValueChanged(sender As Object, e As EventArgs) Handles dateByDate.ValueChanged
        If rbtnDate.Checked Then
            commString = "Select * from Issue_book WHERE due_date >= ' " & _
                dateByDate.Value.ToString("yyyy-MM-01") & "' and  due_date < ' " & _
                dateByDate.Value.ToString("yyyy-") & Val(dateByDate.Value.ToString("MM")) + 1 & _
                "' or borrowed_date >= ' " & _
                dateByDate.Value.ToString("yyyy-MM-01") & "' and  borrowed_date < ' " & _
                dateByDate.Value.ToString("yyyy-") & Val(dateByDate.Value.ToString("MM")) + 1 & "-01';"

            Dim adp As New MySqlDataAdapter(commString, Conn)
            Dim dataTable As New DataTable
            Try
                Conn.Open()
                Me.LibrarydbDataSet.Clear()
                adp.Fill(Me.LibrarydbDataSet.issue_book)
            Catch ex As Exception

            End Try
            Conn.Close()
            Me.Refresh()
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            commString = "Select * from Issue_book;"

            Dim adp As New MySqlDataAdapter(commString, Conn)
            Dim dataTable As New DataTable
            Try
                Conn.Open()
                Me.LibrarydbDataSet.Clear()
                adp.Fill(Me.LibrarydbDataSet.issue_book)
            Catch ex As Exception

            End Try
            Conn.Close()
            Me.Refresh()
        End If
    End Sub

    Private Sub chartLoad()
        Dim day As Date
        Dim strStat As String = ("Summary of this week's Book transactions.").ToUpper & vbNewLine & "_______________________________________________" & vbNewLine
        day = Now.AddDays(-6).ToString("yyyy-MM-dd")
        Dim ds As New DataSet
        Dim i As Integer = 6
        Conn.Open()
        While i >= 0
            Dim da1 As New MySqlDataAdapter("select * from issue_book where borrowed_date ='" & day.ToString("yyyy-MM-dd") & "';", Conn)
            Dim da2 As New MySqlDataAdapter("select * from issue_book where returned_date = '" & day.ToString("yyyy-MM-dd") & "';", Conn)

            da1.Fill(ds, "notreturned" & i)
            da2.Fill(ds, "returned" & i)

            strStat = strStat & "Day : " & day.ToString("yyyy-MMMM-dd  dddd") & vbNewLine & _
                "# Issued           :     " & Val(ds.Tables("notreturned" & i).Rows.Count) & vbNewLine & _
             "# Returned       :     " & Val(ds.Tables("returned" & i).Rows.Count) & vbNewLine & _
             "_______________________________________________" & vbNewLine

            chart.Series("Issued").Points.AddXY(day.ToString("yyyy-MM-dd"), Val(ds.Tables("notreturned" & i).Rows.Count))
            chart.Series("Returned").Points.AddXY(day.ToString("yyyy-MM-dd"), Val(ds.Tables("returned" & i).Rows.Count))
            i = i - 1
            day = Now.AddDays(-i).ToString("yyyy-MM-dd")
        End While
        lblStats.Text = strStat
        Conn.Close()
    End Sub

End Class