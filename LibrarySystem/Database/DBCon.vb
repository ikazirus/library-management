﻿Imports MySql.Data.MySqlClient

Module DBCon
    Public server As String = "127.0.0.1"
    Public userId As String = "user"
    Public password As String = ""
    Public database As String = "librarydb"
    Public Conn As New MySqlConnection With {.ConnectionString = String.Format("server={0};user id ={1};password={2};database={3};pooling=false;", server, userId, password, database)}

    Public Sub Connect()
        Try
            'This is to try to establish the connection with database
            Conn.Open()
            frmMain.lblStatus.Text = (":: DATABASE CONNECTED ::")
        Catch ex As Exception
            'if the connection failed a form will show up and get correct parameters discarding the current parameters
            frmMain.lblStatus.Text = (":: DATABASE CONNECTION FAILED ::" & ex.Message)
            Dim frmDBconfig As New frmDBconfig
            frmDBconfig.Show()
        End Try
        Conn.Close()
    End Sub
End Module
