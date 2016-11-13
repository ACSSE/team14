Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'error handing for incorrect login details
        errlabel.Visible = False
    End Sub

    Protected Sub btnLog_Click(sender As Object, e As EventArgs) Handles myBtn.ServerClick

        'Inside button
        Try 'to catch connection time out errors
            loginClient()
            LoginWorker()
            LoginAdmin()
        Catch ex As SqlException
            errlabel.Visible = True
            errlabel.Text = "Connection Failed"
        End Try
       
        errlabel.Visible = True

    End Sub


    Public Sub loginClient()
        If Page.IsValid Then
            Dim user As String = txtUsername.Value
            Dim pass As String = txtPassword.Value

            'MsgBox("Im in" &user)

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
            ' MsgBox("In worker")
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

        If Page.IsValid Then

            Dim user As String = txtUsername.Value
            Dim pass As String = txtPassword.Value

            Dim admin As cAdmin = New cAdmin(user, pass)
            If admin.getUsername() IsNot "" Then
                Dim cUser As User = admin
                Session("user") = cUser
                'Session("UserName") = user
                Response.Redirect("AdminPage.aspx")
            End If
        End If
    End Sub

End Class