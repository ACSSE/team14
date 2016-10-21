Public Class workerStat1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim currentDate As Date = Date.Now
        Dim currentHour As Integer = TimeOfDay.Hour
        Dim currentMinutes As Integer = TimeOfDay.Minute

        Dim type As String = Request.QueryString("type")
        Dim Worker As Worker = New Worker(username)

        If type = "client" Then
            Dim username As String = Request.QueryString("username")



            divrating.InnerHtml = "<h4>Rating</h4>" & ValidationClass.getRateImage(Worker.getRating())

            lblHour.InnerText = currentHour
            lblMinute.InnerText = currentMinutes
            lblDate.InnerText = currentDate
            JobTitle.InnerText = Worker.getCategory() 'setting the correct heading category
            lblRegion.InnerText = Worker.getRegion()
            lblName.InnerText = Worker.getName()
            lblSurname.InnerHtml = Worker.getSurname()
            lblNumber.InnerText = Worker.getNumbers()
            lblEmail.InnerText = Worker.getEmail()
            lblRegion.InnerText = Worker.getRegion()
            personalAd.InnerHtml = "<a href=""PostAdClient.aspx?adType=" & Worker.getUsername() & """>" & "Post an ad to " & Worker.getUsername() & "</a>"
            getHistory() ' to display all the previous work done by the worker

        Else
            Dim c As User = Session("user")
            Worker = c



            lblRegion.Visible = True
            lblName.Visible = True
            lblSurname.Visible = True
            lblNumber.Visible = True
            lblEmail.Visible = True

            divrating.InnerHtml = "<h3>Rating</h3>" & ValidationClass.getRateImage(Worker.getRating())

            JobTitle.InnerText = Worker.getCategory() 'setting the correct heading category
            lblRegion.InnerText = Worker.getRegion()
            lblName.InnerText = Worker.getName()
            lblSurname.InnerHtml = Worker.getSurname()
            lblNumber.InnerText = Worker.getNumbers()
            lblEmail.InnerText = Worker.getEmail()

            personalJobs.InnerHtml = displayPersonalJobs()
            myJobs.InnerHtml = displayJobs()
            JobNots.InnerHtml = displayJobs(Worker.getCategory())
            penJobs.InnerHtml = displayPendingJobs()
            getHistory() ' to display all the previous work done by the worker
        End If


    End Sub

End Class