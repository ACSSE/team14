Imports System.Data.SqlClient
Public Class WorkerProfile
    Inherits System.Web.UI.Page

    Private worker As Worker

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      

        Dim c As User = Session("user")
        worker = c



        lblRegion.Visible = True
        lblName.Visible = True
        lblSurname.Visible = True
        lblNumber.Visible = True
        lblEmail.Visible = True

        divrating.InnerHtml = "<h4>Rating</h4>" & ValidationClass.getRateImage(worker.getRating())

        JobTitle.InnerText = worker.getCategory() 'setting the correct heading category
        lblRegion.InnerText = worker.getRegion()
        lblName.InnerText = worker.getName()
        lblSurname.InnerHtml = worker.getSurname()
        lblNumber.InnerText = worker.getNumbers()
        lblEmail.InnerText = worker.getEmail()

        myJobs.InnerHtml = displayJobs()
        JobNots.InnerHtml = displayJobs(worker.getCategory())
        penJobs.InnerHtml = displayPendingJobs()
        getHistory() ' to display all the previous work done by the worker
    End Sub

    Private Function displayJobs() As String 'display jobs that the handyman has already accepted or is working on
        Dim size As Integer
        Dim HandymanJobs(size) As Job

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Worker = @name AND Status IS NULL"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = "<h3>My Jobs</h3> <br/>"

        Dim tempJob As Job ' to use as holder

        If reader.HasRows Then
            Dim clientUsername As String = ""
            Dim ID As Integer = 0
            Dim title As String = ""
            Dim description As String = ""
            Dim category As String = ""
            While reader.Read() 'getting all the jobs
                size += 1
                ReDim Preserve HandymanJobs(size)

                clientUsername = reader("Client")
                ID = reader("PostAdId")
                title = reader("AdTitle")
                description = reader("AdDescription")
                category = reader("Category")

                
                tempJob = New Job(ID, category, title, description, clientUsername, "")
                HandymanJobs(size) = tempJob 'adding job to the list
                'TO DO Build messaging service here
                notifications &= "<h5>" & reader("AdTitle") & "</h5> "
                notifications &= ValidationClass.displayMessenges(ID) & "<hr/>" 'displays all the messsenges sent for this particular job
                notifications &= "<a href=""generateQuotation.aspx""> Generate Quotation </a>"

            End While
        End If
        Return notifications
    End Function

    Private Function displayJobs(categroy As String) As String 'displays jobs that have not been taken
        Session("jobs") = Nothing

        Dim size As Integer = 0 'for resizing purposes
        Dim jobs(size) As Job 'array for jobs to be stored

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE Worker IS NULL"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        'NOTE TO SELF: use sql to get all the categories on a proper sql statement


        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = "<h3>New Jobs</h3> <br/>"

        Dim tempJob As Job ' to use as holder

        If reader.HasRows Then
            Dim clientUsername As String = ""
            Dim ID As Integer = 0
            Dim title As String = ""
            Dim description As String = ""
            Dim category As String = ""

            While reader.Read() 'getting all the jobs
                

                clientUsername = reader("Client")
                ID = reader("PostAdId")
                title = reader("AdTitle")
                description = reader("AdDescription")
                category = reader("Category")


                If worker.getCategory().Contains(category) Then
                    If shouldADD(ID) Then
                        size += 1
                        ReDim Preserve jobs(size)
                        tempJob = New Job(ID, category, title, description, clientUsername, "")
                        jobs(size) = tempJob 'adding job to the list

                        notifications &= "<a href= AdDetail.aspx?ID=" & jobs(size).getID() & ">" & reader("AdTitle") & "</a> <br />"
                    End If
                End If

            End While
        End If
        Session("jobs") = jobs

        Return notifications
    End Function

    Private Function displayPendingJobs() As String

        Dim size As Integer = 0 'for resizing purposes
        Dim jobsID(size) As Integer 'array for job idS to be stored

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM Ratings WHERE Worker = @name AND Pending = @true;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())
        command.Parameters.AddWithValue("@true", "true")

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = "<h3>Closed Jobs</h3> <br/>"

        If reader.HasRows Then
         

            While reader.Read() 'getting all the job IDs from pending jobs
                size += 1
                ReDim Preserve jobsID(size)
                jobsID(size) = reader("JobID") 'adding job ID to the list

            End While
        End If

        adconnection.Close()

        Dim idx As Integer = 0 'to keep track of the number of jobs
        Dim jobs(idx) As Job ' pending jobs to be displayed

        For i As Integer = 1 To size
            idx += 1 'increasing the number of jobs
            ReDim Preserve jobs(idx) 'increasing container
            jobs(idx) = createJob(jobsID(idx))

            If jobs(idx) IsNot Nothing Then
                notifications &= "<h5>" & jobs(idx).getTitle() & "</h5> "
                notifications &= "<a href=RatingHandyMan.aspx?Client=" & jobs(idx).getClient() & "&adID=" & jobs(idx).getID() & ">Rate Client</a> <br/>" 'displays all the messsenges sent for this particular job

            End If
        Next i
        Return notifications
    End Function

    Public Function createJob(ID As Integer) As Job


        Dim cJob As Job = Nothing 'variable to be returned

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE PostAdId = @ID"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@ID", ID) 'job I want created

        'Varaibles for the job
        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            reader.Read()
            Dim title As String = reader("AdTitle")
            Dim description As String = reader("AdDescription")
            Dim category As String = reader("Category")
            Dim client As String = reader("Client")
            Dim worker As String = reader("Worker")

            cJob = New Job(ID, category, title, description, client, worker)
        End If

        adconnection.Close()

        Return cJob

    End Function

    Private Function shouldADD(JobID As Integer) As Boolean
        'Jobs that the handyman has already answerede should not be displayed

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM Responses WHERE AdID = @name AND Worker = @worker"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", JobID)
        command.Parameters.AddWithValue("@worker", worker.getUsername())

        Dim reader As SqlDataReader = command.ExecuteReader()

        If reader.HasRows Then
            ' MsgBox("WorkerProfile:shouldADD() - reader has rows, returns true")
            adconnection.Close()
            Return False 'If there is already a response than the job should not be shown
        End If


        ' MsgBox("WorkerProfile:shouldADD() - reader has no rows, returns false")
        adconnection.Close()
        Return True 'job shown if there was no response made by handyman
    End Function


    Private Sub getHistory()
        Dim size As Integer = 0
        Dim IDs(size) As Integer
        Dim comments(size) As String


        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM Ratings WHERE Worker = @name AND Pending = @true;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)

        command.Parameters.AddWithValue("@name", worker.getUsername())
        command.Parameters.AddWithValue("@true", "false")

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim notifications As String = ""

        If reader.HasRows Then
            reader.Read()
            size += 1
            ReDim Preserve IDs(size)
            ReDim Preserve comments(size)
            IDs(size) = reader("JobID") 'GET ALL THE JOB IDs    
            comments(size) = reader("Comments")
        End If

        Dim client1 As Client = Nothing
        Dim client2 As Client = Nothing

        'Binding values to the clients
        If size <= 1 Then
            client1 = getHistoryClientFromJobsInfo(IDs(size))
        Else
            client1 = getHistoryClientFromJobsInfo(IDs(size))
            client2 = getHistoryClientFromJobsInfo(IDs(size - 1))
        End If



        Dim html As String = ""

        If size > 1 Then
            'first client history and comments
            html &= "<div class=""col-md-6 happy-clients-grid wow bounceIn"" data-wow-delay=""0.4s"">"
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size) & "</p>"
            html &= "<h4><a href=""#"">" & client1.getName() & " " & client1.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"

            'second client history and comments
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size - 1) & "</p>"
            html &= "<h4><a href=""#"">" & client2.getName() & " " & client2.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"

        ElseIf size = 1 Then
            html &= "<div class=""col-md-6 happy-clients-grid wow bounceIn"" data-wow-delay=""0.4s"">"
            html &= "<div class=""client"">"
            html &= "<img src=""images/client_1.jpg"" alt="""" />"
            html &= "</div>"
            html &= "<div class=""client-info"">"
            html &= "<p>" & comments(size) & "</p>"
            html &= "<h4><a href=""#"">" & client1.getName() & " " & client1.getSurname() & "</a><p> <i class=""glyphicon glyphicon-map-marker""></i><a href=""#"">Gauteng</a>, <a href=""#"">Edenvale</a></p></h4>"
            html &= "</div>"
            html &= "<div class=""clearfix""></div>"
            html &= "</div>"
        Else
            html &= ""
        End If

        divHistory.InnerHtml = html
    End Sub

    Public Function getHistoryClientFromJobsInfo(JobID As Integer) As Client

        Dim adconnection As SqlConnection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\HandymanDatabase.mdf;Integrated Security=True")
        adconnection.Open()
        Dim query As String = "Select * FROM AdTable WHERE PostAdId = @name;"
        Dim command As SqlCommand = New SqlCommand(query, adconnection)
        command.Parameters.AddWithValue("@name", JobID)

        Dim reader As SqlDataReader = command.ExecuteReader()

        Dim client As Client = Nothing

        If reader.HasRows Then
            reader.Read()
            Dim username As String = reader("Client")
            client = New Client(username)
        End If

        Return client

    End Function

    Public Function getCategoriesSqlStatement(list As String) As String
        Dim categorySQL As String = ""
        Dim tempVal As String = ""

        'NOTE TO SELF: FIND OUT HOW TO SPLIT STRINGS

        Return categorySQL
    End Function

End Class