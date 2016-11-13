Imports System.Data.SqlClient

Public Class UserRemoved
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim user As String = Request.QueryString("username")
        Dim type As String = Request.QueryString("type")
        'MsgBox("type=" & type)
        Dim cuser As User

        If type = "client" Then
            'MsgBox("in client if-statement")
            'blockClient(user)
            cuser = New Client(user, True)
        Else
            'MsgBox("in else if-statement")
            'blockWorker(user)
            cuser = New Worker(user, True)
        End If
        cuser.updateStatus("BLOCKED") 'changing user to blocked
        cuser.updateUser() 'updating user
        divMes.InnerHtml = "<p>User " & cuser.getUsername() & " is now blocked</p>"
    End Sub

    Private Sub blockWorker(username As String)

        Dim connection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
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