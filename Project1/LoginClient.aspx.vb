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
        LoginAdmin() 'return of johnney v
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

    Public Sub LoginAdmin()
        Dim user As String = txtUsername.Value
        Dim pass As String = txtPassword.Value

        'If Not (user = "") Or Not (pass = "") Then
        '    Dim admin As cAdmin = New cAdmin(user, pass)
        '    If admin.getUsername() IsNot "" Then
        '        Dim cUser As User = admin
        '        Session("user") = cUser
        '        Response.Redirect("AdminPage.aspx")
        '    End If
        'End If
    End Sub

   
End Class