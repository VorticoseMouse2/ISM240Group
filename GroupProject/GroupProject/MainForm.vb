﻿Imports MySql.Data.MySqlClient

Public Class MainForm
    Dim frmTransactionMode As New TransactionForm
    Dim frmInventoryManager As New InventoryForm
    Public Shared mySQLConnection As New MySqlConnection

    Private Sub btnTransactionMode_Click(sender As Object, e As EventArgs) Handles btnTransactionMode.Click
        Me.Hide() 'hide base form 
        frmTransactionMode.ShowDialog() 'show new form
        Me.Show() 'when new form is closed show origional form
    End Sub

    Private Sub btnInventoryManager_Click(sender As Object, e As EventArgs) Handles btnInventoryManager.Click
        Me.Hide()
        frmInventoryManager.ShowDialog()
        Me.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine("Form LOADED!")
        'initialize things here

        ConnectToDB("visual", "")
    End Sub

    Private Sub Form_Unload(sender As Object, e As EventArgs) Handles Me.Closing
        mySQLConnection.Close()
    End Sub

    Private Sub ConnectToDB(uname As String, pword As String)
        Dim DatabaseName As String = "ism240"
        Dim ServerUrl As String = "vortimoosegames.ddns.net"
        Dim Username As String = uname
        Dim Password As String = pword 'DO NOT FOR THE LOVE OF GOD TOUCH ANY OF THESE DIMS THEY ARE IMPORTANT

        If Not mySQLConnection Is Nothing Then mySQLConnection.Close()

        mySQLConnection.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", ServerUrl, Username, Password, DatabaseName)
        Try
            mySQLConnection.Open()
            Console.WriteLine("CONNECTED TO DB!!!")
        Catch ex As Exception
            Console.WriteLine("Could not connect to DB" + ex.ToString())
        End Try


    End Sub

    'take in sql command and retrun the data
    Public Function ExecuteQueryWithReturn(query As String)
        Dim sqlQuery As New MySqlCommand(query, mySQLConnection)
        Dim sqlReader As MySqlDataReader = sqlQuery.ExecuteReader()

        Return sqlReader
        sqlReader.Close()
    End Function

    'take in sql command and retrun the data
    Public Function ExecuteQuery(query As String)
        Dim sqlQuery As New MySqlCommand(query, mySQLConnection)
        sqlQuery.ExecuteNonQuery()
    End Function
End Class
