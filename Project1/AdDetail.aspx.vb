Imports System.Data.SqlClient

Public Class AdDetail
    Inherits System.Web.UI.Page

    Private clientUsername As String = ""
    Private ad As Integer

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ad = Request.QueryString("ID")
        Dim isPersonalAd As String = Request.QueryString("personalAd")
        Dim adstring As String
        If isPersonalAd = "false" Then
            adstring = AdInfor(ad)
        Else
            adstring = AdpInfo(ad)
        End If

        ClientInfo.InnerHtml = ClientInfor(clientUsername)
        AdInfo.InnerHtml = adstring


    End Sub

    Private Function ClientInfor(user As String) As String
        Dim client As Client = New Client(user) 'getting partial client information

   

        Dim adString As String = ""

        adString &= "<h3>" & client.getName() & " " & client.getSurname() & "</h3>"
        adString &= "<div class=""itemtype"">"
        adString &= "<p class=""p-price"">Rating</p>"
        adString &= "	<h4><i><img src=""images/rate1.png"" alt="" "" /></i></h4>"
        adString &= "<div class=""clearfix""></div>"
        adString &= "</div>"




        Return adString

    End Function


    Private Function AdpInfo(adID As Integer)
        Dim pJobs() As Job = Session("personalJobs")

        Dim selectedJob As Job = Nothing   'From n In jobs
        'Where n.getID() = ad
        '                 Select n
        For i As Integer = 1 To pJobs.Length() - 1

            If pJobs(i).getID() = ad Then
                selectedJob = pJobs(i)
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
            clientUsername = selectedJob.getClient()
        End If
        adString &= "<hr/>"


        Return adString
    End Function

    Private Function AdInfor(adID As Integer) As String
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
            clientUsername = selectedJob.getClient()
        End If
        adString &= "<hr/>"


        Return adString
    End Function


    Protected Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.ServerClick
        Dim worker As Worker = Session("user")

        Dim adconnection As SqlConnection = New SqlConnection(ValidationClass.CONNECTIONSTRING)
        adconnection.Open()
        Dim query As String = "INSERT INTO Responses (AdID, Worker, Comment, Checked) VALUES (@ID, @Handyman, @comment, @check);"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@ID", ad)
        command.Parameters.AddWithValue("@Handyman", worker.getUsername())
        command.Parameters.AddWithValue("@comment", txtComment.Value())
        command.Parameters.AddWithValue("@check", "unchecked")

        Dim reader As SqlDataReader = command.ExecuteReader()
        adconnection.Close()

        Response.Redirect("WorkerProfile.aspx")
    End Sub

End Class