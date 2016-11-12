﻿Imports System.Data.SqlClient

Public Class UserRemoved
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim user As String = Request.QueryString("username")

        Dim type As String = Request.QueryString("type")

        If type = "client" Then
            blockClient(user)
        Else
            blockWorker(user)
        End If

    End Sub

    Private Sub blockWorker(username As String)

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()

        Dim query As String = "UPDATE Workers SET Status = @blocked WHERE Username = @name"

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@blocked", "BLOCKED")
        command.Parameters.AddWithValue("@name", User)

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        connection.Close()

        divMes.InnerHtml = "<p>Worker " & username & "has been blocked </p>"
    End Sub

    Private Sub blockClient(username As String)

        Dim connection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        connection.Open()

        Dim query As String = "UPDATE Client SET Status = @blocked WHERE Username = @name"

        Dim command As SqlCommand = New SqlCommand(query, connection)
        command.Parameters.AddWithValue("@blocked", "BLOCKED")
        command.Parameters.AddWithValue("@name", User)

        Dim reader As SqlDataReader
        reader = command.ExecuteReader()

        connection.Close()

        divMes.InnerHtml = "<p>User " & username & "has been blocked </p>"
    End Sub

End Class