Imports System.Data
Imports System.Data.SqlClient
Public Class LoginWorker
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If Not Page.IsPostBack Then
        '    If Session("UserName") IsNot Nothing Then
        '        Session("UserName") = Nothing
        '        Response.BufferOutput = True
        '        Response.Redirect("index.aspx")
        '    End If
        'End If

       
    End Sub

    Protected Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.ServerClick
        If Page.IsValid Then
            Dim connection As SqlConnection
            Dim command As SqlCommand
            Dim reader As SqlDataReader
            Dim username As String = txtUsername.Value
            Dim password As String = Secrecy.HashPassword(txtPassword.Value)

            connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True")
            command = New SqlCommand("SELECT * From LoginWorker")

            command.CommandType = CommandType.Text
            command.Connection = connection

            Try
                command.Connection.Open()
                command.ExecuteNonQuery()
                reader = command.ExecuteReader(CommandBehavior.CloseConnection)
                Dim found As Boolean = False

                If reader.HasRows Then

                    While reader.Read

                        If reader("Password") = password And reader("UserName") = username Then
                            found = True

                        End If
                    End While
                End If

                If found = True Then
                    Session("UserName") = username
                    Session("Browser") = Request.UserAgent.ToString
                   


                Else
                    lblLogin.InnerText = "Invalid UserName or Password"
                End If

            Catch ex As Exception
                lblLogin.InnerText = "Couldn't login to the server"
            Finally
                command.Connection.Close()
                command.Dispose()
                connection.Dispose()
            End Try
        End If

        Response.Redirect("WorkerProfile.aspx? UserName=" & Session("UserName"))
    End Sub

End Class