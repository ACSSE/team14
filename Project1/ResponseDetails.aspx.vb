Imports System.Data.SqlClient

Public Class ResponseDetails
    Inherits System.Web.UI.Page

    Private Workername As String = ""
    Private ad As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ad = Request.QueryString("ID")
        Dim user As User = Session("user") 'to access user's name
        Workername = Request.QueryString("workername")

        handymanDet.InnerText = " Communication with " & Workername


        Dim adstring As String = AdInfor(ad)
        AdInfo.InnerHtml = adstring

        'fixing messeges section

        Dim messenges As MessengeList = New MessengeList(ad, Workername)

        Dim html As String = "" 'HTML string to be put in div tag
        If Not (messenges.getSize() = 0) Then 'If there are messenges
            For i As Integer = 1 To messenges.getSize()
                'to do didsplay messenges in div tag on the page  
                Dim messenge As Messenge = messenges.getMessage(i)

                If messenge.getSender() = user.getUsername() Then 'should appear in different colours
                    html &= "<p style=""background-color:yellow;  margin-right: 400px; margin-left: 150px;""> " & messenge.getMessageInfo() & "</p><br />"
                Else
                    html &= "<p style=""background-color:lightgreen;  margin-right: 600px;"">" & messenge.getMessageInfo() & "</p><br /><br/><br/>"
                End If
            Next i
        End If
        messagesHistory.InnerHtml = html
    End Sub

    Private Function AdInfor(adID As Integer) As String
        'NOTE TO SELF: use jobs from Session("jobs") with LINQ to get the right one
        Dim jobs() As Job = Session("jobs")
        'getting correct job from list carried in Session("jobs")
        Dim selectedJob As Job = Nothing   'From n In jobs
        'Where n.getID() = ad
        '                 Select n
        For i As Integer = 1 To jobs.Length() - 1

            If jobs(i).getID() = ad Then
                selectedJob = jobs(i)
            End If
        Next

        Dim adString As String = "<hr/>"

        'displaying ad details
        If selectedJob IsNot Nothing Then
            AdHeading.InnerText = selectedJob.getTitle()
            'adString &= "<h1 class=""head"">" & selectedJob.getTitle() & "</h1> <br />"
            adString &= "<h3 class=""inline"">Category: </h3> " & "<p class=""inline"">" & selectedJob.getCategory() & "</p>" & " <br />"
            adString &= "<h3>Description: </h3>"
            adString &= "<p>" & selectedJob.getDescription() & "</p>"
            ' clientUsername = selectedJob.getClient()
        End If
        adString &= "<hr/>"


        Return adString
    End Function

    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.ServerClick
        Dim worker As Client = Session("user")

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "INSERT INTO ResponsesMesseges (PostAdId, Worker, Messege) VALUES (@ID, @Handyman, @messege);"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@ID", ad)
        command.Parameters.AddWithValue("@Handyman", Workername)
        command.Parameters.AddWithValue("@messege", txtComment.Value())

        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()

        Response.Redirect("ClientProfile.aspx")
    End Sub
End Class