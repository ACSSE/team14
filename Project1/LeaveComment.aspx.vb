<<<<<<< HEAD
﻿Imports System.Data
Imports System.Data.SqlClient
Public Class LeaveComment

    Inherits System.Web.UI.Page
    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtComment.Focus()
        End If
    End Sub

    'Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmit.ServerClick

    '    If Page.IsValid Then
    '        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anna\Desktop\Project\Project1\Project1\App_Data\Data.mdf;Integrated Security=True")

    '        Dim userExist As SqlCommand = New SqlCommand("SELECT * FROM Comment WHERE CommentId = @com")
    '        userExist.Parameters.AddWithValue("@com", txtComment.InnerText)

    '        userExist.Connection = connection
    '        connection.Open()

    '        reader = userExist.ExecuteReader(CommandBehavior.CloseConnection)

    '        If reader.HasRows Then

    '            userExist.Dispose()
    '            reader.Close()
    '        Else
    '            userExist.Dispose()
    '            reader.Close()



    '            command = New SqlCommand("INSERT INTO Comment (CommentId) VALUES (@com")
    '            command.Parameters.AddWithValue("@com", txtComment.InnerText)

    '            command.Connection = connection
    '            connection.Open()
    '            command.ExecuteNonQuery()

    '            'Response.Redirect("ClientProfile1.aspx")

    '            command.Connection.Close()
    '            command.Dispose()
    '            connection.Dispose()

    '        End If
    '    End If


    'End Sub

=======
﻿Imports System.Data
Imports System.Data.SqlClient
Public Class LeaveComment

    Inherits System.Web.UI.Page
    Private connection As SqlConnection
    Private command As SqlCommand
    Private reader As SqlDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            txtComment.Focus()
        End If
    End Sub

    'Protected Sub btnReg_Click(sender As Object, e As EventArgs) Handles btnSubmit.ServerClick

    '    If Page.IsValid Then
    '        connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Anna\Desktop\Project\Project1\Project1\App_Data\Data.mdf;Integrated Security=True")

    '        Dim userExist As SqlCommand = New SqlCommand("SELECT * FROM Comment WHERE CommentId = @com")
    '        userExist.Parameters.AddWithValue("@com", txtComment.InnerText)

    '        userExist.Connection = connection
    '        connection.Open()

    '        reader = userExist.ExecuteReader(CommandBehavior.CloseConnection)

    '        If reader.HasRows Then

    '            userExist.Dispose()
    '            reader.Close()
    '        Else
    '            userExist.Dispose()
    '            reader.Close()



    '            command = New SqlCommand("INSERT INTO Comment (CommentId) VALUES (@com")
    '            command.Parameters.AddWithValue("@com", txtComment.InnerText)

    '            command.Connection = connection
    '            connection.Open()
    '            command.ExecuteNonQuery()

    '            'Response.Redirect("ClientProfile1.aspx")

    '            command.Connection.Close()
    '            command.Dispose()
    '            connection.Dispose()

    '        End If
    '    End If


    'End Sub

>>>>>>> 3924db60ce15290221df9b838aeba9dff3fe785d
End Class