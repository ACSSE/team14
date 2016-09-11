
Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'If Session("Username") IsNot Nothing Then
        '    Response.Redirect("ClientProfile.aspx")
        'End If
        'If Not Page.IsPostBack Then
        '    If Session("UserName") IsNot Nothing Then
        '        Session("UserName") = Nothing
        '        Response.BufferOutput = True
        '        Response.Redirect("index.aspx")
        '    End If
        'End If


    End Sub

    Protected Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.ServerClick
        loginClient()
        LoginWorker()

    End Sub


    Public Sub loginClient()
        If Page.IsValid Then
            Dim user As String = txtUsername.Value
            Dim pass As String = txtPassword.Value

            Dim client As Client = New Client(user, pass)
           

            If client.getUsername IsNot "" Then
                Dim cUser As User = client
                Session("user") = cuser
                'Session("UserName") = user
                Response.Redirect("ClientProfile.aspx")
            End If
        End If
    End Sub

    Public Sub LoginWorker()
        If Page.IsValid Then
            Dim user As String = txtUsername.Value
            Dim pass As String = txtPassword.Value

            Dim worker As Worker = New Worker(user, pass)
            If worker.getUsername() IsNot "" Then
                Dim cUser As User = worker
                Session("user") = cUser
                'Session("UserName") = user
                Response.Redirect("WorkerProfile.aspx")
            End If
        End If
    End Sub

    'Public Function loginClient()
    '    If Page.IsValid Then
    '        Dim connection As SqlConnection
    '        Dim command As SqlCommand
    '        Dim reader As SqlDataReader
    '        Dim username As String = txtUsername.Value
    '        Dim password As String = Secrecy.HashPassword(txtPassword.Value)

    '        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
    '        command = New SqlCommand("SELECT * From LoginClient")

    '        command.CommandType = CommandType.Text
    '        command.Connection = connection

    '        Try
    '            command.Connection.Open()
    '            command.ExecuteNonQuery()
    '            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
    '            Dim found As Boolean = False

    '            If reader.HasRows Then

    '                While reader.Read

    '                    If reader("Password") = password And reader("UserName") = username Then
    '                        found = True

    '                    End If
    '                End While
    '            End If

    '            If found = True Then
    '                Session("UserName") = username
    '                Session("Browser") = Request.UserAgent.ToString


    '                Response.Redirect("ClientProfile.aspx")


    '            Else
    '                lblLogin.InnerText = "Invalid UserName or Password"
    '            End If

    '        Catch ex As Exception
    '            lblLogin.InnerText = "Couldn't login to the server"
    '        Finally
    '            command.Connection.Close()
    '            command.Dispose()
    '            connection.Dispose()
    '        End Try
    '    End If
    'End Function

    'Public Function loginWorker()
    '    If Page.IsValid Then
    '        Dim connection As SqlConnection
    '        Dim command As SqlCommand
    '        Dim reader As SqlDataReader
    '        Dim username As String = txtUsername.Value
    '        Dim password As String = Secrecy.HashPassword(txtPassword.Value)

    '        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
    '        command = New SqlCommand("SELECT * From LoginWorker")

    '        command.CommandType = CommandType.Text
    '        command.Connection = connection

    '        Try
    '            command.Connection.Open()
    '            command.ExecuteNonQuery()
    '            reader = command.ExecuteReader(CommandBehavior.CloseConnection)
    '            Dim found As Boolean = False

    '            If reader.HasRows Then

    '                While reader.Read

    '                    If reader("Password") = password And reader("UserName") = username Then
    '                        found = True

    '                    End If
    '                End While
    '            End If

    '            If found = True Then
    '                Session("UserName") = username
    '                Session("Browser") = Request.UserAgent.ToString


    '                Response.Redirect("WorkerProfile.aspx? UserName=" & Session("UserName"))

    '            Else
    '                lblLogin.InnerText = "Invalid UserName or Password"
    '            End If

    '        Catch ex As Exception
    '            lblLogin.InnerText = "Couldn't login to the server"
    '        Finally
    '            command.Connection.Close()
    '            command.Dispose()
    '            connection.Dispose()
    '        End Try
    '    End If

    'End Function

    ' Protected Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
    '    loginClient()
    '   loginWorker()
    'End Sub

End Class